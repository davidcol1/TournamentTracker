using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Model;

namespace TrackerLibrary.DataAccess.TextHelpers
{
  public static class TextConnectorProcessor
  {
    public static string FullFilePath(this string fileName)
    {
      return $"{ConfigurationManager.AppSettings["filePath"]}\\{fileName}";
    }

    public static List<string> LoadFile(this string file)
    {
      if (File.Exists(file) == false)
      {
        return new List<string>();
      }

      return File.ReadAllLines(file).ToList();
    }

    public static List<PrizeModel> ConvertToPrizeModels(this List<string> lines)
    {
      List<PrizeModel> output = new List<PrizeModel>();

      foreach (string line in lines)
      {
        string[] cols = line.Split(',');
        PrizeModel p = new PrizeModel();
        p.Id = int.Parse(cols[0]);
        p.PlaceNumber = int.Parse(cols[1]);
        p.PlaceName = cols[2];
        p.PrizeAmount = decimal.Parse(cols[3]);
        p.PrizePercentage = double.Parse(cols[4]);
        output.Add(p);
      }

      return output;
    }

    public static List<PersonModel> ConvertToPersonModels(this List<string> lines)
    {
      List<PersonModel> output = new List<PersonModel>();

      foreach (string line in lines)
      {
        string[] cols = line.Split(',');
        PersonModel p = new PersonModel();
        p.Id = int.Parse(cols[0]);
        p.FirstName = cols[1];
        p.LastName = cols[2];
        p.EmailAddress = cols[3];
        p.CellPhoneNumber = cols[4];
        output.Add(p);
      }

      return output;
    }

    public static void SaveToPrizeFile(this List<PrizeModel> models)
    {
      List<string> lines = new List<string>();

      foreach (PrizeModel p in models)
      {
        lines.Add($"{p.Id},{p.PlaceNumber},{p.PlaceName},{p.PrizeAmount},{p.PrizePercentage}");
      }

      File.WriteAllLines(GlobalConfig.PrizesFile.FullFilePath(), lines);
    }

    public static void SaveToPeopleFile(this List<PersonModel> models)
    {
      List<string> lines = new List<string>();

      foreach (PersonModel p in models)
      {
        lines.Add($"{p.Id},{p.FirstName},{p.LastName},{p.EmailAddress},{p.CellPhoneNumber}");
      }

      File.WriteAllLines(GlobalConfig.PeopleFile.FullFilePath(), lines);
    }

    public static List<TeamModel> ConvertToTeamModels(this List<string> lines)
    {
      //id, team name, list of ids: seperated by the pipe
      //3, Tim's Team, 1|3|5

      List<TeamModel> output = new List<TeamModel>();
      List<PersonModel> people = GlobalConfig.PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();

      foreach (string line in lines)
      {
        string[] cols = line.Split(',');
        TeamModel t = new TeamModel();
        t.Id = int.Parse(cols[0]);
        t.TeamName = cols[1];

        string[] personIds = cols[2].Split('|');

        foreach (var id in personIds)
        {
          t.TeamMembers.Add(people.Where(x => x.Id == int.Parse(id)).First());
        }

        output.Add(t);
      }

      return output;
    }

