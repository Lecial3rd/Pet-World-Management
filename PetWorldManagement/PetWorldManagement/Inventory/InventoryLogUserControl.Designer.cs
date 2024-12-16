namespace PetWorldManagement.Inventory
{
    partial class InventoryLogUserControl
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
            this.labelQty = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelProduct = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelQty
            // 
            this.labelQty.BackColor = System.Drawing.SystemColors.Control;
            this.labelQty.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQty.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelQty.Location = new System.Drawing.Point(5, 14);
            this.labelQty.Name = "labelQty";
            this.labelQty.Size = new System.Drawing.Size(85, 23);
            this.labelQty.TabIndex = 3;
            this.labelQty.Text = "100";
            this.labelQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(96, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Units of ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelProduct
            // 
            this.labelProduct.BackColor = System.Drawing.SystemColors.Control;
            this.labelProduct.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProduct.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelProduct.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labelProduct.Location = new System.Drawing.Point(186, 13);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(271, 23);
            this.labelProduct.TabIndex = 5;
            this.labelProduct.Text = "ProductName";
            this.labelProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(463, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "were added to the inventory on";
            // 
            // labelDateTime
            // 
            this.labelDateTime.BackColor = System.Drawing.SystemColors.Control;
            this.labelDateTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateTime.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelDateTime.Location = new System.Drawing.Point(688, 12);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(124, 23);
            this.labelDateTime.TabIndex = 7;
            this.labelDateTime.Text = "Date Received";
            this.labelDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InventoryLogUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelQty);
            this.Name = "InventoryLogUserControl";
            this.Size = new System.Drawing.Size(815, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label labelQty;
        public System.Windows.Forms.Label labelProduct;
        public System.Windows.Forms.Label labelDateTime;
    }
}
