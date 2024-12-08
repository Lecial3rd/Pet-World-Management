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
            // Clear previous values
            lblServiceName.Text = string.Empty;
            lblQuantity.Text = string.Empty;
            lblAmount.Text = string.Empty;

            // Fetch and display the services associated with the appointment
            DataTable services = appointmentRepository.GetAppointmentServices(appointmentId);

            // Assuming you have labels or a list to display the services
            foreach (DataRow row in services.Rows)
            {
                // Trim the values to remove any leading or trailing whitespace
                string serviceName = row["ServiceName"].ToString().Trim();
                string quantity = row["Quantity"].ToString().Trim();
                string totalAmount = Convert.ToDecimal(row["TotalAmount"]).ToString("C").Trim(); // Format as currency

                // Display service details
                lblServiceName.Text += serviceName + "\n";
                lblQuantity.Text += quantity + "\n";
                lblAmount.Text += totalAmount + "\n";
            }
        }
    }
}