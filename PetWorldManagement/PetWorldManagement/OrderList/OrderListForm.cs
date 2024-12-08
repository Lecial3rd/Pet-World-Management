using PetWorldManagement.Inventory;
using PetWorldManagement.Stock;
using PetWorldManagement.Supplier.PurchaseOrder;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace PetWorldManagement.Supplier.OrderList
{
    public partial class OrderListForm : Form
    {
        private readonly RepositoryFacade<InventoryObject> inventoryFacade;
        private readonly IRepositoryFactory factory;
        public OrderListForm()
        {
            InitializeComponent();
            factory = new RepositoryFactory();
            inventoryFacade = new RepositoryFacade<InventoryObject>(factory);
            LoadOrderList();
            
    }

        private void LoadOrderList()
        {
            DataTable inventoryData = GetInventoryData();
            DataTable statusData = GetStatusData();

            ConfigureDataGridView(statusData);

            dataGridViewOrderList.DataSource = inventoryData;
            dataGridViewOrderList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewOrderList.CellValueChanged += (sender, e) =>
            {
                HandleCellValueChanged(e);
            };
        }

        private DataTable GetInventoryData()
        {
            return inventoryFacade.GetAll();
        }

        private DataTable GetStatusData()
        {
            RepositoryFacade<OrderObject> orderFacade = new RepositoryFacade<OrderObject>(factory);
            return orderFacade.GetStatuses();
        }

        private void ConfigureDataGridView(DataTable statusData)
        {
            dataGridViewOrderList.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ID",
                DataPropertyName = "ID",
                HeaderText = "ID",
                Visible = false
            });

            dataGridViewOrderList.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "StockID",
                DataPropertyName = "StockID",
                HeaderText = "StockID",
                Visible = false
            });

            dataGridViewOrderList.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "SupplierID",
                DataPropertyName = "SupplierID",
                HeaderText = "SupplierID",
                Visible = false
            });

            AddColumn("Supplier", "Supplier", DataGridViewAutoSizeColumnMode.Fill);
            AddColumn("Delivery Date", "Delivery Date", DataGridViewAutoSizeColumnMode.Fill);
            AddColumn("Expiration Date", "Expiration Date", DataGridViewAutoSizeColumnMode.Fill);
            AddColumn("ProductID", "Product ID", DataGridViewAutoSizeColumnMode.Fill);
            AddColumn("Product", "Product", DataGridViewAutoSizeColumnMode.Fill);
            AddColumn("Quantity", "Quantity", DataGridViewAutoSizeColumnMode.Fill);
            AddColumn("Price", "Price", DataGridViewAutoSizeColumnMode.Fill);
            AddColumn("TotalPrice", "Total Price", DataGridViewAutoSizeColumnMode.Fill);
            DataGridViewComboBoxColumn statusColumn = new DataGridViewComboBoxColumn
            {
                Name = "Status",
                HeaderText = "Status",
                DataPropertyName = "StatusID",
                DataSource = statusData,
                DisplayMember = "Status",
                ValueMember = "StatusID",
                ValueType = typeof(int),
                DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };

            dataGridViewOrderList.Columns.Add(statusColumn);
            statusColumn.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Regular);
        }

        private void AddColumn(string columnName, string headerText, DataGridViewAutoSizeColumnMode sizeMode)
        {
            dataGridViewOrderList.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = columnName,
                DataPropertyName = columnName,
                HeaderText = headerText,
                AutoSizeMode = sizeMode
            });
        }

        private void HandleCellValueChanged(DataGridViewCellEventArgs e)
        {
            // When the Status column changes, show the row details
            if (dataGridViewOrderList.Columns[e.ColumnIndex].Name == "Status")
            {
                var currentRow = dataGridViewOrderList.Rows[e.RowIndex];
                if (currentRow != null)
                {
                    InventoryObject inventory = new InventoryObject
                    {
                        ID = Convert.ToInt32(currentRow.Cells["ID"].Value),
                        SupplierID = Convert.ToInt32(currentRow.Cells["SupplierID"].Value),
                        ProductID = Convert.ToInt32(currentRow.Cells["ProductID"].Value), // ProductID
                        QtyReceived = Convert.ToInt32(currentRow.Cells["Quantity"].Value),
                        DateDelivery = currentRow.Cells["Delivery Date"].Value?.ToString(),
                        DateReceived = DateTime.Now.ToString(),
                        DateExpiration = currentRow.Cells["Expiration Date"].Value?.ToString(),
                        StockID = Convert.ToInt32(currentRow.Cells["StockID"].Value),
                        StatusID = Convert.ToInt32(currentRow.Cells["Status"].Value),
                        Price = Convert.ToDecimal(currentRow.Cells["Price"].Value),
                        ProductName = currentRow.Cells["Product"].Value?.ToString(),
                        Supplier = currentRow.Cells["Supplier"].Value?.ToString()
                    };

                    inventoryFacade.Update(inventory);

                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable searchResults = inventoryFacade.Search(txtSearch.Text);
            dataGridViewOrderList.DataSource = searchResults;
            dataGridViewOrderList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
