using PetWorldManagement.Repository;
using PetWorldManagement.Supplier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PetWorldManagement
{
    public partial class AddSupplierForm : Form
    {
        private readonly IRepositoryFactory factory;
        public AddSupplierForm(IRepositoryFactory factory)
        {
            this.factory = factory;
            InitializeComponent();
            cbxProduct();
        }

        // Button click event to insert new supplier
        private void btnInsert_Click(object sender, EventArgs e)
        {
            RepositoryFacade<SupplierObject> supplierFacade = new RepositoryFacade<SupplierObject>(factory);
            SupplierObject supplier = new SupplierObject
            {
                SupplierName = txtSupplierName.Text.Trim(),
                address = txtAddress.Text.Trim(),
                contactPerson = txtContactPerson.Text.Trim(),
                contactEmail = txtContactEmail.Text.Trim(),
                contactPhone = txtContactPhone.Text.Trim()
            };

            // Validate required fields
            if (string.IsNullOrWhiteSpace(supplier.SupplierName) ||
                string.IsNullOrWhiteSpace(supplier.address) ||
                string.IsNullOrWhiteSpace(supplier.contactPerson) ||
                string.IsNullOrWhiteSpace(supplier.contactPhone))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            // Check if ProductListBox is empty
            if (ProductListBox.Items.Count == 0)
            {
                MessageBox.Show("The product list is empty. Please add products before proceeding.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                supplierFacade.Add(supplier);
                int supplierID = SupplerIDBridge.getSupplierID();
                addProductSupplier(supplierID);

                MessageBox.Show("Supplier added successfully.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        public void cbxProduct()
        {
            RepositoryFacade<ProductObject> productFacade = new RepositoryFacade<ProductObject>(factory);
            DataTable dt = productFacade.GetAll();
            Product_comboBox.DataSource = dt;
            Product_comboBox.DisplayMember = "ProductName";
            Product_comboBox.ValueMember = "ProductID";
        }

        private void insert_productSupply_BTN_Click(object sender, EventArgs e)
        {
            int productID = Convert.ToInt32(Product_comboBox.SelectedValue);
            string productName = Product_comboBox.Text;

            // Validate input
            if (double.TryParse(textCost.Text, out double pricePerProduct))
            {
                // Add product info to the ListBox in a formatted string
                string listItem = $"{productID} - {productName} - Price: {pricePerProduct}";
                ProductListBox.Items.Add(listItem);
            }
            else
            {
                MessageBox.Show("Invalid price. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            textCost.Text = "";
        }

        public void addProductSupplier(int SupplierID)
        {
            RepositoryFacade<SupplierProductObject> supplierProductFacade = new RepositoryFacade<SupplierProductObject>(factory);

            if (ProductListBox.Items.Count > 0)
            {
                List<SupplierProductObject> supplierProducts = new List<SupplierProductObject>();

                foreach (var item in ProductListBox.Items)
                {
                    string[] details = item.ToString().Split('-');
                    int productID = Convert.ToInt32(details[0].Trim());
                    string productName = details[1].Trim();
                    string price = details[2].Replace("Price:", "").Trim();

                    // Create a new SupplierProductObject and add it to the list
                    SupplierProductObject supplierProduct = new SupplierProductObject
                    {
                        SupplierID = SupplierID,
                        ProductID = productID,
                        ProductCost = Convert.ToDouble(price)
                    };

                    supplierProducts.Add(supplierProduct);
                }
                supplierProductFacade.insertProductSuppliers(supplierProducts);
            }
        }
    }
}
