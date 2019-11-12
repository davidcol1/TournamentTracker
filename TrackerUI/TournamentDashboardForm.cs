using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Model;

namespace TrackerUI
{
  public partial class TournamentDashboardForm : Form
  {
    private List<TournamentModel> tournaments = GlobalConfig.Connection.GetTournament_All();

    public TournamentDashboardForm()
    {
      InitializeComponent();
    }
  }
}
