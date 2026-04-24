namespace CarServiceAdministration
{
    partial class ScheduleBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScheduleBooking));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleBookBox = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtBookingID = new System.Windows.Forms.TextBox();
            this.grdCars = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnScheduleBooking = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.Label();
            this.mechCB = new System.Windows.Forms.ComboBox();
            this.mechID = new System.Windows.Forms.Label();
            this.bookingDatePicker = new System.Windows.Forms.DateTimePicker();
            this.serviceCB = new System.Windows.Forms.ComboBox();
            this.ServiceID = new System.Windows.Forms.Label();
            this.cusID = new System.Windows.Forms.Label();
            this.BookID = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.scheduleBookBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCars)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(757, 24);
            this.menuStrip1.TabIndex = 4;
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
            // scheduleBookBox
            // 
            this.scheduleBookBox.Controls.Add(this.txtSearch);
            this.scheduleBookBox.Controls.Add(this.txtBookingID);
            this.scheduleBookBox.Controls.Add(this.grdCars);
            this.scheduleBookBox.Controls.Add(this.btnSearch);
            this.scheduleBookBox.Controls.Add(this.btnScheduleBooking);
            this.scheduleBookBox.Controls.Add(this.date);
            this.scheduleBookBox.Controls.Add(this.mechCB);
            this.scheduleBookBox.Controls.Add(this.mechID);
            this.scheduleBookBox.Controls.Add(this.bookingDatePicker);
            this.scheduleBookBox.Controls.Add(this.serviceCB);
            this.scheduleBookBox.Controls.Add(this.ServiceID);
            this.scheduleBookBox.Controls.Add(this.cusID);
            this.scheduleBookBox.Controls.Add(this.BookID);
            this.scheduleBookBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scheduleBookBox.Location = new System.Drawing.Point(18, 31);
            this.scheduleBookBox.Margin = new System.Windows.Forms.Padding(1);
            this.scheduleBookBox.Name = "scheduleBookBox";
            this.scheduleBookBox.Padding = new System.Windows.Forms.Padding(1);
            this.scheduleBookBox.Size = new System.Drawing.Size(702, 413);
            this.scheduleBookBox.TabIndex = 5;
            this.scheduleBookBox.TabStop = false;
            this.scheduleBookBox.Text = "Schedule Booking";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(139, 96);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(83, 24);
            this.txtSearch.TabIndex = 31;
            // 
            // txtBookingID
            // 
            this.txtBookingID.Location = new System.Drawing.Point(139, 50);
            this.txtBookingID.Name = "txtBookingID";
            this.txtBookingID.Size = new System.Drawing.Size(83, 24);
            this.txtBookingID.TabIndex = 30;
            // 
            // grdCars
            // 
            this.grdCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCars.Location = new System.Drawing.Point(18, 152);
            this.grdCars.Name = "grdCars";
            this.grdCars.Size = new System.Drawing.Size(520, 150);
            this.grdCars.TabIndex = 29;
            this.grdCars.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCars_CellClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(238, 91);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(83, 41);
            this.btnSearch.TabIndex = 28;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnScheduleBooking
            // 
            this.btnScheduleBooking.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnScheduleBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScheduleBooking.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnScheduleBooking.Location = new System.Drawing.Point(419, 341);
            this.btnScheduleBooking.Margin = new System.Windows.Forms.Padding(1);
            this.btnScheduleBooking.Name = "btnScheduleBooking";
            this.btnScheduleBooking.Size = new System.Drawing.Size(243, 57);
            this.btnScheduleBooking.TabIndex = 27;
            this.btnScheduleBooking.Text = "Schedule Booking";
            this.btnScheduleBooking.UseVisualStyleBackColor = false;
            this.btnScheduleBooking.Click += new System.EventHandler(this.btnScheduleBooking_Click);
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(15, 355);
            this.date.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(43, 18);
            this.date.TabIndex = 26;
            this.date.Text = "Date:";
            // 
            // mechCB
            // 
            this.mechCB.FormattingEnabled = true;
            this.mechCB.Location = new System.Drawing.Point(455, 91);
            this.mechCB.Margin = new System.Windows.Forms.Padding(1);
            this.mechCB.Name = "mechCB";
            this.mechCB.Size = new System.Drawing.Size(83, 26);
            this.mechCB.TabIndex = 24;
            // 
            // mechID
            // 
            this.mechID.AutoSize = true;
            this.mechID.Location = new System.Drawing.Point(352, 99);
            this.mechID.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.mechID.Name = "mechID";
            this.mechID.Size = new System.Drawing.Size(94, 18);
            this.mechID.TabIndex = 23;
            this.mechID.Text = "Mechanic ID:";
            // 
            // bookingDatePicker
            // 
            this.bookingDatePicker.Location = new System.Drawing.Point(72, 350);
            this.bookingDatePicker.Margin = new System.Windows.Forms.Padding(1);
            this.bookingDatePicker.MaxDate = new System.DateTime(2109, 12, 31, 0, 0, 0, 0);
            this.bookingDatePicker.MinDate = new System.DateTime(2026, 4, 22, 0, 0, 0, 0);
            this.bookingDatePicker.Name = "bookingDatePicker";
            this.bookingDatePicker.Size = new System.Drawing.Size(312, 24);
            this.bookingDatePicker.TabIndex = 22;
            this.bookingDatePicker.Value = new System.DateTime(2026, 4, 22, 0, 0, 0, 0);
            // 
            // serviceCB
            // 
            this.serviceCB.FormattingEnabled = true;
            this.serviceCB.Location = new System.Drawing.Point(455, 50);
            this.serviceCB.Margin = new System.Windows.Forms.Padding(1);
            this.serviceCB.Name = "serviceCB";
            this.serviceCB.Size = new System.Drawing.Size(83, 26);
            this.serviceCB.TabIndex = 20;
            // 
            // ServiceID
            // 
            this.ServiceID.AutoSize = true;
            this.ServiceID.Location = new System.Drawing.Point(352, 53);
            this.ServiceID.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.ServiceID.Name = "ServiceID";
            this.ServiceID.Size = new System.Drawing.Size(79, 18);
            this.ServiceID.TabIndex = 19;
            this.ServiceID.Text = "Service ID:";
            // 
            // cusID
            // 
            this.cusID.AutoSize = true;
            this.cusID.Location = new System.Drawing.Point(15, 99);
            this.cusID.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.cusID.Name = "cusID";
            this.cusID.Size = new System.Drawing.Size(96, 18);
            this.cusID.TabIndex = 13;
            this.cusID.Text = "Customer ID:";
            // 
            // BookID
            // 
            this.BookID.AutoSize = true;
            this.BookID.Location = new System.Drawing.Point(15, 53);
            this.BookID.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.BookID.Name = "BookID";
            this.BookID.Size = new System.Drawing.Size(85, 18);
            this.BookID.TabIndex = 11;
            this.BookID.Text = "Booking ID:";
            // 
            // ScheduleBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 450);
            this.Controls.Add(this.scheduleBookBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "ScheduleBooking";
            this.Text = "ScheduleBooking";
            this.Load += new System.EventHandler(this.ScheduleBooking_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.scheduleBookBox.ResumeLayout(false);
            this.scheduleBookBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox scheduleBookBox;
        private System.Windows.Forms.Label BookID;
        private System.Windows.Forms.Label cusID;
        private System.Windows.Forms.Label ServiceID;
        private System.Windows.Forms.ComboBox serviceCB;
        private System.Windows.Forms.DateTimePicker bookingDatePicker;
        private System.Windows.Forms.Label mechID;
        private System.Windows.Forms.ComboBox mechCB;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Button btnScheduleBooking;
        private System.Windows.Forms.DataGridView grdCars;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtBookingID;
        private System.Windows.Forms.TextBox txtSearch;
    }
}