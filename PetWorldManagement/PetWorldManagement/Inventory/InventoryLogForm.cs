using PetWorldManagement.Supplier.PurchaseOrder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetWorldManagement.Inventory
{
    public partial class InventoryLogForm : Form
    {
        private readonly RepositoryFacade<InventoryObject> InventoryFacade;
        private readonly IRepositoryFactory factory;

        public InventoryLogForm()
        {
            factory = new RepositoryFactory();
            InventoryFacade = new RepositoryFacade<InventoryObject>(factory);
            InitializeComponent();
            loadInventoryLog();
        }

        public DataTable getInventory()
        {
            InventoryForm.isSummed = true;
            return InventoryFacade.GetAll();
        }

        public void loadInventoryLog()
        {
            
            DataTable InventoryFacade = getInventory();

            InventoryLog_flowLayout.Controls.Clear();

            foreach (DataRow row in InventoryFacade.Rows)
            {
                InventoryLogUserControl userControl = new InventoryLogUserControl();

                // Set the data on the user control
                userControl.labelQty.Text = row["Quantity"].ToString();
                userControl.labelProduct.Text = row["Product"].ToString();
                userControl.labelDateTime.Text = row["Date Received"].ToString();


                // Add user control to the flow layout panel
                InventoryLog_flowLayout.Controls.Add(userControl);
            }
            InventoryForm.isSummed = false;
        }
    }
}
