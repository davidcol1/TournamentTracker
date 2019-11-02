using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
  /// <summary>
  /// Represents a prize of the tournament.
  /// </summary>
  public class PrizeModel
  {
    /// <summary>
    /// The actual number of the place the prize goes to.
    /// </summary>
    public int PlaceNumber { get; set; }

    /// <summary>
    /// The name of the place the prize goes to like First Place, Runner up or Champion for example.
    /// </summary>
    public string PlaceName { get; set; }

    /// <summary>
    /// The amount of money for the prize.  Set this to zero to use PrizePercentage instead.
    /// </summary>
    public decimal PrizeAmount { get; set; }

    /// <summary>
    /// The percentage of winnings for this place.  Set this to zero to use PrizeAmount instead.
    /// </summary>
    public double PrizePercentage { get; set; }

  }
}