    public static List<TournamentModel> ConvertToTournamentModels(this List<string> lines)
    {
      //id,TournamentName,EntryFee,(id|id|id - Entered Teams),(id|id|id - Prizes), (Rounds - id^id^id|id^id^id|id^id^id|)
      List<TournamentModel> output = new List<TournamentModel>();
      List<TeamModel> teams = GlobalConfig.TeamsFile.FullFilePath().LoadFile().ConvertToTeamModels();
      List<PrizeModel> prizes = GlobalConfig.PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();
      List<MatchupModel> matchups = GlobalConfig.MatchUpsFile.FullFilePath().LoadFile().ConvertToMatchupModels();

      foreach (string line in lines)
      {
        string[] cols = line.Split(',');

        TournamentModel tm = new TournamentModel();
        tm.Id = int.Parse(cols[0]);
        tm.TournamentName = cols[1];
        tm.EntryFee = decimal.Parse(cols[2]);

        string[] teamIds = cols[3].Split('|');

        foreach (string id in teamIds)
        {
          tm.EnteredTeams.Add(teams.Where(x => x.Id == int.Parse(id)).First());
        }

        if (cols[4].Length > 0)
        {
          string[] prizeIds = cols[4].Split('|');

          foreach (string id in prizeIds)
          {
            tm.Prizes.Add(prizes.Where(x => x.Id == int.Parse(id)).First());
          } 
        }

        string[] rounds = cols[5].Split('|');
        List<MatchupModel> ms = new List<MatchupModel>();

        foreach (string round in rounds)
        {
          ms = new List<MatchupModel>();

          string[] msText = round.Split('^');
          foreach (string matchupModelTextId in msText)
          {
            ms.Add(matchups.Where(x => x.Id == int.Parse(matchupModelTextId)).First());
          }
          tm.Rounds.Add(ms);
        }

        output.Add(tm);

      }

      return output;
    }

    public static void SaveToTeamFile(this List<TeamModel> models)
    {
      List<string> lines = new List<string>();

      foreach (TeamModel t in models)
      {
        lines.Add($"{t.Id},{t.TeamName}, {ConvertPeopleListToString(t.TeamMembers)}");
      }

      File.WriteAllLines(GlobalConfig.TeamsFile.FullFilePath(), lines);
    }

    public static void SaveRoundsToFile(this TournamentModel model)
    {
      // Loop through each Round
      // Inside each round, loop through each Matchup
      // Get the id for the new matchup and save the record
      // Loop through each Entry, get the id and save it

      foreach (List<MatchupModel> round in model.Rounds)
      {
        foreach (MatchupModel matchup in round)
        {
          // Load all the matchups from file
          // Get the top id and add one
          // Store the id
          // Save the matchup record
          matchup.SaveMatchupToFile();


        }
      }
    }

    private static List<MatchupEntryModel> ConvertToMatchupEntryModels(this List<string> lines)
    {
      // id,TeamCompeting,Score,ParentMatchup
      List<MatchupEntryModel> output = new List<MatchupEntryModel>();

      foreach (string line in lines)
      {
        string[] cols = line.Split(',');
        MatchupEntryModel me = new MatchupEntryModel();
        me.Id = int.Parse(cols[0]);
        if (cols[1].Length == 0)
        {
          me.TeamCompeting = null;
        }
        else
        {
          me.TeamCompeting = LookUpTeamById(int.Parse(cols[1]));
        }

        me.Score = double.Parse(cols[2]);

        int parentId = 0;
        if (int.TryParse(cols[3], out parentId))
        {
          me.ParentMatchup = LookUpMatchupById(parentId);
        }
        else
        {
          me.ParentMatchup = null;
        }
        
        output.Add(me);
      }

      return output;
    }

    private static List<MatchupEntryModel> ConvertStringToMatchupEntryModels(string input)
    {
      List<MatchupEntryModel> output = new List<MatchupEntryModel>();

      List<string> entries = GlobalConfig.MatchUpEntriesFile.FullFilePath().LoadFile();

      List<string> matchingEntries = new List<string>();

      string[] ids = input.Split('|');

      foreach (string id in ids)
      {
        foreach (string entry in entries)
        {
          string[] cols = entry.Split(',');

          if (cols[0] == id)
          {
            matchingEntries.Add(entry);
          }
        }
      }

      output = matchingEntries.ConvertToMatchupEntryModels();

      return output;

    }

    private static MatchupModel LookUpMatchupById(int id)
    {
      List<string> matchups = GlobalConfig.MatchUpsFile.FullFilePath().LoadFile();


      foreach (string matchup in matchups)
      {
        string[] cols = matchup.Split(',');

        if (cols[0] == id.ToString())
        {
          List<string> matchingMatchup = new List<string>();
          matchingMatchup.Add(matchup);
          return matchingMatchup.ConvertToMatchupModels().First();
        }
      }
      return null;

    }

