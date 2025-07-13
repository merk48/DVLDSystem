namespace DVLD_Mery
{
    partial class frmTestAppointmentSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTestAppointmentSchedule));
            this.btnExitTestAppointmentForm = new System.Windows.Forms.Button();
            this.lblTestAppointmentTitle = new System.Windows.Forms.Label();
            this.pbTestAppointmentImage = new System.Windows.Forms.PictureBox();
            this.lblTestAppointmentsRecords = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCloseTestAppointmentForm = new System.Windows.Forms.Button();
            this.btnAddNewTestAppointment = new System.Windows.Forms.Button();
            this.dgvTestAppintments = new System.Windows.Forms.DataGridView();
            this.cmsTestAppointment = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EditTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TakeTestPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.ctrlLDLAppCard1 = new DVLD_Mery.ctrlLDLAppCard();
            ((System.ComponentModel.ISupportInitialize)(this.pbTestAppointmentImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestAppintments)).BeginInit();
            this.cmsTestAppointment.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExitTestAppointmentForm
            // 
            this.btnExitTestAppointmentForm.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnExitTestAppointmentForm.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnExitTestAppointmentForm.ForeColor = System.Drawing.Color.White;
            this.btnExitTestAppointmentForm.Location = new System.Drawing.Point(1148, 6);
            this.btnExitTestAppointmentForm.Name = "btnExitTestAppointmentForm";
            this.btnExitTestAppointmentForm.Size = new System.Drawing.Size(50, 43);
            this.btnExitTestAppointmentForm.TabIndex = 109;
            this.btnExitTestAppointmentForm.Text = "X";
            this.btnExitTestAppointmentForm.UseVisualStyleBackColor = false;
            this.btnExitTestAppointmentForm.Click += new System.EventHandler(this.btnCloseTestAppointment_Click);
            // 
            // lblTestAppointmentTitle
            // 
            this.lblTestAppointmentTitle.AutoSize = true;
            this.lblTestAppointmentTitle.BackColor = System.Drawing.Color.White;
            this.lblTestAppointmentTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTestAppointmentTitle.Font = new System.Drawing.Font("Montserrat", 22F, System.Drawing.FontStyle.Bold);
            this.lblTestAppointmentTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblTestAppointmentTitle.Location = new System.Drawing.Point(412, 94);
            this.lblTestAppointmentTitle.Name = "lblTestAppointmentTitle";
            this.lblTestAppointmentTitle.Size = new System.Drawing.Size(417, 39);
            this.lblTestAppointmentTitle.TabIndex = 110;
            this.lblTestAppointmentTitle.Text = "Vision Test Appointment";
            // 
            // pbTestAppointmentImage
            // 
            this.pbTestAppointmentImage.BackColor = System.Drawing.Color.Transparent;
            this.pbTestAppointmentImage.Image = global::DVLD_Mery.Properties.Resources.Written_Test_512;
            this.pbTestAppointmentImage.Location = new System.Drawing.Point(545, 2);
            this.pbTestAppointmentImage.Name = "pbTestAppointmentImage";
            this.pbTestAppointmentImage.Size = new System.Drawing.Size(137, 92);
            this.pbTestAppointmentImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTestAppointmentImage.TabIndex = 111;
            this.pbTestAppointmentImage.TabStop = false;
            // 
            // lblTestAppointmentsRecords
            // 
            this.lblTestAppointmentsRecords.AutoSize = true;
            this.lblTestAppointmentsRecords.BackColor = System.Drawing.Color.Transparent;
            this.lblTestAppointmentsRecords.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.lblTestAppointmentsRecords.ForeColor = System.Drawing.Color.White;
            this.lblTestAppointmentsRecords.Location = new System.Drawing.Point(133, 757);
            this.lblTestAppointmentsRecords.Name = "lblTestAppointmentsRecords";
            this.lblTestAppointmentsRecords.Size = new System.Drawing.Size(23, 18);
            this.lblTestAppointmentsRecords.TabIndex = 116;
            this.lblTestAppointmentsRecords.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 757);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 115;
            this.label2.Text = "# Records: ";
            // 
            // btnCloseTestAppointmentForm
            // 
            this.btnCloseTestAppointmentForm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCloseTestAppointmentForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseTestAppointmentForm.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseTestAppointmentForm.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCloseTestAppointmentForm.Location = new System.Drawing.Point(1087, 722);
            this.btnCloseTestAppointmentForm.Name = "btnCloseTestAppointmentForm";
            this.btnCloseTestAppointmentForm.Size = new System.Drawing.Size(102, 31);
            this.btnCloseTestAppointmentForm.TabIndex = 114;
            this.btnCloseTestAppointmentForm.Text = "Close";
            this.btnCloseTestAppointmentForm.UseVisualStyleBackColor = true;
            this.btnCloseTestAppointmentForm.Click += new System.EventHandler(this.btnCloseTestAppointment_Click);
            // 
            // btnAddNewTestAppointment
            // 
            this.btnAddNewTestAppointment.BackColor = System.Drawing.Color.White;
            this.btnAddNewTestAppointment.BackgroundImage = global::DVLD_Mery.Properties.Resources.AddAppointment_32;
            this.btnAddNewTestAppointment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddNewTestAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewTestAppointment.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnAddNewTestAppointment.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnAddNewTestAppointment.Location = new System.Drawing.Point(1088, 571);
            this.btnAddNewTestAppointment.Name = "btnAddNewTestAppointment";
            this.btnAddNewTestAppointment.Size = new System.Drawing.Size(101, 45);
            this.btnAddNewTestAppointment.TabIndex = 117;
            this.btnAddNewTestAppointment.UseVisualStyleBackColor = false;
            this.btnAddNewTestAppointment.Click += new System.EventHandler(this.btnAddNewLDLApp_Click);
            // 
            // dgvTestAppintments
            // 
            this.dgvTestAppintments.AllowUserToAddRows = false;
            this.dgvTestAppintments.AllowUserToDeleteRows = false;
            this.dgvTestAppintments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTestAppintments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTestAppintments.BackgroundColor = System.Drawing.Color.White;
            this.dgvTestAppintments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTestAppintments.ContextMenuStrip = this.cmsTestAppointment;
            this.dgvTestAppintments.Location = new System.Drawing.Point(20, 571);
            this.dgvTestAppintments.Name = "dgvTestAppintments";
            this.dgvTestAppintments.ReadOnly = true;
            this.dgvTestAppintments.Size = new System.Drawing.Size(1062, 182);
            this.dgvTestAppintments.TabIndex = 118;
            this.dgvTestAppintments.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.dgvTestAppintments_CellContextMenuStripNeeded);
            // 
            // cmsTestAppointment
            // 
            this.cmsTestAppointment.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsTestAppointment.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.cmsTestAppointment.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditTestToolStripMenuItem,
            this.TakeTestPersonToolStripMenuItem});
            this.cmsTestAppointment.Name = "cmsPerson";
            this.cmsTestAppointment.Size = new System.Drawing.Size(195, 98);
            // 
            // EditTestToolStripMenuItem
            // 
            this.EditTestToolStripMenuItem.Image = global::DVLD_Mery.Properties.Resources.edit_32;
            this.EditTestToolStripMenuItem.Name = "EditTestToolStripMenuItem";
            this.EditTestToolStripMenuItem.Size = new System.Drawing.Size(194, 36);
            this.EditTestToolStripMenuItem.Text = "Edit";
            this.EditTestToolStripMenuItem.Click += new System.EventHandler(this.EditTestToolStripMenuItem_Click);
            // 
            // TakeTestPersonToolStripMenuItem
            // 
            this.TakeTestPersonToolStripMenuItem.Image = global::DVLD_Mery.Properties.Resources.Test_32;
            this.TakeTestPersonToolStripMenuItem.Name = "TakeTestPersonToolStripMenuItem";
            this.TakeTestPersonToolStripMenuItem.Size = new System.Drawing.Size(194, 36);
            this.TakeTestPersonToolStripMenuItem.Text = "Take Test";
            this.TakeTestPersonToolStripMenuItem.Click += new System.EventHandler(this.TakeTestToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(21, 553);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 18);
            this.label3.TabIndex = 119;
            this.label3.Text = "Appointments";
            // 
            // ctrlLDLAppCard1
            // 
            this.ctrlLDLAppCard1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlLDLAppCard1.Location = new System.Drawing.Point(18, 132);
            this.ctrlLDLAppCard1.Name = "ctrlLDLAppCard1";
            this.ctrlLDLAppCard1.Size = new System.Drawing.Size(1172, 426);
            this.ctrlLDLAppCard1.TabIndex = 120;
            // 
            // frmTestAppointmentSchedule
            // 
            this.AcceptButton = this.btnAddNewTestAppointment;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DVLD_Mery.Properties.Resources.DVLDbackground1_resized;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnCloseTestAppointmentForm;
            this.ClientSize = new System.Drawing.Size(1204, 780);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvTestAppintments);
            this.Controls.Add(this.btnAddNewTestAppointment);
            this.Controls.Add(this.lblTestAppointmentsRecords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCloseTestAppointmentForm);
            this.Controls.Add(this.lblTestAppointmentTitle);
            this.Controls.Add(this.btnExitTestAppointmentForm);
            this.Controls.Add(this.pbTestAppointmentImage);
            this.Controls.Add(this.ctrlLDLAppCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(199, 64);
            this.Name = "frmTestAppointmentSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmVisionTestAppointmentSchedule";
            this.Load += new System.EventHandler(this.frmVisionTestAppointmentSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTestAppointmentImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestAppintments)).EndInit();
            this.cmsTestAppointment.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExitTestAppointmentForm;
        private System.Windows.Forms.Label lblTestAppointmentTitle;
        private System.Windows.Forms.PictureBox pbTestAppointmentImage;
        private System.Windows.Forms.Label lblTestAppointmentsRecords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCloseTestAppointmentForm;
        private System.Windows.Forms.Button btnAddNewTestAppointment;
        private System.Windows.Forms.DataGridView dgvTestAppintments;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip cmsTestAppointment;
        private System.Windows.Forms.ToolStripMenuItem EditTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TakeTestPersonToolStripMenuItem;
        private ctrlLDLAppCard ctrlLDLAppCard1;
    }
}