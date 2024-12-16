using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using PetWorldManagement.Repository;

namespace PetWorldManagement.Staff
{
    public partial class StaffForm : Form
    {
        private readonly RepositoryFacade<StaffObject> staffFacade;
        private readonly IRepositoryFactory factory;

        public StaffForm()
        {
            factory = new RepositoryFactory();
            staffFacade = new RepositoryFacade<StaffObject>(factory);

            InitializeComponent();
            loadStaff();
            loadRole();
        }

        private void loadStaff()
        {
            try
            {
                DataTable staffData = staffFacade.GetAll();
                dataGridViewSuppliers.Rows.Clear();

                foreach (DataRow row in staffData.Rows)
                {
                    int rowIndex = dataGridViewSuppliers.Rows.Add();
                    dataGridViewSuppliers.Rows[rowIndex].Cells["ID"].Value = row["StaffID"];
                    dataGridViewSuppliers.Rows[rowIndex].Cells["LName"].Value = row["lastName"];
                    dataGridViewSuppliers.Rows[rowIndex].Cells["FName"].Value = row["firstName"];
                    dataGridViewSuppliers.Rows[rowIndex].Cells["MI"].Value = row["mi"];
                    dataGridViewSuppliers.Rows[rowIndex].Cells["Age"].Value = row["age"];
                    dataGridViewSuppliers.Rows[rowIndex].Cells["Gender"].Value = row["gender"];
                    dataGridViewSuppliers.Rows[rowIndex].Cells["Contact"].Value = row["contactNumber"];
                    dataGridViewSuppliers.Rows[rowIndex].Cells["Role"].Value = row["RoleID"];
                    dataGridViewSuppliers.Rows[rowIndex].Cells["Username"].Value = row["username"];
                    dataGridViewSuppliers.Rows[rowIndex].Cells["Password"].Value = row["password"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading staff: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string keyword = txtSearch.Text.Trim();
                DataTable searchResults = staffFacade.Search(keyword);

                dataGridViewSuppliers.Rows.Clear();
                foreach (DataRow row in searchResults.Rows)
                {
                    int rowIndex = dataGridViewSuppliers.Rows.Add();
                    dataGridViewSuppliers.Rows[rowIndex].Cells["ID"].Value = row["StaffID"];
                    dataGridViewSuppliers.Rows[rowIndex].Cells["LName"].Value = row["lastName"];
                    dataGridViewSuppliers.Rows[rowIndex].Cells["FName"].Value = row["firstName"];
                    dataGridViewSuppliers.Rows[rowIndex].Cells["MI"].Value = row["mi"];
                    dataGridViewSuppliers.Rows[rowIndex].Cells["Age"].Value = row["age"];
                    dataGridViewSuppliers.Rows[rowIndex].Cells["Gender"].Value = row["gender"];
                    dataGridViewSuppliers.Rows[rowIndex].Cells["Contact"].Value = row["contactNumber"];
                    dataGridViewSuppliers.Rows[rowIndex].Cells["Role"].Value = row["RoleID"];
                    dataGridViewSuppliers.Rows[rowIndex].Cells["Username"].Value = row["username"];
                    dataGridViewSuppliers.Rows[rowIndex].Cells["Password"].Value = row["password"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching staff: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewSuppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the "Delete" button column is clicked
            if (e.ColumnIndex == dataGridViewSuppliers.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                try
                {
                    int staffId = Convert.ToInt32(dataGridViewSuppliers.Rows[e.RowIndex].Cells["ID"].Value);

                    var confirmResult = MessageBox.Show(
                        "Are you sure you want to delete this staff record?",
                        "Confirm Delete",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (confirmResult == DialogResult.Yes)
                    {
                        staffFacade.Delete(staffId);
                        MessageBox.Show("Staff record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadStaff(); // Refresh the data grid
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting staff: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridViewSuppliers_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridViewSuppliers.Rows[e.RowIndex];

                var staff = new StaffObject
                {
                    StaffID = Convert.ToInt32(row.Cells["ID"].Value),
                    LastName = row.Cells["LName"].Value?.ToString(),
                    FirstName = row.Cells["FName"].Value?.ToString(),
                    MiddleInitial = row.Cells["MI"].Value?.ToString(),
                    Age = Convert.ToInt32(row.Cells["Age"].Value),
                    Gender = row.Cells["Gender"].Value?.ToString(),
                    ContactNumber = row.Cells["Contact"].Value?.ToString(),
                    RoleID = Convert.ToInt32(row.Cells["Role"].Value),
                    Username = row.Cells["Username"].Value?.ToString(),
                    Password = row.Cells["Password"].Value?.ToString()
                };

                if (staff.RoleID == 4)
                {
                    if (string.IsNullOrWhiteSpace(staff.Username) || string.IsNullOrWhiteSpace(staff.Password))
                    {
                        MessageBox.Show("Username and Password are required for Admin role.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    staff.Username = null;
                    staff.Password = null;
                }

                staffFacade.Update(staff);

                MessageBox.Show("Staff record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                loadStaff();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating staff: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                
                string fname = txtFname.Text.Trim();
                string lname = txtLname.Text.Trim();
                string mi = txtMI.Text.Trim();
                int age = Convert.ToInt32(txtage.Text);
                string gender = cbxGender.SelectedItem.ToString();
                string contact = txtContact.Text.Trim();
                int roleId = Convert.ToInt32(cbxRole.SelectedValue);
                string username = txtusername.Text.Trim();
                string password = txtpassword.Text.Trim();

                if (string.IsNullOrWhiteSpace(fname) || string.IsNullOrWhiteSpace(lname) || roleId == 0)
                {
                    MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (roleId == 4 && (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password)))
                {
                    MessageBox.Show("Username and Password are required for Admin role.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Create a new StaffObject
                var newStaff = new StaffObject
                {
                    FirstName = fname,
                    LastName = lname,
                    MiddleInitial = mi,
                    Age = age,
                    Gender = gender,
                    ContactNumber = contact,
                    RoleID = roleId,
                    Username = roleId == 4 ? username : null, 
                    Password = roleId == 4 ? password : null 
                };

                staffFacade.Add(newStaff);

                MessageBox.Show("Staff inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inserting staff: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            pnlAddStaff.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlAddStaff.Visible = false;
        }

        private void ClearFields()
        {
            txtFname.Clear();
            txtLname.Clear();
            txtMI.Clear();
            txtage.Clear();
            cbxGender.SelectedIndex = 0;
            txtContact.Clear();
            cbxRole.SelectedIndex = 0;
            txtusername.Clear();
            txtpassword.Clear();
        }


        private void loadRole()
        {
            try
            {
                string query = "SELECT RoleID, RoleName FROM Role";
                DataTable roles = new DataTable();

                using (SqlConnection conn = DatabaseConn.getInstance().GetConnection())
                {
                    conn.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        adapter.Fill(roles);
                    }
                } 
                cbxRole.DataSource = roles;
                cbxRole.DisplayMember = "RoleName";
                cbxRole.ValueMember = "RoleID";
                cbxRole.SelectedIndex = 0;

                cbxRole.Font = new Font("Arial", 12, FontStyle.Regular);
                cbxRole.ForeColor = SystemColors.ControlDarkDark;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading roles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            int num = cbxRole.SelectedIndex + 1;

            if (num == 4)
            {
                lblusername.Visible = true;
                lblpassword.Visible = true;
                txtusername.Visible = true;
                txtpassword.Visible = true;
            }
            else
            {
                lblusername.Visible = false;
                lblpassword.Visible = false;
                txtusername.Visible = false;
                txtpassword.Visible = false;

                txtusername.Clear();
                txtpassword.Clear();
            }
        }

    }
}
