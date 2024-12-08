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
    public partial class SupplierPageForm : Form
    {
        private readonly RepositoryFacade<SupplierObject> supplierFacade;
        private readonly IRepositoryFactory factory;
        public SupplierPageForm()
        {
            InitializeComponent();

            factory = new RepositoryFactory();
            supplierFacade = new RepositoryFacade<SupplierObject>(factory);

            LoadSuppliers();
            setColumn();
        }

        private void LoadSuppliers()
        {
            try
            {
                DataTable dt = supplierFacade.GetAll();
                dataGridViewSuppliers.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void setColumn()
        {
            // Add DeleteAction button column
            this.DeleteAction.Name = "DeleteAction";
            this.DeleteAction.HeaderText = "Action";
            this.DeleteAction.Text = "DELETE";
            this.DeleteAction.UseColumnTextForButtonValue = true; // Display "Delete" as the button text
            this.DeleteAction.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 10, FontStyle.Regular); // Font for button text
            this.dataGridViewSuppliers.Columns.Add(this.DeleteAction); // Add the button column to the DataGridView
            dataGridViewSuppliers.Columns[0].ReadOnly = true;
        }


        private void dataGridViewSuppliers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewSuppliers.Columns["DeleteAction"].Index)
            {
                int supplierID = Convert.ToInt32(dataGridViewSuppliers.Rows[e.RowIndex].Cells["SupplierID"].Value);
                DeleteSupplier(supplierID);
                LoadSuppliers(); // Reload suppliers after deletion
            }
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            AddSupplierForm addSupplierForm = new AddSupplierForm(factory);
            addSupplierForm.ShowDialog();
            LoadSuppliers(); // Refresh after adding a new supplier
        }

        private void DeleteSupplier(int supplierID)
        {
            try
            {
                supplierFacade.Delete(supplierID);
                MessageBox.Show("Supplier deleted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dataGridViewSuppliers_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Check the row and retrieve updated data
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {
                // Assuming the DataGridView columns match your Supplier properties
                int supplierId = Convert.ToInt32(dataGridViewSuppliers.Rows[rowIndex].Cells["SupplierID"].Value);
                string supplierName = dataGridViewSuppliers.Rows[rowIndex].Cells["SupplierName"].Value.ToString();
                string address = dataGridViewSuppliers.Rows[rowIndex].Cells["Address"].Value.ToString();
                string contactPerson = dataGridViewSuppliers.Rows[rowIndex].Cells["ContactPerson"].Value.ToString();
                string contactEmail = dataGridViewSuppliers.Rows[rowIndex].Cells["ContactEmail"].Value.ToString();
                string contactPhone = dataGridViewSuppliers.Rows[rowIndex].Cells["ContactPhone"].Value.ToString();

                // Create a Supplier object with updated values
                SupplierObject updatedSupplier = new SupplierObject
                {
                    SupplierID = supplierId,
                    SupplierName = supplierName,
                    address = address,
                    contactPerson = contactPerson,
                    contactEmail = contactEmail,
                    contactPhone = contactPhone
                };

                try
                {
                    supplierFacade.Update(updatedSupplier);
                    MessageBox.Show("Supplier details updated successfully.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while updating the supplier: {ex.Message}", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;
            DataTable filteredSuppliers = supplierFacade.Search(keyword);
            dataGridViewSuppliers.DataSource = filteredSuppliers;
        }
    }
}
