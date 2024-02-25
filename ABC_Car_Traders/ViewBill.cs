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
    public partial class ViewBill : Form
    {
        public ViewBill()
        {
            InitializeComponent();
        }

        private void BillBackBtn_Click(object sender, EventArgs e)
        {
            adminDashboard obj = new adminDashboard();
            obj.Show();
            this.Hide();
        }

        private void addBillBtn_Click(object sender, EventArgs e)
        {
            addBill obj = new addBill();
            obj.Show();
            this.Hide();
        }
    }
}
