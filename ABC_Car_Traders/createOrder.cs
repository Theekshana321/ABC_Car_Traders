﻿using System;
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
    public partial class createOrder : Form
    {
        public createOrder()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            orderManagement obj = new orderManagement();
            obj.Show();
            this.Hide();
        }

        private void viewOrderBtn_Click(object sender, EventArgs e)
        {
            viewOrder obj = new viewOrder();
            obj.Show();
            this.Hide();
        }
    }
}
