namespace DVLD_Mery
{
    partial class frmRenewLocalDrivingLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRenewLocalDrivingLicense));
            this.btnExitRenewLDLApp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlRenewLicenseApplicationCard1 = new DVLD_Mery.ctrlRenewLicenseApplicationCard();
            this.btnCloseRenewLicenseApp = new System.Windows.Forms.Button();
            this.btnRenewLicense = new System.Windows.Forms.Button();
            this.lnklblShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.lnklblNewShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.ctrlDriverLicenseInfoWithFilter1 = new DVLD_Mery.ctrlDriverLicenseInfoWithFilter();
            this.SuspendLayout();
            // 
            // btnExitRenewLDLApp
            // 
            this.btnExitRenewLDLApp.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnExitRenewLDLApp.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnExitRenewLDLApp.ForeColor = System.Drawing.Color.White;
            this.btnExitRenewLDLApp.Location = new System.Drawing.Point(1151, 3);
            this.btnExitRenewLDLApp.Name = "btnExitRenewLDLApp";
            this.btnExitRenewLDLApp.Size = new System.Drawing.Size(50, 43);
            this.btnExitRenewLDLApp.TabIndex = 40;
            this.btnExitRenewLDLApp.Text = "X";
            this.btnExitRenewLDLApp.UseVisualStyleBackColor = false;
            this.btnExitRenewLDLApp.Click += new System.EventHandler(this.btnExitRenewLDLicense_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Montserrat", 22F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(320, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(547, 39);
            this.label1.TabIndex = 41;
            this.label1.Text = "Renew Local License Application";
            // 
            // ctrlRenewLicenseApplicationCard1
            // 
            this.ctrlRenewLicenseApplicationCard1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlRenewLicenseApplicationCard1.Location = new System.Drawing.Point(18, 479);
            this.ctrlRenewLicenseApplicationCard1.Name = "ctrlRenewLicenseApplicationCard1";
            this.ctrlRenewLicenseApplicationCard1.Size = new System.Drawing.Size(1171, 297);
            this.ctrlRenewLicenseApplicationCard1.TabIndex = 134;
            // 
            // btnCloseRenewLicenseApp
            // 
            this.btnCloseRenewLicenseApp.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCloseRenewLicenseApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseRenewLicenseApp.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseRenewLicenseApp.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCloseRenewLicenseApp.Image = global::DVLD_Mery.Properties.Resources.Close_321;
            this.btnCloseRenewLicenseApp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseRenewLicenseApp.Location = new System.Drawing.Point(1080, 734);
            this.btnCloseRenewLicenseApp.Name = "btnCloseRenewLicenseApp";
            this.btnCloseRenewLicenseApp.Size = new System.Drawing.Size(104, 35);
            this.btnCloseRenewLicenseApp.TabIndex = 136;
            this.btnCloseRenewLicenseApp.Text = "Close";
            this.btnCloseRenewLicenseApp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCloseRenewLicenseApp.UseVisualStyleBackColor = true;
            this.btnCloseRenewLicenseApp.Click += new System.EventHandler(this.btnExitRenewLDLicense_Click);
            // 
            // btnRenewLicense
            // 
            this.btnRenewLicense.BackColor = System.Drawing.Color.White;
            this.btnRenewLicense.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRenewLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRenewLicense.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.btnRenewLicense.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnRenewLicense.Image = global::DVLD_Mery.Properties.Resources.Renew_Driving_License_32;
            this.btnRenewLicense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRenewLicense.Location = new System.Drawing.Point(1080, 693);
            this.btnRenewLicense.Name = "btnRenewLicense";
            this.btnRenewLicense.Size = new System.Drawing.Size(104, 35);
            this.btnRenewLicense.TabIndex = 135;
            this.btnRenewLicense.Text = "Renew";
            this.btnRenewLicense.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRenewLicense.UseVisualStyleBackColor = false;
            this.btnRenewLicense.Click += new System.EventHandler(this.btnRenewLicense_Click);
            // 
            // lnklblShowLicenseHistory
            // 
            this.lnklblShowLicenseHistory.ActiveLinkColor = System.Drawing.Color.Black;
            this.lnklblShowLicenseHistory.AutoSize = true;
            this.lnklblShowLicenseHistory.BackColor = System.Drawing.Color.Transparent;
            this.lnklblShowLicenseHistory.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklblShowLicenseHistory.ForeColor = System.Drawing.Color.White;
            this.lnklblShowLicenseHistory.LinkColor = System.Drawing.Color.White;
            this.lnklblShowLicenseHistory.Location = new System.Drawing.Point(23, 758);
            this.lnklblShowLicenseHistory.Name = "lnklblShowLicenseHistory";
            this.lnklblShowLicenseHistory.Size = new System.Drawing.Size(192, 19);
            this.lnklblShowLicenseHistory.TabIndex = 139;
            this.lnklblShowLicenseHistory.TabStop = true;
            this.lnklblShowLicenseHistory.Text = "Show License History";
            this.lnklblShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblShowLicenseHistory_LinkClicked);
            // 
            // lnklblNewShowLicenseInfo
            // 
            this.lnklblNewShowLicenseInfo.ActiveLinkColor = System.Drawing.Color.Black;
            this.lnklblNewShowLicenseInfo.AutoSize = true;
            this.lnklblNewShowLicenseInfo.BackColor = System.Drawing.Color.Transparent;
            this.lnklblNewShowLicenseInfo.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklblNewShowLicenseInfo.ForeColor = System.Drawing.Color.White;
            this.lnklblNewShowLicenseInfo.LinkColor = System.Drawing.Color.White;
            this.lnklblNewShowLicenseInfo.Location = new System.Drawing.Point(216, 758);
            this.lnklblNewShowLicenseInfo.Name = "lnklblNewShowLicenseInfo";
            this.lnklblNewShowLicenseInfo.Size = new System.Drawing.Size(209, 19);
            this.lnklblNewShowLicenseInfo.TabIndex = 138;
            this.lnklblNewShowLicenseInfo.TabStop = true;
            this.lnklblNewShowLicenseInfo.Text = "Show New License Info";
            this.lnklblNewShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblShowLicenseInfo_LinkClicked);
            // 
            // ctrlDriverLicenseInfoWithFilter1
            // 
            this.ctrlDriverLicenseInfoWithFilter1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlDriverLicenseInfoWithFilter1.Location = new System.Drawing.Point(18, 35);
            this.ctrlDriverLicenseInfoWithFilter1.Name = "ctrlDriverLicenseInfoWithFilter1";
            this.ctrlDriverLicenseInfoWithFilter1.Size = new System.Drawing.Size(1171, 461);
            this.ctrlDriverLicenseInfoWithFilter1.TabIndex = 140;
            this.ctrlDriverLicenseInfoWithFilter1.OnLicenseSelected += new System.EventHandler<DVLD_Mery.ctrlDriverLicenseInfoWithFilter.LicenseSelectedEventsArgs>(this.ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected);
            // 
            // frmRenewLocalDrivingLicense
            // 
            this.AcceptButton = this.btnRenewLicense;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DVLD_Mery.Properties.Resources.DVLDbackground1_resized;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnCloseRenewLicenseApp;
            this.ClientSize = new System.Drawing.Size(1204, 780);
            this.Controls.Add(this.lnklblShowLicenseHistory);
            this.Controls.Add(this.lnklblNewShowLicenseInfo);
            this.Controls.Add(this.btnExitRenewLDLApp);
            this.Controls.Add(this.btnCloseRenewLicenseApp);
            this.Controls.Add(this.btnRenewLicense);
            this.Controls.Add(this.ctrlRenewLicenseApplicationCard1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlDriverLicenseInfoWithFilter1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(199, 64);
            this.Name = "frmRenewLocalDrivingLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmRenewLocalDrivingLicense";
            this.Load += new System.EventHandler(this.frmRenewLocalDrivingLicense_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExitRenewLDLApp;
        private System.Windows.Forms.Label label1;
        private ctrlRenewLicenseApplicationCard ctrlRenewLicenseApplicationCard1;
        private System.Windows.Forms.Button btnCloseRenewLicenseApp;
        private System.Windows.Forms.Button btnRenewLicense;
        private System.Windows.Forms.LinkLabel lnklblShowLicenseHistory;
        private System.Windows.Forms.LinkLabel lnklblNewShowLicenseInfo;
        private ctrlDriverLicenseInfoWithFilter ctrlDriverLicenseInfoWithFilter1;
    }
}