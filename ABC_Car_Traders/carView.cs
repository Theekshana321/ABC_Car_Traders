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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ABC_Car_Traders
{
    public partial class carView : Form
    {
        private database database;
        private int carId;
        private DataTable results = new DataTable();
        private cart cartInstance = new cart();

        public carView()
        {
            InitializeComponent();
            database = new database();
            LoadData();
            database = new database();
        }

        private void LoadData()
        {
            // Clear existing columns to avoid duplicates
            carDataGrid.Columns.Clear();

            // Create columns for other car details
            carDataGrid.Columns.Add("CarId", "Car ID");
            carDataGrid.Columns.Add("CarMake", "Car Make");
            carDataGrid.Columns.Add("CarModel", "Car Model");
            carDataGrid.Columns.Add("Year", "Year");
            carDataGrid.Columns.Add("Price", "Price");
            carDataGrid.Columns.Add("Quantity", "Quantity");

            // Create a DataGridViewImageColumn for displaying images
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.HeaderText = "Image";
            imageColumn.Name = "ImageColumn";
            carDataGrid.Columns.Add(imageColumn);

            var cars = database.GetAllCarDetails();
            foreach (var car in cars)
            {
                DataGridViewRow row = new DataGridViewRow();

                row.Cells.Add(new DataGridViewTextBoxCell { Value = car.carId });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = car.carMake });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = car.carModel });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = car.year });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Price });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Quantity });

                if (car.ImageData != null && car.ImageData.Length > 0)
                {
                    Image image;
                    using (MemoryStream ms = new MemoryStream(car.ImageData))
                    {
                        image = Image.FromStream(ms);
                    }
                    row.Cells.Add(new DataGridViewImageCell { Value = image });
                }
                else
                {
                    row.Cells.Add(new DataGridViewImageCell { Value = null });
                }

                carDataGrid.Rows.Add(row);
            }

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            adminDashboard AdminDashboard = new adminDashboard();
            AdminDashboard.Show();
            this.Hide();

        }

        private void addCarBtn_Click(object sender, EventArgs e)
        {
            carAdd CarAdd = new carAdd();
            CarAdd.Show();
            this.Hide();
        }

        private void carView_Load(object sender, EventArgs e)
        {

        }

        private void carDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the CarID from the selected row
                int carID = Convert.ToInt32(carDataGrid.Rows[e.RowIndex].Cells["CarID"].Value);

                // Open the CarEdit form and pass the CarID and UserType
                this.Hide();
                carEdit obj = new carEdit(carID);
                obj.Show();
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string searchTerm = searchbarcartxt.Text;
            var cars = database.SearchCars(searchTerm);

            // Clear existing rows
            carDataGrid.Rows.Clear();

            foreach (var car in cars)
            {
                DataGridViewRow row = new DataGridViewRow();

                row.Cells.Add(new DataGridViewTextBoxCell { Value = car.carId });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = car.carMake });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = car.carModel });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = car.year });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Price });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Quantity });

                try
                {
                    if (car.ImageData != null && car.ImageData.Length > 0)
                    {
                        using (MemoryStream ms = new MemoryStream(car.ImageData))
                        {
                            Image image = Image.FromStream(ms);
                            row.Cells.Add(new DataGridViewImageCell { Value = image });
                        }
                    }
                    else
                    {
                        row.Cells.Add(new DataGridViewImageCell { Value = null });
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error loading image: " + ex.Message);
                    row.Cells.Add(new DataGridViewImageCell { Value = null });
                }

                carDataGrid.Rows.Add(row);
            }

        }
    }
}
