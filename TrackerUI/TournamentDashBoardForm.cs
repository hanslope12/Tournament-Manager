using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Tracker_Library;
using Tracker_Library.DataAccess;
using Tracker_Library.Models;

namespace TrackerUI
{
    public partial class TournamentDashBoardForm : Form
    {
        List<TournamentModel> tournaments = GlobalConfig.Connection.GetTournament_All();
        public TournamentDashBoardForm()
        {
            InitializeComponent();
            WireUpLists();
        }

        private void WireUpLists()
        {
            loadExistingTournamentDropDown.DataSource = tournaments;
            loadExistingTournamentDropDown.DisplayMember = "TournamentName";
        }

        private void CreateTournamentButton_Click(object sender, EventArgs e)
        {
            CreateTournamentForm frm = new CreateTournamentForm();
            frm.Show();
        }

        private void LoadTournamentButton_Click(object sender, EventArgs e)
        {
            TournamentModel tm = (TournamentModel)loadExistingTournamentDropDown.SelectedItem;
            TournamentViewerForm frm = new TournamentViewerForm(tm);
            frm.Show();
        }
    }
}
