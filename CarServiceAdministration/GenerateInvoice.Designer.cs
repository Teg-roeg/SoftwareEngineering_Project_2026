namespace CarServiceAdministration
{
    partial class GenerateInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateInvoice));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gntInvBox = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.euroLbl = new System.Windows.Forms.Label();
            this.bookIDBox = new System.Windows.Forms.ComboBox();
            this.invListBox = new System.Windows.Forms.ListBox();
            this.btnGenerateInvoice = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.CusPhoneNum = new System.Windows.Forms.Label();
            this.invBookID = new System.Windows.Forms.Label();
            this.InvID = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.gntInvBox.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(576, 24);
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
            // gntInvBox
            // 
            this.gntInvBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gntInvBox.Controls.Add(this.textBox1);
            this.gntInvBox.Controls.Add(this.euroLbl);
            this.gntInvBox.Controls.Add(this.bookIDBox);
            this.gntInvBox.Controls.Add(this.invListBox);
            this.gntInvBox.Controls.Add(this.btnGenerateInvoice);
            this.gntInvBox.Controls.Add(this.txtPrice);
            this.gntInvBox.Controls.Add(this.CusPhoneNum);
            this.gntInvBox.Controls.Add(this.invBookID);
            this.gntInvBox.Controls.Add(this.InvID);
            this.gntInvBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gntInvBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gntInvBox.Location = new System.Drawing.Point(33, 32);
            this.gntInvBox.Margin = new System.Windows.Forms.Padding(2);
            this.gntInvBox.Name = "gntInvBox";
            this.gntInvBox.Padding = new System.Windows.Forms.Padding(2);
            this.gntInvBox.Size = new System.Drawing.Size(512, 400);
            this.gntInvBox.TabIndex = 5;
            this.gntInvBox.TabStop = false;
            this.gntInvBox.Text = "Generate Invoice";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 24);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // euroLbl
            // 
            this.euroLbl.AutoSize = true;
            this.euroLbl.Location = new System.Drawing.Point(442, 139);
            this.euroLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.euroLbl.Name = "euroLbl";
            this.euroLbl.Size = new System.Drawing.Size(17, 20);
            this.euroLbl.TabIndex = 11;
            this.euroLbl.Text = "€";
            // 
            // bookIDBox
            // 
            this.bookIDBox.FormattingEnabled = true;
            this.bookIDBox.Location = new System.Drawing.Point(373, 42);
            this.bookIDBox.Margin = new System.Windows.Forms.Padding(2);
            this.bookIDBox.Name = "bookIDBox";
            this.bookIDBox.Size = new System.Drawing.Size(83, 27);
            this.bookIDBox.TabIndex = 10;
            this.bookIDBox.SelectedIndexChanged += new System.EventHandler(this.bookIDBox_SelectedIndexChanged);
            // 
            // invListBox
            // 
            this.invListBox.FormattingEnabled = true;
            this.invListBox.ItemHeight = 19;
            this.invListBox.Location = new System.Drawing.Point(25, 90);
            this.invListBox.Margin = new System.Windows.Forms.Padding(2);
            this.invListBox.Name = "invListBox";
            this.invListBox.Size = new System.Drawing.Size(238, 175);
            this.invListBox.TabIndex = 9;
            this.invListBox.SelectedIndexChanged += new System.EventHandler(this.invListBox_SelectedIndexChanged);
            // 
            // btnGenerateInvoice
            // 
            this.btnGenerateInvoice.BackColor = System.Drawing.Color.Teal;
            this.btnGenerateInvoice.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateInvoice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGenerateInvoice.Location = new System.Drawing.Point(158, 308);
            this.btnGenerateInvoice.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerateInvoice.Name = "btnGenerateInvoice";
            this.btnGenerateInvoice.Size = new System.Drawing.Size(215, 53);
            this.btnGenerateInvoice.TabIndex = 6;
            this.btnGenerateInvoice.Text = "Generate Invoice";
            this.btnGenerateInvoice.UseVisualStyleBackColor = false;
            this.btnGenerateInvoice.Click += new System.EventHandler(this.btnGenerateInvoice_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.AccessibleName = "";
            this.txtPrice.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtPrice.Location = new System.Drawing.Point(373, 135);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(65, 24);
            this.txtPrice.TabIndex = 5;
            this.txtPrice.Tag = "";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CusPhoneNum
            // 
            this.CusPhoneNum.AutoSize = true;
            this.CusPhoneNum.Location = new System.Drawing.Point(285, 135);
            this.CusPhoneNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CusPhoneNum.Name = "CusPhoneNum";
            this.CusPhoneNum.Size = new System.Drawing.Size(45, 20);
            this.CusPhoneNum.TabIndex = 4;
            this.CusPhoneNum.Text = "Price:";
            this.CusPhoneNum.Click += new System.EventHandler(this.CusPhoneNum_Click);
            // 
            // invBookID
            // 
            this.invBookID.AutoSize = true;
            this.invBookID.Location = new System.Drawing.Point(285, 46);
            this.invBookID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.invBookID.Name = "invBookID";
            this.invBookID.Size = new System.Drawing.Size(88, 20);
            this.invBookID.TabIndex = 2;
            this.invBookID.Text = "Booking ID:";
            this.invBookID.Click += new System.EventHandler(this.invBookID_Click);
            // 
            // InvID
            // 
            this.InvID.AutoSize = true;
            this.InvID.Location = new System.Drawing.Point(21, 46);
            this.InvID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InvID.Name = "InvID";
            this.InvID.Size = new System.Drawing.Size(79, 20);
            this.InvID.TabIndex = 0;
            this.InvID.Text = "Invoice ID:";
            this.InvID.Click += new System.EventHandler(this.CusID_Click);
            // 
            // GenerateInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 457);
            this.Controls.Add(this.gntInvBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GenerateInvoice";
            this.Text = "GenerateInvoice";
            this.Load += new System.EventHandler(this.GenerateInvoice_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gntInvBox.ResumeLayout(false);
            this.gntInvBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox gntInvBox;
        private System.Windows.Forms.Button btnGenerateInvoice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label CusPhoneNum;
        private System.Windows.Forms.Label invBookID;
        private System.Windows.Forms.Label InvID;
        private System.Windows.Forms.ListBox invListBox;
        private System.Windows.Forms.ComboBox bookIDBox;
        private System.Windows.Forms.Label euroLbl;
        private System.Windows.Forms.TextBox textBox1;
    }
}