namespace CarServiceAdministration
{
    partial class UpdateBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateBooking));
            this.cusBox = new System.Windows.Forms.GroupBox();
            this.date = new System.Windows.Forms.Label();
            this.mechCB = new System.Windows.Forms.ComboBox();
            this.mechID = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.serviceCB = new System.Windows.Forms.ComboBox();
            this.ServiceID = new System.Windows.Forms.Label();
            this.carCB = new System.Windows.Forms.ComboBox();
            this.carID = new System.Windows.Forms.Label();
            this.cusCB = new System.Windows.Forms.ComboBox();
            this.cusID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            this.updateServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.cusBox.Controls.Add(this.date);
            this.cusBox.Controls.Add(this.mechCB);
            this.cusBox.Controls.Add(this.mechID);
            this.cusBox.Controls.Add(this.dateTimePicker1);
            this.cusBox.Controls.Add(this.serviceCB);
            this.cusBox.Controls.Add(this.ServiceID);
            this.cusBox.Controls.Add(this.carCB);
            this.cusBox.Controls.Add(this.carID);
            this.cusBox.Controls.Add(this.cusCB);
            this.cusBox.Controls.Add(this.cusID);
            this.cusBox.Controls.Add(this.label1);
            this.cusBox.Controls.Add(this.comboBox1);
            this.cusBox.Controls.Add(this.AddCar);
            this.cusBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusBox.Location = new System.Drawing.Point(32, 75);
            this.cusBox.Name = "cusBox";
            this.cusBox.Size = new System.Drawing.Size(1233, 380);
            this.cusBox.TabIndex = 15;
            this.cusBox.TabStop = false;
            this.cusBox.Text = "Update Booking Details";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(44, 276);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(74, 31);
            this.date.TabIndex = 36;
            this.date.Text = "Date:";
            // 
            // mechCB
            // 
            this.mechCB.FormattingEnabled = true;
            this.mechCB.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.mechCB.Location = new System.Drawing.Point(1037, 73);
            this.mechCB.Name = "mechCB";
            this.mechCB.Size = new System.Drawing.Size(149, 38);
            this.mechCB.TabIndex = 35;
            this.mechCB.SelectedIndexChanged += new System.EventHandler(this.mechCB_SelectedIndexChanged);
            // 
            // mechID
            // 
            this.mechID.AutoSize = true;
            this.mechID.Location = new System.Drawing.Point(862, 80);
            this.mechID.Name = "mechID";
            this.mechID.Size = new System.Drawing.Size(162, 31);
            this.mechID.TabIndex = 34;
            this.mechID.Text = "Mechanic ID:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(225, 271);
            this.dateTimePicker1.MinDate = new System.DateTime(2025, 12, 7, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(569, 37);
            this.dateTimePicker1.TabIndex = 33;
            // 
            // serviceCB
            // 
            this.serviceCB.FormattingEnabled = true;
            this.serviceCB.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.serviceCB.Location = new System.Drawing.Point(617, 168);
            this.serviceCB.Name = "serviceCB";
            this.serviceCB.Size = new System.Drawing.Size(149, 38);
            this.serviceCB.TabIndex = 32;
            // 
            // ServiceID
            // 
            this.ServiceID.AutoSize = true;
            this.ServiceID.Location = new System.Drawing.Point(475, 164);
            this.ServiceID.Name = "ServiceID";
            this.ServiceID.Size = new System.Drawing.Size(134, 31);
            this.ServiceID.TabIndex = 31;
            this.ServiceID.Text = "Service ID:";
            // 
            // carCB
            // 
            this.carCB.FormattingEnabled = true;
            this.carCB.Items.AddRange(new object[] {
            "4",
            "5"});
            this.carCB.Location = new System.Drawing.Point(617, 80);
            this.carCB.Name = "carCB";
            this.carCB.Size = new System.Drawing.Size(149, 38);
            this.carCB.TabIndex = 30;
            // 
            // carID
            // 
            this.carID.AutoSize = true;
            this.carID.Location = new System.Drawing.Point(475, 87);
            this.carID.Name = "carID";
            this.carID.Size = new System.Drawing.Size(90, 31);
            this.carID.TabIndex = 29;
            this.carID.Text = "Car ID:";
            // 
            // cusCB
            // 
            this.cusCB.FormattingEnabled = true;
            this.cusCB.Items.AddRange(new object[] {
            "2",
            "3"});
            this.cusCB.Location = new System.Drawing.Point(225, 164);
            this.cusCB.Name = "cusCB";
            this.cusCB.Size = new System.Drawing.Size(149, 38);
            this.cusCB.TabIndex = 28;
            // 
            // cusID
            // 
            this.cusID.AutoSize = true;
            this.cusID.Location = new System.Drawing.Point(44, 171);
            this.cusID.Name = "cusID";
            this.cusID.Size = new System.Drawing.Size(163, 31);
            this.cusID.TabIndex = 27;
            this.cusID.Text = "Customer ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "Booking ID:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBox1.Location = new System.Drawing.Point(225, 87);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(149, 38);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // AddCar
            // 
            this.AddCar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.AddCar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddCar.Location = new System.Drawing.Point(815, 242);
            this.AddCar.Name = "AddCar";
            this.AddCar.Size = new System.Drawing.Size(394, 98);
            this.AddCar.TabIndex = 6;
            this.AddCar.Text = "Update Booking";
            this.AddCar.UseVisualStyleBackColor = false;
            this.AddCar.Click += new System.EventHandler(this.AddCar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
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
            this.menuStrip1.Size = new System.Drawing.Size(1289, 39);
            this.menuStrip1.TabIndex = 14;
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
            this.mechanicToolStripMenuItem.Size = new System.Drawing.Size(127, 31);
            this.mechanicToolStripMenuItem.Text = "Mechanic";
            // 
            // regMechanicToolStripMenuItem
            // 
            this.regMechanicToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.regMechanicToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.regMechanicToolStripMenuItem.Name = "regMechanicToolStripMenuItem";
            this.regMechanicToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.regMechanicToolStripMenuItem.Text = "Reg Mechanic";
            // 
            // updateMechanicToolStripMenuItem
            // 
            this.updateMechanicToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.updateMechanicToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateMechanicToolStripMenuItem.Name = "updateMechanicToolStripMenuItem";
            this.updateMechanicToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.updateMechanicToolStripMenuItem.Text = "Update Mechanic";
            // 
            // removeMechanicToolStripMenuItem
            // 
            this.removeMechanicToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.removeMechanicToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.removeMechanicToolStripMenuItem.Name = "removeMechanicToolStripMenuItem";
            this.removeMechanicToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
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
            this.carToolStripMenuItem.Size = new System.Drawing.Size(63, 31);
            this.carToolStripMenuItem.Text = "Car";
            // 
            // regCarToolStripMenuItem
            // 
            this.regCarToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.regCarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.regCarToolStripMenuItem.Name = "regCarToolStripMenuItem";
            this.regCarToolStripMenuItem.Size = new System.Drawing.Size(251, 40);
            this.regCarToolStripMenuItem.Text = "Reg Car";
            // 
            // updateCarToolStripMenuItem
            // 
            this.updateCarToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.updateCarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateCarToolStripMenuItem.Name = "updateCarToolStripMenuItem";
            this.updateCarToolStripMenuItem.Size = new System.Drawing.Size(251, 40);
            this.updateCarToolStripMenuItem.Text = "Update Car";
            // 
            // removeCarToolStripMenuItem
            // 
            this.removeCarToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.removeCarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.removeCarToolStripMenuItem.Name = "removeCarToolStripMenuItem";
            this.removeCarToolStripMenuItem.Size = new System.Drawing.Size(251, 40);
            this.removeCarToolStripMenuItem.Text = "Remove Car";
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
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(102, 31);
            this.customerToolStripMenuItem.Text = "Service";
            // 
            // regServiceToolStripMenuItem
            // 
            this.regServiceToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.regServiceToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.regServiceToolStripMenuItem.Name = "regServiceToolStripMenuItem";
            this.regServiceToolStripMenuItem.Size = new System.Drawing.Size(290, 40);
            this.regServiceToolStripMenuItem.Text = "Reg Service";
            // 
            // updateServiceToolStripMenuItem
            // 
            this.updateServiceToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.updateServiceToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateServiceToolStripMenuItem.Name = "updateServiceToolStripMenuItem";
            this.updateServiceToolStripMenuItem.Size = new System.Drawing.Size(290, 40);
            this.updateServiceToolStripMenuItem.Text = "Update Service";
            // 
            // removeServiceToolStripMenuItem
            // 
            this.removeServiceToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.removeServiceToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.removeServiceToolStripMenuItem.Name = "removeServiceToolStripMenuItem";
            this.removeServiceToolStripMenuItem.Size = new System.Drawing.Size(290, 40);
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
            this.serviceToolStripMenuItem.Size = new System.Drawing.Size(127, 31);
            this.serviceToolStripMenuItem.Text = "Customer";
            // 
            // regCustomerToolStripMenuItem
            // 
            this.regCustomerToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.regCustomerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.regCustomerToolStripMenuItem.Name = "regCustomerToolStripMenuItem";
            this.regCustomerToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.regCustomerToolStripMenuItem.Text = "Reg Customer";
            // 
            // removeCustomerToolStripMenuItem
            // 
            this.removeCustomerToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.removeCustomerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.removeCustomerToolStripMenuItem.Name = "removeCustomerToolStripMenuItem";
            this.removeCustomerToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.removeCustomerToolStripMenuItem.Text = "Remove Customer";
            // 
            // updateCustomerToolStripMenuItem
            // 
            this.updateCustomerToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.updateCustomerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateCustomerToolStripMenuItem.Name = "updateCustomerToolStripMenuItem";
            this.updateCustomerToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.updateCustomerToolStripMenuItem.Text = "Update Customer";
            // 
            // bookingToolStripMenuItem
            // 
            this.bookingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scheduleBookingToolStripMenuItem,
            this.cancelBookingToolStripMenuItem,
            this.viewBookingToolStripMenuItem});
            this.bookingToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bookingToolStripMenuItem.Name = "bookingToolStripMenuItem";
            this.bookingToolStripMenuItem.Size = new System.Drawing.Size(114, 31);
            this.bookingToolStripMenuItem.Text = "Booking";
            // 
            // scheduleBookingToolStripMenuItem
            // 
            this.scheduleBookingToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.scheduleBookingToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.scheduleBookingToolStripMenuItem.Name = "scheduleBookingToolStripMenuItem";
            this.scheduleBookingToolStripMenuItem.Size = new System.Drawing.Size(310, 40);
            this.scheduleBookingToolStripMenuItem.Text = "Schedule Booking";
            // 
            // cancelBookingToolStripMenuItem
            // 
            this.cancelBookingToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cancelBookingToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancelBookingToolStripMenuItem.Name = "cancelBookingToolStripMenuItem";
            this.cancelBookingToolStripMenuItem.Size = new System.Drawing.Size(310, 40);
            this.cancelBookingToolStripMenuItem.Text = "Cancel Booking";
            // 
            // viewBookingToolStripMenuItem
            // 
            this.viewBookingToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.viewBookingToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.viewBookingToolStripMenuItem.Name = "viewBookingToolStripMenuItem";
            this.viewBookingToolStripMenuItem.Size = new System.Drawing.Size(310, 40);
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
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(97, 31);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // generateInvoiceToolStripMenuItem
            // 
            this.generateInvoiceToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.generateInvoiceToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.generateInvoiceToolStripMenuItem.Name = "generateInvoiceToolStripMenuItem";
            this.generateInvoiceToolStripMenuItem.Size = new System.Drawing.Size(397, 40);
            this.generateInvoiceToolStripMenuItem.Text = "Generate Invoice";
            // 
            // recordPaymentToolStripMenuItem
            // 
            this.recordPaymentToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.recordPaymentToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.recordPaymentToolStripMenuItem.Name = "recordPaymentToolStripMenuItem";
            this.recordPaymentToolStripMenuItem.Size = new System.Drawing.Size(397, 40);
            this.recordPaymentToolStripMenuItem.Text = "Record Payment";
            // 
            // monthlyRevenueAnalysisToolStripMenuItem
            // 
            this.monthlyRevenueAnalysisToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.monthlyRevenueAnalysisToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.monthlyRevenueAnalysisToolStripMenuItem.Name = "monthlyRevenueAnalysisToolStripMenuItem";
            this.monthlyRevenueAnalysisToolStripMenuItem.Size = new System.Drawing.Size(397, 40);
            this.monthlyRevenueAnalysisToolStripMenuItem.Text = "Monthly Revenue Analysis";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 8.142858F, System.Drawing.FontStyle.Bold);
            this.exitToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(78, 31);
            this.exitToolStripMenuItem.Text = "Back";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // UpdateBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 479);
            this.Controls.Add(this.cusBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateBooking";
            this.Text = "UpdateBooking";
            this.cusBox.ResumeLayout(false);
            this.cusBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox cusBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
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
        private System.Windows.Forms.ToolStripMenuItem updateServiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeServiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateInvoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthlyRevenueAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.ComboBox mechCB;
        private System.Windows.Forms.Label mechID;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox serviceCB;
        private System.Windows.Forms.Label ServiceID;
        private System.Windows.Forms.ComboBox carCB;
        private System.Windows.Forms.Label carID;
        private System.Windows.Forms.ComboBox cusCB;
        private System.Windows.Forms.Label cusID;
    }
}