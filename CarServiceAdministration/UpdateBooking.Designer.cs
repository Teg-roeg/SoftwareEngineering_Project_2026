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
            this.cusBox.Location = new System.Drawing.Point(17, 41);
            this.cusBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cusBox.Name = "cusBox";
            this.cusBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cusBox.Size = new System.Drawing.Size(673, 206);
            this.cusBox.TabIndex = 15;
            this.cusBox.TabStop = false;
            this.cusBox.Text = "Update Booking Details";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(24, 150);
            this.date.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(44, 20);
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
            this.mechCB.Location = new System.Drawing.Point(566, 40);
            this.mechCB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mechCB.Name = "mechCB";
            this.mechCB.Size = new System.Drawing.Size(83, 27);
            this.mechCB.TabIndex = 35;
            this.mechCB.SelectedIndexChanged += new System.EventHandler(this.mechCB_SelectedIndexChanged);
            // 
            // mechID
            // 
            this.mechID.AutoSize = true;
            this.mechID.Location = new System.Drawing.Point(470, 43);
            this.mechID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mechID.Name = "mechID";
            this.mechID.Size = new System.Drawing.Size(97, 20);
            this.mechID.TabIndex = 34;
            this.mechID.Text = "Mechanic ID:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(123, 147);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.MinDate = new System.DateTime(2025, 12, 7, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(312, 24);
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
            this.serviceCB.Location = new System.Drawing.Point(337, 91);
            this.serviceCB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.serviceCB.Name = "serviceCB";
            this.serviceCB.Size = new System.Drawing.Size(83, 27);
            this.serviceCB.TabIndex = 32;
            // 
            // ServiceID
            // 
            this.ServiceID.AutoSize = true;
            this.ServiceID.Location = new System.Drawing.Point(259, 89);
            this.ServiceID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ServiceID.Name = "ServiceID";
            this.ServiceID.Size = new System.Drawing.Size(78, 20);
            this.ServiceID.TabIndex = 31;
            this.ServiceID.Text = "Service ID:";
            // 
            // carCB
            // 
            this.carCB.FormattingEnabled = true;
            this.carCB.Items.AddRange(new object[] {
            "4",
            "5"});
            this.carCB.Location = new System.Drawing.Point(337, 43);
            this.carCB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.carCB.Name = "carCB";
            this.carCB.Size = new System.Drawing.Size(83, 27);
            this.carCB.TabIndex = 30;
            // 
            // carID
            // 
            this.carID.AutoSize = true;
            this.carID.Location = new System.Drawing.Point(259, 47);
            this.carID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.carID.Name = "carID";
            this.carID.Size = new System.Drawing.Size(53, 20);
            this.carID.TabIndex = 29;
            this.carID.Text = "Car ID:";
            // 
            // cusCB
            // 
            this.cusCB.FormattingEnabled = true;
            this.cusCB.Items.AddRange(new object[] {
            "2",
            "3"});
            this.cusCB.Location = new System.Drawing.Point(123, 89);
            this.cusCB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cusCB.Name = "cusCB";
            this.cusCB.Size = new System.Drawing.Size(83, 27);
            this.cusCB.TabIndex = 28;
            // 
            // cusID
            // 
            this.cusID.AutoSize = true;
            this.cusID.Location = new System.Drawing.Point(24, 93);
            this.cusID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cusID.Name = "cusID";
            this.cusID.Size = new System.Drawing.Size(95, 20);
            this.cusID.TabIndex = 27;
            this.cusID.Text = "Customer ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Booking ID:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBox1.Location = new System.Drawing.Point(123, 47);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(83, 27);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // AddCar
            // 
            this.AddCar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.AddCar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddCar.Location = new System.Drawing.Point(445, 131);
            this.AddCar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddCar.Name = "AddCar";
            this.AddCar.Size = new System.Drawing.Size(215, 53);
            this.AddCar.TabIndex = 6;
            this.AddCar.Text = "Update Booking";
            this.AddCar.UseVisualStyleBackColor = false;
            this.AddCar.Click += new System.EventHandler(this.AddCar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(703, 24);
            this.menuStrip1.TabIndex = 14;
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
            // UpdateBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 259);
            this.Controls.Add(this.cusBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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