    private static TeamModel LookUpTeamById(int id)
    {
      List<string> teams = GlobalConfig.TeamsFile.FullFilePath().LoadFile();

      foreach (string team in teams)
      {
        string[] cols = team.Split(',');

        if (cols[0] == id.ToString())
        {
          List<string> matchingTeams = new List<string>();
          matchingTeams.Add(team);
          return matchingTeams.ConvertToTeamModels().First();
        }
      }
      return null;
    }

    public static List<MatchupModel> ConvertToMatchupModels(this List<string> lines)
    {
      //Id,Entries(id|id|id|),Winner,MatchupRound
      List<MatchupModel> output = new List<MatchupModel>();

      foreach (string line in lines)
      {
        string[] cols = line.Split(',');
        MatchupModel p = new MatchupModel();
        p.Id = int.Parse(cols[0]);
        p.Entries = ConvertStringToMatchupEntryModels(cols[1]);

        if (cols[2].Length == 0)
        {
          p.Winner = null;
        }
        else
        {
          p.Winner = LookUpTeamById(int.Parse(cols[2]));
        }

        
        p.MatchupRound = int.Parse(cols[3]);
        output.Add(p);
      }

      return output;
    }

    public static void SaveMatchupToFile(this MatchupModel model)
    {
      List<MatchupModel> matchups = GlobalConfig.MatchUpsFile.FullFilePath().LoadFile().ConvertToMatchupModels();

      int currentId = 1;
      if (matchups.Count > 0)
      {
        currentId = matchups.OrderByDescending(x => x.Id).First().Id + 1;
      }

      model.Id = currentId;
      matchups.Add(model);

      foreach (MatchupEntryModel entry in model.Entries)
      {
        entry.SaveEntryToFile();
      }

      List<string> lines = new List<string>();

      foreach (MatchupModel m in matchups)
      {
        string winner = "";
        if (m.Winner != null)
        {
          winner = m.Winner.Id.ToString();
        }

        lines.Add($"{m.Id},{ConvertMatchupEntryListToString(m.Entries)},{winner},{m.MatchupRound}");
      }

      File.WriteAllLines(GlobalConfig.MatchUpsFile.FullFilePath(), lines);

    }

    public static void SaveEntryToFile(this MatchupEntryModel model)
    {
      List<MatchupEntryModel> matchupEntries = GlobalConfig.MatchUpEntriesFile.FullFilePath().LoadFile().ConvertToMatchupEntryModels();

      int currentId = 1;
      if (matchupEntries.Count > 0)
      {
        currentId = matchupEntries.OrderByDescending(x => x.Id).First().Id + 1;
      }

      model.Id = currentId;
      matchupEntries.Add(model);

      List<string> lines = new List<string>();

      foreach (MatchupEntryModel e in matchupEntries)
      {
        string parent = "";
        if (e.ParentMatchup != null)
        {
          parent = e.ParentMatchup.Id.ToString();
        }

        string teamCompetingId = "";
        if (e.TeamCompeting != null)
        {
          teamCompetingId = e.TeamCompeting.Id.ToString();
        }


        lines.Add($"{e.Id},{teamCompetingId},{e.Score},{parent}");
      }

      File.WriteAllLines(GlobalConfig.MatchUpEntriesFile.FullFilePath(), lines);

    }

    private static string ConvertPeopleListToString(List<PersonModel> people)
    {
      string output = "";

      //2|5|

      if (people.Count == 0)
      {
        return "";
      }

      foreach (var p in people)
      {
        output += $"{p.Id}|";
      }

      output = output.Substring(0, output.Length - 1);

      return output;
    }

    private static string ConvertTeamListToString(List<TeamModel> teams)
    {
      string output = "";

      //2|5|

      if (teams.Count == 0)
      {
        return "";
      }

      foreach (var t in teams)
      {
        output += $"{t.Id}|";
      }

      output = output.Substring(0, output.Length - 1);

      return output;
    }

    private static string ConvertPrizeListToString(List<PrizeModel> prizes)
    {
      string output = "";

      //2|5|

      if (prizes.Count == 0)
      {
        return "";
      }

      foreach (var p in prizes)
      {
        output += $"{p.Id}|";
      }

      output = output.Substring(0, output.Length - 1);

      return output;
    }

