﻿using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Model;


  //@PlaceNumber int,
  //@PlaceName varchar(100),
  //@PrizeAmount money,
  //@PrizePercentage float,
  //@id int = 0 output

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

    public List<PersonModel> GetPerson_All()
    {
      List<PersonModel> output;
      using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
      {
        output = connection.Query<PersonModel>("dbo.spPeople_GetAll").ToList();
      }
      return output;
    }
  }
}
