namespace CarServiceAdministration
{
    partial class RemoveCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveCustomer));
            this.mechBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listCusBox = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.RmvCustomer = new System.Windows.Forms.Button();
            this.MechID = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mechBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mechBox
            // 
            this.mechBox.Controls.Add(this.button1);
            this.mechBox.Controls.Add(this.listCusBox);
            this.mechBox.Controls.Add(this.comboBox1);
            this.mechBox.Controls.Add(this.RmvCustomer);
            this.mechBox.Controls.Add(this.MechID);
            this.mechBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mechBox.Location = new System.Drawing.Point(13, 44);
            this.mechBox.Margin = new System.Windows.Forms.Padding(2);
            this.mechBox.Name = "mechBox";
            this.mechBox.Padding = new System.Windows.Forms.Padding(2);
            this.mechBox.Size = new System.Drawing.Size(579, 284);
            this.mechBox.TabIndex = 9;
            this.mechBox.TabStop = false;
            this.mechBox.Text = "Remove Customer Details ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(25, 160);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 53);
            this.button1.TabIndex = 14;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listCusBox
            // 
            this.listCusBox.FormattingEnabled = true;
            this.listCusBox.ItemHeight = 19;
            this.listCusBox.Location = new System.Drawing.Point(243, 44);
            this.listCusBox.Margin = new System.Windows.Forms.Padding(2);
            this.listCusBox.Name = "listCusBox";
            this.listCusBox.Size = new System.Drawing.Size(314, 80);
            this.listCusBox.TabIndex = 13;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBox1.Location = new System.Drawing.Point(141, 44);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(83, 27);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // RmvCustomer
            // 
            this.RmvCustomer.BackColor = System.Drawing.SystemColors.HotTrack;
            this.RmvCustomer.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RmvCustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RmvCustomer.Location = new System.Drawing.Point(340, 160);
            this.RmvCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.RmvCustomer.Name = "RmvCustomer";
            this.RmvCustomer.Size = new System.Drawing.Size(215, 53);
            this.RmvCustomer.TabIndex = 6;
            this.RmvCustomer.Text = "Remove Customer";
            this.RmvCustomer.UseVisualStyleBackColor = false;
            this.RmvCustomer.Click += new System.EventHandler(this.RmvCustomer_Click);
            // 
            // MechID
            // 
            this.MechID.AutoSize = true;
            this.MechID.Location = new System.Drawing.Point(21, 46);
            this.MechID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MechID.Name = "MechID";
            this.MechID.Size = new System.Drawing.Size(95, 20);
            this.MechID.TabIndex = 0;
            this.MechID.Text = "Customer ID:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(611, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 8.142858F, System.Drawing.FontStyle.Bold);
            this.exitToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.exitToolStripMenuItem.Text = "Back";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // RemoveCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 343);
            this.Controls.Add(this.mechBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RemoveCustomer";
            this.Text = "RemoveCustomer";
            this.Load += new System.EventHandler(this.RemoveCustomer_Load);
            this.mechBox.ResumeLayout(false);
            this.mechBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox mechBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listCusBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button RmvCustomer;
        private System.Windows.Forms.Label MechID;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}