using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Tracker_Library;
using Tracker_Library.Models;
using Tracker_Library.DataAccess;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        IPrizeRequester callingForm;

        public CreatePrizeForm(IPrizeRequester caller)
        {
            InitializeComponent();
            callingForm = caller;
        }
        
        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;
            bool placeNumberValidNumber = int.TryParse(PlaceNumberValue.Text, out placeNumber);

            if(placeNumberValidNumber == false)
            {
                output = false;
            }

            if(placeNumber < 1)
            {
                output = false;
            }

            if(PlaceNumberValue.Text.Length == 0)
            {
                output = false;
            }

            decimal prizeAmount = 0;
            double prizePercentage = 0;

            bool prizeAmountValid = decimal.TryParse(PrizeAmountValue.Text, out prizeAmount);
            bool prizePercentageValid = double.TryParse(PrizePercentageValue.Text, out prizePercentage);

            if (prizeAmountValid == false && prizePercentageValid == false)
            {
                output = false;
            }

            if (prizeAmount <= 0 && prizePercentage <=0)
            {
                output = false;
            }


            if (prizePercentage < 0 || prizePercentage > 100)
            {
                output = false;
            }

            return output;

        }
        private void CreatePrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel
                    (PlaceNameValue.Text,
                    PlaceNameValue.Text,
                    PrizeAmountValue.Text,
                    PrizePercentageValue.Text);

                 GlobalConfig.Connection.CreatePrize(model);

                callingForm.PrizeComplete(model);

                this.Close();
               
                PlaceNameValue.Text = "";
                PlaceNumberValue.Text = "";
                PrizeAmountValue.Text = "0";
                PrizePercentageValue.Text = "0";
                
            }
            else
            {
                MessageBox.Show("This form has invalid information.");
            }
            
    
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreatePrizeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
