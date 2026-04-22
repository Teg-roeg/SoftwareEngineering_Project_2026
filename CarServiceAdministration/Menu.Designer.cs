namespace CarServiceAdministration
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
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
            this.removeServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 20.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(13, 621);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 77);
            this.label1.TabIndex = 1;
            this.label1.Text = "Car Service Administration";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1473, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
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
            this.mechanicToolStripMenuItem.Click += new System.EventHandler(this.mechanicToolStripMenuItem_Click);
            // 
            // regMechanicToolStripMenuItem
            // 
            this.regMechanicToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.regMechanicToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.regMechanicToolStripMenuItem.Name = "regMechanicToolStripMenuItem";
            this.regMechanicToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.regMechanicToolStripMenuItem.Text = "Reg Mechanic";
            this.regMechanicToolStripMenuItem.Click += new System.EventHandler(this.regMechanicToolStripMenuItem_Click);
            // 
            // updateMechanicToolStripMenuItem
            // 
            this.updateMechanicToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.updateMechanicToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateMechanicToolStripMenuItem.Name = "updateMechanicToolStripMenuItem";
            this.updateMechanicToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateMechanicToolStripMenuItem.Text = "Update Mechanic";
            this.updateMechanicToolStripMenuItem.Click += new System.EventHandler(this.updateMechanicToolStripMenuItem_Click);
            // 
            // removeMechanicToolStripMenuItem
            // 
            this.removeMechanicToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.removeMechanicToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.removeMechanicToolStripMenuItem.Name = "removeMechanicToolStripMenuItem";
            this.removeMechanicToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeMechanicToolStripMenuItem.Text = "Remove Mechanic";
            this.removeMechanicToolStripMenuItem.Click += new System.EventHandler(this.removeMechanicToolStripMenuItem_Click);
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
            this.carToolStripMenuItem.Click += new System.EventHandler(this.carToolStripMenuItem_Click);
            // 
            // regCarToolStripMenuItem
            // 
            this.regCarToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.regCarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.regCarToolStripMenuItem.Name = "regCarToolStripMenuItem";
            this.regCarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.regCarToolStripMenuItem.Text = "Reg Car";
            this.regCarToolStripMenuItem.Click += new System.EventHandler(this.regCarToolStripMenuItem_Click);
            // 
            // updateCarToolStripMenuItem
            // 
            this.updateCarToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.updateCarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateCarToolStripMenuItem.Name = "updateCarToolStripMenuItem";
            this.updateCarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateCarToolStripMenuItem.Text = "Update Car";
            this.updateCarToolStripMenuItem.Click += new System.EventHandler(this.updateCarToolStripMenuItem_Click);
            // 
            // removeCarToolStripMenuItem
            // 
            this.removeCarToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.removeCarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.removeCarToolStripMenuItem.Name = "removeCarToolStripMenuItem";
            this.removeCarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeCarToolStripMenuItem.Text = "Remove Car";
            this.removeCarToolStripMenuItem.Click += new System.EventHandler(this.removeCarToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regServiceToolStripMenuItem,
            this.updateServiceToolStripMenuItem,
            this.removeServiceToolStripMenuItem});
            this.customerToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.customerToolStripMenuItem.Text = "Service";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // regServiceToolStripMenuItem
            // 
            this.regServiceToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.regServiceToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.regServiceToolStripMenuItem.Name = "regServiceToolStripMenuItem";
            this.regServiceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.regServiceToolStripMenuItem.Text = "Reg Service";
            this.regServiceToolStripMenuItem.Click += new System.EventHandler(this.regServiceToolStripMenuItem_Click);
            // 
            // updateServiceToolStripMenuItem
            // 
            this.updateServiceToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.updateServiceToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateServiceToolStripMenuItem.Name = "updateServiceToolStripMenuItem";
            this.updateServiceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateServiceToolStripMenuItem.Text = "Update Service";
            this.updateServiceToolStripMenuItem.Click += new System.EventHandler(this.updateServiceToolStripMenuItem_Click);
            // 
            // removeServiceToolStripMenuItem
            // 
            this.removeServiceToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.removeServiceToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.removeServiceToolStripMenuItem.Name = "removeServiceToolStripMenuItem";
            this.removeServiceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeServiceToolStripMenuItem.Text = "Remove Service";
            this.removeServiceToolStripMenuItem.Click += new System.EventHandler(this.removeServiceToolStripMenuItem_Click);
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
            this.serviceToolStripMenuItem.Click += new System.EventHandler(this.serviceToolStripMenuItem_Click);
            // 
            // regCustomerToolStripMenuItem
            // 
            this.regCustomerToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.regCustomerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.regCustomerToolStripMenuItem.Name = "regCustomerToolStripMenuItem";
            this.regCustomerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.regCustomerToolStripMenuItem.Text = "Reg Customer";
            this.regCustomerToolStripMenuItem.Click += new System.EventHandler(this.regCustomerToolStripMenuItem_Click);
            // 
            // updateCustomerToolStripMenuItem
            // 
            this.updateCustomerToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.updateCustomerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateCustomerToolStripMenuItem.Name = "updateCustomerToolStripMenuItem";
            this.updateCustomerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateCustomerToolStripMenuItem.Text = "Update Customer";
            this.updateCustomerToolStripMenuItem.Click += new System.EventHandler(this.updateCustomerToolStripMenuItem_Click);
            // 
            // removeCustomerToolStripMenuItem
            // 
            this.removeCustomerToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.removeCustomerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.removeCustomerToolStripMenuItem.Name = "removeCustomerToolStripMenuItem";
            this.removeCustomerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeCustomerToolStripMenuItem.Text = "Remove Customer";
            this.removeCustomerToolStripMenuItem.Click += new System.EventHandler(this.removeCustomerToolStripMenuItem_Click);
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
            this.bookingToolStripMenuItem.Click += new System.EventHandler(this.bookingToolStripMenuItem_Click);
            // 
            // scheduleBookingToolStripMenuItem
            // 
            this.scheduleBookingToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.scheduleBookingToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.scheduleBookingToolStripMenuItem.Name = "scheduleBookingToolStripMenuItem";
            this.scheduleBookingToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.scheduleBookingToolStripMenuItem.Text = "Schedule Booking";
            this.scheduleBookingToolStripMenuItem.Click += new System.EventHandler(this.scheduleBookingToolStripMenuItem_Click);
            // 
            // updateBookingToolStripMenuItem
            // 
            this.updateBookingToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.updateBookingToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateBookingToolStripMenuItem.Name = "updateBookingToolStripMenuItem";
            this.updateBookingToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.updateBookingToolStripMenuItem.Text = "Update Booking";
            this.updateBookingToolStripMenuItem.Click += new System.EventHandler(this.updateBookingToolStripMenuItem_Click);
            // 
            // cancelBookingToolStripMenuItem
            // 
            this.cancelBookingToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cancelBookingToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancelBookingToolStripMenuItem.Name = "cancelBookingToolStripMenuItem";
            this.cancelBookingToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.cancelBookingToolStripMenuItem.Text = "Cancel Booking";
            this.cancelBookingToolStripMenuItem.Click += new System.EventHandler(this.cancelBookingToolStripMenuItem_Click);
            // 
            // viewBookingToolStripMenuItem
            // 
            this.viewBookingToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.viewBookingToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.viewBookingToolStripMenuItem.Name = "viewBookingToolStripMenuItem";
            this.viewBookingToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.viewBookingToolStripMenuItem.Text = "View Booking";
            this.viewBookingToolStripMenuItem.Click += new System.EventHandler(this.viewBookingToolStripMenuItem_Click);
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
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // generateInvoiceToolStripMenuItem
            // 
            this.generateInvoiceToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.generateInvoiceToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.generateInvoiceToolStripMenuItem.Name = "generateInvoiceToolStripMenuItem";
            this.generateInvoiceToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.generateInvoiceToolStripMenuItem.Text = "Generate Invoice";
            this.generateInvoiceToolStripMenuItem.Click += new System.EventHandler(this.generateInvoiceToolStripMenuItem_Click);
            // 
            // recordPaymentToolStripMenuItem
            // 
            this.recordPaymentToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.recordPaymentToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.recordPaymentToolStripMenuItem.Name = "recordPaymentToolStripMenuItem";
            this.recordPaymentToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.recordPaymentToolStripMenuItem.Text = "Record Payment";
            this.recordPaymentToolStripMenuItem.Click += new System.EventHandler(this.recordPaymentToolStripMenuItem_Click);
            // 
            // monthlyRevenueAnalysisToolStripMenuItem
            // 
            this.monthlyRevenueAnalysisToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.monthlyRevenueAnalysisToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.monthlyRevenueAnalysisToolStripMenuItem.Name = "monthlyRevenueAnalysisToolStripMenuItem";
            this.monthlyRevenueAnalysisToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.monthlyRevenueAnalysisToolStripMenuItem.Text = "Monthly Revenue Analysis";
            this.monthlyRevenueAnalysisToolStripMenuItem.Click += new System.EventHandler(this.monthlyRevenueAnalysisToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 8.142858F, System.Drawing.FontStyle.Bold);
            this.exitToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening_1);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip2.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip2_Opening);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Font = new System.Drawing.Font("OCR A Extended", 27.85714F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(13, 490);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(360, 68);
            this.label2.TabIndex = 5;
            this.label2.Text = "Welcome to -";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1473, 803);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft YaHei", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mechanicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regMechanicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateMechanicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeMechanicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regServiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateServiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeServiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateInvoiceToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem recordPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthlyRevenueAnalysisToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label2;
    }
}

