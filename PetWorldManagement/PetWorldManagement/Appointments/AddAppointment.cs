using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using PetWorldManagement.Appointments;
using PetWorldManagement.Repository;

namespace PetWorldManagement.Appointments
{
    public partial class AddAppointment : Form
    {
        private readonly AppointmentRepository _appointmentRepository;

        public AddAppointment()
        {
            InitializeComponent();
            _appointmentRepository = new AppointmentRepository();
            LoadStaffComboBox();
            LoadServiceComboBox(); // Load services into the ComboBox
            SetDefaultStatus();
        }

        private void LoadStaffComboBox()
        {
            // Load staff members into the combo box
            DataTable staffData = _appointmentRepository.GetStaffData();
            DataTable busyStaffData = GetBusyStaffData(); // Get busy staff data

            // Filter out busy staff from the staffData
            foreach (DataRow row in busyStaffData.Rows)
            {
                int busyStaffId = (int)row["StaffID"];
                DataRow[] rowsToRemove = staffData.Select($"StaffID = {busyStaffId}");
                foreach (var r in rowsToRemove)
                {
                    staffData.Rows.Remove(r);
                }
            }

            // Check if all staff are busy
            if (staffData.Rows.Count == 0)
            {
                MessageBox.Show("All staff members are currently busy. Please try again later.", "Apology", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboStaff.Enabled = false; // Disable the ComboBox to prevent selection
                btnInsert.Enabled = false;
                return;
            }

            comboStaff.DataSource = staffData;
            comboStaff.DisplayMember = "FullName"; // Assuming FullName is a column in the result
            comboStaff.ValueMember = "StaffID"; // Assuming StaffID is a column in the result
        }

        private DataTable GetBusyStaffData()
        {
            // Retrieve busy staff data from the database
            DataTable dt = new DataTable();
            using (SqlConnection conn = DatabaseConn.getInstance().GetConnection())
            {
                string query = @"
                    SELECT StaffID 
                    FROM Appointment 
                    WHERE StatusID = 3"; // Assuming 3 is the ID for "Busy"
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dt);
            }
            return dt;
        }

        private void LoadServiceComboBox()
        {
            // Load services into the combo box
            DataTable serviceData = _appointmentRepository.GetServiceData();
            Service_comboBox.DataSource = serviceData;
            Service_comboBox.DisplayMember = "ServiceName"; // Assuming ServiceName is a column in the result
            Service_comboBox.ValueMember = "ServiceID"; // Assuming ServiceID is a column in the result

            // Add event handler for when the selected service changes
            Service_comboBox.SelectedIndexChanged += Service_comboBox_SelectedIndexChanged;
        }

        private void Service_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected service ID
            if (Service_comboBox.SelectedValue != null)
            {
                int serviceId = (int)Service_comboBox.SelectedValue;
                decimal price = GetServicePrice(serviceId);
                textCost.Text = price.ToString("F2"); // Format price to 2 decimal places
            }
        }

