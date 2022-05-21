using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tracker_Library;
using Tracker_Library.DataAccess;
using Tracker_Library.Models;

namespace TrackerUI
{
    public partial class CreateTournamentForm : Form, IPrizeRequester, ITeamRequester
    {
        List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeam_All();
        List<TeamModel> selectedTeams = new List<TeamModel>();
        List<PrizeModel> selectedPrize = new List<PrizeModel>();
        public CreateTournamentForm()
        {
            InitializeComponent();
            WireUpLists();
        }

        private void WireUpLists()
        {
            SelectTeamDropDown.DataSource = null;
            SelectTeamDropDown.DataSource = availableTeams;
            SelectTeamDropDown.DisplayMember = "TeamName";

            tournamentTeamsListbox.DataSource = null;
            tournamentTeamsListbox.DataSource = selectedTeams;
            tournamentTeamsListbox.DisplayMember = "TeamName";

            prizesListBox.DataSource = null;
            prizesListBox.DataSource = selectedPrize;
            prizesListBox.DisplayMember = "PlaceName";
        }



        private void SelectTeamDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)SelectTeamDropDown.SelectedItem;

            if (t != null)
            {
                availableTeams.Remove(t);
                selectedTeams.Add(t);

                WireUpLists();
            }
        }

        private void CreatePrizeButton_Click(object sender, EventArgs e)
        {
            CreatePrizeForm frm = new CreatePrizeForm(this);
            frm.Show();
        }

        public void PrizeComplete(PrizeModel model)
        {
            selectedPrize.Add(model);
            WireUpLists();
        }

        public void TeamComplete(TeamModel model)
        {
            selectedTeams.Add(model);
            WireUpLists();
        }

        private void CreateNewTeamLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateTeamForm frm = new CreateTeamForm(this);
            frm.Show();
        }

        private void removeSelectedPlayerButton_Click(object sender, EventArgs e)
        {

            TeamModel t = (TeamModel)tournamentTeamsListbox.SelectedItem;
            if (t != null)
            {
                selectedTeams.Remove(t);
                availableTeams.Add(t);

                WireUpLists();
            }
        }

        private void DeletePrizeButton_Click(object sender, EventArgs e)
        {

            PrizeModel p = (PrizeModel)prizesListBox.SelectedItem;

            if (p != null)
            {
                selectedPrize.Remove(p);

                WireUpLists();
            }
        }

        private void CreateTournamentButton_Click(object sender, EventArgs e)
        {

            decimal fee = 0;
            bool feeAcceptable = decimal.TryParse(EntryFeeValue.Text, out fee);

            if (!feeAcceptable)
            {
                MessageBox.Show("You need to enter a valid Entry Fee", "Invalid Fee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            TournamentModel tm = new TournamentModel();

            tm.TournamentName = TournamentNameValue.Text;
            tm.EntryFee = fee;

            tm.Prizes = selectedPrize;
            tm.EnteredTeams = selectedTeams;

            TournamentLogic.CreateRounds(tm);
            GlobalConfig.Connection.CreateTournament(tm);

            TournamentViewerForm frm = new TournamentViewerForm(tm);
            frm.Show();
            this.Close();
        }
    }
}
