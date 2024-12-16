using PetWorldManagement.Inventory;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetWorldManagement.Repository
{
    public class InventoryRepository : IRepository<InventoryObject>
    {
        public DataTable GetAll()
        {
            DataTable dt = new DataTable();

            string query;

            if (InventoryForm.isSummed)
            {
                query = @"SELECT 
                            i.InventoryID AS ID,
                            i.StockID,
                            i.SupplierID,
                            i.SupplierName AS Supplier,
                            i.DateDelivery AS [Delivery Date],
                            i.DateExpiration AS [Expiration Date],
	                        i.DateReceived As [Date Received],
                            i.ProductID,
                            i.ProductName AS Product,
                            i.QuantityReceived AS Quantity,
                            i.Price,
                            (i.QuantityReceived * i.Price) AS TotalPrice,
                            i.StatusID
                        FROM Inventory AS i WHERE i.STATUSID = 2
                        ORDER BY i.DateReceived desc";
            }
            else
            {
                query = @"
                    SELECT 
                        i.InventoryID AS ID,
                        i.StockID,
                        i.SupplierID,
                        i.SupplierName AS Supplier,
                        i.DateDelivery AS [Delivery Date],
                        i.DateExpiration AS [Expiration Date],
                        i.ProductID,
                        i.ProductName AS Product,
                        i.QuantityReceived AS Quantity,
                        i.Price,
                        (i.QuantityReceived * i.Price) AS TotalPrice,
                        i.StatusID
                    FROM Inventory AS i WHERE i.STATUSID = 1";
            }

            using (SqlConnection conn = DatabaseConn.getInstance().GetConnection())
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dt);
            }

            return dt;
        }



        public DataTable Search(string keyword)
        {
            DataTable dt = new DataTable();
            string searchPattern = "%" + keyword + "%";

            using (SqlConnection conn = DatabaseConn.getInstance().GetConnection())
            {
                string query = @"
                        SELECT 
                            i.InventoryID AS ID,
                            i.SupplierName AS Supplier,
                            i.DateDelivery AS [Delivery Date],
                            i.DateExpiration AS [Expiration Date],
                            i.ProductID,
                            i.ProductName AS Product,
                            i.QuantityReceived AS Quantity,
                            i.Price,
                            (i.QuantityReceived * i.Price) AS TotalPrice,
                            i.StatusID
                        FROM Inventory AS i
                        WHERE 
                            i.ProductName LIKE @Keyword
                            OR i.SupplierName LIKE @Keyword
                            OR i.ProductID LIKE @Keyword";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                // Add the parameter to avoid SQL injection
                adapter.SelectCommand.Parameters.AddWithValue("@Keyword", searchPattern);

                adapter.Fill(dt);
            }

            return dt;
        }


        public void Add(InventoryObject entity)
        {
            string query = @"
                INSERT INTO Inventory (SupplierID, ProductID, QuantityReceived, DateDelivery, DateReceived, DateExpiration, StockID, StatusID, Price, ProductName, SupplierName)
                SELECT 
                    @SupplierID, 
                    @ProductID, 
                    @QuantityReceived, 
                    @DateDelivery, 
                    @DateReceived, 
                    @DateExpiration, 
                    @StockID, 
                    @StatusID, 
                    @Price,
                    p.ProductName,  -- Capture ProductName at time of insertion
                    s.SupplierName  -- Capture SupplierName at time of insertion
                FROM Products p
                JOIN Suppliers s ON s.SupplierID = @SupplierID
                WHERE p.ProductID = @ProductID;
                ";

            using (SqlConnection conn = DatabaseConn.getInstance().GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Assign parameters to the SQL command
                    cmd.Parameters.AddWithValue("@SupplierID", entity.SupplierID);
                    cmd.Parameters.AddWithValue("@ProductID", entity.ProductID);
                    cmd.Parameters.AddWithValue("@QuantityReceived", entity.QtyReceived);

                    // Explicitly set the parameter types for date values
                    cmd.Parameters.Add("@DateDelivery", SqlDbType.DateTime).Value = (object)entity.DateDelivery ?? DBNull.Value;
                    cmd.Parameters.Add("@DateReceived", SqlDbType.DateTime).Value = (object)entity.DateReceived ?? DBNull.Value;
                    cmd.Parameters.Add("@DateExpiration", SqlDbType.DateTime).Value = (object)entity.DateExpiration ?? DBNull.Value;

                    cmd.Parameters.AddWithValue("@StockID", entity.StockID);
                    cmd.Parameters.AddWithValue("@StatusID", entity.StatusID);
                    cmd.Parameters.AddWithValue("@Price", entity.Price);

                    // Execute the query
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
        public void Update(InventoryObject entity)
        {
            using (SqlConnection conn = DatabaseConn.getInstance().GetConnection())
            {
                string query = @"
                    UPDATE Inventory
                    SET 
                        SupplierID = @SupplierID,
                        ProductID = @ProductID,
                        QuantityReceived = @QtyReceived,
                        DateDelivery = @DateDelivery,
                        DateReceived = @DateReceived,
                        DateExpiration = @DateExpiration,
                        StockID = @StockID,
                        StatusID = @StatusID,
                        Price = @Price,
                        ProductName = @ProductName,
                        SupplierName = @SupplierName
                    WHERE InventoryID = @InventoryID;
                    ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Add parameters to the command to prevent SQL injection
                    cmd.Parameters.AddWithValue("@SupplierID", entity.SupplierID);
                    cmd.Parameters.AddWithValue("@ProductID", entity.ProductID);
                    cmd.Parameters.AddWithValue("@QtyReceived", entity.QtyReceived);
                    cmd.Parameters.AddWithValue("@DateDelivery", entity.DateDelivery);
                    cmd.Parameters.AddWithValue("@DateReceived", entity.DateReceived);
                    cmd.Parameters.AddWithValue("@DateExpiration", entity.DateExpiration);
                    cmd.Parameters.AddWithValue("@StockID", entity.StockID);
                    cmd.Parameters.AddWithValue("@StatusID", entity.StatusID);
                    cmd.Parameters.AddWithValue("@Price", entity.Price);
                    cmd.Parameters.AddWithValue("@ProductName", entity.ProductName);
                    cmd.Parameters.AddWithValue("@SupplierName", entity.Supplier);
                    cmd.Parameters.AddWithValue("@InventoryID", entity.ID);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int id)
        {

        }
    }
}
