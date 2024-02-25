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
    public partial class adminDashboard : Form
    {
        private int loggedInStaffID;
        public string UserType { get; }
        public adminDashboard()
        {
            InitializeComponent();
        }

        //Car Management
        private void button1_Click(object sender, EventArgs e)
        {
            carManagement CarManagement = new carManagement();

            CarManagement.Show();
            this.Hide();
            
        }

        // Car Parts Management
        private void button3_Click(object sender, EventArgs e)
        {
            carPartManagement CarPartManagement = new carPartManagement();
            CarPartManagement.Show();
            this.Hide();
        }


        // Customer Management
        private void button2_Click(object sender, EventArgs e)
        {
            customerManagement CustomerManagement = new customerManagement();
            CustomerManagement.Show();
            this.Hide();
        }


        // Order Management
        private void button4_Click(object sender, EventArgs e)
        {
            orderManagement OrderManagement = new orderManagement();
            OrderManagement.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            carView obj = new carView();
            obj.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            carPartView CarPartView = new carPartView();
            CarPartView.Show();


            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            customerView obj = new customerView();
            obj.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            viewOrder obj = new viewOrder();
            obj.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            viewReport obj = new viewReport();
            obj.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ViewBill obj = new ViewBill();
            obj.Show();
            this.Hide();
        }

        private void adminDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
