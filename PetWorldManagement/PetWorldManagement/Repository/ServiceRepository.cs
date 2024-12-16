using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using PetWorldManagement.Service;

namespace PetWorldManagement.Repository
{
    public class ServiceRepository : IRepository<ServiceObject>
    {
        
        public DataTable GetAll()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = DatabaseConn.getInstance().GetConnection())
            {
                string query = "SELECT ServiceID, ServiceName, Price FROM Services";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dt);
            }
            return dt;
        }

        public void Add(ServiceObject service)
        {
            using (SqlConnection conn = DatabaseConn.getInstance().GetConnection())
            {
                string query = "INSERT INTO Services (ServiceName, Price) VALUES (@ServiceName, @Price)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ServiceName", service.Name);
                    cmd.Parameters.AddWithValue("@Price", service.Price);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public void Update(ServiceObject service)
        {
            using (SqlConnection conn = DatabaseConn.getInstance().GetConnection())
            {
                string query = "UPDATE Services SET ServiceName = @ServiceName, Price = @Price WHERE ServiceID = @ServiceID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ServiceName", service.Name);
                    cmd.Parameters.AddWithValue("@Price", service.Price);
                    cmd.Parameters.AddWithValue("@ServiceID", service.Id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
        public void Delete(int id)
        {
            using (SqlConnection conn = DatabaseConn.getInstance().GetConnection())
            {
                string query = "DELETE FROM Services WHERE ServiceID = @ServiceID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ServiceID", id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public DataTable Search(string keyword)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = DatabaseConn.getInstance().GetConnection())
            {
                string query = @"SELECT ServiceID, ServiceName, Price FROM Services 
                                 WHERE ServiceName LIKE '%' + @Keyword + '%' 
                                 OR CAST(ServiceID AS NVARCHAR) LIKE '%' + @Keyword + '%'
                                 OR CAST(Price AS NVARCHAR) LIKE '%' + @Keyword + '%'";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Keyword", keyword);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }
            return dt;
        }
    }
}
