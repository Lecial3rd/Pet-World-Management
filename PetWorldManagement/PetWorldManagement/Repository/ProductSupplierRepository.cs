using PetWorldManagement.Supplier;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetWorldManagement.Repository
{
    public class ProductSupplierRepository
    {
        public void insertProductSuppliers(List<SupplierProductObject> supplierProducts)
        {
            string query = "INSERT INTO SupplierProduct (SupplierID, ProductID, CostPerProduct) VALUES (@SupplierID, @ProductID, @CostPerProduct)";

            using (SqlConnection conn = DatabaseConn.getInstance().GetConnection())
            {
                conn.Open();

                foreach (var supplierProduct in supplierProducts)
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add parameters for each product
                        cmd.Parameters.AddWithValue("@SupplierID", supplierProduct.SupplierID);
                        cmd.Parameters.AddWithValue("@ProductID", supplierProduct.ProductID);
                        cmd.Parameters.AddWithValue("@CostPerProduct", supplierProduct.ProductCost);

                        // Execute the query for each product
                        cmd.ExecuteNonQuery();
                    }
                }

                conn.Close();
            }
        }
    }
}
