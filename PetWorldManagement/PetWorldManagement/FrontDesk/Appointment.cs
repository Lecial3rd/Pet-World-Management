using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using PetWorldManagement.Appointments; // Ensure this is included
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
                    UseColumnTextForButtonValue = true
                };
                dataGridViewAppointments.Columns.Add(viewButton);
            }

            // Add Delete button column if it doesn't exist
            if (dataGridViewAppointments.Columns["Delete"] == null)
            {
                DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn
                {
                    Name = "Delete",
                    Text = "DELETE",
                    UseColumnTextForButtonValue = true
                };
                dataGridViewAppointments.Columns.Add(deleteButton);
            }

            // Ensure the buttons are the last columns
            dataGridViewAppointments.Columns["View"].DisplayIndex = dataGridViewAppointments.Columns.Count - 2;
            dataGridViewAppointments.Columns["Delete"].DisplayIndex = dataGridViewAppointments.Columns.Count - 1;

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
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewAppointments.Rows[e.RowIndex];
                int appointmentId = Convert.ToInt32(row.Cells["ID"].Value);

                if (e.ColumnIndex == dataGridViewAppointments.Columns["View"].Index)
                {
                    // Open the ViewAppointment form to view details
                    ViewAppointment viewAppointmentForm = new ViewAppointment(appointmentId);
                    viewAppointmentForm.ShowDialog(); // Show the form as a dialog
                }
                else if (e.ColumnIndex == dataGridViewAppointments.Columns["Delete"].Index)
                {
                    var confirmResult = MessageBox.Show("Are you sure to delete this appointment?", "Confirm Delete", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        appointmentRepository.Delete(appointmentId);
                        LoadAppointments(); // Refresh grid after deletion
                    }
                }
            }
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            AddAppointment addAppointmentForm = new AddAppointment();
            addAppointmentForm.ShowDialog(); // Show the form as a dialog
            LoadAppointments(); // Refresh the appointments after adding a new one
        }

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearchBox.Text.ToLower();
            DataTable appointments = appointmentRepository.GetAll();
            DataView filteredView = new DataView(appointments);
            filteredView.RowFilter = $"CustomerName LIKE '%{searchTerm}%' OR PetName LIKE '%{searchTerm}%'";
            dataGridViewAppointments.DataSource = filteredView;
        }
    }
}