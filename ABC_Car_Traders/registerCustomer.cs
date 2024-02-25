using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ABC_Car_Traders.User;

namespace ABC_Car_Traders
{
    public partial class registerCustomer : Form
    {
        public registerCustomer()
        {
            InitializeComponent();
        }

        public void display()
        {
            database database = new database();

        }

        private void registerCustomer_Load(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            customerManagement obj = new customerManagement();
            obj.Show();
            this.Hide();
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            customerView obj = new customerView();
            obj.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            int contactNumber;
            if (int.TryParse(contactNumberTxt.Text, out contactNumber))
            {
                Customer customer = new Customer()
                {
                    Fname = firstNameTxt.Text,
                    Lname = lastNameTxt.Text,
                    Address = addressTxt.Text,
                    contactNumber = contactNumber,
                    Email = emailTxt.Text,
                    Gender = maleRdBtn.Checked ? "Male" : "Female",
                };
           


            // Create and initialize the 'users' object
            Users users = new Users()
            {
                UserName = custUsernameTxt.Text,
                Password = custPasswordTxt.Text,
            };

            // Ensure required fields are not empty
            if (string.IsNullOrWhiteSpace(customer.Fname) || string.IsNullOrWhiteSpace(customer.Lname) ||
                string.IsNullOrWhiteSpace(customer.Address) ||  
                 string.IsNullOrWhiteSpace(customer.Email) ||
                string.IsNullOrWhiteSpace(users.UserName) || string.IsNullOrWhiteSpace(users.Password))
            {
                MessageBox.Show("Please fill in all required fields.");
            }
            else
            {
                // Insert staff and users data into the database
                database database = new database();
                int generatedCustomerID = database.InsertCustomer(customer);

                if (generatedCustomerID != -1)
                {
                    // If Staff insertion was successful, insert into Users
                    database.InsertUsers(users, generatedCustomerID);

                    display();
                    //ClearTextBoxes();
                }
                else
                {
                    // Handle the case where Staff insertion failed
                    MessageBox.Show("Staff registration failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            }
            else
            {
                MessageBox.Show("Invalid contact Number. Please enter a valid number.");
            }
        }
    }
}
