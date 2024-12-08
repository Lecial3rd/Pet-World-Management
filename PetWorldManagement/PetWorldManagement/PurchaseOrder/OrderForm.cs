using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PetWorldManagement.Inventory;
using PetWorldManagement.Repository;
using PetWorldManagement.Stock;

namespace PetWorldManagement.Supplier.PurchaseOrder
{
    public partial class OrderForm : Form
    {
        private int supplierID, StatusID;
        private readonly List<OrderObject> orderCollection;
        private readonly RepositoryFacade<OrderObject> orderFacade;
        private readonly IRepositoryFactory factory;

        public OrderForm(int supplierID)
        {
            this.supplierID = supplierID;

            factory = new RepositoryFactory();
            orderFacade = new RepositoryFacade<OrderObject>(factory);
            orderCollection = new List<OrderObject>();

            InitializeComponent();
            LoadSupplierProducts();
            LoadStatus();
            LoadSupplierName();
        }

        private void LoadSupplierProducts()
        {
            CbxProducts.Items.Clear();
            var products = orderFacade.GetSupplierProducts(supplierID);

            foreach (var product in products)
            {
                CbxProducts.Items.Add(product);
            }

            CbxProducts.DisplayMember = "ProductName";
        }

        private void CbxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbxProducts.SelectedItem is ProductItem selectedProduct)
            {
                int categoryID = orderFacade.GetProductCategoryID(selectedProduct.ProductID);

                if (categoryID == 2)
                {
                    Expiration_dateTimePicker.Show();
                    expirationDatelbl.Show();
                    Expiration_dateTimePicker.Value = Delivery_dateTimePicker.Value.AddMonths(2);
                    Expiration_dateTimePicker.Enabled = false;
                }
                else
                {
                    Expiration_dateTimePicker.Hide();
                    expirationDatelbl.Hide();
                }
            }
        }

        private void Delivery_dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            Expiration_dateTimePicker.Value = Delivery_dateTimePicker.Value.AddMonths(2);
            Expiration_dateTimePicker.Enabled = false;
        }

        private void LoadStatus()
        {
            var statusResult = orderFacade.GetStatus();
            txtStatus.Text = statusResult.Status;
            StatusID = statusResult.StatusID;
        }

        private void LoadSupplierName()
        {
            txtSupplierName.Text = orderFacade.GetSupplierName(supplierID);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            flowLayout_purchaseOrder.Controls.Clear();

            if (!ValidateInputs())
            {
                return;
            }

            OrderObject orderObject = getOrderObject();
            orderCollection.Add(orderObject);
            AddItem(orderObject);
            UpdateOrderUI();
            UpdateTotalPrice();
        }

        private bool ValidateInputs()
        {
            if (CbxProducts.SelectedItem == null)
            {
                MessageBox.Show("Please select a product.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }else if(string.IsNullOrWhiteSpace(txtQty.Text))
            {
                MessageBox.Show("Number of Item should not be empty.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtQty.Text, out int qty) || qty <= 0)
            {
                MessageBox.Show("Please enter a valid number for Number of Item.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private OrderObject getOrderObject()
        {
            OrderObject orderObject = new OrderObject
            {
                supplierID = supplierID,
                supplierName = txtSupplierName.Text,
                numberOfItem = Convert.ToInt32(txtQty.Text),
                status = txtStatus.Text,
                deliveryDate = Delivery_dateTimePicker.Value.ToString(),
                expirationDate = Expiration_dateTimePicker.Value.ToString()
            };

            if (CbxProducts.SelectedItem is ProductItem selectedProduct)
            {
                orderObject.productName = selectedProduct.ProductName;
                orderObject.productId = selectedProduct.ProductID;
                orderObject.ItemPrice = selectedProduct.ItemPrice;
            }

            return orderObject;
        }

        private void UpdateOrderUI()
        {
            foreach (var item in orderCollection)
            {
                purchasedOrderCard purchasedOrderCard = CreateOrderCard(item);
                flowLayout_purchaseOrder.Controls.Add(purchasedOrderCard);
            }
        }

        private purchasedOrderCard CreateOrderCard(OrderObject orderObject)
        {
            purchasedOrderCard orderCard = new purchasedOrderCard
            {
                lblproductName = { Text = orderObject.productName },
                lblprice = { Text = "₱" + orderObject.ItemPrice.ToString("N2") },
                lblquantity = { Text = orderObject.numberOfItem.ToString() },
                lblsubtotal = { Text = "₱" + (orderObject.numberOfItem * orderObject.ItemPrice).ToString("N2") }
            };

            return orderCard;
        }

        private void UpdateTotalPrice()
        {
            decimal totalPriceValue = orderCollection.Sum(item => item.numberOfItem * item.ItemPrice);
            totalPrice.Text = "₱" + totalPriceValue.ToString("N2");
        }

        public void AddItem(OrderObject orderObject)
        {
            RepositoryFacade<StockObject> stockFacade = new RepositoryFacade<StockObject>(factory);
            StockObject stockObject = new StockObject
            {
                StockID = 0, // StockID is not being checked; a new StockID will be generated
                ProductID = orderObject.productId, // This is for reference in the method, not the Stock table
                Qty = orderObject.numberOfItem,
                QtyDamage = 0,
                Date = DateTime.Now.ToString(),
                Type = "add"
            };

            // Add the stock item using the facade (it will get a new StockID)
            stockFacade.Add(stockObject);

            // If the stock is successfully added and a new StockID is generated
            if (stockObject.StockID != 0)
            {
                AddToInventory(orderObject, stockObject.StockID); // Add to inventory using the new StockID
            }
        }


        public void AddToInventory(OrderObject orderObject, int StockID)
        {
            RepositoryFacade<InventoryObject> stockFacade = new RepositoryFacade<InventoryObject>(factory);
            InventoryObject inventoryObject = new InventoryObject();

            inventoryObject.SupplierID = orderObject.supplierID;
            inventoryObject.ProductID = orderObject.productId;
            inventoryObject.QtyReceived = orderObject.numberOfItem;
            inventoryObject.DateDelivery = orderObject.deliveryDate;
            inventoryObject.DateReceived = null;
            inventoryObject.StockID = StockID;
            inventoryObject.StatusID = StatusID;
            inventoryObject.Price = orderObject.ItemPrice;

            // Check if product has expiration date
            if (CbxProducts.SelectedItem is ProductItem selectedProduct && orderObject.productId == selectedProduct.ProductID)
            {
                int categoryID = orderFacade.GetProductCategoryID(selectedProduct.ProductID);

                // Set expirationDate to null if no expiration date is required for this product
                if (categoryID != 2) // Assuming 2 represents products with expiration dates
                {
                    inventoryObject.DateExpiration = null;
                }
                else
                {
                    inventoryObject.DateExpiration = orderObject.expirationDate; // Use the provided expiration date
                }
            }

            stockFacade.Add(inventoryObject);
        }
    }
}
