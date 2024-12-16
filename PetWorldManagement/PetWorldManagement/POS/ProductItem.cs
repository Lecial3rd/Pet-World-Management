using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetWorldManagement.POS
{
    public partial class ProductItem : UserControl
    {
        public ProductItem()
        {
            InitializeComponent();
        }
        public void ProductDetails(string name, double price, Image imageData)
        {
            label1.Text = name;
            Price.Text = $"₱{price:F2}";
            if (imageData != null)
            {
                try
                {
                    pictureBox1.Image = imageData;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error displaying image: {ex.Message}");
                    pictureBox1.Image = null;
                }
            }
            else
            {
                pictureBox1.Image = null;
            }
        }

    }
}
