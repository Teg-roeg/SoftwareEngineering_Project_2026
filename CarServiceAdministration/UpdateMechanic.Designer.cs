namespace CarServiceAdministration
{
    partial class UpdateMechanic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateMechanic));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cusBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MechIDBox = new System.Windows.Forms.ComboBox();
            this.AddCar = new System.Windows.Forms.Button();
            this.numMechBox = new System.Windows.Forms.TextBox();
            this.CusName = new System.Windows.Forms.Label();
            this.nameMechBox = new System.Windows.Forms.TextBox();
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
            this.menuStrip1.Size = new System.Drawing.Size(554, 24);
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
            // cusBox
            // 
            this.cusBox.Controls.Add(this.label3);
            this.cusBox.Controls.Add(this.MechIDBox);
            this.cusBox.Controls.Add(this.AddCar);
            this.cusBox.Controls.Add(this.numMechBox);
            this.cusBox.Controls.Add(this.CusName);
            this.cusBox.Controls.Add(this.nameMechBox);
            this.cusBox.Controls.Add(this.CusID);
            this.cusBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusBox.Location = new System.Drawing.Point(17, 42);
            this.cusBox.Margin = new System.Windows.Forms.Padding(1);
            this.cusBox.Name = "cusBox";
            this.cusBox.Padding = new System.Windows.Forms.Padding(1);
            this.cusBox.Size = new System.Drawing.Size(523, 309);
            this.cusBox.TabIndex = 7;
            this.cusBox.TabStop = false;
            this.cusBox.Text = "Update Mechanic Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mechanic ID:";
            // 
            // MechIDBox
            // 
            this.MechIDBox.FormattingEnabled = true;
            this.MechIDBox.Location = new System.Drawing.Point(199, 47);
            this.MechIDBox.Margin = new System.Windows.Forms.Padding(1);
            this.MechIDBox.Name = "MechIDBox";
            this.MechIDBox.Size = new System.Drawing.Size(68, 27);
            this.MechIDBox.TabIndex = 11;
            this.MechIDBox.SelectedIndexChanged += new System.EventHandler(this.MechIDBox_SelectedIndexChanged);
            // 
            // AddCar
            // 
            this.AddCar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.AddCar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddCar.Location = new System.Drawing.Point(287, 226);
            this.AddCar.Margin = new System.Windows.Forms.Padding(1);
            this.AddCar.Name = "AddCar";
            this.AddCar.Size = new System.Drawing.Size(215, 53);
            this.AddCar.TabIndex = 6;
            this.AddCar.Text = "Update Mechanic";
            this.AddCar.UseVisualStyleBackColor = false;
            this.AddCar.Click += new System.EventHandler(this.AddCar_Click);
            // 
            // numMechBox
            // 
            this.numMechBox.Location = new System.Drawing.Point(199, 126);
            this.numMechBox.Margin = new System.Windows.Forms.Padding(1);
            this.numMechBox.Name = "numMechBox";
            this.numMechBox.Size = new System.Drawing.Size(168, 24);
            this.numMechBox.TabIndex = 3;
            // 
            // CusName
            // 
            this.CusName.AutoSize = true;
            this.CusName.Location = new System.Drawing.Point(21, 129);
            this.CusName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.CusName.Name = "CusName";
            this.CusName.Size = new System.Drawing.Size(115, 20);
            this.CusName.TabIndex = 2;
            this.CusName.Text = "Phone Number:";
            // 
            // nameMechBox
            // 
            this.nameMechBox.Location = new System.Drawing.Point(199, 87);
            this.nameMechBox.Margin = new System.Windows.Forms.Padding(1);
            this.nameMechBox.Name = "nameMechBox";
            this.nameMechBox.Size = new System.Drawing.Size(168, 24);
            this.nameMechBox.TabIndex = 1;
            // 
            // CusID
            // 
            this.CusID.AutoSize = true;
            this.CusID.Location = new System.Drawing.Point(21, 90);
            this.CusID.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.CusID.Name = "CusID";
            this.CusID.Size = new System.Drawing.Size(52, 20);
            this.CusID.TabIndex = 0;
            this.CusID.Text = "Name:";
            // 
            // UpdateMechanic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 367);
            this.Controls.Add(this.cusBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "UpdateMechanic";
            this.Text = "UpdateMechanic";
            this.Load += new System.EventHandler(this.UpdateMechanic_Load);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox MechIDBox;
        private System.Windows.Forms.Button AddCar;
        private System.Windows.Forms.TextBox numMechBox;
        private System.Windows.Forms.Label CusName;
        private System.Windows.Forms.TextBox nameMechBox;
        private System.Windows.Forms.Label CusID;
    }
}