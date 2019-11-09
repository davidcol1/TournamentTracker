﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Model;
using TrackerLibrary.DataAccess.TextHelpers;

namespace TrackerLibrary.DataAccess
{
  public class TextConnector : IDataConnection
  {
    private const string PrizesFile = "PrizeModels.csv";
    private const string PeopleFile = "PersonModels.csv";
    private const string TeamsFile = "TeamModels.csv";

    public PersonModel CreatePerson(PersonModel model)
    {
      List<PersonModel> people = PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();

      int currentId = 1;
      if (people.Count > 0)
      {
        currentId = people.OrderByDescending(x => x.Id).First().Id + 1;
      }

      model.Id = currentId;

      people.Add(model);

      people.SaveToPeopleFile(PeopleFile);

      return model;
    }

    /// <summary>
    /// Saves a new prize to the text file.
    /// </summary>
    /// <param name="model">The prize information.</param>
    /// <returns>The prize information, including the unique identifier.</returns>
    public PrizeModel CreatePrize(PrizeModel model)
    {
      // Load the text file and convert the text to List<PrizeModel>
      List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

      int currentId = 1;
      if ( prizes.Count > 0 )
      {
        currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
      }

      model.Id = currentId;

      prizes.Add(model);

      prizes.SaveToPrizeFile(PrizesFile);

      return model;
    }

    public List<PersonModel> GetPerson_All()
    {
      return PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();
    }

    public TeamModel CreateTeam(TeamModel model)
    {

      List<TeamModel> teams = TeamsFile.FullFilePath().LoadFile().ConvertToTeamModels(PeopleFile);

      int currentId = 1;
      if (teams.Count > 0)
      {
        currentId = teams.OrderByDescending(x => x.Id).First().Id + 1;
      }

      model.Id = currentId;

      teams.Add(model);

      teams.SaveToTeamFile(TeamsFile);

      return model;
    }

    public List<TeamModel> GetTeam_All()
    {
      throw new NotImplementedException();
    }
  }
}
