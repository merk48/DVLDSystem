namespace DVLD_Mery
{
    partial class frmManageApplicationTypes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageApplicationTypes));
            this.btnExitManageApplicationTypes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvApplicationTypes = new System.Windows.Forms.DataGridView();
            this.cmsApplicationTypes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EditApplicationTypetoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblApplicationsTypes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCloseManageApplicationTypes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicationTypes)).BeginInit();
            this.cmsApplicationTypes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExitManageApplicationTypes
            // 
            this.btnExitManageApplicationTypes.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnExitManageApplicationTypes.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnExitManageApplicationTypes.ForeColor = System.Drawing.Color.White;
            this.btnExitManageApplicationTypes.Location = new System.Drawing.Point(1149, 4);
            this.btnExitManageApplicationTypes.Name = "btnExitManageApplicationTypes";
            this.btnExitManageApplicationTypes.Size = new System.Drawing.Size(50, 43);
            this.btnExitManageApplicationTypes.TabIndex = 40;
            this.btnExitManageApplicationTypes.Text = "X";
            this.btnExitManageApplicationTypes.UseVisualStyleBackColor = false;
            this.btnExitManageApplicationTypes.Click += new System.EventHandler(this.btnExitManageApplicationTypes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Montserrat", 22F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(385, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 39);
            this.label1.TabIndex = 41;
            this.label1.Text = "Manage Applicationt Types";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::DVLD_Mery.Properties.Resources.Application_Types_64;
            this.pictureBox1.Location = new System.Drawing.Point(542, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // dgvApplicationTypes
            // 
            this.dgvApplicationTypes.AllowUserToAddRows = false;
            this.dgvApplicationTypes.AllowUserToDeleteRows = false;
            this.dgvApplicationTypes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvApplicationTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvApplicationTypes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgvApplicationTypes.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvApplicationTypes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvApplicationTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApplicationTypes.ContextMenuStrip = this.cmsApplicationTypes;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvApplicationTypes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvApplicationTypes.Location = new System.Drawing.Point(129, 149);
            this.dgvApplicationTypes.Name = "dgvApplicationTypes";
            this.dgvApplicationTypes.ReadOnly = true;
            this.dgvApplicationTypes.Size = new System.Drawing.Size(945, 400);
            this.dgvApplicationTypes.TabIndex = 43;
            // 
            // cmsApplicationTypes
            // 
            this.cmsApplicationTypes.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsApplicationTypes.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.cmsApplicationTypes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditApplicationTypetoolStripMenuItem});
            this.cmsApplicationTypes.Name = "cmsPerson";
            this.cmsApplicationTypes.Size = new System.Drawing.Size(216, 40);
            // 
            // EditApplicationTypetoolStripMenuItem
            // 
            this.EditApplicationTypetoolStripMenuItem.Image = global::DVLD_Mery.Properties.Resources.edit_32;
            this.EditApplicationTypetoolStripMenuItem.Name = "EditApplicationTypetoolStripMenuItem";
            this.EditApplicationTypetoolStripMenuItem.Size = new System.Drawing.Size(215, 36);
            this.EditApplicationTypetoolStripMenuItem.Text = "Edit Application Type";
            this.EditApplicationTypetoolStripMenuItem.Click += new System.EventHandler(this.EditApplicationTypetoolStripMenuItem_Click);
            // 
            // lblApplicationsTypes
            // 
            this.lblApplicationsTypes.AutoSize = true;
            this.lblApplicationsTypes.BackColor = System.Drawing.Color.Transparent;
            this.lblApplicationsTypes.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.lblApplicationsTypes.ForeColor = System.Drawing.Color.White;
            this.lblApplicationsTypes.Location = new System.Drawing.Point(223, 571);
            this.lblApplicationsTypes.Name = "lblApplicationsTypes";
            this.lblApplicationsTypes.Size = new System.Drawing.Size(23, 18);
            this.lblApplicationsTypes.TabIndex = 46;
            this.lblApplicationsTypes.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(118, 571);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 45;
            this.label2.Text = "# Records: ";
            // 
            // btnCloseManageApplicationTypes
            // 
            this.btnCloseManageApplicationTypes.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCloseManageApplicationTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseManageApplicationTypes.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseManageApplicationTypes.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCloseManageApplicationTypes.Image = global::DVLD_Mery.Properties.Resources.Close_32;
            this.btnCloseManageApplicationTypes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseManageApplicationTypes.Location = new System.Drawing.Point(972, 562);
            this.btnCloseManageApplicationTypes.Name = "btnCloseManageApplicationTypes";
            this.btnCloseManageApplicationTypes.Size = new System.Drawing.Size(101, 31);
            this.btnCloseManageApplicationTypes.TabIndex = 44;
            this.btnCloseManageApplicationTypes.Text = "Close";
            this.btnCloseManageApplicationTypes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCloseManageApplicationTypes.UseVisualStyleBackColor = true;
            this.btnCloseManageApplicationTypes.Click += new System.EventHandler(this.btnExitManageApplicationTypes_Click);
            // 
            // frmManageApplicationTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DVLD_Mery.Properties.Resources.DVLDbackground1_resized;
            this.CancelButton = this.btnCloseManageApplicationTypes;
            this.ClientSize = new System.Drawing.Size(1204, 616);
            this.Controls.Add(this.lblApplicationsTypes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCloseManageApplicationTypes);
            this.Controls.Add(this.dgvApplicationTypes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExitManageApplicationTypes);
            this.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmManageApplicationTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManageApplicationTypes";
            this.Load += new System.EventHandler(this.frmManageApplicationTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicationTypes)).EndInit();
            this.cmsApplicationTypes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExitManageApplicationTypes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvApplicationTypes;
        private System.Windows.Forms.Label lblApplicationsTypes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCloseManageApplicationTypes;
        private System.Windows.Forms.ContextMenuStrip cmsApplicationTypes;
        private System.Windows.Forms.ToolStripMenuItem EditApplicationTypetoolStripMenuItem;
    }
}