namespace CarServiceAdministration
{
    partial class UpdateService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateService));
            this.cusBox = new System.Windows.Forms.GroupBox();
            this.priceSerBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameSerBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SerIDBox = new System.Windows.Forms.ComboBox();
            this.AddCar = new System.Windows.Forms.Button();
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
            this.cusBox.Controls.Add(this.priceSerBox);
            this.cusBox.Controls.Add(this.label2);
            this.cusBox.Controls.Add(this.nameSerBox);
            this.cusBox.Controls.Add(this.label4);
            this.cusBox.Controls.Add(this.label1);
            this.cusBox.Controls.Add(this.SerIDBox);
            this.cusBox.Controls.Add(this.AddCar);
            this.cusBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusBox.Location = new System.Drawing.Point(17, 46);
            this.cusBox.Margin = new System.Windows.Forms.Padding(2);
            this.cusBox.Name = "cusBox";
            this.cusBox.Padding = new System.Windows.Forms.Padding(2);
            this.cusBox.Size = new System.Drawing.Size(523, 275);
            this.cusBox.TabIndex = 13;
            this.cusBox.TabStop = false;
            this.cusBox.Text = "Update Car Details";
            // 
            // priceSerBox
            // 
            this.priceSerBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.priceSerBox.Location = new System.Drawing.Point(200, 128);
            this.priceSerBox.Margin = new System.Windows.Forms.Padding(2);
            this.priceSerBox.Name = "priceSerBox";
            this.priceSerBox.Size = new System.Drawing.Size(65, 24);
            this.priceSerBox.TabIndex = 18;
            this.priceSerBox.Tag = "";
            this.priceSerBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Price:";
            // 
            // nameSerBox
            // 
            this.nameSerBox.Location = new System.Drawing.Point(200, 89);
            this.nameSerBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameSerBox.Name = "nameSerBox";
            this.nameSerBox.Size = new System.Drawing.Size(168, 24);
            this.nameSerBox.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Service Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Service ID:";
            // 
            // SerIDBox
            // 
            this.SerIDBox.FormattingEnabled = true;
            this.SerIDBox.Location = new System.Drawing.Point(200, 47);
            this.SerIDBox.Margin = new System.Windows.Forms.Padding(2);
            this.SerIDBox.Name = "SerIDBox";
            this.SerIDBox.Size = new System.Drawing.Size(68, 27);
            this.SerIDBox.TabIndex = 11;
            this.SerIDBox.SelectedIndexChanged += new System.EventHandler(this.SerIDBox_SelectedIndexChanged);
            // 
            // AddCar
            // 
            this.AddCar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.AddCar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddCar.Location = new System.Drawing.Point(289, 198);
            this.AddCar.Margin = new System.Windows.Forms.Padding(2);
            this.AddCar.Name = "AddCar";
            this.AddCar.Size = new System.Drawing.Size(215, 53);
            this.AddCar.TabIndex = 6;
            this.AddCar.Text = "Update Service";
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
            this.menuStrip1.Size = new System.Drawing.Size(558, 24);
            this.menuStrip1.TabIndex = 12;
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
            this.euroLbl.Location = new System.Drawing.Point(269, 132);
            this.euroLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.euroLbl.Name = "euroLbl";
            this.euroLbl.Size = new System.Drawing.Size(17, 20);
            this.euroLbl.TabIndex = 14;
            this.euroLbl.Text = "€";
            // 
            // UpdateService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 330);
            this.Controls.Add(this.cusBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UpdateService";
            this.Text = "UpdateService";
            this.Load += new System.EventHandler(this.UpdateService_Load);
            this.cusBox.ResumeLayout(false);
            this.cusBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox cusBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameSerBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SerIDBox;
        private System.Windows.Forms.Button AddCar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox priceSerBox;
        private System.Windows.Forms.Label euroLbl;
    }
}