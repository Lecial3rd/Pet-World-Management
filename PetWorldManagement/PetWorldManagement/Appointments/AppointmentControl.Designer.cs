namespace PetWorldManagement.Appointments
{
    partial class AppointmentControl
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
            this.btnMinusQuantity = new System.Windows.Forms.Button();
            this.btnAddQuantity = new System.Windows.Forms.Button();
            this.lblamount = new System.Windows.Forms.Label();
            this.lblSName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(243, 11);
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
            this.btnRemove.Location = new System.Drawing.Point(286, 9);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(24, 23);
            this.btnRemove.TabIndex = 28;
            this.btnRemove.Text = "X";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnMinusQuantity
            // 
            this.btnMinusQuantity.AutoSize = true;
            this.btnMinusQuantity.Location = new System.Drawing.Point(220, 9);
            this.btnMinusQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinusQuantity.Name = "btnMinusQuantity";
            this.btnMinusQuantity.Size = new System.Drawing.Size(21, 23);
            this.btnMinusQuantity.TabIndex = 27;
            this.btnMinusQuantity.Text = "-";
            this.btnMinusQuantity.UseVisualStyleBackColor = true;
            // 
            // btnAddQuantity
            // 
            this.btnAddQuantity.AutoSize = true;
            this.btnAddQuantity.Location = new System.Drawing.Point(262, 9);
            this.btnAddQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddQuantity.Name = "btnAddQuantity";
            this.btnAddQuantity.Size = new System.Drawing.Size(23, 23);
            this.btnAddQuantity.TabIndex = 26;
            this.btnAddQuantity.Text = "+";
            this.btnAddQuantity.UseVisualStyleBackColor = true;
            // 
            // lblamount
            // 
            this.lblamount.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblamount.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblamount.Location = new System.Drawing.Point(131, 9);
            this.lblamount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblamount.Name = "lblamount";
            this.lblamount.Size = new System.Drawing.Size(85, 19);
            this.lblamount.TabIndex = 25;
            this.lblamount.Text = "amount";
            this.lblamount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSName
            // 
            this.lblSName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSName.Location = new System.Drawing.Point(7, 9);
            this.lblSName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSName.Name = "lblSName";
            this.lblSName.Size = new System.Drawing.Size(120, 19);
            this.lblSName.TabIndex = 24;
            this.lblSName.Text = "servicename";
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPrice.Location = new System.Drawing.Point(344, 11);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(85, 19);
            this.lblPrice.TabIndex = 30;
            this.lblPrice.Text = "amount";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AppointmentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnMinusQuantity);
            this.Controls.Add(this.btnAddQuantity);
            this.Controls.Add(this.lblamount);
            this.Controls.Add(this.lblSName);
            this.Name = "AppointmentControl";
            this.Size = new System.Drawing.Size(320, 40);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtQuantity;
        public System.Windows.Forms.Button btnRemove;
        public System.Windows.Forms.Button btnMinusQuantity;
        public System.Windows.Forms.Button btnAddQuantity;
        public System.Windows.Forms.Label lblamount;
        public System.Windows.Forms.Label lblSName;
        public System.Windows.Forms.Label lblPrice;
    }
}
