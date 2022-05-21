
namespace TrackerUI
{
    partial class CreateTournamentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.TournamentNameLabel = new System.Windows.Forms.Label();
            this.TournamentNameValue = new System.Windows.Forms.TextBox();
            this.EntryFeeValue = new System.Windows.Forms.TextBox();
            this.EntryFeeLabel = new System.Windows.Forms.Label();
            this.SelectTeamDropDown = new System.Windows.Forms.ComboBox();
            this.SelectTeamLabel = new System.Windows.Forms.Label();
            this.CreateNewTeamLink = new System.Windows.Forms.LinkLabel();
            this.AddTeamButton = new System.Windows.Forms.Button();
            this.CreatePrizeButton = new System.Windows.Forms.Button();
            this.TeamPlayersLabel = new System.Windows.Forms.Label();
            this.removeSelectedPlayerButton = new System.Windows.Forms.Button();
            this.removeSelectedPrizeButton = new System.Windows.Forms.Button();
            this.PrizesLabel = new System.Windows.Forms.Label();
            this.CreateTournamentButton = new System.Windows.Forms.Button();
            this.tournamentTeamsListbox = new System.Windows.Forms.ListBox();
            this.prizesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HeaderLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.HeaderLabel.Location = new System.Drawing.Point(27, 9);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(435, 62);
            this.HeaderLabel.TabIndex = 1;
            this.HeaderLabel.Text = "Create Tournament:";
            // 
            // TournamentNameLabel
            // 
            this.TournamentNameLabel.AutoSize = true;
            this.TournamentNameLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TournamentNameLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.TournamentNameLabel.Location = new System.Drawing.Point(43, 111);
            this.TournamentNameLabel.Name = "TournamentNameLabel";
            this.TournamentNameLabel.Size = new System.Drawing.Size(264, 41);
            this.TournamentNameLabel.TabIndex = 2;
            this.TournamentNameLabel.Text = "Tournament Name";
            // 
            // TournamentNameValue
            // 
            this.TournamentNameValue.Location = new System.Drawing.Point(43, 167);
            this.TournamentNameValue.Name = "TournamentNameValue";
            this.TournamentNameValue.Size = new System.Drawing.Size(398, 31);
            this.TournamentNameValue.TabIndex = 3;
            // 
            // EntryFeeValue
            // 
            this.EntryFeeValue.Location = new System.Drawing.Point(177, 244);
            this.EntryFeeValue.Name = "EntryFeeValue";
            this.EntryFeeValue.Size = new System.Drawing.Size(125, 31);
            this.EntryFeeValue.TabIndex = 10;
            // 
            // EntryFeeLabel
            // 
            this.EntryFeeLabel.AutoSize = true;
            this.EntryFeeLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EntryFeeLabel.Location = new System.Drawing.Point(43, 237);
            this.EntryFeeLabel.Name = "EntryFeeLabel";
            this.EntryFeeLabel.Size = new System.Drawing.Size(138, 38);
            this.EntryFeeLabel.TabIndex = 9;
            this.EntryFeeLabel.Text = "Entry Fee:";
            // 
            // SelectTeamDropDown
            // 
            this.SelectTeamDropDown.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectTeamDropDown.FormattingEnabled = true;
            this.SelectTeamDropDown.Location = new System.Drawing.Point(43, 353);
            this.SelectTeamDropDown.Name = "SelectTeamDropDown";
            this.SelectTeamDropDown.Size = new System.Drawing.Size(398, 45);
            this.SelectTeamDropDown.TabIndex = 12;
            this.SelectTeamDropDown.SelectedIndexChanged += new System.EventHandler(this.SelectTeamDropDown_SelectedIndexChanged);
            // 
            // SelectTeamLabel
            // 
            this.SelectTeamLabel.AutoSize = true;
            this.SelectTeamLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectTeamLabel.Location = new System.Drawing.Point(43, 304);
            this.SelectTeamLabel.Name = "SelectTeamLabel";
            this.SelectTeamLabel.Size = new System.Drawing.Size(175, 41);
            this.SelectTeamLabel.TabIndex = 11;
            this.SelectTeamLabel.Text = "Select Team";
            // 
            // CreateNewTeamLink
            // 
            this.CreateNewTeamLink.AutoSize = true;
            this.CreateNewTeamLink.Location = new System.Drawing.Point(307, 317);
            this.CreateNewTeamLink.Name = "CreateNewTeamLink";
            this.CreateNewTeamLink.Size = new System.Drawing.Size(102, 25);
            this.CreateNewTeamLink.TabIndex = 13;
            this.CreateNewTeamLink.TabStop = true;
            this.CreateNewTeamLink.Text = "Create New";
            this.CreateNewTeamLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CreateNewTeamLink_LinkClicked);
            // 
            // AddTeamButton
            // 
            this.AddTeamButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTeamButton.Location = new System.Drawing.Point(99, 411);
            this.AddTeamButton.Name = "AddTeamButton";
            this.AddTeamButton.Size = new System.Drawing.Size(138, 40);
            this.AddTeamButton.TabIndex = 14;
            this.AddTeamButton.Text = "Add Team";
            this.AddTeamButton.UseVisualStyleBackColor = true;
            this.AddTeamButton.Click += new System.EventHandler(this.AddTeamButton_Click);
            // 
            // CreatePrizeButton
            // 
            this.CreatePrizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreatePrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreatePrizeButton.Location = new System.Drawing.Point(99, 474);
            this.CreatePrizeButton.Name = "CreatePrizeButton";
            this.CreatePrizeButton.Size = new System.Drawing.Size(138, 40);
            this.CreatePrizeButton.TabIndex = 15;
            this.CreatePrizeButton.Text = "Create Prize";
            this.CreatePrizeButton.UseVisualStyleBackColor = true;
            this.CreatePrizeButton.Click += new System.EventHandler(this.CreatePrizeButton_Click);
            // 
            // TeamPlayersLabel
            // 
            this.TeamPlayersLabel.AutoSize = true;
            this.TeamPlayersLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeamPlayersLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.TeamPlayersLabel.Location = new System.Drawing.Point(559, 111);
            this.TeamPlayersLabel.Name = "TeamPlayersLabel";
            this.TeamPlayersLabel.Size = new System.Drawing.Size(206, 41);
            this.TeamPlayersLabel.TabIndex = 16;
            this.TeamPlayersLabel.Text = "Teams/Players";
            // 
            // removeSelectedPlayerButton
            // 
            this.removeSelectedPlayerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeSelectedPlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeSelectedPlayerButton.Location = new System.Drawing.Point(850, 190);
            this.removeSelectedPlayerButton.Name = "removeSelectedPlayerButton";
            this.removeSelectedPlayerButton.Size = new System.Drawing.Size(128, 65);
            this.removeSelectedPlayerButton.TabIndex = 18;
            this.removeSelectedPlayerButton.Text = "Remove Selected ";
            this.removeSelectedPlayerButton.UseVisualStyleBackColor = true;
            this.removeSelectedPlayerButton.Click += new System.EventHandler(this.removeSelectedPlayerButton_Click);
            // 
            // removeSelectedPrizeButton
            // 
            this.removeSelectedPrizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeSelectedPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeSelectedPrizeButton.Location = new System.Drawing.Point(850, 351);
            this.removeSelectedPrizeButton.Name = "removeSelectedPrizeButton";
            this.removeSelectedPrizeButton.Size = new System.Drawing.Size(138, 62);
            this.removeSelectedPrizeButton.TabIndex = 21;
            this.removeSelectedPrizeButton.Text = "Remove Selected";
            this.removeSelectedPrizeButton.UseVisualStyleBackColor = true;
            this.removeSelectedPrizeButton.Click += new System.EventHandler(this.DeletePrizeButton_Click);
            // 
            // PrizesLabel
            // 
            this.PrizesLabel.AutoSize = true;
            this.PrizesLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PrizesLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.PrizesLabel.Location = new System.Drawing.Point(559, 297);
            this.PrizesLabel.Name = "PrizesLabel";
            this.PrizesLabel.Size = new System.Drawing.Size(95, 41);
            this.PrizesLabel.TabIndex = 19;
            this.PrizesLabel.Text = "Prizes";
            // 
            // CreateTournamentButton
            // 
            this.CreateTournamentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTournamentButton.Location = new System.Drawing.Point(419, 488);
            this.CreateTournamentButton.Name = "CreateTournamentButton";
            this.CreateTournamentButton.Size = new System.Drawing.Size(162, 62);
            this.CreateTournamentButton.TabIndex = 22;
            this.CreateTournamentButton.Text = "Create Tournament";
            this.CreateTournamentButton.UseVisualStyleBackColor = true;
            this.CreateTournamentButton.Click += new System.EventHandler(this.CreateTournamentButton_Click);
            // 
            // tournamentTeamsListbox
            // 
            this.tournamentTeamsListbox.FormattingEnabled = true;
            this.tournamentTeamsListbox.ItemHeight = 25;
            this.tournamentTeamsListbox.Location = new System.Drawing.Point(576, 167);
            this.tournamentTeamsListbox.Name = "tournamentTeamsListbox";
            this.tournamentTeamsListbox.Size = new System.Drawing.Size(201, 104);
            this.tournamentTeamsListbox.TabIndex = 23;
            // 
            // prizesListBox
            // 
            this.prizesListBox.FormattingEnabled = true;
            this.prizesListBox.ItemHeight = 25;
            this.prizesListBox.Location = new System.Drawing.Point(576, 353);
            this.prizesListBox.Name = "prizesListBox";
            this.prizesListBox.Size = new System.Drawing.Size(201, 104);
            this.prizesListBox.TabIndex = 24;
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.prizesListBox);
            this.Controls.Add(this.tournamentTeamsListbox);
            this.Controls.Add(this.CreateTournamentButton);
            this.Controls.Add(this.removeSelectedPrizeButton);
            this.Controls.Add(this.PrizesLabel);
            this.Controls.Add(this.removeSelectedPlayerButton);
            this.Controls.Add(this.TeamPlayersLabel);
            this.Controls.Add(this.CreatePrizeButton);
            this.Controls.Add(this.AddTeamButton);
            this.Controls.Add(this.CreateNewTeamLink);
            this.Controls.Add(this.SelectTeamDropDown);
            this.Controls.Add(this.SelectTeamLabel);
            this.Controls.Add(this.EntryFeeValue);
            this.Controls.Add(this.EntryFeeLabel);
            this.Controls.Add(this.TournamentNameValue);
            this.Controls.Add(this.TournamentNameLabel);
            this.Controls.Add(this.HeaderLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreateTournamentForm";
            this.Text = "Create Tournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Label TournamentNameLabel;
        private System.Windows.Forms.TextBox TournamentNameValue;
        private System.Windows.Forms.TextBox EntryFeeValue;
        private System.Windows.Forms.Label EntryFeeLabel;
        private System.Windows.Forms.ComboBox SelectTeamDropDown;
        private System.Windows.Forms.Label SelectTeamLabel;
        private System.Windows.Forms.LinkLabel CreateNewTeamLink;
        private System.Windows.Forms.Button AddTeamButton;
        private System.Windows.Forms.Button CreatePrizeButton;
        private System.Windows.Forms.Label TeamPlayersLabel;
        private System.Windows.Forms.Button removeSelectedPlayerButton;
        private System.Windows.Forms.Button removeSelectedPrizeButton;
        private System.Windows.Forms.Label PrizesLabel;
        private System.Windows.Forms.Button CreateTournamentButton;
        private System.Windows.Forms.ListBox tournamentTeamsListbox;
        private System.Windows.Forms.ListBox prizesListBox;
    }
}