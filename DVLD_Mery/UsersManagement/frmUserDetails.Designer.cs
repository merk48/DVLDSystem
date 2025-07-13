namespace DVLD_Mery
{
    partial class frmUserDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserDetails));
            this.lblCardTitle = new System.Windows.Forms.Label();
            this.btnCloseUserDetailsCard = new System.Windows.Forms.Button();
            this.btnExitUserDetailsCard = new System.Windows.Forms.Button();
            this.ctrlUserCard1 = new DVLD_Mery.ctrlUserCard();
            this.SuspendLayout();
            // 
            // lblCardTitle
            // 
            this.lblCardTitle.AutoSize = true;
            this.lblCardTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCardTitle.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblCardTitle.Location = new System.Drawing.Point(490, 25);
            this.lblCardTitle.Name = "lblCardTitle";
            this.lblCardTitle.Size = new System.Drawing.Size(193, 37);
            this.lblCardTitle.TabIndex = 99;
            this.lblCardTitle.Text = "User Details";
            // 
            // btnCloseUserDetailsCard
            // 
            this.btnCloseUserDetailsCard.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCloseUserDetailsCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseUserDetailsCard.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseUserDetailsCard.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCloseUserDetailsCard.Image = global::DVLD_Mery.Properties.Resources.Close_32;
            this.btnCloseUserDetailsCard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseUserDetailsCard.Location = new System.Drawing.Point(1081, 572);
            this.btnCloseUserDetailsCard.Name = "btnCloseUserDetailsCard";
            this.btnCloseUserDetailsCard.Size = new System.Drawing.Size(105, 31);
            this.btnCloseUserDetailsCard.TabIndex = 120;
            this.btnCloseUserDetailsCard.Text = "Close";
            this.btnCloseUserDetailsCard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCloseUserDetailsCard.UseVisualStyleBackColor = true;
            this.btnCloseUserDetailsCard.Click += new System.EventHandler(this.btnExitUserDetailsCard_Click);
            // 
            // btnExitUserDetailsCard
            // 
            this.btnExitUserDetailsCard.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnExitUserDetailsCard.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnExitUserDetailsCard.ForeColor = System.Drawing.Color.White;
            this.btnExitUserDetailsCard.Location = new System.Drawing.Point(1145, 7);
            this.btnExitUserDetailsCard.Name = "btnExitUserDetailsCard";
            this.btnExitUserDetailsCard.Size = new System.Drawing.Size(50, 43);
            this.btnExitUserDetailsCard.TabIndex = 129;
            this.btnExitUserDetailsCard.Text = "X";
            this.btnExitUserDetailsCard.UseVisualStyleBackColor = false;
            this.btnExitUserDetailsCard.Click += new System.EventHandler(this.btnExitUserDetailsCard_Click);
            // 
            // ctrlUserCard1
            // 
            this.ctrlUserCard1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlUserCard1.Location = new System.Drawing.Point(16, 91);
            this.ctrlUserCard1.Name = "ctrlUserCard1";
            this.ctrlUserCard1.Size = new System.Drawing.Size(1172, 461);
            this.ctrlUserCard1.TabIndex = 130;
            // 
            // frmUserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DVLD_Mery.Properties.Resources.DVLDbackground1_resized;
            this.CancelButton = this.btnCloseUserDetailsCard;
            this.ClientSize = new System.Drawing.Size(1204, 616);
            this.Controls.Add(this.ctrlUserCard1);
            this.Controls.Add(this.btnExitUserDetailsCard);
            this.Controls.Add(this.btnCloseUserDetailsCard);
            this.Controls.Add(this.lblCardTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUserDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUserDetails";
            this.Load += new System.EventHandler(this.frmUserDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCardTitle;
        private System.Windows.Forms.Button btnCloseUserDetailsCard;
        private System.Windows.Forms.Button btnExitUserDetailsCard;
        private ctrlUserCard ctrlUserCard1;
    }
}