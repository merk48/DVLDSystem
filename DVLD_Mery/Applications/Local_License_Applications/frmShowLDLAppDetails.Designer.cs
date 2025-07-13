namespace DVLD_Mery
{
    partial class frmShowLDLAppDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowLDLAppDetails));
            this.btnExitLDLAppDetailsCard = new System.Windows.Forms.Button();
            this.btnCloseLDLAppDetailsCard = new System.Windows.Forms.Button();
            this.lblCardTitle = new System.Windows.Forms.Label();
            this.ctrlLDLAppCard1 = new DVLD_Mery.ctrlLDLAppCard();
            this.SuspendLayout();
            // 
            // btnExitLDLAppDetailsCard
            // 
            this.btnExitLDLAppDetailsCard.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnExitLDLAppDetailsCard.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnExitLDLAppDetailsCard.ForeColor = System.Drawing.Color.White;
            this.btnExitLDLAppDetailsCard.Location = new System.Drawing.Point(1148, 6);
            this.btnExitLDLAppDetailsCard.Name = "btnExitLDLAppDetailsCard";
            this.btnExitLDLAppDetailsCard.Size = new System.Drawing.Size(50, 43);
            this.btnExitLDLAppDetailsCard.TabIndex = 132;
            this.btnExitLDLAppDetailsCard.Text = "X";
            this.btnExitLDLAppDetailsCard.UseVisualStyleBackColor = false;
            this.btnExitLDLAppDetailsCard.Click += new System.EventHandler(this.btnExitLDLAppDetailsCard_Click);
            // 
            // btnCloseLDLAppDetailsCard
            // 
            this.btnCloseLDLAppDetailsCard.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCloseLDLAppDetailsCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseLDLAppDetailsCard.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseLDLAppDetailsCard.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCloseLDLAppDetailsCard.Image = global::DVLD_Mery.Properties.Resources.Close_321;
            this.btnCloseLDLAppDetailsCard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseLDLAppDetailsCard.Location = new System.Drawing.Point(1080, 571);
            this.btnCloseLDLAppDetailsCard.Name = "btnCloseLDLAppDetailsCard";
            this.btnCloseLDLAppDetailsCard.Size = new System.Drawing.Size(105, 31);
            this.btnCloseLDLAppDetailsCard.TabIndex = 131;
            this.btnCloseLDLAppDetailsCard.Text = "Close";
            this.btnCloseLDLAppDetailsCard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCloseLDLAppDetailsCard.UseVisualStyleBackColor = true;
            this.btnCloseLDLAppDetailsCard.Click += new System.EventHandler(this.btnExitLDLAppDetailsCard_Click);
            // 
            // lblCardTitle
            // 
            this.lblCardTitle.AutoSize = true;
            this.lblCardTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCardTitle.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblCardTitle.Location = new System.Drawing.Point(297, 67);
            this.lblCardTitle.Name = "lblCardTitle";
            this.lblCardTitle.Size = new System.Drawing.Size(612, 37);
            this.lblCardTitle.TabIndex = 130;
            this.lblCardTitle.Text = "Local Driving License Application Details";
            // 
            // ctrlLDLAppCard1
            // 
            this.ctrlLDLAppCard1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlLDLAppCard1.Location = new System.Drawing.Point(16, 119);
            this.ctrlLDLAppCard1.Name = "ctrlLDLAppCard1";
            this.ctrlLDLAppCard1.Size = new System.Drawing.Size(1172, 426);
            this.ctrlLDLAppCard1.TabIndex = 133;
            // 
            // frmShowLDLAppDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DVLD_Mery.Properties.Resources.DVLDbackground1_resized;
            this.CancelButton = this.btnCloseLDLAppDetailsCard;
            this.ClientSize = new System.Drawing.Size(1204, 616);
            this.Controls.Add(this.ctrlLDLAppCard1);
            this.Controls.Add(this.btnExitLDLAppDetailsCard);
            this.Controls.Add(this.btnCloseLDLAppDetailsCard);
            this.Controls.Add(this.lblCardTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmShowLDLAppDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmShowLDLAppDetails";
            this.Load += new System.EventHandler(this.frmShowLDLAppDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExitLDLAppDetailsCard;
        private System.Windows.Forms.Button btnCloseLDLAppDetailsCard;
        private System.Windows.Forms.Label lblCardTitle;
        private ctrlLDLAppCard ctrlLDLAppCard1;
    }
}