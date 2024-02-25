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
    public partial class carPartManagement : Form
    {
        public carPartManagement()
        {
            InitializeComponent();
        }

        private void carPartAdd_Click(object sender, EventArgs e)
        {
            carPartsAdd CarPartAdd = new carPartsAdd();
            CarPartAdd.Show();
            this.Hide();
        }

        private void carPartEdit_Click(object sender, EventArgs e)
        {
            carPartEdit CarPartEdit = new carPartEdit();
            CarPartEdit.Show();
            this.Hide();
        }

        private void carPartView_Click(object sender, EventArgs e)
        {
            carPartView CarPartView = new carPartView();
            CarPartView.Show();
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
