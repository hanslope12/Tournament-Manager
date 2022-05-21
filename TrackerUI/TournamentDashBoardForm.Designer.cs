
namespace TrackerUI
{
    partial class TournamentDashBoardForm
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
            this.loadExistingTournamentDropDown = new System.Windows.Forms.ComboBox();
            this.LoadExistingTournamentLabel = new System.Windows.Forms.Label();
            this.LoadTournamentButton = new System.Windows.Forms.Button();
            this.CreateTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HeaderLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.HeaderLabel.Location = new System.Drawing.Point(298, 25);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(182, 41);
            this.HeaderLabel.TabIndex = 27;
            this.HeaderLabel.Text = "Create Team";
            // 
            // loadExistingTournamentDropDown
            // 
            this.loadExistingTournamentDropDown.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loadExistingTournamentDropDown.FormattingEnabled = true;
            this.loadExistingTournamentDropDown.Location = new System.Drawing.Point(171, 157);
            this.loadExistingTournamentDropDown.Name = "loadExistingTournamentDropDown";
            this.loadExistingTournamentDropDown.Size = new System.Drawing.Size(473, 45);
            this.loadExistingTournamentDropDown.TabIndex = 30;
            // 
            // LoadExistingTournamentLabel
            // 
            this.LoadExistingTournamentLabel.AutoSize = true;
            this.LoadExistingTournamentLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoadExistingTournamentLabel.Location = new System.Drawing.Point(270, 97);
            this.LoadExistingTournamentLabel.Name = "LoadExistingTournamentLabel";
            this.LoadExistingTournamentLabel.Size = new System.Drawing.Size(250, 41);
            this.LoadExistingTournamentLabel.TabIndex = 29;
            this.LoadExistingTournamentLabel.Text = "Load Tournament";
            // 
            // LoadTournamentButton
            // 
            this.LoadTournamentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoadTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadTournamentButton.Location = new System.Drawing.Point(270, 266);
            this.LoadTournamentButton.Name = "LoadTournamentButton";
            this.LoadTournamentButton.Size = new System.Drawing.Size(227, 39);
            this.LoadTournamentButton.TabIndex = 33;
            this.LoadTournamentButton.Text = "Load Tournament";
            this.LoadTournamentButton.UseVisualStyleBackColor = true;
            this.LoadTournamentButton.Click += new System.EventHandler(this.LoadTournamentButton_Click);
            // 
            // CreateTournamentButton
            // 
            this.CreateTournamentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTournamentButton.Location = new System.Drawing.Point(270, 326);
            this.CreateTournamentButton.Name = "CreateTournamentButton";
            this.CreateTournamentButton.Size = new System.Drawing.Size(227, 80);
            this.CreateTournamentButton.TabIndex = 34;
            this.CreateTournamentButton.Text = "Create Tournament";
            this.CreateTournamentButton.UseVisualStyleBackColor = true;
            this.CreateTournamentButton.Click += new System.EventHandler(this.CreateTournamentButton_Click);
            // 
            // TournamentDashBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(832, 450);
            this.Controls.Add(this.CreateTournamentButton);
            this.Controls.Add(this.LoadTournamentButton);
            this.Controls.Add(this.loadExistingTournamentDropDown);
            this.Controls.Add(this.LoadExistingTournamentLabel);
            this.Controls.Add(this.HeaderLabel);
            this.Name = "TournamentDashBoardForm";
            this.Text = "TournamentDashBoardForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.ComboBox loadExistingTournamentDropDown;
        private System.Windows.Forms.Label LoadExistingTournamentLabel;
        private System.Windows.Forms.Button LoadTournamentButton;
        private System.Windows.Forms.Button CreateTournamentButton;
    }
}