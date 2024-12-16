namespace PetWorldManagement.Supplier.PurchaseOrder
{
    partial class OrderForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Delivery_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.CbxProducts = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Expiration_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.expirationDatelbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayout_purchaseOrder = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.totalPrice = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtSupplierName);
            this.panel1.Controls.Add(this.btnOrder);
            this.panel1.Controls.Add(this.txtStatus);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtQty);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Delivery_dateTimePicker);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.CbxProducts);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Expiration_dateTimePicker);
            this.panel1.Controls.Add(this.expirationDatelbl);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 469);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(4, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Supplier";
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Enabled = false;
            this.txtSupplierName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtSupplierName.Location = new System.Drawing.Point(11, 82);
            this.txtSupplierName.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.ReadOnly = true;
            this.txtSupplierName.Size = new System.Drawing.Size(314, 26);
            this.txtSupplierName.TabIndex = 3;
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.SlateBlue;
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOrder.Location = new System.Drawing.Point(9, 407);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(313, 30);
            this.btnOrder.TabIndex = 14;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Enabled = false;
            this.txtStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtStatus.Location = new System.Drawing.Point(9, 240);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(314, 26);
            this.txtStatus.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(5, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Status";
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtQty.Location = new System.Drawing.Point(9, 188);
            this.txtQty.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(314, 26);
            this.txtQty.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(5, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Number of Items";
            // 
            // Delivery_dateTimePicker
            // 
            this.Delivery_dateTimePicker.CalendarForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Delivery_dateTimePicker.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.Delivery_dateTimePicker.CustomFormat = "MMMM dd, yyyy";
            this.Delivery_dateTimePicker.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delivery_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Delivery_dateTimePicker.Location = new System.Drawing.Point(9, 293);
            this.Delivery_dateTimePicker.Name = "Delivery_dateTimePicker";
            this.Delivery_dateTimePicker.Size = new System.Drawing.Size(314, 26);
            this.Delivery_dateTimePicker.TabIndex = 9;
            this.Delivery_dateTimePicker.ValueChanged += new System.EventHandler(this.Delivery_dateTimePicker_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(5, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Delivery Date";
            // 
            // CbxProducts
            // 
            this.CbxProducts.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxProducts.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CbxProducts.FormattingEnabled = true;
            this.CbxProducts.Location = new System.Drawing.Point(8, 136);
            this.CbxProducts.Name = "CbxProducts";
            this.CbxProducts.Size = new System.Drawing.Size(314, 26);
            this.CbxProducts.TabIndex = 7;
            this.CbxProducts.SelectedIndexChanged += new System.EventHandler(this.CbxProducts_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(4, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Select Product";
            // 
            // Expiration_dateTimePicker
            // 
            this.Expiration_dateTimePicker.CalendarForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Expiration_dateTimePicker.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.Expiration_dateTimePicker.CustomFormat = "MMMM dd, yyyy";
            this.Expiration_dateTimePicker.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Expiration_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Expiration_dateTimePicker.Location = new System.Drawing.Point(9, 346);
            this.Expiration_dateTimePicker.Name = "Expiration_dateTimePicker";
            this.Expiration_dateTimePicker.Size = new System.Drawing.Size(314, 26);
            this.Expiration_dateTimePicker.TabIndex = 5;
            this.Expiration_dateTimePicker.Visible = false;
            // 
            // expirationDatelbl
            // 
            this.expirationDatelbl.AutoSize = true;
            this.expirationDatelbl.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expirationDatelbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.expirationDatelbl.Location = new System.Drawing.Point(5, 322);
            this.expirationDatelbl.Name = "expirationDatelbl";
            this.expirationDatelbl.Size = new System.Drawing.Size(120, 18);
            this.expirationDatelbl.TabIndex = 4;
            this.expirationDatelbl.Text = "Expiration Date";
            this.expirationDatelbl.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateBlue;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(334, 34);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(35, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Purchase Order Form";
            // 
            // flowLayout_purchaseOrder
            // 
            this.flowLayout_purchaseOrder.AutoScroll = true;
            this.flowLayout_purchaseOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayout_purchaseOrder.Location = new System.Drawing.Point(447, 47);
            this.flowLayout_purchaseOrder.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayout_purchaseOrder.Name = "flowLayout_purchaseOrder";
            this.flowLayout_purchaseOrder.Size = new System.Drawing.Size(335, 400);
            this.flowLayout_purchaseOrder.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SlateBlue;
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(447, 13);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(335, 35);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(8, 8);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(35, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Purchase Order";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.totalPrice);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Location = new System.Drawing.Point(447, 447);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(335, 35);
            this.panel4.TabIndex = 3;
            // 
            // totalPrice
            // 
            this.totalPrice.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPrice.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.totalPrice.Location = new System.Drawing.Point(222, 7);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(104, 20);
            this.totalPrice.TabIndex = 3;
            this.totalPrice.Text = "₱0";
            this.totalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(8, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 18);
            this.label9.TabIndex = 2;
            this.label9.Text = "Total:";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 494);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.flowLayout_purchaseOrder);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label expirationDatelbl;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker Delivery_dateTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CbxProducts;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.FlowLayoutPanel flowLayout_purchaseOrder;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label totalPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker Expiration_dateTimePicker;
    }
}