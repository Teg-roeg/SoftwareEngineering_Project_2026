namespace CarServiceAdministration
{
    partial class RegCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegCustomer));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cusBox = new System.Windows.Forms.GroupBox();
            this.addCustomer = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.CusPhoneNum = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.CusName = new System.Windows.Forms.Label();
            this.txtCusID = new System.Windows.Forms.TextBox();
            this.CusID = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.cusBox.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(547, 24);
            this.menuStrip1.TabIndex = 3;
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
            // cusBox
            // 
            this.cusBox.Controls.Add(this.addCustomer);
            this.cusBox.Controls.Add(this.txtPhone);
            this.cusBox.Controls.Add(this.CusPhoneNum);
            this.cusBox.Controls.Add(this.txtName);
            this.cusBox.Controls.Add(this.CusName);
            this.cusBox.Controls.Add(this.txtCusID);
            this.cusBox.Controls.Add(this.CusID);
            this.cusBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusBox.Location = new System.Drawing.Point(14, 30);
            this.cusBox.Margin = new System.Windows.Forms.Padding(2);
            this.cusBox.Name = "cusBox";
            this.cusBox.Padding = new System.Windows.Forms.Padding(2);
            this.cusBox.Size = new System.Drawing.Size(518, 400);
            this.cusBox.TabIndex = 4;
            this.cusBox.TabStop = false;
            this.cusBox.Text = "Enter Customer Details";
            // 
            // addCustomer
            // 
            this.addCustomer.BackColor = System.Drawing.SystemColors.HotTrack;
            this.addCustomer.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addCustomer.Location = new System.Drawing.Point(293, 336);
            this.addCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.addCustomer.Name = "addCustomer";
            this.addCustomer.Size = new System.Drawing.Size(215, 53);
            this.addCustomer.TabIndex = 6;
            this.addCustomer.Text = "Add Customer";
            this.addCustomer.UseVisualStyleBackColor = false;
            this.addCustomer.Click += new System.EventHandler(this.addCustomer_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtPhone.Location = new System.Drawing.Point(141, 145);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(168, 24);
            this.txtPhone.TabIndex = 5;
            // 
            // CusPhoneNum
            // 
            this.CusPhoneNum.AutoSize = true;
            this.CusPhoneNum.Location = new System.Drawing.Point(21, 146);
            this.CusPhoneNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CusPhoneNum.Name = "CusPhoneNum";
            this.CusPhoneNum.Size = new System.Drawing.Size(115, 20);
            this.CusPhoneNum.TabIndex = 4;
            this.CusPhoneNum.Text = "Phone Number:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(141, 93);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(168, 24);
            this.txtName.TabIndex = 3;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // CusName
            // 
            this.CusName.AutoSize = true;
            this.CusName.Location = new System.Drawing.Point(21, 96);
            this.CusName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CusName.Name = "CusName";
            this.CusName.Size = new System.Drawing.Size(52, 20);
            this.CusName.TabIndex = 2;
            this.CusName.Text = "Name:";
            // 
            // txtCusID
            // 
            this.txtCusID.Location = new System.Drawing.Point(141, 44);
            this.txtCusID.Margin = new System.Windows.Forms.Padding(2);
            this.txtCusID.Name = "txtCusID";
            this.txtCusID.Size = new System.Drawing.Size(49, 24);
            this.txtCusID.TabIndex = 1;
            // 
            // CusID
            // 
            this.CusID.AutoSize = true;
            this.CusID.Location = new System.Drawing.Point(21, 46);
            this.CusID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CusID.Name = "CusID";
            this.CusID.Size = new System.Drawing.Size(95, 20);
            this.CusID.TabIndex = 0;
            this.CusID.Text = "Customer ID:";
            this.CusID.Click += new System.EventHandler(this.label1_Click);
            // 
            // RegCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 446);
            this.Controls.Add(this.cusBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RegCustomer";
            this.Text = "RegCustomer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.cusBox.ResumeLayout(false);
            this.cusBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox cusBox;
        private System.Windows.Forms.Label CusID;
        private System.Windows.Forms.TextBox txtCusID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label CusName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label CusPhoneNum;
        private System.Windows.Forms.Button addCustomer;
    }
}