namespace DVLD_Mery
{
    partial class frmShowInternatioanlLicenseDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowInternatioanlLicenseDetails));
            this.ctrlDriverInternationalLicenseCard1 = new DVLD_Mery.ctrlDriverInternationalLicenseCard();
            this.lblCardTitle = new System.Windows.Forms.Label();
            this.btnExitIntLAppDetailsCard = new System.Windows.Forms.Button();
            this.btnCloseIssueDrivingLicense = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlDriverInternationalLicenseCard1
            // 
            this.ctrlDriverInternationalLicenseCard1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlDriverInternationalLicenseCard1.Location = new System.Drawing.Point(15, 177);
            this.ctrlDriverInternationalLicenseCard1.Name = "ctrlDriverInternationalLicenseCard1";
            this.ctrlDriverInternationalLicenseCard1.Size = new System.Drawing.Size(1171, 348);
            this.ctrlDriverInternationalLicenseCard1.TabIndex = 0;
            // 
            // lblCardTitle
            // 
            this.lblCardTitle.AutoSize = true;
            this.lblCardTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCardTitle.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblCardTitle.Location = new System.Drawing.Point(374, 122);
            this.lblCardTitle.Name = "lblCardTitle";
            this.lblCardTitle.Size = new System.Drawing.Size(489, 37);
            this.lblCardTitle.TabIndex = 131;
            this.lblCardTitle.Text = "Driver International License Info";
            // 
            // btnExitIntLAppDetailsCard
            // 
            this.btnExitIntLAppDetailsCard.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnExitIntLAppDetailsCard.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnExitIntLAppDetailsCard.ForeColor = System.Drawing.Color.White;
            this.btnExitIntLAppDetailsCard.Location = new System.Drawing.Point(1149, 5);
            this.btnExitIntLAppDetailsCard.Name = "btnExitIntLAppDetailsCard";
            this.btnExitIntLAppDetailsCard.Size = new System.Drawing.Size(50, 43);
            this.btnExitIntLAppDetailsCard.TabIndex = 133;
            this.btnExitIntLAppDetailsCard.Text = "X";
            this.btnExitIntLAppDetailsCard.UseVisualStyleBackColor = false;
            this.btnExitIntLAppDetailsCard.Click += new System.EventHandler(this.btnExitIntLAppDetailsCard_Click);
            // 
            // btnCloseIssueDrivingLicense
            // 
            this.btnCloseIssueDrivingLicense.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCloseIssueDrivingLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseIssueDrivingLicense.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseIssueDrivingLicense.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCloseIssueDrivingLicense.Image = global::DVLD_Mery.Properties.Resources.Close_321;
            this.btnCloseIssueDrivingLicense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseIssueDrivingLicense.Location = new System.Drawing.Point(1080, 548);
            this.btnCloseIssueDrivingLicense.Name = "btnCloseIssueDrivingLicense";
            this.btnCloseIssueDrivingLicense.Size = new System.Drawing.Size(104, 35);
            this.btnCloseIssueDrivingLicense.TabIndex = 134;
            this.btnCloseIssueDrivingLicense.Text = "Close";
            this.btnCloseIssueDrivingLicense.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCloseIssueDrivingLicense.UseVisualStyleBackColor = true;
            this.btnCloseIssueDrivingLicense.Click += new System.EventHandler(this.btnExitIntLAppDetailsCard_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::DVLD_Mery.Properties.Resources.Local_Driving_License_512;
            this.pictureBox1.Location = new System.Drawing.Point(556, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 136;
            this.pictureBox1.TabStop = false;
            // 
            // frmShowInternatioanlLicenseDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DVLD_Mery.Properties.Resources.DVLDbackground1_resized;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnCloseIssueDrivingLicense;
            this.ClientSize = new System.Drawing.Size(1204, 616);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCloseIssueDrivingLicense);
            this.Controls.Add(this.btnExitIntLAppDetailsCard);
            this.Controls.Add(this.lblCardTitle);
            this.Controls.Add(this.ctrlDriverInternationalLicenseCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmShowInternatioanlLicenseDetails";
            this.Text = "frmShowInternatioanlLicenseDetails";
            this.Load += new System.EventHandler(this.frmShowInternatioanlLicenseDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlDriverInternationalLicenseCard ctrlDriverInternationalLicenseCard1;
        private System.Windows.Forms.Label lblCardTitle;
        private System.Windows.Forms.Button btnExitIntLAppDetailsCard;
        private System.Windows.Forms.Button btnCloseIssueDrivingLicense;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}