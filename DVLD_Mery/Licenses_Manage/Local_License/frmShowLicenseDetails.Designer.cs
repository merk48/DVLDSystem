namespace DVLD_Mery
{
    partial class frmShowLicenseDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowLicenseDetails));
            this.ctrlDriverLicenseCard1 = new DVLD_Mery.ctrlDriverLicenseCard();
            this.btnCloseIssueDrivingLicense = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.pb = new System.Windows.Forms.PictureBox();
            this.btnExitLicenseDetailsCard = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlDriverLicenseCard1
            // 
            this.ctrlDriverLicenseCard1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlDriverLicenseCard1.Location = new System.Drawing.Point(17, 133);
            this.ctrlDriverLicenseCard1.Name = "ctrlDriverLicenseCard1";
            this.ctrlDriverLicenseCard1.Size = new System.Drawing.Size(1173, 463);
            this.ctrlDriverLicenseCard1.TabIndex = 0;
            // 
            // btnCloseIssueDrivingLicense
            // 
            this.btnCloseIssueDrivingLicense.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCloseIssueDrivingLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseIssueDrivingLicense.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseIssueDrivingLicense.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCloseIssueDrivingLicense.Image = global::DVLD_Mery.Properties.Resources.Close_321;
            this.btnCloseIssueDrivingLicense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseIssueDrivingLicense.Location = new System.Drawing.Point(1081, 570);
            this.btnCloseIssueDrivingLicense.Name = "btnCloseIssueDrivingLicense";
            this.btnCloseIssueDrivingLicense.Size = new System.Drawing.Size(104, 35);
            this.btnCloseIssueDrivingLicense.TabIndex = 132;
            this.btnCloseIssueDrivingLicense.Text = "Close";
            this.btnCloseIssueDrivingLicense.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCloseIssueDrivingLicense.UseVisualStyleBackColor = true;
            this.btnCloseIssueDrivingLicense.Click += new System.EventHandler(this.btnCloseIssueDrivingLicense_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.Color.Transparent;
            this.lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl.Font = new System.Drawing.Font("Montserrat", 22F, System.Drawing.FontStyle.Bold);
            this.lbl.ForeColor = System.Drawing.Color.Navy;
            this.lbl.Location = new System.Drawing.Point(459, 94);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(319, 39);
            this.lbl.TabIndex = 133;
            this.lbl.Text = "Driver License Info";
            // 
            // pb
            // 
            this.pb.BackColor = System.Drawing.Color.Transparent;
            this.pb.Image = global::DVLD_Mery.Properties.Resources.Local_Driving_License_512;
            this.pb.Location = new System.Drawing.Point(545, 2);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(137, 92);
            this.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb.TabIndex = 134;
            this.pb.TabStop = false;
            // 
            // btnExitLicenseDetailsCard
            // 
            this.btnExitLicenseDetailsCard.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnExitLicenseDetailsCard.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnExitLicenseDetailsCard.ForeColor = System.Drawing.Color.White;
            this.btnExitLicenseDetailsCard.Location = new System.Drawing.Point(1149, 6);
            this.btnExitLicenseDetailsCard.Name = "btnExitLicenseDetailsCard";
            this.btnExitLicenseDetailsCard.Size = new System.Drawing.Size(50, 43);
            this.btnExitLicenseDetailsCard.TabIndex = 135;
            this.btnExitLicenseDetailsCard.Text = "X";
            this.btnExitLicenseDetailsCard.UseVisualStyleBackColor = false;
            this.btnExitLicenseDetailsCard.Click += new System.EventHandler(this.btnCloseIssueDrivingLicense_Click);
            // 
            // frmShowLicenseDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DVLD_Mery.Properties.Resources.DVLDbackground1_resized;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnCloseIssueDrivingLicense;
            this.ClientSize = new System.Drawing.Size(1204, 616);
            this.Controls.Add(this.btnExitLicenseDetailsCard);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.btnCloseIssueDrivingLicense);
            this.Controls.Add(this.ctrlDriverLicenseCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmShowLicenseDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLicenseDetails";
            this.Load += new System.EventHandler(this.frmShowLicenseDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlDriverLicenseCard ctrlDriverLicenseCard1;
        private System.Windows.Forms.Button btnCloseIssueDrivingLicense;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.Button btnExitLicenseDetailsCard;
    }
}