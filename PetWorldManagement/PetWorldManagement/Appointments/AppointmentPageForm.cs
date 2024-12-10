using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using PetWorldManagement.Appointments; // Ensure this is included
using PetWorldManagement.Repository;

namespace PetWorldManagement.Appointments
{
    public partial class AppointmentPageForm : Form
    {
        private readonly Dashboard dashboard;
        private readonly AppointmentRepository appointmentRepository;

        // Dictionaries to hold status and staff mappings
        private Dictionary<int, string> statusMapping;
        private Dictionary<int, string> staffMapping;

        public AppointmentPageForm(Dashboard dashboard)
        {
            InitializeComponent();
            this.dashboard = dashboard;

            appointmentRepository = new AppointmentRepository();

            LoadStatusAndStaffData();
            LoadAppointments();

            // Attach event handlers
            dataGridViewAppointmentList.CellValueChanged += dataGridViewAppointmentList_CellValueChanged;
            dataGridViewAppointmentList.CurrentCellDirtyStateChanged += dataGridViewAppointmentList_CurrentCellDirtyStateChanged;
        }

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
            // Filter appointments to only include Busy (3) and Complete (4) statuses
            DataView filteredView = new DataView(appointments);
            filteredView.RowFilter = "StatusID IN (3, 4)"; // Only include Busy and Complete
            DataTable filteredAppointments = filteredView.ToTable();

            // Create a new DataTable to hold formatted data
            DataTable formattedAppointments = new DataTable();
            formattedAppointments.Columns.Add("ID", typeof(int));
            formattedAppointments.Columns.Add("Customer Name", typeof(string));
            formattedAppointments.Columns.Add("Pet Name", typeof(string));
            formattedAppointments.Columns.Add("Date", typeof(string)); // Changed to string for formatted date
            formattedAppointments.Columns.Add("Staff Name", typeof(string)); // Changed to string for staff name
            formattedAppointments.Columns.Add("StatusID", typeof(int)); // Keep StatusID for data binding

            foreach (DataRow row in filteredAppointments.Rows)
            {
                DataRow newRow = formattedAppointments.NewRow();
                newRow["ID"] = row["AppointmentID"];
                newRow["Customer Name"] = row["CustomerName"];
                newRow["Pet Name"] = row["PetName"];
                newRow["Date"] = Convert.ToDateTime(row["AppointmentDate"]).ToString("MM/dd/yyyy"); // Format date

                // Add StatusID to the new row
                newRow["StatusID"] = row["StatusID"];

                // Replace StaffID with Staff name using the dictionary
                int staffId = Convert.ToInt32(row["StaffID"]);
                newRow["Staff Name"] = staffMapping.ContainsKey(staffId) ? staffMapping[staffId] : "Unknown Staff";

                formattedAppointments.Rows.Add(newRow);
            }

            dataGridViewAppointmentList.DataSource = formattedAppointments;

            // Create a ComboBox column for Status if it doesn't exist
            if (dataGridViewAppointmentList.Columns["Status"] == null)
            {
                DataGridViewComboBoxColumn statusColumn = new DataGridViewComboBoxColumn
                {
                    Name = "Status",
                    HeaderText = "Status",
                    DataPropertyName = "StatusID", // Bind to StatusID
                    DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox
                };

                // Add options to the ComboBox
                statusColumn.Items.Add(new { Value = 3, Text = "Busy" });
                statusColumn.Items.Add(new { Value = 4, Text = "Completed" });

                // Set the value member and display member
                statusColumn.ValueMember = "Value";
                statusColumn.DisplayMember = "Text";

                // Add the ComboBox column to the DataGridView
                dataGridViewAppointmentList.Columns.Add(statusColumn);
            }

            // Add the View button column if it doesn't exist
            if (dataGridViewAppointmentList.Columns["View"] == null)
            {
                DataGridViewButtonColumn viewButton = new DataGridViewButtonColumn
                {
                    Name = "View",
                    Text = "VIEW",
                    UseColumnTextForButtonValue = true
                };
                viewButton.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Regular);
                dataGridViewAppointmentList.Columns.Add(viewButton);
            }

            // Remove the old StatusID column if it exists
            if (dataGridViewAppointmentList.Columns["StatusID"] != null)
            {
                dataGridViewAppointmentList.Columns.Remove("StatusID");
            }

