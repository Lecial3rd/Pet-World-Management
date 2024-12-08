namespace PetWorldManagement.Inventory
{
    partial class InventoryForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Header_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCategoryName = new System.Windows.Forms.Label();
            this.inventory_flowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.btnViewLog = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.Header_panel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Location = new System.Drawing.Point(13, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 5);
            this.panel1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(12, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Inventory";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(591, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 33);
            this.panel2.TabIndex = 19;
            // 
            // Header_panel
            // 
            this.Header_panel.BackColor = System.Drawing.Color.SlateBlue;
            this.Header_panel.Controls.Add(this.label1);
            this.Header_panel.Controls.Add(this.labelCategoryName);
            this.Header_panel.Location = new System.Drawing.Point(12, 165);
            this.Header_panel.Margin = new System.Windows.Forms.Padding(0);
            this.Header_panel.Name = "Header_panel";
            this.Header_panel.Size = new System.Drawing.Size(851, 33);
            this.Header_panel.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(684, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quantity";
            // 
            // labelCategoryName
            // 
            this.labelCategoryName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoryName.ForeColor = System.Drawing.SystemColors.Control;
            this.labelCategoryName.Location = new System.Drawing.Point(268, 5);
            this.labelCategoryName.Name = "labelCategoryName";
            this.labelCategoryName.Size = new System.Drawing.Size(75, 23);
            this.labelCategoryName.TabIndex = 2;
            this.labelCategoryName.Text = "Product";
            // 
            // inventory_flowLayout
            // 
            this.inventory_flowLayout.AutoScroll = true;
            this.inventory_flowLayout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventory_flowLayout.Location = new System.Drawing.Point(12, 198);
            this.inventory_flowLayout.Margin = new System.Windows.Forms.Padding(0);
            this.inventory_flowLayout.Name = "inventory_flowLayout";
            this.inventory_flowLayout.Size = new System.Drawing.Size(851, 421);
            this.inventory_flowLayout.TabIndex = 17;
            // 
            // btnViewLog
            // 
            this.btnViewLog.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnViewLog.BackColor = System.Drawing.Color.SlateBlue;
            this.btnViewLog.FlatAppearance.BorderSize = 0;
            this.btnViewLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewLog.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.btnViewLog.ForeColor = System.Drawing.SystemColors.Control;
            this.btnViewLog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewLog.Location = new System.Drawing.Point(711, 133);
            this.btnViewLog.Name = "btnViewLog";
            this.btnViewLog.Size = new System.Drawing.Size(152, 30);
            this.btnViewLog.TabIndex = 21;
            this.btnViewLog.Text = "View Log";
            this.btnViewLog.UseVisualStyleBackColor = false;
            this.btnViewLog.Click += new System.EventHandler(this.btnViewLog_Click);
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
            this.panel5.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(12, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.Control;
            this.txtSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtSearch.Location = new System.Drawing.Point(70, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(241, 26);
            this.txtSearch.TabIndex = 5;
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 628);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.btnViewLog);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Header_panel);
            this.Controls.Add(this.inventory_flowLayout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InventoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InventoryForm";
            this.Header_panel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel Header_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCategoryName;
        private System.Windows.Forms.FlowLayoutPanel inventory_flowLayout;
        private System.Windows.Forms.Button btnViewLog;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSearch;
    }
}