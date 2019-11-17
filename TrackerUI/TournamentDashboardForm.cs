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
  public partial class TournamentDashboardForm : Form, ITournamentRequester
  {
    private BindingList<TournamentModel> tournaments = new BindingList<TournamentModel>(GlobalConfig.Connection.GetTournament_All());
    private TournamentModel createdTournament;

    public TournamentDashboardForm()
    {
      InitializeComponent();
      WireUpLists();
    }

    private void WireUpLists()
    {
      loadExistingTournamentComboBox.DataSource = tournaments;
      loadExistingTournamentComboBox.DisplayMember = "TournamentName";
    }

    private void createTournamentButton_Click(object sender, EventArgs e)
    {
      using (var frm = new CreateTournamentForm(this))
      {
        frm.ShowDialog();
      }

      if (createdTournament != null)
      {
        using (var frm = new TournamentViewerForm(createdTournament))
        {
          frm.ShowDialog();
        }
      }

    }

    private void loadTournamentButton_Click(object sender, EventArgs e)
    {
      TournamentModel tm = (TournamentModel)loadExistingTournamentComboBox.SelectedItem;
      if (tm != null)
      {
        TournamentViewerForm frm = new TournamentViewerForm(tm);
        frm.ShowDialog();
      }
      else
      {
        MessageBox.Show("Please select a tournament to load");
      }
    }

    public void TournamentComplete(TournamentModel model)
    {
      createdTournament = model;
      tournaments.Add(model);
    }
  }
}
