using System;
using System.Data;
using System.Data.SqlClient;

namespace PetWorldManagement.Repository
{
    public class OverviewFormRepository
    {
        private readonly SqlConnection connection;

        public OverviewFormRepository()
        {
            connection = DatabaseConn.getInstance().GetConnection();
        }

        public int GetProductCount()
        {
            string query = "SELECT COUNT(*) AS ProductCount FROM Products";
            int productCount = 0;

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                connection.Open();
                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    productCount = Convert.ToInt32(result);
                }
                connection.Close();
            }

            return productCount;
        }

        public int GetSupplierCount()
        {
            string query = "SELECT COUNT(*) AS SupplierCount FROM Suppliers";
            int supplierCount = 0;

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                connection.Open();
                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    supplierCount = Convert.ToInt32(result);
                }
                connection.Close();
            }

            return supplierCount;
        }

        public int GetServiceCount()
        {
            string query = "SELECT COUNT(*) AS ServiceCount FROM Services";
            int serviceCount = 0;

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                connection.Open();
                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    serviceCount = Convert.ToInt32(result);
                }
                connection.Close();
            }

            return serviceCount;
        }

        public int GetInvoiceCount()
        {
            string query = "SELECT COUNT(*) AS InvoiceCount FROM Invoices";
            int invoiceCount = 0;

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                connection.Open();
                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    invoiceCount = Convert.ToInt32(result);
                }
                connection.Close();
            }

            return invoiceCount;
        }

        public decimal GetTotalPurchased()
        {
            string query = "SELECT SUM(Price * QuantityReceived) AS TotalPurchased FROM Inventory Where StatusID = 2";
            decimal totalPurchased = 0;

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                connection.Open();
                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    totalPurchased = Convert.ToDecimal(result);
                }
                connection.Close();
            }

            return totalPurchased;
        }

        public decimal GetTotalRevenue()
        {
            string query = "SELECT SUM(TotalAmount) AS TotalRevenue FROM Invoices";
            decimal totalRevenue = 0;

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                connection.Open();
                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    totalRevenue = Convert.ToDecimal(result);
                }
                connection.Close();
            }

            return totalRevenue;
        }

        public decimal GetIncome()
        {
            string query = @"SELECT 
                                (SELECT SUM(TotalAmount) FROM Invoices) -
								(SELECT SUM(Price * QuantityReceived) AS TotalPurchased FROM Inventory Where StatusID = 2)
                                 AS Income ";
            decimal income = 0;

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                connection.Open();
                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    income = Convert.ToDecimal(result);
                }
                connection.Close();
            }

            return income < 0 ? 0 : income;
        }
    }
}
