namespace DVLD_Mery
{
    partial class frmManageUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageUsers));
            this.txtUsersFilter = new System.Windows.Forms.TextBox();
            this.cmbFilterUsersByProperity = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.cmsUser = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowDetailstoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EdittoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeletetoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangePasswordtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SendEmailtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PhoneCalltoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCloseManageUsers = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUsersRecords = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.btnExitManageUsers = new System.Windows.Forms.Button();
            this.panelrbIsActiveFilter = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.rdbFilterDeActive = new System.Windows.Forms.RadioButton();
            this.rdbFilterActive = new System.Windows.Forms.RadioButton();
            this.lnklblClearFilter = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.cmsUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelrbIsActiveFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsersFilter
            // 
            this.txtUsersFilter.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtUsersFilter.Location = new System.Drawing.Point(317, 178);
            this.txtUsersFilter.Name = "txtUsersFilter";
            this.txtUsersFilter.Size = new System.Drawing.Size(184, 21);
            this.txtUsersFilter.TabIndex = 0;
            this.txtUsersFilter.TextChanged += new System.EventHandler(this.txtUsersFilter_TextChanged);
            this.txtUsersFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsersFilter_KeyPress);
            // 
            // cmbFilterUsersByProperity
            // 
            this.cmbFilterUsersByProperity.AutoCompleteCustomSource.AddRange(new string[] {
            "None",
            "UserID",
            "PersonID",
            "Username",
            "Full Name",
            "Is Active"});
            this.cmbFilterUsersByProperity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterUsersByProperity.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cmbFilterUsersByProperity.FormattingEnabled = true;
            this.cmbFilterUsersByProperity.Items.AddRange(new object[] {
            "None",
            "UserID",
            "PersonID",
            "Username",
            "FullName",
            "IsActive"});
            this.cmbFilterUsersByProperity.Location = new System.Drawing.Point(124, 175);
            this.cmbFilterUsersByProperity.Name = "cmbFilterUsersByProperity";
            this.cmbFilterUsersByProperity.Size = new System.Drawing.Size(169, 22);
            this.cmbFilterUsersByProperity.TabIndex = 30;
            this.cmbFilterUsersByProperity.SelectedIndexChanged += new System.EventHandler(this.cmbFilterUsersByProperity_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Montserrat", 22F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(504, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 39);
            this.label1.TabIndex = 27;
            this.label1.Text = "Manage Users";
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.ContextMenuStrip = this.cmsUser;
            this.dgvUsers.Location = new System.Drawing.Point(29, 205);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.Size = new System.Drawing.Size(1145, 358);
            this.dgvUsers.TabIndex = 26;
            this.dgvUsers.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellContentDoubleClick);
            // 
            // cmsUser
            // 
            this.cmsUser.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsUser.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.cmsUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowDetailstoolStripMenuItem,
            this.AddNewUserToolStripMenuItem,
            this.EdittoolStripMenuItem,
            this.DeletetoolStripMenuItem,
            this.ChangePasswordtoolStripMenuItem,
            this.SendEmailtoolStripMenuItem,
            this.PhoneCalltoolStripMenuItem});
            this.cmsUser.Name = "cmsPerson";
            this.cmsUser.Size = new System.Drawing.Size(198, 256);
            // 
            // ShowDetailstoolStripMenuItem
            // 
            this.ShowDetailstoolStripMenuItem.Image = global::DVLD_Mery.Properties.Resources.PersonDetails_32;
            this.ShowDetailstoolStripMenuItem.Name = "ShowDetailstoolStripMenuItem";
            this.ShowDetailstoolStripMenuItem.Size = new System.Drawing.Size(197, 36);
            this.ShowDetailstoolStripMenuItem.Text = "Show Details";
            this.ShowDetailstoolStripMenuItem.Click += new System.EventHandler(this.ShowDetailstoolStripMenuItem_Click);
            // 
            // AddNewUserToolStripMenuItem
            // 
            this.AddNewUserToolStripMenuItem.Image = global::DVLD_Mery.Properties.Resources.AddNewPersonimg_removebg_preview__1_1;
            this.AddNewUserToolStripMenuItem.Name = "AddNewUserToolStripMenuItem";
            this.AddNewUserToolStripMenuItem.Size = new System.Drawing.Size(197, 36);
            this.AddNewUserToolStripMenuItem.Text = "Add New User";
            this.AddNewUserToolStripMenuItem.Click += new System.EventHandler(this.AddNewUserToolStripMenuItem_Click);
            // 
            // EdittoolStripMenuItem
            // 
            this.EdittoolStripMenuItem.Image = global::DVLD_Mery.Properties.Resources.EditPerson;
            this.EdittoolStripMenuItem.Name = "EdittoolStripMenuItem";
            this.EdittoolStripMenuItem.Size = new System.Drawing.Size(197, 36);
            this.EdittoolStripMenuItem.Text = "Edit";
            this.EdittoolStripMenuItem.Click += new System.EventHandler(this.EdittoolStripMenuItem_Click);
            // 
            // DeletetoolStripMenuItem
            // 
            this.DeletetoolStripMenuItem.Image = global::DVLD_Mery.Properties.Resources.Delete2;
            this.DeletetoolStripMenuItem.Name = "DeletetoolStripMenuItem";
            this.DeletetoolStripMenuItem.Size = new System.Drawing.Size(197, 36);
            this.DeletetoolStripMenuItem.Text = "Delete";
            this.DeletetoolStripMenuItem.Click += new System.EventHandler(this.DeletetoolStripMenuItem_Click);
            // 
            // ChangePasswordtoolStripMenuItem
            // 
            this.ChangePasswordtoolStripMenuItem.Image = global::DVLD_Mery.Properties.Resources.Password_32;
            this.ChangePasswordtoolStripMenuItem.Name = "ChangePasswordtoolStripMenuItem";
            this.ChangePasswordtoolStripMenuItem.Size = new System.Drawing.Size(197, 36);
            this.ChangePasswordtoolStripMenuItem.Text = "Change Password";
            this.ChangePasswordtoolStripMenuItem.Click += new System.EventHandler(this.ChangePasswordtoolStripMenuItem_Click);
            // 
            // SendEmailtoolStripMenuItem
            // 
            this.SendEmailtoolStripMenuItem.Image = global::DVLD_Mery.Properties.Resources.SendEmail_removebg_preview;
            this.SendEmailtoolStripMenuItem.Name = "SendEmailtoolStripMenuItem";
            this.SendEmailtoolStripMenuItem.Size = new System.Drawing.Size(197, 36);
            this.SendEmailtoolStripMenuItem.Text = "Send Email";
            this.SendEmailtoolStripMenuItem.Click += new System.EventHandler(this.SendEmailtoolStripMenuItem_Click);
            // 
            // PhoneCalltoolStripMenuItem
            // 
            this.PhoneCalltoolStripMenuItem.Image = global::DVLD_Mery.Properties.Resources.CallPhone_removebg_preview;
            this.PhoneCalltoolStripMenuItem.Name = "PhoneCalltoolStripMenuItem";
            this.PhoneCalltoolStripMenuItem.Size = new System.Drawing.Size(197, 36);
            this.PhoneCalltoolStripMenuItem.Text = "Phone Call";
            this.PhoneCalltoolStripMenuItem.Click += new System.EventHandler(this.PhoneCalltoolStripMenuItem_Click);
            // 
            // btnCloseManageUsers
            // 
            this.btnCloseManageUsers.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCloseManageUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseManageUsers.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseManageUsers.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCloseManageUsers.Image = global::DVLD_Mery.Properties.Resources.Close_32;
            this.btnCloseManageUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseManageUsers.Location = new System.Drawing.Point(1069, 569);
            this.btnCloseManageUsers.Name = "btnCloseManageUsers";
            this.btnCloseManageUsers.Size = new System.Drawing.Size(105, 31);
            this.btnCloseManageUsers.TabIndex = 5;
            this.btnCloseManageUsers.Text = "Close";
            this.btnCloseManageUsers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCloseManageUsers.UseVisualStyleBackColor = true;
            this.btnCloseManageUsers.Click += new System.EventHandler(this.btnCloseManageUsers_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(30, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 29;
            this.label3.Text = "Filter By";
            // 
            // lblUsersRecords
            // 
            this.lblUsersRecords.AutoSize = true;
            this.lblUsersRecords.BackColor = System.Drawing.Color.Transparent;
            this.lblUsersRecords.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.lblUsersRecords.ForeColor = System.Drawing.Color.White;
            this.lblUsersRecords.Location = new System.Drawing.Point(135, 582);
            this.lblUsersRecords.Name = "lblUsersRecords";
            this.lblUsersRecords.Size = new System.Drawing.Size(23, 18);
            this.lblUsersRecords.TabIndex = 38;
            this.lblUsersRecords.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 582);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 37;
            this.label2.Text = "# Records: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::DVLD_Mery.Properties.Resources.Usersimg2_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(555, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.BackColor = System.Drawing.Color.White;
            this.btnAddNewUser.BackgroundImage = global::DVLD_Mery.Properties.Resources.AddNewPersonimg_removebg_preview__1_;
            this.btnAddNewUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewUser.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnAddNewUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddNewUser.Image = global::DVLD_Mery.Properties.Resources.AddNewPersonimg_removebg_preview;
            this.btnAddNewUser.Location = new System.Drawing.Point(1105, 149);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(68, 45);
            this.btnAddNewUser.TabIndex = 4;
            this.btnAddNewUser.UseVisualStyleBackColor = false;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // btnExitManageUsers
            // 
            this.btnExitManageUsers.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnExitManageUsers.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnExitManageUsers.ForeColor = System.Drawing.Color.White;
            this.btnExitManageUsers.Location = new System.Drawing.Point(1142, 12);
            this.btnExitManageUsers.Name = "btnExitManageUsers";
            this.btnExitManageUsers.Size = new System.Drawing.Size(50, 43);
            this.btnExitManageUsers.TabIndex = 6;
            this.btnExitManageUsers.Text = "X";
            this.btnExitManageUsers.UseVisualStyleBackColor = false;
            this.btnExitManageUsers.Click += new System.EventHandler(this.btnCloseManageUsers_Click);
            // 
            // panelrbIsActiveFilter
            // 
            this.panelrbIsActiveFilter.BackColor = System.Drawing.Color.Transparent;
            this.panelrbIsActiveFilter.Controls.Add(this.label13);
            this.panelrbIsActiveFilter.Controls.Add(this.rdbFilterDeActive);
            this.panelrbIsActiveFilter.Controls.Add(this.rdbFilterActive);
            this.panelrbIsActiveFilter.Location = new System.Drawing.Point(312, 171);
            this.panelrbIsActiveFilter.Name = "panelrbIsActiveFilter";
            this.panelrbIsActiveFilter.Size = new System.Drawing.Size(171, 35);
            this.panelrbIsActiveFilter.TabIndex = 41;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Image = global::DVLD_Mery.Properties.Resources.genderfemaleicon;
            this.label13.Location = new System.Drawing.Point(114, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 14);
            this.label13.TabIndex = 91;
            // 
            // rdbFilterDeActive
            // 
            this.rdbFilterDeActive.AutoSize = true;
            this.rdbFilterDeActive.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFilterDeActive.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rdbFilterDeActive.Location = new System.Drawing.Point(83, 8);
            this.rdbFilterDeActive.Name = "rdbFilterDeActive";
            this.rdbFilterDeActive.Size = new System.Drawing.Size(84, 20);
            this.rdbFilterDeActive.TabIndex = 2;
            this.rdbFilterDeActive.Text = "DeActive";
            this.rdbFilterDeActive.UseVisualStyleBackColor = true;
            this.rdbFilterDeActive.CheckedChanged += new System.EventHandler(this.rdbFilterIsActive_CheckedChanged);
            // 
            // rdbFilterActive
            // 
            this.rdbFilterActive.AutoSize = true;
            this.rdbFilterActive.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFilterActive.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rdbFilterActive.Location = new System.Drawing.Point(5, 7);
            this.rdbFilterActive.Name = "rdbFilterActive";
            this.rdbFilterActive.Size = new System.Drawing.Size(66, 20);
            this.rdbFilterActive.TabIndex = 1;
            this.rdbFilterActive.Text = "Active";
            this.rdbFilterActive.UseVisualStyleBackColor = true;
            this.rdbFilterActive.CheckedChanged += new System.EventHandler(this.rdbFilterIsActive_CheckedChanged);
            // 
            // lnklblClearFilter
            // 
            this.lnklblClearFilter.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.lnklblClearFilter.AutoSize = true;
            this.lnklblClearFilter.Font = new System.Drawing.Font("Montserrat", 8F);
            this.lnklblClearFilter.LinkColor = System.Drawing.Color.MidnightBlue;
            this.lnklblClearFilter.Location = new System.Drawing.Point(508, 184);
            this.lnklblClearFilter.Name = "lnklblClearFilter";
            this.lnklblClearFilter.Size = new System.Drawing.Size(67, 14);
            this.lnklblClearFilter.TabIndex = 3;
            this.lnklblClearFilter.TabStop = true;
            this.lnklblClearFilter.Text = "Clear Filter";
            this.lnklblClearFilter.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llClearFilter_LinkClicked);
            // 
            // frmManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DVLD_Mery.Properties.Resources.DVLDbackground1_resized;
            this.CancelButton = this.btnCloseManageUsers;
            this.ClientSize = new System.Drawing.Size(1204, 616);
            this.Controls.Add(this.lnklblClearFilter);
            this.Controls.Add(this.panelrbIsActiveFilter);
            this.Controls.Add(this.btnExitManageUsers);
            this.Controls.Add(this.lblUsersRecords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCloseManageUsers);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtUsersFilter);
            this.Controls.Add(this.cmbFilterUsersByProperity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddNewUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvUsers);
            this.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmManageUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManageUsers";
            this.Load += new System.EventHandler(this.frmManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.cmsUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelrbIsActiveFilter.ResumeLayout(false);
            this.panelrbIsActiveFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtUsersFilter;
        private System.Windows.Forms.ComboBox cmbFilterUsersByProperity;
        private System.Windows.Forms.Button btnAddNewUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Button btnCloseManageUsers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUsersRecords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip cmsUser;
        private System.Windows.Forms.ToolStripMenuItem ShowDetailstoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddNewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EdittoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeletetoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangePasswordtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SendEmailtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PhoneCalltoolStripMenuItem;
        private System.Windows.Forms.Button btnExitManageUsers;
        private System.Windows.Forms.Panel panelrbIsActiveFilter;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton rdbFilterDeActive;
        private System.Windows.Forms.RadioButton rdbFilterActive;
        private System.Windows.Forms.LinkLabel lnklblClearFilter;
    }
}