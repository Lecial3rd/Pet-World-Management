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

namespace PetWorldManagement
{
    public partial class AddProductForm : Form
    {
        private int productID = -1; // Default to -1 for new products
        private byte[] imageBytes = null;
        private readonly RepositoryFacade<ProductObject> productFacade;
        private readonly RepositoryFacade<CategoryObject> categoryFacade;

        public AddProductForm(IRepositoryFactory factory)
        {
            InitializeComponent();

            // Use the factory to create the repository facades
            productFacade = new RepositoryFacade<ProductObject>(factory);
            categoryFacade = new RepositoryFacade<CategoryObject>(factory);

            LoadCategories();
        }

        public void SetProductData(DataGridViewRow row)
        {
            productID = Convert.ToInt32(row.Cells["ProductID"].Value);
            txtProductName.Text = row.Cells["Product Name"].Value.ToString();
            txtPrice.Text = row.Cells["Price"].Value.ToString();
            comboCategory.SelectedValue = row.Cells["CategoryID"].Value;
            txtDescription.Text = row.Cells["Description"].Value.ToString();

            btnSubmit.Text = "UPDATE";
        }

        private void LoadCategories()
        {
            DataTable categories = categoryFacade.GetAll();
            comboCategory.DataSource = categories;
            comboCategory.DisplayMember = "CategoryName";
            comboCategory.ValueMember = "CategoryID";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Check if any required field is empty
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Product Name is required.");
                return;
            }

            if (comboCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a category.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Description is required.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Price is required.");
                return;
            }

            // Additional check to ensure the price is a valid decimal
            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Please enter a valid price.");
                return;
            }

            // Proceed with creating the product object if all validations pass
            ProductObject product = new ProductObject
            {
                ProductID = productID,
                ProductName = txtProductName.Text,
                CategoryID = Convert.ToInt32(comboCategory.SelectedValue),
                Description = txtDescription.Text,
                Price = price,
                ProductImage = imageBytes // Store the byte array in the Product object
            };

            // Check if adding a new product or updating an existing one
            if (productID == -1)
            {
                // Check if the image is provided
                if (imageBytes == null || imageBytes.Length == 0)
                {
                    MessageBox.Show("Please upload a product image.");
                    return;
                }

                productFacade.Add(product);
                MessageBox.Show("Product Added Successfully!");
            }
            else
            {
                productFacade.Update(product);
                MessageBox.Show("Product Updated Successfully!");
            }

            this.Close(); // Close the form after submission
        }


        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                pictureBoxProduct.Image = Image.FromFile(imagePath);

                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBoxProduct.Image.Save(ms, pictureBoxProduct.Image.RawFormat);
                    imageBytes = ms.ToArray(); // Store the image as a byte array
                }
            }
        }
    }
}
