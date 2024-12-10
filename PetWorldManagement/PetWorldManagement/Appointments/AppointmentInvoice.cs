using System;
using System.Data;
using System.Windows.Forms;
using PetWorldManagement.Repository;

namespace PetWorldManagement.Appointments
{
    public partial class AppointmentInvoice : Form
    {
        private int appointmentId;
        private decimal discountRate;
        private decimal cashReceived;
        private decimal totalAmount;
        private decimal change;

        public AppointmentInvoice(int appointmentId, decimal discountRate, decimal cashReceived, decimal totalAmount, decimal change)
        {
            InitializeComponent();
            this.appointmentId = appointmentId;
            this.discountRate = discountRate;
            this.cashReceived = cashReceived;
            this.totalAmount = totalAmount;
            this.change = change;

            // Load invoice details based on appointmentId
            LoadInvoiceDetails();
        }

        private void LoadInvoiceDetails()
        {
            AppointmentRepository repository = new AppointmentRepository();
            DataTable invoiceTable = repository.GetInvoiceByAppointmentId(appointmentId);

            if (invoiceTable.Rows.Count > 0)
            {
                DataRow invoiceRow = invoiceTable.Rows[0];
                lblInvoiceID.Text = invoiceRow["InvoiceID"].ToString();
                lblInvoiceDate.Text = Convert.ToDateTime(invoiceRow["InvoiceDate"]).ToString("yyyy-MM-dd");
                lblTotalAmount.Text = $"{totalAmount:C2}"; // Display the effective total amount
                lbldiscountRate.Text = $"{discountRate}%"; // Display the discount rate as a percentage
                lblCashReceive.Text = $"{cashReceived:C2}"; // Display the cash received
                lblChange.Text = $"{change:C2}"; // Display the change

                // Fetch services based on the appointment ID
                DataTable services = repository.GetAppointmentServices(appointmentId);

                // Debugging: Check if services are retrieved
                if (services.Rows.Count == 0)
                {
                    MessageBox.Show("No services found for this appointment.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                DisplayServices(services);
            }
            else
            {
                MessageBox.Show("Failed to load invoice details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayServices(DataTable services)
        {
            ServiceFlowLayout.Controls.Clear();

            foreach (DataRow row in services.Rows)
            {
                AppointmentInvoiceLayout serviceLayout = new AppointmentInvoiceLayout();

                // Ensure the column names match those in your DataTable
                serviceLayout.lblServiceName.Text = row["ServiceName"].ToString();
                serviceLayout.lblPrice.Text = $"{Convert.ToDecimal(row["Price"]):C2}"; // Ensure this matches the column name
                serviceLayout.lblQty.Text = row["Quantity"].ToString();
                serviceLayout.lblTotalAmount.Text = $"{Convert.ToDecimal(row["TotalAmount"]):C2}";

                // Make the labels visible
                serviceLayout.lblServiceName.Visible = true;
                serviceLayout.lblQty.Visible = true;
                serviceLayout.lblPrice.Visible = true;
                serviceLayout.lblTotalAmount.Visible = true;

                // Add the layout to the ServiceFlowLayout
                ServiceFlowLayout.Controls.Add(serviceLayout);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}