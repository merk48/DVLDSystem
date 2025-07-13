namespace DVLD_Mery
{
    partial class frmAddEdiInternationalDrivingLicenseApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEdiInternationalDrivingLicenseApplication));
            this.lblLDLAppFormTitle = new System.Windows.Forms.Label();
            this.btnCloseIntLApp = new System.Windows.Forms.Button();
            this.btnIssueIntLicense = new System.Windows.Forms.Button();
            this.lnklblShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.lnklblShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.btnExitManageIntLApplications = new System.Windows.Forms.Button();
            this.ctrlIntLAppCard1 = new DVLD_Mery.ctrlIntLAppCard();
            this.ctrlDriverLicenseInfoWithFilter1 = new DVLD_Mery.ctrlDriverLicenseInfoWithFilter();
            this.SuspendLayout();
            // 
            // lblLDLAppFormTitle
            // 
            this.lblLDLAppFormTitle.AutoSize = true;
            this.lblLDLAppFormTitle.BackColor = System.Drawing.Color.White;
            this.lblLDLAppFormTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLDLAppFormTitle.Font = new System.Drawing.Font("Montserrat", 22F, System.Drawing.FontStyle.Bold);
            this.lblLDLAppFormTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblLDLAppFormTitle.Location = new System.Drawing.Point(335, 4);
            this.lblLDLAppFormTitle.Name = "lblLDLAppFormTitle";
            this.lblLDLAppFormTitle.Size = new System.Drawing.Size(550, 39);
            this.lblLDLAppFormTitle.TabIndex = 50;
            this.lblLDLAppFormTitle.Text = "International License Application";
            // 
            // btnCloseIntLApp
            // 
            this.btnCloseIntLApp.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCloseIntLApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseIntLApp.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseIntLApp.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCloseIntLApp.Image = global::DVLD_Mery.Properties.Resources.Close_321;
            this.btnCloseIntLApp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseIntLApp.Location = new System.Drawing.Point(954, 730);
            this.btnCloseIntLApp.Name = "btnCloseIntLApp";
            this.btnCloseIntLApp.Size = new System.Drawing.Size(104, 35);
            this.btnCloseIntLApp.TabIndex = 133;
            this.btnCloseIntLApp.Text = "Close";
            this.btnCloseIntLApp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCloseIntLApp.UseVisualStyleBackColor = true;
            this.btnCloseIntLApp.Click += new System.EventHandler(this.btnExitManageIntLApplications_Click);
            // 
            // btnIssueIntLicense
            // 
            this.btnIssueIntLicense.BackColor = System.Drawing.Color.White;
            this.btnIssueIntLicense.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIssueIntLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssueIntLicense.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.btnIssueIntLicense.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnIssueIntLicense.Image = global::DVLD_Mery.Properties.Resources.International_32;
            this.btnIssueIntLicense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIssueIntLicense.Location = new System.Drawing.Point(1079, 730);
            this.btnIssueIntLicense.Name = "btnIssueIntLicense";
            this.btnIssueIntLicense.Size = new System.Drawing.Size(104, 35);
            this.btnIssueIntLicense.TabIndex = 132;
            this.btnIssueIntLicense.Text = "Issue";
            this.btnIssueIntLicense.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIssueIntLicense.UseVisualStyleBackColor = false;
            this.btnIssueIntLicense.Click += new System.EventHandler(this.btnIssueIntLicense_Click);
            // 
            // lnklblShowLicenseInfo
            // 
            this.lnklblShowLicenseInfo.ActiveLinkColor = System.Drawing.Color.Black;
            this.lnklblShowLicenseInfo.AutoSize = true;
            this.lnklblShowLicenseInfo.BackColor = System.Drawing.Color.Transparent;
            this.lnklblShowLicenseInfo.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklblShowLicenseInfo.ForeColor = System.Drawing.Color.White;
            this.lnklblShowLicenseInfo.LinkColor = System.Drawing.Color.White;
            this.lnklblShowLicenseInfo.Location = new System.Drawing.Point(207, 739);
            this.lnklblShowLicenseInfo.Name = "lnklblShowLicenseInfo";
            this.lnklblShowLicenseInfo.Size = new System.Drawing.Size(165, 19);
            this.lnklblShowLicenseInfo.TabIndex = 134;
            this.lnklblShowLicenseInfo.TabStop = true;
            this.lnklblShowLicenseInfo.Text = "Show License Info";
            this.lnklblShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblShowLicenseInfo_LinkClicked);
            // 
            // lnklblShowLicenseHistory
            // 
            this.lnklblShowLicenseHistory.ActiveLinkColor = System.Drawing.Color.Black;
            this.lnklblShowLicenseHistory.AutoSize = true;
            this.lnklblShowLicenseHistory.BackColor = System.Drawing.Color.Transparent;
            this.lnklblShowLicenseHistory.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklblShowLicenseHistory.ForeColor = System.Drawing.Color.White;
            this.lnklblShowLicenseHistory.LinkColor = System.Drawing.Color.White;
            this.lnklblShowLicenseHistory.Location = new System.Drawing.Point(14, 739);
            this.lnklblShowLicenseHistory.Name = "lnklblShowLicenseHistory";
            this.lnklblShowLicenseHistory.Size = new System.Drawing.Size(192, 19);
            this.lnklblShowLicenseHistory.TabIndex = 135;
            this.lnklblShowLicenseHistory.TabStop = true;
            this.lnklblShowLicenseHistory.Text = "Show License History";
            this.lnklblShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblShowLicenseHistory_LinkClicked);
            // 
            // btnExitManageIntLApplications
            // 
            this.btnExitManageIntLApplications.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnExitManageIntLApplications.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnExitManageIntLApplications.ForeColor = System.Drawing.Color.White;
            this.btnExitManageIntLApplications.Location = new System.Drawing.Point(1153, 1);
            this.btnExitManageIntLApplications.Name = "btnExitManageIntLApplications";
            this.btnExitManageIntLApplications.Size = new System.Drawing.Size(50, 43);
            this.btnExitManageIntLApplications.TabIndex = 124;
            this.btnExitManageIntLApplications.Text = "X";
            this.btnExitManageIntLApplications.UseVisualStyleBackColor = false;
            this.btnExitManageIntLApplications.Click += new System.EventHandler(this.btnExitManageIntLApplications_Click);
            // 
            // ctrlIntLAppCard1
            // 
            this.ctrlIntLAppCard1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlIntLAppCard1.Location = new System.Drawing.Point(17, 511);
            this.ctrlIntLAppCard1.Name = "ctrlIntLAppCard1";
            this.ctrlIntLAppCard1.Size = new System.Drawing.Size(1170, 211);
            this.ctrlIntLAppCard1.TabIndex = 136;
            // 
            // ctrlDriverLicenseInfoWithFilter1
            // 
            this.ctrlDriverLicenseInfoWithFilter1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlDriverLicenseInfoWithFilter1.Location = new System.Drawing.Point(17, 44);
            this.ctrlDriverLicenseInfoWithFilter1.Name = "ctrlDriverLicenseInfoWithFilter1";
            this.ctrlDriverLicenseInfoWithFilter1.Size = new System.Drawing.Size(1171, 461);
            this.ctrlDriverLicenseInfoWithFilter1.TabIndex = 137;
            this.ctrlDriverLicenseInfoWithFilter1.OnLicenseSelected += new System.EventHandler<DVLD_Mery.ctrlDriverLicenseInfoWithFilter.LicenseSelectedEventsArgs>(this.ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected);
            // 
            // frmAddEdiInternationalDrivingLicenseApplication
            // 
            this.AcceptButton = this.btnIssueIntLicense;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DVLD_Mery.Properties.Resources.DVLDbackground1_resized;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnCloseIntLApp;
            this.ClientSize = new System.Drawing.Size(1204, 780);
            this.Controls.Add(this.ctrlDriverLicenseInfoWithFilter1);
            this.Controls.Add(this.ctrlIntLAppCard1);
            this.Controls.Add(this.btnExitManageIntLApplications);
            this.Controls.Add(this.lnklblShowLicenseHistory);
            this.Controls.Add(this.lnklblShowLicenseInfo);
            this.Controls.Add(this.btnCloseIntLApp);
            this.Controls.Add(this.btnIssueIntLicense);
            this.Controls.Add(this.lblLDLAppFormTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(199, 64);
            this.Name = "frmAddEdiInternationalDrivingLicenseApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmAddEdiInternationalDrivingLicenseApplication";
            this.Load += new System.EventHandler(this.frmAddEdiInternationalDrivingLicenseApplication_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblLDLAppFormTitle;
        private System.Windows.Forms.Button btnCloseIntLApp;
        private System.Windows.Forms.Button btnIssueIntLicense;
        private System.Windows.Forms.LinkLabel lnklblShowLicenseInfo;
        private System.Windows.Forms.LinkLabel lnklblShowLicenseHistory;
        private System.Windows.Forms.Button btnExitManageIntLApplications;
        private ctrlIntLAppCard ctrlIntLAppCard1;
        private ctrlDriverLicenseInfoWithFilter ctrlDriverLicenseInfoWithFilter1;
    }
}