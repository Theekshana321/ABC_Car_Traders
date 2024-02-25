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
    public partial class customerManagement : Form
    {
        public customerManagement()
        {
            InitializeComponent();
        }

        private void viewCustomerBtn_Click(object sender, EventArgs e)
        {
            customerView CustomerView = new customerView();
            CustomerView.Show();
            this.Hide();
        }

        private void editCustomerBtn_Click(object sender, EventArgs e)
        {
            customerEdit CustomerEdit = new customerEdit();
            CustomerEdit.Show();
            this.Hide();
        }

        private void registerCustomerBtn_Click(object sender, EventArgs e)
        {
            registerCustomer RegisterCustomer = new registerCustomer();
            RegisterCustomer.Show();
            this.Hide();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            adminDashboard AdminDashboard = new adminDashboard();
            AdminDashboard.Show();
            this.Hide();
        }
    }
}
