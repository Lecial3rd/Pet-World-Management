namespace PetWorldManagement.POS
{
    partial class ProductControl
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
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnMinusProduct = new System.Windows.Forms.Button();
            this.btnAddQuantity = new System.Windows.Forms.Button();
            this.lblprice = new System.Windows.Forms.Label();
            this.lblPName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(275, 11);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.ReadOnly = true;
            this.txtQuantity.Size = new System.Drawing.Size(18, 20);
            this.txtQuantity.TabIndex = 29;
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // btnRemove
            // 
            this.btnRemove.AutoSize = true;
            this.btnRemove.Location = new System.Drawing.Point(319, 9);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(24, 23);
            this.btnRemove.TabIndex = 28;
            this.btnRemove.Text = "X";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Visible = false;
            // 
            // btnMinusProduct
            // 
            this.btnMinusProduct.AutoSize = true;
            this.btnMinusProduct.Location = new System.Drawing.Point(253, 9);
            this.btnMinusProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinusProduct.Name = "btnMinusProduct";
            this.btnMinusProduct.Size = new System.Drawing.Size(21, 23);
            this.btnMinusProduct.TabIndex = 27;
            this.btnMinusProduct.Text = "-";
            this.btnMinusProduct.UseVisualStyleBackColor = true;
            this.btnMinusProduct.Visible = false;
            // 
            // btnAddQuantity
            // 
            this.btnAddQuantity.AutoSize = true;
            this.btnAddQuantity.Location = new System.Drawing.Point(294, 9);
            this.btnAddQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddQuantity.Name = "btnAddQuantity";
            this.btnAddQuantity.Size = new System.Drawing.Size(23, 23);
            this.btnAddQuantity.TabIndex = 26;
            this.btnAddQuantity.Text = "+";
            this.btnAddQuantity.UseVisualStyleBackColor = true;
            this.btnAddQuantity.Visible = false;
            // 
            // lblprice
            // 
            this.lblprice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.Location = new System.Drawing.Point(164, 9);
            this.lblprice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(85, 19);
            this.lblprice.TabIndex = 25;
            this.lblprice.Text = "price";
            this.lblprice.Visible = false;
            // 
            // lblPName
            // 
            this.lblPName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPName.Location = new System.Drawing.Point(7, 9);
            this.lblPName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPName.Name = "lblPName";
            this.lblPName.Size = new System.Drawing.Size(153, 19);
            this.lblPName.TabIndex = 24;
            this.lblPName.Text = "productname";
            this.lblPName.Visible = false;
            // 
            // ProductControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnMinusProduct);
            this.Controls.Add(this.btnAddQuantity);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.lblPName);
            this.Name = "ProductControl";
            this.Size = new System.Drawing.Size(350, 40);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtQuantity;
        public System.Windows.Forms.Button btnRemove;
        public System.Windows.Forms.Button btnMinusProduct;
        public System.Windows.Forms.Button btnAddQuantity;
        public System.Windows.Forms.Label lblprice;
        public System.Windows.Forms.Label lblPName;
    }
}
