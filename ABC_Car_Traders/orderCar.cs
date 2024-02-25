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
    public partial class orderCar : Form
    {
        private int CarID { get; set; }
        private database database;

        public orderCar(int carId)
        {
            InitializeComponent();
            //database = new database();
            CarID = carId;
            
            LoadCarDetails();
        }

        public void LoadCarDetails()
        {
            database database = new database();
            // Get the car details
            car Car = database.GetCarDetails(CarID);

            if (Car != null)
            {
                
                carMakeTxt.Text = Car.carMake;
                carModelTxt.Text = Car.carModel;
                
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

        private void orderCar_Load(object sender, EventArgs e)
        {

        }

        private void carPayBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Payment successful!", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void cancelOrderBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order canceled.", "Cancellation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
