namespace CarServiceAdministration
{
    partial class UpdateCar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateCar));
            this.cusBox = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.grdCars = new System.Windows.Forms.DataGridView();
            this.yearBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.modelBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdateCar = new System.Windows.Forms.Button();
            this.brandBox = new System.Windows.Forms.TextBox();
            this.CusName = new System.Windows.Forms.Label();
            this.regNumBox = new System.Windows.Forms.TextBox();
            this.CusID = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cusBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCars)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cusBox
            // 
            this.cusBox.Controls.Add(this.btnSearch);
            this.cusBox.Controls.Add(this.label3);
            this.cusBox.Controls.Add(this.txtSearch);
            this.cusBox.Controls.Add(this.grdCars);
            this.cusBox.Controls.Add(this.yearBox);
            this.cusBox.Controls.Add(this.label2);
            this.cusBox.Controls.Add(this.modelBox);
            this.cusBox.Controls.Add(this.label1);
            this.cusBox.Controls.Add(this.btnUpdateCar);
            this.cusBox.Controls.Add(this.brandBox);
            this.cusBox.Controls.Add(this.CusName);
            this.cusBox.Controls.Add(this.regNumBox);
            this.cusBox.Controls.Add(this.CusID);
            this.cusBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusBox.Location = new System.Drawing.Point(17, 26);
            this.cusBox.Margin = new System.Windows.Forms.Padding(2);
            this.cusBox.Name = "cusBox";
            this.cusBox.Padding = new System.Windows.Forms.Padding(2);
            this.cusBox.Size = new System.Drawing.Size(598, 411);
            this.cusBox.TabIndex = 11;
            this.cusBox.TabStop = false;
            this.cusBox.Text = "Update Car Details";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(419, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(155, 30);
            this.btnSearch.TabIndex = 24;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Model:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(273, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 24);
            this.txtSearch.TabIndex = 20;
            // 
            // grdCars
            // 
            this.grdCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCars.Location = new System.Drawing.Point(25, 152);
            this.grdCars.Name = "grdCars";
            this.grdCars.Size = new System.Drawing.Size(549, 150);
            this.grdCars.TabIndex = 19;
            this.grdCars.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCars_CellClick);
            // 
            // yearBox
            // 
            this.yearBox.Location = new System.Drawing.Point(419, 99);
            this.yearBox.Margin = new System.Windows.Forms.Padding(2);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(49, 24);
            this.yearBox.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(366, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Year:";
            // 
            // modelBox
            // 
            this.modelBox.Location = new System.Drawing.Point(419, 66);
            this.modelBox.Margin = new System.Windows.Forms.Padding(2);
            this.modelBox.Name = "modelBox";
            this.modelBox.Size = new System.Drawing.Size(155, 24);
            this.modelBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Customer ID:";
            // 
            // btnUpdateCar
            // 
            this.btnUpdateCar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnUpdateCar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdateCar.Location = new System.Drawing.Point(192, 327);
            this.btnUpdateCar.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateCar.Name = "btnUpdateCar";
            this.btnUpdateCar.Size = new System.Drawing.Size(215, 53);
            this.btnUpdateCar.TabIndex = 6;
            this.btnUpdateCar.Text = "Update Car";
            this.btnUpdateCar.UseVisualStyleBackColor = false;
            this.btnUpdateCar.Click += new System.EventHandler(this.btnUpdateCar_Click);
            // 
            // brandBox
            // 
            this.brandBox.Location = new System.Drawing.Point(177, 96);
            this.brandBox.Margin = new System.Windows.Forms.Padding(2);
            this.brandBox.Name = "brandBox";
            this.brandBox.Size = new System.Drawing.Size(168, 24);
            this.brandBox.TabIndex = 3;
            // 
            // CusName
            // 
            this.CusName.AutoSize = true;
            this.CusName.Location = new System.Drawing.Point(21, 62);
            this.CusName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CusName.Name = "CusName";
            this.CusName.Size = new System.Drawing.Size(152, 20);
            this.CusName.TabIndex = 2;
            this.CusName.Text = "Registration Number:";
            // 
            // regNumBox
            // 
            this.regNumBox.Location = new System.Drawing.Point(177, 62);
            this.regNumBox.Name = "regNumBox";
            this.regNumBox.Size = new System.Drawing.Size(100, 24);
            this.regNumBox.TabIndex = 22;
            // 
            // CusID
            // 
            this.CusID.AutoSize = true;
            this.CusID.Location = new System.Drawing.Point(121, 96);
            this.CusID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CusID.Name = "CusID";
            this.CusID.Size = new System.Drawing.Size(52, 20);
            this.CusID.TabIndex = 0;
            this.CusID.Text = "Brand:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(664, 24);
            this.menuStrip1.TabIndex = 15;
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
            // UpdateCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 452);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.cusBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UpdateCar";
            this.Text = "UpdateCar";
            this.Load += new System.EventHandler(this.UpdateCar_Load);
            this.cusBox.ResumeLayout(false);
            this.cusBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCars)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox cusBox;
        private System.Windows.Forms.TextBox modelBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdateCar;
        private System.Windows.Forms.TextBox brandBox;
        private System.Windows.Forms.Label CusName;
        private System.Windows.Forms.TextBox regNumBox;
        private System.Windows.Forms.Label CusID;
        private System.Windows.Forms.TextBox yearBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grdCars;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnSearch;
    }
}