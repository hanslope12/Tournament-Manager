
namespace TrackerUI
{
    partial class TournamentViewerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.TournamentName = new System.Windows.Forms.Label();
            this.RoundLabel = new System.Windows.Forms.Label();
            this.RoundDropDown = new System.Windows.Forms.ComboBox();
            this.UnplayedOnlyCheckbox = new System.Windows.Forms.CheckBox();
            this.matchupListBox = new System.Windows.Forms.ListBox();
            this.teamOneName = new System.Windows.Forms.Label();
            this.teamOneScoreLabel = new System.Windows.Forms.Label();
            this.TeamOneScoreValue = new System.Windows.Forms.TextBox();
            this.teamTwoScoreValue = new System.Windows.Forms.TextBox();
            this.teamTwoScoreLabel = new System.Windows.Forms.Label();
            this.teamTwoName = new System.Windows.Forms.Label();
            this.vsLabel = new System.Windows.Forms.Label();
            this.scoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HeaderLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.HeaderLabel.Location = new System.Drawing.Point(12, 9);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(287, 62);
            this.HeaderLabel.TabIndex = 0;
            this.HeaderLabel.Text = "Tournament:";
            // 
            // TournamentName
            // 
            this.TournamentName.AutoSize = true;
            this.TournamentName.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TournamentName.ForeColor = System.Drawing.Color.DarkRed;
            this.TournamentName.Location = new System.Drawing.Point(305, 9);
            this.TournamentName.Name = "TournamentName";
            this.TournamentName.Size = new System.Drawing.Size(206, 62);
            this.TournamentName.TabIndex = 1;
            this.TournamentName.Text = "<None>";
            // 
            // RoundLabel
            // 
            this.RoundLabel.AutoSize = true;
            this.RoundLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RoundLabel.Location = new System.Drawing.Point(12, 83);
            this.RoundLabel.Name = "RoundLabel";
            this.RoundLabel.Size = new System.Drawing.Size(115, 45);
            this.RoundLabel.TabIndex = 2;
            this.RoundLabel.Text = "Round";
            // 
            // RoundDropDown
            // 
            this.RoundDropDown.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RoundDropDown.FormattingEnabled = true;
            this.RoundDropDown.Location = new System.Drawing.Point(135, 84);
            this.RoundDropDown.Name = "RoundDropDown";
            this.RoundDropDown.Size = new System.Drawing.Size(275, 45);
            this.RoundDropDown.TabIndex = 3;
            this.RoundDropDown.SelectedIndexChanged += new System.EventHandler(this.RoundDropDown_SelectedIndexChanged);
            // 
            // UnplayedOnlyCheckbox
            // 
            this.UnplayedOnlyCheckbox.AutoSize = true;
            this.UnplayedOnlyCheckbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UnplayedOnlyCheckbox.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UnplayedOnlyCheckbox.Location = new System.Drawing.Point(118, 136);
            this.UnplayedOnlyCheckbox.Name = "UnplayedOnlyCheckbox";
            this.UnplayedOnlyCheckbox.Size = new System.Drawing.Size(222, 42);
            this.UnplayedOnlyCheckbox.TabIndex = 4;
            this.UnplayedOnlyCheckbox.Text = "Unplayed Only";
            this.UnplayedOnlyCheckbox.UseVisualStyleBackColor = true;
            this.UnplayedOnlyCheckbox.CheckedChanged += new System.EventHandler(this.UnplayedOnlyCheckbox_CheckedChanged);
            // 
            // matchupListBox
            // 
            this.matchupListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchupListBox.FormattingEnabled = true;
            this.matchupListBox.ItemHeight = 20;
            this.matchupListBox.Location = new System.Drawing.Point(12, 186);
            this.matchupListBox.Name = "matchupListBox";
            this.matchupListBox.Size = new System.Drawing.Size(275, 202);
            this.matchupListBox.TabIndex = 5;
            this.matchupListBox.SelectedIndexChanged += new System.EventHandler(this.matchupListBox_SelectedIndexChanged);
            // 
            // teamOneName
            // 
            this.teamOneName.AutoSize = true;
            this.teamOneName.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamOneName.Location = new System.Drawing.Point(421, 141);
            this.teamOneName.Name = "teamOneName";
            this.teamOneName.Size = new System.Drawing.Size(180, 38);
            this.teamOneName.TabIndex = 6;
            this.teamOneName.Text = "<Team One>";
            // 
            // teamOneScoreLabel
            // 
            this.teamOneScoreLabel.AutoSize = true;
            this.teamOneScoreLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamOneScoreLabel.Location = new System.Drawing.Point(421, 195);
            this.teamOneScoreLabel.Name = "teamOneScoreLabel";
            this.teamOneScoreLabel.Size = new System.Drawing.Size(100, 38);
            this.teamOneScoreLabel.TabIndex = 7;
            this.teamOneScoreLabel.Text = "Score :";
            this.teamOneScoreLabel.Click += new System.EventHandler(this.teamOneScore_Click);
            // 
            // TeamOneScoreValue
            // 
            this.TeamOneScoreValue.Location = new System.Drawing.Point(527, 206);
            this.TeamOneScoreValue.Name = "TeamOneScoreValue";
            this.TeamOneScoreValue.Size = new System.Drawing.Size(125, 27);
            this.TeamOneScoreValue.TabIndex = 8;
            this.TeamOneScoreValue.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // teamTwoScoreValue
            // 
            this.teamTwoScoreValue.Location = new System.Drawing.Point(527, 406);
            this.teamTwoScoreValue.Name = "teamTwoScoreValue";
            this.teamTwoScoreValue.Size = new System.Drawing.Size(125, 27);
            this.teamTwoScoreValue.TabIndex = 11;
            // 
            // teamTwoScoreLabel
            // 
            this.teamTwoScoreLabel.AutoSize = true;
            this.teamTwoScoreLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamTwoScoreLabel.Location = new System.Drawing.Point(421, 395);
            this.teamTwoScoreLabel.Name = "teamTwoScoreLabel";
            this.teamTwoScoreLabel.Size = new System.Drawing.Size(100, 38);
            this.teamTwoScoreLabel.TabIndex = 10;
            this.teamTwoScoreLabel.Text = "Score :";
            // 
            // teamTwoName
            // 
            this.teamTwoName.AutoSize = true;
            this.teamTwoName.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamTwoName.Location = new System.Drawing.Point(421, 341);
            this.teamTwoName.Name = "teamTwoName";
            this.teamTwoName.Size = new System.Drawing.Size(177, 38);
            this.teamTwoName.TabIndex = 9;
            this.teamTwoName.Text = "<Team Two>";
            // 
            // vsLabel
            // 
            this.vsLabel.AutoSize = true;
            this.vsLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vsLabel.Location = new System.Drawing.Point(485, 280);
            this.vsLabel.Name = "vsLabel";
            this.vsLabel.Size = new System.Drawing.Size(71, 38);
            this.vsLabel.TabIndex = 12;
            this.vsLabel.Text = "-VS-";
            // 
            // scoreButton
            // 
            this.scoreButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.scoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoreButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scoreButton.Location = new System.Drawing.Point(635, 272);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Size = new System.Drawing.Size(125, 53);
            this.scoreButton.TabIndex = 13;
            this.scoreButton.Text = "Score";
            this.scoreButton.UseVisualStyleBackColor = true;
            this.scoreButton.Click += new System.EventHandler(this.scoreButton_Click);
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.scoreButton);
            this.Controls.Add(this.vsLabel);
            this.Controls.Add(this.teamTwoScoreValue);
            this.Controls.Add(this.teamTwoScoreLabel);
            this.Controls.Add(this.teamTwoName);
            this.Controls.Add(this.TeamOneScoreValue);
            this.Controls.Add(this.teamOneScoreLabel);
            this.Controls.Add(this.teamOneName);
            this.Controls.Add(this.matchupListBox);
            this.Controls.Add(this.UnplayedOnlyCheckbox);
            this.Controls.Add(this.RoundDropDown);
            this.Controls.Add(this.RoundLabel);
            this.Controls.Add(this.TournamentName);
            this.Controls.Add(this.HeaderLabel);
            this.Name = "TournamentViewerForm";
            this.Text = "Tournament Viewer";
            this.Load += new System.EventHandler(this.TournamentViewerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Label TournamentName;
        private System.Windows.Forms.Label RoundLabel;
        private System.Windows.Forms.ComboBox RoundDropDown;
        private System.Windows.Forms.CheckBox UnplayedOnlyCheckbox;
        private System.Windows.Forms.ListBox matchupListBox;
        private System.Windows.Forms.Label teamOneName;
        private System.Windows.Forms.Label teamOneScoreLabel;
        private System.Windows.Forms.TextBox TeamOneScoreValue;
        private System.Windows.Forms.TextBox teamTwoScoreValue;
        private System.Windows.Forms.Label teamTwoScoreLabel;
        private System.Windows.Forms.Label teamTwoName;
        private System.Windows.Forms.Label vsLabel;
        private System.Windows.Forms.Button scoreButton;
    }
}

