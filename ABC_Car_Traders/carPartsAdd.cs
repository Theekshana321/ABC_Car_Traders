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
    public partial class carPartsAdd : Form
    {
        private database database;
        public carPartsAdd()
        {
            InitializeComponent();
            database = new database();
        }

        public void display()
        {
            database database = new database();

        }

        private void carPartBackBtn_Click(object sender, EventArgs e)
        {
            adminDashboard obj = new adminDashboard();
            obj.Show();
            this.Close();
        }

        private void carPartviewBtn_Click(object sender, EventArgs e)
        {
            carPartView obj = new carPartView();
            obj.Show();
            this.Hide();
        }

        private void carPartInstBtn_Click(object sender, EventArgs e)
        {
            int quantity;
            if (int.TryParse(partQuantityTxt.Text, out quantity))
            {
                decimal price;
                if (decimal.TryParse(partPriceTxt.Text, out price))
                {
                    carPart carPart = new carPart()
                    {
                        partName = partNameTxt.Text,
                        description = partDescTxt.Text,
                        Price = price,
                        Quantity = quantity
                    };

                    // Use an OpenFileDialog to select the image file
                    OpenFileDialog openFileDialog = new OpenFileDialog();
                    openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Read the selected image file as a byte array
                        byte[] imageData = File.ReadAllBytes(openFileDialog.FileName);

                        database database = new database();
                        database.InsertCarParts(carPart, imageData);
                        display();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid price. Please enter a valid number.");
                }
            }
            else
            {
                MessageBox.Show("Invalid quantity. Please enter a valid number.");
            }
        }
    }
}
