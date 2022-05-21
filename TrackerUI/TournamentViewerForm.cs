using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tracker_Library;
using Tracker_Library.DataAccess;
using Tracker_Library.Models;

namespace TrackerUI
{
    public partial class TournamentViewerForm : Form
    {
        private TournamentModel tournament;
        BindingList<int> rounds = new BindingList<int>();
        BindingList<MatchupModel> selectedMatchups = new BindingList<MatchupModel>();

        public TournamentViewerForm(TournamentModel tournamentModel)
        {
            InitializeComponent();

            tournament = tournamentModel;

            LoadFormData();
            LoadRounds();

        }

        private void LoadFormData()
        {
            TournamentName.Text = tournament.TournamentName;
        }

        private void WireUpRoundsLists()
        {
            RoundDropDown.DataSource = rounds;
        }

        private void WireUpMatchupsLists()
        {
            matchupListBox.DataSource = selectedMatchups;
            matchupListBox.DisplayMember = "DisplayName";
        }

        private void LoadRounds()
        {
            rounds.Clear();
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
            WireUpRoundsLists();
            LoadMatchups(1);
        }

        private void TournamentViewerForm_Load(object sender, EventArgs e)
        {

        }

        private void teamOneScore_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RoundDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchups((int)RoundDropDown.SelectedItem);
        }

        private void LoadMatchups(int round)
        {
            foreach (List<MatchupModel> matchups in tournament.Rounds)
            {
                if (matchups.First().MatchupRound == round)
                {
                    selectedMatchups = new BindingList<MatchupModel>();
                    foreach(MatchupModel m in matchups)
                    {
                        if (m.Winner == null || !UnplayedOnlyCheckbox.Checked)
                        {
                            selectedMatchups.Add(m);
                        }
                    }
                }

            }

            DisplayMatchupInfo();
            WireUpMatchupsLists();
        }

        private void DisplayMatchupInfo()
        {
            bool isVisible = (selectedMatchups.Count > 0);

            teamOneName.Visible = isVisible;
            teamOneScoreLabel.Visible = isVisible;
            TeamOneScoreValue.Visible = isVisible;

            teamTwoName.Visible = isVisible;
            teamTwoScoreLabel.Visible = isVisible;
            teamTwoScoreValue.Visible = isVisible;

            vsLabel.Visible = isVisible;
            scoreButton.Visible = isVisible;
        }

        private void matchupListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchup();
        }
        private void LoadMatchup()
        {
            MatchupModel m = (MatchupModel)matchupListBox.SelectedItem;

            for (int i = 0; i < m.Entries.Count; i++)
            {
                if (i == 0)
                {
                    if (m.Entries[0].TeamCompeting != null)
                    {
                        teamOneName.Text = m.Entries[0].TeamCompeting.TeamName;
                        TeamOneScoreValue.Text = m.Entries[0].Score.ToString();

                        teamTwoName.Text = "Bye";
                        teamTwoScoreValue.Text = "";
                    }
                    else
                    {
                        teamOneName.Text = "Not yet set";
                        TeamOneScoreValue.Text = "";
                    }
                }
                if (i == 1)
                {
                    if (m.Entries[1].TeamCompeting != null)
                    {
                        teamTwoName.Text = m.Entries[1].TeamCompeting.TeamName;
                        teamTwoScoreValue.Text = m.Entries[1].Score.ToString();
                    }
                    else
                    {
                        teamTwoName.Text = "Not yet set";
                        teamTwoScoreValue.Text = "";
                    }       
                }
            }


        }

        private void UnplayedOnlyCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            LoadMatchups((int)RoundDropDown.SelectedItem);
        }

        private void scoreButton_Click(object sender, EventArgs e)
        {
            MatchupModel m = (MatchupModel)matchupListBox.SelectedItem;
            double teamOneScore = 0;
            double teamTwoScore = 0;
            for (int i = 0; i < m.Entries.Count; i++)
            {
                if (i == 0)
                {
                    if (m.Entries[0].TeamCompeting != null)
                    {
                        bool scoreValid = double.TryParse(TeamOneScoreValue.Text, out teamOneScore);
                        if (scoreValid)
                        {
                            m.Entries[0].Score = teamOneScore;

                        }
                        else
                        {
                            MessageBox.Show("Please Enter a valid score");
                            return;
                        }
                    }
                }
                if (i == 1)
                {
                    if (m.Entries[1].TeamCompeting != null)
                    { 
                        bool scoreValid = double.TryParse(teamTwoScoreValue.Text, out teamTwoScore);
                        if (scoreValid)
                        {
                            m.Entries[1].Score = teamTwoScore;

                        }
                        else
                        {
                            MessageBox.Show("Please Enter a valid score");
                            return;
                        }
                    }
                }
            }
            TournamentLogic.UpdateTournamentResults(tournament);
            LoadMatchup();


        }
    }
}
