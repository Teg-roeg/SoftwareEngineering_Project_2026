namespace CarServiceAdministration
{
    partial class RemoveService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveService));
            this.servBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listServBox = new System.Windows.Forms.ListBox();
            this.SerIDBox = new System.Windows.Forms.ComboBox();
            this.RmvService = new System.Windows.Forms.Button();
            this.ServiceID = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // servBox
            // 
            this.servBox.Controls.Add(this.button1);
            this.servBox.Controls.Add(this.listServBox);
            this.servBox.Controls.Add(this.SerIDBox);
            this.servBox.Controls.Add(this.RmvService);
            this.servBox.Controls.Add(this.ServiceID);
            this.servBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servBox.Location = new System.Drawing.Point(13, 36);
            this.servBox.Margin = new System.Windows.Forms.Padding(2);
            this.servBox.Name = "servBox";
            this.servBox.Padding = new System.Windows.Forms.Padding(2);
            this.servBox.Size = new System.Drawing.Size(579, 256);
            this.servBox.TabIndex = 9;
            this.servBox.TabStop = false;
            this.servBox.Text = "Remove Service Details ";
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
            // listServBox
            // 
            this.listServBox.FormattingEnabled = true;
            this.listServBox.ItemHeight = 19;
            this.listServBox.Location = new System.Drawing.Point(243, 44);
            this.listServBox.Margin = new System.Windows.Forms.Padding(2);
            this.listServBox.Name = "listServBox";
            this.listServBox.Size = new System.Drawing.Size(314, 80);
            this.listServBox.TabIndex = 13;
            // 
            // SerIDBox
            // 
            this.SerIDBox.FormattingEnabled = true;
            this.SerIDBox.Location = new System.Drawing.Point(141, 44);
            this.SerIDBox.Margin = new System.Windows.Forms.Padding(2);
            this.SerIDBox.Name = "SerIDBox";
            this.SerIDBox.Size = new System.Drawing.Size(83, 27);
            this.SerIDBox.TabIndex = 12;
            this.SerIDBox.SelectedIndexChanged += new System.EventHandler(this.SerIDBox_SelectedIndexChanged);
            // 
            // RmvService
            // 
            this.RmvService.BackColor = System.Drawing.SystemColors.HotTrack;
            this.RmvService.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RmvService.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RmvService.Location = new System.Drawing.Point(340, 160);
            this.RmvService.Margin = new System.Windows.Forms.Padding(2);
            this.RmvService.Name = "RmvService";
            this.RmvService.Size = new System.Drawing.Size(215, 53);
            this.RmvService.TabIndex = 6;
            this.RmvService.Text = "Remove Service";
            this.RmvService.UseVisualStyleBackColor = false;
            this.RmvService.Click += new System.EventHandler(this.RmvService_Click);
            // 
            // ServiceID
            // 
            this.ServiceID.AutoSize = true;
            this.ServiceID.Location = new System.Drawing.Point(21, 46);
            this.ServiceID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ServiceID.Name = "ServiceID";
            this.ServiceID.Size = new System.Drawing.Size(78, 20);
            this.ServiceID.TabIndex = 0;
            this.ServiceID.Text = "Service ID:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(606, 24);
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
            // RemoveService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 304);
            this.Controls.Add(this.servBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RemoveService";
            this.Text = "RemoveService";
            this.Load += new System.EventHandler(this.RemoveService_Load);
            this.servBox.ResumeLayout(false);
            this.servBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox servBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listServBox;
        private System.Windows.Forms.ComboBox SerIDBox;
        private System.Windows.Forms.Button RmvService;
        private System.Windows.Forms.Label ServiceID;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}