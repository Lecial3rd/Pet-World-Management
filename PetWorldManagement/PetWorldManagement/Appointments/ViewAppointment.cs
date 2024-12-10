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
            ServiceFlowLayout.Controls.Clear();

            DataTable services = appointmentRepository.GetAppointmentServices(appointmentId);

            foreach (DataRow row in services.Rows)
            {
                int serviceId = Convert.ToInt32(row["ServiceID"]); // This should now work
                int quantity = Convert.ToInt32(row["Quantity"]);
                decimal totalAmount = Convert.ToDecimal(row["TotalAmount"]);

                // Create a new instance of AppointmentInvoiceLayout
                AppointmentInvoiceLayout layout = new AppointmentInvoiceLayout();

                // Set the values for the layout
                layout.lblServiceName.Text = row["ServiceName"].ToString(); // Use the ServiceName from the DataRow
                layout.lblQty.Text = quantity.ToString();
                layout.lblPrice.Text = appointmentRepository.GetServicePrice(serviceId).ToString("C"); // Format as currency
                layout.lblTotalAmount.Text = totalAmount.ToString("C"); // Format as currency

                // Make the labels visible
                layout.lblServiceName.Visible = true;
                layout.lblQty.Visible = true;
                layout.lblPrice.Visible = true;
                layout.lblTotalAmount.Visible = true;

                // Add the layout to the ServiceFlowLayout
                ServiceFlowLayout.Controls.Add(layout);
            }
        }
    }
}