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

namespace ABC_Car_Traders
{
    public partial class carAdd : Form
    {
        private database database;

        public carAdd()
        {
            InitializeComponent();
            database = new database();

        }

        public void display()
        {
            database database = new database();

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            adminDashboard obj = new adminDashboard();
            obj.Show();
            this.Close();
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            int year;
            if (int.TryParse(carYearTxt.Text, out year))
            {
                decimal price;
                if (decimal.TryParse(carPriceTxt.Text, out price))
                {
                    int quantity;
                    if (int.TryParse(carQuantityTxt.Text, out quantity))
                    {
                        // Use an OpenFileDialog to select the image file
                        OpenFileDialog openFileDialog = new OpenFileDialog();
                        openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            // Read the selected image file as a byte array
                            byte[] imageData = File.ReadAllBytes(openFileDialog.FileName);

                            car cars = new car()
                            {
                                carMake = carMakeTxt.Text,
                                carModel = carModelTxt.Text,
                                year = year,
                                Price = price,
                                Quantity = quantity
                            };

                            database database = new database();
                            database.InsertCar(cars, imageData);
                            display();
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


        private void viewBtn_Click(object sender, EventArgs e)
        {
            carView CarView = new carView();
            CarView.Show();
            this.Hide();
        }
    }
}
