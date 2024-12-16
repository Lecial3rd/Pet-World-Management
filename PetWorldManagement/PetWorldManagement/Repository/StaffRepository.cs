using System;
using System.Data;
using System.Data.SqlClient;
using PetWorldManagement;

namespace PetWorldManagement.Repository
{
    public class StaffRepository : IRepository<StaffObject>
    {
        public void Add(StaffObject staff)
        {
            using (SqlConnection conn = DatabaseConn.getInstance().GetConnection())
            {
                string query = @"INSERT INTO Staff (firstName, lastName, mi, age, gender, contactNumber, RoleID, username, password) 
                                 VALUES (@firstName, @lastName, @mi, @age, @gender, @contactNumber, @RoleID, @username, @password)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();

                    cmd.Parameters.AddWithValue("@firstName", staff.FirstName);
                    cmd.Parameters.AddWithValue("@lastName", staff.LastName);
                    cmd.Parameters.AddWithValue("@mi", (object)staff.MiddleInitial ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@age", staff.Age);
                    cmd.Parameters.AddWithValue("@gender", staff.Gender);
                    cmd.Parameters.AddWithValue("@contactNumber", staff.ContactNumber);
                    cmd.Parameters.AddWithValue("@RoleID", staff.RoleID);

                    if (staff.RoleID == 4) // Role is Admin
                    {
                        if (string.IsNullOrWhiteSpace(staff.Username) || string.IsNullOrWhiteSpace(staff.Password))
                        {
                            throw new ArgumentException("Username and Password are required for Admin role.");
                        }

                        cmd.Parameters.AddWithValue("@username", staff.Username);
                        cmd.Parameters.AddWithValue("@password", staff.Password);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@username", DBNull.Value);
                        cmd.Parameters.AddWithValue("@password", DBNull.Value);
                    }

                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public void Update(StaffObject staff)
        {
            using (SqlConnection conn = DatabaseConn.getInstance().GetConnection())
            {
                string query = @"UPDATE Staff 
                                 SET firstName = @firstName, lastName = @lastName, mi = @mi, age = @age, gender = @gender, 
                                     contactNumber = @contactNumber, RoleID = @RoleID, username = @username, password = @password
                                 WHERE StaffID = @StaffID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();

                    cmd.Parameters.AddWithValue("@StaffID", staff.StaffID);
                    cmd.Parameters.AddWithValue("@firstName", staff.FirstName);
                    cmd.Parameters.AddWithValue("@lastName", staff.LastName);
                    cmd.Parameters.AddWithValue("@mi", (object)staff.MiddleInitial ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@age", staff.Age);
                    cmd.Parameters.AddWithValue("@gender", staff.Gender);
                    cmd.Parameters.AddWithValue("@contactNumber", staff.ContactNumber);
                    cmd.Parameters.AddWithValue("@RoleID", staff.RoleID);

                    if (staff.RoleID == 4) // Role is Admin
                    {
                        if (string.IsNullOrWhiteSpace(staff.Username) || string.IsNullOrWhiteSpace(staff.Password))
                        {
                            throw new ArgumentException("Username and Password are required for Admin role.");
                        }

                        cmd.Parameters.AddWithValue("@username", staff.Username);
                        cmd.Parameters.AddWithValue("@password", staff.Password);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@username", DBNull.Value);
                        cmd.Parameters.AddWithValue("@password", DBNull.Value);
                    }

                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public void Delete(int id)
        {
            using (SqlConnection conn = DatabaseConn.getInstance().GetConnection())
            {
                string query = "DELETE FROM Staff WHERE StaffID = @StaffID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StaffID", id);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch (SqlException ex) when (ex.Number == 547) // Foreign key violation
                    {
                        throw new InvalidOperationException("Cannot delete the staff record because it is referenced by other data.");
                    }
                }
            }
        }

        public DataTable GetAll()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = DatabaseConn.getInstance().GetConnection())
            {
                string query = "SELECT * FROM Staff";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dt);
            }
            return dt;
        }

        public DataTable Search(string keyword)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = DatabaseConn.getInstance().GetConnection())
            {
                string query = @"SELECT * FROM Staff WHERE firstName LIKE '%' + @keyword + '%' OR lastName LIKE '%' + @keyword + '%'";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@keyword", keyword);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }
            return dt;
        }
    }
}
