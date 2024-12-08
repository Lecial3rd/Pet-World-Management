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
    public partial class ProductControl : UserControl
    {
        public double defaultPrice { get; set; }
        public string pname { get; set; }
        public ProductControl()
        {
            InitializeComponent();
        }
        public void SetProductControl(string productName, int quantity, double price, int productID)
        {
            lblPName.Text = productName;
            lblPName.Visible = true;


            txtQuantity.Text = quantity > 0 ? quantity.ToString() : "1";

            txtQuantity.Visible = true;




            lblprice.Text = (quantity * price).ToString("N2");
            lblprice.Visible = true;
            this.Tag = productID;
            this.defaultPrice = price;
            this.pname = productName;

            btnAddQuantity.Visible = true;
            btnMinusProduct.Visible = true;
            btnRemove.Visible = true;

        }
        public event Action QuantityChanged;

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
               
                return;
            }

           
            if (int.TryParse(txtQuantity.Text, out int quantity) && quantity > 0)
            {
                
                QuantityChanged?.Invoke();
            }
            else
            {
                
                MessageBox.Show("Invalid Quantity entered! Please enter a number greater than 0.");
                txtQuantity.Text = "1";  
            }



        }
    }
}
