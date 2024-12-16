namespace PetWorldManagement.POS
{
    partial class ProductItem
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
            lblNotAvailable = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.btnAddtoCart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNotAvailable
            // 
            lblNotAvailable.AutoSize = true;
            lblNotAvailable.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNotAvailable.ForeColor = System.Drawing.Color.IndianRed;
            lblNotAvailable.Location = new System.Drawing.Point(24, 70);
            lblNotAvailable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblNotAvailable.Name = "lblNotAvailable";
            lblNotAvailable.Size = new System.Drawing.Size(104, 18);
            lblNotAvailable.TabIndex = 19;
            lblNotAvailable.Text = "Not Available";
            lblNotAvailable.Visible = false;
            //
            // Price
            // 
            this.Price.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.ForeColor = System.Drawing.Color.SlateBlue;
            this.Price.Location = new System.Drawing.Point(0, 183);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(142, 39);
            this.Price.TabIndex = 18;
            this.Price.Text = "P 159.00";
            this.Price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddtoCart
            // 
            this.btnAddtoCart.BackColor = System.Drawing.Color.SlateBlue;
            this.btnAddtoCart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddtoCart.FlatAppearance.BorderSize = 0;
            this.btnAddtoCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddtoCart.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddtoCart.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddtoCart.Location = new System.Drawing.Point(0, 222);
            this.btnAddtoCart.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddtoCart.Name = "btnAddtoCart";
            this.btnAddtoCart.Size = new System.Drawing.Size(145, 32);
            this.btnAddtoCart.TabIndex = 17;
            this.btnAddtoCart.Text = "Order";
            this.btnAddtoCart.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(3, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 36);
            this.label1.TabIndex = 16;
            this.label1.Text = "Doggo ropey slippery toy";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // ProductItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(lblNotAvailable);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.btnAddtoCart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ProductItem";
            this.Size = new System.Drawing.Size(145, 254);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Price;
        public System.Windows.Forms.Button btnAddtoCart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public static System.Windows.Forms.Label lblNotAvailable;
    }
}
