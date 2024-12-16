namespace PetWorldManagement.Staff
{
    partial class StaffForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewSuppliers = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.pnlAddStaff = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.lblusername = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.cbxRole = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.cbxGender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtMI = new System.Windows.Forms.TextBox();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuppliers)).BeginInit();
            this.pnlAddStaff.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.txtSearch);
            this.panel5.Location = new System.Drawing.Point(11, 93);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(331, 67);
            this.panel5.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(12, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 18);
            this.label11.TabIndex = 24;
            this.label11.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.Control;
            this.txtSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtSearch.Location = new System.Drawing.Point(84, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(227, 26);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(12, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 23);
            this.label2.TabIndex = 31;
            this.label2.Text = "Staff";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Location = new System.Drawing.Point(13, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 5);
            this.panel1.TabIndex = 30;
            // 
            // dataGridViewSuppliers
            // 
            this.dataGridViewSuppliers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSuppliers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewSuppliers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSuppliers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSuppliers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.LName,
            this.FName,
            this.MI,
            this.Age,
            this.Gender,
            this.Contact,
            this.Role,
            this.Username,
            this.Password,
            this.Delete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSuppliers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewSuppliers.EnableHeadersVisualStyles = false;
            this.dataGridViewSuppliers.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridViewSuppliers.Location = new System.Drawing.Point(12, 165);
            this.dataGridViewSuppliers.Name = "dataGridViewSuppliers";
            this.dataGridViewSuppliers.RowHeadersVisible = false;
            this.dataGridViewSuppliers.Size = new System.Drawing.Size(851, 451);
            this.dataGridViewSuppliers.TabIndex = 28;
            this.dataGridViewSuppliers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSuppliers_CellClick);
            this.dataGridViewSuppliers.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSuppliers_CellEndEdit);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // LName
            // 
            this.LName.HeaderText = "LName";
            this.LName.Name = "LName";
            // 
            // FName
            // 
            this.FName.HeaderText = "FName";
            this.FName.Name = "FName";
            // 
            // MI
            // 
            this.MI.HeaderText = "MI";
            this.MI.Name = "MI";
            // 
            // Age
            // 
            this.Age.HeaderText = "Age";
            this.Age.Name = "Age";
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            // 
            // Contact
            // 
            this.Contact.HeaderText = "Contact";
            this.Contact.Name = "Contact";
            // 
            // Role
            // 
            this.Role.HeaderText = "Role";
            this.Role.Name = "Role";
            // 
            // Username
            // 
            this.Username.HeaderText = "User name";
            this.Username.Name = "Username";
            // 
            // Password
            // 
            this.Password.HeaderText = "Pass word";
            this.Password.Name = "Password";
            // 
            // Delete
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Delete.DefaultCellStyle = dataGridViewCellStyle2;
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "DELETE";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.BackColor = System.Drawing.Color.SlateBlue;
            this.btnAddSupplier.FlatAppearance.BorderSize = 0;
            this.btnAddSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSupplier.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSupplier.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddSupplier.Location = new System.Drawing.Point(711, 133);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(152, 30);
            this.btnAddSupplier.TabIndex = 29;
            this.btnAddSupplier.Text = "+ Staff";
            this.btnAddSupplier.UseVisualStyleBackColor = false;
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // pnlAddStaff
            // 
            this.pnlAddStaff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAddStaff.Controls.Add(this.btnCancel);
            this.pnlAddStaff.Controls.Add(this.btnInsert);
            this.pnlAddStaff.Controls.Add(this.lblusername);
            this.pnlAddStaff.Controls.Add(this.txtusername);
            this.pnlAddStaff.Controls.Add(this.lblpassword);
            this.pnlAddStaff.Controls.Add(this.txtpassword);
            this.pnlAddStaff.Controls.Add(this.cbxRole);
            this.pnlAddStaff.Controls.Add(this.label6);
            this.pnlAddStaff.Controls.Add(this.label5);
            this.pnlAddStaff.Controls.Add(this.txtContact);
            this.pnlAddStaff.Controls.Add(this.cbxGender);
            this.pnlAddStaff.Controls.Add(this.label4);
            this.pnlAddStaff.Controls.Add(this.label3);
            this.pnlAddStaff.Controls.Add(this.txtage);
            this.pnlAddStaff.Controls.Add(this.label1);
            this.pnlAddStaff.Controls.Add(this.txtLname);
            this.pnlAddStaff.Controls.Add(this.lblProductName);
            this.pnlAddStaff.Controls.Add(this.txtFname);
            this.pnlAddStaff.Controls.Add(this.lblDescription);
            this.pnlAddStaff.Controls.Add(this.txtMI);
            this.pnlAddStaff.Location = new System.Drawing.Point(147, 74);
            this.pnlAddStaff.Name = "pnlAddStaff";
            this.pnlAddStaff.Size = new System.Drawing.Size(410, 452);
            this.pnlAddStaff.TabIndex = 33;
            this.pnlAddStaff.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.SlateBlue;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Location = new System.Drawing.Point(52, 402);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(317, 30);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.SlateBlue;
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.SystemColors.Control;
            this.btnInsert.Location = new System.Drawing.Point(52, 366);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(317, 30);
            this.btnInsert.TabIndex = 24;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // lblusername
            // 
            this.lblusername.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblusername.Location = new System.Drawing.Point(49, 287);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(120, 23);
            this.lblusername.TabIndex = 20;
            this.lblusername.Text = "Username";
            this.lblusername.Visible = false;
            // 
            // txtusername
            // 
            this.txtusername.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtusername.Location = new System.Drawing.Point(169, 284);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(200, 26);
            this.txtusername.TabIndex = 21;
            this.txtusername.Visible = false;
            // 
            // lblpassword
            // 
            this.lblpassword.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblpassword.Location = new System.Drawing.Point(49, 319);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(120, 23);
            this.lblpassword.TabIndex = 22;
            this.lblpassword.Text = "Password";
            this.lblpassword.Visible = false;
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtpassword.Location = new System.Drawing.Point(169, 316);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(200, 26);
            this.txtpassword.TabIndex = 23;
            this.txtpassword.Visible = false;
            // 
            // cbxRole
            // 
            this.cbxRole.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxRole.FormattingEnabled = true;
            this.cbxRole.Location = new System.Drawing.Point(169, 252);
            this.cbxRole.Name = "cbxRole";
            this.cbxRole.Size = new System.Drawing.Size(200, 26);
            this.cbxRole.TabIndex = 19;
            this.cbxRole.SelectedIndexChanged += new System.EventHandler(this.cbxRole_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(49, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 23);
            this.label6.TabIndex = 18;
            this.label6.Text = "Role";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(49, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "Contact No.";
            // 
            // txtContact
            // 
            this.txtContact.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtContact.Location = new System.Drawing.Point(169, 220);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(200, 26);
            this.txtContact.TabIndex = 17;
            // 
            // cbxGender
            // 
            this.cbxGender.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGender.FormattingEnabled = true;
            this.cbxGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cbxGender.Location = new System.Drawing.Point(169, 188);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.Size = new System.Drawing.Size(200, 26);
            this.cbxGender.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(49, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "Gender";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(49, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Age";
            // 
            // txtage
            // 
            this.txtage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtage.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtage.Location = new System.Drawing.Point(169, 156);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(200, 26);
            this.txtage.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(49, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Last Name";
            // 
            // txtLname
            // 
            this.txtLname.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLname.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtLname.Location = new System.Drawing.Point(169, 124);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(200, 26);
            this.txtLname.TabIndex = 11;
            // 
            // lblProductName
            // 
            this.lblProductName.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblProductName.Location = new System.Drawing.Point(49, 63);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(120, 23);
            this.lblProductName.TabIndex = 6;
            this.lblProductName.Text = "First Name";
            // 
            // txtFname
            // 
            this.txtFname.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFname.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtFname.Location = new System.Drawing.Point(169, 60);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(200, 26);
            this.txtFname.TabIndex = 7;
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDescription.Location = new System.Drawing.Point(49, 95);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(120, 23);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "Middle Name";
            // 
            // txtMI
            // 
            this.txtMI.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMI.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtMI.Location = new System.Drawing.Point(169, 92);
            this.txtMI.Name = "txtMI";
            this.txtMI.Size = new System.Drawing.Size(200, 26);
            this.txtMI.TabIndex = 9;
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 628);
            this.Controls.Add(this.pnlAddStaff);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewSuppliers);
            this.Controls.Add(this.btnAddSupplier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffForm";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuppliers)).EndInit();
            this.pnlAddStaff.ResumeLayout(false);
            this.pnlAddStaff.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewSuppliers;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.Panel pnlAddStaff;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtMI;
        private System.Windows.Forms.ComboBox cbxRole;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.ComboBox cbxGender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}