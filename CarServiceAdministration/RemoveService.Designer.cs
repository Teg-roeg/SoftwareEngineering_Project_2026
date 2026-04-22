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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.RmvService = new System.Windows.Forms.Button();
            this.ServiceID = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mechanicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regMechanicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateMechanicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeMechanicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthlyRevenueAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // servBox
            // 
            this.servBox.Controls.Add(this.button1);
            this.servBox.Controls.Add(this.listServBox);
            this.servBox.Controls.Add(this.comboBox1);
            this.servBox.Controls.Add(this.RmvService);
            this.servBox.Controls.Add(this.ServiceID);
            this.servBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servBox.Location = new System.Drawing.Point(13, 36);
            this.servBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.servBox.Name = "servBox";
            this.servBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.listServBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listServBox.Name = "listServBox";
            this.listServBox.Size = new System.Drawing.Size(314, 80);
            this.listServBox.TabIndex = 13;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(141, 44);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(83, 27);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // RmvService
            // 
            this.RmvService.BackColor = System.Drawing.SystemColors.HotTrack;
            this.RmvService.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RmvService.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RmvService.Location = new System.Drawing.Point(340, 160);
            this.RmvService.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.mechanicToolStripMenuItem,
            this.carToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.serviceToolStripMenuItem,
            this.bookingToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(606, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mechanicToolStripMenuItem
            // 
            this.mechanicToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regMechanicToolStripMenuItem,
            this.updateMechanicToolStripMenuItem,
            this.removeMechanicToolStripMenuItem});
            this.mechanicToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mechanicToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mechanicToolStripMenuItem.Name = "mechanicToolStripMenuItem";
            this.mechanicToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.mechanicToolStripMenuItem.Text = "Mechanic";
            // 
            // regMechanicToolStripMenuItem
            // 
            this.regMechanicToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.regMechanicToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.regMechanicToolStripMenuItem.Name = "regMechanicToolStripMenuItem";
            this.regMechanicToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.regMechanicToolStripMenuItem.Text = "Reg Mechanic";
            // 
            // updateMechanicToolStripMenuItem
            // 
            this.updateMechanicToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.updateMechanicToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateMechanicToolStripMenuItem.Name = "updateMechanicToolStripMenuItem";
            this.updateMechanicToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.updateMechanicToolStripMenuItem.Text = "Update Mechanic";
            // 
            // removeMechanicToolStripMenuItem
            // 
            this.removeMechanicToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.removeMechanicToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.removeMechanicToolStripMenuItem.Name = "removeMechanicToolStripMenuItem";
            this.removeMechanicToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.removeMechanicToolStripMenuItem.Text = "Remove Mechanic";
            // 
            // carToolStripMenuItem
            // 
            this.carToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regCarToolStripMenuItem,
            this.updateCarToolStripMenuItem,
            this.removeCarToolStripMenuItem});
            this.carToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.carToolStripMenuItem.Name = "carToolStripMenuItem";
            this.carToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.carToolStripMenuItem.Text = "Car";
            // 
            // regCarToolStripMenuItem
            // 
            this.regCarToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.regCarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.regCarToolStripMenuItem.Name = "regCarToolStripMenuItem";
            this.regCarToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.regCarToolStripMenuItem.Text = "Reg Car";
            // 
            // updateCarToolStripMenuItem
            // 
            this.updateCarToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.updateCarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateCarToolStripMenuItem.Name = "updateCarToolStripMenuItem";
            this.updateCarToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.updateCarToolStripMenuItem.Text = "Update Car";
            // 
            // removeCarToolStripMenuItem
            // 
            this.removeCarToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.removeCarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.removeCarToolStripMenuItem.Name = "removeCarToolStripMenuItem";
            this.removeCarToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.removeCarToolStripMenuItem.Text = "Remove Car";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regServiceToolStripMenuItem,
            this.updateServiceToolStripMenuItem});
            this.customerToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.customerToolStripMenuItem.Text = "Service";
            // 
            // regServiceToolStripMenuItem
            // 
            this.regServiceToolStripMenuItem.Name = "regServiceToolStripMenuItem";
            this.regServiceToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            // 
            // updateServiceToolStripMenuItem
            // 
            this.updateServiceToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.updateServiceToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateServiceToolStripMenuItem.Name = "updateServiceToolStripMenuItem";
            this.updateServiceToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.updateServiceToolStripMenuItem.Text = "Update Service";
            // 
            // serviceToolStripMenuItem
            // 
            this.serviceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regCustomerToolStripMenuItem,
            this.updateCustomerToolStripMenuItem,
            this.removeCustomerToolStripMenuItem});
            this.serviceToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.serviceToolStripMenuItem.Name = "serviceToolStripMenuItem";
            this.serviceToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.serviceToolStripMenuItem.Text = "Customer";
            // 
            // regCustomerToolStripMenuItem
            // 
            this.regCustomerToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.regCustomerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.regCustomerToolStripMenuItem.Name = "regCustomerToolStripMenuItem";
            this.regCustomerToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.regCustomerToolStripMenuItem.Text = "Reg Customer";
            // 
            // updateCustomerToolStripMenuItem
            // 
            this.updateCustomerToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.updateCustomerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateCustomerToolStripMenuItem.Name = "updateCustomerToolStripMenuItem";
            this.updateCustomerToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.updateCustomerToolStripMenuItem.Text = "Update Customer";
            // 
            // removeCustomerToolStripMenuItem
            // 
            this.removeCustomerToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.removeCustomerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.removeCustomerToolStripMenuItem.Name = "removeCustomerToolStripMenuItem";
            this.removeCustomerToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.removeCustomerToolStripMenuItem.Text = "Remove Customer";
            // 
            // bookingToolStripMenuItem
            // 
            this.bookingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scheduleBookingToolStripMenuItem,
            this.updateBookingToolStripMenuItem,
            this.cancelBookingToolStripMenuItem,
            this.viewBookingToolStripMenuItem});
            this.bookingToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bookingToolStripMenuItem.Name = "bookingToolStripMenuItem";
            this.bookingToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.bookingToolStripMenuItem.Text = "Booking";
            // 
            // scheduleBookingToolStripMenuItem
            // 
            this.scheduleBookingToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.scheduleBookingToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.scheduleBookingToolStripMenuItem.Name = "scheduleBookingToolStripMenuItem";
            this.scheduleBookingToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.scheduleBookingToolStripMenuItem.Text = "Schedule Booking";
            // 
            // updateBookingToolStripMenuItem
            // 
            this.updateBookingToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.updateBookingToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateBookingToolStripMenuItem.Name = "updateBookingToolStripMenuItem";
            this.updateBookingToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.updateBookingToolStripMenuItem.Text = "Update Booking";
            // 
            // cancelBookingToolStripMenuItem
            // 
            this.cancelBookingToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cancelBookingToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancelBookingToolStripMenuItem.Name = "cancelBookingToolStripMenuItem";
            this.cancelBookingToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.cancelBookingToolStripMenuItem.Text = "Cancel Booking";
            // 
            // viewBookingToolStripMenuItem
            // 
            this.viewBookingToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.viewBookingToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.viewBookingToolStripMenuItem.Name = "viewBookingToolStripMenuItem";
            this.viewBookingToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.viewBookingToolStripMenuItem.Text = "View Booking";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateInvoiceToolStripMenuItem,
            this.recordPaymentToolStripMenuItem,
            this.monthlyRevenueAnalysisToolStripMenuItem});
            this.adminToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // generateInvoiceToolStripMenuItem
            // 
            this.generateInvoiceToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.generateInvoiceToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.generateInvoiceToolStripMenuItem.Name = "generateInvoiceToolStripMenuItem";
            this.generateInvoiceToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.generateInvoiceToolStripMenuItem.Text = "Generate Invoice";
            // 
            // recordPaymentToolStripMenuItem
            // 
            this.recordPaymentToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.recordPaymentToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.recordPaymentToolStripMenuItem.Name = "recordPaymentToolStripMenuItem";
            this.recordPaymentToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.recordPaymentToolStripMenuItem.Text = "Record Payment";
            // 
            // monthlyRevenueAnalysisToolStripMenuItem
            // 
            this.monthlyRevenueAnalysisToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.monthlyRevenueAnalysisToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.monthlyRevenueAnalysisToolStripMenuItem.Name = "monthlyRevenueAnalysisToolStripMenuItem";
            this.monthlyRevenueAnalysisToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.monthlyRevenueAnalysisToolStripMenuItem.Text = "Monthly Revenue Analysis";
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RemoveService";
            this.Text = "RemoveService";
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button RmvService;
        private System.Windows.Forms.Label ServiceID;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mechanicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regMechanicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateMechanicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeMechanicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regServiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateServiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateInvoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthlyRevenueAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}