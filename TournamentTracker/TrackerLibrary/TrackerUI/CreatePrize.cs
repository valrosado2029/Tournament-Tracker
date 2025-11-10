using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;

namespace TrackerUI
{
    public partial class CreatePrize : Form
    {
        public CreatePrize()
        {
            InitializeComponent();
        }

        private void CreatePrize_btn_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel(PlaceName_txt.Text, PlaceNumber_txt.Text, PrizeAmount_txt.Text, PrizePercentage_txt.Text);

               GlobalConfig.Connection.CreatePrize(model);
                

                PlaceName_txt.Text = "";
                PlaceNumber_txt.Text = "";
                PrizeAmount_txt.Text = "0";
                PrizePercentage_txt.Text = "0";

            }
            else
            {
                MessageBox.Show("This form has invalid information");
            }
        }

        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;
            bool placeNumberValidNumber = int.TryParse(PlaceNumber_txt.Text, out placeNumber);

            if (placeNumberValidNumber == false) 
            {
                output = false;
            }
            if (placeNumber < 1)
            {
                output = false;
            }
            if (PlaceName_txt.Text.Length == 0)
            {
                output = false;
            }
            decimal PrizeAmount = 0;
            double PrizePercentage = 0;

            bool prizeAmountValid = decimal.TryParse(PrizeAmount_txt.Text, out PrizeAmount);
            bool prizePercentageValid = double.TryParse(PrizePercentage_txt.Text, out PrizePercentage);
            if (prizeAmountValid == false || prizePercentageValid == false)
            {
                output = false;
            }

            if(PrizeAmount <= 0 && PrizePercentage <= 0)
            {

                output = false; 
            }

            if (PrizePercentage < 0 || PrizePercentage > 100)
            {
                output = false;
            }


            return output;
        }
    }
}
