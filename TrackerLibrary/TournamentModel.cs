using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
  /// <summary>
  /// Represents a tournament.
  /// </summary>
  public class TournamentModel
  {
    /// <summary>
    /// The name of the tournament.
    /// </summary>
    public string TournamentName { get; set; }

    /// <summary>
    /// The entry fee paid to get into the tournament.
    /// </summary>
    public decimal EntryFee { get; set; }

    /// <summary>
    /// A list of teams that are in the tournament.
    /// </summary>
    public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

    /// <summary>
    /// The list of prizes in the tournament.
    /// </summary>
    public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

    /// <summary>
    /// A list of a list matchups.  For instance the first round has 4 matchups, the second round has 2,
    /// and the final round has 1.
    /// </summary>
    public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();

  }
}
