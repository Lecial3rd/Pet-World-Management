using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetWorldManagement.Repository;

namespace PetWorldManagement.Overview
{
    public partial class OverviewForm : Form
    {
        private readonly OverviewFormRepository repository;
        public OverviewForm()
        {
            repository = new OverviewFormRepository();
            InitializeComponent();
            LoadOverview();
        }

        private void LoadOverview()
        {
            lblSupplier.Text = repository.GetSupplierCount().ToString();
            lblProduct.Text = repository.GetProductCount().ToString();
            lblService.Text = repository.GetServiceCount().ToString();
            lblInvoice.Text = repository.GetInvoiceCount().ToString();
            lblPurchased.Text = "₱"+repository.GetTotalPurchased().ToString("N2");
            lblRevenue.Text = "₱"+repository.GetTotalRevenue().ToString("N2");
            lblIncome.Text = "₱" + repository.GetIncome().ToString("N2");
        }
    }
}
