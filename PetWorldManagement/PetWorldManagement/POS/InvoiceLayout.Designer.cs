namespace PetWorldManagement.POS
{
    partial class InvoiceLayout
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
            this.lblsubTotal = new System.Windows.Forms.Label();
            this.qtylbl = new System.Windows.Forms.Label();
            this.ITpricelbl = new System.Windows.Forms.Label();
            this.prodNamelbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblsubTotal
            // 
            this.lblsubTotal.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubTotal.Location = new System.Drawing.Point(274, 21);
            this.lblsubTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsubTotal.Name = "lblsubTotal";
            this.lblsubTotal.Size = new System.Drawing.Size(54, 21);
            this.lblsubTotal.TabIndex = 29;
            this.lblsubTotal.Text = "label10";
            this.lblsubTotal.Visible = false;
            // 
            // qtylbl
            // 
            this.qtylbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtylbl.Location = new System.Drawing.Point(9, 21);
            this.qtylbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.qtylbl.Name = "qtylbl";
            this.qtylbl.Size = new System.Drawing.Size(41, 21);
            this.qtylbl.TabIndex = 28;
            this.qtylbl.Text = "label9";
            this.qtylbl.Visible = false;
            // 
            // ITpricelbl
            // 
            this.ITpricelbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ITpricelbl.Location = new System.Drawing.Point(212, 21);
            this.ITpricelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ITpricelbl.Name = "ITpricelbl";
            this.ITpricelbl.Size = new System.Drawing.Size(47, 21);
            this.ITpricelbl.TabIndex = 27;
            this.ITpricelbl.Text = "label8";
            this.ITpricelbl.Visible = false;
            // 
            // prodNamelbl
            // 
            this.prodNamelbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodNamelbl.Location = new System.Drawing.Point(64, 21);
            this.prodNamelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.prodNamelbl.Name = "prodNamelbl";
            this.prodNamelbl.Size = new System.Drawing.Size(143, 21);
            this.prodNamelbl.TabIndex = 26;
            this.prodNamelbl.Text = "label7";
            this.prodNamelbl.Visible = false;
            // 
            // InvoiceLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblsubTotal);
            this.Controls.Add(this.qtylbl);
            this.Controls.Add(this.ITpricelbl);
            this.Controls.Add(this.prodNamelbl);
            this.Name = "InvoiceLayout";
            this.Size = new System.Drawing.Size(337, 62);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblsubTotal;
        public System.Windows.Forms.Label qtylbl;
        public System.Windows.Forms.Label ITpricelbl;
        public System.Windows.Forms.Label prodNamelbl;
    }
}
