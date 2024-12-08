namespace PetWorldManagement.Inventory
{
    partial class InventoryUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryUserControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_Product = new System.Windows.Forms.Label();
            this.txtqty_left = new System.Windows.Forms.Label();
            this.btn_View = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(578, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 36);
            this.panel1.TabIndex = 8;
            // 
            // txt_Product
            // 
            this.txt_Product.BackColor = System.Drawing.Color.Transparent;
            this.txt_Product.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Product.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_Product.Location = new System.Drawing.Point(10, 6);
            this.txt_Product.Name = "txt_Product";
            this.txt_Product.Size = new System.Drawing.Size(562, 23);
            this.txt_Product.TabIndex = 6;
            this.txt_Product.Text = "Product";
            this.txt_Product.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtqty_left
            // 
            this.txtqty_left.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqty_left.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtqty_left.Location = new System.Drawing.Point(656, 6);
            this.txtqty_left.Name = "txtqty_left";
            this.txtqty_left.Size = new System.Drawing.Size(76, 23);
            this.txtqty_left.TabIndex = 9;
            this.txtqty_left.Text = "Qty";
            this.txtqty_left.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_View
            // 
            this.btn_View.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_View.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_View.FlatAppearance.BorderSize = 0;
            this.btn_View.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_View.Image = ((System.Drawing.Image)(resources.GetObject("btn_View.Image")));
            this.btn_View.Location = new System.Drawing.Point(787, 3);
            this.btn_View.Name = "btn_View";
            this.btn_View.Size = new System.Drawing.Size(41, 29);
            this.btn_View.TabIndex = 10;
            this.btn_View.UseVisualStyleBackColor = false;
            // 
            // InventoryUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btn_View);
            this.Controls.Add(this.txtqty_left);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_Product);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "InventoryUserControl";
            this.Size = new System.Drawing.Size(831, 36);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label txt_Product;
        public System.Windows.Forms.Label txtqty_left;
        public System.Windows.Forms.Button btn_View;
    }
}
