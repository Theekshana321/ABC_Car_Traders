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
    public partial class carManagement : Form
    {
        public carManagement()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            carAdd CarAdd = new carAdd();

            CarAdd.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*carEdit CarEdit = new carEdit();
            CarEdit.Show();
            this.Hide();*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            carView CarView = new carView();
            CarView.Show();
            this.Hide();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            adminDashboard AdminDashboard = new adminDashboard();
            AdminDashboard.Show();
            this.Hide();
        }

        private void carManagement_Load(object sender, EventArgs e)
        {

        }
    }
}
