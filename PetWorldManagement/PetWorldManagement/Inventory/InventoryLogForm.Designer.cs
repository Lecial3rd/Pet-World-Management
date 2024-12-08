namespace PetWorldManagement.Inventory
{
    partial class InventoryLogForm
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
            this.Header_panel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.InventoryLog_flowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // Header_panel
            // 
            this.Header_panel.BackColor = System.Drawing.Color.SlateBlue;
            this.Header_panel.Location = new System.Drawing.Point(13, 59);
            this.Header_panel.Margin = new System.Windows.Forms.Padding(0);
            this.Header_panel.Name = "Header_panel";
            this.Header_panel.Size = new System.Drawing.Size(850, 33);
            this.Header_panel.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(12, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "Inventory Log";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Location = new System.Drawing.Point(13, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 5);
            this.panel1.TabIndex = 14;
            // 
            // InventoryLog_flowLayout
            // 
            this.InventoryLog_flowLayout.AutoScroll = true;
            this.InventoryLog_flowLayout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InventoryLog_flowLayout.Location = new System.Drawing.Point(13, 92);
            this.InventoryLog_flowLayout.Margin = new System.Windows.Forms.Padding(0);
            this.InventoryLog_flowLayout.Name = "InventoryLog_flowLayout";
            this.InventoryLog_flowLayout.Size = new System.Drawing.Size(850, 527);
            this.InventoryLog_flowLayout.TabIndex = 16;
            // 
            // InventoryLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 628);
            this.Controls.Add(this.InventoryLog_flowLayout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Header_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InventoryLogForm";
            this.Text = "InventoryLogForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Header_panel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel InventoryLog_flowLayout;
    }
}