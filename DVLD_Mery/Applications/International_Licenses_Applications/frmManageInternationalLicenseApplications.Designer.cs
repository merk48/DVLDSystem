namespace DVLD_Mery
{
    partial class frmManageInternationalLicenseApplications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageInternationalLicenseApplications));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnExitManageIntLApplications = new System.Windows.Forms.Button();
            this.lnklblClearFilter = new System.Windows.Forms.LinkLabel();
            this.lblIntLApplicationsRecords = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCloseManageIntLApplications = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddNewIntLApp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvIntLApplications = new System.Windows.Forms.DataGridView();
            this.cmsIntLApp = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ShowApplicationDetailstoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowLicensetoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtIntLAppsFilter = new System.Windows.Forms.TextBox();
            this.cmbFilterIntLAppsByProperity = new System.Windows.Forms.ComboBox();
            this.panelrbIsActiveFilter = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.rdbFilterDeActive = new System.Windows.Forms.RadioButton();
            this.rdbFilterActive = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntLApplications)).BeginInit();
            this.cmsIntLApp.SuspendLayout();
            this.panelrbIsActiveFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::DVLD_Mery.Properties.Resources.InternationalLicenseImage_removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(696, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(86, 94);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 124;
            this.pictureBox2.TabStop = false;
            // 
            // btnExitManageIntLApplications
            // 
            this.btnExitManageIntLApplications.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnExitManageIntLApplications.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnExitManageIntLApplications.ForeColor = System.Drawing.Color.White;
            this.btnExitManageIntLApplications.Location = new System.Drawing.Point(1145, 9);
            this.btnExitManageIntLApplications.Name = "btnExitManageIntLApplications";
            this.btnExitManageIntLApplications.Size = new System.Drawing.Size(50, 43);
            this.btnExitManageIntLApplications.TabIndex = 123;
            this.btnExitManageIntLApplications.Text = "X";
            this.btnExitManageIntLApplications.UseVisualStyleBackColor = false;
            this.btnExitManageIntLApplications.Click += new System.EventHandler(this.btnCloseManageIntLApplications_Click);
            // 
            // lnklblClearFilter
            // 
            this.lnklblClearFilter.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.lnklblClearFilter.AutoSize = true;
            this.lnklblClearFilter.BackColor = System.Drawing.Color.Transparent;
            this.lnklblClearFilter.Font = new System.Drawing.Font("Montserrat", 8F);
            this.lnklblClearFilter.LinkColor = System.Drawing.Color.MidnightBlue;
            this.lnklblClearFilter.Location = new System.Drawing.Point(508, 186);
            this.lnklblClearFilter.Name = "lnklblClearFilter";
            this.lnklblClearFilter.Size = new System.Drawing.Size(67, 14);
            this.lnklblClearFilter.TabIndex = 120;
            this.lnklblClearFilter.TabStop = true;
            this.lnklblClearFilter.Text = "Clear Filter";
            this.lnklblClearFilter.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblClearFilter_LinkClicked);
            // 
            // lblIntLApplicationsRecords
            // 
            this.lblIntLApplicationsRecords.AutoSize = true;
            this.lblIntLApplicationsRecords.BackColor = System.Drawing.Color.Transparent;
            this.lblIntLApplicationsRecords.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.lblIntLApplicationsRecords.ForeColor = System.Drawing.Color.White;
            this.lblIntLApplicationsRecords.Location = new System.Drawing.Point(135, 589);
            this.lblIntLApplicationsRecords.Name = "lblIntLApplicationsRecords";
            this.lblIntLApplicationsRecords.Size = new System.Drawing.Size(23, 18);
            this.lblIntLApplicationsRecords.TabIndex = 119;
            this.lblIntLApplicationsRecords.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 589);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 118;
            this.label2.Text = "# Records: ";
            // 
            // btnCloseManageIntLApplications
            // 
            this.btnCloseManageIntLApplications.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCloseManageIntLApplications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseManageIntLApplications.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseManageIntLApplications.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCloseManageIntLApplications.Location = new System.Drawing.Point(1069, 576);
            this.btnCloseManageIntLApplications.Name = "btnCloseManageIntLApplications";
            this.btnCloseManageIntLApplications.Size = new System.Drawing.Size(105, 31);
            this.btnCloseManageIntLApplications.TabIndex = 117;
            this.btnCloseManageIntLApplications.Text = "Close";
            this.btnCloseManageIntLApplications.UseVisualStyleBackColor = true;
            this.btnCloseManageIntLApplications.Click += new System.EventHandler(this.btnCloseManageIntLApplications_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::DVLD_Mery.Properties.Resources.Applications;
            this.pictureBox1.Location = new System.Drawing.Point(572, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 116;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(30, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 113;
            this.label3.Text = "Filter By";
            // 
            // btnAddNewIntLApp
            // 
            this.btnAddNewIntLApp.BackColor = System.Drawing.Color.White;
            this.btnAddNewIntLApp.BackgroundImage = global::DVLD_Mery.Properties.Resources.New_Application_64;
            this.btnAddNewIntLApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddNewIntLApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewIntLApp.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnAddNewIntLApp.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnAddNewIntLApp.Location = new System.Drawing.Point(1098, 155);
            this.btnAddNewIntLApp.Name = "btnAddNewIntLApp";
            this.btnAddNewIntLApp.Size = new System.Drawing.Size(68, 45);
            this.btnAddNewIntLApp.TabIndex = 112;
            this.btnAddNewIntLApp.UseVisualStyleBackColor = false;
            this.btnAddNewIntLApp.Click += new System.EventHandler(this.btnAddNewIntLApp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montserrat", 22F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(299, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(693, 37);
            this.label1.TabIndex = 111;
            this.label1.Text = "Manage InternationalLicense Applications";
            // 
            // dgvIntLApplications
            // 
            this.dgvIntLApplications.AllowUserToAddRows = false;
            this.dgvIntLApplications.AllowUserToDeleteRows = false;
            this.dgvIntLApplications.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvIntLApplications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIntLApplications.BackgroundColor = System.Drawing.Color.White;
            this.dgvIntLApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIntLApplications.ContextMenuStrip = this.cmsIntLApp;
            this.dgvIntLApplications.Location = new System.Drawing.Point(29, 212);
            this.dgvIntLApplications.Name = "dgvIntLApplications";
            this.dgvIntLApplications.ReadOnly = true;
            this.dgvIntLApplications.Size = new System.Drawing.Size(1145, 358);
            this.dgvIntLApplications.TabIndex = 110;
            this.dgvIntLApplications.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvIntLApplications_CellMouseDoubleClick);
            // 
            // cmsIntLApp
            // 
            this.cmsIntLApp.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsIntLApp.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.cmsIntLApp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNewUserToolStripMenuItem,
            this.toolStripSeparator1,
            this.ShowApplicationDetailstoolStripMenuItem,
            this.ShowLicensetoolStripMenuItem,
            this.ShowPersonLicenseHistoryToolStripMenuItem});
            this.cmsIntLApp.Name = "cmsPerson";
            this.cmsIntLApp.Size = new System.Drawing.Size(272, 154);
            // 
            // AddNewUserToolStripMenuItem
            // 
            this.AddNewUserToolStripMenuItem.Image = global::DVLD_Mery.Properties.Resources.New_Application_64;
            this.AddNewUserToolStripMenuItem.Name = "AddNewUserToolStripMenuItem";
            this.AddNewUserToolStripMenuItem.Size = new System.Drawing.Size(271, 36);
            this.AddNewUserToolStripMenuItem.Text = "Add New Application";
            this.AddNewUserToolStripMenuItem.Click += new System.EventHandler(this.AddNewUserToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(268, 6);
            // 
            // ShowApplicationDetailstoolStripMenuItem
            // 
            this.ShowApplicationDetailstoolStripMenuItem.Image = global::DVLD_Mery.Properties.Resources.PersonDetails_32;
            this.ShowApplicationDetailstoolStripMenuItem.Name = "ShowApplicationDetailstoolStripMenuItem";
            this.ShowApplicationDetailstoolStripMenuItem.Size = new System.Drawing.Size(271, 36);
            this.ShowApplicationDetailstoolStripMenuItem.Text = "Show Person Details";
            this.ShowApplicationDetailstoolStripMenuItem.Click += new System.EventHandler(this.ShowApplicationDetailstoolStripMenuItem_Click);
            // 
            // ShowLicensetoolStripMenuItem
            // 
            this.ShowLicensetoolStripMenuItem.Image = global::DVLD_Mery.Properties.Resources.License_View_32;
            this.ShowLicensetoolStripMenuItem.Name = "ShowLicensetoolStripMenuItem";
            this.ShowLicensetoolStripMenuItem.Size = new System.Drawing.Size(271, 36);
            this.ShowLicensetoolStripMenuItem.Text = "Show License Details";
            this.ShowLicensetoolStripMenuItem.Click += new System.EventHandler(this.ShowLicensetoolStripMenuItem_Click);
            // 
            // ShowPersonLicenseHistoryToolStripMenuItem
            // 
            this.ShowPersonLicenseHistoryToolStripMenuItem.Image = global::DVLD_Mery.Properties.Resources.PersonLicenseHistory_32;
            this.ShowPersonLicenseHistoryToolStripMenuItem.Name = "ShowPersonLicenseHistoryToolStripMenuItem";
            this.ShowPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(271, 36);
            this.ShowPersonLicenseHistoryToolStripMenuItem.Text = "Show Person\'s License History";
            this.ShowPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.ShowPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // txtIntLAppsFilter
            // 
            this.txtIntLAppsFilter.Location = new System.Drawing.Point(317, 183);
            this.txtIntLAppsFilter.Name = "txtIntLAppsFilter";
            this.txtIntLAppsFilter.Size = new System.Drawing.Size(184, 20);
            this.txtIntLAppsFilter.TabIndex = 115;
            this.txtIntLAppsFilter.TextChanged += new System.EventHandler(this.txtIntLAppsFilter_TextChanged);
            this.txtIntLAppsFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIntLAppsFilter_KeyPress);
            // 
            // cmbFilterIntLAppsByProperity
            // 
            this.cmbFilterIntLAppsByProperity.AutoCompleteCustomSource.AddRange(new string[] {
            "None",
            "UserID",
            "PersonID",
            "Username",
            "Full Name",
            "Is Active"});
            this.cmbFilterIntLAppsByProperity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterIntLAppsByProperity.FormattingEnabled = true;
            this.cmbFilterIntLAppsByProperity.Items.AddRange(new object[] {
            "None",
            "IntLicenseID",
            "ApplicationID",
            "DriverID",
            "LDLicenseID",
            "IsActive"});
            this.cmbFilterIntLAppsByProperity.Location = new System.Drawing.Point(124, 182);
            this.cmbFilterIntLAppsByProperity.Name = "cmbFilterIntLAppsByProperity";
            this.cmbFilterIntLAppsByProperity.Size = new System.Drawing.Size(169, 21);
            this.cmbFilterIntLAppsByProperity.TabIndex = 114;
            this.cmbFilterIntLAppsByProperity.SelectedIndexChanged += new System.EventHandler(this.cmbFilterIntLAppsByProperity_SelectedIndexChanged);
            // 
            // panelrbIsActiveFilter
            // 
            this.panelrbIsActiveFilter.BackColor = System.Drawing.Color.Transparent;
            this.panelrbIsActiveFilter.Controls.Add(this.label13);
            this.panelrbIsActiveFilter.Controls.Add(this.rdbFilterDeActive);
            this.panelrbIsActiveFilter.Controls.Add(this.rdbFilterActive);
            this.panelrbIsActiveFilter.Location = new System.Drawing.Point(324, 176);
            this.panelrbIsActiveFilter.Name = "panelrbIsActiveFilter";
            this.panelrbIsActiveFilter.Size = new System.Drawing.Size(171, 35);
            this.panelrbIsActiveFilter.TabIndex = 125;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Image = global::DVLD_Mery.Properties.Resources.genderfemaleicon;
            this.label13.Location = new System.Drawing.Point(114, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 13);
            this.label13.TabIndex = 91;
            // 
            // rdbFilterDeActive
            // 
            this.rdbFilterDeActive.AutoSize = true;
            this.rdbFilterDeActive.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFilterDeActive.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rdbFilterDeActive.Location = new System.Drawing.Point(83, 8);
            this.rdbFilterDeActive.Name = "rdbFilterDeActive";
            this.rdbFilterDeActive.Size = new System.Drawing.Size(84, 20);
            this.rdbFilterDeActive.TabIndex = 1;
            this.rdbFilterDeActive.Text = "DeActive";
            this.rdbFilterDeActive.UseVisualStyleBackColor = true;
            this.rdbFilterDeActive.CheckedChanged += new System.EventHandler(this.rdbFilterIsActive_CheckedChanged);
            // 
            // rdbFilterActive
            // 
            this.rdbFilterActive.AutoSize = true;
            this.rdbFilterActive.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFilterActive.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rdbFilterActive.Location = new System.Drawing.Point(5, 7);
            this.rdbFilterActive.Name = "rdbFilterActive";
            this.rdbFilterActive.Size = new System.Drawing.Size(66, 20);
            this.rdbFilterActive.TabIndex = 0;
            this.rdbFilterActive.Text = "Active";
            this.rdbFilterActive.UseVisualStyleBackColor = true;
            this.rdbFilterActive.CheckedChanged += new System.EventHandler(this.rdbFilterIsActive_CheckedChanged);
            // 
            // frmManageInternationalLicenseApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DVLD_Mery.Properties.Resources.DVLDbackground1_resized;
            this.CancelButton = this.btnCloseManageIntLApplications;
            this.ClientSize = new System.Drawing.Size(1204, 616);
            this.Controls.Add(this.btnExitManageIntLApplications);
            this.Controls.Add(this.lnklblClearFilter);
            this.Controls.Add(this.lblIntLApplicationsRecords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCloseManageIntLApplications);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddNewIntLApp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvIntLApplications);
            this.Controls.Add(this.cmbFilterIntLAppsByProperity);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panelrbIsActiveFilter);
            this.Controls.Add(this.txtIntLAppsFilter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmManageInternationalLicenseApplications";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManageInternationalLicenseApplications";
            this.Load += new System.EventHandler(this.frmManageInternationalLicenseApplications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntLApplications)).EndInit();
            this.cmsIntLApp.ResumeLayout(false);
            this.panelrbIsActiveFilter.ResumeLayout(false);
            this.panelrbIsActiveFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnExitManageIntLApplications;
        private System.Windows.Forms.LinkLabel lnklblClearFilter;
        private System.Windows.Forms.Label lblIntLApplicationsRecords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCloseManageIntLApplications;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddNewIntLApp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvIntLApplications;
        private System.Windows.Forms.TextBox txtIntLAppsFilter;
        private System.Windows.Forms.ComboBox cmbFilterIntLAppsByProperity;
        private System.Windows.Forms.Panel panelrbIsActiveFilter;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton rdbFilterDeActive;
        private System.Windows.Forms.RadioButton rdbFilterActive;
        private System.Windows.Forms.ContextMenuStrip cmsIntLApp;
        private System.Windows.Forms.ToolStripMenuItem ShowApplicationDetailstoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddNewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ShowLicensetoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowPersonLicenseHistoryToolStripMenuItem;
    }
}