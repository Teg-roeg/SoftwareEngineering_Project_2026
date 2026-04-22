namespace CarServiceAdministration
{
    partial class UpdateCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateCustomer));
            this.cusBox = new System.Windows.Forms.GroupBox();
            this.grdCustomers = new System.Windows.Forms.DataGridView();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.nameCusBox = new System.Windows.Forms.TextBox();
            this.numCusBox = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CusName = new System.Windows.Forms.Label();
            this.CusID = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cusBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cusBox
            // 
            this.cusBox.Controls.Add(this.grdCustomers);
            this.cusBox.Controls.Add(this.btnUpdateCustomer);
            this.cusBox.Controls.Add(this.btnSearch);
            this.cusBox.Controls.Add(this.nameCusBox);
            this.cusBox.Controls.Add(this.numCusBox);
            this.cusBox.Controls.Add(this.txtSearch);
            this.cusBox.Controls.Add(this.label3);
            this.cusBox.Controls.Add(this.CusName);
            this.cusBox.Controls.Add(this.CusID);
            this.cusBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusBox.Location = new System.Drawing.Point(17, 47);
            this.cusBox.Margin = new System.Windows.Forms.Padding(2);
            this.cusBox.Name = "cusBox";
            this.cusBox.Padding = new System.Windows.Forms.Padding(2);
            this.cusBox.Size = new System.Drawing.Size(656, 407);
            this.cusBox.TabIndex = 9;
            this.cusBox.TabStop = false;
            this.cusBox.Text = "Update Customer Details";
            // 
            // grdCustomers
            // 
            this.grdCustomers.AllowUserToOrderColumns = true;
            this.grdCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCustomers.Location = new System.Drawing.Point(25, 186);
            this.grdCustomers.Name = "grdCustomers";
            this.grdCustomers.Size = new System.Drawing.Size(375, 206);
            this.grdCustomers.TabIndex = 23;
            this.grdCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCustomers_CellClick);
            this.grdCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCustomers_CellContentClick_1);
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnUpdateCustomer.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCustomer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdateCustomer.Location = new System.Drawing.Point(440, 186);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(188, 63);
            this.btnUpdateCustomer.TabIndex = 22;
            this.btnUpdateCustomer.Text = "Update Customer";
            this.btnUpdateCustomer.UseVisualStyleBackColor = false;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSearch.Location = new System.Drawing.Point(401, 46);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 31);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // nameCusBox
            // 
            this.nameCusBox.Location = new System.Drawing.Point(163, 86);
            this.nameCusBox.Name = "nameCusBox";
            this.nameCusBox.Size = new System.Drawing.Size(187, 24);
            this.nameCusBox.TabIndex = 20;
            // 
            // numCusBox
            // 
            this.numCusBox.Location = new System.Drawing.Point(163, 129);
            this.numCusBox.Name = "numCusBox";
            this.numCusBox.Size = new System.Drawing.Size(187, 24);
            this.numCusBox.TabIndex = 19;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(163, 49);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(187, 24);
            this.txtSearch.TabIndex = 17;
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
            // CusName
            // 
            this.CusName.AutoSize = true;
            this.CusName.Location = new System.Drawing.Point(21, 129);
            this.CusName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CusName.Name = "CusName";
            this.CusName.Size = new System.Drawing.Size(115, 20);
            this.CusName.TabIndex = 2;
            this.CusName.Text = "Phone Number:";
            // 
            // CusID
            // 
            this.CusID.AutoSize = true;
            this.CusID.Location = new System.Drawing.Point(21, 90);
            this.CusID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CusID.Name = "CusID";
            this.CusID.Size = new System.Drawing.Size(52, 20);
            this.CusID.TabIndex = 0;
            this.CusID.Text = "Name:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(698, 24);
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
            // UpdateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 465);
            this.Controls.Add(this.cusBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UpdateCustomer";
            this.Text = "UpdateCustomer";
            this.cusBox.ResumeLayout(false);
            this.cusBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox cusBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label CusName;
        private System.Windows.Forms.Label CusID;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox nameCusBox;
        private System.Windows.Forms.TextBox numCusBox;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView grdCustomers;
    }
}