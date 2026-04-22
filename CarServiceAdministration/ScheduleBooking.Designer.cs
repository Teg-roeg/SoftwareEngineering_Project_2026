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
            this.button1 = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.Label();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.mechCB = new System.Windows.Forms.ComboBox();
            this.mechID = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.serviceCB = new System.Windows.Forms.ComboBox();
            this.ServiceID = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.carCB = new System.Windows.Forms.ComboBox();
            this.carID = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cusCB = new System.Windows.Forms.ComboBox();
            this.cusID = new System.Windows.Forms.Label();
            this.bookCB = new System.Windows.Forms.ComboBox();
            this.BookID = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.scheduleBookBox.SuspendLayout();
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
            this.scheduleBookBox.Controls.Add(this.button1);
            this.scheduleBookBox.Controls.Add(this.date);
            this.scheduleBookBox.Controls.Add(this.listBox4);
            this.scheduleBookBox.Controls.Add(this.mechCB);
            this.scheduleBookBox.Controls.Add(this.mechID);
            this.scheduleBookBox.Controls.Add(this.dateTimePicker1);
            this.scheduleBookBox.Controls.Add(this.listBox3);
            this.scheduleBookBox.Controls.Add(this.serviceCB);
            this.scheduleBookBox.Controls.Add(this.ServiceID);
            this.scheduleBookBox.Controls.Add(this.listBox2);
            this.scheduleBookBox.Controls.Add(this.carCB);
            this.scheduleBookBox.Controls.Add(this.carID);
            this.scheduleBookBox.Controls.Add(this.listBox1);
            this.scheduleBookBox.Controls.Add(this.cusCB);
            this.scheduleBookBox.Controls.Add(this.cusID);
            this.scheduleBookBox.Controls.Add(this.bookCB);
            this.scheduleBookBox.Controls.Add(this.BookID);
            this.scheduleBookBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scheduleBookBox.Location = new System.Drawing.Point(18, 31);
            this.scheduleBookBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.scheduleBookBox.Name = "scheduleBookBox";
            this.scheduleBookBox.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.scheduleBookBox.Size = new System.Drawing.Size(702, 413);
            this.scheduleBookBox.TabIndex = 5;
            this.scheduleBookBox.TabStop = false;
            this.scheduleBookBox.Text = "Schedule Booking";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(419, 341);
            this.button1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 57);
            this.button1.TabIndex = 27;
            this.button1.Text = "Schedule Booking";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(16, 290);
            this.date.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(43, 18);
            this.date.TabIndex = 26;
            this.date.Text = "Date:";
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 18;
            this.listBox4.Location = new System.Drawing.Point(244, 236);
            this.listBox4.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(220, 22);
            this.listBox4.TabIndex = 25;
            // 
            // mechCB
            // 
            this.mechCB.FormattingEnabled = true;
            this.mechCB.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.mechCB.Location = new System.Drawing.Point(139, 236);
            this.mechCB.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.mechCB.Name = "mechCB";
            this.mechCB.Size = new System.Drawing.Size(83, 26);
            this.mechCB.TabIndex = 24;
            this.mechCB.SelectedIndexChanged += new System.EventHandler(this.mechCB_SelectedIndexChanged);
            // 
            // mechID
            // 
            this.mechID.AutoSize = true;
            this.mechID.Location = new System.Drawing.Point(15, 238);
            this.mechID.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.mechID.Name = "mechID";
            this.mechID.Size = new System.Drawing.Size(94, 18);
            this.mechID.TabIndex = 23;
            this.mechID.Text = "Mechanic ID:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(113, 287);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dateTimePicker1.MinDate = new System.DateTime(2025, 12, 7, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(312, 24);
            this.dateTimePicker1.TabIndex = 22;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 18;
            this.listBox3.Location = new System.Drawing.Point(244, 189);
            this.listBox3.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(187, 22);
            this.listBox3.TabIndex = 21;
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
            this.serviceCB.Location = new System.Drawing.Point(139, 189);
            this.serviceCB.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.serviceCB.Name = "serviceCB";
            this.serviceCB.Size = new System.Drawing.Size(83, 26);
            this.serviceCB.TabIndex = 20;
            this.serviceCB.SelectedIndexChanged += new System.EventHandler(this.serviceCB_SelectedIndexChanged);
            // 
            // ServiceID
            // 
            this.ServiceID.AutoSize = true;
            this.ServiceID.Location = new System.Drawing.Point(15, 189);
            this.ServiceID.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.ServiceID.Name = "ServiceID";
            this.ServiceID.Size = new System.Drawing.Size(79, 18);
            this.ServiceID.TabIndex = 19;
            this.ServiceID.Text = "Service ID:";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 18;
            this.listBox2.Location = new System.Drawing.Point(244, 144);
            this.listBox2.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(243, 22);
            this.listBox2.TabIndex = 18;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // carCB
            // 
            this.carCB.FormattingEnabled = true;
            this.carCB.Items.AddRange(new object[] {
            "4",
            "5"});
            this.carCB.Location = new System.Drawing.Point(139, 144);
            this.carCB.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.carCB.Name = "carCB";
            this.carCB.Size = new System.Drawing.Size(83, 26);
            this.carCB.TabIndex = 17;
            this.carCB.SelectedIndexChanged += new System.EventHandler(this.carCB_SelectedIndexChanged);
            // 
            // carID
            // 
            this.carID.AutoSize = true;
            this.carID.Location = new System.Drawing.Point(15, 146);
            this.carID.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.carID.Name = "carID";
            this.carID.Size = new System.Drawing.Size(54, 18);
            this.carID.TabIndex = 16;
            this.carID.Text = "Car ID:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(244, 98);
            this.listBox1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(220, 22);
            this.listBox1.TabIndex = 15;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // cusCB
            // 
            this.cusCB.FormattingEnabled = true;
            this.cusCB.Items.AddRange(new object[] {
            "2",
            "3"});
            this.cusCB.Location = new System.Drawing.Point(139, 98);
            this.cusCB.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.cusCB.Name = "cusCB";
            this.cusCB.Size = new System.Drawing.Size(83, 26);
            this.cusCB.TabIndex = 14;
            this.cusCB.SelectedIndexChanged += new System.EventHandler(this.cusCB_SelectedIndexChanged);
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
            // bookCB
            // 
            this.bookCB.FormattingEnabled = true;
            this.bookCB.Items.AddRange(new object[] {
            "1",
            "2"});
            this.bookCB.Location = new System.Drawing.Point(139, 51);
            this.bookCB.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.bookCB.Name = "bookCB";
            this.bookCB.Size = new System.Drawing.Size(83, 26);
            this.bookCB.TabIndex = 12;
            this.bookCB.SelectedIndexChanged += new System.EventHandler(this.bookCB_SelectedIndexChanged);
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
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "ScheduleBooking";
            this.Text = "ScheduleBooking";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.scheduleBookBox.ResumeLayout(false);
            this.scheduleBookBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox scheduleBookBox;
        private System.Windows.Forms.ComboBox bookCB;
        private System.Windows.Forms.Label BookID;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox cusCB;
        private System.Windows.Forms.Label cusID;
        private System.Windows.Forms.ComboBox carCB;
        private System.Windows.Forms.Label carID;
        private System.Windows.Forms.Label ServiceID;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ComboBox serviceCB;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label mechID;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.ComboBox mechCB;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Button button1;
    }
}