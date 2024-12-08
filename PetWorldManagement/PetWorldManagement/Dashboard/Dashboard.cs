using PetWorldManagement.Appointments;
using PetWorldManagement.Inventory;
using PetWorldManagement.Supplier;
using PetWorldManagement.Supplier.OrderList;
using System;
using System.Windows.Forms;

namespace PetWorldManagement
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        public void LoadForm(object formObj)
        {
            if (this.base_panel.Controls.Count > 0)
            {
                this.base_panel.Controls.RemoveAt(0);
            }

            Form form = formObj as Form;
            if (form != null)
            {
                form.TopLevel = false;
                form.Dock = DockStyle.Fill;
                this.base_panel.Controls.Add(form);
                this.base_panel.Tag = form;
                form.Show();
            }
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {

        }

        private void appointmentList_btn_Click(object sender, EventArgs e)
        {
            LoadForm(new AppointmentPageForm(this));
        }

        private void appoimentManagement_btn_Click(object sender, EventArgs e)
        {

        }

        private void productList_btn_Click(object sender, EventArgs e)
        {
            LoadForm(new ProductPageForm(this));
        }

        private void productCategory_btn_Click(object sender, EventArgs e)
        {
            LoadForm(new CategoryPageForm());
        }

        private void supplierList_btn_Click(object sender, EventArgs e)
        {
            LoadForm(new SupplierPageForm());
        }

        private void orderList_btn_Click(object sender, EventArgs e)
        {
            LoadForm(new OrderListForm());
        }

        private void purchaseOrder_btn_Click(object sender, EventArgs e)
        {
            LoadForm(new PurchaseOrderForm());
        }

        private void Inventory_btn_Click(object sender, EventArgs e)
        {
            LoadForm(new InventoryForm(this));
        }

        private void Sales_btn_Click(object sender, EventArgs e)
        {

        }

        private void Invoice_btn_Click(object sender, EventArgs e)
        {

        }

        private void btn_Staff_Click(object sender, EventArgs e)
        {

        }
    }
}