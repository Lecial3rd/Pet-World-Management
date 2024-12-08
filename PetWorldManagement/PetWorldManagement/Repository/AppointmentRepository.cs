using System;
using System.Data;
using System.Data.SqlClient;
using PetWorldManagement.Appointments;

namespace PetWorldManagement.Repository
{
    internal class AppointmentRepository : IRepository<AppointmentObject>
    {
        public DataTable GetAll()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = DatabaseConn.getInstance().GetConnection())
            {
                string query = "SELECT * FROM Appointment";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dt);
            }
            return dt;
        }

        public void Add(AppointmentObject appointment)
        {
            using (SqlConnection conn = DatabaseConn.getInstance().GetConnection())
            {
                string query = "INSERT INTO Appointment (CustomerName, PetName, AppointmentDate, StatusID, StaffID) VALUES (@CustomerName, @PetName, @AppointmentDate, @StatusID, @StaffID)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerName", appointment.CustomerName);
                    cmd.Parameters.AddWithValue("@PetName", appointment.PetName);
                    cmd.Parameters.AddWithValue("@AppointmentDate", appointment.AppointmentDate);
                    cmd.Parameters.AddWithValue("@StatusID", appointment.StatusID);
                    cmd.Parameters.AddWithValue("@StaffID", appointment.StaffID);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Update(AppointmentObject appointment)
        {
            using (SqlConnection conn = DatabaseConn.getInstance().GetConnection())
            {
                string query = "UPDATE Appointment SET CustomerName = @CustomerName, PetName = @PetName, AppointmentDate = @AppointmentDate, StatusID = @StatusID, StaffID = @StaffID WHERE AppointmentID = @AppointmentID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerName", appointment.CustomerName);
                    cmd.Parameters.AddWithValue("@PetName", appointment.PetName);
                    cmd.Parameters.AddWithValue("@AppointmentDate", appointment.AppointmentDate);
                    cmd.Parameters.AddWithValue("@StatusID", appointment.StatusID);
                    cmd.Parameters.AddWithValue("@StaffID", appointment.StaffID);
                    cmd.Parameters.AddWithValue("@AppointmentID", appointment.AppointmentID); // Ensure AppointmentID is included

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int appointmentID)
        {
            using (SqlConnection conn = DatabaseConn.getInstance().GetConnection())
            {
                // First, delete related records in AppointmentService
                string deleteServiceQuery = "DELETE FROM AppointmentService WHERE AppointmentID = @AppointmentID";
                using (SqlCommand cmd = new SqlCommand(deleteServiceQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@AppointmentID", appointmentID);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                // Now delete the appointment
                string deleteAppointmentQuery = "DELETE FROM Appointment WHERE AppointmentID = @AppointmentID";
                using (SqlCommand cmd = new SqlCommand(deleteAppointmentQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@AppointmentID", appointmentID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable Search(string keyword)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = DatabaseConn.getInstance().GetConnection())
            {
                string query = @"
                    SELECT * FROM Appointment 
                    WHERE CustomerName LIKE '%' + @Keyword + '%' OR PetName LIKE '%' + @Keyword + '%'";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Keyword", keyword);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        // New method to get status data
        public DataTable GetStatusData()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = DatabaseConn.getInstance().GetConnection())
            {
                string query = "SELECT StatusID, Status FROM Status"; // Adjust the query based on your actual table structure
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dt);
            }
            return dt;
        }

        // New method to get staff data
        public DataTable GetStaffData()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = DatabaseConn.getInstance().GetConnection())
            {
                string query = "SELECT StaffID, CONCAT(firstName, ' ', lastName) AS FullName FROM Staff"; // Adjust the query based on your actual table structure
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dt);
            }
            return dt;
        }

        public DataTable GetServiceData()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = DatabaseConn.getInstance().GetConnection())
            {
                string query = "SELECT ServiceID, ServiceName, Price FROM Services"; // Adjust the query based on your actual table structure
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dt);
            }
            return dt;
        }

        public void AddAppointmentService(int appointmentId, int serviceId, int quantity, decimal totalAmount)
        {
            using (SqlConnection conn = DatabaseConn.getInstance().GetConnection())
            {
                string query = "INSERT INTO AppointmentService (AppointmentID, ServiceID, Quantity, TotalAmount) VALUES (@AppointmentID, @ServiceID, @Quantity, @TotalAmount)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@AppointmentID", appointmentId);
                    cmd.Parameters.AddWithValue("@ServiceID", serviceId);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    cmd.Parameters.AddWithValue("@TotalAmount", totalAmount);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    Console.WriteLine($"Rows affected: {rowsAffected}"); // Log the number of rows affected
                }
            }
        }

        public int GetLastInsertedAppointmentId()
        {
            int lastId = 0;
            string query = "SELECT TOP 1 AppointmentID FROM Appointment ORDER BY AppointmentID DESC"; // Adjust the table name and column name as necessary

            using (SqlConnection conn = DatabaseConn.getInstance().GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        lastId = Convert.ToInt32(result);
                    }
                }
            }

            return lastId;
        }

        public bool CheckServiceExists(int appointmentId, int serviceId)
        {
            using (SqlConnection conn = DatabaseConn.getInstance().GetConnection())
            {
                string query = "SELECT COUNT(*) FROM AppointmentService WHERE AppointmentID = @AppointmentID AND ServiceID = @ServiceID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@AppointmentID", appointmentId);
                    cmd.Parameters.AddWithValue("@ServiceID", serviceId);
                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0; // Return true if the service exists
                }
            }
        }

        public void UpdateAppointmentServiceQuantity(int appointmentId, int serviceId, int quantity, decimal totalAmount)
        {
            using (SqlConnection conn = DatabaseConn.getInstance().GetConnection())
            {
                string query = "UPDATE AppointmentService SET Quantity = Quantity + @Quantity, TotalAmount = TotalAmount + @TotalAmount WHERE AppointmentID = @AppointmentID AND ServiceID = @ServiceID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@AppointmentID", appointmentId);
                    cmd.Parameters.AddWithValue("@ServiceID", serviceId);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    cmd.Parameters.AddWithValue("@TotalAmount", totalAmount);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public AppointmentObject GetAppointmentById(int appointmentId)
        {
            AppointmentObject appointment = null;
            using (SqlConnection conn = DatabaseConn.getInstance().GetConnection())
            {
                string query = "SELECT * FROM Appointment WHERE AppointmentID = @AppointmentID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@AppointmentID", appointmentId);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            appointment = new AppointmentObject
                            {
                                AppointmentID = reader.GetInt32(reader.GetOrdinal("AppointmentID")),
                                CustomerName = reader.GetString(reader.GetOrdinal("CustomerName")),
                                PetName = reader.GetString(reader.GetOrdinal("PetName")),
                                AppointmentDate = reader.GetDateTime(reader.GetOrdinal("AppointmentDate")),
                                StatusID = reader.GetInt32(reader.GetOrdinal("StatusID")),
                                StaffID = reader.GetInt32(reader.GetOrdinal("StaffID"))
                            };
                        }
                    }
                }
            }
            return appointment;
        }

        public DataTable GetAppointmentServices(int appointmentId)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = DatabaseConn.getInstance().GetConnection())
            {
                string query = @"
            SELECT s.ServiceName, appointmentService.Quantity, appointmentService.TotalAmount
            FROM AppointmentService appointmentService
            JOIN Services s ON appointmentService.ServiceID = s.ServiceID
            WHERE appointmentService.AppointmentID = @AppointmentID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@AppointmentID", appointmentId);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        public string GetStatusName(int statusId)
        {
            string statusName = "Unknown Status";
            using (SqlConnection conn = DatabaseConn.getInstance().GetConnection())
            {
                string query = "SELECT Status FROM Status WHERE StatusID = @StatusID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StatusID", statusId);
                    conn.Open();
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        statusName = result.ToString();
                    }
                }
            }
            return statusName;
        }

        public string GetStaffName(int staffId)
        {
            string staffName = "Unknown Staff"; // Default value
            using (SqlConnection conn = DatabaseConn.getInstance().GetConnection())
            {
                string query = "SELECT CONCAT(firstName, ' ', lastName) FROM Staff WHERE StaffID = @StaffID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StaffID", staffId);
                    conn.Open();
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        staffName = result.ToString(); // Update staffName if a valid result is found
                    }
                }
            }
            return staffName; // Ensure that a value is always returned
        }

    }
}