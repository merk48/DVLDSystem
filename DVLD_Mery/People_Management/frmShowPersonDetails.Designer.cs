namespace DVLD_Mery
{
    partial class frmShowPersonDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowPersonDetails));
            this.lblCardTitle = new System.Windows.Forms.Label();
            this.btnExitPersonDetailsCard = new System.Windows.Forms.Button();
            this.btnClosePersonDetailsCard = new System.Windows.Forms.Button();
            this.ctrlPersonCard1 = new DVLD_Mery.ctrlPersonCard();
            this.SuspendLayout();
            // 
            // lblCardTitle
            // 
            this.lblCardTitle.AutoSize = true;
            this.lblCardTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCardTitle.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblCardTitle.Location = new System.Drawing.Point(479, 63);
            this.lblCardTitle.Name = "lblCardTitle";
            this.lblCardTitle.Size = new System.Drawing.Size(229, 37);
            this.lblCardTitle.TabIndex = 98;
            this.lblCardTitle.Text = "Person Details";
            // 
            // btnExitPersonDetailsCard
            // 
            this.btnExitPersonDetailsCard.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnExitPersonDetailsCard.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnExitPersonDetailsCard.ForeColor = System.Drawing.Color.White;
            this.btnExitPersonDetailsCard.Location = new System.Drawing.Point(1150, 3);
            this.btnExitPersonDetailsCard.Name = "btnExitPersonDetailsCard";
            this.btnExitPersonDetailsCard.Size = new System.Drawing.Size(50, 43);
            this.btnExitPersonDetailsCard.TabIndex = 129;
            this.btnExitPersonDetailsCard.Text = "X";
            this.btnExitPersonDetailsCard.UseVisualStyleBackColor = false;
            this.btnExitPersonDetailsCard.Click += new System.EventHandler(this.btnExitPersonDetailsCard_Click);
            // 
            // btnClosePersonDetailsCard
            // 
            this.btnClosePersonDetailsCard.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClosePersonDetailsCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClosePersonDetailsCard.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClosePersonDetailsCard.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnClosePersonDetailsCard.Image = global::DVLD_Mery.Properties.Resources.Close_321;
            this.btnClosePersonDetailsCard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClosePersonDetailsCard.Location = new System.Drawing.Point(1080, 519);
            this.btnClosePersonDetailsCard.Name = "btnClosePersonDetailsCard";
            this.btnClosePersonDetailsCard.Size = new System.Drawing.Size(104, 35);
            this.btnClosePersonDetailsCard.TabIndex = 133;
            this.btnClosePersonDetailsCard.Text = "Close";
            this.btnClosePersonDetailsCard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClosePersonDetailsCard.UseVisualStyleBackColor = true;
            this.btnClosePersonDetailsCard.Click += new System.EventHandler(this.btnExitPersonDetailsCard_Click);
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlPersonCard1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlPersonCard1.Location = new System.Drawing.Point(14, 136);
            this.ctrlPersonCard1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(1174, 366);
            this.ctrlPersonCard1.TabIndex = 134;
            // 
            // frmPersonDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DVLD_Mery.Properties.Resources.DVLDbackground1_resized;
            this.CancelButton = this.btnClosePersonDetailsCard;
            this.ClientSize = new System.Drawing.Size(1204, 616);
            this.Controls.Add(this.ctrlPersonCard1);
            this.Controls.Add(this.btnExitPersonDetailsCard);
            this.Controls.Add(this.lblCardTitle);
            this.Controls.Add(this.btnClosePersonDetailsCard);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPersonDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPersonDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCardTitle;
        private System.Windows.Forms.Button btnExitPersonDetailsCard;
        private System.Windows.Forms.Button btnClosePersonDetailsCard;
        private ctrlPersonCard ctrlPersonCard1;
    }
}