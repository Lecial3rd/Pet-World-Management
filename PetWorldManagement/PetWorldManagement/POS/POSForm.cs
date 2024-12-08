using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetWorldManagement.POS
{
    public partial class POSForm : Form
    {
        public POSForm()
        {
            InitializeComponent();
            AddProductToLayout();
        }
        private void AddProductToLayout(int categoryId = 0)
        {
            SqlConnection conn = DatabaseConn.getInstance().GetConnection();
            string query = @"SELECT p.ProductImage, p.ProductID, p.ProductName, p.Price, c.CategoryID, COALESCE(SUM(s.QuantityAvailable),0) as AvailableQuantity
                            FROM Products AS p 
                            INNER JOIN Categories AS c ON p.CategoryID = c.CategoryID 
                            LEFT JOIN Inventory AS i ON p.ProductID = i.ProductID 
                            LEFT JOIN Stock AS s ON i.StockID = s.StockID";





            if (categoryId != 0)
            {
                query += " WHERE c.CategoryID = @CategoryID";
            }
            query += " GROUP BY p.ProductImage, p.ProductID, p.ProductName, p.Price, c.CategoryID";

            using (SqlCommand command = new SqlCommand(query, conn))
            {
                if (categoryId != 0)
                {
                    command.Parameters.AddWithValue("@CategoryID", categoryId);
                }

                try
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        //To clear
                        flowLayoutPanel1.Controls.Clear();

                        while (reader.Read())
                        {
                            byte[] imageData = null;
                            if (!reader.IsDBNull(0))
                            {
                                imageData = (byte[])reader.GetValue(0);
                            }

                            int ProductID = Convert.ToInt32(reader.GetValue(1));
                            string Name = reader.GetValue(2).ToString();
                            double Price = Convert.ToDouble(reader.GetValue(3));
                            int QuantityAvailable = reader.IsDBNull(5) ? 0 : Convert.ToInt32(reader.GetValue(5));



                            Image productImage = null;
                            if (imageData != null)
                            {
                                using (MemoryStream ms = new MemoryStream(imageData))
                                {
                                    productImage = Image.FromStream(ms);
                                }
                            }


                            AddProductDetails(ProductID, Name, Price, productImage, QuantityAvailable);



                            if (QuantityAvailable == 0)
                            {
                                ProductItem.lblNotAvailable.Visible = true;
                            }

                        }
                    }
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show("Database error: " + sqlEx.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }

            }

        }
        public void AddProductDetails(int ProductID, string Name, double Price, Image imageData, int QuantityAvailable)
        {
            ProductControl productControl = new ProductControl();
            ProductItem productItem = new ProductItem();


            productItem.ProductDetails(Name, Price, imageData);
            productControl.Tag = ProductID;

            flowLayoutPanel1.Controls.Add(productItem);

            productControl.txtQuantity.Text = "1";
            productControl.lblprice.Text = Price.ToString("N2");

            if (QuantityAvailable == 0)
            {
                ProductItem.lblNotAvailable.Visible = true;
            }



            productItem.btnAddtoCart.Click += (sender, e) =>
            {
                bool productExists = false;


                foreach (ProductControl pc in productLayout.Controls)
                {
                    if (pc.Tag != null && (int)pc.Tag == ProductID)
                    {
                        productExists = true;
                        break;

                    }

                }

                if (!productExists && QuantityAvailable > 0)
                {
                    productControl.SetProductControl(Name, 1, Price, ProductID);
                    productLayout.Controls.Add(productControl);
                }

                UpdatePrice();
            };


            productControl.btnAddQuantity.Click += (sender1, e1) =>
            {

                IncreaseQuantity(productControl, QuantityAvailable, Price);

            };




            productControl.btnMinusProduct.Click += (sender2, e2) =>
            {

                DecreaseQuantity(productControl);
            };

            productControl.btnRemove.Click += (sender3, e3) =>
            {
                ProductControl_RemoveClicked(productControl, EventArgs.Empty);
            };

            productControl.QuantityChanged += UpdatePrice;



        }
        private void IncreaseQuantity(ProductControl productControl, int stockQuantity, double price)
        {
            int currentQuantity;


            if (int.TryParse(productControl.txtQuantity.Text, out currentQuantity) && currentQuantity < stockQuantity)
            {
                currentQuantity++;
                productControl.txtQuantity.Text = currentQuantity.ToString();
            }

            UpdatePrice();
        }

        private void DecreaseQuantity(ProductControl productControl)
        {
            int currentQuantity;

            if (int.TryParse(productControl.txtQuantity.Text, out currentQuantity) && currentQuantity > 1)
            {
                currentQuantity--;
                productControl.txtQuantity.Text = currentQuantity.ToString();
            }
            else if (currentQuantity == 1)
            {
                productLayout.Controls.Remove(productControl);
            }

            UpdatePrice();
        }
        private void ProductControl_RemoveClicked(object sender, EventArgs e)
        {

            for (int i = 0; i < productLayout.Controls.Count; i++)
            {
                if (productLayout.Controls[i] == sender)
                {

                    productLayout.Controls.RemoveAt(i);
                    break;
                }
            }

            UpdatePrice();
        }
        private void UpdatePrice()
        {
            double toPrice = 0;

            foreach (ProductControl control in productLayout.Controls.OfType<ProductControl>())
            {
                if (int.TryParse(control.txtQuantity.Text, out int quantity) && double.TryParse(control.lblprice.Text, out double price))
                {
                    toPrice += quantity * control.defaultPrice;
                }
            }

            totalPrice.Text = "₱" + toPrice.ToString("N2");


        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            AddProductToLayout();
        }

        private void btnGrooming_Click(object sender, EventArgs e)
        {
            AddProductToLayout(1);
        }

        private void btnAccessories_Click(object sender, EventArgs e)
        {
            AddProductToLayout(2);
        }

        private void btnToys_Click(object sender, EventArgs e)
        {
            AddProductToLayout(3);
        }

        private void btnFoods_Click(object sender, EventArgs e)
        {
            AddProductToLayout(4);
        }


        private void SearchProduct(string searchText)
        {
            SqlConnection conn = DatabaseConn.getInstance().GetConnection();
            string query = @"SELECT p.ProductImage, p.ProductID, p.ProductName, p.Price, 
           COALESCE(SUM(s.QuantityAvailable),0) as AvailableQuantity
           FROM Products AS p
           LEFT JOIN Inventory AS i ON p.ProductID = i.ProductID
           LEFT JOIN Stock AS s ON i.StockID = s.StockID
           WHERE p.ProductName LIKE '%' + @SearchText + '%'
           GROUP BY p.ProductImage, p.ProductID, p.ProductName, p.Price";


            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@SearchText", searchText);


                try
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        flowLayoutPanel1.Controls.Clear();

                        while (reader.Read())
                        {
                            byte[] imageData = null;
                            if (!reader.IsDBNull(0))
                            {
                                imageData = (byte[])reader.GetValue(0);
                            }

                            int ProductID = Convert.ToInt32(reader.GetValue(1));
                            string Name = reader.GetValue(2).ToString();
                            double Price = Convert.ToDouble(reader.GetValue(3));
                            int QuantityAvailable = reader.IsDBNull(4) ? 0 : Convert.ToInt32(reader.GetValue(4));




                            Image productImage = null;
                            if (imageData != null)
                            {
                                using (MemoryStream ms = new MemoryStream(imageData))
                                {
                                    productImage = Image.FromStream(ms);
                                }
                            }


                            AddProductDetails(ProductID, Name, Price, productImage, QuantityAvailable);
                            ProductItem productItem = new ProductItem();


                            if (QuantityAvailable == 0)
                            {
                                ProductItem.lblNotAvailable.Visible = true;
                            }

                        }
                    }
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show("Database error: " + sqlEx.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }


            }

        }

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchBox.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                AddProductToLayout();
                return;
            }
            SearchProduct(searchText);
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
           

            double TPrice;
            if (!double.TryParse(totalPrice.Text.Replace("₱", ""), out TPrice))
            {
                MessageBox.Show("Error calculating the total price.");
                return;
            }

            double submitAmount;
            if (double.TryParse(txtReceived.Text, out submitAmount))
            {
                if (submitAmount >= TPrice)
                {
                    SqlConnection conn = DatabaseConn.getInstance().GetConnection();

                    try
                    {
                        if (conn.State == ConnectionState.Closed)
                            conn.Open();

                        using (SqlTransaction transaction = conn.BeginTransaction())
                        {
                            try
                            {
                                int totalQuantitySold = 0;
                                double discountAmount = 0;

                               
                                string insertTransaction = @"Insert Into SalesTransactions 
                                                     (StaffID, TotalQuantitySold, TotalPrice, DiscountRate, PaymentMethod, Change)
                                                     Values (@StaffID, @TotalQuantitySold, @TotalPrice, @DiscountRate, @PaymentMethod, @Change);
                                                     SELECT SCOPE_IDENTITY();";

                                int staffId;
                                if (!int.TryParse(txtboxCashier.Text, out staffId))
                                {
                                    MessageBox.Show("Invalid Staff ID.");
                                    return;
                                }

                                double discountRate = 0;
                                if (!double.TryParse(txtboxDiscount.Text, out discountRate))
                                {
                                    MessageBox.Show("Invalid Discount Rate.");
                                    return;
                                }

                                discountAmount = TPrice * discountRate / 100;
                                TPrice -= discountAmount;

                                int transactionId;
                                using (SqlCommand cmdTransaction = new SqlCommand(insertTransaction, conn, transaction))
                                {
                                    cmdTransaction.Parameters.AddWithValue("@StaffID", staffId);
                                    cmdTransaction.Parameters.AddWithValue("@TotalQuantitySold", totalQuantitySold);
                                    cmdTransaction.Parameters.AddWithValue("@TotalPrice", TPrice);
                                    cmdTransaction.Parameters.AddWithValue("@DiscountRate", discountRate);
                                    cmdTransaction.Parameters.AddWithValue("@PaymentMethod", "Cash");
                                    cmdTransaction.Parameters.AddWithValue("@Change", submitAmount - TPrice);

                                    transactionId = Convert.ToInt32(cmdTransaction.ExecuteScalar());
                                }
     
                                string insertInvoice = @"Insert Into Invoices (InvoiceType, TransactionID, InvoiceDate, TotalAmount)
                                                        Values (@InvoiceType, @TransactionID, @InvoiceDate, @TotalAmount);
                                                        SELECT SCOPE_IDENTITY();";


                                int invoiceId;


                                using (SqlCommand cmdInsertInvoice = new SqlCommand(insertInvoice, conn, transaction))
                                {

                                    cmdInsertInvoice.Parameters.AddWithValue("@InvoiceType", "Sales");
                                    cmdInsertInvoice.Parameters.AddWithValue("@TransactionID", transactionId);
                                    cmdInsertInvoice.Parameters.AddWithValue("@InvoiceDate", DateTime.Now);
                                    cmdInsertInvoice.Parameters.AddWithValue("@TotalAmount", TPrice);

                                    invoiceId = Convert.ToInt32(cmdInsertInvoice.ExecuteScalar());
                                }


                                foreach (ProductControl pc in productLayout.Controls.OfType<ProductControl>())
                                {
                                    int productId = Convert.ToInt32(pc.Tag);
                                    int quantity;
                                    if (int.TryParse(pc.txtQuantity.Text, out quantity) && quantity > 0)
                                    {
                                        totalQuantitySold += quantity;

                                      
                                        string insertSalesQuery = @"Insert Into Sales (ProductID, ProductName, QuantitySold, ItemPrice)
                                                            Values (@ProductID, @ProductName, @QuantitySold, @ItemPrice);
                                                            SELECT SCOPE_IDENTITY();";

                                        int saleId;
                                        using (SqlCommand cmdSales = new SqlCommand(insertSalesQuery, conn, transaction))
                                        {
                                            cmdSales.Parameters.AddWithValue("@ProductID", productId);
                                            cmdSales.Parameters.AddWithValue("@ProductName", pc.pname);
                                            cmdSales.Parameters.AddWithValue("@QuantitySold", quantity);
                                            cmdSales.Parameters.AddWithValue("@ItemPrice", pc.defaultPrice);

                                            saleId = Convert.ToInt32(cmdSales.ExecuteScalar());
                                        }

                                        
                                        string insertSalesItem = @"Insert Into SalesItems (TransactionID, SaleID, TotalPrice)
                                                           Values (@TransactionID, @SaleID, @TotalPrice);";

                                        using (SqlCommand cmdSalesItem = new SqlCommand(insertSalesItem, conn, transaction))
                                        {
                                            cmdSalesItem.Parameters.AddWithValue("@TransactionID", transactionId);
                                            cmdSalesItem.Parameters.AddWithValue("@SaleID", saleId);
                                            cmdSalesItem.Parameters.AddWithValue("@TotalPrice", quantity * pc.defaultPrice);
                                            cmdSalesItem.ExecuteNonQuery();
                                        }

                                       
                                        string updateStockQuery = @"EXEC dbo.cp_StockBuyDeduct @ProductID = @ProductID, @NumberOfItems = @Quantity;";
                                        using (SqlCommand updateStockCmd = new SqlCommand(updateStockQuery, conn, transaction))
                                        {
                                            updateStockCmd.Parameters.AddWithValue("@ProductID", productId);
                                            updateStockCmd.Parameters.AddWithValue("@Quantity", quantity);
                                            updateStockCmd.ExecuteNonQuery();
                                        }
                                    }
                                }

                              
                                string updateTransactionQuery = @"UPDATE SalesTransactions
                                                              SET TotalQuantitySold = @TotalQuantitySold
                                                              WHERE TransactionID = @TransactionID;";

                                using (SqlCommand cmdUpdateTransaction = new SqlCommand(updateTransactionQuery, conn, transaction))
                                {
                                    cmdUpdateTransaction.Parameters.AddWithValue("@TotalQuantitySold", totalQuantitySold);
                                    cmdUpdateTransaction.Parameters.AddWithValue("@TransactionID", transactionId);
                                    cmdUpdateTransaction.ExecuteNonQuery();
                                }

                                transaction.Commit();

                               
                               
                                double change = submitAmount - TPrice;
                                label3.Text = "Change:";
                                totalPrice.Text = change.ToString("F2");
                                txtReceived.Clear();
                                txtboxDiscount.Clear();
                                MessageBox.Show("Your Payment is Successful!");
                                productLayout.Controls.Clear();
                                UpdatePrice();
                                DisplayInvoice(invoiceId, submitAmount, change);
                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback();
                                MessageBox.Show("Transaction failed: " + ex.Message);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database error: " + ex.Message);
                    }
                    finally
                    {
                        if (conn.State == ConnectionState.Open)
                            conn.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Insufficient Payment!");
                }
            }
            else
            {
                MessageBox.Show("Invalid Payment!");
            }

        }

        private void DisplayInvoice(int InvoiceID, double submitAmount, double change)
        {
            InvoiceForm invoiceDisplay = new InvoiceForm();
            double FinalTotal = 0;

            SqlConnection conn = DatabaseConn.getInstance().GetConnection();
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string query = @"Select
                                        i.InvoiceID, 
                                        i.InvoiceDate, 
                                        s.ProductID, 
                                        s.ProductName,
                                        s.QuantitySold,
                                        s.ItemPrice,
                                        (s.QuantitySold * s.ItemPrice) as SubTotal,
                                        i.TotalAmount, st.DiscountRate
                                From Sales s 
                                Inner join  SalesItems si on si.SaleID = s.SaleID
                                Inner join Invoices i on i.TransactionID = si.TransactionID
                                Inner join SalesTransactions st on st.TransactionID = i.TransactionID
                                where i.InvoiceID = @InvoiceID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@InvoiceID", InvoiceID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        bool isInvoiceDetailsFetched = false;

                        while (reader.Read())
                        {
                            if (!isInvoiceDetailsFetched)
                            {

                                invoiceDisplay.lblInvoiceID.Text = reader.GetInt32(0).ToString();
                                invoiceDisplay.lblInvoiceDate.Text = reader.GetDateTime(1).ToString("MMMM dd, yyyy");
                                decimal totalAmount = reader.GetDecimal(7);
                                decimal discountrate = reader.GetDecimal(8);
                                invoiceDisplay.lblDR.Text = discountrate.ToString();
                                invoiceDisplay.lblTAmount.Text = totalAmount.ToString("F2");
                                invoiceDisplay.cshrcvlbl.Text = submitAmount.ToString("F2");
                                invoiceDisplay.changelbl.Text = change.ToString("F2");
                                invoiceDisplay.lblTAmount.Visible = true;
                                isInvoiceDetailsFetched = true;
                            }


                            int productID = reader.GetInt32(2);
                            string productName = reader.GetString(3);
                            int quantity = reader.GetInt32(4);
                            decimal itemPrice = reader.GetDecimal(5);
                            decimal subtotal = reader.GetDecimal(6);

                            FinalTotal += (double)subtotal;


                            InvoiceLayout invoiceItemLayout = new InvoiceLayout();
                            invoiceItemLayout.ShowInvoiceLayout(productName, (int)itemPrice, quantity, (double)subtotal);
                            invoiceDisplay.InvoiceFlowLayout.Controls.Add(invoiceItemLayout);


                        }


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {

                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }


            invoiceDisplay.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            productLayout.Controls.Clear();
            UpdatePrice();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string staffid = txtboxCashier.Text.Trim();

            // Toggle behavior for enabling/disabling the input
            if (txtboxCashier.Enabled == false)
            {
                txtboxCashier.Enabled = true;
                lblCashierName.Text = string.Empty;
                return;
            }

            // Validate if the StaffID field is empty
            if (string.IsNullOrEmpty(staffid))
            {
                MessageBox.Show("Please enter a valid cashier ID to proceed.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = @"
                            SELECT s.lastName, s.firstName, s.mi 
                            FROM Staff s 
                            INNER JOIN Role r ON s.RoleID = r.RoleID
                            WHERE s.StaffID = @StaffID AND r.RoleName = 'Cashier'";

            SqlConnection conn = DatabaseConn.getInstance().GetConnection();
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                using (SqlCommand cmdStaff = new SqlCommand(query, conn))
                {
                    cmdStaff.Parameters.AddWithValue("@StaffID", staffid);
                    using (SqlDataReader reader = cmdStaff.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string lastName = reader["lastName"].ToString();
                            string firstName = reader["firstName"].ToString();
                            string mi = reader["mi"].ToString();

                            lblCashierName.Text = $"{lastName}, {firstName} {mi}".Trim();
                            txtboxCashier.Enabled = false;

                            MessageBox.Show($"Cashier {lblCashierName.Text} successfully selected.", "Selection Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("The entered cashier ID is not valid or does not belong to a cashier. Please try again.", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred while processing your request:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
    }
}

