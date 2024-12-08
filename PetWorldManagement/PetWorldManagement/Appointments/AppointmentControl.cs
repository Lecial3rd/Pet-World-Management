using System;
using System.Windows.Forms;

namespace PetWorldManagement.Appointments
{
    public partial class AppointmentControl : UserControl
    {
        private bool isUpdatingQuantity = false; // Flag for quantity updates

        public AppointmentControl()
        {
            InitializeComponent();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        public void SetServiceName(string serviceName)
        {
            lblSName.Text = serviceName;
            lblSName.Visible = true; // Make sure the service name label is visible
        }

        public void SetQuantity(int quantity)
        {
            // Set the quantity directly without calculating the difference
            if (quantity < 1) quantity = 1; // Ensure minimum quantity is 1
            txtQuantity.Text = quantity.ToString();
            UpdateAmount(); // Update amount based on the new quantity
        }

        public void SetAmount(decimal amount)
        {
            lblamount.Text = amount.ToString("F2");
            lblamount.Visible = true; // Make sure the amount label is visible
        }

        public void UpdateQuantity(int change)
        {
            if (isUpdatingQuantity) return; // Prevent re-entrance

            try
            {
                isUpdatingQuantity = true; // Set the flag to true to prevent re-entrance
                int currentQty = int.Parse(txtQuantity.Text);
                currentQty += change; // Update quantity

                // Ensure quantity does not go below 1
                if (currentQty < 1)
                {
                    currentQty = 1;
                }

                txtQuantity.Text = currentQty.ToString(); // Update the text box with the new quantity
                UpdateAmount(); // Update the amount based on the new quantity
            }
            finally
            {
                isUpdatingQuantity = false; // Reset the flag after processing
            }
        }

        private void UpdateAmount()
        {
            int quantity = int.Parse(txtQuantity.Text);
            decimal price = GetServicePrice(lblSName.Text); // Implement this method to get the price
            lblamount.Text = (price * quantity).ToString("F2");
        }

        private decimal GetServicePrice(string serviceName)
        {
            // Implement logic to retrieve the price based on the service name
            // This could be a call to a repository or a static list of services
            return 50; // Placeholder for testing; replace with actual logic
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (isUpdatingQuantity) return; // Prevent re-entrance

            if (string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                return; // Ignore empty input
            }

            if (int.TryParse(txtQuantity.Text, out int quantity) && quantity > 0)
            {
                UpdateAmount(); // Update amount based on new quantity
            }
            else
            {
                MessageBox.Show("Invalid Quantity entered! Please enter a number greater than 0.");
                txtQuantity.Text = "1"; // Reset to default
            }
        }
    }
}