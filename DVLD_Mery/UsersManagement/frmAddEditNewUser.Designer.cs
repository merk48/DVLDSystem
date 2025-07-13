namespace DVLD_Mery
{
    partial class frmAddEditNewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditNewUser));
            this.lblUserCardTitle = new System.Windows.Forms.Label();
            this.tcUserInfo = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.ctrlPersonCardWithFilter1 = new DVLD_Mery.ctrlPersonCardWithFilter();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.chcUserIsActive = new System.Windows.Forms.CheckBox();
            this.txtUserConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSaveAddNewUser = new System.Windows.Forms.Button();
            this.btnCancelAddNewUser = new System.Windows.Forms.Button();
            this.errpAddNewUserCard = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnExitAddNewUser = new System.Windows.Forms.Button();
            this.tcUserInfo.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errpAddNewUserCard)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserCardTitle
            // 
            this.lblUserCardTitle.AutoSize = true;
            this.lblUserCardTitle.BackColor = System.Drawing.Color.White;
            this.lblUserCardTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUserCardTitle.Font = new System.Drawing.Font("Montserrat", 22F, System.Drawing.FontStyle.Bold);
            this.lblUserCardTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblUserCardTitle.Location = new System.Drawing.Point(476, 30);
            this.lblUserCardTitle.Name = "lblUserCardTitle";
            this.lblUserCardTitle.Size = new System.Drawing.Size(249, 39);
            this.lblUserCardTitle.TabIndex = 28;
            this.lblUserCardTitle.Text = "Add New User";
            // 
            // tcUserInfo
            // 
            this.tcUserInfo.Controls.Add(this.tabPage1);
            this.tcUserInfo.Controls.Add(this.tabPage2);
            this.tcUserInfo.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcUserInfo.Location = new System.Drawing.Point(10, 76);
            this.tcUserInfo.Name = "tcUserInfo";
            this.tcUserInfo.SelectedIndex = 0;
            this.tcUserInfo.Size = new System.Drawing.Size(1185, 484);
            this.tcUserInfo.TabIndex = 29;
            this.tcUserInfo.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tcUserInfo_Selecting);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnNext);
            this.tabPage1.Controls.Add(this.ctrlPersonCardWithFilter1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1177, 455);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PersonInfo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.AutoSize = true;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnNext.Image = global::DVLD_Mery.Properties.Resources.Next_32;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.Location = new System.Drawing.Point(1040, 411);
            this.btnNext.Name = "btnNext";
            this.btnNext.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnNext.Size = new System.Drawing.Size(102, 40);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Next";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ctrlPersonCardWithFilter1
            // 
            this.ctrlPersonCardWithFilter1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlPersonCardWithFilter1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ctrlPersonCardWithFilter1.Location = new System.Drawing.Point(7, 1);
            this.ctrlPersonCardWithFilter1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            this.ctrlPersonCardWithFilter1.Size = new System.Drawing.Size(1163, 457);
            this.ctrlPersonCardWithFilter1.TabIndex = 0;
            this.ctrlPersonCardWithFilter1.OnPersonSelected += new System.EventHandler<DVLD_Mery.ctrlPersonCardWithFilter.PersonSelectedEventsArgs>(this.ctrlPersonCardWithFilter1_OnPersonSelected);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnPrevious);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1177, 455);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "LoginInfo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnPrevious.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrevious.Location = new System.Drawing.Point(1013, 413);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPrevious.Size = new System.Drawing.Size(130, 36);
            this.btnPrevious.TabIndex = 12;
            this.btnPrevious.Text = "⬅️ Previous ";
            this.btnPrevious.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox7);
            this.groupBox1.Controls.Add(this.lblUserID);
            this.groupBox1.Controls.Add(this.chcUserIsActive);
            this.groupBox1.Controls.Add(this.txtUserConfirmPassword);
            this.groupBox1.Controls.Add(this.txtUserPassword);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(295, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(609, 317);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "UserInfo";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = global::DVLD_Mery.Properties.Resources.Password_32;
            this.pictureBox3.Location = new System.Drawing.Point(265, 210);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 129;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::DVLD_Mery.Properties.Resources.Password_32;
            this.pictureBox1.Location = new System.Drawing.Point(265, 153);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 128;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::DVLD_Mery.Properties.Resources.Nameicon;
            this.pictureBox2.Location = new System.Drawing.Point(265, 97);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 127;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox7.Image = global::DVLD_Mery.Properties.Resources.Number_32;
            this.pictureBox7.Location = new System.Drawing.Point(265, 43);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(30, 27);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 126;
            this.pictureBox7.TabStop = false;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.lblUserID.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblUserID.Location = new System.Drawing.Point(312, 47);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(32, 18);
            this.lblUserID.TabIndex = 62;
            this.lblUserID.Text = "???";
            // 
            // chcUserIsActive
            // 
            this.chcUserIsActive.AutoSize = true;
            this.chcUserIsActive.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chcUserIsActive.ForeColor = System.Drawing.Color.MidnightBlue;
            this.chcUserIsActive.Location = new System.Drawing.Point(315, 265);
            this.chcUserIsActive.Name = "chcUserIsActive";
            this.chcUserIsActive.Size = new System.Drawing.Size(82, 20);
            this.chcUserIsActive.TabIndex = 11;
            this.chcUserIsActive.Text = "Is Active";
            this.chcUserIsActive.UseVisualStyleBackColor = true;
            // 
            // txtUserConfirmPassword
            // 
            this.txtUserConfirmPassword.Location = new System.Drawing.Point(314, 212);
            this.txtUserConfirmPassword.Name = "txtUserConfirmPassword";
            this.txtUserConfirmPassword.PasswordChar = '*';
            this.txtUserConfirmPassword.Size = new System.Drawing.Size(184, 23);
            this.txtUserConfirmPassword.TabIndex = 10;
            this.txtUserConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserConfirmPassword_Validating);
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Location = new System.Drawing.Point(315, 155);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.PasswordChar = '*';
            this.txtUserPassword.Size = new System.Drawing.Size(184, 23);
            this.txtUserPassword.TabIndex = 9;
            this.txtUserPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserPassword_Validating);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(315, 99);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(184, 23);
            this.txtUsername.TabIndex = 8;
            this.txtUsername.Validating += new System.ComponentModel.CancelEventHandler(this.txtUsername_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(87, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 18);
            this.label5.TabIndex = 53;
            this.label5.Text = "Confirm Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(87, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 18);
            this.label4.TabIndex = 52;
            this.label4.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(87, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 18);
            this.label2.TabIndex = 51;
            this.label2.Text = "UserName: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(87, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 18);
            this.label3.TabIndex = 50;
            this.label3.Text = "UserID:";
            // 
            // btnSaveAddNewUser
            // 
            this.btnSaveAddNewUser.AutoSize = true;
            this.btnSaveAddNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAddNewUser.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAddNewUser.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSaveAddNewUser.Image = global::DVLD_Mery.Properties.Resources.Save_32;
            this.btnSaveAddNewUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveAddNewUser.Location = new System.Drawing.Point(1044, 566);
            this.btnSaveAddNewUser.Name = "btnSaveAddNewUser";
            this.btnSaveAddNewUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSaveAddNewUser.Size = new System.Drawing.Size(113, 40);
            this.btnSaveAddNewUser.TabIndex = 5;
            this.btnSaveAddNewUser.Text = "Save ";
            this.btnSaveAddNewUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveAddNewUser.UseVisualStyleBackColor = true;
            this.btnSaveAddNewUser.Click += new System.EventHandler(this.btnSaveAddNewUser_Click);
            // 
            // btnCancelAddNewUser
            // 
            this.btnCancelAddNewUser.AutoSize = true;
            this.btnCancelAddNewUser.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelAddNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelAddNewUser.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAddNewUser.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCancelAddNewUser.Image = global::DVLD_Mery.Properties.Resources.Close_32;
            this.btnCancelAddNewUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelAddNewUser.Location = new System.Drawing.Point(920, 566);
            this.btnCancelAddNewUser.Name = "btnCancelAddNewUser";
            this.btnCancelAddNewUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCancelAddNewUser.Size = new System.Drawing.Size(113, 40);
            this.btnCancelAddNewUser.TabIndex = 6;
            this.btnCancelAddNewUser.Text = "Cancel";
            this.btnCancelAddNewUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelAddNewUser.UseVisualStyleBackColor = true;
            this.btnCancelAddNewUser.Click += new System.EventHandler(this.btnCancelAddNewUser_Click);
            // 
            // errpAddNewUserCard
            // 
            this.errpAddNewUserCard.ContainerControl = this;
            // 
            // btnExitAddNewUser
            // 
            this.btnExitAddNewUser.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnExitAddNewUser.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnExitAddNewUser.ForeColor = System.Drawing.Color.White;
            this.btnExitAddNewUser.Location = new System.Drawing.Point(1142, 30);
            this.btnExitAddNewUser.Name = "btnExitAddNewUser";
            this.btnExitAddNewUser.Size = new System.Drawing.Size(50, 43);
            this.btnExitAddNewUser.TabIndex = 7;
            this.btnExitAddNewUser.Text = "X";
            this.btnExitAddNewUser.UseVisualStyleBackColor = false;
            this.btnExitAddNewUser.Click += new System.EventHandler(this.btnCancelAddNewUser_Click);
            // 
            // frmAddEditNewUser
            // 
            this.AcceptButton = this.btnSaveAddNewUser;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DVLD_Mery.Properties.Resources.DVLDbackground1_resized;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnCancelAddNewUser;
            this.ClientSize = new System.Drawing.Size(1204, 616);
            this.Controls.Add(this.btnExitAddNewUser);
            this.Controls.Add(this.tcUserInfo);
            this.Controls.Add(this.btnCancelAddNewUser);
            this.Controls.Add(this.btnSaveAddNewUser);
            this.Controls.Add(this.lblUserCardTitle);
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddEditNewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewUser";
            this.Load += new System.EventHandler(this.frmAddNewUser_Load);
            this.tcUserInfo.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errpAddNewUserCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserCardTitle;
        private System.Windows.Forms.TabControl tcUserInfo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        public  ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.CheckBox chcUserIsActive;
        private System.Windows.Forms.TextBox txtUserConfirmPassword;
        private System.Windows.Forms.TextBox txtUserPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSaveAddNewUser;
        private System.Windows.Forms.Button btnCancelAddNewUser;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.ErrorProvider errpAddNewUserCard;
        private System.Windows.Forms.Button btnExitAddNewUser;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}