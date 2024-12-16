namespace PetWorldManagement.Supplier
{
    partial class SupplyOrderCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplyOrderCard));
            this.label_supplierName = new System.Windows.Forms.Label();
            this.purchase_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label_supplierName
            // 
            this.label_supplierName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_supplierName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_supplierName.Location = new System.Drawing.Point(18, 6);
            this.label_supplierName.Name = "label_supplierName";
            this.label_supplierName.Size = new System.Drawing.Size(598, 23);
            this.label_supplierName.TabIndex = 3;
            this.label_supplierName.Text = "Supplier Company";
            // 
            // purchase_btn
            // 
            this.purchase_btn.BackColor = System.Drawing.Color.SlateBlue;
            this.purchase_btn.FlatAppearance.BorderSize = 0;
            this.purchase_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.purchase_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchase_btn.Image = ((System.Drawing.Image)(resources.GetObject("purchase_btn.Image")));
            this.purchase_btn.Location = new System.Drawing.Point(785, 3);
            this.purchase_btn.Name = "purchase_btn";
            this.purchase_btn.Size = new System.Drawing.Size(42, 27);
            this.purchase_btn.TabIndex = 4;
            this.purchase_btn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(766, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 36);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(831, 1);
            this.panel2.TabIndex = 6;
            // 
            // SupplyOrderCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.purchase_btn);
            this.Controls.Add(this.label_supplierName);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "SupplyOrderCard";
            this.Size = new System.Drawing.Size(831, 36);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_supplierName;
        private System.Windows.Forms.Button purchase_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
