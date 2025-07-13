namespace DVLD_Mery
{
    partial class frmManageDetainedlLicenseApplications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageDetainedlLicenseApplications));
            this.btnExitManagetDetainedLicenses = new System.Windows.Forms.Button();
            this.lnklblClearFilter = new System.Windows.Forms.LinkLabel();
            this.lbltDetainedLicensesRecords = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCloseManagetDetainedLicenses = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvtDetainedLicenses = new System.Windows.Forms.DataGridView();
            this.cmsDetainedLicense = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowPersonDetailstoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowLiceDetailsnsetoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ReleaseDetainedLicenseFTtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtDetainedLicensesFilter = new System.Windows.Forms.TextBox();
            this.cmbFiltertDetainedLicensesByProperity = new System.Windows.Forms.ComboBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnDetainLicense = new System.Windows.Forms.Button();
            this.btnReleaseLicense = new System.Windows.Forms.Button();
            this.pnlIsReleasedFilter = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.rbFilterNotReleased = new System.Windows.Forms.RadioButton();
            this.rbFilterReleased = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtDetainedLicenses)).BeginInit();
            this.cmsDetainedLicense.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pnlIsReleasedFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExitManagetDetainedLicenses
            // 
            this.btnExitManagetDetainedLicenses.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnExitManagetDetainedLicenses.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnExitManagetDetainedLicenses.ForeColor = System.Drawing.Color.White;
            this.btnExitManagetDetainedLicenses.Location = new System.Drawing.Point(1146, 5);
            this.btnExitManagetDetainedLicenses.Name = "btnExitManagetDetainedLicenses";
            this.btnExitManagetDetainedLicenses.Size = new System.Drawing.Size(50, 43);
            this.btnExitManagetDetainedLicenses.TabIndex = 130;
            this.btnExitManagetDetainedLicenses.Text = "X";
            this.btnExitManagetDetainedLicenses.UseVisualStyleBackColor = false;
            this.btnExitManagetDetainedLicenses.Click += new System.EventHandler(this.btnExitManagetDetainedLicenses_Click);
            // 
            // lnklblClearFilter
            // 
            this.lnklblClearFilter.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.lnklblClearFilter.AutoSize = true;
            this.lnklblClearFilter.BackColor = System.Drawing.Color.Transparent;
            this.lnklblClearFilter.Font = new System.Drawing.Font("Montserrat", 8F);
            this.lnklblClearFilter.LinkColor = System.Drawing.Color.MidnightBlue;
            this.lnklblClearFilter.Location = new System.Drawing.Point(506, 190);
            this.lnklblClearFilter.Name = "lnklblClearFilter";
            this.lnklblClearFilter.Size = new System.Drawing.Size(67, 14);
            this.lnklblClearFilter.TabIndex = 127;
            this.lnklblClearFilter.TabStop = true;
            this.lnklblClearFilter.Text = "Clear Filter";
            this.lnklblClearFilter.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblClearFilter_LinkClicked);
            // 
            // lbltDetainedLicensesRecords
            // 
            this.lbltDetainedLicensesRecords.AutoSize = true;
            this.lbltDetainedLicensesRecords.BackColor = System.Drawing.Color.Transparent;
            this.lbltDetainedLicensesRecords.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.lbltDetainedLicensesRecords.ForeColor = System.Drawing.Color.White;
            this.lbltDetainedLicensesRecords.Location = new System.Drawing.Point(133, 586);
            this.lbltDetainedLicensesRecords.Name = "lbltDetainedLicensesRecords";
            this.lbltDetainedLicensesRecords.Size = new System.Drawing.Size(23, 18);
            this.lbltDetainedLicensesRecords.TabIndex = 126;
            this.lbltDetainedLicensesRecords.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 586);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 125;
            this.label2.Text = "# Records: ";
            // 
            // btnCloseManagetDetainedLicenses
            // 
            this.btnCloseManagetDetainedLicenses.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCloseManagetDetainedLicenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseManagetDetainedLicenses.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseManagetDetainedLicenses.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCloseManagetDetainedLicenses.Location = new System.Drawing.Point(1067, 580);
            this.btnCloseManagetDetainedLicenses.Name = "btnCloseManagetDetainedLicenses";
            this.btnCloseManagetDetainedLicenses.Size = new System.Drawing.Size(105, 31);
            this.btnCloseManagetDetainedLicenses.TabIndex = 124;
            this.btnCloseManagetDetainedLicenses.Text = "Close";
            this.btnCloseManagetDetainedLicenses.UseVisualStyleBackColor = true;
            this.btnCloseManagetDetainedLicenses.Click += new System.EventHandler(this.btnExitManagetDetainedLicenses_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(28, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 121;
            this.label3.Text = "Filter By";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montserrat", 22F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(400, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 37);
            this.label1.TabIndex = 119;
            this.label1.Text = "Manage Detained Licenses";
            // 
            // dgvtDetainedLicenses
            // 
            this.dgvtDetainedLicenses.AllowUserToAddRows = false;
            this.dgvtDetainedLicenses.AllowUserToDeleteRows = false;
            this.dgvtDetainedLicenses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvtDetainedLicenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvtDetainedLicenses.BackgroundColor = System.Drawing.Color.White;
            this.dgvtDetainedLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtDetainedLicenses.ContextMenuStrip = this.cmsDetainedLicense;
            this.dgvtDetainedLicenses.Location = new System.Drawing.Point(27, 216);
            this.dgvtDetainedLicenses.Name = "dgvtDetainedLicenses";
            this.dgvtDetainedLicenses.ReadOnly = true;
            this.dgvtDetainedLicenses.Size = new System.Drawing.Size(1145, 358);
            this.dgvtDetainedLicenses.TabIndex = 118;
            this.dgvtDetainedLicenses.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.dgvtDetainedLicenses_CellContextMenuStripNeeded);
            // 
            // cmsDetainedLicense
            // 
            this.cmsDetainedLicense.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsDetainedLicense.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.cmsDetainedLicense.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowPersonDetailstoolStripMenuItem,
            this.ShowLiceDetailsnsetoolStripMenuItem,
            this.ShowPersonLicenseHistoryToolStripMenuItem,
            this.toolStripSeparator2,
            this.ReleaseDetainedLicenseFTtoolStripMenuItem});
            this.cmsDetainedLicense.Name = "cmsPerson";
            this.cmsDetainedLicense.Size = new System.Drawing.Size(272, 154);
            // 
            // ShowPersonDetailstoolStripMenuItem
            // 
            this.ShowPersonDetailstoolStripMenuItem.Image = global::DVLD_Mery.Properties.Resources.PersonDetails_321;
            this.ShowPersonDetailstoolStripMenuItem.Name = "ShowPersonDetailstoolStripMenuItem";
            this.ShowPersonDetailstoolStripMenuItem.Size = new System.Drawing.Size(271, 36);
            this.ShowPersonDetailstoolStripMenuItem.Text = "Show Person Details";
            this.ShowPersonDetailstoolStripMenuItem.Click += new System.EventHandler(this.ShowPersonDetailstoolStripMenuItem_Click);
            // 
            // ShowLiceDetailsnsetoolStripMenuItem
            // 
            this.ShowLiceDetailsnsetoolStripMenuItem.Image = global::DVLD_Mery.Properties.Resources.License_View_32;
            this.ShowLiceDetailsnsetoolStripMenuItem.Name = "ShowLiceDetailsnsetoolStripMenuItem";
            this.ShowLiceDetailsnsetoolStripMenuItem.Size = new System.Drawing.Size(271, 36);
            this.ShowLiceDetailsnsetoolStripMenuItem.Text = "Show License Details";
            this.ShowLiceDetailsnsetoolStripMenuItem.Click += new System.EventHandler(this.ShowLiceDetailsnsetoolStripMenuItem_Click);
            // 
            // ShowPersonLicenseHistoryToolStripMenuItem
            // 
            this.ShowPersonLicenseHistoryToolStripMenuItem.Image = global::DVLD_Mery.Properties.Resources.PersonLicenseHistory_32;
            this.ShowPersonLicenseHistoryToolStripMenuItem.Name = "ShowPersonLicenseHistoryToolStripMenuItem";
            this.ShowPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(271, 36);
            this.ShowPersonLicenseHistoryToolStripMenuItem.Text = "Show Person\'s License History";
            this.ShowPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.ShowPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(268, 6);
            // 
            // ReleaseDetainedLicenseFTtoolStripMenuItem
            // 
            this.ReleaseDetainedLicenseFTtoolStripMenuItem.Image = global::DVLD_Mery.Properties.Resources.Release_Detained_License_32;
            this.ReleaseDetainedLicenseFTtoolStripMenuItem.Name = "ReleaseDetainedLicenseFTtoolStripMenuItem";
            this.ReleaseDetainedLicenseFTtoolStripMenuItem.Size = new System.Drawing.Size(271, 36);
            this.ReleaseDetainedLicenseFTtoolStripMenuItem.Text = "Release Detained License";
            this.ReleaseDetainedLicenseFTtoolStripMenuItem.Click += new System.EventHandler(this.ReleaseDetainedLicenseFTtoolStripMenuItem_Click);
            // 
            // txtDetainedLicensesFilter
            // 
            this.txtDetainedLicensesFilter.Location = new System.Drawing.Point(315, 187);
            this.txtDetainedLicensesFilter.Name = "txtDetainedLicensesFilter";
            this.txtDetainedLicensesFilter.Size = new System.Drawing.Size(184, 20);
            this.txtDetainedLicensesFilter.TabIndex = 123;
            this.txtDetainedLicensesFilter.TextChanged += new System.EventHandler(this.txtDetainedLicensesFilter_TextChanged);
            this.txtDetainedLicensesFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDetainedLicensesFilter_KeyPress);
            // 
            // cmbFiltertDetainedLicensesByProperity
            // 
            this.cmbFiltertDetainedLicensesByProperity.AutoCompleteCustomSource.AddRange(new string[] {
            "None",
            "UserID",
            "PersonID",
            "Username",
            "Full Name",
            "Is Active"});
            this.cmbFiltertDetainedLicensesByProperity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltertDetainedLicensesByProperity.FormattingEnabled = true;
            this.cmbFiltertDetainedLicensesByProperity.Items.AddRange(new object[] {
            "None",
            "DetainID",
            "IsReleased",
            "NationalNo",
            "FullName",
            "ReleaseApplicationID"});
            this.cmbFiltertDetainedLicensesByProperity.Location = new System.Drawing.Point(122, 186);
            this.cmbFiltertDetainedLicensesByProperity.Name = "cmbFiltertDetainedLicensesByProperity";
            this.cmbFiltertDetainedLicensesByProperity.Size = new System.Drawing.Size(169, 21);
            this.cmbFiltertDetainedLicensesByProperity.TabIndex = 122;
            this.cmbFiltertDetainedLicensesByProperity.SelectedIndexChanged += new System.EventHandler(this.cmbFiltertDetainedLicensesByProperity_SelectedIndexChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::DVLD_Mery.Properties.Resources.Detain_512;
            this.pictureBox3.Location = new System.Drawing.Point(563, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(133, 127);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 132;
            this.pictureBox3.TabStop = false;
            // 
            // btnDetainLicense
            // 
            this.btnDetainLicense.BackColor = System.Drawing.Color.White;
            this.btnDetainLicense.BackgroundImage = global::DVLD_Mery.Properties.Resources.Detain_64;
            this.btnDetainLicense.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDetainLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetainLicense.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnDetainLicense.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDetainLicense.Location = new System.Drawing.Point(1096, 159);
            this.btnDetainLicense.Name = "btnDetainLicense";
            this.btnDetainLicense.Size = new System.Drawing.Size(68, 45);
            this.btnDetainLicense.TabIndex = 120;
            this.btnDetainLicense.UseVisualStyleBackColor = false;
            this.btnDetainLicense.Click += new System.EventHandler(this.btnDetainLicense_Click);
            // 
            // btnReleaseLicense
            // 
            this.btnReleaseLicense.BackColor = System.Drawing.Color.White;
            this.btnReleaseLicense.BackgroundImage = global::DVLD_Mery.Properties.Resources.Release_Detained_License_64;
            this.btnReleaseLicense.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReleaseLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReleaseLicense.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnReleaseLicense.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnReleaseLicense.Location = new System.Drawing.Point(1022, 159);
            this.btnReleaseLicense.Name = "btnReleaseLicense";
            this.btnReleaseLicense.Size = new System.Drawing.Size(68, 45);
            this.btnReleaseLicense.TabIndex = 133;
            this.btnReleaseLicense.UseVisualStyleBackColor = false;
            this.btnReleaseLicense.Click += new System.EventHandler(this.btnReleaseLicense_Click);
            // 
            // pnlIsReleasedFilter
            // 
            this.pnlIsReleasedFilter.BackColor = System.Drawing.Color.Transparent;
            this.pnlIsReleasedFilter.Controls.Add(this.label13);
            this.pnlIsReleasedFilter.Controls.Add(this.rbFilterNotReleased);
            this.pnlIsReleasedFilter.Controls.Add(this.rbFilterReleased);
            this.pnlIsReleasedFilter.Location = new System.Drawing.Point(297, 180);
            this.pnlIsReleasedFilter.Name = "pnlIsReleasedFilter";
            this.pnlIsReleasedFilter.Size = new System.Drawing.Size(203, 35);
            this.pnlIsReleasedFilter.TabIndex = 134;
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
            // rbFilterNotReleased
            // 
            this.rbFilterNotReleased.AutoSize = true;
            this.rbFilterNotReleased.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFilterNotReleased.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rbFilterNotReleased.Location = new System.Drawing.Point(92, 8);
            this.rbFilterNotReleased.Name = "rbFilterNotReleased";
            this.rbFilterNotReleased.Size = new System.Drawing.Size(114, 20);
            this.rbFilterNotReleased.TabIndex = 1;
            this.rbFilterNotReleased.Text = "Not Released";
            this.rbFilterNotReleased.UseVisualStyleBackColor = true;
            this.rbFilterNotReleased.CheckedChanged += new System.EventHandler(this.rbFilterIsReleased_CheckedChanged);
            // 
            // rbFilterReleased
            // 
            this.rbFilterReleased.AutoSize = true;
            this.rbFilterReleased.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFilterReleased.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rbFilterReleased.Location = new System.Drawing.Point(3, 7);
            this.rbFilterReleased.Name = "rbFilterReleased";
            this.rbFilterReleased.Size = new System.Drawing.Size(86, 20);
            this.rbFilterReleased.TabIndex = 0;
            this.rbFilterReleased.Text = "Released";
            this.rbFilterReleased.UseVisualStyleBackColor = true;
            this.rbFilterReleased.CheckedChanged += new System.EventHandler(this.rbFilterIsReleased_CheckedChanged);
            // 
            // frmManageDetainedlLicenseApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DVLD_Mery.Properties.Resources.DVLDbackground1_resized;
            this.CancelButton = this.btnCloseManagetDetainedLicenses;
            this.ClientSize = new System.Drawing.Size(1204, 616);
            this.Controls.Add(this.btnReleaseLicense);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnExitManagetDetainedLicenses);
            this.Controls.Add(this.lnklblClearFilter);
            this.Controls.Add(this.lbltDetainedLicensesRecords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCloseManagetDetainedLicenses);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDetainLicense);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvtDetainedLicenses);
            this.Controls.Add(this.cmbFiltertDetainedLicensesByProperity);
            this.Controls.Add(this.txtDetainedLicensesFilter);
            this.Controls.Add(this.pnlIsReleasedFilter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmManageDetainedlLicenseApplications";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManageDetainedlLicenseApplications";
            this.Load += new System.EventHandler(this.frmManageDetainedlLicenseApplications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtDetainedLicenses)).EndInit();
            this.cmsDetainedLicense.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pnlIsReleasedFilter.ResumeLayout(false);
            this.pnlIsReleasedFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnExitManagetDetainedLicenses;
        private System.Windows.Forms.LinkLabel lnklblClearFilter;
        private System.Windows.Forms.Label lbltDetainedLicensesRecords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCloseManagetDetainedLicenses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDetainLicense;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvtDetainedLicenses;
        private System.Windows.Forms.TextBox txtDetainedLicensesFilter;
        private System.Windows.Forms.ComboBox cmbFiltertDetainedLicensesByProperity;
        private System.Windows.Forms.Button btnReleaseLicense;
        private System.Windows.Forms.ContextMenuStrip cmsDetainedLicense;
        private System.Windows.Forms.ToolStripMenuItem ShowPersonDetailstoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowLiceDetailsnsetoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReleaseDetainedLicenseFTtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowPersonLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Panel pnlIsReleasedFilter;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton rbFilterNotReleased;
        private System.Windows.Forms.RadioButton rbFilterReleased;
    }
}