            // Add the Delete button column if it doesn't exist
            if (dataGridViewAppointmentList.Columns["Delete"] == null)
            {
                AddDeleteButtonToGrid();
            }

            // Ensure the Delete button is the last column
            dataGridViewAppointmentList.Columns["Delete"].DisplayIndex = dataGridViewAppointmentList.Columns.Count - 1;

            AutoSizeGridColumns();
        }

        private void AutoSizeGridColumns()
        {
            foreach (DataGridViewColumn column in dataGridViewAppointmentList.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void AddDeleteButtonToGrid()
        {
            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn
            {
                Name = "Delete",
                Text = "DELETE",
                UseColumnTextForButtonValue = true
            };
            deleteButton.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Regular);
            dataGridViewAppointmentList.Columns.Add(deleteButton);
        }

        private void dataGridViewAppointmentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the row index is valid
            {
                DataGridViewRow row = dataGridViewAppointmentList.Rows[e.RowIndex];

                // Check if the ID cell is not null or empty
                if (row.Cells["ID"].Value == null || row.Cells["ID"].Value == DBNull.Value)
                {
                    MessageBox.Show("Invalid appointment selected. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Exit the method
                }

                int appointmentId = Convert.ToInt32(row.Cells["ID"].Value);

                if (e.ColumnIndex == dataGridViewAppointmentList.Columns["Delete"].Index)
                {
                    var confirmResult = MessageBox.Show("Are you sure to delete this appointment?", "Confirm Delete", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        appointmentRepository.Delete(appointmentId);
                        LoadAppointments(); // Refresh grid after deletion
                    }
                }
                else if (e.ColumnIndex == dataGridViewAppointmentList.Columns["View"].Index)
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;
            DataTable filteredAppointments = appointmentRepository.Search(keyword);
            DisplayAppointments(filteredAppointments); // Update the DataGridView with filtered results
        }

        private void dataGridViewAppointmentList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewAppointmentList.Columns["Status"].Index)
            {
                DataGridViewRow row = dataGridViewAppointmentList.Rows[e.RowIndex];
                int appointmentId = Convert.ToInt32(row.Cells["ID"].Value);
                int newStatusId = Convert.ToInt32(row.Cells["Status"].Value);

                // Retrieve the current appointment details to ensure we have the correct data
                DataTable appointmentData = appointmentRepository.GetAll();
                DataRow[] selectedRows = appointmentData.Select($"AppointmentID = {appointmentId}");

                if (selectedRows.Length > 0)
                {
                    int staffId = Convert.ToInt32(selectedRows[0]["StaffID"]);
                    string customerName = selectedRows[0]["CustomerName"].ToString();

                    // Check if the new status is "Busy" (assuming Busy status ID is 3)
                    if (newStatusId == 3) // 3 represents "Busy"
                    {
                        // Check for existing "Busy" appointments for the same staff member
                        DataRow[] busyAppointments = appointmentData.Select($"StatusID = 3 AND StaffID = {staffId} AND AppointmentID <> {appointmentId}");

                        if (busyAppointments.Length > 0)
                        {
                            // Inform the user that the status cannot be changed
                            MessageBox.Show($"Cannot change the status to 'Busy' because {staffMapping[staffId]} is already handling another appointment for {customerName}.", "Status Change Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            // Revert the status change in the DataGridView
                            row.Cells["Status"].Value = 4; // Assuming 4 is the "Completed" status or whatever the previous status was
                            return; // Exit the method
                        }
                    }

                    // If no conflicts, proceed to update the appointment
                    AppointmentObject appointment = new AppointmentObject
                    {
                        AppointmentID = appointmentId,
                        StatusID = newStatusId,
                        CustomerName = customerName,
                        PetName = selectedRows[0]["PetName"].ToString(),
                        AppointmentDate = Convert.ToDateTime(selectedRows[0]["AppointmentDate"]),
                        StaffID = staffId
                    };

                    // Update the appointment status in the database
                    appointmentRepository.Update(appointment);
                }
            }
        }

        private void dataGridViewAppointmentList_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewAppointmentList.IsCurrentCellDirty)
            {
                dataGridViewAppointmentList.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
    }
}