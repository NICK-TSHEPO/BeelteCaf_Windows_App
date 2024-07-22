using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Onkarabetse Mooketsi 41395654
//Nick Tshepo Mogotlane 43230350

namespace PeerProgramming_Project
{
    public partial class AddForm : Form
    {
        public int itemPrice { get; set; }
        public string itemName { get; set; }
        public AddForm()
        {
            InitializeComponent();
        }

        private void btnCancelAdd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Receiving inputs
                itemName = txtItemName.Text;  //Declaring itemName
                                              // int itemPrice;
                if (itemName == "")    //If loop as an exception for itemName input
                {
                    MessageBox.Show("Please enter the item name");  //Display message

                }
                this.Close();  //Closing this form
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
      
    }
}
