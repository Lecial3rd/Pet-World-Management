using PetWorldManagement.POS;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PetWorldManagement.StartUp
{
    public partial class StartUp : Form
    {
        public StartUp()
        {
            InitializeComponent();
        }

        private void btn_Admin_Click(object sender, EventArgs e)
        {
            btn_Admin.Visible = false;
            btn_Cashier.Visible = false;
            btn_FrontDesk.Visible = false;
            loginPanel.Visible = true;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            loginPanel.Visible = false;
            btn_Admin.Visible = true;
            btn_Cashier.Visible = true;
            btn_FrontDesk.Visible = true;
        }

        private void btn_FrontDesk_Click(object sender, EventArgs e)
        {
            Appointment appointment = new Appointment();
            appointment.ShowDialog();
            this.Hide();
        }

        private void btn_Cashier_Click(object sender, EventArgs e)
        {
            POSForm pOSForm = new POSForm();
            pOSForm.ShowDialog();
            this.Hide();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string password = txtPass.Text;

            if(ValidateAdmin(username, password))
            {
                Dashboard dashboard = new Dashboard();
                dashboard.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateAdmin(string username, string password)
        {
            try
            {
                // Query to check if the user exists with RoleID = 4 (Admin role)
                string query = @"SELECT COUNT(*) 
                         FROM Staff 
                         WHERE RoleID = 4 AND username = @username AND password = @password";

                using (SqlConnection conn = DatabaseConn.getInstance().GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Use parameterized queries to prevent SQL injection
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        // Execute the query and check the count
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0; // Return true if an admin user is found
                    }
                }
            }
            catch (Exception ex)
            {
                // Log error or handle appropriately (avoid revealing sensitive details in production)
                MessageBox.Show($"An error occurred while validating: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }
}
