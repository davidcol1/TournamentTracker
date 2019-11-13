using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary.Model;

namespace TrackerUI
{
  public partial class TournamentViewerForm : Form
  {
    private TournamentModel tournament;
    private List<int> rounds = new List<int>();
    private List<MatchupModel> selectedMatchups = new List<MatchupModel>();

    public TournamentViewerForm(TournamentModel tournamentModel)
    {
      InitializeComponent();
      tournament = tournamentModel;
      LoadFormData();
      LoadRounds();
    }

    private void LoadFormData()
    {
      tournamentNameLabel.Text = tournament.TournamentName;
    }

    private void LoadRounds()
    {
      rounds = new List<int>();

      rounds.Add(1);
      int currRound = 1;
      foreach (List<MatchupModel> matchups in tournament.Rounds)
      {
        if (matchups.First().MatchupRound > currRound)
        {
          currRound = matchups.First().MatchupRound;
          rounds.Add(currRound);
        }
      }

      WireUpRoundsList();
    }

    private void WireUpMatchupsLists()
    {
      matchupListBox.DataSource = null;
      matchupListBox.DataSource = selectedMatchups;
      matchupListBox.DisplayMember = "DisplayName";
    }

    private void WireUpRoundsList()
    {
      roundComboBox.DataSource = null;
      roundComboBox.DataSource = rounds;

    }

    private void roundComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
      LoadMatchups();
    }

    private void LoadMatchups()
    {
      int round = (int)roundComboBox.SelectedItem;
      foreach (List<MatchupModel> matchups in tournament.Rounds)
      {
        if (matchups.First().MatchupRound == round)
        {
          selectedMatchups = matchups;
          break;
        }
      }
      WireUpMatchupsLists();
    }

    private void matchupListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
      LoadScoresFromMatchup();
    }

    private void LoadScoresFromMatchup()
    {
      MatchupModel m = ( MatchupModel ) matchupListBox.SelectedItem;

      if ( m != null )
      {
        List<MatchupEntryModel> sortedList = m.Entries
                                              .Where( x => x.TeamCompeting != null )
                                              .OrderBy( x => x.TeamCompeting.TeamName ).ToList();

        for ( int i = 0; i < sortedList.Count(); i++ )
        {
          if ( i == 0 )
          {
            if ( m.Entries[ 0 ].TeamCompeting != null )
            {
              teamOneNameLabel.Text = m.Entries[ 0 ].TeamCompeting.TeamName;
              teamOneScoreTextBox.Text = sortedList[ 0 ].Score.ToString();

              teamTwoNameLabel.Text = "<Bye>";
              teamTwoScoreTextBox.Text = "";
            }
            else
            {
              teamOneNameLabel.Text = "Not yet set";
              teamOneScoreTextBox.Text = "";
            }
          }

          if ( i == 1 )
          {
            if ( m.Entries[ 0 ].TeamCompeting != null )
            {
              teamTwoNameLabel.Text = m.Entries[ 1 ].TeamCompeting.TeamName;
              teamTwoScoreTextBox.Text = sortedList[ 1 ].Score.ToString();
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
  }
}
