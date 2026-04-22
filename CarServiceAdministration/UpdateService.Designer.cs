namespace CarServiceAdministration
{
    partial class UpdateService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateService));
            this.cusBox = new System.Windows.Forms.GroupBox();
            this.priceSerBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameSerBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SerIDBox = new System.Windows.Forms.ComboBox();
            this.AddCar = new System.Windows.Forms.Button();
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
            this.removeServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.cusBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cusBox
            // 
            this.cusBox.Controls.Add(this.priceSerBox);
            this.cusBox.Controls.Add(this.label2);
            this.cusBox.Controls.Add(this.nameSerBox);
            this.cusBox.Controls.Add(this.label4);
            this.cusBox.Controls.Add(this.label1);
            this.cusBox.Controls.Add(this.SerIDBox);
            this.cusBox.Controls.Add(this.AddCar);
            this.cusBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusBox.Location = new System.Drawing.Point(17, 46);
            this.cusBox.Margin = new System.Windows.Forms.Padding(2);
            this.cusBox.Name = "cusBox";
            this.cusBox.Padding = new System.Windows.Forms.Padding(2);
            this.cusBox.Size = new System.Drawing.Size(523, 275);
            this.cusBox.TabIndex = 13;
            this.cusBox.TabStop = false;
            this.cusBox.Text = "Update Car Details";
            // 
            // priceSerBox
            // 
            this.priceSerBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.priceSerBox.Location = new System.Drawing.Point(200, 128);
            this.priceSerBox.Margin = new System.Windows.Forms.Padding(2);
            this.priceSerBox.Name = "priceSerBox";
            this.priceSerBox.Size = new System.Drawing.Size(65, 24);
            this.priceSerBox.TabIndex = 18;
            this.priceSerBox.Tag = "";
            this.priceSerBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Price:";
            // 
            // nameSerBox
            // 
            this.nameSerBox.Location = new System.Drawing.Point(200, 89);
            this.nameSerBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameSerBox.Name = "nameSerBox";
            this.nameSerBox.Size = new System.Drawing.Size(168, 24);
            this.nameSerBox.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Service Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Service ID:";
            // 
            // SerIDBox
            // 
            this.SerIDBox.FormattingEnabled = true;
            this.SerIDBox.Location = new System.Drawing.Point(200, 47);
            this.SerIDBox.Margin = new System.Windows.Forms.Padding(2);
            this.SerIDBox.Name = "SerIDBox";
            this.SerIDBox.Size = new System.Drawing.Size(68, 27);
            this.SerIDBox.TabIndex = 11;
            this.SerIDBox.SelectedIndexChanged += new System.EventHandler(this.SerIDBox_SelectedIndexChanged);
            // 
            // AddCar
            // 
            this.AddCar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.AddCar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddCar.Location = new System.Drawing.Point(289, 198);
            this.AddCar.Margin = new System.Windows.Forms.Padding(2);
            this.AddCar.Name = "AddCar";
            this.AddCar.Size = new System.Drawing.Size(215, 53);
            this.AddCar.TabIndex = 6;
            this.AddCar.Text = "Update Service";
            this.AddCar.UseVisualStyleBackColor = false;
            this.AddCar.Click += new System.EventHandler(this.AddCar_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(558, 24);
            this.menuStrip1.TabIndex = 12;
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
            this.removeServiceToolStripMenuItem});
            this.customerToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.customerToolStripMenuItem.Text = "Service";
            // 
            // regServiceToolStripMenuItem
            // 
            this.regServiceToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.regServiceToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.regServiceToolStripMenuItem.Name = "regServiceToolStripMenuItem";
            this.regServiceToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.regServiceToolStripMenuItem.Text = "Reg Service";
            // 
            // removeServiceToolStripMenuItem
            // 
            this.removeServiceToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.removeServiceToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.removeServiceToolStripMenuItem.Name = "removeServiceToolStripMenuItem";
            this.removeServiceToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.removeServiceToolStripMenuItem.Text = "Remove Service";
            // 
            // serviceToolStripMenuItem
            // 
            this.serviceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regCustomerToolStripMenuItem,
            this.removeCustomerToolStripMenuItem,
            this.updateCustomerToolStripMenuItem});
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
            // removeCustomerToolStripMenuItem
            // 
            this.removeCustomerToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.removeCustomerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.removeCustomerToolStripMenuItem.Name = "removeCustomerToolStripMenuItem";
            this.removeCustomerToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.removeCustomerToolStripMenuItem.Text = "Remove Customer";
            // 
            // updateCustomerToolStripMenuItem
            // 
            this.updateCustomerToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.updateCustomerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateCustomerToolStripMenuItem.Name = "updateCustomerToolStripMenuItem";
            this.updateCustomerToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.updateCustomerToolStripMenuItem.Text = "Update Customer";
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
            // UpdateService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 330);
            this.Controls.Add(this.cusBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UpdateService";
            this.Text = "UpdateService";
            this.Load += new System.EventHandler(this.UpdateService_Load);
            this.cusBox.ResumeLayout(false);
            this.cusBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox cusBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameSerBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SerIDBox;
        private System.Windows.Forms.Button AddCar;
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
        private System.Windows.Forms.ToolStripMenuItem removeServiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regCustomerToolStripMenuItem;
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
        private System.Windows.Forms.TextBox priceSerBox;
        private System.Windows.Forms.ToolStripMenuItem updateCustomerToolStripMenuItem;
    }
}