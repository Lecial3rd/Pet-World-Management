using System.Windows.Forms;

namespace PetWorldManagement
{
    partial class AddSupplierForm
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
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblContactPerson = new System.Windows.Forms.Label();
            this.lblContactEmail = new System.Windows.Forms.Label();
            this.lblContactPhone = new System.Windows.Forms.Label();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtContactPerson = new System.Windows.Forms.TextBox();
            this.txtContactEmail = new System.Windows.Forms.TextBox();
            this.txtContactPhone = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Product_comboBox = new System.Windows.Forms.ComboBox();
            this.insert_productSupply_BTN = new System.Windows.Forms.Button();
            this.ProductListBox = new System.Windows.Forms.ListBox();
            this.textCost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSupplierName.Location = new System.Drawing.Point(39, 41);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(113, 18);
            this.lblSupplierName.TabIndex = 0;
            this.lblSupplierName.Text = "Supplier Name";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAddress.Location = new System.Drawing.Point(39, 73);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(67, 18);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "Address";
            // 
            // lblContactPerson
            // 
            this.lblContactPerson.AutoSize = true;
            this.lblContactPerson.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactPerson.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblContactPerson.Location = new System.Drawing.Point(39, 106);
            this.lblContactPerson.Name = "lblContactPerson";
            this.lblContactPerson.Size = new System.Drawing.Size(120, 18);
            this.lblContactPerson.TabIndex = 2;
            this.lblContactPerson.Text = "Contact Person";
            // 
            // lblContactEmail
            // 
            this.lblContactEmail.AutoSize = true;
            this.lblContactEmail.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactEmail.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblContactEmail.Location = new System.Drawing.Point(39, 138);
            this.lblContactEmail.Name = "lblContactEmail";
            this.lblContactEmail.Size = new System.Drawing.Size(47, 18);
            this.lblContactEmail.TabIndex = 3;
            this.lblContactEmail.Text = "Email";
            // 
            // lblContactPhone
            // 
            this.lblContactPhone.AutoSize = true;
            this.lblContactPhone.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactPhone.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblContactPhone.Location = new System.Drawing.Point(39, 169);
            this.lblContactPhone.Name = "lblContactPhone";
            this.lblContactPhone.Size = new System.Drawing.Size(53, 18);
            this.lblContactPhone.TabIndex = 4;
            this.lblContactPhone.Text = "Phone";
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtSupplierName.Location = new System.Drawing.Point(167, 38);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(308, 26);
            this.txtSupplierName.TabIndex = 5;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtAddress.Location = new System.Drawing.Point(167, 71);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(308, 26);
            this.txtAddress.TabIndex = 6;
            // 
            // txtContactPerson
            // 
            this.txtContactPerson.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactPerson.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtContactPerson.Location = new System.Drawing.Point(167, 104);
            this.txtContactPerson.Name = "txtContactPerson";
            this.txtContactPerson.Size = new System.Drawing.Size(308, 26);
            this.txtContactPerson.TabIndex = 7;
            // 
            // txtContactEmail
            // 
            this.txtContactEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactEmail.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtContactEmail.Location = new System.Drawing.Point(167, 136);
            this.txtContactEmail.Name = "txtContactEmail";
            this.txtContactEmail.Size = new System.Drawing.Size(308, 26);
            this.txtContactEmail.TabIndex = 8;
            // 
            // txtContactPhone
            // 
            this.txtContactPhone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactPhone.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtContactPhone.Location = new System.Drawing.Point(167, 168);
            this.txtContactPhone.Name = "txtContactPhone";
            this.txtContactPhone.Size = new System.Drawing.Size(308, 26);
            this.txtContactPhone.TabIndex = 9;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.SlateBlue;
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.SystemColors.Control;
            this.btnInsert.Location = new System.Drawing.Point(43, 368);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(432, 30);
            this.btnInsert.TabIndex = 10;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(39, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Supplier Product";
            // 
            // Product_comboBox
            // 
            this.Product_comboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_comboBox.FormattingEnabled = true;
            this.Product_comboBox.Location = new System.Drawing.Point(167, 209);
            this.Product_comboBox.Name = "Product_comboBox";
            this.Product_comboBox.Size = new System.Drawing.Size(161, 26);
            this.Product_comboBox.TabIndex = 13;
            // 
            // insert_productSupply_BTN
            // 
            this.insert_productSupply_BTN.BackColor = System.Drawing.Color.SlateBlue;
            this.insert_productSupply_BTN.FlatAppearance.BorderSize = 0;
            this.insert_productSupply_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insert_productSupply_BTN.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_productSupply_BTN.ForeColor = System.Drawing.SystemColors.Control;
            this.insert_productSupply_BTN.Location = new System.Drawing.Point(167, 241);
            this.insert_productSupply_BTN.Name = "insert_productSupply_BTN";
            this.insert_productSupply_BTN.Size = new System.Drawing.Size(308, 30);
            this.insert_productSupply_BTN.TabIndex = 14;
            this.insert_productSupply_BTN.Text = "Add Product";
            this.insert_productSupply_BTN.UseVisualStyleBackColor = false;
            this.insert_productSupply_BTN.Click += new System.EventHandler(this.insert_productSupply_BTN_Click);
            // 
            // ProductListBox
            // 
            this.ProductListBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductListBox.FormattingEnabled = true;
            this.ProductListBox.ItemHeight = 18;
            this.ProductListBox.Location = new System.Drawing.Point(167, 277);
            this.ProductListBox.Name = "ProductListBox";
            this.ProductListBox.Size = new System.Drawing.Size(308, 76);
            this.ProductListBox.TabIndex = 15;
            // 
            // textCost
            // 
            this.textCost.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCost.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textCost.Location = new System.Drawing.Point(380, 209);
            this.textCost.Name = "textCost";
            this.textCost.Size = new System.Drawing.Size(95, 26);
            this.textCost.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(332, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Price";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(43, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 3);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Location = new System.Drawing.Point(43, 200);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(432, 3);
            this.panel2.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Location = new System.Drawing.Point(43, 359);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(432, 3);
            this.panel3.TabIndex = 19;
            // 
            // AddSupplierForm
            // 
            this.ClientSize = new System.Drawing.Size(522, 423);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textCost);
            this.Controls.Add(this.ProductListBox);
            this.Controls.Add(this.insert_productSupply_BTN);
            this.Controls.Add(this.Product_comboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSupplierName);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblContactPerson);
            this.Controls.Add(this.lblContactEmail);
            this.Controls.Add(this.lblContactPhone);
            this.Controls.Add(this.txtSupplierName);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtContactPerson);
            this.Controls.Add(this.txtContactEmail);
            this.Controls.Add(this.txtContactPhone);
            this.Controls.Add(this.btnInsert);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddSupplierForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private TextBox txtSupplierName;
        private TextBox txtAddress;
        private TextBox txtContactPerson;
        private TextBox txtContactEmail;
        private TextBox txtContactPhone;
        private Button btnInsert;

        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblContactPerson;
        private System.Windows.Forms.Label lblContactEmail;
        private System.Windows.Forms.Label lblContactPhone;

        #endregion

        private Label label1;
        private ComboBox Product_comboBox;
        private Button insert_productSupply_BTN;
        private ListBox ProductListBox;
        private TextBox textCost;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
    }
}