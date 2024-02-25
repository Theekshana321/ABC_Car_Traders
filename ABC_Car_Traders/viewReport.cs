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
    public partial class viewReport : Form
    {
        public viewReport()
        {
            InitializeComponent();
        }

        private void btnRepVback_Click(object sender, EventArgs e)
        {
            adminDashboard obj = new adminDashboard();
            obj.Show();
            this.Hide();
        }

        private void addRepBtn_Click(object sender, EventArgs e)
        {
            createReport obj = new createReport();
            obj.Show();
            this.Hide();
        }
    }
}
