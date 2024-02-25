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
    public partial class customerEdit : Form
    {
        public customerEdit()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            customerManagement CustomerManagement = new customerManagement();
            CustomerManagement.Show();
            this.Hide();
        }
    }
}
