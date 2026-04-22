namespace CarServiceAdministration
{
    partial class RemoveCar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveCar));
            this.carBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listCarBox = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.RmvCar = new System.Windows.Forms.Button();
            this.CarID = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // carBox
            // 
            this.carBox.Controls.Add(this.button1);
            this.carBox.Controls.Add(this.listCarBox);
            this.carBox.Controls.Add(this.comboBox1);
            this.carBox.Controls.Add(this.RmvCar);
            this.carBox.Controls.Add(this.CarID);
            this.carBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carBox.Location = new System.Drawing.Point(13, 26);
            this.carBox.Margin = new System.Windows.Forms.Padding(2);
            this.carBox.Name = "carBox";
            this.carBox.Padding = new System.Windows.Forms.Padding(2);
            this.carBox.Size = new System.Drawing.Size(579, 299);
            this.carBox.TabIndex = 9;
            this.carBox.TabStop = false;
            this.carBox.Text = "Remove Car Details ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(25, 192);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 53);
            this.button1.TabIndex = 14;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listCarBox
            // 
            this.listCarBox.FormattingEnabled = true;
            this.listCarBox.ItemHeight = 19;
            this.listCarBox.Location = new System.Drawing.Point(243, 44);
            this.listCarBox.Margin = new System.Windows.Forms.Padding(2);
            this.listCarBox.Name = "listCarBox";
            this.listCarBox.Size = new System.Drawing.Size(314, 118);
            this.listCarBox.TabIndex = 13;
            this.listCarBox.SelectedIndexChanged += new System.EventHandler(this.listCarBox_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(141, 44);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(83, 27);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.CarIDBox_SelectedIndexChanged);
            // 
            // RmvCar
            // 
            this.RmvCar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.RmvCar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RmvCar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RmvCar.Location = new System.Drawing.Point(340, 192);
            this.RmvCar.Margin = new System.Windows.Forms.Padding(2);
            this.RmvCar.Name = "RmvCar";
            this.RmvCar.Size = new System.Drawing.Size(215, 53);
            this.RmvCar.TabIndex = 6;
            this.RmvCar.Text = "Remove Car";
            this.RmvCar.UseVisualStyleBackColor = false;
            this.RmvCar.Click += new System.EventHandler(this.RmvCar_Click_1);
            // 
            // CarID
            // 
            this.CarID.AutoSize = true;
            this.CarID.Location = new System.Drawing.Point(21, 46);
            this.CarID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CarID.Name = "CarID";
            this.CarID.Size = new System.Drawing.Size(53, 20);
            this.CarID.TabIndex = 0;
            this.CarID.Text = "Car ID:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(606, 24);
            this.menuStrip1.TabIndex = 8;
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
            // RemoveCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 344);
            this.Controls.Add(this.carBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RemoveCar";
            this.Text = "RemoveCar";
            this.Load += new System.EventHandler(this.RemoveCar_Load);
            this.carBox.ResumeLayout(false);
            this.carBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox carBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listCarBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button RmvCar;
        private System.Windows.Forms.Label CarID;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}