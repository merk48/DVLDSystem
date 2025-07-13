namespace DVLD_Mery
{
    partial class ctrlDriverLicenseInfoWithFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ctrlDriverLicenseCard1 = new DVLD_Mery.ctrlDriverLicenseCard();
            this.gbLicenseFilter = new System.Windows.Forms.GroupBox();
            this.btnSearchLicense = new System.Windows.Forms.Button();
            this.txtLicenseToSelect = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbLicenseFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlDriverLicenseCard1
            // 
            this.ctrlDriverLicenseCard1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlDriverLicenseCard1.Location = new System.Drawing.Point(-1, 0);
            this.ctrlDriverLicenseCard1.Name = "ctrlDriverLicenseCard1";
            this.ctrlDriverLicenseCard1.Size = new System.Drawing.Size(1173, 463);
            this.ctrlDriverLicenseCard1.TabIndex = 0;
            // 
            // gbLicenseFilter
            // 
            this.gbLicenseFilter.BackColor = System.Drawing.Color.Transparent;
            this.gbLicenseFilter.Controls.Add(this.btnSearchLicense);
            this.gbLicenseFilter.Controls.Add(this.txtLicenseToSelect);
            this.gbLicenseFilter.Controls.Add(this.label3);
            this.gbLicenseFilter.ForeColor = System.Drawing.Color.Crimson;
            this.gbLicenseFilter.Location = new System.Drawing.Point(642, 3);
            this.gbLicenseFilter.Name = "gbLicenseFilter";
            this.gbLicenseFilter.Size = new System.Drawing.Size(525, 55);
            this.gbLicenseFilter.TabIndex = 155;
            this.gbLicenseFilter.TabStop = false;
            this.gbLicenseFilter.Text = "Filter";
            // 
            // btnSearchLicense
            // 
            this.btnSearchLicense.BackgroundImage = global::DVLD_Mery.Properties.Resources.License_View_322;
            this.btnSearchLicense.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearchLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchLicense.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchLicense.ForeColor = System.Drawing.Color.Crimson;
            this.btnSearchLicense.Location = new System.Drawing.Point(429, 11);
            this.btnSearchLicense.Name = "btnSearchLicense";
            this.btnSearchLicense.Size = new System.Drawing.Size(62, 36);
            this.btnSearchLicense.TabIndex = 45;
            this.btnSearchLicense.UseVisualStyleBackColor = true;
            this.btnSearchLicense.Click += new System.EventHandler(this.btnSearchLicense_Click);
            // 
            // txtLicenseToSelect
            // 
            this.txtLicenseToSelect.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLicenseToSelect.ForeColor = System.Drawing.Color.Crimson;
            this.txtLicenseToSelect.Location = new System.Drawing.Point(139, 16);
            this.txtLicenseToSelect.Name = "txtLicenseToSelect";
            this.txtLicenseToSelect.Size = new System.Drawing.Size(268, 27);
            this.txtLicenseToSelect.TabIndex = 34;
            this.txtLicenseToSelect.TextChanged += new System.EventHandler(this.txtLicenseToSelect_TextChanged);
            this.txtLicenseToSelect.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLicenseToSelect_KeyPress);
            this.txtLicenseToSelect.Validating += new System.ComponentModel.CancelEventHandler(this.txtLicenseToSelect_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(25, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 18);
            this.label3.TabIndex = 32;
            this.label3.Text = "LicenseID:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlDriverLicenseInfoWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gbLicenseFilter);
            this.Controls.Add(this.ctrlDriverLicenseCard1);
            this.Name = "ctrlDriverLicenseInfoWithFilter";
            this.Size = new System.Drawing.Size(1171, 461);
            this.Load += new System.EventHandler(this.ctrlDriverLicenseInfoWithFilter_Load);
            this.gbLicenseFilter.ResumeLayout(false);
            this.gbLicenseFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlDriverLicenseCard ctrlDriverLicenseCard1;
        public System.Windows.Forms.GroupBox gbLicenseFilter;
        private System.Windows.Forms.Button btnSearchLicense;
        public System.Windows.Forms.TextBox txtLicenseToSelect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
