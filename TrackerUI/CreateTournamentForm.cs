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
  public partial class CreateTournamentForm : Form, IPrizeRequester, ITeamRequester
  {
    List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeam_All();
    List<TeamModel> selectedTeams = new List<TeamModel>();
    List<PrizeModel> selectedPrizes = new List<PrizeModel>();
    private ITournamentRequester callingForm;


    public CreateTournamentForm(ITournamentRequester caller)
    {
      InitializeComponent();

      callingForm = caller;

      WireUpLists();
    }

    public void PrizeComplete(PrizeModel model)
    {
      // Get back from the form a PrizeModel
      // Take the PrizeModel and put it into our list of selected prizes
      selectedPrizes.Add(model);
      WireUpLists();
    }

    public void TeamComplete(TeamModel model)
    {
      selectedTeams.Add(model);
      WireUpLists();
    }

    private void WireUpLists()
    {
      selectTeamComboBox.DataSource = null;

      selectTeamComboBox.DataSource = availableTeams;
      selectTeamComboBox.DisplayMember = "TeamName";

      tournamentTeamsListBox.DataSource = null;

      tournamentTeamsListBox.DataSource = selectedTeams;
      tournamentTeamsListBox.DisplayMember = "TeamName";

      prizesListBox.DataSource = null;

      prizesListBox.DataSource = selectedPrizes;
      prizesListBox.DisplayMember = "PlaceName";
    }

    private void addTeamButton_Click(object sender, EventArgs e)
    {
      TeamModel t = (TeamModel)selectTeamComboBox.SelectedItem;

      if (t != null)
      {
        availableTeams.Remove(t);
        selectedTeams.Add(t);

        WireUpLists();
      }
    }

    private void createTournamentButton_Click(object sender, EventArgs e)
    {
      // Validate data
      decimal fee = 0;

      bool feeAcceptable = decimal.TryParse(entryFeeTextBox.Text, out fee);

      if (feeAcceptable == false)
      {
        MessageBox.Show("You need to enter a valid Entry Fee.",
          "Invalid Fee", 
          MessageBoxButtons.OK, 
          MessageBoxIcon.Error);
        return;
      }

      // Create our tournament model
      TournamentModel tm = new TournamentModel();

      tm.TournamentName = tournamentNameTextBox.Text;
      tm.EntryFee = fee;

      tm.Prizes = selectedPrizes;
      tm.EnteredTeams = selectedTeams;

      // Create our matchups
      // Order our list randomly
      // Check if it is big enough and if not, add in byes
      // Create or first round of matchups
      // Create every round after that - 8 matchups -> 4 matchups -> 2 matchups -> 1 matchup
      TournamentLogic.CreateRounds(tm);


      // Create Tournament Entry
      // Create all of the prizes entries
      // Create all of the team entries
      GlobalConfig.Connection.CreateTournament(tm);

      callingForm.TournamentComplete(tm);

      Close();

    }

    private void createPrizeButton_Click(object sender, EventArgs e)
    {
      // Call the CreatePrizeForm
      CreatePrizeForm frm = new CreatePrizeForm(this);
      frm.ShowDialog();
    }

    private void removeSelectedPlayerButton_Click(object sender, EventArgs e)
    {
      TeamModel t = (TeamModel)tournamentTeamsListBox.SelectedItem;

      if (t != null)
      {
        selectedTeams.Remove(t);
        availableTeams.Add(t);

        WireUpLists();
      }
    }

    private void removeSelectedPrizeButton_Click(object sender, EventArgs e)
    {
      PrizeModel p = (PrizeModel)prizesListBox.SelectedItem;

      if (p != null)
      {
        selectedPrizes.Remove(p);

        WireUpLists();
      }
    }

    private void createNewTeamLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      // Call the CreatePrizeForm
      CreateTeamForm frm = new CreateTeamForm(this);
      frm.ShowDialog();
    }
  }
}
