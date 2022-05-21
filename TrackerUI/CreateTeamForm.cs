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
    public partial class CreateTeamForm : Form
    {
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();
        private ITeamRequester callingForm;
        
        private void WireUpLists()
        {
            SelectMemberDropDown.DataSource = null;
            SelectMemberDropDown.DataSource = availableTeamMembers;
            SelectMemberDropDown.DisplayMember = "FullName";

            TeamMemberListBox.DataSource = null;
            TeamMemberListBox.DataSource = selectedTeamMembers;
            TeamMemberListBox.DisplayMember = "FullName";

        }
        public CreateTeamForm(ITeamRequester caller)
        {
            InitializeComponent();
            callingForm = caller;
            WireUpLists();
        }

     

        private bool ValidateForm()
        {
            if(FirstNameValue.Text.Length == 0)
            {
                return false;
            }

            if (LastNameValue.Text.Length == 0)
            {
                return false;
            }

            if (EmailValue.Text.Length == 0)
            {
                return false;
            }

            if (CellphoneValue.Text.Length == 0)
            {
                return false;
            }

            return true;
        }
        private void SelectTeamLabel_Click(object sender, EventArgs e)
        {

        }

        private void CreateTeamForm_Load(object sender, EventArgs e)
        {

        }

        private void CreateMember_Click(object sender, EventArgs e)
        {
            if(ValidateForm())
            {
                PersonModel p = new PersonModel();

                p.FirstName = FirstNameValue.Text;
                p.LastName = LastNameValue.Text;
                p.EmailAddress = EmailValue.Text;
                p.CellphoneNumber = CellphoneValue.Text;

                GlobalConfig.Connection.CreatePerson(p);

                availableTeamMembers.Add(p);

                WireUpLists();

                FirstNameValue.Text = "";
                LastNameValue.Text = "";
                EmailValue.Text = "";
                CellphoneValue.Text = "";
            }
            else
            {
                MessageBox.Show("You need to fill in all of the fields");
            }

           
        }

        private void SelectMemberDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)SelectMemberDropDown.SelectedItem;
            if (p != null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);
            }
            WireUpLists();
        }

        private void DeleteSelectedMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)TeamMemberListBox.SelectedItem;

            if (p != null)
            {
                selectedTeamMembers.Remove(p);
                availableTeamMembers.Add(p);

                WireUpLists();
            }
        }

        private void CreateTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = new TeamModel();

            t.TeamName = TeamNameValue.Text;
            t.TeamMembers = selectedTeamMembers;

            GlobalConfig.Connection.CreateTeam(t);

            callingForm.TeamComplete(t);

            this.Close();
        }
    }
}
