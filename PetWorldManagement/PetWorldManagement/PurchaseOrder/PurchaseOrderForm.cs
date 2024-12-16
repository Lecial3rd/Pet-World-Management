using PetWorldManagement.Inventory;
using PetWorldManagement.Supplier.PurchaseOrder;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PetWorldManagement.Supplier
{
    public partial class PurchaseOrderForm : Form
    {
        private readonly RepositoryFacade<SupplierObject> supplierFacade;
        private readonly IRepositoryFactory factory;

        public PurchaseOrderForm()
        {
            InitializeComponent();

            factory = new RepositoryFactory();
            supplierFacade = new RepositoryFacade<SupplierObject>(factory);

            displaySupplier();
        }

        private void displaySupplier()
        {
            InventoryForm.isSummed = false;
            DataTable suppliers = supplierFacade.GetAll();
            DisplaySupplierCards(suppliers);
        }

        private void DisplaySupplierCards(DataTable suppliers)
        {
            // Clear existing controls in the FlowLayoutPanel
            supplier_order_flowLayout.Controls.Clear();

            // Loop through the DataTable rows
            foreach (DataRow row in suppliers.Rows)
            {
                var supplyOrderCard = CreateSupplyOrderCard(row);
                supplier_order_flowLayout.Controls.Add(supplyOrderCard);
            }
        }

        private SupplyOrderCard CreateSupplyOrderCard(DataRow row)
        {
            var supplyOrderCard = new SupplyOrderCard();

            var supplierLabel = (Label)supplyOrderCard.Controls.Find("label_supplierName", true).FirstOrDefault();
            var purchaseButton = (Button)supplyOrderCard.Controls.Find("purchase_btn", true).FirstOrDefault();

            if (supplierLabel != null)
            {
                supplierLabel.Text = row["Name"].ToString();
            }

            supplyOrderCard.Tag = row["SupplierID"];
            int supplierId = (int)supplyOrderCard.Tag;

            if (purchaseButton != null)
            {
                purchaseButton.Click += (sender, e) =>
                {
                    OrderForm orderForm = new OrderForm(supplierId);
                    orderForm.ShowDialog();
                };
            }

            return supplyOrderCard;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;
            DataTable searchResults = supplierFacade.Search(keyword);
            DisplaySupplierCards(searchResults);
        }
    }
}