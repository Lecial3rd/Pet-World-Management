namespace PetWorldManagement
{
    partial class Appointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Appointment));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.txtboxDiscount = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.txtReceived = new System.Windows.Forms.TextBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblTotalService = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPetName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAppID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewAppointments = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBook = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lblFrontDeskName = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtfrontDeskID = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.dataGridViewAppointments);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 741);
            this.panel1.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.btnLogout);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Location = new System.Drawing.Point(886, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(286, 66);
            this.panel7.TabIndex = 28;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.SlateBlue;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.Location = new System.Drawing.Point(23, 24);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnLogout.Size = new System.Drawing.Size(243, 35);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Shutdown";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(2, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Exit";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.txtboxDiscount);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.btnPay);
            this.panel3.Controls.Add(this.txtReceived);
            this.panel3.Controls.Add(this.lblTotalPrice);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.txtAppID);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(886, 166);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(286, 563);
            this.panel3.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.Location = new System.Drawing.Point(239, 444);
            this.label13.Margin = new System.Windows.Forms.Padding(0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 25);
            this.label13.TabIndex = 35;
            this.label13.Text = "%";
            // 
            // txtboxDiscount
            // 
            this.txtboxDiscount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxDiscount.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtboxDiscount.Location = new System.Drawing.Point(112, 444);
            this.txtboxDiscount.Name = "txtboxDiscount";
            this.txtboxDiscount.Size = new System.Drawing.Size(126, 26);
            this.txtboxDiscount.TabIndex = 34;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label14.Location = new System.Drawing.Point(18, 447);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 23);
            this.label14.TabIndex = 33;
            this.label14.Text = "Discount";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label15.Location = new System.Drawing.Point(19, 394);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 23);
            this.label15.TabIndex = 32;
            this.label15.Text = "Cash";
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.SlateBlue;
            this.btnPay.Enabled = false;
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPay.Location = new System.Drawing.Point(22, 504);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(245, 42);
            this.btnPay.TabIndex = 31;
            this.btnPay.Text = "Confirm\r\n";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // txtReceived
            // 
            this.txtReceived.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceived.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtReceived.Location = new System.Drawing.Point(112, 391);
            this.txtReceived.Name = "txtReceived";
            this.txtReceived.Size = new System.Drawing.Size(154, 26);
            this.txtReceived.TabIndex = 30;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTotalPrice.Location = new System.Drawing.Point(98, 321);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(166, 41);
            this.lblTotalPrice.TabIndex = 29;
            this.lblTotalPrice.Text = "0.00";
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Control;
            this.label12.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(19, 333);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 23);
            this.label12.TabIndex = 28;
            this.label12.Text = "Total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(18, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 18);
            this.label3.TabIndex = 27;
            this.label3.Text = "Customer Information";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.lblTotalService);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.lblPetName);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.lblCustomerName);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Location = new System.Drawing.Point(21, 130);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(244, 173);
            this.panel6.TabIndex = 26;
            // 
            // lblTotalService
            // 
            this.lblTotalService.AutoSize = true;
            this.lblTotalService.BackColor = System.Drawing.SystemColors.Control;
            this.lblTotalService.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalService.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTotalService.Location = new System.Drawing.Point(130, 131);
            this.lblTotalService.Name = "lblTotalService";
            this.lblTotalService.Size = new System.Drawing.Size(17, 18);
            this.lblTotalService.TabIndex = 33;
            this.lblTotalService.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(20, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 18);
            this.label8.TabIndex = 32;
            this.label8.Text = "# of Service";
            // 
            // lblPetName
            // 
            this.lblPetName.BackColor = System.Drawing.SystemColors.Control;
            this.lblPetName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPetName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPetName.Location = new System.Drawing.Point(130, 85);
            this.lblPetName.Name = "lblPetName";
            this.lblPetName.Size = new System.Drawing.Size(109, 16);
            this.lblPetName.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(20, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 18);
            this.label6.TabIndex = 30;
            this.label6.Text = "Pet Name";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.BackColor = System.Drawing.SystemColors.Control;
            this.lblCustomerName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCustomerName.Location = new System.Drawing.Point(130, 39);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(109, 16);
            this.lblCustomerName.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(20, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 18);
            this.label4.TabIndex = 28;
            this.label4.Text = "Customer";
            // 
            // txtAppID
            // 
            this.txtAppID.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAppID.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtAppID.Location = new System.Drawing.Point(21, 46);
            this.txtAppID.Name = "txtAppID";
            this.txtAppID.Size = new System.Drawing.Size(245, 39);
            this.txtAppID.TabIndex = 25;
            this.txtAppID.TextChanged += new System.EventHandler(this.txtAppID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Appointment ID";
            // 
            // dataGridViewAppointments
            // 
            this.dataGridViewAppointments.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewAppointments.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAppointments.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAppointments.EnableHeadersVisualStyles = false;
            this.dataGridViewAppointments.Location = new System.Drawing.Point(12, 93);
            this.dataGridViewAppointments.Name = "dataGridViewAppointments";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAppointments.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewAppointments.RowHeadersWidth = 51;
            this.dataGridViewAppointments.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewAppointments.Size = new System.Drawing.Size(868, 636);
            this.dataGridViewAppointments.TabIndex = 26;
            this.dataGridViewAppointments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAppointments_CellContentClick);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.txtSearchBox);
            this.panel5.Location = new System.Drawing.Point(416, 4);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(400, 73);
            this.panel5.TabIndex = 24;
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
            // txtSearchBox
            // 
            this.txtSearchBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtSearchBox.Location = new System.Drawing.Point(84, 21);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(295, 26);
            this.txtSearchBox.TabIndex = 15;
            this.txtSearchBox.TextChanged += new System.EventHandler(this.txtSearchBox_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnBook);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(886, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(286, 66);
            this.panel2.TabIndex = 27;
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.Color.SlateBlue;
            this.btnBook.FlatAppearance.BorderSize = 0;
            this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBook.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBook.Location = new System.Drawing.Point(22, 24);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(243, 35);
            this.btnBook.TabIndex = 6;
            this.btnBook.Text = "+ Book";
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Book Appointment";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnSelect);
            this.panel4.Controls.Add(this.lblFrontDeskName);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.txtfrontDeskID);
            this.panel4.Location = new System.Drawing.Point(12, 4);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(400, 73);
            this.panel4.TabIndex = 20;
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.SlateBlue;
            this.btnSelect.FlatAppearance.BorderSize = 0;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Image = ((System.Drawing.Image)(resources.GetObject("btnSelect.Image")));
            this.btnSelect.Location = new System.Drawing.Point(360, 3);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(26, 25);
            this.btnSelect.TabIndex = 24;
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lblFrontDeskName
            // 
            this.lblFrontDeskName.AutoSize = true;
            this.lblFrontDeskName.BackColor = System.Drawing.SystemColors.Control;
            this.lblFrontDeskName.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrontDeskName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFrontDeskName.Location = new System.Drawing.Point(133, 41);
            this.lblFrontDeskName.Name = "lblFrontDeskName";
            this.lblFrontDeskName.Size = new System.Drawing.Size(0, 18);
            this.lblFrontDeskName.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(6, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 18);
            this.label10.TabIndex = 22;
            this.label10.Text = "Used:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(6, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 18);
            this.label9.TabIndex = 21;
            this.label9.Text = "FrontDesk ID";
            // 
            // txtfrontDeskID
            // 
            this.txtfrontDeskID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfrontDeskID.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtfrontDeskID.Location = new System.Drawing.Point(129, 3);
            this.txtfrontDeskID.Name = "txtfrontDeskID";
            this.txtfrontDeskID.Size = new System.Drawing.Size(226, 26);
            this.txtfrontDeskID.TabIndex = 16;
            // 
            // Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 741);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Appointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointment";
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label lblFrontDeskName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtfrontDeskID;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewAppointments;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtAppID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblPetName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTotalService;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtboxDiscount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.TextBox txtReceived;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLogout;
    }
}