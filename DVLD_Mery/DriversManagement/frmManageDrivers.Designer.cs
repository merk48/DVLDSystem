namespace DVLD_Mery.DriversManagement
{
    partial class frmManageDrivers
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageDrivers));
            this.btnExitManagerDrivers = new System.Windows.Forms.Button();
            this.lnklblClearFilter = new System.Windows.Forms.LinkLabel();
            this.lblPDriversRecords = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCloseManageDrivers = new System.Windows.Forms.Button();
            this.txtDriverseFilter = new System.Windows.Forms.TextBox();
            this.cmbFilterDriversByProperity = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvDrivers = new System.Windows.Forms.DataGridView();
            this.cmsicenseHistory = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showLicenseDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ShowDriverLicesnsesHistorystoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrivers)).BeginInit();
            this.cmsicenseHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExitManagerDrivers
            // 
            this.btnExitManagerDrivers.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnExitManagerDrivers.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnExitManagerDrivers.ForeColor = System.Drawing.Color.White;
            this.btnExitManagerDrivers.Location = new System.Drawing.Point(1148, 5);
            this.btnExitManagerDrivers.Name = "btnExitManagerDrivers";
            this.btnExitManagerDrivers.Size = new System.Drawing.Size(50, 43);
            this.btnExitManagerDrivers.TabIndex = 52;
            this.btnExitManagerDrivers.Text = "X";
            this.btnExitManagerDrivers.UseVisualStyleBackColor = false;
            this.btnExitManagerDrivers.Click += new System.EventHandler(this.btnExitManagerDrivers_Click);
            // 
            // lnklblClearFilter
            // 
            this.lnklblClearFilter.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.lnklblClearFilter.AutoSize = true;
            this.lnklblClearFilter.BackColor = System.Drawing.Color.Transparent;
            this.lnklblClearFilter.Font = new System.Drawing.Font("Montserrat", 8F);
            this.lnklblClearFilter.LinkColor = System.Drawing.Color.MidnightBlue;
            this.lnklblClearFilter.Location = new System.Drawing.Point(495, 184);
            this.lnklblClearFilter.Name = "lnklblClearFilter";
            this.lnklblClearFilter.Size = new System.Drawing.Size(67, 14);
            this.lnklblClearFilter.TabIndex = 51;
            this.lnklblClearFilter.TabStop = true;
            this.lnklblClearFilter.Text = "Clear Filter";
            this.lnklblClearFilter.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblClearFilter_LinkClicked);
            // 
            // lblPDriversRecords
            // 
            this.lblPDriversRecords.AutoSize = true;
            this.lblPDriversRecords.BackColor = System.Drawing.Color.Transparent;
            this.lblPDriversRecords.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.lblPDriversRecords.ForeColor = System.Drawing.Color.White;
            this.lblPDriversRecords.Location = new System.Drawing.Point(131, 581);
            this.lblPDriversRecords.Name = "lblPDriversRecords";
            this.lblPDriversRecords.Size = new System.Drawing.Size(23, 18);
            this.lblPDriversRecords.TabIndex = 49;
            this.lblPDriversRecords.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 581);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 48;
            this.label2.Text = "# Records: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montserrat", 22F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(503, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 37);
            this.label1.TabIndex = 41;
            this.label1.Text = "Manage Drivers";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::DVLD_Mery.Properties.Resources.Driver_Main;
            this.pictureBox1.Location = new System.Drawing.Point(554, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // btnCloseManageDrivers
            // 
            this.btnCloseManageDrivers.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCloseManageDrivers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseManageDrivers.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseManageDrivers.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCloseManageDrivers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseManageDrivers.Location = new System.Drawing.Point(1069, 573);
            this.btnCloseManageDrivers.Name = "btnCloseManageDrivers";
            this.btnCloseManageDrivers.Size = new System.Drawing.Size(105, 31);
            this.btnCloseManageDrivers.TabIndex = 47;
            this.btnCloseManageDrivers.Text = "Close";
            this.btnCloseManageDrivers.UseVisualStyleBackColor = true;
            this.btnCloseManageDrivers.Click += new System.EventHandler(this.btnExitManagerDrivers_Click);
            // 
            // txtDriverseFilter
            // 
            this.txtDriverseFilter.Location = new System.Drawing.Point(307, 179);
            this.txtDriverseFilter.Name = "txtDriverseFilter";
            this.txtDriverseFilter.Size = new System.Drawing.Size(184, 20);
            this.txtDriverseFilter.TabIndex = 45;
            this.txtDriverseFilter.TextChanged += new System.EventHandler(this.txtDriverseFilter_TextChanged);
            this.txtDriverseFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDriverseFilter_KeyPress);
            // 
            // cmbFilterDriversByProperity
            // 
            this.cmbFilterDriversByProperity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterDriversByProperity.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cmbFilterDriversByProperity.FormattingEnabled = true;
            this.cmbFilterDriversByProperity.Items.AddRange(new object[] {
            "None",
            "DriverID",
            "PersonID",
            "NationalNo",
            "FullName"});
            this.cmbFilterDriversByProperity.Location = new System.Drawing.Point(120, 176);
            this.cmbFilterDriversByProperity.Name = "cmbFilterDriversByProperity";
            this.cmbFilterDriversByProperity.Size = new System.Drawing.Size(169, 21);
            this.cmbFilterDriversByProperity.TabIndex = 44;
            this.cmbFilterDriversByProperity.SelectedIndexChanged += new System.EventHandler(this.cmbFilterDriversByProperity_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(26, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 43;
            this.label3.Text = "Filter By";
            // 
            // dgvDrivers
            // 
            this.dgvDrivers.AllowUserToAddRows = false;
            this.dgvDrivers.AllowUserToDeleteRows = false;
            this.dgvDrivers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDrivers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDrivers.BackgroundColor = System.Drawing.Color.White;
            this.dgvDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDrivers.ContextMenuStrip = this.cmsicenseHistory;
            this.dgvDrivers.Location = new System.Drawing.Point(29, 209);
            this.dgvDrivers.Name = "dgvDrivers";
            this.dgvDrivers.ReadOnly = true;
            this.dgvDrivers.Size = new System.Drawing.Size(1145, 358);
            this.dgvDrivers.TabIndex = 40;
            this.dgvDrivers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDrivers_CellContentClick);
            // 
            // cmsicenseHistory
            // 
            this.cmsicenseHistory.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsicenseHistory.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.cmsicenseHistory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showLicenseDetailsToolStripMenuItem,
            this.toolStripSeparator1,
            this.ShowDriverLicesnsesHistorystoolStripMenuItem});
            this.cmsicenseHistory.Name = "cmsPerson";
            this.cmsicenseHistory.Size = new System.Drawing.Size(269, 82);
            // 
            // showLicenseDetailsToolStripMenuItem
            // 
            this.showLicenseDetailsToolStripMenuItem.Image = global::DVLD_Mery.Properties.Resources.PersonDetails_321;
            this.showLicenseDetailsToolStripMenuItem.Name = "showLicenseDetailsToolStripMenuItem";
            this.showLicenseDetailsToolStripMenuItem.Size = new System.Drawing.Size(268, 36);
            this.showLicenseDetailsToolStripMenuItem.Text = "Show Person Details";
            this.showLicenseDetailsToolStripMenuItem.Click += new System.EventHandler(this.showLicenseDetailsToolStripMenuItem_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(265, 6);
            // 
            // ShowDriverLicesnsesHistorystoolStripMenuItem
            // 
            this.ShowDriverLicesnsesHistorystoolStripMenuItem.Image = global::DVLD_Mery.Properties.Resources.PersonLicenseHistory_321;
            this.ShowDriverLicesnsesHistorystoolStripMenuItem.Name = "ShowDriverLicesnsesHistorystoolStripMenuItem";
            this.ShowDriverLicesnsesHistorystoolStripMenuItem.Size = new System.Drawing.Size(268, 36);
            this.ShowDriverLicesnsesHistorystoolStripMenuItem.Text = "Show Driver Licesnses History";
            this.ShowDriverLicesnsesHistorystoolStripMenuItem.Click += new System.EventHandler(this.ShowLicenseDetailstoolStripMenuItem_Click);
            // 
            // frmManageDrivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DVLD_Mery.Properties.Resources.DVLDbackground1_resized;
            this.CancelButton = this.btnCloseManageDrivers;
            this.ClientSize = new System.Drawing.Size(1204, 616);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExitManagerDrivers);
            this.Controls.Add(this.lnklblClearFilter);
            this.Controls.Add(this.lblPDriversRecords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCloseManageDrivers);
            this.Controls.Add(this.txtDriverseFilter);
            this.Controls.Add(this.cmbFilterDriversByProperity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvDrivers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmManageDrivers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManageDrivers";
            this.Load += new System.EventHandler(this.frmManageDrivers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrivers)).EndInit();
            this.cmsicenseHistory.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExitManagerDrivers;
        private System.Windows.Forms.LinkLabel lnklblClearFilter;
        private System.Windows.Forms.Label lblPDriversRecords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCloseManageDrivers;
        private System.Windows.Forms.TextBox txtDriverseFilter;
        private System.Windows.Forms.ComboBox cmbFilterDriversByProperity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvDrivers;
        private System.Windows.Forms.ContextMenuStrip cmsicenseHistory;
        private System.Windows.Forms.ToolStripMenuItem ShowDriverLicesnsesHistorystoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}