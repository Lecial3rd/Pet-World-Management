using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetWorldManagement.Supplier;

namespace PetWorldManagement
{
    public class SupplierRepository : IRepository<SupplierObject>
    {
        private readonly SqlConnection connection;
        int newSupplierID;

        public SupplierRepository()
        {
            connection = DatabaseConn.getInstance().GetConnection();
        }

        public DataTable GetAll()
        {
            DataTable dt = new DataTable();
            string query = "SELECT SupplierID, SupplierName as Name, Address, ContactPerson as 'Contact Person', ContactEmail as Email, ContactPhone as 'Phone No.' FROM Suppliers";
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            da.Fill(dt);
            return dt;
        }

        public void Add(SupplierObject supplier)
        {
            string query = @"
                        INSERT INTO Suppliers (SupplierName, Address, ContactPerson, ContactEmail, ContactPhone) 
                        VALUES (@SupplierName, @Address, @ContactPerson, @ContactEmail, @ContactPhone);
                        SELECT SCOPE_IDENTITY();";

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@SupplierName", supplier.SupplierName);
                cmd.Parameters.AddWithValue("@Address", supplier.address);
                cmd.Parameters.AddWithValue("@ContactPerson", supplier.contactPerson);
                cmd.Parameters.AddWithValue("@ContactEmail", supplier.contactEmail);
                cmd.Parameters.AddWithValue("@ContactPhone", supplier.contactPhone);

                connection.Open();
                newSupplierID = Convert.ToInt32(cmd.ExecuteScalar());
                SupplerIDBridge.setSupplierID(newSupplierID);
                connection.Close();
            }
        }

        public void Update(SupplierObject supplier)
        {

            string query = "UPDATE Suppliers SET SupplierName = @SupplierName, Address = @Address, ContactPerson = @ContactPerson, ContactEmail = @ContactEmail, ContactPhone = @ContactPhone WHERE SupplierID = @SupplierID";
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@SupplierID", supplier.SupplierID);
                cmd.Parameters.AddWithValue("@SupplierName", supplier.SupplierName);
                cmd.Parameters.AddWithValue("@Address", supplier.address);
                cmd.Parameters.AddWithValue("@ContactPerson", supplier.contactPerson);
                cmd.Parameters.AddWithValue("@ContactEmail", supplier.contactEmail);
                cmd.Parameters.AddWithValue("@ContactPhone", supplier.contactPhone);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Delete(int supplierID)
        {
            string query1 = $"DELETE FROM SupplierProduct WHERE SupplierID = {supplierID}";
            string query2 = $"DELETE FROM Suppliers WHERE SupplierID = {supplierID}";

            using (SqlCommand cmd = new SqlCommand(query1, connection))
            {
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }

            using (SqlCommand cmd = new SqlCommand(query2, connection))
            {
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }


        public DataTable Search(string keyword)
        {
            DataTable dt = new DataTable();
            string query = @"
                            SELECT SupplierID, SupplierName as Name, Address, ContactPerson as 'Contact Person', ContactEmail as Email, ContactPhone as 'Phone No.' 
                            FROM Suppliers 
                            WHERE SupplierName LIKE @Keyword OR CAST(SupplierID AS NVARCHAR) LIKE @Keyword";

            using (SqlConnection connection = DatabaseConn.getInstance().GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    // Prepare the keyword for both SupplierName and SupplierID
                    cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            return dt;
        }
    }
}
