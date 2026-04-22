namespace CarServiceAdministration
{
    partial class RegService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegService));
            this.cusBox = new System.Windows.Forms.GroupBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.AddCar = new System.Windows.Forms.Button();
            this.CusPhoneNum = new System.Windows.Forms.Label();
            this.numSerBox = new System.Windows.Forms.TextBox();
            this.CusName = new System.Windows.Forms.Label();
            this.SerIDBox = new System.Windows.Forms.TextBox();
            this.CusID = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.euroLbl = new System.Windows.Forms.Label();
            this.cusBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cusBox
            // 
            this.cusBox.Controls.Add(this.euroLbl);
            this.cusBox.Controls.Add(this.txtPrice);
            this.cusBox.Controls.Add(this.AddCar);
            this.cusBox.Controls.Add(this.CusPhoneNum);
            this.cusBox.Controls.Add(this.numSerBox);
            this.cusBox.Controls.Add(this.CusName);
            this.cusBox.Controls.Add(this.SerIDBox);
            this.cusBox.Controls.Add(this.CusID);
            this.cusBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusBox.Location = new System.Drawing.Point(14, 25);
            this.cusBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.cusBox.Name = "cusBox";
            this.cusBox.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.cusBox.Size = new System.Drawing.Size(608, 328);
            this.cusBox.TabIndex = 8;
            this.cusBox.TabStop = false;
            this.cusBox.Text = "Enter Service Job Details";
            this.cusBox.Enter += new System.EventHandler(this.cusBox_Enter);
            // 
            // txtPrice
            // 
            this.txtPrice.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtPrice.Location = new System.Drawing.Point(199, 179);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(65, 28);
            this.txtPrice.TabIndex = 7;
            this.txtPrice.Tag = "";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // AddCar
            // 
            this.AddCar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.AddCar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddCar.Location = new System.Drawing.Point(370, 236);
            this.AddCar.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.AddCar.Name = "AddCar";
            this.AddCar.Size = new System.Drawing.Size(215, 53);
            this.AddCar.TabIndex = 6;
            this.AddCar.Text = "Add Service";
            this.AddCar.UseVisualStyleBackColor = false;
            this.AddCar.Click += new System.EventHandler(this.AddCar_Click);
            // 
            // CusPhoneNum
            // 
            this.CusPhoneNum.AutoSize = true;
            this.CusPhoneNum.Location = new System.Drawing.Point(21, 179);
            this.CusPhoneNum.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.CusPhoneNum.Name = "CusPhoneNum";
            this.CusPhoneNum.Size = new System.Drawing.Size(51, 21);
            this.CusPhoneNum.TabIndex = 4;
            this.CusPhoneNum.Text = "Price:";
            // 
            // numSerBox
            // 
            this.numSerBox.Location = new System.Drawing.Point(199, 126);
            this.numSerBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.numSerBox.Name = "numSerBox";
            this.numSerBox.Size = new System.Drawing.Size(168, 28);
            this.numSerBox.TabIndex = 3;
            // 
            // CusName
            // 
            this.CusName.AutoSize = true;
            this.CusName.Location = new System.Drawing.Point(21, 129);
            this.CusName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.CusName.Name = "CusName";
            this.CusName.Size = new System.Drawing.Size(118, 21);
            this.CusName.TabIndex = 2;
            this.CusName.Text = "Service Name:";
            // 
            // SerIDBox
            // 
            this.SerIDBox.Location = new System.Drawing.Point(199, 76);
            this.SerIDBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.SerIDBox.Name = "SerIDBox";
            this.SerIDBox.Size = new System.Drawing.Size(49, 28);
            this.SerIDBox.TabIndex = 1;
            this.SerIDBox.TextChanged += new System.EventHandler(this.txtCarID_TextChanged);
            // 
            // CusID
            // 
            this.CusID.AutoSize = true;
            this.CusID.Location = new System.Drawing.Point(21, 76);
            this.CusID.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.CusID.Name = "CusID";
            this.CusID.Size = new System.Drawing.Size(89, 21);
            this.CusID.TabIndex = 0;
            this.CusID.Text = "Service ID:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(635, 24);
            this.menuStrip1.TabIndex = 7;
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
            // euroLbl
            // 
            this.euroLbl.AutoSize = true;
            this.euroLbl.Location = new System.Drawing.Point(267, 186);
            this.euroLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.euroLbl.Name = "euroLbl";
            this.euroLbl.Size = new System.Drawing.Size(19, 21);
            this.euroLbl.TabIndex = 12;
            this.euroLbl.Text = "€";
            // 
            // RegService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 360);
            this.Controls.Add(this.cusBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "RegService";
            this.Text = "RegService";
            this.cusBox.ResumeLayout(false);
            this.cusBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox cusBox;
        private System.Windows.Forms.Button AddCar;
        private System.Windows.Forms.Label CusPhoneNum;
        private System.Windows.Forms.TextBox numSerBox;
        private System.Windows.Forms.Label CusName;
        private System.Windows.Forms.TextBox SerIDBox;
        private System.Windows.Forms.Label CusID;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label euroLbl;
    }
}