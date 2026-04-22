namespace CarServiceAdministration
{
    partial class ViewBookings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBookings));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listStatus = new System.Windows.Forms.ListBox();
            this.detailsLbl = new System.Windows.Forms.Label();
            this.BookIdLbl = new System.Windows.Forms.Label();
            this.statusLbl = new System.Windows.Forms.Label();
            this.listBookInfoBox = new System.Windows.Forms.ListBox();
            this.listBookBox = new System.Windows.Forms.ListBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(608, 24);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listStatus);
            this.groupBox1.Controls.Add(this.detailsLbl);
            this.groupBox1.Controls.Add(this.BookIdLbl);
            this.groupBox1.Controls.Add(this.statusLbl);
            this.groupBox1.Controls.Add(this.listBookInfoBox);
            this.groupBox1.Controls.Add(this.listBookBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(580, 445);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View Booking";
            // 
            // listStatus
            // 
            this.listStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listStatus.FormattingEnabled = true;
            this.listStatus.ItemHeight = 25;
            this.listStatus.Location = new System.Drawing.Point(201, 379);
            this.listStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listStatus.Name = "listStatus";
            this.listStatus.Size = new System.Drawing.Size(168, 29);
            this.listStatus.TabIndex = 5;
            this.listStatus.SelectedIndexChanged += new System.EventHandler(this.listStatus_SelectedIndexChanged);
            // 
            // detailsLbl
            // 
            this.detailsLbl.AutoSize = true;
            this.detailsLbl.Location = new System.Drawing.Point(130, 61);
            this.detailsLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.detailsLbl.Name = "detailsLbl";
            this.detailsLbl.Size = new System.Drawing.Size(79, 26);
            this.detailsLbl.TabIndex = 4;
            this.detailsLbl.Text = "Details";
            // 
            // BookIdLbl
            // 
            this.BookIdLbl.AutoSize = true;
            this.BookIdLbl.Location = new System.Drawing.Point(17, 61);
            this.BookIdLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BookIdLbl.Name = "BookIdLbl";
            this.BookIdLbl.Size = new System.Drawing.Size(90, 26);
            this.BookIdLbl.TabIndex = 3;
            this.BookIdLbl.Text = "Book ID";
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.Location = new System.Drawing.Point(130, 379);
            this.statusLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(74, 26);
            this.statusLbl.TabIndex = 2;
            this.statusLbl.Text = "Status";
            // 
            // listBookInfoBox
            // 
            this.listBookInfoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBookInfoBox.FormattingEnabled = true;
            this.listBookInfoBox.ItemHeight = 20;
            this.listBookInfoBox.Location = new System.Drawing.Point(134, 98);
            this.listBookInfoBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBookInfoBox.Name = "listBookInfoBox";
            this.listBookInfoBox.Size = new System.Drawing.Size(423, 264);
            this.listBookInfoBox.TabIndex = 1;
            this.listBookInfoBox.SelectedIndexChanged += new System.EventHandler(this.listBookInfoBox_SelectedIndexChanged);
            // 
            // listBookBox
            // 
            this.listBookBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBookBox.FormattingEnabled = true;
            this.listBookBox.ItemHeight = 25;
            this.listBookBox.Location = new System.Drawing.Point(21, 98);
            this.listBookBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBookBox.Name = "listBookBox";
            this.listBookBox.Size = new System.Drawing.Size(102, 254);
            this.listBookBox.TabIndex = 0;
            this.listBookBox.Click += new System.EventHandler(this.listBookBox_Click);
            this.listBookBox.SelectedIndexChanged += new System.EventHandler(this.listBookBox_SelectedIndexChanged);
            this.listBookBox.Leave += new System.EventHandler(this.listBookBox_Leave);
            // 
            // ViewBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 492);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ViewBookings";
            this.Text = "ViewBookings";
            this.Load += new System.EventHandler(this.ViewBookings_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBookBox;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ListBox listBookInfoBox;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.ListBox listStatus;
        private System.Windows.Forms.Label detailsLbl;
        private System.Windows.Forms.Label BookIdLbl;
    }
}