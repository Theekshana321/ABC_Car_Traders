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
    public partial class editReport : Form
    {
        public editReport()
        {
            InitializeComponent();
        }

        private void exitReptBtn_Click(object sender, EventArgs e)
        {
            viewReport obj = new viewReport();
            obj.Show();
            this.Close();
        }
    }
}