    private static string ConvertRoundListToString(List<List<MatchupModel>> rounds)
    {
      // (Rounds - id^id^id|id^id^id|id^id^id|)
      string output = "";

      if (rounds.Count == 0)
      {
        return "";
      }

      foreach (List<MatchupModel> r in rounds)
      {
        output += $"{ConvertMatchupListToString(r)}|";
      }

      output = output.Substring(0, output.Length - 1);

      return output;
    }

    private static string ConvertMatchupListToString(List<MatchupModel> matchups)
    {
      string output = "";

      //2^5^

      if (matchups.Count == 0)
      {
        return "";
      }

      foreach (var m in matchups)
      {
        output += $"{m.Id}^";
      }

      output = output.Substring(0, output.Length - 1);

      return output;
    }

    private static string ConvertMatchupEntryListToString(List<MatchupEntryModel> matchupEntries)
    {
      string output = "";

      //2|5|

      if (matchupEntries.Count == 0)
      {
        return "";
      }

      foreach (var m in matchupEntries)
      {
        output += $"{m.Id}|";
      }

      output = output.Substring(0, output.Length - 1);

      return output;
    }

    public static void SaveToTournamentFile(this List<TournamentModel> models)
    {
      List<string> lines = new List<string>();

      foreach (TournamentModel t in models)
      {
        lines.Add($"{t.Id},{t.TournamentName},{t.EntryFee},{ConvertTeamListToString(t.EnteredTeams)},{ConvertPrizeListToString(t.Prizes)},{ConvertRoundListToString(t.Rounds)}");
      }

      File.WriteAllLines(GlobalConfig.TournamentsFile.FullFilePath(), lines);
    }

    public static void UpdateMatchupToFile(this MatchupModel model)
    {
      List<MatchupModel> matchups = GlobalConfig.MatchUpsFile.FullFilePath().LoadFile().ConvertToMatchupModels();

      MatchupModel oldMatchup = new MatchupModel();

      foreach (MatchupModel matchup in matchups)
      {
        if (matchup.Id == model.Id)
        {
          oldMatchup = matchup;
        }
      }

      matchups.Remove(oldMatchup);

      matchups.Add(model);

      foreach (MatchupEntryModel entry in model.Entries)
      {
        entry.UpdateEntryToFile();
      }

      List<string> lines = new List<string>();

      foreach (MatchupModel m in matchups)
      {
        string winner = "";
        if (m.Winner != null)
        {
          winner = m.Winner.Id.ToString();
        }

        lines.Add($"{m.Id},{ConvertMatchupEntryListToString(m.Entries)},{winner},{m.MatchupRound}");
      }

      File.WriteAllLines(GlobalConfig.MatchUpsFile.FullFilePath(), lines);
    }

    public static void UpdateEntryToFile(this MatchupEntryModel model)
    {
      List<MatchupEntryModel> matchupEntries = GlobalConfig.MatchUpEntriesFile.FullFilePath().LoadFile().ConvertToMatchupEntryModels();

      MatchupEntryModel oldMatchupEntry = new MatchupEntryModel();

      foreach (MatchupEntryModel matchupEntry in matchupEntries)
      {
        if (matchupEntry.Id == model.Id)
        {
          oldMatchupEntry = matchupEntry;
        }
      }

      matchupEntries.Remove(oldMatchupEntry);

      matchupEntries.Add(model);

      List<string> lines = new List<string>();

      foreach (MatchupEntryModel e in matchupEntries)
      {
        string parent = "";
        if (e.ParentMatchup != null)
        {
          parent = e.ParentMatchup.Id.ToString();
        }

        string teamCompetingId = "";
        if (e.TeamCompeting != null)
        {
          teamCompetingId = e.TeamCompeting.Id.ToString();
        }


        lines.Add($"{e.Id},{teamCompetingId},{e.Score},{parent}");
      }

      File.WriteAllLines(GlobalConfig.MatchUpEntriesFile.FullFilePath(), lines);

    }
  }
}
