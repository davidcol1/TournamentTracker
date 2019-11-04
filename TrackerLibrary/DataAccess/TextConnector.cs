﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Model;

namespace TrackerLibrary.DataAccess
{
  public class TextConnector : IDataConnection
  {
    // ToDO - Make the CreatePrize method actually save to the text files
    /// <summary>
    /// Saves a new prize to the text file.
    /// </summary>
    /// <param name="model">The prize information.</param>
    /// <returns>The prize information, including the unique identifier.</returns>
    public PrizeModel CreatePrize(PrizeModel model)
    {
      model.Id = 1;

      return model;
    }
  }
}
