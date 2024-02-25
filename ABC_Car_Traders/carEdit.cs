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
using static ABC_Car_Traders.User;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ABC_Car_Traders
{
    public partial class carEdit : Form


    {
        private int CarID { get; set; }

        private database database;
        public carEdit(int carId)
        {
            InitializeComponent();
            //database = new database();
            CarID = carId;
            carIdTxt.Enabled = false;
            LoadCarDetails();
        }
        public void LoadCarDetails()
        {
            database database = new database();
            // Get the car details
            car Car = database.GetCarDetails(CarID);

            if (Car != null)
            {
                carIdTxt.Text = Car.carId.ToString();
                carMakeTxt.Text = Car.carMake;
                carModelTxt.Text = Car.carModel;
                carQuantityTxt.Text = Car.Quantity.ToString();
                carPriceTxt.Text = Car.Price.ToString();
                carYearTxt.Text = Car.year.ToString();

                // Set the image in a PictureBox
                if (Car.ImageData != null && Car.ImageData.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(Car.ImageData))
                    {
                        carImgPB.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    carImgPB.Image = null;
                }
            }
            else
            {
                MessageBox.Show("CarID not found.");
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            carView obj = new carView();
            obj.Show();
            this.Hide();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            int newCarId;
            if (int.TryParse(carIdTxt.Text, out newCarId))
            {
                string newCarMake = carMakeTxt.Text;
                string newCarModel = carModelTxt.Text;
                int newYear;
                if (int.TryParse(carYearTxt.Text, out newYear))
                {
                    decimal newPrice;
                    if (decimal.TryParse(carPriceTxt.Text, out newPrice))
                    {
                        int newQuantity;
                        if (int.TryParse(carQuantityTxt.Text, out newQuantity))
                        {
                            car cars = new car
                            {
                                carId = newCarId,
                                carMake = newCarMake,
                                carModel = newCarModel,
                                year = newYear,
                                Price = newPrice,
                                Quantity = newQuantity
                            };

                            OpenFileDialog openFileDialog1 = new OpenFileDialog();
                            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";
                            openFileDialog1.Title = "Select an Image File";

                            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                            {
                                string imagePath = openFileDialog1.FileName;
                                byte[] imageData = File.ReadAllBytes(imagePath);

                                database database = new database();
                                bool updated = database.updateCar(cars, imageData);

                                if (updated)
                                {
                                    MessageBox.Show("Car data Updated Successfully");
                                    this.Hide();
                                    carView obj = new carView();
                                    obj.Show();
                                }
                                else
                                {
                                    MessageBox.Show("Update failed. Car ID not found or no changes made.");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid quantity. Please enter a valid number.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid price. Please enter a valid number.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid year. Please enter a valid number.");
                }
            }
            else
            {
                MessageBox.Show("Invalid car ID. Please enter a valid number.");
            }
        }


        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int carIDToDelete;

            if (int.TryParse(carIdTxt.Text, out carIDToDelete))
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this Product?", "Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    database database = new database();
                    bool deleted = database.DeleteCar(carIDToDelete);

                    if (deleted)
                    {
                        MessageBox.Show("Product deleted successfully!");
                        this.Hide();
                        carView obj = new carView();
                        obj.Show();
                    }
                    else
                    {
                        MessageBox.Show("Delete failed. Product not found.");
                    }
                }
                else
                {
                    MessageBox.Show("Deletion canceled.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric CarID.");
            }
        }

        private void carEdit_Load(object sender, EventArgs e)
        {

        }
    }
}
