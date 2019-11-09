﻿using System;
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
  public partial class CreateTournamentForm : Form
  {
    List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeam_All();
    List<TeamModel> selectedTeams = new List<TeamModel>();
    List<PrizeModel> selectedPrizes = new List<PrizeModel>();

    public CreateTournamentForm()
    {
      InitializeComponent();

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

    private void CreateTournamentForm_Load(object sender, EventArgs e)
    {

    }

    private void tournamentPlayersListBox_SelectedIndexChanged(object sender, EventArgs e)
    {

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
  }
}
