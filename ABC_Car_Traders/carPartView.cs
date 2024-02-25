using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class carPartView : Form
    {

        private database database;
        private int carPartId;
        private DataTable results = new DataTable();
        public carPartView()
        {
            InitializeComponent();
            database = new database();
            LoadData();
            database = new database();
        }

        private void LoadData()
        {
            // Clear existing columns to avoid duplicates
            carPartDGV.Columns.Clear();

            // Create columns for other car details
            carPartDGV.Columns.Add("partId", "Car Part ID");
            carPartDGV.Columns.Add("partName", "Name");
            carPartDGV.Columns.Add("description", "Descrtiption");
            carPartDGV.Columns.Add("Quantity", "Quantity");
            carPartDGV.Columns.Add("Price", "Price");
            

            // Create a DataGridViewImageColumn for displaying images
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.HeaderText = "Image";
            imageColumn.Name = "partImage";
            carPartDGV.Columns.Add(imageColumn);

            var carParts = database.GetAllPartCarDetails();
            foreach (var carPart in carParts)
            {
                DataGridViewRow row = new DataGridViewRow();

                row.Cells.Add(new DataGridViewTextBoxCell { Value = carPart.carPartId});
                row.Cells.Add(new DataGridViewTextBoxCell { Value = carPart.partName });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = carPart.description });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = carPart.Price });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = carPart.Quantity });

                if (carPart.ImageData != null && carPart.ImageData.Length > 0)
                {
                    Image image;
                    using (MemoryStream ms = new MemoryStream(carPart.ImageData))
                    {
                        image = Image.FromStream(ms);
                    }
                    row.Cells.Add(new DataGridViewImageCell { Value = image });
                }
                else
                {
                    row.Cells.Add(new DataGridViewImageCell { Value = null });
                }

                carPartDGV.Rows.Add(row);
            }

        }
        private void backBtn_Click(object sender, EventArgs e)
        {
            adminDashboard obj = new adminDashboard();
            obj.Show();
            this.Hide();

        }

        private void carPartAddBtn_Click(object sender, EventArgs e)
        {
            carPartsAdd Obj = new carPartsAdd();
            Obj.Show();
            this.Hide();
        }

        private void carPartView_Load(object sender, EventArgs e)
        {

        }

        private void carPartDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the CarID from the selected row
                int carID = Convert.ToInt32(carPartDGV.Rows[e.RowIndex].Cells["CarID"].Value);

                // Open the CarEdit form and pass the CarID and UserType
                this.Hide();
                carEdit obj = new carEdit(carID);
                obj.Show();
            }
        }
    }
}
