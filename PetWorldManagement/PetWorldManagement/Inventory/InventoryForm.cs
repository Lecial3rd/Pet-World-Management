using System;
using System.Data;
using System.Windows.Forms;
using PetWorldManagement.Inventory;
using PetWorldManagement.Supplier.PurchaseOrder;

namespace PetWorldManagement.Inventory
{
    public partial class InventoryForm : Form
    {
        public static bool isSummed = false;
        private readonly RepositoryFacade<InventoryObject> inventoryFacade;
        private readonly IRepositoryFactory factory;
        private readonly Dashboard dashboard;
        public InventoryForm(Dashboard dashboard)
        {
            factory = new RepositoryFactory();
            inventoryFacade = new RepositoryFacade<InventoryObject>(factory);
            InitializeComponent();
            loadInventory();
            this.dashboard = dashboard;
        }

        private void loadInventory()
        {
            RepositoryFacade<OrderObject> newFacade = new RepositoryFacade<OrderObject>(factory);
            DataTable inventoryData = newFacade.GetInventoryProduct();

            inventory_flowLayout.Controls.Clear();

            foreach (DataRow row in inventoryData.Rows)
            {
                InventoryUserControl userControl = new InventoryUserControl();

                // Set the data on the user control
                userControl.txt_Product.Text = row["Product"].ToString();
                userControl.txtqty_left.Text = row["TotalAvailableQuantity"].ToString();

                // Subscribe to the button click event in the user control
                userControl.btn_View.Click += (sender, e) => Btn_View_Click(sender, e, row);

                // Add user control to the flow layout panel
                inventory_flowLayout.Controls.Add(userControl);
            }
        }

        private void Btn_View_Click(object sender, EventArgs e, DataRow row)
        {
            string productName = row["Product"].ToString();
            string availableQuantity = row["TotalAvailableQuantity"].ToString();

            // The ProductID is hidden in the user control but passed to the details form
            int productID = Convert.ToInt32(row["ProductID"]);
            int totalqty = Convert.ToInt32(row["TotalQuantity"]);
            int damage = Convert.ToInt32(row["DamageQuantity"]);
            OpenProductDetailsForm(productName, availableQuantity, productID, totalqty, damage);
        }

        private void OpenProductDetailsForm(string productName, string availableQuantity, int productID, int totalqty, int damage)
        {
            StockForm stockForm = new StockForm(productID, productName, Convert.ToInt32(availableQuantity), Convert.ToInt32(totalqty), Convert.ToInt32(damage));
            stockForm.Show();

        }


        private void btnViewLog_Click(object sender, EventArgs e)
        {
            dashboard.LoadForm(new InventoryLogForm());
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.ToLower();

            foreach (Control control in inventory_flowLayout.Controls)
            {
                if (control is InventoryUserControl userControl)
                {
                    bool isVisible = userControl.txt_Product.Text.ToLower().Contains(searchTerm);
                    userControl.Visible = isVisible;
                }
            }
        }
    }
}
