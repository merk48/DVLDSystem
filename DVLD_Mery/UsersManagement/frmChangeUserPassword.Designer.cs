namespace DVLD_Mery
{
    partial class frmChangeUserPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangeUserPassword));
            this.txtConfirmNewPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCloseUserChangePassword = new System.Windows.Forms.Button();
            this.btnSaveUserChangePassword = new System.Windows.Forms.Button();
            this.errorpChangePassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnExitUserChangePassword = new System.Windows.Forms.Button();
            this.ctrlUserCard1 = new DVLD_Mery.ctrlUserCard();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorpChangePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtConfirmNewPassword
            // 
            this.txtConfirmNewPassword.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtConfirmNewPassword.Location = new System.Drawing.Point(643, 584);
            this.txtConfirmNewPassword.Name = "txtConfirmNewPassword";
            this.txtConfirmNewPassword.PasswordChar = '*';
            this.txtConfirmNewPassword.Size = new System.Drawing.Size(184, 20);
            this.txtConfirmNewPassword.TabIndex = 2;
            this.txtConfirmNewPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfirmNewPassword_Validating);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtNewPassword.Location = new System.Drawing.Point(643, 537);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(184, 20);
            this.txtNewPassword.TabIndex = 1;
            this.txtNewPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtNewPassword_Validating);
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtCurrentPassword.Location = new System.Drawing.Point(643, 490);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.PasswordChar = '*';
            this.txtCurrentPassword.Size = new System.Drawing.Size(184, 20);
            this.txtCurrentPassword.TabIndex = 0;
            this.txtCurrentPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtCurrentPassword_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(408, 585);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 18);
            this.label5.TabIndex = 126;
            this.label5.Text = "Confirm Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(435, 538);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 18);
            this.label4.TabIndex = 125;
            this.label4.Text = "New Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(405, 491);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 18);
            this.label2.TabIndex = 124;
            this.label2.Text = "Current Password: ";
            // 
            // btnCloseUserChangePassword
            // 
            this.btnCloseUserChangePassword.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCloseUserChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseUserChangePassword.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseUserChangePassword.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCloseUserChangePassword.Image = global::DVLD_Mery.Properties.Resources.Close_32;
            this.btnCloseUserChangePassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseUserChangePassword.Location = new System.Drawing.Point(1077, 589);
            this.btnCloseUserChangePassword.Name = "btnCloseUserChangePassword";
            this.btnCloseUserChangePassword.Size = new System.Drawing.Size(105, 31);
            this.btnCloseUserChangePassword.TabIndex = 4;
            this.btnCloseUserChangePassword.Text = "Close";
            this.btnCloseUserChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCloseUserChangePassword.UseVisualStyleBackColor = true;
            this.btnCloseUserChangePassword.Click += new System.EventHandler(this.btnExitUserChangePassword_Click);
            // 
            // btnSaveUserChangePassword
            // 
            this.btnSaveUserChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveUserChangePassword.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveUserChangePassword.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSaveUserChangePassword.Image = global::DVLD_Mery.Properties.Resources.Save_32;
            this.btnSaveUserChangePassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveUserChangePassword.Location = new System.Drawing.Point(1077, 552);
            this.btnSaveUserChangePassword.Name = "btnSaveUserChangePassword";
            this.btnSaveUserChangePassword.Size = new System.Drawing.Size(105, 31);
            this.btnSaveUserChangePassword.TabIndex = 3;
            this.btnSaveUserChangePassword.Text = "Save";
            this.btnSaveUserChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveUserChangePassword.UseVisualStyleBackColor = true;
            this.btnSaveUserChangePassword.Click += new System.EventHandler(this.btnSaveUserChangePassword_Click);
            // 
            // errorpChangePassword
            // 
            this.errorpChangePassword.ContainerControl = this;
            // 
            // btnExitUserChangePassword
            // 
            this.btnExitUserChangePassword.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnExitUserChangePassword.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnExitUserChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnExitUserChangePassword.Location = new System.Drawing.Point(1150, 2);
            this.btnExitUserChangePassword.Name = "btnExitUserChangePassword";
            this.btnExitUserChangePassword.Size = new System.Drawing.Size(50, 43);
            this.btnExitUserChangePassword.TabIndex = 5;
            this.btnExitUserChangePassword.Text = "X";
            this.btnExitUserChangePassword.UseVisualStyleBackColor = false;
            this.btnExitUserChangePassword.Click += new System.EventHandler(this.btnExitUserChangePassword_Click);
            // 
            // ctrlUserCard1
            // 
            this.ctrlUserCard1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlUserCard1.Location = new System.Drawing.Point(16, 8);
            this.ctrlUserCard1.Name = "ctrlUserCard1";
            this.ctrlUserCard1.Size = new System.Drawing.Size(1172, 461);
            this.ctrlUserCard1.TabIndex = 137;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_Mery.Properties.Resources.Password_32;
            this.pictureBox1.Location = new System.Drawing.Point(590, 487);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 138;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLD_Mery.Properties.Resources.Password_32;
            this.pictureBox2.Location = new System.Drawing.Point(590, 534);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 139;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DVLD_Mery.Properties.Resources.Password_32;
            this.pictureBox3.Location = new System.Drawing.Point(590, 581);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 140;
            this.pictureBox3.TabStop = false;
            // 
            // frmChangeUserPassword
            // 
            this.AcceptButton = this.btnSaveUserChangePassword;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DVLD_Mery.Properties.Resources.DVLDbackground1_resized;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnCloseUserChangePassword;
            this.ClientSize = new System.Drawing.Size(1204, 649);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExitUserChangePassword);
            this.Controls.Add(this.ctrlUserCard1);
            this.Controls.Add(this.btnSaveUserChangePassword);
            this.Controls.Add(this.txtConfirmNewPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtCurrentPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCloseUserChangePassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmChangeUserPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChangeUserPassword";
            this.Load += new System.EventHandler(this.frmChangeUserPassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorpChangePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtConfirmNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCloseUserChangePassword;
        private System.Windows.Forms.Button btnSaveUserChangePassword;
        private System.Windows.Forms.ErrorProvider errorpChangePassword;
        private System.Windows.Forms.Button btnExitUserChangePassword;
        private ctrlUserCard ctrlUserCard1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}