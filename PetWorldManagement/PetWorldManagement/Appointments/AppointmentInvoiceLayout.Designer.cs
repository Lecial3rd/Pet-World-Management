namespace PetWorldManagement.Appointments
{
    partial class AppointmentInvoiceLayout
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblServiceName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(365, 26);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(72, 26);
            this.lblTotalAmount.TabIndex = 29;
            this.lblTotalAmount.Text = "amount";
            this.lblTotalAmount.Visible = false;
            // 
            // lblQty
            // 
            this.lblQty.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(12, 26);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(55, 26);
            this.lblQty.TabIndex = 28;
            this.lblQty.Text = "quantity";
            this.lblQty.Visible = false;
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(283, 26);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(63, 26);
            this.lblPrice.TabIndex = 27;
            this.lblPrice.Text = "price";
            this.lblPrice.Visible = false;
            // 
            // lblServiceName
            // 
            this.lblServiceName.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceName.Location = new System.Drawing.Point(85, 26);
            this.lblServiceName.Name = "lblServiceName";
            this.lblServiceName.Size = new System.Drawing.Size(191, 26);
            this.lblServiceName.TabIndex = 26;
            this.lblServiceName.Text = "name";
            this.lblServiceName.Visible = false;
            // 
            // AppointmentInvoiceLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblServiceName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AppointmentInvoiceLayout";
            this.Size = new System.Drawing.Size(449, 76);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblTotalAmount;
        public System.Windows.Forms.Label lblQty;
        public System.Windows.Forms.Label lblPrice;
        public System.Windows.Forms.Label lblServiceName;
    }
}
