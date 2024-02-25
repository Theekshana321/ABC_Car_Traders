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
    public partial class addBill : Form
    {
        public addBill()
        {
            InitializeComponent();
            PopulatePaymentTypes();
        }

        private void PopulatePaymentTypes()
        {
            cmbPaymentMethod.Items.Clear();
            cmbPaymentMethod.Items.Add("Cash");
            cmbPaymentMethod.Items.Add("Card");
            cmbPaymentMethod.Items.Add("Cheque");
            cmbPaymentMethod.SelectedIndex = 0;
        }

        private void btnBCview_Click(object sender, EventArgs e)
        {
            ViewBill obj = new ViewBill();
            obj.Show();
            this.Hide();
        }

        private void billExitBtn_Click(object sender, EventArgs e)
        {
            adminDashboard obj = new adminDashboard();
            obj.Show();
            this.Hide();
        }

        private void btnBCedit_Click(object sender, EventArgs e)
        {
            editBill obj = new editBill();
            obj.Show();
            this.Hide();
        }

        private void addBill_Load(object sender, EventArgs e)
        {

        }
    }
}
