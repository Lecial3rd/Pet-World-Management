using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using PetWorldManagement.Appointments; // Ensure this is included
using PetWorldManagement.Invoice;
using PetWorldManagement.POS;
using PetWorldManagement.Repository;

namespace PetWorldManagement
{
    public partial class Appointment : Form
    {
        private readonly AppointmentRepository appointmentRepository;

        // Dictionaries to hold status and staff mappings
        private Dictionary<int, string> statusMapping;
        private Dictionary<int, string> staffMapping;

        public Appointment()
        {
            InitializeComponent();
            appointmentRepository = new AppointmentRepository();
            LoadStatusAndStaffData();
            LoadAppointments();
        }

        private int? selectedStaffId; // Store the selected staff ID

        private void LoadStatusAndStaffData()
        {
            // Load status data from the database
            statusMapping = new Dictionary<int, string>();
            DataTable statusData = appointmentRepository.GetStatusData();
            foreach (DataRow row in statusData.Rows)
            {
                int statusId = row.Field<int>("StatusID");
                string statusName = row.Field<string>("Status");
                statusMapping[statusId] = statusName;
            }

            // Load staff data from the database
            staffMapping = new Dictionary<int, string>();
            DataTable staffData = appointmentRepository.GetStaffData();
            foreach (DataRow row in staffData.Rows)
            {
                int staffId = row.Field<int>("StaffID");
                string staffName = row.Field<string>("FullName");
                staffMapping[staffId] = staffName;
            }
        }

        private void LoadAppointments()
        {
            DataTable appointments = appointmentRepository.GetAll();
            DisplayAppointments(appointments);
        }

        private void DisplayAppointments(DataTable appointments)
        {
            // Create a new DataTable to hold formatted data
            DataTable formattedAppointments = new DataTable();
            formattedAppointments.Columns.Add("ID", typeof(int));
            formattedAppointments.Columns.Add("Customer Name", typeof(string));
            formattedAppointments.Columns.Add("Pet Name", typeof(string));
            formattedAppointments.Columns.Add("Date", typeof(string)); // Changed to string for formatted date
            formattedAppointments.Columns.Add("Staff Name", typeof(string)); // Changed to string for staff name
            formattedAppointments.Columns.Add("Status", typeof(string)); // Changed to string for status name

            foreach (DataRow row in appointments.Rows)
            {
                DataRow newRow = formattedAppointments.NewRow();
                newRow["ID"] = row["AppointmentID"];
                newRow["Customer Name"] = row["CustomerName"];
                newRow["Pet Name"] = row["PetName"];
                newRow["Date"] = Convert.ToDateTime(row["AppointmentDate"]).ToString("MM/dd/yyyy"); // Format date

                // Replace StaffID with Staff name using the dictionary
                int staffId = Convert.ToInt32(row["StaffID"]);
                newRow["Staff Name"] = staffMapping.ContainsKey(staffId) ? staffMapping[staffId] : "Unknown Staff";

                // Replace StatusID with Status name using the dictionary
                int statusId = Convert.ToInt32(row["StatusID"]);
                newRow["Status"] = statusMapping.ContainsKey(statusId) ? statusMapping[statusId] : "Unknown Status";

                formattedAppointments.Rows.Add(newRow);
            }

            dataGridViewAppointments.DataSource = formattedAppointments;

            // Add View button column if it doesn't exist
            if (dataGridViewAppointments.Columns["View"] == null)
            {
                DataGridViewButtonColumn viewButton = new DataGridViewButtonColumn
                {
                    Name = "View",
                    Text = "VIEW",
                    UseColumnTextForButtonValue = true,
                    DefaultCellStyle = new DataGridViewCellStyle
                    {
                        Font = new Font("Arial", 10, FontStyle.Regular),
                        Alignment = DataGridViewContentAlignment.MiddleCenter
                    }
                };
                dataGridViewAppointments.Columns.Add(viewButton);
            }

            // Ensure the button is the last column
            dataGridViewAppointments.Columns["View"].DisplayIndex = dataGridViewAppointments.Columns.Count - 1;

            AutoSizeGridColumns();
        }


