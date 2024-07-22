using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Staff log-in details:
//StaffName = "YourName", Password = "admin"
namespace PeerProgramming_Project
{
    public partial class Personnel : Form
    {
        public Personnel()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string staffName = txtStaffName.Text;  //Declaring staffName
                string passWord = txtPassword.Text;   //Declaring password

                if (staffName != "")    //If loop as an exception for staffName and password
                {
                    if (passWord == "admin")
                    {
                        MaintainForm staffForm = new MaintainForm();  //Calling form MaintainForm
                        this.Hide();  //Hide this form
                        staffForm.ShowDialog();  //Display MaintainForm
                    }
                    else
                    {
                        errorProviderPassword.SetError(txtPassword, "Incorrect Password!");  //ErrorProvider set incase an incorrect password is entered
                    }
                }
                else
                {
                    MessageBox.Show("Enter staff name!");  //Display message
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPersonnelCancel_Click(object sender, EventArgs e)
        {
            this.Close();  //Closes form Personnel
        }
    }
}
