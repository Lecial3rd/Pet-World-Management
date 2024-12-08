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
            this.SuspendLayout();
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(329, 14);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.ReadOnly = true;
            this.txtQuantity.Size = new System.Drawing.Size(23, 22);
            this.txtQuantity.TabIndex = 29;
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // btnRemove
            // 
            this.btnRemove.AutoSize = true;
            this.btnRemove.Location = new System.Drawing.Point(387, 11);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(32, 28);
            this.btnRemove.TabIndex = 28;
            this.btnRemove.Text = "X";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnMinusQuantity
            // 
            this.btnMinusQuantity.AutoSize = true;
            this.btnMinusQuantity.Location = new System.Drawing.Point(299, 11);
            this.btnMinusQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinusQuantity.Name = "btnMinusQuantity";
            this.btnMinusQuantity.Size = new System.Drawing.Size(28, 28);
            this.btnMinusQuantity.TabIndex = 27;
            this.btnMinusQuantity.Text = "-";
            this.btnMinusQuantity.UseVisualStyleBackColor = true;
            // 
            // btnAddQuantity
            // 
            this.btnAddQuantity.AutoSize = true;
            this.btnAddQuantity.Location = new System.Drawing.Point(354, 11);
            this.btnAddQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddQuantity.Name = "btnAddQuantity";
            this.btnAddQuantity.Size = new System.Drawing.Size(31, 28);
            this.btnAddQuantity.TabIndex = 26;
            this.btnAddQuantity.Text = "+";
            this.btnAddQuantity.UseVisualStyleBackColor = true;
            // 
            // lblamount
            // 
            this.lblamount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblamount.Location = new System.Drawing.Point(164, 11);
            this.lblamount.Name = "lblamount";
            this.lblamount.Size = new System.Drawing.Size(113, 23);
            this.lblamount.TabIndex = 25;
            this.lblamount.Text = "amount";
            // 
            // lblSName
            // 
            this.lblSName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSName.Location = new System.Drawing.Point(9, 11);
            this.lblSName.Name = "lblSName";
            this.lblSName.Size = new System.Drawing.Size(204, 23);
            this.lblSName.TabIndex = 24;
            this.lblSName.Text = "servicename";
            // 
            // AppointmentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnMinusQuantity);
            this.Controls.Add(this.btnAddQuantity);
            this.Controls.Add(this.lblamount);
            this.Controls.Add(this.lblSName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AppointmentControl";
            this.Size = new System.Drawing.Size(447, 49);
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
    }
}
