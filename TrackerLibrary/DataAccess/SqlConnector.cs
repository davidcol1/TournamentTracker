using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Model;

namespace TrackerLibrary.DataAccess
{
  public class SqlConnector : IDataConnection
  {
    private const string db = "Tournaments";

    public PersonModel CreatePerson(PersonModel model)
    {
      using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
      {
        var p = new DynamicParameters();
        p.Add("@FirstName", model.FirstName);
        p.Add("@LastName", model.LastName);
        p.Add("@EmailAddress", model.EmailAddress);
        p.Add("@CellPhoneNumber", model.CellPhoneNumber);
        p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

        connection.Execute("spPeople_Insert", p, commandType: CommandType.StoredProcedure);

        model.Id = p.Get<int>("@id");

        return model;
      }
    }

    /// <summary>
    /// Saves a new prize to the database.
    /// </summary>
    /// <param name="model">The prize information.</param>
    /// <returns>The prize information, including the unique identifier.</returns>
    public PrizeModel CreatePrize(PrizeModel model)
    {
      using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
      {
        var p = new DynamicParameters();
        p.Add("@PlaceNumber", model.PlaceNumber);
        p.Add("@PlaceName", model.PlaceName);
        p.Add("@PrizeAmount", model.PrizeAmount);
        p.Add("@PrizePercentage", model.PrizePercentage);
        p.Add("@id", 0, dbType:DbType.Int32, direction: ParameterDirection.Output);

        connection.Execute("spPrizes_Insert", p, commandType:CommandType.StoredProcedure);

        model.Id = p.Get<int>("@id");

        return model;
      }

    }

    public TeamModel CreateTeam(TeamModel model)
    {
      using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
      {
        var p = new DynamicParameters();
        p.Add("@TeamName", model.TeamName);
        p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

        connection.Execute("spTeams_Insert", p, commandType: CommandType.StoredProcedure);

        model.Id = p.Get<int>("@id");

        foreach (var tm in model.TeamMembers)
        {
          p = new DynamicParameters();
          p.Add("@TeamId", model.Id);
          p.Add("@PersonId", tm.Id);
          p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

          connection.Execute("spTeamMembers_Insert", p, commandType: CommandType.StoredProcedure);
        }

        return model;
      }
    }

    public void CreateTournament(TournamentModel model)
    {
      using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
      {
        SaveTournament(connection, model);

        SaveTournamentPrizes(connection, model);

        SaveTournamentEntries(connection, model);

        SaveTournamentRounds(connection, model);
      }
    }

    private void SaveTournament(IDbConnection connection, TournamentModel model)
    {
      var p = new DynamicParameters();
      p.Add("@TournamentName", model.TournamentName);
      p.Add("@EntryFee", model.EntryFee);
      p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

      connection.Execute("spTournaments_Insert", p, commandType: CommandType.StoredProcedure);

      model.Id = p.Get<int>("@id");
    }

    private void SaveTournamentPrizes(IDbConnection connection, TournamentModel model)
    {
      var p = new DynamicParameters();

      foreach (var prize in model.Prizes)
      {
        p = new DynamicParameters();
        p.Add("@TournamentId", model.Id);
        p.Add("@PrizeId", prize.Id);
        p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

        connection.Execute("spTournamentPrizes_Insert", p, commandType: CommandType.StoredProcedure);
      }
    }

    private void SaveTournamentEntries(IDbConnection connection, TournamentModel model)
    {
      var p = new DynamicParameters();

      foreach (var t in model.EnteredTeams)
      {
        p = new DynamicParameters();
        p.Add("@TournamentId", model.Id);
        p.Add("@TeamId", t.Id);
        p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

        connection.Execute("spTournamentEntries_Insert", p, commandType: CommandType.StoredProcedure);
      }
    }

