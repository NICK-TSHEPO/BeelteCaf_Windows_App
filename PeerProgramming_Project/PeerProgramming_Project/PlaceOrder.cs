using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
//Onkarabetse Mooketsi 41395654
//Nick Tshepo Mogotlane 43230350

namespace PeerProgramming_Project
{
    public partial class PlaceOrder : Form
    {
        public SqlConnection conn;  //Establing a server connection
        public SqlCommand comm;  //Executes a command
        public SqlDataAdapter dataAdapter;  //Populates data
        public SqlDataReader dataReader;  //Reads data
        public string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\41395654\source\repos\PeerProgramming_Project\PeerProgramming_Project\DB_BeelteCaf.mdf;Integrated Security=True";
       
        public PlaceOrder()
        {
            InitializeComponent();
        }

        public void loadComboBoxOpAdd()
        {
            try
            {
                conn = new SqlConnection(conString);  //Sql connection statement
                conn.Open();  //Openning connection
                string sql = "SELECT DISTINCT ItemType FROM TableMenu";  //Sql query
                dataAdapter = new SqlDataAdapter(sql, conn);  //Sql dataAdapter statement

                DataSet ds = new DataSet();  //DataSet statement, storage for data

                dataAdapter.Fill(ds, "TableMenu");  //Populates the comboBox cmbCategory
                cmbCategory.DisplayMember = "ItemType";
                cmbCategory.ValueMember = "ItemType";
                cmbCategory.DataSource = ds.Tables["TableMenu"];
                conn.Close();  //Closing connection
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void displayItems(string sqlStatement)
        {
            try
            {
                conn = new SqlConnection(conString);

                cmbCategory.SelectedIndex = -1;  //Setting comboBox's selectedItems to nothing
                string sql = sqlStatement;
                comm = new SqlCommand(sql, conn);  //Sql command statement
                conn.Open();  //Openning connection
                dataReader = comm.ExecuteReader();  //Sql dataReader statement
                while (dataReader.Read())  //hile loop for reading data and display it to a listBox lstItemList
                {
                    lstItemList.Items.Add(dataReader.GetValue(1) + "\t R" + dataReader.GetValue(3).ToString());  //Display items on the listBox
                }
                dataReader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }
        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lstItemList.Items.Clear();  //Clears the listBox lstItemList
                conn.Close();  //Closing connection
                conn.Open();  //Openning connection
                displayItems("SELECT * FROM TableMenu WHERE ItemType = '" + cmbCategory.Text + "' ");  //Calling display method

                conn.Close();  //Closing connection
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }                      
        }

        private void PlaceOrder_Load(object sender, EventArgs e)
        {
            try
            {
                lstItemList.Items.Clear();  //Clearing listBox lstItemList

                lstCartList.Items.Add("***************receipt***************");  //Display 
                conn = new SqlConnection(conString);  //sql statement
                conn.Open();
                conn.Close();
                loadComboBoxOpAdd();   //Calling loadComboBox method
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }                   
        }

        private void btnCustomerProceed_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Thank you for placing your order at BEELTECAF *_*");  //Display
                lstItemList.Items.Clear();  //Clear listBoxes

                lstCartList.Items.Clear();
                lblGrandTotal.Text = "";  //Clearing textBoxes
                lblPrice.Text = "";
                lblSelectedItem.Text = "";
                cmbQuantity.SelectedIndex = -1;  //Setting comboBox selectedItems to nothing
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }

        private void txtItemSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lstItemList.Items.Clear();
                conn.Open();
                displayItems($"SELECT * FROM TableMenu WHERE ItemName LIKE '%{txtItemSearch.Text}%'");  //Calling displayItems method
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(conString);

                cmbCategory.SelectedIndex = -1;
                //string sql = "SELECT * FROM TableMenu WHERE ItemPrice = '" + cmbCategory.Text + "' ";
                string sql = "SELECT * FROM TableMenu";  //sql statement
                comm = new SqlCommand(sql, conn);
                conn.Open();
                dataReader = comm.ExecuteReader();  //dataReader statement

                if (cmbQuantity.SelectedIndex != -1)
                {
                    string text = lstItemList.GetItemText(lstItemList.SelectedItem);  //Declare 'text', which carries listBox's selectedItems
                    lblSelectedItem.Text = text;  //Assign 'text' to a label lblSelectedItem
                    lstCartList.Items.Add(text);  //Display 'text' in a listBox lstCart

                    //Calculations
                    if (dataReader.Read())  //While loop for reading data
                    {
                        int price = Convert.ToInt32(dataReader.GetValue(3));
                        //int price = int.Parse(lstItemList.SelectedItem.ToString());
                        int quantity = Convert.ToInt32(cmbQuantity.SelectedItem.ToString());
                        int cost = (price * quantity) + 18;  //Multiplication of price selected in the listBox with quantity selected

                        lstCartList.Items.Add("Discounted price: R" + price * quantity);  //Display itemSelected
                        lblGrandTotal.Visible = true;  //View label
                        lblGrandTotal.ForeColor = Color.DarkBlue;  //Set label color
                        lblGrandTotal.Text = "R " + cost.ToString() + ".00 VAT Included";  //Display text
                                                                                           //break;
                    }
                    lstCartList.Items.Add("VAT : R*****");  //Display VAT
                    dateTimeReceipt.Visible = true;
                    dataReader.Close();
                }
                else
                {
                    MessageBox.Show("Please specify your quantity");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }

        private void lstItemList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lblTotal.Visible = false;  //Hide label
                                           //Displays the customer's lstItemList selection on txtOrderItemName
                lblTotal.Text = "";  //Clears label
                label6.Visible = true;  //View label
                lblSelectedItem.Visible = true;  //View label
                string text = lstItemList.GetItemText(lstItemList.SelectedItem);  //Declare 'text', which carries listBox's selectedItems
                lblSelectedItem.ForeColor = Color.DarkBlue;  //Set label color
                lblSelectedItem.Text = text;  //Display 'text' on the label
                                              //lstCartList.Items.Add(text);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstCartList.SelectedIndex != -1)  //If loop as an exception for listBox lstCart item selection
                {
                    lstCartList.Items.RemoveAt(lstCartList.SelectedIndex);
                }
                else
                {
                    MessageBox.Show("Please select item from receipt to remove");  //Display message
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void lstCartList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
