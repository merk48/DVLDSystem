namespace DVLD_Mery
{
    partial class frmReplaceLicenseForLostOrDamagedLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReplaceLicenseForLostOrDamagedLicense));
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnExitReplacemenLicenseApp = new System.Windows.Forms.Button();
            this.gbReplacementFor = new System.Windows.Forms.GroupBox();
            this.rbLostLicense = new System.Windows.Forms.RadioButton();
            this.rbDamageLicense = new System.Windows.Forms.RadioButton();
            this.ctrlReplacementApplicationInfoCard1 = new DVLD_Mery.ctrlReplacementApplicationInfoCard();
            this.lnklblShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.lnklblShowNewLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.btnCloseReplacemenLicenseApp = new System.Windows.Forms.Button();
            this.btnReplaceLicense = new System.Windows.Forms.Button();
            this.ctrlDriverLicenseInfoWithFilter1 = new DVLD_Mery.ctrlDriverLicenseInfoWithFilter();
            this.gbReplacementFor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.Font = new System.Drawing.Font("Montserrat", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitle.Location = new System.Drawing.Point(327, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(584, 39);
            this.lblTitle.TabIndex = 45;
            this.lblTitle.Text = "Replacement for Damaged License";
            // 
            // btnExitReplacemenLicenseApp
            // 
            this.btnExitReplacemenLicenseApp.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnExitReplacemenLicenseApp.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnExitReplacemenLicenseApp.ForeColor = System.Drawing.Color.White;
            this.btnExitReplacemenLicenseApp.Location = new System.Drawing.Point(1151, 5);
            this.btnExitReplacemenLicenseApp.Name = "btnExitReplacemenLicenseApp";
            this.btnExitReplacemenLicenseApp.Size = new System.Drawing.Size(50, 43);
            this.btnExitReplacemenLicenseApp.TabIndex = 44;
            this.btnExitReplacemenLicenseApp.Text = "X";
            this.btnExitReplacemenLicenseApp.UseVisualStyleBackColor = false;
            this.btnExitReplacemenLicenseApp.Click += new System.EventHandler(this.btnExitReplacemenLicenseApp_Click);
            // 
            // gbReplacementFor
            // 
            this.gbReplacementFor.BackColor = System.Drawing.Color.Transparent;
            this.gbReplacementFor.Controls.Add(this.rbLostLicense);
            this.gbReplacementFor.Controls.Add(this.rbDamageLicense);
            this.gbReplacementFor.ForeColor = System.Drawing.Color.Crimson;
            this.gbReplacementFor.Location = new System.Drawing.Point(661, 124);
            this.gbReplacementFor.Name = "gbReplacementFor";
            this.gbReplacementFor.Size = new System.Drawing.Size(525, 38);
            this.gbReplacementFor.TabIndex = 44;
            this.gbReplacementFor.TabStop = false;
            this.gbReplacementFor.Text = "Replacement For";
            // 
            // rbLostLicense
            // 
            this.rbLostLicense.AutoSize = true;
            this.rbLostLicense.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.rbLostLicense.Location = new System.Drawing.Point(300, 11);
            this.rbLostLicense.Name = "rbLostLicense";
            this.rbLostLicense.Size = new System.Drawing.Size(126, 22);
            this.rbLostLicense.TabIndex = 1;
            this.rbLostLicense.TabStop = true;
            this.rbLostLicense.Text = "Lost License";
            this.rbLostLicense.UseVisualStyleBackColor = true;
            this.rbLostLicense.CheckedChanged += new System.EventHandler(this.rbDamageLostLicense_CheckedChanged);
            // 
            // rbDamageLicense
            // 
            this.rbDamageLicense.AutoSize = true;
            this.rbDamageLicense.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.rbDamageLicense.Location = new System.Drawing.Point(115, 11);
            this.rbDamageLicense.Name = "rbDamageLicense";
            this.rbDamageLicense.Size = new System.Drawing.Size(157, 22);
            this.rbDamageLicense.TabIndex = 0;
            this.rbDamageLicense.TabStop = true;
            this.rbDamageLicense.Text = "Damage License";
            this.rbDamageLicense.UseVisualStyleBackColor = true;
            this.rbDamageLicense.CheckedChanged += new System.EventHandler(this.rbDamageLostLicense_CheckedChanged);
            // 
            // ctrlReplacementApplicationInfoCard1
            // 
            this.ctrlReplacementApplicationInfoCard1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlReplacementApplicationInfoCard1.Location = new System.Drawing.Point(16, 538);
            this.ctrlReplacementApplicationInfoCard1.Name = "ctrlReplacementApplicationInfoCard1";
            this.ctrlReplacementApplicationInfoCard1.Size = new System.Drawing.Size(1171, 160);
            this.ctrlReplacementApplicationInfoCard1.TabIndex = 139;
            // 
            // lnklblShowLicenseHistory
            // 
            this.lnklblShowLicenseHistory.ActiveLinkColor = System.Drawing.Color.Black;
            this.lnklblShowLicenseHistory.AutoSize = true;
            this.lnklblShowLicenseHistory.BackColor = System.Drawing.Color.Transparent;
            this.lnklblShowLicenseHistory.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklblShowLicenseHistory.ForeColor = System.Drawing.Color.White;
            this.lnklblShowLicenseHistory.LinkColor = System.Drawing.Color.White;
            this.lnklblShowLicenseHistory.Location = new System.Drawing.Point(15, 735);
            this.lnklblShowLicenseHistory.Name = "lnklblShowLicenseHistory";
            this.lnklblShowLicenseHistory.Size = new System.Drawing.Size(192, 19);
            this.lnklblShowLicenseHistory.TabIndex = 143;
            this.lnklblShowLicenseHistory.TabStop = true;
            this.lnklblShowLicenseHistory.Text = "Show License History";
            this.lnklblShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblShowLicenseHistory_LinkClicked);
            // 
            // lnklblShowNewLicenseInfo
            // 
            this.lnklblShowNewLicenseInfo.ActiveLinkColor = System.Drawing.Color.Black;
            this.lnklblShowNewLicenseInfo.AutoSize = true;
            this.lnklblShowNewLicenseInfo.BackColor = System.Drawing.Color.Transparent;
            this.lnklblShowNewLicenseInfo.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklblShowNewLicenseInfo.ForeColor = System.Drawing.Color.White;
            this.lnklblShowNewLicenseInfo.LinkColor = System.Drawing.Color.White;
            this.lnklblShowNewLicenseInfo.Location = new System.Drawing.Point(208, 735);
            this.lnklblShowNewLicenseInfo.Name = "lnklblShowNewLicenseInfo";
            this.lnklblShowNewLicenseInfo.Size = new System.Drawing.Size(209, 19);
            this.lnklblShowNewLicenseInfo.TabIndex = 142;
            this.lnklblShowNewLicenseInfo.TabStop = true;
            this.lnklblShowNewLicenseInfo.Text = "Show New License Info";
            this.lnklblShowNewLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblShowLicenseInfo_LinkClicked);
            // 
            // btnCloseReplacemenLicenseApp
            // 
            this.btnCloseReplacemenLicenseApp.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCloseReplacemenLicenseApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseReplacemenLicenseApp.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseReplacemenLicenseApp.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCloseReplacemenLicenseApp.Image = global::DVLD_Mery.Properties.Resources.Close_321;
            this.btnCloseReplacemenLicenseApp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseReplacemenLicenseApp.Location = new System.Drawing.Point(838, 727);
            this.btnCloseReplacemenLicenseApp.Name = "btnCloseReplacemenLicenseApp";
            this.btnCloseReplacemenLicenseApp.Size = new System.Drawing.Size(104, 35);
            this.btnCloseReplacemenLicenseApp.TabIndex = 141;
            this.btnCloseReplacemenLicenseApp.Text = "Close";
            this.btnCloseReplacemenLicenseApp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCloseReplacemenLicenseApp.UseVisualStyleBackColor = true;
            this.btnCloseReplacemenLicenseApp.Click += new System.EventHandler(this.btnExitReplacemenLicenseApp_Click);
            // 
            // btnReplaceLicense
            // 
            this.btnReplaceLicense.BackColor = System.Drawing.Color.White;
            this.btnReplaceLicense.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReplaceLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReplaceLicense.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.btnReplaceLicense.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnReplaceLicense.Image = global::DVLD_Mery.Properties.Resources.Renew_Driving_License_32;
            this.btnReplaceLicense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReplaceLicense.Location = new System.Drawing.Point(962, 727);
            this.btnReplaceLicense.Name = "btnReplaceLicense";
            this.btnReplaceLicense.Size = new System.Drawing.Size(222, 35);
            this.btnReplaceLicense.TabIndex = 140;
            this.btnReplaceLicense.Text = "Issue Replacement";
            this.btnReplaceLicense.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReplaceLicense.UseVisualStyleBackColor = false;
            this.btnReplaceLicense.Click += new System.EventHandler(this.btnReplaceLicense_Click);
            // 
            // ctrlDriverLicenseInfoWithFilter1
            // 
            this.ctrlDriverLicenseInfoWithFilter1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlDriverLicenseInfoWithFilter1.Location = new System.Drawing.Point(18, 71);
            this.ctrlDriverLicenseInfoWithFilter1.Name = "ctrlDriverLicenseInfoWithFilter1";
            this.ctrlDriverLicenseInfoWithFilter1.Size = new System.Drawing.Size(1171, 461);
            this.ctrlDriverLicenseInfoWithFilter1.TabIndex = 144;
            this.ctrlDriverLicenseInfoWithFilter1.OnLicenseSelected += new System.EventHandler<DVLD_Mery.ctrlDriverLicenseInfoWithFilter.LicenseSelectedEventsArgs>(this.ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected);
            // 
            // frmReplaceLicenseForLostOrDamagedLicense
            // 
            this.AcceptButton = this.btnReplaceLicense;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DVLD_Mery.Properties.Resources.DVLDbackground1_resized;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnCloseReplacemenLicenseApp;
            this.ClientSize = new System.Drawing.Size(1204, 780);
            this.Controls.Add(this.gbReplacementFor);
            this.Controls.Add(this.ctrlDriverLicenseInfoWithFilter1);
            this.Controls.Add(this.lnklblShowLicenseHistory);
            this.Controls.Add(this.lnklblShowNewLicenseInfo);
            this.Controls.Add(this.btnCloseReplacemenLicenseApp);
            this.Controls.Add(this.btnReplaceLicense);
            this.Controls.Add(this.ctrlReplacementApplicationInfoCard1);
            this.Controls.Add(this.btnExitReplacemenLicenseApp);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(199, 64);
            this.Name = "frmReplaceLicenseForLostOrDamagedLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmReplaceLicenseForLostOrDamagedLicense";
            this.Load += new System.EventHandler(this.frmReplaceLicenseForLostOrDamagedLicense_Load);
            this.gbReplacementFor.ResumeLayout(false);
            this.gbReplacementFor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnExitReplacemenLicenseApp;
        private System.Windows.Forms.GroupBox gbReplacementFor;
        private System.Windows.Forms.RadioButton rbLostLicense;
        private System.Windows.Forms.RadioButton rbDamageLicense;
        private ctrlReplacementApplicationInfoCard ctrlReplacementApplicationInfoCard1;
        private System.Windows.Forms.LinkLabel lnklblShowLicenseHistory;
        private System.Windows.Forms.LinkLabel lnklblShowNewLicenseInfo;
        private System.Windows.Forms.Button btnCloseReplacemenLicenseApp;
        private System.Windows.Forms.Button btnReplaceLicense;
        private ctrlDriverLicenseInfoWithFilter ctrlDriverLicenseInfoWithFilter1;
    }
}