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
    public partial class InvoiceLayout : UserControl
    {
        public InvoiceLayout()
        {
            InitializeComponent();
        }
        public void ShowInvoiceLayout(string productName, int itemPrice, int quantity, double subtotal)
        {
            if (prodNamelbl != null && ITpricelbl != null && qtylbl != null && lblsubTotal != null)
            {

                prodNamelbl.Text = productName;
                prodNamelbl.Visible = true;
                ITpricelbl.Text = itemPrice.ToString();
                ITpricelbl.Visible = true;
                qtylbl.Text = quantity.ToString();
                qtylbl.Visible = true;
                lblsubTotal.Text = subtotal.ToString("F2");
                lblsubTotal.Visible = true;
            }
            else
            {
                MessageBox.Show("One or more labels are not initialized in InvoiceLayout.");
            }


        }
    }
}
