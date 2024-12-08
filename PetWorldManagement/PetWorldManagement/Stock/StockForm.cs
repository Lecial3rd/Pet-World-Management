using PetWorldManagement.Inventory;
using PetWorldManagement.Stock;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetWorldManagement
{
    public partial class StockForm : Form
    {
        private int Id, qty, total,damage;
        private string name;

        public static bool state = false;
        private readonly RepositoryFacade<StockObject> stockFacade;
        private readonly IRepositoryFactory factory;

        public StockForm(int ID, string Name, int qty, int total, int damage)
        {
            factory = new RepositoryFactory();
            stockFacade = new RepositoryFacade<StockObject>(factory);
            InitializeComponent();
            this.Id = ID;
            this.name = Name;
            this.qty = qty;
            this.total = total;
            this.damage = damage;
            loadProductStock();
        }

        public void loadProductStock()
        {
            txtProductName.Text = name;
            txtQty.Text = total.ToString();
            txtAvailable.Text = qty.ToString();
            txtDamage.Text = damage.ToString();
        }

        private void btnUpdateStock_Click(object sender, EventArgs e)
        {
            state = true;

            StockObject stock = new StockObject();
            stock.ProductID = Id;
            stock.QtyDamage = Convert.ToInt32(txtNewDamage.Text);
            stockFacade.Update(stock);

            txtNewDamage.Text = "";

            state = false;
        }
    }
}
