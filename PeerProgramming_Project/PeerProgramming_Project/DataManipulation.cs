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
    public partial class DataManipulation : Form
    {
        public string itemName { get; set; }  //Declaring itemName
        public int itemPrice { get; set; }  //Declaring itemPrice
        public string searchItem { get; set; }  //Declaring searchItem
        public DataManipulation()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOperationsDone_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblOperations.Text == "DELETE ITEM")  //If loop as an exception for when the label is 'DELETE ITEM'
                {
                    searchItem = txtOpSearch.Text;
                }
                else
                {
                    //itemName = txtOpItemName.Text;  //Receiving name input
                    int itemPrice;  //Declaring itemPrice or receiving price input
                    if (itemName != "")
                    {
                        /*
                        if (int.TryParse(txtOpPrice.Text, out itemPrice))
                        {
                            itemPrice = Convert.ToInt32(txtOpPrice.Text);

                        }
                        else
                        {
                            itemPrice = 0;
                        }
                        */
                        itemName = txtOpItemName.Text;  //Receiving name input
                    }
                    else
                    {
                        MessageBox.Show("Please enter the item name");  //Display message
                    }
                }
                this.Close();  //Closes this form
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }    

        private void btnOperationsCancel_Click(object sender, EventArgs e)
        {
            this.Close();  //Closes the form
        }

        private void btnHowToDelete_Click(object sender, EventArgs e)
        {
            lblDeleteInstruction.Visible = true;  //View label
            lblDeleteInstruction.ForeColor = Color.Red;  //Sets label color
            lblDeleteInstruction.Text = "*Enter the name of the item you want to delete";  //Displays message
        }

        private void DataManipulation_Load(object sender, EventArgs e)
        {

        }

        private void txtOpItemName_TextChanged(object sender, EventArgs e)
        {
            itemName = txtOpItemName.Text;
        }

        private void txtOpPrice_TextChanged(object sender, EventArgs e)
        {
            itemPrice = int.Parse(txtOpPrice.Text);
        }
    }
}
