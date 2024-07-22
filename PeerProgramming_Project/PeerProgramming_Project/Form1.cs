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
//For staff login: StaffName = "YourName", Password = "admin"

namespace PeerProgramming_Project
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Personnel staffForm = new Personnel();   //calling another form
            staffForm.ShowDialog();  //display the form

        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            PlaceOrder placeOrder = new PlaceOrder();  //calling another form
           // placeOrder.MdiParent = this;
            placeOrder.ShowDialog();  //display the form
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();  //terminates the entire program
        }
    }
}
