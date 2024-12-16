using System;
using System.Data;
using System.Windows.Forms;
using PetWorldManagement.Service;

namespace PetWorldManagement.Service
{
    public partial class ServiceForm : Form
    {
        private readonly RepositoryFacade<ServiceObject> serviceFacade;

        public ServiceForm()
        {
            IRepositoryFactory factory = new RepositoryFactory();
            serviceFacade = new RepositoryFacade<ServiceObject>(factory);
            InitializeComponent();
            LoadService();
        }

        private void LoadService()
        {
            try
            {
                DataTable services = serviceFacade.GetAll();
                dataGridViewService.Rows.Clear(); // Clear existing rows

                foreach (DataRow row in services.Rows)
                {
                    int rowIndex = dataGridViewService.Rows.Add();
                    dataGridViewService.Rows[rowIndex].Cells["ServiceID"].Value = row["ServiceID"];
                    dataGridViewService.Rows[rowIndex].Cells["Service"].Value = row["ServiceName"];
                    dataGridViewService.Rows[rowIndex].Cells["Price"].Value = row["Price"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading services: " + ex.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string keyword = txtSearch.Text;
                DataTable searchResults = serviceFacade.Search(keyword);
                dataGridViewService.Rows.Clear();

                foreach (DataRow row in searchResults.Rows)
                {
                    int rowIndex = dataGridViewService.Rows.Add();
                    dataGridViewService.Rows[rowIndex].Cells["ServiceID"].Value = row["ServiceID"];
                    dataGridViewService.Rows[rowIndex].Cells["Service"].Value = row["ServiceName"];
                    dataGridViewService.Rows[rowIndex].Cells["Price"].Value = row["Price"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching services: " + ex.Message);
            }
        }

        private void dataGridViewService_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == dataGridViewService.Columns["Delete"].Index && e.RowIndex >= 0)
                {
                    int serviceID = Convert.ToInt32(dataGridViewService.Rows[e.RowIndex].Cells["ServiceID"].Value);
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this service?", "Delete Service", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            serviceFacade.Delete(serviceID);
                            MessageBox.Show("Service deleted successfully.");
                            LoadService();
                        }
                        catch (Exception ex)
                        {
                            if (ex.Message.Contains("FOREIGN KEY"))
                            {
                                MessageBox.Show("Cannot delete this service as it is being used in other records.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                MessageBox.Show("Error deleting service: " + ex.Message);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting service: " + ex.Message);
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            try
            {
                string serviceName = txtService.Text;
                decimal price = Convert.ToDecimal(txtPrice.Text);

                if (string.IsNullOrWhiteSpace(serviceName))
                {
                    MessageBox.Show("Service name cannot be empty.");
                    return;
                }

                ServiceObject newService = new ServiceObject
                {
                    Name = serviceName,
                    Price = price
                };

                serviceFacade.Add(newService);
                MessageBox.Show("Service added successfully.");
                LoadService();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding service: " + ex.Message);
            }
        }

        private void dataGridViewService_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    int serviceID = Convert.ToInt32(dataGridViewService.Rows[e.RowIndex].Cells["ServiceID"].Value);
                    string serviceName = dataGridViewService.Rows[e.RowIndex].Cells["Service"].Value.ToString();
                    decimal price = Convert.ToDecimal(dataGridViewService.Rows[e.RowIndex].Cells["Price"].Value);

                    if (string.IsNullOrWhiteSpace(serviceName))
                    {
                        MessageBox.Show("Service name cannot be empty.");
                        LoadService(); // Reload original values
                        return;
                    }

                    ServiceObject updatedService = new ServiceObject
                    {
                        Id = serviceID,
                        Name = serviceName,
                        Price = price
                    };

                    serviceFacade.Update(updatedService);
                    MessageBox.Show("Service updated successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating service: " + ex.Message);
                LoadService(); // Reload original values to prevent invalid data in the grid
            }
        }
    }
}
