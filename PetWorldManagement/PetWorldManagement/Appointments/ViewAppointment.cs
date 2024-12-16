using System;
using System.Data;
using System.Windows.Forms;
using PetWorldManagement.Repository;

namespace PetWorldManagement.Appointments
{
    public partial class ViewAppointment : Form
    {
        private readonly AppointmentRepository appointmentRepository;
        private int appointmentId;

        public ViewAppointment(int appointmentId)
        {
            InitializeComponent();
            this.appointmentId = appointmentId;
            appointmentRepository = new AppointmentRepository();
            LoadAppointmentDetails();
        }

        private void LoadAppointmentDetails()
        {
            // Get the appointment details from the repository
            AppointmentObject appointment = appointmentRepository.GetAppointmentById(appointmentId);

            if (appointment != null)
            {
                // Populate the labels with the appointment details
                lblAppointmentID.Text = appointment.AppointmentID.ToString();
                lblCustomerName.Text = appointment.CustomerName;
                lblPetName.Text = appointment.PetName;
                lblAppointmentDate.Text = appointment.AppointmentDate.ToString("MM/dd/yyyy");

                // Fetch the status and staff names from the repository
                lblStatus.Text = appointmentRepository.GetStatusName(appointment.StatusID);
                lblStaff.Text = appointmentRepository.GetStaffName(appointment.StaffID);

                // Load associated services
                LoadAppointmentServices(appointment.AppointmentID);
            }
            else
            {
                MessageBox.Show("Appointment not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAppointmentServices(int appointmentId)
        {
            try
            {
                // Retrieve appointment services from the database
                DataTable services = appointmentRepository.GetAppointmentServices(appointmentId);


                // Iterate through the rows in the DataTable
                foreach (DataRow row in services.Rows)
                {
                    // Extract data from the current row
                    string serviceName = row["ServiceName"].ToString();
                    int quantity = Convert.ToInt32(row["Quantity"]);
                    decimal price = Convert.ToDecimal(row["Price"]);
                    decimal totalAmount = Convert.ToDecimal(row["TotalAmount"]);

                    // Create a new AppointmentInvoiceLayout instance
                    AppointmentInvoiceLayout layout = new AppointmentInvoiceLayout();

                    // Set label values
                    layout.lblServiceName.Text = serviceName;
                    layout.lblQty.Text = quantity.ToString();
                    layout.lblPrice.Text = "₱" + price.ToString("N2"); // Format as currency
                    layout.lblTotalAmount.Text = "₱" + totalAmount.ToString("N2"); // Format as currency

                    // Ensure the labels are visible
                    layout.lblServiceName.Visible = true;
                    layout.lblQty.Visible = true;
                    layout.lblPrice.Visible = true;
                    layout.lblTotalAmount.Visible = true;

                    // Add the layout control to the ServiceFlowLayout
                    ServiceFlowLayout.Controls.Add(layout);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading appointment services: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}