    private void SaveTournamentRounds(IDbConnection connection, TournamentModel model)
    {
      // List<List<MatchupModel>> Rounds
      // MatchupModel is List<MatchupEntryModel> Entries

      // Loop through the rounds
      // Loop through the matchups
      // Save the matchup
      // Loop through the entries and save them

      var p = new DynamicParameters();

      foreach (List<MatchupModel> round in model.Rounds)
      {
        foreach (MatchupModel matchup in round)
        {
          p = new DynamicParameters();
          p.Add("@TournamentId", model.Id);
          p.Add("@MatchupRound", matchup.MatchupRound);
          p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

          connection.Execute("spMatchups_Insert", p, commandType: CommandType.StoredProcedure);

          matchup.Id = p.Get<int>("@id");

          foreach (MatchupEntryModel entry in matchup.Entries)
          {
            p = new DynamicParameters();
            p.Add("@MatchupId", matchup.Id);

            if (entry.ParentMatchup == null)
            {
              p.Add("@ParentMatchupId", null);
            }
            else
            {
              p.Add("@ParentMatchupId", entry.ParentMatchup.Id);
            }

            if (entry.TeamCompeting == null)
            {
              p.Add("@TeamCompetingId", null);
            }
            else
            {
              p.Add("@TeamCompetingId", entry.TeamCompeting.Id);
            }

            p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

            connection.Execute("spMatchupEntries_Insert", p, commandType: CommandType.StoredProcedure);

            entry.Id = p.Get<int>("@id");
          }
        }
      }

    }

    public List<TournamentModel> GetTournament_All()
    {
      List<TournamentModel> output;
      using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
      {
        output = connection.Query<TournamentModel>("dbo.spTournaments_GetAll").ToList();

        foreach ( TournamentModel t in output)
        {
          var p = new DynamicParameters();
          p.Add("@TournamentId", t.Id);

          // Populate Prizes
          t.Prizes = connection.Query<PrizeModel>("dbo.spPrizes_GetByTournament", p, commandType: CommandType.StoredProcedure).ToList();

          // Populate Teams
          t.EnteredTeams = connection.Query<TeamModel>("dbo.spTeams_GetByTournament", p, commandType: CommandType.StoredProcedure).ToList();

          foreach (var team in t.EnteredTeams)
          {
            p = new DynamicParameters();
            p.Add("@TeamId", team.Id);

            team.TeamMembers = connection.Query<PersonModel>("dbo.spTeamMembers_GetByTeam", p, commandType: CommandType.StoredProcedure).ToList();
          }

          p = new DynamicParameters();
          p.Add("@TournamentId", t.Id);
          // Populate Rounds
          List<MatchupModel> matchups = connection.Query<MatchupModel>("dbo.spMatchups_GetByTournament", p, commandType: CommandType.StoredProcedure).ToList();

          foreach (MatchupModel matchup in matchups)
          {
            matchup.Winner = t.EnteredTeams.First(x => x.Id == matchup.WinnerId);

            p = new DynamicParameters();
            p.Add("@MatchupId", matchup.Id);

            matchup.Entries = connection.Query<MatchupEntryModel>( "dbo.spMatchupEntries_GetByMatchup", p, commandType: CommandType.StoredProcedure ).ToList();

            foreach ( MatchupEntryModel me in matchup.Entries)
            {
              if ( me.TeamCompetingId > 0 )
              {
                me.TeamCompeting = t.EnteredTeams.First( x => x.Id == me.TeamCompetingId );
              }

              if (me.ParentMatchupId > 0)
              {
                me.ParentMatchup = matchups.First( x => x.Id == me.ParentMatchupId );
              }
            }
          }
        }

      }
      return output;
    }

    public List<PersonModel> GetPerson_All()
    {
      List<PersonModel> output;
      using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
      {
        output = connection.Query<PersonModel>("dbo.spPeople_GetAll").ToList();
      }
      return output;
    }

    public List<TeamModel> GetTeam_All()
    {
      List<TeamModel> output;
      using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
      {
        output = connection.Query<TeamModel>("dbo.spTeams_GetAll").ToList();

        foreach (var team in output)
        {
          var p = new DynamicParameters();
          p.Add("@TeamId", team.Id);

          team.TeamMembers = connection.Query<PersonModel>("dbo.spTeamMembers_GetByTeam", p, commandType: CommandType.StoredProcedure).ToList();
        }
      }
      return output;
    }
  }
}
