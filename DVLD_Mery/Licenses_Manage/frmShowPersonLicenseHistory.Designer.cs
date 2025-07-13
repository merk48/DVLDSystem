namespace DVLD_Mery
{
    partial class frmShowPersonLicenseHistory
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowPersonLicenseHistory));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvLocalLicenses = new System.Windows.Forms.DataGridView();
            this.cmsLDLicenseHistory = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowLicenseDetails = new System.Windows.Forms.ToolStripSeparator();
            this.ShowLicenseDetailstoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvInternationalLicenses = new System.Windows.Forms.DataGridView();
            this.cmsIntLicenseHistory = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ShowinternationalLicenseDetailsMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblLicensesRecords = new System.Windows.Forms.Label();
            this.btnCloseLicensesHistory = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExitLicensesHistory = new System.Windows.Forms.Button();
            this.ctrlPersonCard1 = new DVLD_Mery.ctrlPersonCard();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicenses)).BeginInit();
            this.cmsLDLicenseHistory.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicenses)).BeginInit();
            this.cmsIntLicenseHistory.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Montserrat", 22F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(452, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 39);
            this.label1.TabIndex = 95;
            this.label1.Text = "Licenses History";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::DVLD_Mery.Properties.Resources.PersonLicenseHistory_512;
            this.pictureBox1.Location = new System.Drawing.Point(524, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 100;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(14, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1143, 248);
            this.tabControl1.TabIndex = 101;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting_1);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.dgvLocalLicenses);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1135, 221);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Local";
            // 
            // dgvLocalLicenses
            // 
            this.dgvLocalLicenses.AllowUserToAddRows = false;
            this.dgvLocalLicenses.AllowUserToDeleteRows = false;
            this.dgvLocalLicenses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLocalLicenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLocalLicenses.BackgroundColor = System.Drawing.Color.White;
            this.dgvLocalLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalLicenses.ContextMenuStrip = this.cmsLDLicenseHistory;
            this.dgvLocalLicenses.Location = new System.Drawing.Point(14, 21);
            this.dgvLocalLicenses.Name = "dgvLocalLicenses";
            this.dgvLocalLicenses.ReadOnly = true;
            this.dgvLocalLicenses.Size = new System.Drawing.Size(1103, 182);
            this.dgvLocalLicenses.TabIndex = 120;
            // 
            // cmsLDLicenseHistory
            // 
            this.cmsLDLicenseHistory.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsLDLicenseHistory.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.cmsLDLicenseHistory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowLicenseDetails,
            this.ShowLicenseDetailstoolStripMenuItem});
            this.cmsLDLicenseHistory.Name = "cmsPerson";
            this.cmsLDLicenseHistory.Size = new System.Drawing.Size(215, 46);
            // 
            // ShowLicenseDetails
            // 
            this.ShowLicenseDetails.Name = "ShowLicenseDetails";
            this.ShowLicenseDetails.Size = new System.Drawing.Size(211, 6);
            // 
            // ShowLicenseDetailstoolStripMenuItem
            // 
            this.ShowLicenseDetailstoolStripMenuItem.Image = global::DVLD_Mery.Properties.Resources.License_View_32;
            this.ShowLicenseDetailstoolStripMenuItem.Name = "ShowLicenseDetailstoolStripMenuItem";
            this.ShowLicenseDetailstoolStripMenuItem.Size = new System.Drawing.Size(214, 36);
            this.ShowLicenseDetailstoolStripMenuItem.Text = "Show License Details";
            this.ShowLicenseDetailstoolStripMenuItem.Click += new System.EventHandler(this.ShowLicenseDetailstoolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(11, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 15);
            this.label3.TabIndex = 120;
            this.label3.Text = "Local Licenses History";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.dgvInternationalLicenses);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1135, 221);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "International";
            // 
            // dgvInternationalLicenses
            // 
            this.dgvInternationalLicenses.AllowUserToAddRows = false;
            this.dgvInternationalLicenses.AllowUserToDeleteRows = false;
            this.dgvInternationalLicenses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInternationalLicenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInternationalLicenses.BackgroundColor = System.Drawing.Color.White;
            this.dgvInternationalLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInternationalLicenses.ContextMenuStrip = this.cmsIntLicenseHistory;
            this.dgvInternationalLicenses.Location = new System.Drawing.Point(14, 21);
            this.dgvInternationalLicenses.Name = "dgvInternationalLicenses";
            this.dgvInternationalLicenses.ReadOnly = true;
            this.dgvInternationalLicenses.Size = new System.Drawing.Size(1103, 182);
            this.dgvInternationalLicenses.TabIndex = 121;
            // 
            // cmsIntLicenseHistory
            // 
            this.cmsIntLicenseHistory.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsIntLicenseHistory.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.cmsIntLicenseHistory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.ShowinternationalLicenseDetailsMenuItem1});
            this.cmsIntLicenseHistory.Name = "cmsPerson";
            this.cmsIntLicenseHistory.Size = new System.Drawing.Size(215, 46);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(211, 6);
            // 
            // ShowinternationalLicenseDetailsMenuItem1
            // 
            this.ShowinternationalLicenseDetailsMenuItem1.Image = global::DVLD_Mery.Properties.Resources.License_View_32;
            this.ShowinternationalLicenseDetailsMenuItem1.Name = "ShowinternationalLicenseDetailsMenuItem1";
            this.ShowinternationalLicenseDetailsMenuItem1.Size = new System.Drawing.Size(214, 36);
            this.ShowinternationalLicenseDetailsMenuItem1.Text = "Show License Details";
            this.ShowinternationalLicenseDetailsMenuItem1.Click += new System.EventHandler(this.ShowInternationalLicneseDetails_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(11, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 15);
            this.label4.TabIndex = 122;
            this.label4.Text = "International Licenses History";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(16, 466);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1169, 288);
            this.groupBox1.TabIndex = 102;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Driver Licenses";
            // 
            // lblLicensesRecords
            // 
            this.lblLicensesRecords.AutoSize = true;
            this.lblLicensesRecords.BackColor = System.Drawing.Color.Transparent;
            this.lblLicensesRecords.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.lblLicensesRecords.ForeColor = System.Drawing.Color.White;
            this.lblLicensesRecords.Location = new System.Drawing.Point(121, 753);
            this.lblLicensesRecords.Name = "lblLicensesRecords";
            this.lblLicensesRecords.Size = new System.Drawing.Size(23, 18);
            this.lblLicensesRecords.TabIndex = 118;
            this.lblLicensesRecords.Text = "...";
            // 
            // btnCloseLicensesHistory
            // 
            this.btnCloseLicensesHistory.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCloseLicensesHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseLicensesHistory.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseLicensesHistory.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCloseLicensesHistory.Image = global::DVLD_Mery.Properties.Resources.Close_32;
            this.btnCloseLicensesHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseLicensesHistory.Location = new System.Drawing.Point(1071, 740);
            this.btnCloseLicensesHistory.Name = "btnCloseLicensesHistory";
            this.btnCloseLicensesHistory.Size = new System.Drawing.Size(102, 31);
            this.btnCloseLicensesHistory.TabIndex = 119;
            this.btnCloseLicensesHistory.Text = "Close";
            this.btnCloseLicensesHistory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCloseLicensesHistory.UseVisualStyleBackColor = true;
            this.btnCloseLicensesHistory.Click += new System.EventHandler(this.btnCloseLicenseHistory_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 753);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 117;
            this.label2.Text = "# Records: ";
            // 
            // btnExitLicensesHistory
            // 
            this.btnExitLicensesHistory.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnExitLicensesHistory.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnExitLicensesHistory.ForeColor = System.Drawing.Color.White;
            this.btnExitLicensesHistory.Location = new System.Drawing.Point(1148, 5);
            this.btnExitLicensesHistory.Name = "btnExitLicensesHistory";
            this.btnExitLicensesHistory.Size = new System.Drawing.Size(50, 43);
            this.btnExitLicensesHistory.TabIndex = 120;
            this.btnExitLicensesHistory.Text = "X";
            this.btnExitLicensesHistory.UseVisualStyleBackColor = false;
            this.btnExitLicensesHistory.Click += new System.EventHandler(this.btnCloseLicenseHistory_Click);
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlPersonCard1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlPersonCard1.Location = new System.Drawing.Point(15, 127);
            this.ctrlPersonCard1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(1174, 366);
            this.ctrlPersonCard1.TabIndex = 0;
            // 
            // frmShowPersonLicenseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DVLD_Mery.Properties.Resources.DVLDbackground1_resized;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnCloseLicensesHistory;
            this.ClientSize = new System.Drawing.Size(1204, 780);
            this.Controls.Add(this.btnExitLicensesHistory);
            this.Controls.Add(this.btnCloseLicensesHistory);
            this.Controls.Add(this.lblLicensesRecords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ctrlPersonCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(199, 70);
            this.Name = "frmShowPersonLicenseHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmShowPersonLicenseHistory";
            this.Load += new System.EventHandler(this.frmShowPersonLicenseHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicenses)).EndInit();
            this.cmsLDLicenseHistory.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicenses)).EndInit();
            this.cmsIntLicenseHistory.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlPersonCard ctrlPersonCard1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblLicensesRecords;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCloseLicensesHistory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvLocalLicenses;
        private System.Windows.Forms.DataGridView dgvInternationalLicenses;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExitLicensesHistory;
        private System.Windows.Forms.ContextMenuStrip cmsLDLicenseHistory;
        private System.Windows.Forms.ToolStripSeparator ShowLicenseDetails;
        private System.Windows.Forms.ToolStripMenuItem ShowLicenseDetailstoolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsIntLicenseHistory;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ShowinternationalLicenseDetailsMenuItem1;
    }
}