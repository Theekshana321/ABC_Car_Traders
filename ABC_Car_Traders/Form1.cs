using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class Form1 : Form
    {
        private database database; // Initialize Database class
        private int loggedInStaffID;
        public Form1()
        {
            InitializeComponent();
            //loggedInStaffID = staffID;
            database = new database();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;

            string userType = database.GetUserType(username, password); // Use the Database class method

            if (userType == "admin")
            {
                this.Hide();
                adminDashboard obj = new adminDashboard();
                obj.Show();
            }
            else if (userType == "customer")
            {
                
                    this.Hide();
                    Customer_Page obj = new Customer_Page();
                    obj.Show();
               
            }
            else if (userType == "SuperAdmin")
            {
                this.Hide();
                AdminReg obj = new AdminReg();
                obj.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }
    }
}
