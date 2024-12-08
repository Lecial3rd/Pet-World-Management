using PetWorldManagement.Inventory;
using PetWorldManagement.Stock;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetWorldManagement.Repository
{
    public class StockRepository : IRepository<StockObject>
    {
        public DataTable GetAll()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = DatabaseConn.getInstance().GetConnection())
            {
                string query = "select * from Stock";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dt);
            }
            return dt;
        }

        public DataTable Search(string StockID)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = DatabaseConn.getInstance().GetConnection())
            {
                string query = @"
                    SELECT StockID, TotalQuantity, QuantityAvailable, DamagedQuantity, LastUpdated
                    FROM Stock
                    WHERE StockID = @Keyword";  // Exact match search

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Keyword", StockID);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        public void Add(StockObject entity)
        {
            using (SqlConnection conn = DatabaseConn.getInstance().GetConnection())
            {
                string query = "cp_Stock";  // The stored procedure name

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Add parameters for the stored procedure
                    cmd.Parameters.Add(new SqlParameter("@StockID", SqlDbType.Int)
                    {
                        Value = entity.StockID,
                        Direction = ParameterDirection.Output
                    });
                    cmd.Parameters.Add(new SqlParameter("@ProductID", SqlDbType.Int) { Value = entity.ProductID });
                    cmd.Parameters.Add(new SqlParameter("@Qty", SqlDbType.Int) { Value = entity.Qty });
                    cmd.Parameters.Add(new SqlParameter("@QtyDamage", SqlDbType.Int) { Value = entity.QtyDamage });
                    cmd.Parameters.Add(new SqlParameter("@Date", SqlDbType.DateTime) { Value = entity.Date });
                    cmd.Parameters.Add(new SqlParameter("@type", SqlDbType.VarChar, 50) { Value = entity.Type });

                    // Open connection and execute the stored procedure
                    conn.Open();
                    cmd.ExecuteNonQuery();

                    // Retrieve the StockID from the output parameter
                    entity.StockID = (int)cmd.Parameters["@StockID"].Value;

                    conn.Close();
                }
            }
        }




        public void Update(StockObject entity)
        {
            // If state is true, execute the first query (damage update)
            if (StockForm.state == true)
            {
                string procedureName = "cp_StockDamage";

                // Use the DatabaseConn singleton to get the connection for the procedure call
                using (SqlConnection connection = DatabaseConn.getInstance().GetConnection())
                {
                    try
                    {
                        connection.Open();
                        using (SqlTransaction transaction = connection.BeginTransaction())
                        {
                            using (SqlCommand cmd = new SqlCommand(procedureName, connection, transaction))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;

                                // Pass parameters to the procedure
                                cmd.Parameters.AddWithValue("@QuantityToDeduct", entity.QtyDamage);
                                cmd.Parameters.AddWithValue("@ProductID", entity.ProductID);

                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    // Damage update was successful
                                    transaction.Commit();
                                    MessageBox.Show("Damaged Quantity updated successfully.");
                                }
                                else
                                {
                                    // Rollback if the update fails
                                    transaction.Rollback();
                                    MessageBox.Show("Damage update failed.");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }

            }
            // If state is false, execute the second query (quantity update)
            else
            {
                // Stored Procedure execution query
                string execProcQuery = "EXEC cp_StockBuyDeduct @ProductID = @ProductID, @NumberOfItems = @NumberOfItems";

                using (SqlConnection connection = DatabaseConn.getInstance().GetConnection())
                {
                    try
                    {
                        connection.Open();

                        // Begin a transaction to ensure consistency
                        using (SqlTransaction transaction = connection.BeginTransaction())
                        {
                            using (SqlCommand cmd = new SqlCommand(execProcQuery, connection, transaction))
                            {
                                // Add parameters to the stored procedure execution command
                                cmd.Parameters.AddWithValue("@ProductID", entity.ProductID); // Replace entity.ProductID with your product ID
                                cmd.Parameters.AddWithValue("@NumberOfItems", entity.numberOfItem); // Replace entity.numberOfItem with the number of items to deduct

                                // Execute the stored procedure
                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    // If the stored procedure executes successfully, commit the transaction
                                    transaction.Commit();
                                    MessageBox.Show("Stock deduction successful.");
                                    return;  // Exit after successful deduction
                                }
                                else
                                {
                                    // Rollback if the stored procedure execution fails
                                    transaction.Rollback();
                                    MessageBox.Show("Stock deduction failed.");
                                    return;  // Exit if deduction fails
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        public void Delete(int id)
        {
            using (SqlConnection conn = DatabaseConn.getInstance().GetConnection())
            {
                string query = "DELETE FROM Stock WHERE StockID = @StockID"; 
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StockID", id);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
