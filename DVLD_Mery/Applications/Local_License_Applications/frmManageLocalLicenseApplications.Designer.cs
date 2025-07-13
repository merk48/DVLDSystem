namespace DVLD_Mery
{
    partial class frmManageLocalLicenseApplications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageLocalLicenseApplications));
            this.lnklblClearFilter = new System.Windows.Forms.LinkLabel();
            this.lblLDLApplicationsRecords = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCloseManageLocalLicenseApplications = new System.Windows.Forms.Button();
            this.txtLDLAppsFilter = new System.Windows.Forms.TextBox();
            this.cmbFilterLDLAppsByProperity = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLDLApplications = new System.Windows.Forms.DataGridView();
            this.cmsLDLApp = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowApplicationDetailstoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.EdittoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeletetoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CancelApplicationtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ScheduleTestsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleVisionTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleWrittenTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleStreetTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.IssueDrivingLicenseFTtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.ShowLicensetoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.ShowPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbLicenseClasses = new System.Windows.Forms.ComboBox();
            this.cmbLDLAppStatus = new System.Windows.Forms.ComboBox();
            this.btnExitManageLocalLicenseApplications = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnAddNewLDLApp = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLDLApplications)).BeginInit();
            this.cmsLDLApp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lnklblClearFilter
            // 
            this.lnklblClearFilter.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.lnklblClearFilter.AutoSize = true;
            this.lnklblClearFilter.BackColor = System.Drawing.Color.Transparent;
            this.lnklblClearFilter.Font = new System.Drawing.Font("Montserrat", 8F);
            this.lnklblClearFilter.LinkColor = System.Drawing.Color.MidnightBlue;
            this.lnklblClearFilter.Location = new System.Drawing.Point(509, 186);
            this.lnklblClearFilter.Name = "lnklblClearFilter";
            this.lnklblClearFilter.Size = new System.Drawing.Size(67, 14);
            this.lnklblClearFilter.TabIndex = 104;
            this.lnklblClearFilter.TabStop = true;
            this.lnklblClearFilter.Text = "Clear Filter";
            this.lnklblClearFilter.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llClearFilter_LinkClicked);
            // 
            // lblLDLApplicationsRecords
            // 
            this.lblLDLApplicationsRecords.AutoSize = true;
            this.lblLDLApplicationsRecords.BackColor = System.Drawing.Color.Transparent;
            this.lblLDLApplicationsRecords.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.lblLDLApplicationsRecords.ForeColor = System.Drawing.Color.White;
            this.lblLDLApplicationsRecords.Location = new System.Drawing.Point(136, 589);
            this.lblLDLApplicationsRecords.Name = "lblLDLApplicationsRecords";
            this.lblLDLApplicationsRecords.Size = new System.Drawing.Size(23, 18);
            this.lblLDLApplicationsRecords.TabIndex = 102;
            this.lblLDLApplicationsRecords.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 589);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 101;
            this.label2.Text = "# Records: ";
            // 
            // btnCloseManageLocalLicenseApplications
            // 
            this.btnCloseManageLocalLicenseApplications.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCloseManageLocalLicenseApplications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseManageLocalLicenseApplications.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseManageLocalLicenseApplications.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCloseManageLocalLicenseApplications.Image = global::DVLD_Mery.Properties.Resources.Close_32;
            this.btnCloseManageLocalLicenseApplications.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseManageLocalLicenseApplications.Location = new System.Drawing.Point(1070, 576);
            this.btnCloseManageLocalLicenseApplications.Name = "btnCloseManageLocalLicenseApplications";
            this.btnCloseManageLocalLicenseApplications.Size = new System.Drawing.Size(105, 31);
            this.btnCloseManageLocalLicenseApplications.TabIndex = 100;
            this.btnCloseManageLocalLicenseApplications.Text = "Close";
            this.btnCloseManageLocalLicenseApplications.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCloseManageLocalLicenseApplications.UseVisualStyleBackColor = true;
            this.btnCloseManageLocalLicenseApplications.Click += new System.EventHandler(this.btnExitManageLocalLicenseApplications_Click);
            // 
            // txtLDLAppsFilter
            // 
            this.txtLDLAppsFilter.Location = new System.Drawing.Point(318, 183);
            this.txtLDLAppsFilter.Name = "txtLDLAppsFilter";
            this.txtLDLAppsFilter.Size = new System.Drawing.Size(184, 21);
            this.txtLDLAppsFilter.TabIndex = 98;
            this.txtLDLAppsFilter.TextChanged += new System.EventHandler(this.txtLDLAppsFilter_TextChanged);
            this.txtLDLAppsFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLDLAppsFilter_KeyPress);
            // 
            // cmbFilterLDLAppsByProperity
            // 
            this.cmbFilterLDLAppsByProperity.AutoCompleteCustomSource.AddRange(new string[] {
            "None",
            "UserID",
            "PersonID",
            "Username",
            "Full Name",
            "Is Active"});
            this.cmbFilterLDLAppsByProperity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterLDLAppsByProperity.FormattingEnabled = true;
            this.cmbFilterLDLAppsByProperity.Items.AddRange(new object[] {
            "None",
            "LDLAppID",
            "DrivingClass",
            "NationalNo",
            "FullName",
            "PassedTests",
            "Status"});
            this.cmbFilterLDLAppsByProperity.Location = new System.Drawing.Point(125, 182);
            this.cmbFilterLDLAppsByProperity.Name = "cmbFilterLDLAppsByProperity";
            this.cmbFilterLDLAppsByProperity.Size = new System.Drawing.Size(169, 22);
            this.cmbFilterLDLAppsByProperity.TabIndex = 97;
            this.cmbFilterLDLAppsByProperity.SelectedIndexChanged += new System.EventHandler(this.cmbFilterLDLAppsByProperity_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(31, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 96;
            this.label3.Text = "Filter By";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montserrat", 22F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(352, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(579, 37);
            this.label1.TabIndex = 94;
            this.label1.Text = "Manage Local License Applications";
            // 
            // dgvLDLApplications
            // 
            this.dgvLDLApplications.AllowUserToAddRows = false;
            this.dgvLDLApplications.AllowUserToDeleteRows = false;
            this.dgvLDLApplications.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLDLApplications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLDLApplications.BackgroundColor = System.Drawing.Color.White;
            this.dgvLDLApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLDLApplications.ContextMenuStrip = this.cmsLDLApp;
            this.dgvLDLApplications.Location = new System.Drawing.Point(30, 212);
            this.dgvLDLApplications.Name = "dgvLDLApplications";
            this.dgvLDLApplications.ReadOnly = true;
            this.dgvLDLApplications.Size = new System.Drawing.Size(1145, 358);
            this.dgvLDLApplications.TabIndex = 93;
            this.dgvLDLApplications.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.dgvLDLApplications_CellContextMenuStripNeeded);
            // 
            // cmsLDLApp
            // 
            this.cmsLDLApp.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsLDLApp.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.cmsLDLApp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowApplicationDetailstoolStripMenuItem,
            this.toolStripSeparator2,
            this.EdittoolStripMenuItem,
            this.DeletetoolStripMenuItem,
            this.toolStripSeparator1,
            this.CancelApplicationtoolStripMenuItem,
            this.toolStripSeparator3,
            this.ScheduleTestsMenuItem,
            this.toolStripSeparator4,
            this.IssueDrivingLicenseFTtoolStripMenuItem,
            this.toolStripSeparator5,
            this.ShowLicensetoolStripMenuItem,
            this.toolStripSeparator6,
            this.ShowPersonLicenseHistoryToolStripMenuItem});
            this.cmsLDLApp.Name = "cmsPerson";
            this.cmsLDLApp.Size = new System.Drawing.Size(283, 350);
            // 
            // ShowApplicationDetailstoolStripMenuItem
            // 
            this.ShowApplicationDetailstoolStripMenuItem.Image = global::DVLD_Mery.Properties.Resources.ApplicationFormImage1_removebg_preview;
            this.ShowApplicationDetailstoolStripMenuItem.Name = "ShowApplicationDetailstoolStripMenuItem";
            this.ShowApplicationDetailstoolStripMenuItem.Size = new System.Drawing.Size(282, 36);
            this.ShowApplicationDetailstoolStripMenuItem.Text = "Show ApplicationDetails";
            this.ShowApplicationDetailstoolStripMenuItem.Click += new System.EventHandler(this.ShowApplicationDetailstoolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(279, 6);
            // 
            // EdittoolStripMenuItem
            // 
            this.EdittoolStripMenuItem.Image = global::DVLD_Mery.Properties.Resources.edit_32;
            this.EdittoolStripMenuItem.Name = "EdittoolStripMenuItem";
            this.EdittoolStripMenuItem.Size = new System.Drawing.Size(282, 36);
            this.EdittoolStripMenuItem.Text = "Edit Application";
            this.EdittoolStripMenuItem.Click += new System.EventHandler(this.EdittoolStripMenuItem_Click);
            // 
            // DeletetoolStripMenuItem
            // 
            this.DeletetoolStripMenuItem.Image = global::DVLD_Mery.Properties.Resources.Delete_32_2;
            this.DeletetoolStripMenuItem.Name = "DeletetoolStripMenuItem";
            this.DeletetoolStripMenuItem.Size = new System.Drawing.Size(282, 36);
            this.DeletetoolStripMenuItem.Text = "Delete Application";
            this.DeletetoolStripMenuItem.Click += new System.EventHandler(this.DeletetoolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(279, 6);
            // 
            // CancelApplicationtoolStripMenuItem
            // 
            this.CancelApplicationtoolStripMenuItem.Image = global::DVLD_Mery.Properties.Resources.Delete_32;
            this.CancelApplicationtoolStripMenuItem.Name = "CancelApplicationtoolStripMenuItem";
            this.CancelApplicationtoolStripMenuItem.Size = new System.Drawing.Size(282, 36);
            this.CancelApplicationtoolStripMenuItem.Text = "Cancel Application";
            this.CancelApplicationtoolStripMenuItem.Click += new System.EventHandler(this.CancelApplicationtoolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(279, 6);
            // 
            // ScheduleTestsMenuItem
            // 
            this.ScheduleTestsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scheduleVisionTestToolStripMenuItem,
            this.scheduleWrittenTestToolStripMenuItem,
            this.scheduleStreetTestToolStripMenuItem});
            this.ScheduleTestsMenuItem.Image = global::DVLD_Mery.Properties.Resources.Test_32;
            this.ScheduleTestsMenuItem.Name = "ScheduleTestsMenuItem";
            this.ScheduleTestsMenuItem.Size = new System.Drawing.Size(282, 36);
            this.ScheduleTestsMenuItem.Text = "Schedule Tests";
            // 
            // scheduleVisionTestToolStripMenuItem
            // 
            this.scheduleVisionTestToolStripMenuItem.Image = global::DVLD_Mery.Properties.Resources.Vision_512;
            this.scheduleVisionTestToolStripMenuItem.Name = "scheduleVisionTestToolStripMenuItem";
            this.scheduleVisionTestToolStripMenuItem.Size = new System.Drawing.Size(221, 36);
            this.scheduleVisionTestToolStripMenuItem.Text = "Schedule Vision Test";
            this.scheduleVisionTestToolStripMenuItem.Click += new System.EventHandler(this.scheduleVisionTestToolStripMenuItem_Click);
            // 
            // scheduleWrittenTestToolStripMenuItem
            // 
            this.scheduleWrittenTestToolStripMenuItem.Image = global::DVLD_Mery.Properties.Resources.Written_Test_32_Sechdule;
            this.scheduleWrittenTestToolStripMenuItem.Name = "scheduleWrittenTestToolStripMenuItem";
            this.scheduleWrittenTestToolStripMenuItem.Size = new System.Drawing.Size(221, 36);
            this.scheduleWrittenTestToolStripMenuItem.Text = "Schedule Written Test";
            this.scheduleWrittenTestToolStripMenuItem.Click += new System.EventHandler(this.scheduleWrittenTestToolStripMenuItem_Click);
            // 
            // scheduleStreetTestToolStripMenuItem
            // 
            this.scheduleStreetTestToolStripMenuItem.Image = global::DVLD_Mery.Properties.Resources.Street_Test_32;
            this.scheduleStreetTestToolStripMenuItem.Name = "scheduleStreetTestToolStripMenuItem";
            this.scheduleStreetTestToolStripMenuItem.Size = new System.Drawing.Size(221, 36);
            this.scheduleStreetTestToolStripMenuItem.Text = "Schedule Street Test";
            this.scheduleStreetTestToolStripMenuItem.Click += new System.EventHandler(this.scheduleStreetTestToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(279, 6);
            // 
            // IssueDrivingLicenseFTtoolStripMenuItem
            // 
            this.IssueDrivingLicenseFTtoolStripMenuItem.Image = global::DVLD_Mery.Properties.Resources.IssueDrivingLicense_32;
            this.IssueDrivingLicenseFTtoolStripMenuItem.Name = "IssueDrivingLicenseFTtoolStripMenuItem";
            this.IssueDrivingLicenseFTtoolStripMenuItem.Size = new System.Drawing.Size(282, 36);
            this.IssueDrivingLicenseFTtoolStripMenuItem.Text = "Issue Driving License (First Time)";
            this.IssueDrivingLicenseFTtoolStripMenuItem.Click += new System.EventHandler(this.IssueDrivingLicenseFTtoolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(279, 6);
            // 
            // ShowLicensetoolStripMenuItem
            // 
            this.ShowLicensetoolStripMenuItem.Image = global::DVLD_Mery.Properties.Resources.License_View_32;
            this.ShowLicensetoolStripMenuItem.Name = "ShowLicensetoolStripMenuItem";
            this.ShowLicensetoolStripMenuItem.Size = new System.Drawing.Size(282, 36);
            this.ShowLicensetoolStripMenuItem.Text = "Show License";
            this.ShowLicensetoolStripMenuItem.Click += new System.EventHandler(this.ShowLicensetoolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(279, 6);
            // 
            // ShowPersonLicenseHistoryToolStripMenuItem
            // 
            this.ShowPersonLicenseHistoryToolStripMenuItem.Image = global::DVLD_Mery.Properties.Resources.PersonLicenseHistory_32;
            this.ShowPersonLicenseHistoryToolStripMenuItem.Name = "ShowPersonLicenseHistoryToolStripMenuItem";
            this.ShowPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(282, 36);
            this.ShowPersonLicenseHistoryToolStripMenuItem.Text = "Show Person\'s License History";
            this.ShowPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.ShowPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // cmbLicenseClasses
            // 
            this.cmbLicenseClasses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLicenseClasses.FormattingEnabled = true;
            this.cmbLicenseClasses.Items.AddRange(new object[] {
            "All"});
            this.cmbLicenseClasses.Location = new System.Drawing.Point(317, 182);
            this.cmbLicenseClasses.Name = "cmbLicenseClasses";
            this.cmbLicenseClasses.Size = new System.Drawing.Size(184, 22);
            this.cmbLicenseClasses.TabIndex = 106;
            this.cmbLicenseClasses.SelectedIndexChanged += new System.EventHandler(this.cmbLicenseClasses_SelectedIndexChanged);
            // 
            // cmbLDLAppStatus
            // 
            this.cmbLDLAppStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLDLAppStatus.FormattingEnabled = true;
            this.cmbLDLAppStatus.Items.AddRange(new object[] {
            "All",
            "New",
            "Cancelled",
            "Completed"});
            this.cmbLDLAppStatus.Location = new System.Drawing.Point(318, 182);
            this.cmbLDLAppStatus.Name = "cmbLDLAppStatus";
            this.cmbLDLAppStatus.Size = new System.Drawing.Size(184, 22);
            this.cmbLDLAppStatus.TabIndex = 107;
            this.cmbLDLAppStatus.SelectedIndexChanged += new System.EventHandler(this.cmbLDLAppStatus_SelectedIndexChanged);
            // 
            // btnExitManageLocalLicenseApplications
            // 
            this.btnExitManageLocalLicenseApplications.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnExitManageLocalLicenseApplications.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnExitManageLocalLicenseApplications.ForeColor = System.Drawing.Color.White;
            this.btnExitManageLocalLicenseApplications.Location = new System.Drawing.Point(1151, 2);
            this.btnExitManageLocalLicenseApplications.Name = "btnExitManageLocalLicenseApplications";
            this.btnExitManageLocalLicenseApplications.Size = new System.Drawing.Size(50, 43);
            this.btnExitManageLocalLicenseApplications.TabIndex = 108;
            this.btnExitManageLocalLicenseApplications.Text = "X";
            this.btnExitManageLocalLicenseApplications.UseVisualStyleBackColor = false;
            this.btnExitManageLocalLicenseApplications.Click += new System.EventHandler(this.btnExitManageLocalLicenseApplications_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::DVLD_Mery.Properties.Resources.Local_32;
            this.pictureBox2.Location = new System.Drawing.Point(710, 57);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 109;
            this.pictureBox2.TabStop = false;
            // 
            // btnAddNewLDLApp
            // 
            this.btnAddNewLDLApp.BackColor = System.Drawing.Color.White;
            this.btnAddNewLDLApp.BackgroundImage = global::DVLD_Mery.Properties.Resources.New_Application_64;
            this.btnAddNewLDLApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddNewLDLApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewLDLApp.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnAddNewLDLApp.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnAddNewLDLApp.Location = new System.Drawing.Point(1099, 155);
            this.btnAddNewLDLApp.Name = "btnAddNewLDLApp";
            this.btnAddNewLDLApp.Size = new System.Drawing.Size(68, 45);
            this.btnAddNewLDLApp.TabIndex = 95;
            this.btnAddNewLDLApp.UseVisualStyleBackColor = false;
            this.btnAddNewLDLApp.Click += new System.EventHandler(this.btnAddNewLDLApp_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::DVLD_Mery.Properties.Resources.Applications;
            this.pictureBox3.Location = new System.Drawing.Point(575, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(133, 127);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 117;
            this.pictureBox3.TabStop = false;
            // 
            // frmManageLocalLicenseApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DVLD_Mery.Properties.Resources.DVLDbackground1_resized;
            this.CancelButton = this.btnCloseManageLocalLicenseApplications;
            this.ClientSize = new System.Drawing.Size(1204, 616);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnExitManageLocalLicenseApplications);
            this.Controls.Add(this.lnklblClearFilter);
            this.Controls.Add(this.lblLDLApplicationsRecords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCloseManageLocalLicenseApplications);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddNewLDLApp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvLDLApplications);
            this.Controls.Add(this.txtLDLAppsFilter);
            this.Controls.Add(this.cmbLicenseClasses);
            this.Controls.Add(this.cmbFilterLDLAppsByProperity);
            this.Controls.Add(this.cmbLDLAppStatus);
            this.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmManageLocalLicenseApplications";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManageLocalLicenseApplications";
            this.Load += new System.EventHandler(this.frmManageLocalLicenseApplications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLDLApplications)).EndInit();
            this.cmsLDLApp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel lnklblClearFilter;
        private System.Windows.Forms.Label lblLDLApplicationsRecords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCloseManageLocalLicenseApplications;
        private System.Windows.Forms.TextBox txtLDLAppsFilter;
        private System.Windows.Forms.ComboBox cmbFilterLDLAppsByProperity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLDLApplications;
        private System.Windows.Forms.ComboBox cmbLicenseClasses;
        private System.Windows.Forms.ComboBox cmbLDLAppStatus;
        private System.Windows.Forms.Button btnExitManageLocalLicenseApplications;
        private System.Windows.Forms.ContextMenuStrip cmsLDLApp;
        private System.Windows.Forms.ToolStripMenuItem ShowApplicationDetailstoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EdittoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeletetoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CancelApplicationtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IssueDrivingLicenseFTtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowLicensetoolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem ScheduleTestsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowPersonLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem scheduleVisionTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleWrittenTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleStreetTestToolStripMenuItem;
        private System.Windows.Forms.Button btnAddNewLDLApp;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}