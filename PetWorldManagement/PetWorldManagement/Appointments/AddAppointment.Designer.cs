using System.Windows.Forms;

namespace PetWorldManagement.Appointments
{
    partial class AddAppointment
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
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblPetName = new System.Windows.Forms.Label();
            this.lblAppointmentDate = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblStaff = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtPetName = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.lblServices = new System.Windows.Forms.Label();
            this.Service_comboBox = new System.Windows.Forms.ComboBox();
            this.insert_serviceSupply_BTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtp_Appointment = new System.Windows.Forms.DateTimePicker();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.comboStaff = new System.Windows.Forms.ComboBox();
            this.textCost = new System.Windows.Forms.TextBox();
            this.serviceLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.lblCustomerName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCustomerName.Location = new System.Drawing.Point(39, 41);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(139, 24);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "Customer Name:";
            // 
            // lblPetName
            // 
            this.lblPetName.AutoSize = true;
            this.lblPetName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.lblPetName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPetName.Location = new System.Drawing.Point(39, 73);
            this.lblPetName.Name = "lblPetName";
            this.lblPetName.Size = new System.Drawing.Size(89, 24);
            this.lblPetName.TabIndex = 1;
            this.lblPetName.Text = "Pet Name:";
            // 
            // lblAppointmentDate
            // 
            this.lblAppointmentDate.AutoSize = true;
            this.lblAppointmentDate.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.lblAppointmentDate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAppointmentDate.Location = new System.Drawing.Point(39, 106);
            this.lblAppointmentDate.Name = "lblAppointmentDate";
            this.lblAppointmentDate.Size = new System.Drawing.Size(153, 24);
            this.lblAppointmentDate.TabIndex = 2;
            this.lblAppointmentDate.Text = "Appointment Date:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblStatus.Location = new System.Drawing.Point(39, 138);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(64, 24);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status:";
            // 
            // lblStaff
            // 
            this.lblStaff.AutoSize = true;
            this.lblStaff.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.lblStaff.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblStaff.Location = new System.Drawing.Point(39, 169);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(50, 24);
            this.lblStaff.TabIndex = 4;
            this.lblStaff.Text = "Staff:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtCustomerName.Location = new System.Drawing.Point(198, 40);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(308, 30);
            this.txtCustomerName.TabIndex = 5;
            // 
            // txtPetName
            // 
            this.txtPetName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPetName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtPetName.Location = new System.Drawing.Point(198, 73);
            this.txtPetName.Name = "txtPetName";
            this.txtPetName.Size = new System.Drawing.Size(308, 30);
            this.txtPetName.TabIndex = 6;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.SlateBlue;
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.SystemColors.Control;
            this.btnInsert.Location = new System.Drawing.Point(43, 335);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(463, 30);
            this.btnInsert.TabIndex = 10;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // lblServices
            // 
            this.lblServices.AutoSize = true;
            this.lblServices.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.lblServices.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblServices.Location = new System.Drawing.Point(39, 211);
            this.lblServices.Name = "lblServices";
            this.lblServices.Size = new System.Drawing.Size(81, 24);
            this.lblServices.TabIndex = 11;
            this.lblServices.Text = "Services:";
            // 
            // Service_comboBox
            // 
            this.Service_comboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Service_comboBox.FormattingEnabled = true;
            this.Service_comboBox.Location = new System.Drawing.Point(198, 211);
            this.Service_comboBox.Name = "Service_comboBox";
            this.Service_comboBox.Size = new System.Drawing.Size(161, 31);
            this.Service_comboBox.TabIndex = 13;
            // 
            // insert_serviceSupply_BTN
            // 
            this.insert_serviceSupply_BTN.BackColor = System.Drawing.Color.SlateBlue;
            this.insert_serviceSupply_BTN.FlatAppearance.BorderSize = 0;
            this.insert_serviceSupply_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insert_serviceSupply_BTN.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_serviceSupply_BTN.ForeColor = System.Drawing.SystemColors.Control;
            this.insert_serviceSupply_BTN.Location = new System.Drawing.Point(198, 286);
            this.insert_serviceSupply_BTN.Name = "insert_serviceSupply_BTN";
            this.insert_serviceSupply_BTN.Size = new System.Drawing.Size(308, 30);
            this.insert_serviceSupply_BTN.TabIndex = 14;
            this.insert_serviceSupply_BTN.Text = "Add Services";
            this.insert_serviceSupply_BTN.UseVisualStyleBackColor = false;
            this.insert_serviceSupply_BTN.Click += new System.EventHandler(this.insert_serviceSupply_BTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(359, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Price:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(43, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 3);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Location = new System.Drawing.Point(43, 200);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(463, 3);
            this.panel2.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Location = new System.Drawing.Point(43, 326);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(463, 3);
            this.panel3.TabIndex = 19;
            // 
            // dtp_Appointment
            // 
            this.dtp_Appointment.Font = new System.Drawing.Font("Arial", 10F);
            this.dtp_Appointment.Location = new System.Drawing.Point(198, 110);
            this.dtp_Appointment.Name = "dtp_Appointment";
            this.dtp_Appointment.Size = new System.Drawing.Size(308, 27);
            this.dtp_Appointment.TabIndex = 20;
            // 
            // txtStatus
            // 
            this.txtStatus.Enabled = false;
            this.txtStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtStatus.Location = new System.Drawing.Point(198, 137);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(13, 4, 13, 4);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(308, 30);
            this.txtStatus.TabIndex = 21;
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.lblQty.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblQty.Location = new System.Drawing.Point(39, 254);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(42, 24);
            this.lblQty.TabIndex = 22;
            this.lblQty.Text = "Qty:";
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtQty.Location = new System.Drawing.Point(198, 248);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(81, 30);
            this.txtQty.TabIndex = 23;
            // 
            // comboStaff
            // 
            this.comboStaff.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboStaff.FormattingEnabled = true;
            this.comboStaff.Location = new System.Drawing.Point(198, 168);
            this.comboStaff.Name = "comboStaff";
            this.comboStaff.Size = new System.Drawing.Size(308, 31);
            this.comboStaff.TabIndex = 24;
            // 
            // textCost
            // 
            this.textCost.Enabled = false;
            this.textCost.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCost.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textCost.Location = new System.Drawing.Point(414, 210);
            this.textCost.Margin = new System.Windows.Forms.Padding(13, 4, 13, 4);
            this.textCost.Name = "textCost";
            this.textCost.ReadOnly = true;
            this.textCost.Size = new System.Drawing.Size(81, 30);
            this.textCost.TabIndex = 25;
            // 
            // serviceLayout
            // 
            this.serviceLayout.AutoScroll = true;
            this.serviceLayout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.serviceLayout.Location = new System.Drawing.Point(523, 55);
            this.serviceLayout.Margin = new System.Windows.Forms.Padding(4);
            this.serviceLayout.Name = "serviceLayout";
            this.serviceLayout.Size = new System.Drawing.Size(345, 304);
            this.serviceLayout.TabIndex = 27;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SlateBlue;
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(523, 11);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(346, 44);
            this.panel4.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(254, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "QTY";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(122, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // AddAppointment
            // 
            this.ClientSize = new System.Drawing.Size(881, 378);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.serviceLayout);
            this.Controls.Add(this.textCost);
            this.Controls.Add(this.comboStaff);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.dtp_Appointment);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.insert_serviceSupply_BTN);
            this.Controls.Add(this.Service_comboBox);
            this.Controls.Add(this.lblServices);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblPetName);
            this.Controls.Add(this.lblAppointmentDate);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblStaff);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.txtPetName);
            this.Controls.Add(this.btnInsert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private TextBox txtCustomerName;
        private TextBox txtPetName;
        private Button btnInsert;

        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblPetName;
        private System.Windows.Forms.Label lblAppointmentDate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblStaff;

        #endregion

        private Label lblServices;
        private ComboBox Service_comboBox;
        private Button insert_serviceSupply_BTN;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private DateTimePicker dtp_Appointment;
        private TextBox txtStatus;
        private Label lblQty;
        private TextBox txtQty;
        private ComboBox comboStaff;
        private TextBox textCost;
        private FlowLayoutPanel serviceLayout;
        private Panel panel4;
        private Label label7;
        private Label label6;
        private Label label1;
    }
}