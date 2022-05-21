
namespace TrackerUI
{
    partial class CreateTeamForm
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
            this.AddMemberButton = new System.Windows.Forms.Button();
            this.TeamNameValue = new System.Windows.Forms.TextBox();
            this.TeamNameLabel = new System.Windows.Forms.Label();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.SelectMemberDropDown = new System.Windows.Forms.ComboBox();
            this.SelectTeamMemberLabel = new System.Windows.Forms.Label();
            this.AddNewMemberBox = new System.Windows.Forms.GroupBox();
            this.CreateMember = new System.Windows.Forms.Button();
            this.CellphoneValue = new System.Windows.Forms.TextBox();
            this.CellphoneLabel = new System.Windows.Forms.Label();
            this.EmailValue = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.LastNameValue = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameValue = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.TeamMemberListBox = new System.Windows.Forms.ListBox();
            this.DeleteSelectedMemberButton = new System.Windows.Forms.Button();
            this.CreateTeamButton = new System.Windows.Forms.Button();
            this.AddNewMemberBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddMemberButton
            // 
            this.AddMemberButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddMemberButton.Location = new System.Drawing.Point(59, 295);
            this.AddMemberButton.Name = "AddMemberButton";
            this.AddMemberButton.Size = new System.Drawing.Size(162, 36);
            this.AddMemberButton.TabIndex = 25;
            this.AddMemberButton.Text = "Add Member";
            this.AddMemberButton.UseVisualStyleBackColor = true;
            this.AddMemberButton.Click += new System.EventHandler(this.AddMemberButton_Click);
            // 
            // TeamNameValue
            // 
            this.TeamNameValue.Location = new System.Drawing.Point(12, 119);
            this.TeamNameValue.Name = "TeamNameValue";
            this.TeamNameValue.Size = new System.Drawing.Size(398, 27);
            this.TeamNameValue.TabIndex = 24;
            // 
            // TeamNameLabel
            // 
            this.TeamNameLabel.AutoSize = true;
            this.TeamNameLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeamNameLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.TeamNameLabel.Location = new System.Drawing.Point(46, 63);
            this.TeamNameLabel.Name = "TeamNameLabel";
            this.TeamNameLabel.Size = new System.Drawing.Size(175, 41);
            this.TeamNameLabel.TabIndex = 23;
            this.TeamNameLabel.Text = "Team Name";
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HeaderLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.HeaderLabel.Location = new System.Drawing.Point(12, 9);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(182, 41);
            this.HeaderLabel.TabIndex = 26;
            this.HeaderLabel.Text = "Create Team";
            // 
            // SelectMemberDropDown
            // 
            this.SelectMemberDropDown.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectMemberDropDown.FormattingEnabled = true;
            this.SelectMemberDropDown.Location = new System.Drawing.Point(12, 221);
            this.SelectMemberDropDown.Name = "SelectMemberDropDown";
            this.SelectMemberDropDown.Size = new System.Drawing.Size(398, 45);
            this.SelectMemberDropDown.TabIndex = 28;
            this.SelectMemberDropDown.SelectedIndexChanged += new System.EventHandler(this.SelectMemberDropDown_SelectedIndexChanged);
            // 
            // SelectTeamMemberLabel
            // 
            this.SelectTeamMemberLabel.AutoSize = true;
            this.SelectTeamMemberLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectTeamMemberLabel.Location = new System.Drawing.Point(46, 166);
            this.SelectTeamMemberLabel.Name = "SelectTeamMemberLabel";
            this.SelectTeamMemberLabel.Size = new System.Drawing.Size(296, 41);
            this.SelectTeamMemberLabel.TabIndex = 27;
            this.SelectTeamMemberLabel.Text = "Select Team Member";
            this.SelectTeamMemberLabel.Click += new System.EventHandler(this.SelectTeamLabel_Click);
            // 
            // AddNewMemberBox
            // 
            this.AddNewMemberBox.Controls.Add(this.CreateMember);
            this.AddNewMemberBox.Controls.Add(this.CellphoneValue);
            this.AddNewMemberBox.Controls.Add(this.CellphoneLabel);
            this.AddNewMemberBox.Controls.Add(this.EmailValue);
            this.AddNewMemberBox.Controls.Add(this.EmailLabel);
            this.AddNewMemberBox.Controls.Add(this.LastNameValue);
            this.AddNewMemberBox.Controls.Add(this.LastNameLabel);
            this.AddNewMemberBox.Controls.Add(this.FirstNameValue);
            this.AddNewMemberBox.Controls.Add(this.FirstNameLabel);
            this.AddNewMemberBox.Location = new System.Drawing.Point(12, 351);
            this.AddNewMemberBox.Name = "AddNewMemberBox";
            this.AddNewMemberBox.Size = new System.Drawing.Size(475, 171);
            this.AddNewMemberBox.TabIndex = 29;
            this.AddNewMemberBox.TabStop = false;
            this.AddNewMemberBox.Text = "Add New Member";
            // 
            // CreateMember
            // 
            this.CreateMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateMember.Location = new System.Drawing.Point(279, 69);
            this.CreateMember.Name = "CreateMember";
            this.CreateMember.Size = new System.Drawing.Size(162, 36);
            this.CreateMember.TabIndex = 26;
            this.CreateMember.Text = "Create Member";
            this.CreateMember.UseVisualStyleBackColor = true;
            this.CreateMember.Click += new System.EventHandler(this.CreateMember_Click);
            // 
            // CellphoneValue
            // 
            this.CellphoneValue.Location = new System.Drawing.Point(125, 138);
            this.CellphoneValue.Name = "CellphoneValue";
            this.CellphoneValue.Size = new System.Drawing.Size(125, 27);
            this.CellphoneValue.TabIndex = 16;
            // 
            // CellphoneLabel
            // 
            this.CellphoneLabel.AutoSize = true;
            this.CellphoneLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CellphoneLabel.Location = new System.Drawing.Point(13, 135);
            this.CellphoneLabel.Name = "CellphoneLabel";
            this.CellphoneLabel.Size = new System.Drawing.Size(104, 28);
            this.CellphoneLabel.TabIndex = 15;
            this.CellphoneLabel.Text = "Cellphone:";
            // 
            // EmailValue
            // 
            this.EmailValue.Location = new System.Drawing.Point(125, 98);
            this.EmailValue.Name = "EmailValue";
            this.EmailValue.Size = new System.Drawing.Size(125, 27);
            this.EmailValue.TabIndex = 14;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailLabel.Location = new System.Drawing.Point(14, 98);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(63, 28);
            this.EmailLabel.TabIndex = 13;
            this.EmailLabel.Text = "Email:";
            // 
            // LastNameValue
            // 
            this.LastNameValue.Location = new System.Drawing.Point(125, 59);
            this.LastNameValue.Name = "LastNameValue";
            this.LastNameValue.Size = new System.Drawing.Size(125, 27);
            this.LastNameValue.TabIndex = 12;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastNameLabel.Location = new System.Drawing.Point(13, 56);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(107, 28);
            this.LastNameLabel.TabIndex = 11;
            this.LastNameLabel.Text = "Last Name:";
            // 
            // FirstNameValue
            // 
            this.FirstNameValue.Location = new System.Drawing.Point(125, 26);
            this.FirstNameValue.Name = "FirstNameValue";
            this.FirstNameValue.Size = new System.Drawing.Size(125, 27);
            this.FirstNameValue.TabIndex = 10;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstNameLabel.Location = new System.Drawing.Point(13, 23);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(110, 28);
            this.FirstNameLabel.TabIndex = 9;
            this.FirstNameLabel.Text = "First Name:";
            // 
            // TeamMemberListBox
            // 
            this.TeamMemberListBox.FormattingEnabled = true;
            this.TeamMemberListBox.ItemHeight = 20;
            this.TeamMemberListBox.Location = new System.Drawing.Point(567, 9);
            this.TeamMemberListBox.Name = "TeamMemberListBox";
            this.TeamMemberListBox.Size = new System.Drawing.Size(253, 444);
            this.TeamMemberListBox.TabIndex = 30;
            // 
            // DeleteSelectedMemberButton
            // 
            this.DeleteSelectedMemberButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteSelectedMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteSelectedMemberButton.Location = new System.Drawing.Point(853, 204);
            this.DeleteSelectedMemberButton.Name = "DeleteSelectedMemberButton";
            this.DeleteSelectedMemberButton.Size = new System.Drawing.Size(138, 62);
            this.DeleteSelectedMemberButton.TabIndex = 31;
            this.DeleteSelectedMemberButton.Text = "Delete Selected";
            this.DeleteSelectedMemberButton.UseVisualStyleBackColor = true;
            this.DeleteSelectedMemberButton.Click += new System.EventHandler(this.DeleteSelectedMemberButton_Click);
            // 
            // CreateTeamButton
            // 
            this.CreateTeamButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTeamButton.Location = new System.Drawing.Point(567, 460);
            this.CreateTeamButton.Name = "CreateTeamButton";
            this.CreateTeamButton.Size = new System.Drawing.Size(138, 62);
            this.CreateTeamButton.TabIndex = 32;
            this.CreateTeamButton.Text = "Create Team";
            this.CreateTeamButton.UseVisualStyleBackColor = true;
            this.CreateTeamButton.Click += new System.EventHandler(this.CreateTeamButton_Click);
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1066, 534);
            this.Controls.Add(this.CreateTeamButton);
            this.Controls.Add(this.DeleteSelectedMemberButton);
            this.Controls.Add(this.TeamMemberListBox);
            this.Controls.Add(this.AddNewMemberBox);
            this.Controls.Add(this.SelectMemberDropDown);
            this.Controls.Add(this.SelectTeamMemberLabel);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.AddMemberButton);
            this.Controls.Add(this.TeamNameValue);
            this.Controls.Add(this.TeamNameLabel);
            this.Name = "CreateTeamForm";
            this.Text = "Create Team";
            this.Load += new System.EventHandler(this.CreateTeamForm_Load);
            this.AddNewMemberBox.ResumeLayout(false);
            this.AddNewMemberBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddMemberButton;
        private System.Windows.Forms.TextBox TeamNameValue;
        private System.Windows.Forms.Label TeamNameLabel;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.ComboBox SelectMemberDropDown;
        private System.Windows.Forms.Label SelectTeamMemberLabel;
        private System.Windows.Forms.GroupBox AddNewMemberBox;
        private System.Windows.Forms.TextBox FirstNameValue;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Button CreateMember;
        private System.Windows.Forms.TextBox CellphoneValue;
        private System.Windows.Forms.Label CellphoneLabel;
        private System.Windows.Forms.TextBox EmailValue;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox LastNameValue;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.ListBox TeamMemberListBox;
        private System.Windows.Forms.Button DeleteSelectedMemberButton;
        private System.Windows.Forms.Button CreateTeamButton;
    }
}