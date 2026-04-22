namespace CarServiceAdministration
{
    partial class RemoveBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveBooking));
            this.bookBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBookBox = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.RmvBooking = new System.Windows.Forms.Button();
            this.MechID = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bookBox
            // 
            this.bookBox.Controls.Add(this.button1);
            this.bookBox.Controls.Add(this.listBookBox);
            this.bookBox.Controls.Add(this.comboBox1);
            this.bookBox.Controls.Add(this.RmvBooking);
            this.bookBox.Controls.Add(this.MechID);
            this.bookBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookBox.Location = new System.Drawing.Point(13, 38);
            this.bookBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bookBox.Name = "bookBox";
            this.bookBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bookBox.Size = new System.Drawing.Size(620, 340);
            this.bookBox.TabIndex = 11;
            this.bookBox.TabStop = false;
            this.bookBox.Text = "Cancel Booking Details ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(25, 241);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 53);
            this.button1.TabIndex = 14;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBookBox
            // 
            this.listBookBox.FormattingEnabled = true;
            this.listBookBox.ItemHeight = 19;
            this.listBookBox.Location = new System.Drawing.Point(243, 44);
            this.listBookBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBookBox.Name = "listBookBox";
            this.listBookBox.Size = new System.Drawing.Size(343, 118);
            this.listBookBox.TabIndex = 13;
            this.listBookBox.SelectedIndexChanged += new System.EventHandler(this.listCusBox_SelectedIndexChanged);
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
            // RmvBooking
            // 
            this.RmvBooking.BackColor = System.Drawing.SystemColors.HotTrack;
            this.RmvBooking.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RmvBooking.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RmvBooking.Location = new System.Drawing.Point(370, 241);
            this.RmvBooking.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RmvBooking.Name = "RmvBooking";
            this.RmvBooking.Size = new System.Drawing.Size(215, 53);
            this.RmvBooking.TabIndex = 6;
            this.RmvBooking.Text = "Remove Booking";
            this.RmvBooking.UseVisualStyleBackColor = false;
            this.RmvBooking.Click += new System.EventHandler(this.RmvBooking_Click);
            // 
            // MechID
            // 
            this.MechID.AutoSize = true;
            this.MechID.Location = new System.Drawing.Point(21, 46);
            this.MechID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MechID.Name = "MechID";
            this.MechID.Size = new System.Drawing.Size(88, 20);
            this.MechID.TabIndex = 0;
            this.MechID.Text = "Booking ID:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(652, 24);
            this.menuStrip1.TabIndex = 10;
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
            // RemoveBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 394);
            this.Controls.Add(this.bookBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RemoveBooking";
            this.Text = "RemoveBooking";
            this.Load += new System.EventHandler(this.RemoveBooking_Load);
            this.bookBox.ResumeLayout(false);
            this.bookBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox bookBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBookBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button RmvBooking;
        private System.Windows.Forms.Label MechID;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}