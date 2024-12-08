using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetWorldManagement
{
    public partial class ProductPageForm : Form
    {
        private readonly RepositoryFacade<ProductObject> productFacade;
        private readonly IRepositoryFactory factory;
        private readonly Dashboard dashboard;

        public ProductPageForm(Dashboard dashboard)
        {
            this.dashboard = dashboard;
            InitializeComponent();

            factory = new RepositoryFactory();
            productFacade = new RepositoryFacade<ProductObject>(factory);

            LoadProducts();
        }


        private void LoadProducts()
        {
            DataTable products = productFacade.GetAll();
            DisplayProducts(products);
        }

        private void DisplayProducts(DataTable products)
        {
            dataGridViewProducts.DataSource = products;

            if (dataGridViewProducts.Columns["Update Action"] == null && dataGridViewProducts.Columns["Delete Action"] == null)
            {
                AddActionButtonsToGrid(); // Add Update and Delete buttons only once
            }

            AutoSizeGridColumns(); // Adjust column sizes after loading data
        }

        private void AutoSizeGridColumns()
        {
            foreach (DataGridViewColumn column in dataGridViewProducts.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void AddActionButtonsToGrid()
        {
            DataGridViewButtonColumn updateButton = new DataGridViewButtonColumn
            {
                Name = "Update Action",
                Text = "UPDATE",
                UseColumnTextForButtonValue = true
            };
            updateButton.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Regular);
            dataGridViewProducts.Columns.Add(updateButton);

            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn
            {
                Name = "Delete Action",
                Text = "DELETE",
                UseColumnTextForButtonValue = true
            };
            deleteButton.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Regular);
            dataGridViewProducts.Columns.Add(deleteButton);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm(factory);
            addProductForm.ShowDialog(); // Open in add mode (default)
            LoadProducts(); // Refresh product list after adding
        }

        private void dataGridViewProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewProducts.Rows[e.RowIndex];
                int productId = Convert.ToInt32(row.Cells["ProductID"].Value);

                if (e.ColumnIndex == dataGridViewProducts.Columns["Update Action"].Index)
                {
                    // Open form in update mode
                    AddProductForm updateForm = new AddProductForm(factory);
                    updateForm.SetProductData(row);
                    updateForm.ShowDialog();
                    LoadProducts(); // Refresh grid after update
                }
                else if (e.ColumnIndex == dataGridViewProducts.Columns["Delete Action"].Index)
                {
                    var confirmResult = MessageBox.Show("Are you sure to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        productFacade.Delete(productId);
                        LoadProducts();
                    }
                }
            }
        }

        private void productCategory_btn_Click(object sender, EventArgs e)
        {
            dashboard.LoadForm(new CategoryPageForm());
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;
            DataTable filteredProducts = productFacade.Search(keyword);
            DisplayProducts(filteredProducts);
        }
    }
}