        private void AutoSizeGridColumns()
        {
            foreach (DataGridViewColumn column in dataGridViewAppointments.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void dataGridViewAppointments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the row index is valid
            {
                DataGridViewRow row = dataGridViewAppointments.Rows[e.RowIndex];

                // Check if the ID cell is not null or empty
                if (row.Cells["ID"].Value == null || row.Cells["ID"].Value == DBNull.Value)
                {
                    MessageBox.Show("Invalid appointment selected. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Exit the method
                }

                int appointmentId = Convert.ToInt32(row.Cells["ID"].Value);

                if (e.ColumnIndex == dataGridViewAppointments.Columns["View"].Index)
                {
                    // Check if the appointmentId is valid before opening the ViewAppointment form
                    if (appointmentId <= 0)
                    {
                        MessageBox.Show("Invalid appointment selected. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Exit the method
                    }

                    // Open the ViewAppointment form to view details
                    ViewAppointment viewAppointmentForm = new ViewAppointment(appointmentId);
                    viewAppointmentForm.ShowDialog(); // Show the form as a dialog
                }
            }
            else
            {
                MessageBox.Show("No valid row selected. Please select a valid appointment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            AddAppointment addAppointmentForm = new AddAppointment();
            addAppointmentForm.ShowDialog(); 
            LoadAppointments(); 
        }

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearchBox.Text.ToLower();
            DataTable appointments = appointmentRepository.GetAll();
            DataView filteredView = new DataView(appointments);
            filteredView.RowFilter = $"CustomerName LIKE '%{searchTerm}%' OR PetName LIKE '%{searchTerm}%'";
            DisplayAppointments(filteredView.ToTable());
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string staffid = txtfrontDeskID.Text.Trim();

            if (txtfrontDeskID.Enabled == false)
            {
                txtfrontDeskID.Enabled = true;
                lblFrontDeskName.Text = string.Empty;
                btnPay.Enabled = false; // Disable btnPay when editing staff ID
                return;
            }

            if (string.IsNullOrEmpty(staffid))
            {
                MessageBox.Show("Please enter a valid staff ID to proceed.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AppointmentRepository repository = new AppointmentRepository();
            DataTable staffData = repository.GetFrontDeskStaffData(staffid);

            if (staffData.Rows.Count > 0)
            {
                string lastName = staffData.Rows[0]["lastName"].ToString();
                string firstName = staffData.Rows[0]["firstName"].ToString();
                string mi = staffData.Rows[0]["mi"].ToString();

                lblFrontDeskName.Text = $"{lastName}, {firstName} {mi}".Trim();
                txtfrontDeskID.Enabled = false;

                // Store the selected staff ID
                selectedStaffId = Convert.ToInt32(staffData.Rows[0]["StaffID"]);

                MessageBox.Show($"Front Desk Staff {lblFrontDeskName.Text} successfully selected.", "Selection Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The entered staff ID is not valid or does not belong to a Front Desk Staff. Please try again.", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Validate the Pay button state after selecting staff
            ValidatePayButton(); // Recheck button state
        }

        private void txtAppID_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtAppID.Text, out int appointmentId))
            {
                AppointmentObject appointment = appointmentRepository.GetAppointmentById(appointmentId);

                if (appointment != null)
                {
                    lblCustomerName.Text = appointment.CustomerName;
                    lblPetName.Text = appointment.PetName;

                    DataTable services = appointmentRepository.GetAppointmentServices(appointmentId);

                    // Calculate total quantity
                    int totalQuantity = 0;
                    decimal totalPrice = 0;

                    foreach (DataRow row in services.Rows)
                    {
                        totalPrice += row.Field<decimal>("TotalAmount");
                        totalQuantity += row.Field<int>("Quantity"); // Sum the quantities
                    }

                    lblTotalService.Text = totalQuantity.ToString(); // Display total quantity
                    lblTotalPrice.Text = totalPrice.ToString(); // Format total price as currency

                    // Check the status of the appointment
                    if (appointment.StatusID == 4) // Assuming 4 is the ID for "Completed"
                    {
                        btnPay.Enabled = false; // Disable the Pay button if the status is completed
                        MessageBox.Show("This appointment has already been completed and cannot be paid for again.", "Appointment Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Only call ValidatePayButton if the appointment is not completed
                        ValidatePayButton(); // Recheck button state if the appointment is not completed
                    }
                }
                else
                {
                    // Clear fields if no appointment is found
                    lblCustomerName.Text = string.Empty;
                    lblPetName.Text = string.Empty;
                    lblTotalService.Text = "0";
                    lblTotalPrice.Text = "0.00";
                    btnPay.Enabled = false; // Disable Pay button if no appointment is found
                }
            }
            else
            {
                // Clear fields for invalid input
                lblCustomerName.Text = string.Empty;
                lblPetName.Text = string.Empty;
                lblTotalService.Text = "0";
                lblTotalPrice.Text = "0.00";
                btnPay.Enabled = false; // Disable Pay button for invalid input
            }

            // Always validate the Pay button state after changing the appointment ID
            ValidatePayButton();
        }

        private void ValidatePayButton()
        {
            // Ensure both conditions are true before enabling btnPay
            bool isStaffSelected = !string.IsNullOrEmpty(lblFrontDeskName.Text.Trim());
            bool isAppointmentValid = !string.IsNullOrEmpty(lblCustomerName.Text.Trim()) && !string.IsNullOrEmpty(lblPetName.Text.Trim());

            // Check if the current appointment is not completed
            bool isAppointmentNotCompleted = true;
            if (int.TryParse(txtAppID.Text, out int appointmentId))
            {
                AppointmentObject appointment = appointmentRepository.GetAppointmentById(appointmentId);
                if (appointment != null)
                {
                    isAppointmentNotCompleted = appointment.StatusID != 4; // Assuming 4 is the ID for "Completed"
                }
            }

            // Enable btnPay only if all conditions are met
            btnPay.Enabled = isStaffSelected && isAppointmentValid && isAppointmentNotCompleted;
        }

        private int GetCurrentStaffId()
        {
            if (selectedStaffId.HasValue)
            {
                return selectedStaffId.Value;
            }
            throw new InvalidOperationException("No staff selected.");
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            // Step 1: Collect data
            if (int.TryParse(txtAppID.Text, out int appointmentId))
            {
                // Retrieve appointment details
                AppointmentObject appointment = appointmentRepository.GetAppointmentById(appointmentId);
                if (appointment == null)
                {
                    MessageBox.Show("Appointment not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Calculate total amount (you may already have this in lblTotalPrice)
                decimal totalAmount = decimal.Parse(lblTotalPrice.Text);
                decimal discountRate = string.IsNullOrEmpty(txtboxDiscount.Text) ? 0 : decimal.Parse(txtboxDiscount.Text) / 100; // Convert to percentage

                // Calculate the discount amount
                decimal discountAmount = totalAmount * discountRate;

                // Calculate the effective total amount after discount
                decimal effectiveTotalAmount = totalAmount - discountAmount;

                // Validate cashReceived input
                if (!decimal.TryParse(txtReceived.Text, out decimal cashReceived))
                {
                    MessageBox.Show("Invalid cash received format. Please enter a valid decimal number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal change = cashReceived - effectiveTotalAmount;

                // Check if cash received is sufficient
                if (change < 0)
                {
                    MessageBox.Show("Cash received is not enough to cover the total amount.", "Insufficient Cash", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Step 2: Get the services for the appointment to calculate total quantity sold
                DataTable services = appointmentRepository.GetAppointmentServices(appointmentId);
                int totalQuantitySold = 0;

                foreach (DataRow row in services.Rows)
                {
                    totalQuantitySold += row.Field<int>("Quantity"); // Sum the quantities
                }

                // Step 3: Insert data into the database
                int transactionId = appointmentRepository.InsertSalesTransaction(
                    staffId: GetCurrentStaffId(),
                    totalQuantitySold: totalQuantitySold, // Use the calculated total service quantity
                    totalPrice: effectiveTotalAmount, // Use the effective total amount after discount
                    discountRate: discountRate * 100, // Store the discount rate as a percentage
                    paymentMethod: "Cash", // Assuming cash payment
                    change: change
                );

                // Insert invoice
                appointmentRepository.InsertInvoice(
                    invoiceType: "Appointment",
                    transactionId: transactionId,
                    appointmentId: appointmentId,
                    invoiceDate: DateTime.Now,
                    totalAmount: effectiveTotalAmount // Use the effective total amount for the invoice
                );

                // Receipt
                DisplayInvoiceAppointment(appointmentId);

                // Update the appointment status to completed
                appointmentRepository.UpdateAppointmentStatus(appointmentId, 4);

                LoadAppointments();
                ClearInputFields();
            }
            else
            {
                MessageBox.Show("Invalid Appointment ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayInvoiceAppointment(int appointmentID)
        {
            InvoiceAppointmentForm invoice = new InvoiceAppointmentForm();

            SqlConnection conn = DatabaseConn.getInstance().GetConnection();
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string query = @"SELECT 
                            app.AppointmentID,
                            app.CustomerName,
                            app.PetName,
                            apps.ServiceName, 
                            apps.Quantity,
                            apps.Price,
                            inv.TotalAmount as TotalPrice,
                            st.Change,
                            st.DiscountRate,
                            (st.Change + st.TotalPrice) as CashReceived,
                            st.PaymentMethod
                        FROM 
                            AppointmentService apps
                        INNER JOIN Services s ON apps.ServiceID = s.ServiceID
                        INNER JOIN Appointment app on apps.AppointmentID = app.AppointmentID
                        INNER JOIN Invoices inv on app.AppointmentID = inv.AppointmentID
                        INNER JOIN SalesTransactions st on inv.TransactionID = st.TransactionID
                        WHERE apps.AppointmentID = @AppointmentID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@AppointmentID", appointmentID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        bool isInvoiceDetailsFetched = false;
                        decimal grandtotal = 0;
                        while (reader.Read())
                        {
                            if (!isInvoiceDetailsFetched)
                            {
                                invoice.lblInvoiceID.Text = reader.GetInt32(0).ToString();
                                invoice.lblCustomer.Text = reader.GetString(1);
                                invoice.lblPet.Text = reader.GetString(2);
                                invoice.lblInvoiceDate.Text = DateTime.Now.ToString("MMMM dd, yyyy");

                                decimal totalPrice = reader.GetDecimal(6);
                                int discountRate = Convert.ToInt32(reader.GetDecimal(8));
                                decimal dbChange = reader.GetDecimal(7);
                                decimal cashReceived = reader.GetDecimal(9);
                                grandtotal+= reader.GetDecimal(6);

                                invoice.lblDR.Text = discountRate.ToString();
                                invoice.lblTAmount.Text = "₱" + grandtotal.ToString("N2");
                                invoice.cshrcvlbl.Text = "₱" + cashReceived.ToString("N2");
                                invoice.changelbl.Text = "₱" + dbChange.ToString("N2");
                                invoice.paymentMethod.Text = reader.GetString(10);

                                invoice.lblTAmount.Visible = true;
                                isInvoiceDetailsFetched = true;
                            }

                            string serviceName = reader.GetString(3);
                            int quantity = reader.GetInt32(4);
                            decimal price = reader.GetDecimal(5);
                            decimal subtotal = quantity * price;

                            InvoiceLayout invoiceItemLayout = new InvoiceLayout();
                            invoiceItemLayout.ShowInvoiceLayout(serviceName, price, quantity, (double)subtotal);
                            invoice.InvoiceFlowLayout.Controls.Add(invoiceItemLayout);
                            invoice.InvoiceFlowLayout.Controls.Add(invoice.summaryPNL);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }

            invoice.Show();
        }


        private void ClearInputFields()
        {
            // Clear the input fields and labels
            txtAppID.Text = string.Empty;
            txtReceived.Text = string.Empty;
            txtboxDiscount.Text = string.Empty;
            lblCustomerName.Text = string.Empty;
            lblPetName.Text = string.Empty;
            lblTotalService.Text = "0";
            lblTotalPrice.Text = "0.00";
            btnPay.Enabled = false; // Disable Pay button after clearing
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}