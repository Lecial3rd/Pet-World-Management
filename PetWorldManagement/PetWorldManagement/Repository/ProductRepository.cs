using System;
using System.Data.SqlClient;
using System.Data;

namespace PetWorldManagement
{
    public class ProductRepository : IRepository<ProductObject>
    {
        public DataTable GetAll()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = DatabaseConn.getInstance().GetConnection())
            {
                string query = "SELECT ProductID, ProductName as 'Product Name', CategoryID, Description, Price FROM Products";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dt);
            }
            return dt;
        }

        public void Add(ProductObject product)
        {
            string query = "INSERT INTO Products (ProductImage, ProductName, CategoryID, Description, Price) " +
                           "VALUES (@ProductImage, @ProductName, @CategoryID, @Description, @Price)";

            using (SqlConnection conn = DatabaseConn.getInstance().GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ProductImage", (object)product.ProductImage ?? DBNull.Value); // Handle NULL image
                    cmd.Parameters.AddWithValue("@ProductName", product.ProductName);
                    cmd.Parameters.AddWithValue("@CategoryID", product.CategoryID);
                    cmd.Parameters.AddWithValue("@Description", product.Description);
                    cmd.Parameters.AddWithValue("@Price", product.Price);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        public void Update(ProductObject product)
        {
            string query = "UPDATE Products SET ProductName = @ProductName, CategoryID = @CategoryID, Description = @Description, Price = @Price";

            if (product.ProductImage != null)
            {
                query += ", ProductImage = @ProductImage"; // Update image only if a new one is provided
            }

            query += " WHERE ProductID = @ProductID";

            using (SqlConnection conn = DatabaseConn.getInstance().GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ProductName", product.ProductName);
                    cmd.Parameters.AddWithValue("@CategoryID", product.CategoryID);
                    cmd.Parameters.AddWithValue("@Description", product.Description);
                    cmd.Parameters.AddWithValue("@Price", product.Price);
                    cmd.Parameters.AddWithValue("@ProductID", product.ProductID);

                    if (product.ProductImage != null)
                    {
                        cmd.Parameters.AddWithValue("@ProductImage", product.ProductImage); // Update image
                    }

                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        public void Delete(int productId)
        {
            using (SqlConnection conn = DatabaseConn.getInstance().GetConnection())
            {
                string query = "DELETE FROM Products WHERE ProductID = @ProductID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ProductID", productId);
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
                string query = @"
                SELECT ProductID, ProductName as 'Product Name', CategoryID, Description, Price 
                FROM Products 
                WHERE ProductName LIKE '%' + @Keyword + '%' OR CAST(ProductID AS NVARCHAR) LIKE '%' + @Keyword + '%'";
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
