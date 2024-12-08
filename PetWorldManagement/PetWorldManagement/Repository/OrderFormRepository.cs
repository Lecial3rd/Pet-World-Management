using PetWorldManagement.Supplier.PurchaseOrder;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace PetWorldManagement.Repository
{
    public class OrderFormRepository
    {
        private readonly SqlConnection connection;

        public OrderFormRepository()
        {
            connection = DatabaseConn.getInstance().GetConnection();
        }

        public List<ProductItem> GetSupplierProducts(int supplierID)
        {
            var products = new List<ProductItem>();
            string query = @"
                SELECT p.ProductID, p.ProductName, sp.CostPerProduct
                FROM SupplierProduct sp
                JOIN Suppliers s ON sp.SupplierID = s.SupplierID
                JOIN Products p ON sp.ProductID = p.ProductID
                WHERE s.SupplierID = @SupplierID";

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@SupplierID", supplierID);
                connection.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int productID = reader.GetInt32(0);
                        string productName = reader.GetString(1);
                        decimal Itemprice = reader.GetDecimal(2);
                        products.Add(new ProductItem(productID, productName, Itemprice));
                    }
                }

                connection.Close();
            }

            return products;
        }

        public int GetCategoryID(int productID)
        {
            string query = "SELECT CategoryID FROM Products WHERE ProductID = @ProductID";
            int categoryID = -1;

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@ProductID", productID);
                connection.Open();

                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    categoryID = Convert.ToInt32(result);
                }

                connection.Close();
            }

            return categoryID;
        }
        public (int StatusID, string Status) GetStatus()
        {
            string query = "SELECT StatusID, Status FROM Status WHERE Category = 'Inventory' AND Status = 'Pending'";
            int statusID = 0;
            string status = string.Empty;

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                connection.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        statusID = Convert.ToInt32(reader["StatusID"]);
                        status = reader["Status"].ToString();
                    }
                }
                connection.Close();
            }

            return (statusID, status);
        }
        public string GetSupplierName(int supplierID)
        {
            string query = "SELECT SupplierName FROM Suppliers WHERE SupplierID = @SupplierID";
            string supplierName = string.Empty;

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@SupplierID", supplierID);
                connection.Open();

                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    supplierName = result.ToString();
                }

                connection.Close();
            }
            return supplierName;
        }

        public DataTable GetStatuses()
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = DatabaseConn.getInstance().GetConnection())
            {
                string query = @"
                                SELECT 
                                    StatusID, 
                                    Status 
                                FROM Status
                                WHERE Category = 'Inventory'";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dt);
            }

            return dt;
        }

        public DataTable GetInventoryProduct()
        {
            string query = @"
                        SELECT 
                            i.ProductID, 
                            p.ProductName as Product,
                            SUM(s.DamagedQuantity) AS DamageQuantity,
                            SUM(s.TotalQuantity) AS TotalQuantity,
                            SUM(s.QuantityAvailable) AS TotalAvailableQuantity
                        FROM Inventory AS i
                        JOIN Products AS p ON i.ProductID = p.ProductID
                        JOIN Stock AS s ON i.StockID = s.StockID
                        WHERE i.StatusID = 2
                        GROUP BY i.ProductID, p.ProductName";

            DataTable dt = new DataTable();

            using (SqlConnection conn = DatabaseConn.getInstance().GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                    conn.Close();
                }
            }

            return dt;
        }
    }
}
