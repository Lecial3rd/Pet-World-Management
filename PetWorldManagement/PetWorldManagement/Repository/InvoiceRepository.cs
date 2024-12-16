using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetWorldManagement.Invoice;

namespace PetWorldManagement.Repository.RepositoryFactoryMethod
{
    public class InvoiceRepository
    {
        public DataTable GetAll()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = DatabaseConn.getInstance().GetConnection())
            {
                string query = @"SELECT
                                    s.InvoiceID as ID,
                                    s.InvoiceType as Type,
                                    s.TransactionID as 'Transaction ID',
                                    COALESCE(s.AppointmentID, '') AS 'Appointment ID',
                                    s.InvoiceDate as Date,
                                    s.TotalAmount
                                FROM
                                    Invoices AS s
                                ORDER BY s.InvoiceDate DESC";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dt);
            }
            return dt;
        }

        public DataTable ViewSpecificAppointmentInvoice(int invoiceID)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = DatabaseConn.getInstance().GetConnection())
            {
                string query = @"SELECT 
                                    app.AppointmentID,
                                    app.CustomerName,
                                    app.PetName,
                                    apps.ServiceName, 
                                    apps.Quantity,
                                    apps.Price,
                                    apps.TotalAmount as TotalPrice,
							        inv.TotalAmount as GrandTotal,
                                    st.Change,
                                    st.DiscountRate,
                                    (st.Change + st.TotalPrice) as CashReceived,
                                    st.PaymentMethod
                                FROM 
                                    AppointmentService apps
                                INNER JOIN Services s ON apps.ServiceID = s.ServiceID
                                INNER JOIN Appointment app on apps.AppointmentID = app.AppointmentID
                                INNER JOIN Invoices inv on app.AppointmentID = inv.AppointmentID
                                INNER JOIN SalesTransactions st on inv.TransactionID = st.TransactionID
                                WHERE InvoiceID = @InvoiceID";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@InvoiceID", invoiceID);
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        public DataTable ViewSpecificSalesInvoice(int invoiceID)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = DatabaseConn.getInstance().GetConnection())
            {
                string query = @"SELECT 
                            i.InvoiceID, 
                            i.InvoiceDate, 
                            s.ProductID, 
                            s.ProductName,
                            s.QuantitySold,
                            s.ItemPrice,
                            (s.QuantitySold * s.ItemPrice) AS SubTotal,
                            i.TotalAmount, 
                            st.DiscountRate,
                            st.Change,
                            (st.Change + i.TotalAmount) AS Amount,
                            st.PaymentMethod
                        FROM 
                            Sales s 
                        INNER JOIN SalesItems si ON si.SaleID = s.SaleID
                        INNER JOIN Invoices i ON i.TransactionID = si.TransactionID
                        INNER JOIN SalesTransactions st ON st.TransactionID = i.TransactionID
                        WHERE i.InvoiceID = @InvoiceID";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@InvoiceID", invoiceID);
                    adapter.Fill(dt);
                }
            }
            return dt;
        }


        public DataTable Search(string invoiceKeyword)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = DatabaseConn.getInstance().GetConnection())
            {
                string query = @"SELECT
                                    s.InvoiceID AS ID,
                                    s.InvoiceType AS Type,
                                    COALESCE(s.TransactionID, '') AS 'Transaction ID',
                                    COALESCE(s.AppointmentID, '') AS 'Appointment ID',
                                    s.InvoiceDate AS Date,
                                    s.TotalAmount
                                FROM
                                    Invoices AS s
                                WHERE 
                                    CAST(s.InvoiceID AS NVARCHAR) LIKE '%' + @InvoiceKeyword + '%' OR
                                    CAST(s.InvoiceType AS NVARCHAR) LIKE '%' + @InvoiceKeyword + '%' OR
                                    CAST(s.TransactionID AS NVARCHAR) LIKE '%' + @InvoiceKeyword + '%' OR
                                    CAST(s.AppointmentID AS NVARCHAR) LIKE '%' + @InvoiceKeyword + '%'";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@InvoiceKeyword", invoiceKeyword);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }
            return dt;
        }
    }
}