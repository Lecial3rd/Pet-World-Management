using System;
using System.Data;
using System.Windows.Forms;
using PetWorldManagement.Appointments;
using PetWorldManagement.POS;

namespace PetWorldManagement.Invoice
{
    public partial class Invoice : Form
    {
        private readonly RepositoryFacade<AppointmentObject> invoiceFacade;
        private readonly IRepositoryFactory factory;

        public Invoice()
        {
            factory = new RepositoryFactory();
            invoiceFacade = new RepositoryFacade<AppointmentObject>(factory);

            InitializeComponent();
            LoadInvoice();
        }

        private void LoadInvoice()
        {
            try
            {
                // Fetch all invoices using the facade
                DataTable invoices = invoiceFacade.GetAllInvoices();
                PopulateDataGridView(invoices);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading invoices: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateDataGridView(DataTable invoices)
        {
            dataGridViewInvoice.Rows.Clear();

            foreach (DataRow row in invoices.Rows)
            {
                // Populate DataGridView with invoice data
                dataGridViewInvoice.Rows.Add(
                    row["ID"],
                    row["Type"],
                    row["Transaction ID"],
                    row["Appointment ID"],
                    row["Date"],
                    row["TotalAmount"]
                );
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchText = txtSearch.Text.Trim();
                DataTable filteredInvoices;

                // Perform search on invoice details
                if (string.IsNullOrEmpty(searchText))
                {
                    filteredInvoices = invoiceFacade.GetAllInvoices();
                }
                else
                {
                    filteredInvoices = invoiceFacade.SearchInvoice(searchText);
                }

                PopulateDataGridView(filteredInvoices);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during the search: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewInvoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewInvoice.Columns["View"].Index) 
            {
                int invoiceID = Convert.ToInt32(dataGridViewInvoice.Rows[e.RowIndex].Cells[0].Value);
                int appointmentID = Convert.ToInt32(dataGridViewInvoice.Rows[e.RowIndex].Cells[3].Value);

                if (appointmentID != 0)
                {
                    DisplayInvoiceAppointment(invoiceID);
                }
                else
                {
                    DisplayInvoiceSales(invoiceID);
                }
            }
        }

        private void DisplayInvoiceAppointment(int appointmentID)
        {
            InvoiceAppointmentForm invoice = new InvoiceAppointmentForm();

            try
            {
                DataTable invoiceDetails = invoiceFacade.ViewSpecificAppointmentInvoice(appointmentID);

                if (invoiceDetails.Rows.Count == 0)
                {
                    MessageBox.Show("No invoice details found for the given Appointment ID.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                bool isInvoiceDetailsFetched = false;

                foreach (DataRow row in invoiceDetails.Rows)
                {
                    if (!isInvoiceDetailsFetched)
                    {
                        invoice.lblInvoiceID.Text = row["AppointmentID"].ToString();
                        invoice.lblCustomer.Text = row["CustomerName"].ToString();
                        invoice.lblPet.Text = row["PetName"].ToString();
                        invoice.lblInvoiceDate.Text = DateTime.Now.ToString("MMMM dd, yyyy");

                        decimal totalPrice = Convert.ToDecimal(row["TotalPrice"]);
                        decimal grandTotal = Convert.ToDecimal(row["GrandTotal"]);
                        int discountRate = Convert.ToInt32(row["DiscountRate"]);
                        decimal dbChange = Convert.ToDecimal(row["Change"]);
                        decimal cashReceived = Convert.ToDecimal(row["CashReceived"]);

                        invoice.lblDR.Text = discountRate.ToString();
                        invoice.lblTAmount.Text = "₱" + grandTotal.ToString("N2");
                        invoice.cshrcvlbl.Text = "₱" + cashReceived.ToString("N2");
                        invoice.changelbl.Text = "₱" + dbChange.ToString("N2");
                        invoice.paymentMethod.Text = row["PaymentMethod"].ToString();

                        invoice.lblTAmount.Visible = true;
                        isInvoiceDetailsFetched = true;
                    }

                    string serviceName = row["ServiceName"].ToString();
                    int quantity = Convert.ToInt32(row["Quantity"]);
                    decimal price = Convert.ToDecimal(row["Price"]);
                    decimal subtotal = Convert.ToDecimal(row["TotalPrice"]);

                    InvoiceLayout invoiceItemLayout = new InvoiceLayout();
                    invoiceItemLayout.ShowInvoiceLayout(serviceName, price, quantity, (double)subtotal);
                    invoice.InvoiceFlowLayout.Controls.Add(invoiceItemLayout);
                    invoice.InvoiceFlowLayout.Controls.Add(invoice.summaryPNL);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            invoice.Show();
        }

        private void DisplayInvoiceSales(int invoiceID)
        {
            InvoiceForm invoiceDisplay = new InvoiceForm();

            try
            {
                DataTable invoiceDetails = invoiceFacade.ViewSpecificSalesInvoice(invoiceID);

                if (invoiceDetails.Rows.Count == 0)
                {
                    MessageBox.Show("No invoice details found for the given Invoice ID.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                bool isInvoiceDetailsFetched = false;

                foreach (DataRow row in invoiceDetails.Rows)
                {
                    if (!isInvoiceDetailsFetched)
                    {
                        invoiceDisplay.lblInvoiceID.Text = row["InvoiceID"].ToString();
                        invoiceDisplay.lblInvoiceDate.Text = Convert.ToDateTime(row["InvoiceDate"]).ToString("MMMM dd, yyyy");

                        decimal totalAmount = Convert.ToDecimal(row["TotalAmount"]);
                        
                        decimal discountRate = Convert.ToDecimal(row["DiscountRate"]);
                        decimal dbChange = Convert.ToDecimal(row["Change"]);
                        decimal amount = Convert.ToDecimal(row["Amount"]);
                        string paymentMethod = row["PaymentMethod"].ToString();

                        invoiceDisplay.lblDR.Text = discountRate.ToString();
                        invoiceDisplay.lblTAmount.Text = totalAmount.ToString("N2");
                        invoiceDisplay.cshrcvlbl.Text = amount.ToString("N2");
                        invoiceDisplay.changelbl.Text = dbChange.ToString("N2");
                        invoiceDisplay.paymentMethod.Text = paymentMethod;

                        invoiceDisplay.lblTAmount.Visible = true;
                        isInvoiceDetailsFetched = true;
                    }

                    string productName = row["ProductName"].ToString();
                    int quantity = Convert.ToInt32(row["QuantitySold"]);
                    decimal itemPrice = Convert.ToDecimal(row["ItemPrice"]);
                    decimal subtotal = Convert.ToDecimal(row["SubTotal"]);

                    InvoiceLayout invoiceItemLayout = new InvoiceLayout();
                    invoiceItemLayout.ShowInvoiceLayout(productName, itemPrice, quantity, (double)subtotal);
                    invoiceDisplay.InvoiceFlowLayout.Controls.Add(invoiceItemLayout);
                }

                invoiceDisplay.InvoiceFlowLayout.Controls.Add(invoiceDisplay.summaryPNL);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            invoiceDisplay.Show();
        }

    }
}
