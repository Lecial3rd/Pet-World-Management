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
    public partial class CategoryPageForm : Form
    {
        private readonly RepositoryFacade<CategoryObject> categoryFacade;
        public CategoryPageForm()
        {
            InitializeComponent();

            IRepositoryFactory factory = new RepositoryFactory();
            categoryFacade = new RepositoryFacade<CategoryObject>(factory);
            LoadCategories();
        }

        private void LoadCategories()
        {
            DataTable dt = categoryFacade.GetAll();
            dataGridViewCategories.DataSource = dt;
            loadColumn();
        }

        private void loadColumn()
        {
            // Clear any existing columns before adding new ones
            dataGridViewCategories.Columns.Clear();

            // Add CategoryID column
            DataGridViewTextBoxColumn colID = new DataGridViewTextBoxColumn
            {
                HeaderText = "ID",
                DataPropertyName = "CategoryID",
                Name = "Category ID",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            };
            dataGridViewCategories.Columns.Add(colID); // Add ID column

            // Add CategoryName column
            DataGridViewTextBoxColumn colName = new DataGridViewTextBoxColumn
            {
                HeaderText = "Name",
                DataPropertyName = "CategoryName",
                Name = "Category Name",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };
            dataGridViewCategories.Columns.Add(colName); // Add Name column

            // Add Delete button column
            DataGridViewButtonColumn colDelete = new DataGridViewButtonColumn
            {
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells,
                HeaderText = "Action",
                Name = "Delete",
                Text = "DELETE",
                UseColumnTextForButtonValue = true
            };
            colDelete.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Regular);
            dataGridViewCategories.Columns.Add(colDelete);

            dataGridViewCategories.Columns[0].ReadOnly = true;
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string categoryName = txtCategoryName.Text.Trim();
            if (!string.IsNullOrEmpty(categoryName))
            {
                try
                {
                    CategoryObject category = new CategoryObject();
                    category.CategoryName = categoryName;

                    categoryFacade.Add(category);
                    MessageBox.Show("Category added successfully!");
                    LoadCategories(); // Refresh list after adding
                    txtCategoryName.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error adding category: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Category name cannot be empty!");
            }
        }

        private void dataGridViewCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewCategories.Columns["Delete"].Index)
            {
                try
                {
                    int categoryID = Convert.ToInt32(dataGridViewCategories.Rows[e.RowIndex].Cells["Category ID"].Value);
                    try
                    {
                        categoryFacade.Delete(categoryID);
                        MessageBox.Show("Category deleted successfully!");
                        LoadCategories(); // Refresh list after deletion
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting category: {ex.Message}");
                    }
                }
                catch (Exception a)
                {
                    MessageBox.Show($"Error: {a.Message}");
                }
            }
        }

        private void dataGridViewCategories_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewCategories.Columns["Category Name"].Index)
            {
                try
                {
                    // Get the CategoryID and updated CategoryName
                    int categoryId = Convert.ToInt32(dataGridViewCategories.Rows[e.RowIndex].Cells["Category ID"].Value);
                    string updatedCategoryName = dataGridViewCategories.Rows[e.RowIndex].Cells["Category Name"].Value.ToString().Trim();

                    // Update the category in the database
                    if (!string.IsNullOrEmpty(updatedCategoryName))
                    {
                        CategoryObject category = new CategoryObject();
                        category.CategoryID = categoryId;
                        category.CategoryName = updatedCategoryName;

                        categoryFacade.Update(category);
                        MessageBox.Show("Category updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Category name cannot be empty!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating category: {ex.Message}");
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;
            DataTable filteredProducts = categoryFacade.Search(keyword);
            dataGridViewCategories.DataSource = filteredProducts;
        }
    }
}
