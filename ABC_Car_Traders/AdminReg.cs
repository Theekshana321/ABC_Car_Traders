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
    public partial class AdminReg : Form
    {
        public AdminReg()
        {
            InitializeComponent();
        }

        public void display()
        {
            database database = new database();

        }

        private void AdminReg_Load(object sender, EventArgs e)
        {

        }

        private void adminIntBtn_Click(object sender, EventArgs e)
        {
            Users users = new Users()
            {
                UserName = adminUsernameTxt.Text,
                Password = adminPassTxt.Text
            };

            if (string.IsNullOrWhiteSpace(users.UserName) || string.IsNullOrWhiteSpace(users.Password))
            {
                MessageBox.Show("Please fill in all required fields.");
            }
            else
            {
                database database = new database();
                database.InsertAdmin(users);
                display();

            }
        }

        private void btnARexit_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            this.Hide();
        }

        private void adminEditBtn_Click(object sender, EventArgs e)
        {
            /*adminEdit obj = new adminEdit(UserID);
            obj.Show();
            this.Hide();*/
        }

        private void AdminViewBtn_Click(object sender, EventArgs e)
        {
            adminView obj = new adminView();
            obj.Show();
            this.Hide();
        }
    }
}
