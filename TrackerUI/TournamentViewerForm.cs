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
  public partial class TournamentViewerForm : Form
  {
    private TournamentModel tournament;
    private BindingList<int> rounds = new BindingList<int>();
    private BindingList<MatchupModel> selectedMatchups = new BindingList<MatchupModel>();

    public TournamentViewerForm(TournamentModel tournamentModel)
    {
      InitializeComponent();
      tournament = tournamentModel;
      LoadFormData();
      WireUpLists();
      LoadRounds();
    }

    private void LoadFormData()
    {
      tournamentNameLabel.Text = tournament.TournamentName;
    }

    private void LoadRounds()
    {
      rounds.Clear();

      rounds.Add(1);
      int currRound = 1;
      foreach (List<MatchupModel> matchups in tournament.Rounds.OrderBy(x => x.First().MatchupRound ))
      {
        if (matchups.First().MatchupRound > currRound)
        {
          currRound = matchups.First().MatchupRound;
          rounds.Add(currRound);
        }
      }
      LoadMatchups(1);
    }

    private void WireUpLists()
    {
      roundComboBox.DataSource = rounds;

      matchupListBox.DataSource = selectedMatchups;
      matchupListBox.DisplayMember = "DisplayName";
    }

    private void LoadMatchups(int round)
    {
      foreach (List<MatchupModel> matchups in tournament.Rounds)
      {
        if (matchups.First().MatchupRound == round)
        {
          selectedMatchups.Clear();
          foreach (MatchupModel m in matchups.OrderBy(x => x.DisplayName))
          {
            if (m.Winner == null || unplayedOnlyCheckBox.Checked == false)
            {
              selectedMatchups.Add(m);
            }
          }
          break;
        }
      }
      if (selectedMatchups.Count > 0)
      {
        LoadScoresFromMatchup(selectedMatchups.First());
      }

      DisplayMatchupInfo();
    }

    private void DisplayMatchupInfo()
    {
      bool isVisible = (selectedMatchups.Count > 0);

      teamOneNameLabel.Visible = isVisible;
      teamTwoNameLabel.Visible = isVisible;
      teamOneScoreLabel.Visible = isVisible;
      teamTwoScoreLabel.Visible = isVisible;
      teamOneScoreTextBox.Visible = isVisible;
      teamTwoScoreTextBox.Visible = isVisible;
      vsLabel.Visible = isVisible;
      scoreButton.Visible = isVisible;

    }

    private void LoadScoresFromMatchup(MatchupModel m)
    {

      if (m != null)
      {
        List<MatchupEntryModel> sortedList = m.Entries.OrderByDescending(x => x.TeamCompeting != null
                                                                                ? x.TeamCompeting.Id
                                                                                : 0).ToList();

        for (int i = 0; i < sortedList.Count(); i++)
        {
          if (i == 0)
          {
            if (m.Entries[0].TeamCompeting != null)
            {
              teamOneNameLabel.Text = m.Entries[0].TeamCompeting.TeamName;
              teamOneScoreTextBox.Text = sortedList[0].Score.ToString();

              teamTwoNameLabel.Text = "<Bye>";
              teamTwoScoreTextBox.Text = "";
            }
            else
            {
              teamOneNameLabel.Text = "Not yet set";
              teamOneScoreTextBox.Text = "";
            }
          }

          if (i == 1)
          {
            if (m.Entries[0].TeamCompeting != null)
            {
              teamTwoNameLabel.Text = m.Entries[1].TeamCompeting.TeamName;
              teamTwoScoreTextBox.Text = sortedList[1].Score.ToString();
            }
            else
            {
              teamTwoNameLabel.Text = "Not yet set";
              teamTwoScoreTextBox.Text = "";
            }
          }
        }
      }
    }

    private void scoreButton_Click(object sender, EventArgs e)
    {
      MatchupModel m = (MatchupModel)matchupListBox.SelectedItem;
      double teamOneScore = 0;
      double teamTwoScore = 0;

      List<MatchupEntryModel> sortedList = m.Entries.OrderByDescending(x => x.TeamCompeting != null
                                                                              ? x.TeamCompeting.Id
                                                                              : 0).ToList();

      for (int i = 0; i < sortedList.Count(); i++)
      {
        if (i == 0)
        {
          if (m.Entries[0].TeamCompeting != null)
          {
            bool scoreValid = double.TryParse(teamOneScoreTextBox.Text, out teamOneScore);

            if (scoreValid)
            {
              sortedList[0].Score = teamOneScore;
            }
            else
            {
              MessageBox.Show("Please enter a valid score for team 1.");
              return;
            }
          }
        }

        if (i == 1)
        {
          if (m.Entries[1].TeamCompeting != null)
          {
            bool scoreValid = double.TryParse(teamTwoScoreTextBox.Text, out teamTwoScore);

            if (scoreValid)
            {
              sortedList[1].Score = teamTwoScore;
            }
            else
            {
              MessageBox.Show("Please enter a valid score for team 2.");
              return;
            }
          }
        }
      }

      if (teamOneScore > teamTwoScore || sortedList.Count == 1)
      {
        m.Winner = m.Entries[0].TeamCompeting;
      }
      else if (teamTwoScore > teamOneScore)
      {
        m.Winner = m.Entries[1].TeamCompeting;
      }
      else
      {
        MessageBox.Show("I do not handle ties.");
        return;
      }

      foreach (List<MatchupModel> round in tournament.Rounds)
      {
        foreach (MatchupModel matchupModel in round)
        {
          foreach (MatchupEntryModel matchupEntry in matchupModel.Entries)
          {
            if (matchupEntry.ParentMatchup != null)
            {
              if (matchupEntry.ParentMatchup.Id == m.Id)
              {
                matchupEntry.TeamCompeting = m.Winner;
                GlobalConfig.Connection.UpdateMatchup(matchupModel);
              }
            }
          }
        }
      }

      GlobalConfig.Connection.UpdateMatchup(m);

      LoadMatchups((int)roundComboBox.SelectedItem);
    }

    private void unplayedOnlyCheckBox_CheckedChanged(object sender, EventArgs e)
    {
      LoadMatchups((int)roundComboBox.SelectedItem);
    }

    private void roundComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
      LoadMatchups((int)roundComboBox.SelectedItem);
    }

    private void matchupListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
      LoadScoresFromMatchup((MatchupModel)matchupListBox.SelectedItem);
    }
  }
}
