namespace DVLD_Mery
{
    partial class frmManageTestTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageTestTypes));
            this.btnExitManageTestTpes = new System.Windows.Forms.Button();
            this.lblTestTypesRecords = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCloseManageTestTypes = new System.Windows.Forms.Button();
            this.dgvTestTypes = new System.Windows.Forms.DataGridView();
            this.cmsTestTypes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EditApplicationTypetoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestTypes)).BeginInit();
            this.cmsTestTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExitManageTestTpes
            // 
            this.btnExitManageTestTpes.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnExitManageTestTpes.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnExitManageTestTpes.ForeColor = System.Drawing.Color.White;
            this.btnExitManageTestTpes.Location = new System.Drawing.Point(1149, 4);
            this.btnExitManageTestTpes.Name = "btnExitManageTestTpes";
            this.btnExitManageTestTpes.Size = new System.Drawing.Size(50, 43);
            this.btnExitManageTestTpes.TabIndex = 41;
            this.btnExitManageTestTpes.Text = "X";
            this.btnExitManageTestTpes.UseVisualStyleBackColor = false;
            this.btnExitManageTestTpes.Click += new System.EventHandler(this.btnExitManageTestTpes_Click);
            // 
            // lblTestTypesRecords
            // 
            this.lblTestTypesRecords.AutoSize = true;
            this.lblTestTypesRecords.BackColor = System.Drawing.Color.Transparent;
            this.lblTestTypesRecords.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.lblTestTypesRecords.ForeColor = System.Drawing.Color.White;
            this.lblTestTypesRecords.Location = new System.Drawing.Point(154, 573);
            this.lblTestTypesRecords.Name = "lblTestTypesRecords";
            this.lblTestTypesRecords.Size = new System.Drawing.Size(23, 18);
            this.lblTestTypesRecords.TabIndex = 53;
            this.lblTestTypesRecords.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(49, 573);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 52;
            this.label2.Text = "# Records: ";
            // 
            // btnCloseManageTestTypes
            // 
            this.btnCloseManageTestTypes.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCloseManageTestTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseManageTestTypes.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseManageTestTypes.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCloseManageTestTypes.Image = global::DVLD_Mery.Properties.Resources.Close_32;
            this.btnCloseManageTestTypes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseManageTestTypes.Location = new System.Drawing.Point(1052, 565);
            this.btnCloseManageTestTypes.Name = "btnCloseManageTestTypes";
            this.btnCloseManageTestTypes.Size = new System.Drawing.Size(105, 31);
            this.btnCloseManageTestTypes.TabIndex = 51;
            this.btnCloseManageTestTypes.Text = "Close";
            this.btnCloseManageTestTypes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCloseManageTestTypes.UseVisualStyleBackColor = true;
            this.btnCloseManageTestTypes.Click += new System.EventHandler(this.btnExitManageTestTpes_Click);
            // 
            // dgvTestTypes
            // 
            this.dgvTestTypes.AllowUserToAddRows = false;
            this.dgvTestTypes.AllowUserToDeleteRows = false;
            this.dgvTestTypes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTestTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTestTypes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgvTestTypes.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTestTypes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTestTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTestTypes.ContextMenuStrip = this.cmsTestTypes;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTestTypes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTestTypes.Location = new System.Drawing.Point(52, 149);
            this.dgvTestTypes.Name = "dgvTestTypes";
            this.dgvTestTypes.ReadOnly = true;
            this.dgvTestTypes.Size = new System.Drawing.Size(1105, 400);
            this.dgvTestTypes.TabIndex = 50;
            // 
            // cmsTestTypes
            // 
            this.cmsTestTypes.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsTestTypes.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.cmsTestTypes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditApplicationTypetoolStripMenuItem});
            this.cmsTestTypes.Name = "cmsPerson";
            this.cmsTestTypes.Size = new System.Drawing.Size(168, 40);
            // 
            // EditApplicationTypetoolStripMenuItem
            // 
            this.EditApplicationTypetoolStripMenuItem.Image = global::DVLD_Mery.Properties.Resources.edit_32;
            this.EditApplicationTypetoolStripMenuItem.Name = "EditApplicationTypetoolStripMenuItem";
            this.EditApplicationTypetoolStripMenuItem.Size = new System.Drawing.Size(167, 36);
            this.EditApplicationTypetoolStripMenuItem.Text = "Edit TestType";
            this.EditApplicationTypetoolStripMenuItem.Click += new System.EventHandler(this.EditApplicationTypetoolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Montserrat", 22F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(456, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 39);
            this.label1.TabIndex = 48;
            this.label1.Text = "Manage Test Types";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::DVLD_Mery.Properties.Resources.TestType_512;
            this.pictureBox1.Location = new System.Drawing.Point(557, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // frmManageTestTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DVLD_Mery.Properties.Resources.DVLDbackground1_resized;
            this.CancelButton = this.btnCloseManageTestTypes;
            this.ClientSize = new System.Drawing.Size(1204, 616);
            this.Controls.Add(this.lblTestTypesRecords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCloseManageTestTypes);
            this.Controls.Add(this.dgvTestTypes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExitManageTestTpes);
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmManageTestTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManageTestTypes";
            this.Load += new System.EventHandler(this.frmManageTestTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestTypes)).EndInit();
            this.cmsTestTypes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExitManageTestTpes;
        private System.Windows.Forms.Label lblTestTypesRecords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCloseManageTestTypes;
        private System.Windows.Forms.DataGridView dgvTestTypes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip cmsTestTypes;
        private System.Windows.Forms.ToolStripMenuItem EditApplicationTypetoolStripMenuItem;
    }
}