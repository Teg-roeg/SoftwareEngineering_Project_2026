namespace CarServiceAdministration
{
    partial class RegMechanic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegMechanic));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mechBox = new System.Windows.Forms.GroupBox();
            this.AddMechanic = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCusID = new System.Windows.Forms.TextBox();
            this.MechID = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.mechBox.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(563, 24);
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
            // mechBox
            // 
            this.mechBox.Controls.Add(this.AddMechanic);
            this.mechBox.Controls.Add(this.txtPhone);
            this.mechBox.Controls.Add(this.label3);
            this.mechBox.Controls.Add(this.txtName);
            this.mechBox.Controls.Add(this.label2);
            this.mechBox.Controls.Add(this.txtCusID);
            this.mechBox.Controls.Add(this.MechID);
            this.mechBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mechBox.Location = new System.Drawing.Point(13, 30);
            this.mechBox.Margin = new System.Windows.Forms.Padding(2);
            this.mechBox.Name = "mechBox";
            this.mechBox.Padding = new System.Windows.Forms.Padding(2);
            this.mechBox.Size = new System.Drawing.Size(533, 367);
            this.mechBox.TabIndex = 5;
            this.mechBox.TabStop = false;
            this.mechBox.Text = "Enter Mechanic Details";
            // 
            // AddMechanic
            // 
            this.AddMechanic.BackColor = System.Drawing.SystemColors.HotTrack;
            this.AddMechanic.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMechanic.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddMechanic.Location = new System.Drawing.Point(293, 272);
            this.AddMechanic.Margin = new System.Windows.Forms.Padding(2);
            this.AddMechanic.Name = "AddMechanic";
            this.AddMechanic.Size = new System.Drawing.Size(215, 53);
            this.AddMechanic.TabIndex = 6;
            this.AddMechanic.Text = "Add Mechanic";
            this.AddMechanic.UseVisualStyleBackColor = false;
            this.AddMechanic.Click += new System.EventHandler(this.AddMechanic_Click);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phone Number:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(141, 93);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(168, 24);
            this.txtName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mechanic Name:";
            // 
            // txtCusID
            // 
            this.txtCusID.Location = new System.Drawing.Point(141, 44);
            this.txtCusID.Margin = new System.Windows.Forms.Padding(2);
            this.txtCusID.Name = "txtCusID";
            this.txtCusID.Size = new System.Drawing.Size(49, 24);
            this.txtCusID.TabIndex = 1;
            // 
            // MechID
            // 
            this.MechID.AutoSize = true;
            this.MechID.Location = new System.Drawing.Point(21, 46);
            this.MechID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MechID.Name = "MechID";
            this.MechID.Size = new System.Drawing.Size(97, 20);
            this.MechID.TabIndex = 0;
            this.MechID.Text = "Mechanic ID:";
            // 
            // RegMechanic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 415);
            this.Controls.Add(this.mechBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RegMechanic";
            this.Text = "RegMechanic";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mechBox.ResumeLayout(false);
            this.mechBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox mechBox;
        private System.Windows.Forms.Button AddMechanic;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCusID;
        private System.Windows.Forms.Label MechID;
    }
}