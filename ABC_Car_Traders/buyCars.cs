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
    public partial class buyCars : Form
    {
        private database database;
        private int carId;
        private DataTable results = new DataTable();
        public buyCars()
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
                dataGridView1.DataSource = carDataGrid;

            }

        }

        private void buyCars_Load(object sender, EventArgs e)
        {

        }

        private void carDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           /* if (e.RowIndex >= 0)
            {
                // Assuming the DataGridView has columns named "CarID" and "PartID" for the item IDs
                int itemId;
                if (dataGridView1.Columns[e.ColumnIndex].Name == "AddToCartColumn" &&
                    int.TryParse(dataGridView1.Rows[e.RowIndex].Cells["CarID"].Value.ToString(), out itemId))
                {
                    // Add the item to the cart
                    // You can use the itemId to identify the item and add it to the cart
                    // For example:
                    cartInstance.AddItem(itemId);

                    // Optionally, provide feedback to the user
                    MessageBox.Show("Item added to cart successfully.");
                }
            }*/
        }
       /* private void AddItemToCart(int itemId, ItemType itemType, decimal price)
        {
            // Assuming you have a list to store the items in the cart
            List<customerOrder> cartItems = new List<customerOrder>();

            // Generate a unique order ID
            int orderId = GetUniqueOrderId();

            // Assuming customerId is the ID of the current customer
            int customerId = GetCurrentCustomerId();

            // Assuming orderDate is the current date and time
            DateTime orderDate = DateTime.Now;

            // Assuming quantity is always 1 for each item added to the cart
            int quantity = 1;

            // Calculate the total price (assuming quantity is always 1)
            decimal totalPrice = price;

            // Create a new customerOrder object and add it to the cart
            customerOrder order = new customerOrder(orderId, customerId, itemId, itemType, orderDate, quantity, totalPrice);
            cartItems.Add(order);

            // Optionally, update the cart display or perform other operations
            UpdateCartDisplay();
        }*/

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the selected car details from the carDataGrid
                int carId = Convert.ToInt32(carDataGrid.Rows[e.RowIndex].Cells["CarId"].Value);
                string carMake = Convert.ToString(carDataGrid.Rows[e.RowIndex].Cells["CarMake"].Value);
                string carModel = Convert.ToString(carDataGrid.Rows[e.RowIndex].Cells["CarModel"].Value);
                int year = Convert.ToInt32(carDataGrid.Rows[e.RowIndex].Cells["Year"].Value);
                decimal price = Convert.ToDecimal(carDataGrid.Rows[e.RowIndex].Cells["Price"].Value);
                int quantity = Convert.ToInt32(carDataGrid.Rows[e.RowIndex].Cells["Quantity"].Value);
                Image image = (Image)carDataGrid.Rows[e.RowIndex].Cells["ImageColumn"].Value;

                // Add the selected car to the selectedCars DataTable
                dataGridView1.Rows.Add(carId, carMake, carModel, year, price, quantity, image);
            }
        }
    }
}