        private void SetDefaultStatus()
        {
            // Set the default status to "Busy"
            txtStatus.Text = "Busy";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if the serviceLayout is empty
                if (serviceLayout.Controls.Count == 0)
                {
                    MessageBox.Show("Please add at least one service before saving the appointment.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Exit the method if no services are added
                }

                // Gather input data
                string customerName = txtCustomerName.Text.Trim();
                string petName = txtPetName.Text.Trim();
                DateTime appointmentDate = dtp_Appointment.Value;
                int staffId = (int)comboStaff.SelectedValue; // Get selected staff ID
                int statusId = 3; // Set status ID to 3 for "Busy"

                // Validate input
                ValidateInput(customerName, petName, appointmentDate);

                // Create new appointment object
                var newAppointment = new AppointmentObject
                {
                    CustomerName = customerName,
                    PetName = petName,
                    AppointmentDate = appointmentDate,
                    StaffID = staffId,
                    StatusID = statusId // Use the status ID for "Busy"
                };

                // Save to repository
                _appointmentRepository.Add(newAppointment);

                // Get the last inserted appointment ID
                int appointmentId = _appointmentRepository.GetLastInsertedAppointmentId();

                // Add selected services to the AppointmentService table
                foreach (Control control in serviceLayout.Controls)
                {
                    if (control is AppointmentControl appointmentControl)
                    {
                        string serviceName = appointmentControl.lblSName.Text;
                        int quantity = int.Parse(appointmentControl.txtQuantity.Text);
                        decimal totalAmount = decimal.Parse(appointmentControl.lblamount.Text);

                        // Get the service ID based on the service name
                        int serviceId = GetServiceIdByName(serviceName);
                        if (serviceId == -1)
                        {
                            MessageBox.Show($"Service not found: {serviceName}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            continue; // Skip this item if service ID is not found
                        }

                        // Check if the service already exists in the AppointmentService table
                        if (ServiceExistsInAppointment(appointmentId, serviceId))
                        {
                            // Update the quantity if the service already exists
                            UpdateServiceQuantity(appointmentId, serviceId, quantity, totalAmount);
                        }
                        else
                        {
                            // Add the service to the AppointmentService table
                            _appointmentRepository.AddAppointmentService(appointmentId, serviceId, quantity, totalAmount);
                        }
                    }
                }

                MessageBox.Show("Appointment added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Close the form after successful addition
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ServiceExistsInAppointment(int appointmentId, int serviceId)
        {
            // Check if the service already exists for the given appointment
            return _appointmentRepository.CheckServiceExists(appointmentId, serviceId);
        }

        private void UpdateServiceQuantity(int appointmentId, int serviceId, int quantity, decimal totalAmount)
        {
            // Update the quantity of the existing service in the AppointmentService table
            _appointmentRepository.UpdateAppointmentServiceQuantity(appointmentId, serviceId, quantity, totalAmount);
            MessageBox.Show("Service quantity updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private int GetServiceIdByName(string serviceName)
        {
            DataTable serviceData = _appointmentRepository.GetServiceData();
            foreach (DataRow row in serviceData.Rows)
            {
                if (row["ServiceName"].ToString() == serviceName)
                {
                    return (int)row["ServiceID"];
                }
            }
            return -1; // Return -1 if not found
        }

        private void insert_serviceSupply_BTN_Click(object sender, EventArgs e)
        {
            // Check if a service is selected and quantity is provided
            if (Service_comboBox.SelectedValue != null && !string.IsNullOrWhiteSpace(txtQty.Text))
            {
                int serviceId = (int)Service_comboBox.SelectedValue; // Get selected service ID
                string serviceName = Service_comboBox.Text; // Get selected service name

                // Safely parse the quantity
                int quantity;
                if (!int.TryParse(txtQty.Text, out quantity) || quantity <= 0)
                {
                    MessageBox.Show("Please enter a valid quantity greater than 0.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Exit the method if parsing fails or quantity is not positive
                }

                // Check if the service already exists in the FlowLayoutPanel
                foreach (Control control in serviceLayout.Controls)
                {
                    if (control is AppointmentControl appointmentControl && appointmentControl.lblSName.Text == serviceName)
                    {
                        // Update the existing service's quantity
                        int existingQuantity = int.Parse(appointmentControl.txtQuantity.Text);
                        existingQuantity += quantity; // Update quantity
                        appointmentControl.SetQuantity(existingQuantity); // Use the method to update quantity
                        return; // Exit the method after updating
                    }
                }

                // If the service layout does not exist, create a new AppointmentControl
                AppointmentControl newControl = new AppointmentControl();
                newControl.SetServiceName(serviceName);
                newControl.SetQuantity(quantity);
                newControl.SetAmount(GetServicePrice(serviceId) * quantity); // Assuming you have a method to get the price

                // Add event handlers for the buttons in the AppointmentControl
                newControl.btnAddQuantity.Click += (s, args) => newControl.UpdateQuantity(1); // Increment by 1
                newControl.btnMinusQuantity.Click += (s, args) => newControl.UpdateQuantity(-1); // Decrement by 1
                newControl.btnRemove.Click += (s, args) => serviceLayout.Controls.Remove(newControl); // This should work as expected

                // Add the new control to the FlowLayoutPanel
                serviceLayout.Controls.Add(newControl);

                // Optionally, clear the quantity textbox after adding
                txtQty.Clear();
            }
            else
            {
                MessageBox.Show("Please select a service and enter a quantity.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private decimal GetServicePrice(int serviceId)
        {
            // Retrieve the price of the selected service
            DataTable serviceData = _appointmentRepository.GetServiceData();
            foreach (DataRow row in serviceData.Rows)
            {
                if ((int)row["ServiceID"] == serviceId)
                {
                    return (decimal)row["Price"];
                }
            }
            return 0; // Default if not found
        }

        private void ValidateInput(string customerName, string petName, DateTime appointmentDate)
        {
            if (string.IsNullOrWhiteSpace(customerName))
                throw new ArgumentException("Customer name cannot be empty.", nameof(customerName));
            if (string.IsNullOrWhiteSpace(petName))
                throw new ArgumentException("Pet name cannot be empty.", nameof(petName));
        }
    }
}