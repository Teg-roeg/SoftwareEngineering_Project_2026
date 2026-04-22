namespace CarServiceAdministration
{
    partial class RegCar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegCar));
            this.cusBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CusIDBox = new System.Windows.Forms.ComboBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddCar = new System.Windows.Forms.Button();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.CusPhoneNum = new System.Windows.Forms.Label();
            this.txtRegNum = new System.Windows.Forms.TextBox();
            this.CusName = new System.Windows.Forms.Label();
            this.CarIDBox = new System.Windows.Forms.TextBox();
            this.CusID = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cusBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cusBox
            // 
            this.cusBox.Controls.Add(this.label3);
            this.cusBox.Controls.Add(this.CusIDBox);
            this.cusBox.Controls.Add(this.txtYear);
            this.cusBox.Controls.Add(this.label2);
            this.cusBox.Controls.Add(this.txtModel);
            this.cusBox.Controls.Add(this.label1);
            this.cusBox.Controls.Add(this.AddCar);
            this.cusBox.Controls.Add(this.txtBrand);
            this.cusBox.Controls.Add(this.CusPhoneNum);
            this.cusBox.Controls.Add(this.txtRegNum);
            this.cusBox.Controls.Add(this.CusName);
            this.cusBox.Controls.Add(this.CarIDBox);
            this.cusBox.Controls.Add(this.CusID);
            this.cusBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusBox.Location = new System.Drawing.Point(14, 33);
            this.cusBox.Margin = new System.Windows.Forms.Padding(2);
            this.cusBox.Name = "cusBox";
            this.cusBox.Padding = new System.Windows.Forms.Padding(2);
            this.cusBox.Size = new System.Drawing.Size(529, 422);
            this.cusBox.TabIndex = 6;
            this.cusBox.TabStop = false;
            this.cusBox.Text = "Enter Car Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Customer ID:";
            // 
            // CusIDBox
            // 
            this.CusIDBox.FormattingEnabled = true;
            this.CusIDBox.Location = new System.Drawing.Point(200, 47);
            this.CusIDBox.Margin = new System.Windows.Forms.Padding(2);
            this.CusIDBox.Name = "CusIDBox";
            this.CusIDBox.Size = new System.Drawing.Size(68, 27);
            this.CusIDBox.TabIndex = 11;
            // 
            // txtYear
            // 
            this.txtYear.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtYear.Location = new System.Drawing.Point(200, 276);
            this.txtYear.Margin = new System.Windows.Forms.Padding(2);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(168, 24);
            this.txtYear.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 279);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Year:";
            // 
            // txtModel
            // 
            this.txtModel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtModel.Location = new System.Drawing.Point(200, 225);
            this.txtModel.Margin = new System.Windows.Forms.Padding(2);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(168, 24);
            this.txtModel.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 229);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Model:";
            // 
            // AddCar
            // 
            this.AddCar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.AddCar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddCar.Location = new System.Drawing.Point(293, 336);
            this.AddCar.Margin = new System.Windows.Forms.Padding(2);
            this.AddCar.Name = "AddCar";
            this.AddCar.Size = new System.Drawing.Size(215, 53);
            this.AddCar.TabIndex = 6;
            this.AddCar.Text = "Add Car";
            this.AddCar.UseVisualStyleBackColor = false;
            this.AddCar.Click += new System.EventHandler(this.AddCar_Click);
            // 
            // txtBrand
            // 
            this.txtBrand.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtBrand.Location = new System.Drawing.Point(200, 176);
            this.txtBrand.Margin = new System.Windows.Forms.Padding(2);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(168, 24);
            this.txtBrand.TabIndex = 5;
            // 
            // CusPhoneNum
            // 
            this.CusPhoneNum.AutoSize = true;
            this.CusPhoneNum.Location = new System.Drawing.Point(21, 179);
            this.CusPhoneNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CusPhoneNum.Name = "CusPhoneNum";
            this.CusPhoneNum.Size = new System.Drawing.Size(49, 20);
            this.CusPhoneNum.TabIndex = 4;
            this.CusPhoneNum.Text = "Brand";
            // 
            // txtRegNum
            // 
            this.txtRegNum.Location = new System.Drawing.Point(200, 126);
            this.txtRegNum.Margin = new System.Windows.Forms.Padding(2);
            this.txtRegNum.Name = "txtRegNum";
            this.txtRegNum.Size = new System.Drawing.Size(168, 24);
            this.txtRegNum.TabIndex = 3;
            // 
            // CusName
            // 
            this.CusName.AutoSize = true;
            this.CusName.Location = new System.Drawing.Point(21, 129);
            this.CusName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CusName.Name = "CusName";
            this.CusName.Size = new System.Drawing.Size(152, 20);
            this.CusName.TabIndex = 2;
            this.CusName.Text = "Registration Number:";
            // 
            // CarIDBox
            // 
            this.CarIDBox.Location = new System.Drawing.Point(200, 87);
            this.CarIDBox.Margin = new System.Windows.Forms.Padding(2);
            this.CarIDBox.Name = "CarIDBox";
            this.CarIDBox.Size = new System.Drawing.Size(49, 24);
            this.CarIDBox.TabIndex = 1;
            // 
            // CusID
            // 
            this.CusID.AutoSize = true;
            this.CusID.Location = new System.Drawing.Point(21, 90);
            this.CusID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CusID.Name = "CusID";
            this.CusID.Size = new System.Drawing.Size(53, 20);
            this.CusID.TabIndex = 0;
            this.CusID.Text = "Car ID:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(562, 24);
            this.menuStrip1.TabIndex = 5;
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
            // RegCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 465);
            this.Controls.Add(this.cusBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RegCar";
            this.Text = "RegCar";
            this.Load += new System.EventHandler(this.RegCar_Load);
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
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label CusPhoneNum;
        private System.Windows.Forms.TextBox txtRegNum;
        private System.Windows.Forms.Label CusName;
        private System.Windows.Forms.TextBox CarIDBox;
        private System.Windows.Forms.Label CusID;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CusIDBox;
    }
}