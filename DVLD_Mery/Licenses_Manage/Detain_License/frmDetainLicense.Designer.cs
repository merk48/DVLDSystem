namespace DVLD_Mery
{
    partial class frmDetainLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetainLicense));
            this.lblTestAppointmentTitle = new System.Windows.Forms.Label();
            this.btnExitDetainLicenseForm = new System.Windows.Forms.Button();
            this.lnklblShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.btnCloseDetainLicense = new System.Windows.Forms.Button();
            this.btnDetainLicense = new System.Windows.Forms.Button();
            this.ctrlDetainLicenseInfo1 = new DVLD_Mery.ctrlDetainLicenseCard();
            this.ctrlDriverLicenseInfoWithFilter1 = new DVLD_Mery.ctrlDriverLicenseInfoWithFilter();
            this.SuspendLayout();
            // 
            // lblTestAppointmentTitle
            // 
            this.lblTestAppointmentTitle.AutoSize = true;
            this.lblTestAppointmentTitle.BackColor = System.Drawing.Color.White;
            this.lblTestAppointmentTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTestAppointmentTitle.Font = new System.Drawing.Font("Montserrat", 22F, System.Drawing.FontStyle.Bold);
            this.lblTestAppointmentTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTestAppointmentTitle.Location = new System.Drawing.Point(482, 16);
            this.lblTestAppointmentTitle.Name = "lblTestAppointmentTitle";
            this.lblTestAppointmentTitle.Size = new System.Drawing.Size(255, 39);
            this.lblTestAppointmentTitle.TabIndex = 111;
            this.lblTestAppointmentTitle.Text = "Detain License";
            // 
            // btnExitDetainLicenseForm
            // 
            this.btnExitDetainLicenseForm.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnExitDetainLicenseForm.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnExitDetainLicenseForm.ForeColor = System.Drawing.Color.White;
            this.btnExitDetainLicenseForm.Location = new System.Drawing.Point(1149, 4);
            this.btnExitDetainLicenseForm.Name = "btnExitDetainLicenseForm";
            this.btnExitDetainLicenseForm.Size = new System.Drawing.Size(50, 43);
            this.btnExitDetainLicenseForm.TabIndex = 112;
            this.btnExitDetainLicenseForm.Text = "X";
            this.btnExitDetainLicenseForm.UseVisualStyleBackColor = false;
            this.btnExitDetainLicenseForm.Click += new System.EventHandler(this.btnExitDetainLicenseForm_Click);
            // 
            // lnklblShowLicenseHistory
            // 
            this.lnklblShowLicenseHistory.ActiveLinkColor = System.Drawing.Color.Black;
            this.lnklblShowLicenseHistory.AutoSize = true;
            this.lnklblShowLicenseHistory.BackColor = System.Drawing.Color.Transparent;
            this.lnklblShowLicenseHistory.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklblShowLicenseHistory.ForeColor = System.Drawing.Color.White;
            this.lnklblShowLicenseHistory.LinkColor = System.Drawing.Color.White;
            this.lnklblShowLicenseHistory.Location = new System.Drawing.Point(19, 733);
            this.lnklblShowLicenseHistory.Name = "lnklblShowLicenseHistory";
            this.lnklblShowLicenseHistory.Size = new System.Drawing.Size(192, 19);
            this.lnklblShowLicenseHistory.TabIndex = 149;
            this.lnklblShowLicenseHistory.TabStop = true;
            this.lnklblShowLicenseHistory.Text = "Show License History";
            this.lnklblShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblShowLicenseHistory_LinkClicked);
            // 
            // btnCloseDetainLicense
            // 
            this.btnCloseDetainLicense.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCloseDetainLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseDetainLicense.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseDetainLicense.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCloseDetainLicense.Image = global::DVLD_Mery.Properties.Resources.Close_321;
            this.btnCloseDetainLicense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseDetainLicense.Location = new System.Drawing.Point(953, 725);
            this.btnCloseDetainLicense.Name = "btnCloseDetainLicense";
            this.btnCloseDetainLicense.Size = new System.Drawing.Size(113, 35);
            this.btnCloseDetainLicense.TabIndex = 147;
            this.btnCloseDetainLicense.Text = "Close";
            this.btnCloseDetainLicense.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCloseDetainLicense.UseVisualStyleBackColor = true;
            this.btnCloseDetainLicense.Click += new System.EventHandler(this.btnExitDetainLicenseForm_Click);
            // 
            // btnDetainLicense
            // 
            this.btnDetainLicense.BackColor = System.Drawing.Color.White;
            this.btnDetainLicense.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDetainLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetainLicense.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.btnDetainLicense.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDetainLicense.Image = global::DVLD_Mery.Properties.Resources.Detain_32;
            this.btnDetainLicense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetainLicense.Location = new System.Drawing.Point(1073, 725);
            this.btnDetainLicense.Name = "btnDetainLicense";
            this.btnDetainLicense.Size = new System.Drawing.Size(113, 35);
            this.btnDetainLicense.TabIndex = 146;
            this.btnDetainLicense.Text = "Detain";
            this.btnDetainLicense.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDetainLicense.UseVisualStyleBackColor = false;
            this.btnDetainLicense.Click += new System.EventHandler(this.btnDetainLicense_Click);
            // 
            // ctrlDetainLicenseInfo1
            // 
            this.ctrlDetainLicenseInfo1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlDetainLicenseInfo1.Location = new System.Drawing.Point(17, 554);
            this.ctrlDetainLicenseInfo1.Name = "ctrlDetainLicenseInfo1";
            this.ctrlDetainLicenseInfo1.Size = new System.Drawing.Size(1171, 155);
            this.ctrlDetainLicenseInfo1.TabIndex = 150;
            // 
            // ctrlDriverLicenseInfoWithFilter1
            // 
            this.ctrlDriverLicenseInfoWithFilter1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlDriverLicenseInfoWithFilter1.Location = new System.Drawing.Point(17, 71);
            this.ctrlDriverLicenseInfoWithFilter1.Name = "ctrlDriverLicenseInfoWithFilter1";
            this.ctrlDriverLicenseInfoWithFilter1.Size = new System.Drawing.Size(1171, 461);
            this.ctrlDriverLicenseInfoWithFilter1.TabIndex = 151;
            this.ctrlDriverLicenseInfoWithFilter1.OnLicenseSelected += new System.EventHandler<DVLD_Mery.ctrlDriverLicenseInfoWithFilter.LicenseSelectedEventsArgs>(this.ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected);
            // 
            // frmDetainLicense
            // 
            this.AcceptButton = this.btnDetainLicense;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DVLD_Mery.Properties.Resources.DVLDbackground1_resized;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnCloseDetainLicense;
            this.ClientSize = new System.Drawing.Size(1204, 780);
            this.Controls.Add(this.ctrlDriverLicenseInfoWithFilter1);
            this.Controls.Add(this.btnExitDetainLicenseForm);
            this.Controls.Add(this.ctrlDetainLicenseInfo1);
            this.Controls.Add(this.lblTestAppointmentTitle);
            this.Controls.Add(this.lnklblShowLicenseHistory);
            this.Controls.Add(this.btnCloseDetainLicense);
            this.Controls.Add(this.btnDetainLicense);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(199, 64);
            this.Name = "frmDetainLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmDetainLicense";
            this.Load += new System.EventHandler(this.frmDetainLicense_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTestAppointmentTitle;
        private System.Windows.Forms.Button btnExitDetainLicenseForm;
        private System.Windows.Forms.LinkLabel lnklblShowLicenseHistory;
        private System.Windows.Forms.Button btnCloseDetainLicense;
        private System.Windows.Forms.Button btnDetainLicense;
        private ctrlDetainLicenseCard ctrlDetainLicenseInfo1;
        private ctrlDriverLicenseInfoWithFilter ctrlDriverLicenseInfoWithFilter1;
    }
}