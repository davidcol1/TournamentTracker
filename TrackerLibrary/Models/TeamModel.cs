using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Model
{
  /// <summary>
  /// Represents one team in a tournament.
  /// </summary>
  public class TeamModel
  {
    /// <summary>
    /// A list of Persons that are the members of the team.
    /// </summary>
    public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

    /// <summary>
    /// The name of the team.
    /// </summary>
    public string TeamName { get; set; }

  }
}
