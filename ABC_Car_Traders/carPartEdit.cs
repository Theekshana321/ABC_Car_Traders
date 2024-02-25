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
    public partial class carPartEdit : Form
    {
        public carPartEdit()
        {
            InitializeComponent();
        }

        private void carPartEdit_Load(object sender, EventArgs e)
        {

        }

        private void CarPartBackBtn_Click(object sender, EventArgs e)
        {
            carPartView obj = new carPartView();
            obj.Show();
            this.Hide();
        }

        private void carPartUpdateBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
