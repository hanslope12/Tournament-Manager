
namespace TrackerUI
{
    partial class CreatePrizeForm
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
            this.PlaceNumberValue = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.PlaceNameValue = new System.Windows.Forms.TextBox();
            this.PlaceNameLabel = new System.Windows.Forms.Label();
            this.PrizeAmountValue = new System.Windows.Forms.TextBox();
            this.PrizeAmountLabel = new System.Windows.Forms.Label();
            this.PrizePercentageValue = new System.Windows.Forms.TextBox();
            this.PrizePercentageLabel = new System.Windows.Forms.Label();
            this.ORLabel = new System.Windows.Forms.Label();
            this.CreatePrizeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HeaderLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.HeaderLabel.Location = new System.Drawing.Point(12, 9);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(176, 41);
            this.HeaderLabel.TabIndex = 27;
            this.HeaderLabel.Text = "Create Prize";
            // 
            // PlaceNumberValue
            // 
            this.PlaceNumberValue.Location = new System.Drawing.Point(180, 73);
            this.PlaceNumberValue.Name = "PlaceNumberValue";
            this.PlaceNumberValue.Size = new System.Drawing.Size(125, 27);
            this.PlaceNumberValue.TabIndex = 29;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstNameLabel.Location = new System.Drawing.Point(15, 73);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(138, 28);
            this.FirstNameLabel.TabIndex = 28;
            this.FirstNameLabel.Text = "Place Number:";
            // 
            // PlaceNameValue
            // 
            this.PlaceNameValue.Location = new System.Drawing.Point(180, 124);
            this.PlaceNameValue.Name = "PlaceNameValue";
            this.PlaceNameValue.Size = new System.Drawing.Size(125, 27);
            this.PlaceNameValue.TabIndex = 31;
            // 
            // PlaceNameLabel
            // 
            this.PlaceNameLabel.AutoSize = true;
            this.PlaceNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlaceNameLabel.Location = new System.Drawing.Point(15, 124);
            this.PlaceNameLabel.Name = "PlaceNameLabel";
            this.PlaceNameLabel.Size = new System.Drawing.Size(118, 28);
            this.PlaceNameLabel.TabIndex = 30;
            this.PlaceNameLabel.Text = "Place Name:";
            // 
            // PrizeAmountValue
            // 
            this.PrizeAmountValue.Location = new System.Drawing.Point(180, 172);
            this.PrizeAmountValue.Name = "PrizeAmountValue";
            this.PrizeAmountValue.Size = new System.Drawing.Size(125, 27);
            this.PrizeAmountValue.TabIndex = 33;
            this.PrizeAmountValue.Text = "0";
            this.PrizeAmountValue.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // PrizeAmountLabel
            // 
            this.PrizeAmountLabel.AutoSize = true;
            this.PrizeAmountLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PrizeAmountLabel.Location = new System.Drawing.Point(15, 172);
            this.PrizeAmountLabel.Name = "PrizeAmountLabel";
            this.PrizeAmountLabel.Size = new System.Drawing.Size(134, 28);
            this.PrizeAmountLabel.TabIndex = 32;
            this.PrizeAmountLabel.Text = "Prize Amount:";
            this.PrizeAmountLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // PrizePercentageValue
            // 
            this.PrizePercentageValue.Location = new System.Drawing.Point(180, 308);
            this.PrizePercentageValue.Name = "PrizePercentageValue";
            this.PrizePercentageValue.Size = new System.Drawing.Size(125, 27);
            this.PrizePercentageValue.TabIndex = 35;
            this.PrizePercentageValue.Text = "0";
            // 
            // PrizePercentageLabel
            // 
            this.PrizePercentageLabel.AutoSize = true;
            this.PrizePercentageLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PrizePercentageLabel.Location = new System.Drawing.Point(15, 307);
            this.PrizePercentageLabel.Name = "PrizePercentageLabel";
            this.PrizePercentageLabel.Size = new System.Drawing.Size(159, 28);
            this.PrizePercentageLabel.TabIndex = 34;
            this.PrizePercentageLabel.Text = "Prize Percentage:";
            // 
            // ORLabel
            // 
            this.ORLabel.AutoSize = true;
            this.ORLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ORLabel.Location = new System.Drawing.Point(133, 237);
            this.ORLabel.Name = "ORLabel";
            this.ORLabel.Size = new System.Drawing.Size(55, 28);
            this.ORLabel.TabIndex = 36;
            this.ORLabel.Text = "-OR-";
            // 
            // CreatePrizeButton
            // 
            this.CreatePrizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreatePrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreatePrizeButton.Location = new System.Drawing.Point(133, 384);
            this.CreatePrizeButton.Name = "CreatePrizeButton";
            this.CreatePrizeButton.Size = new System.Drawing.Size(138, 62);
            this.CreatePrizeButton.TabIndex = 37;
            this.CreatePrizeButton.Text = "Create Prize";
            this.CreatePrizeButton.UseVisualStyleBackColor = true;
            this.CreatePrizeButton.Click += new System.EventHandler(this.CreatePrizeButton_Click);
            // 
            // CreatePrizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(494, 535);
            this.Controls.Add(this.CreatePrizeButton);
            this.Controls.Add(this.ORLabel);
            this.Controls.Add(this.PrizePercentageValue);
            this.Controls.Add(this.PrizePercentageLabel);
            this.Controls.Add(this.PrizeAmountValue);
            this.Controls.Add(this.PrizeAmountLabel);
            this.Controls.Add(this.PlaceNameValue);
            this.Controls.Add(this.PlaceNameLabel);
            this.Controls.Add(this.PlaceNumberValue);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.HeaderLabel);
            this.Name = "CreatePrizeForm";
            this.Text = "Create Prize";
            this.Load += new System.EventHandler(this.CreatePrizeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.TextBox PlaceNumberValue;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.TextBox PlaceNameValue;
        private System.Windows.Forms.Label PlaceNameLabel;
        private System.Windows.Forms.TextBox PrizeAmountValue;
        private System.Windows.Forms.Label PrizeAmountLabel;
        private System.Windows.Forms.TextBox PrizePercentageValue;
        private System.Windows.Forms.Label PrizePercentageLabel;
        private System.Windows.Forms.Label ORLabel;
        private System.Windows.Forms.Button CreatePrizeButton;
    }
}