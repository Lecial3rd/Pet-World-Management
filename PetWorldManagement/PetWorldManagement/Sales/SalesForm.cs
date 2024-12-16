using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PetWorldManagement.Sales
{
    public partial class SalesForm : Form
    {
        public SalesForm()
        {
            InitializeComponent();

            // Set default value for cbxType and configure DataGridView columns
            cbxType.SelectedIndex = 0;

            // Ensure DataGridView columns exist
            if (dataGridViewSales.Columns.Count == 0)
            {
                dataGridViewSales.Columns.Add("Type", "Type");
                dataGridViewSales.Columns.Add("TotalAmount", "Total Amount");
            }
        }

        private void FilterData()
        {
            string procedureName = "cpSales";

            DateTime startDate = dateTimePickerStart.Value;
            DateTime endDate = dateTimePickerEnd.Value;
            string type = cbxType.SelectedItem?.ToString();

            using (SqlConnection connection = DatabaseConn.getInstance().GetConnection())
            {
                using (SqlCommand command = new SqlCommand(procedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@StartDate", startDate);
                    command.Parameters.AddWithValue("@EndDate", endDate);

                    if (string.IsNullOrEmpty(type) || type == "All")
                    {
                        command.Parameters.AddWithValue("@Type", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@Type", type);
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    try
                    {
                        connection.Open();
                        adapter.Fill(dataTable);

                        // Add rows to dataGridViewSales and calculate total amount
                        dataGridViewSales.Rows.Clear();
                        decimal totalAmount = 0;

                        foreach (DataRow row in dataTable.Rows)
                        {
                            // Add row directly with Type and Total Amount
                            dataGridViewSales.Rows.Add(
                                row["InvoiceType"].ToString(),
                                row["TotalAmount"] != DBNull.Value ? Convert.ToDecimal(row["TotalAmount"]) : 0
                            );

                            // Accumulate total amount
                            totalAmount += row["TotalAmount"] != DBNull.Value ? Convert.ToDecimal(row["TotalAmount"]) : 0;
                        }

                        // Display total amount in lblSales
                        lblSales.Text = $"₱{totalAmount:N}";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void cbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }
    }
}
