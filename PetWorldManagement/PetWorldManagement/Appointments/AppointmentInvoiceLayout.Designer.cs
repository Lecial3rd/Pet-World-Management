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
            this.lblTotalAmount.BackColor = System.Drawing.SystemColors.Control;
            this.lblTotalAmount.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTotalAmount.Location = new System.Drawing.Point(236, 6);
            this.lblTotalAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(54, 21);
            this.lblTotalAmount.TabIndex = 33;
            this.lblTotalAmount.Text = "amount";
            this.lblTotalAmount.Visible = false;
            // 
            // lblQty
            // 
            this.lblQty.BackColor = System.Drawing.SystemColors.Control;
            this.lblQty.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblQty.Location = new System.Drawing.Point(18, 6);
            this.lblQty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(41, 21);
            this.lblQty.TabIndex = 32;
            this.lblQty.Text = "quantity";
            this.lblQty.Visible = false;
            // 
            // lblPrice
            // 
            this.lblPrice.BackColor = System.Drawing.SystemColors.Control;
            this.lblPrice.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPrice.Location = new System.Drawing.Point(168, 6);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(64, 21);
            this.lblPrice.TabIndex = 31;
            this.lblPrice.Text = "price";
            this.lblPrice.Visible = false;
            // 
            // lblServiceName
            // 
            this.lblServiceName.BackColor = System.Drawing.SystemColors.Control;
            this.lblServiceName.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblServiceName.Location = new System.Drawing.Point(64, 6);
            this.lblServiceName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblServiceName.Name = "lblServiceName";
            this.lblServiceName.Size = new System.Drawing.Size(100, 21);
            this.lblServiceName.TabIndex = 30;
            this.lblServiceName.Text = "name";
            this.lblServiceName.Visible = false;
            // 
            // AppointmentInvoiceLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblServiceName);
            this.Name = "AppointmentInvoiceLayout";
            this.Size = new System.Drawing.Size(309, 32);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblTotalAmount;
        public System.Windows.Forms.Label lblQty;
        public System.Windows.Forms.Label lblPrice;
        public System.Windows.Forms.Label lblServiceName;
    }
}
