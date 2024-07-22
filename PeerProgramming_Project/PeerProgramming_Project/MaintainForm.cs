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
    public partial class MaintainForm : Form
    {
        AddForm addItem = new AddForm();
        DataManipulation deleteItem = new DataManipulation();
        DataManipulation updateItem = new DataManipulation();

        public SqlConnection conn;
        public SqlCommand comm;
        public SqlDataAdapter dataAdapter;
        public SqlDataReader dataReader;
        public string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\41395654\source\repos\PeerProgramming_Project\PeerProgramming_Project\DB_BeelteCaf.mdf;Integrated Security=True";
        public MaintainForm()
        {
            InitializeComponent();
        }

        private void btnStaffLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            loadComboBoxOpAdd();
            addItem.cmbItemCategory.SelectedIndex = -1;
            addItem.ShowDialog();
            addItem.cmbItemCategory.Enabled = true;

            try
            {
                conn.Open();

                double itemPrice = 0.00;
                if (addItem.cmbItemCategory.SelectedIndex != -1)
                {
                    if (double.TryParse(addItem.txtItemPrice.Text, out itemPrice))
                    {
                        string add_sql = $"INSERT INTO TableMenu(ItemName, ItemType, ItemPrice) VALUES('{addItem.itemName}', '{addItem.cmbItemCategory.SelectedValue}', {itemPrice.ToString("n2")})";
                        comm = new SqlCommand(add_sql, conn);
                        dataAdapter.InsertCommand = comm;
                        dataAdapter.InsertCommand.ExecuteNonQuery();
                        MessageBox.Show("Item successfully added");
                        //addItem.Close();
                    }
                    else
                    {
                        MessageBox.Show("Please enter valid price!");
                    }
                }
                else
                {
                    MessageBox.Show("Please select type of item you want to add");
                }
                conn.Close();
                display();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        

        private void btnUpdateItems_Click(object sender, EventArgs e)
        {
            updateItem.btnHowToDelete.Visible = false;
            updateItem.lblDeleteInstruction.Visible = false;
            updateItem.cmbOpCategory.Enabled = false;
            updateItem.cmbOpCategory.SelectedIndex = -1;
            updateItem.txtOpSearch.Enabled = false;
         
            updateItem.lblOperations.Text = "UPDATE ITEM";
            displayForUpdate();
            loadComboBoxOpUpdate();
            updateItem.ShowDialog();

            conn.Open();
            try
            {
                string update_sql = "UPDATE TableMenu SET ItemPrice = @price WHERE ItemName = @name"; //ItemType = @cmbCategory,
                comm = new SqlCommand(update_sql, conn);
                comm.Parameters.AddWithValue("@name", updateItem.itemName);
                comm.Parameters.AddWithValue("@price", updateItem.itemPrice);
                //comm.Parameters.AddWithValue("@cmbCategory", updateItem.cmbOpCategory.SelectedValue);
                dataAdapter = new SqlDataAdapter();
                dataAdapter.UpdateCommand = comm;
                dataAdapter.UpdateCommand.ExecuteNonQuery();
                //comm.ExecuteNonQuery();

                int rowsAffected = comm.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Item price updated successfully!");
                    updateItem.itemName = "";
                    //updateItem.itemPrice = 0;
                }
                else
                {
                    MessageBox.Show("Item not found in the database.");
                }

                conn.Close();
                loadComboBoxOpUpdate();
                displayForUpdate();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private void btnRemoveItems_Click(object sender, EventArgs e)
        {
            deleteItem.txtOpSearch.Enabled = false;     
            deleteItem.lblOperations.Text = "DELETE ITEM";
            //deleteItem.txtOpItemName.Enabled = false;
            deleteItem.txtOpPrice.Enabled = false;
            deleteItem.cmbOpCategory.Enabled = false;
            //deleteItem.btnOperationsDone.Enabled = false;
            displayForDelete();
            deleteItem.ShowDialog();

            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                else
                {
                    try
                    {
                        string name = deleteItem.txtOpItemName.Text;  //Declaring name
                                                                      //string sql_delete = $"DELETE FROM TableMenu WHERE ItemName = @name";
                        string sql_delete = $"DELETE FROM TableMenu WHERE ItemName = '{name}'";  //sql statement
                        comm = new SqlCommand(sql_delete, conn);  //command statement
                        dataAdapter = new SqlDataAdapter();  //dataAdapter statement
                                                             //comm.Parameters.AddWithValue("@name", deleteItem.itemName);

                        dataAdapter.DeleteCommand = comm;
                        dataAdapter.DeleteCommand.ExecuteNonQuery();
                        display();  //Calling display method

                        conn.Close();  //Closing server connection
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);  //Display message
                    }
                }

                loadComboBoxOpUpdate();  //Calling method loadComboBoxOpUpdate
                displayForDelete();   //Calling method displayForDelete
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }

        public void display()
        {
            try
            {
                conn = new SqlConnection(conString);  //connection statement
                if (conn.State == ConnectionState.Closed)  //If statement for the connection state
                {
                    conn.Open();  //Openning connection
                }
                string sql = @"SELECT * FROM TableMenu";  //sql statement
                comm = new SqlCommand(sql, conn);  //executes a command
                dataAdapter = new SqlDataAdapter();   //dataAdapter statement
                dataAdapter.SelectCommand = comm;

                DataSet ds = new DataSet();  //serves as storage for data
                dataAdapter.Fill(ds, "TableMenu");  //Populates the dataGriedView
                dataGridView.DataSource = ds;
                dataGridView.DataMember = "TableMenu";
                conn.Close();  //Closing the connection
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void displayForUpdate()
        {
            try
            {
                conn.Open();  //openning connection
                string sql = @"SELECT * FROM TableMenu";  //sql statement
                comm = new SqlCommand(sql, conn);  //command statement
                dataAdapter = new SqlDataAdapter();  //dataAdapter statement
                dataAdapter.SelectCommand = comm;  //executes a command

                DataSet ds = new DataSet();  //stores data
                dataAdapter.Fill(ds, "TableMenu");  //populates the dataGriedView dgvOperations
                updateItem.dgvOperations.DataSource = ds;
                updateItem.dgvOperations.DataMember = "TableMenu";
                conn.Close();  //closing the connection
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void displayForDelete()
        {
            try
            {
                conn.Open(); //Openning connection
                string sql = @"SELECT * FROM TableMenu"; //sql statement
                comm = new SqlCommand(sql, conn);
                dataAdapter = new SqlDataAdapter();  //dataAdapter statement
                dataAdapter.SelectCommand = comm;  //executes a command

                DataSet ds = new DataSet();  //serves as storage location
                dataAdapter.Fill(ds, "TableMenu");  //Fills the dataGriedView
                deleteItem.dgvOperations.DataSource = ds;
                deleteItem.dgvOperations.DataMember = "TableMenu";
                conn.Close();  //Closing the connection
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        public void loadComboBoxOpUpdate()
        {
            try
            {
                conn.Open();  //Openning the connection
                string sql = "SELECT DISTINCT ItemType FROM TableMenu";  //sql statement
                dataAdapter = new SqlDataAdapter(sql, conn);  //dataAdapter statement

                DataSet ds = new DataSet();  //Serves as storage location

                dataAdapter.Fill(ds, "TableMenu");  //Populates the comboBox cmbOpCategory
                updateItem.cmbOpCategory.DisplayMember = "ItemType";
                updateItem.cmbOpCategory.ValueMember = "ItemType";
                updateItem.cmbOpCategory.DataSource = ds.Tables["TableMenu"];
                conn.Close();  //Closing connection
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void loadComboBoxOpAdd()
        {
            try
            {
                conn.Open();
                string sql = "SELECT DISTINCT ItemType FROM TableMenu";  //sql statement
                dataAdapter = new SqlDataAdapter(sql, conn);  //dataAdapter statement

                DataSet ds = new DataSet();  //Serves as storage location

                dataAdapter.Fill(ds, "TableMenu");  //Populates the comboBox cmbItemCategory
                addItem.cmbItemCategory.DisplayMember = "ItemType";
                addItem.cmbItemCategory.ValueMember = "ItemType";
                addItem.cmbItemCategory.DataSource = ds.Tables["TableMenu"];
                conn.Close();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void loadItemType()
        {
            try
            {
                conn.Open();
                string sql = "SELECT DISTINCT ItemType FROM TableMenu";  //sql statement
                dataAdapter = new SqlDataAdapter(sql, conn);  //dataAdapter statement

                DataSet ds = new DataSet();

                dataAdapter.Fill(ds, "TableMenu");  //Populates the comboBox cmbItem
                cmbType.DisplayMember = "ItemType";
                cmbType.ValueMember = "ItemType";
                cmbType.DataSource = ds.Tables["TableMenu"];
                conn.Close();  //Closing the connection
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MaintainForm_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(conString);
                conn.Open();

                conn.Close();
                display();  //Calling display method


                conn.Open();
                string sql = "SELECT DISTINCT ItemType FROM TableMenu";  //sql statement
                dataAdapter = new SqlDataAdapter(sql, conn);

                DataSet ds = new DataSet();  //Serves as storage for data

                dataAdapter.Fill(ds, "TableMenu");  //Populates the dataGriedView
                cmbType.DisplayMember = "ItemType";
                cmbType.ValueMember = "ItemType";
                cmbType.DataSource = ds.Tables["TableMenu"];
                cmbType.SelectedIndex = -1;  //Setting comboBox selection to nothing
                conn.Close();  //Closing connection
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTeaReport_Click(object sender, EventArgs e)
        {
          
        }

        public void displayReport(string sqlStatement)
        {
            try
            {
                conn = new SqlConnection(conString);  //sql statement
                conn.Open();  //Openning connection
                string sql = sqlStatement;
                comm = new SqlCommand(sql, conn);
                dataAdapter = new SqlDataAdapter();  //dataApdater statement
                dataAdapter.SelectCommand = comm;

                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "TableMenu");  //Populates dataGriedView 
                dataGridView.DataSource = ds;
                dataGridView.DataMember = "TableMenu";
                conn.Close();  //Closing connection
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnCoffeeReport_Click(object sender, EventArgs e)
        {
           
        }

        private void btnPastryReport_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSandwichReport_Click(object sender, EventArgs e)
        {
            
        }

        private void btnOtherDrinksReport_Click(object sender, EventArgs e)
        {
           
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                displayReport($"SELECT * FROM TableMenu WHERE ItemType = '{cmbType.SelectedValue}'");  //Calling displayReports method
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            try
            {
                display();  //Calling display method
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
