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
    public partial class createReport : Form
    {
        public createReport()
        {
            InitializeComponent();
        }

        private void RepExitBtn_Click(object sender, EventArgs e)
        {
            adminDashboard obj = new adminDashboard();
            obj.Show();
            this.Hide();
        }

        private void editReportBtn_Click(object sender, EventArgs e)
        {
            editReport obj = new editReport();
            obj.Show();
            this.Hide();
        }
    }
}
