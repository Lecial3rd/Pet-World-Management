namespace PetWorldManagement.StartUp
{
    partial class StartUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartUp));
            this.panel1 = new System.Windows.Forms.Panel();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.btn_Back = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCategoryName = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Admin = new System.Windows.Forms.Button();
            this.btn_Cashier = new System.Windows.Forms.Button();
            this.btn_FrontDesk = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.loginPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.loginPanel);
            this.panel1.Controls.Add(this.btn_Admin);
            this.panel1.Controls.Add(this.btn_Cashier);
            this.panel1.Controls.Add(this.btn_FrontDesk);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 450);
            this.panel1.TabIndex = 0;
            // 
            // loginPanel
            // 
            this.loginPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginPanel.Controls.Add(this.btn_Back);
            this.loginPanel.Controls.Add(this.label2);
            this.loginPanel.Controls.Add(this.labelCategoryName);
            this.loginPanel.Controls.Add(this.txtUser);
            this.loginPanel.Controls.Add(this.txtPass);
            this.loginPanel.Controls.Add(this.btn_Login);
            this.loginPanel.ForeColor = System.Drawing.Color.SlateBlue;
            this.loginPanel.Location = new System.Drawing.Point(456, 123);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(247, 225);
            this.loginPanel.TabIndex = 25;
            this.loginPanel.Visible = false;
            // 
            // btn_Back
            // 
            this.btn_Back.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Back.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_Back.FlatAppearance.BorderSize = 0;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Back.Location = new System.Drawing.Point(12, 180);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(227, 30);
            this.btn_Back.TabIndex = 35;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(8, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 23);
            this.label2.TabIndex = 34;
            this.label2.Text = "Password";
            // 
            // labelCategoryName
            // 
            this.labelCategoryName.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoryName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelCategoryName.Location = new System.Drawing.Point(8, 15);
            this.labelCategoryName.Name = "labelCategoryName";
            this.labelCategoryName.Size = new System.Drawing.Size(114, 23);
            this.labelCategoryName.TabIndex = 33;
            this.labelCategoryName.Text = "Username";
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.SystemColors.Control;
            this.txtUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtUser.Location = new System.Drawing.Point(12, 41);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(227, 26);
            this.txtUser.TabIndex = 32;
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.SystemColors.Control;
            this.txtPass.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtPass.Location = new System.Drawing.Point(12, 96);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '•';
            this.txtPass.Size = new System.Drawing.Size(227, 26);
            this.txtPass.TabIndex = 31;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // btn_Login
            // 
            this.btn_Login.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Login.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_Login.FlatAppearance.BorderSize = 0;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Login.Location = new System.Drawing.Point(12, 144);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(227, 30);
            this.btn_Login.TabIndex = 30;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Admin
            // 
            this.btn_Admin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Admin.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Admin.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Admin.ForeColor = System.Drawing.Color.SlateBlue;
            this.btn_Admin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Admin.Location = new System.Drawing.Point(467, 148);
            this.btn_Admin.Name = "btn_Admin";
            this.btn_Admin.Size = new System.Drawing.Size(227, 40);
            this.btn_Admin.TabIndex = 24;
            this.btn_Admin.Text = "Login as Admin";
            this.btn_Admin.UseVisualStyleBackColor = false;
            this.btn_Admin.Click += new System.EventHandler(this.btn_Admin_Click);
            // 
            // btn_Cashier
            // 
            this.btn_Cashier.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Cashier.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_Cashier.FlatAppearance.BorderSize = 0;
            this.btn_Cashier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cashier.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cashier.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Cashier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cashier.Location = new System.Drawing.Point(467, 240);
            this.btn_Cashier.Name = "btn_Cashier";
            this.btn_Cashier.Size = new System.Drawing.Size(227, 40);
            this.btn_Cashier.TabIndex = 23;
            this.btn_Cashier.Text = "Cashier";
            this.btn_Cashier.UseVisualStyleBackColor = false;
            this.btn_Cashier.Click += new System.EventHandler(this.btn_Cashier_Click);
            // 
            // btn_FrontDesk
            // 
            this.btn_FrontDesk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_FrontDesk.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_FrontDesk.FlatAppearance.BorderSize = 0;
            this.btn_FrontDesk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FrontDesk.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FrontDesk.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_FrontDesk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_FrontDesk.Location = new System.Drawing.Point(467, 194);
            this.btn_FrontDesk.Name = "btn_FrontDesk";
            this.btn_FrontDesk.Size = new System.Drawing.Size(227, 40);
            this.btn_FrontDesk.TabIndex = 22;
            this.btn_FrontDesk.Text = "Front Desk";
            this.btn_FrontDesk.UseVisualStyleBackColor = false;
            this.btn_FrontDesk.Click += new System.EventHandler(this.btn_FrontDesk_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateBlue;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(371, 448);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(57, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 79);
            this.label1.TabIndex = 7;
            this.label1.Text = "Your One-Stop Shop for Happy Pets and Hassle-Free Care!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartUp";
            this.panel1.ResumeLayout(false);
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_FrontDesk;
        private System.Windows.Forms.Button btn_Admin;
        private System.Windows.Forms.Button btn_Cashier;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCategoryName;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btn_Login;
    }
}