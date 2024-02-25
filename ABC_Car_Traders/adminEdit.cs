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
    public partial class adminEdit : Form
    {
        private int loggedInUserID;
        public adminEdit(int UserID)
        {
            InitializeComponent();
            loggedInUserID = UserID;
        }
        public void display()
        {
            database database = new database();

        }

        private void adminUpdateBtn_Click(object sender, EventArgs e)
        {
            string newUsername = adminUserNameTxt.Text;
            string newPassword = adminPassTxt.Text;

            if (string.IsNullOrWhiteSpace(newUsername) || string.IsNullOrWhiteSpace(newPassword))
            {
                MessageBox.Show("Please fill in all required fields.");
            }
            else
            {
                database database = new database();

                Users adminUser = new Users
                {
                    UserID = int.Parse(adminIDtxt.Text),
                    UserName = newUsername,
                    Password = newPassword
                };

                bool updated = database.UpdateAdmin(adminUser);

                if (updated)
                {
                    MessageBox.Show("Admin username and password updated successfully!");
                    this.Hide();
                    adminView obj = new adminView();
                    obj.Show();
                }
                else
                {
                    MessageBox.Show("Update failed. Admin user not found or no changes made.");
                }
            }

        }

        private void adminEdit_Load(object sender, EventArgs e)
        {
            int userIDToUpdate = loggedInUserID;

            if (userIDToUpdate != -1)
            {
                database database = new database();
                Users adminUser = database.LoadAdminDetails(userIDToUpdate);

                if (adminUser != null)
                {
                    adminIDtxt.Text = adminUser.UserID.ToString(); ;
                    
                    adminUserNameTxt.Text = adminUser.UserName;
                    adminPassTxt.Text = adminUser.Password;
                }
                // Note: If adminUser is null, a message box is already displayed in the LoadAdminDetails method.
            }
            else
            {
                MessageBox.Show("Please select an admin user from the DataGridView.");
            }

        }

        private void adminDeleteBtn_Click(object sender, EventArgs e)
        {
            int userIDToDelete;

            if (int.TryParse(adminIDtxt.Text, out userIDToDelete))
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this admin user?", "Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    database database = new database();
                    bool deleted = database.DeleteAdmin(userIDToDelete);

                    if (deleted)
                    {
                        MessageBox.Show("Admin user deleted successfully!");
                        this.Hide();
                        adminView obj = new adminView();
                        obj.Show();
                    }
                    else
                    {
                        MessageBox.Show("Delete failed. Admin user not found.");
                    }
                }
                else
                {
                    MessageBox.Show("Deletion canceled.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric UserID.");
            }
        }
    }
}
