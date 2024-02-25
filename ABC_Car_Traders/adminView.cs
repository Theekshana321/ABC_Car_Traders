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
    public partial class adminView : Form
    {
        private database database;
        private int UserID;
        private DataTable results = new DataTable();

        public string UserType { get; set; }
        public adminView()
        {
            InitializeComponent();
            database = new database();
            LoadData();
            database = new database();
        }

        private void LoadData()
        {
            var users = database.GetSelectedUserDetails();
            adminDataGrid.DataSource = users;
            adminDataGrid.Columns["Password"].Visible = false;
            adminDataGrid.Columns["CustomerID"].Visible = false;
        }

        private void adminView_Load(object sender, EventArgs e)
        {

        }

        private void adminDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                int UserID = Convert.ToInt32(adminDataGrid.Rows[e.RowIndex].Cells["UserID"].Value);

                this.Hide();
                adminEdit obj = new adminEdit(UserID);
                obj.Show();
            }
        }
    }
}
