using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;

namespace TrackerUI
{
    public partial class CreateTeam : Form
    {
        public CreateTeam()
        {
            InitializeComponent();
        }

        private void CreateTeamMember_btn_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel();

                p.FirstName = FName_txt.Text;
                p.LastName = LName_txt.Text;
                p.EmailAddress = Email_txt.Text;
                p.PhoneNumber = Phone_txt.Text;

                GlobalConfig.Connection.CreatePerson(p);
            }
            else
            {
                MessageBox.Show("you need to fill in all the fields");
            }
        }

        private bool ValidateForm()
        {
            if (FName_txt.Text.Length == 0) 
            {
                return false;
            }

            if (LName_txt.Text.Length == 0)
            {
                return false;
            }

            if (Email_txt.Text.Length == 0)
            {
                return false;
            }

            return true;
        }
    }
}
