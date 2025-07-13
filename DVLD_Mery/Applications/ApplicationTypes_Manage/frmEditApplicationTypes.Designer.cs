namespace DVLD_Mery
{
    partial class frmEditApplicationTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditApplicationTypes));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApplicationTypeTitle = new System.Windows.Forms.TextBox();
            this.txtApplicationTypeFees = new System.Windows.Forms.TextBox();
            this.lblApplicationTypeID = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSaveApplicationTypes = new System.Windows.Forms.Button();
            this.btnCloseApplicationTypes = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Montserrat", 22F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(305, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 37);
            this.label1.TabIndex = 33;
            this.label1.Text = "Update Application Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(234, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 29);
            this.label2.TabIndex = 35;
            this.label2.Text = "ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(204, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 29);
            this.label4.TabIndex = 36;
            this.label4.Text = "Title:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(202, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 29);
            this.label5.TabIndex = 37;
            this.label5.Text = "Fees:";
            // 
            // txtApplicationTypeTitle
            // 
            this.txtApplicationTypeTitle.Font = new System.Drawing.Font("Montserrat", 10F);
            this.txtApplicationTypeTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtApplicationTypeTitle.Location = new System.Drawing.Point(383, 213);
            this.txtApplicationTypeTitle.Name = "txtApplicationTypeTitle";
            this.txtApplicationTypeTitle.Size = new System.Drawing.Size(355, 24);
            this.txtApplicationTypeTitle.TabIndex = 38;
            this.txtApplicationTypeTitle.TextChanged += new System.EventHandler(this.txtApplicationTypeTitle_Validating);
            // 
            // txtApplicationTypeFees
            // 
            this.txtApplicationTypeFees.Font = new System.Drawing.Font("Montserrat", 10F);
            this.txtApplicationTypeFees.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtApplicationTypeFees.Location = new System.Drawing.Point(383, 264);
            this.txtApplicationTypeFees.Name = "txtApplicationTypeFees";
            this.txtApplicationTypeFees.Size = new System.Drawing.Size(355, 24);
            this.txtApplicationTypeFees.TabIndex = 39;
            this.txtApplicationTypeFees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApplicationTypeFees_KeyPress);
            this.txtApplicationTypeFees.Validating += new System.ComponentModel.CancelEventHandler(this.txtApplicationTypeFees_Validating);
            // 
            // lblApplicationTypeID
            // 
            this.lblApplicationTypeID.AutoSize = true;
            this.lblApplicationTypeID.BackColor = System.Drawing.Color.Transparent;
            this.lblApplicationTypeID.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold);
            this.lblApplicationTypeID.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblApplicationTypeID.Location = new System.Drawing.Point(383, 164);
            this.lblApplicationTypeID.Name = "lblApplicationTypeID";
            this.lblApplicationTypeID.Size = new System.Drawing.Size(37, 29);
            this.lblApplicationTypeID.TabIndex = 40;
            this.lblApplicationTypeID.Text = "...";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnSaveApplicationTypes
            // 
            this.btnSaveApplicationTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveApplicationTypes.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveApplicationTypes.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSaveApplicationTypes.Image = global::DVLD_Mery.Properties.Resources.Save_32;
            this.btnSaveApplicationTypes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveApplicationTypes.Location = new System.Drawing.Point(505, 331);
            this.btnSaveApplicationTypes.Name = "btnSaveApplicationTypes";
            this.btnSaveApplicationTypes.Size = new System.Drawing.Size(100, 31);
            this.btnSaveApplicationTypes.TabIndex = 41;
            this.btnSaveApplicationTypes.Text = "Save";
            this.btnSaveApplicationTypes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveApplicationTypes.UseVisualStyleBackColor = true;
            this.btnSaveApplicationTypes.Click += new System.EventHandler(this.btnSaveApplicationTypes_Click);
            // 
            // btnCloseApplicationTypes
            // 
            this.btnCloseApplicationTypes.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCloseApplicationTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseApplicationTypes.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseApplicationTypes.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCloseApplicationTypes.Image = global::DVLD_Mery.Properties.Resources.Close_32;
            this.btnCloseApplicationTypes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseApplicationTypes.Location = new System.Drawing.Point(386, 331);
            this.btnCloseApplicationTypes.Name = "btnCloseApplicationTypes";
            this.btnCloseApplicationTypes.Size = new System.Drawing.Size(100, 31);
            this.btnCloseApplicationTypes.TabIndex = 42;
            this.btnCloseApplicationTypes.Text = "Close";
            this.btnCloseApplicationTypes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCloseApplicationTypes.UseVisualStyleBackColor = true;
            this.btnCloseApplicationTypes.Click += new System.EventHandler(this.btnCloseApplicationTypes_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = global::DVLD_Mery.Properties.Resources.money_32;
            this.pictureBox3.Location = new System.Drawing.Point(312, 263);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 127;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::DVLD_Mery.Properties.Resources.ApplicationTitle;
            this.pictureBox1.Location = new System.Drawing.Point(312, 212);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 126;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox7.Image = global::DVLD_Mery.Properties.Resources.Number_32;
            this.pictureBox7.Location = new System.Drawing.Point(312, 165);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(30, 27);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 125;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::DVLD_Mery.Properties.Resources.edit_32;
            this.pictureBox2.Location = new System.Drawing.Point(267, 60);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 55;
            this.pictureBox2.TabStop = false;
            // 
            // frmEditApplicationTypes
            // 
            this.AcceptButton = this.btnSaveApplicationTypes;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnCloseApplicationTypes;
            this.ClientSize = new System.Drawing.Size(945, 400);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnCloseApplicationTypes);
            this.Controls.Add(this.btnSaveApplicationTypes);
            this.Controls.Add(this.lblApplicationTypeID);
            this.Controls.Add(this.txtApplicationTypeFees);
            this.Controls.Add(this.txtApplicationTypeTitle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmEditApplicationTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmEditApplicationTypes";
            this.Load += new System.EventHandler(this.frmEditApplicationTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtApplicationTypeTitle;
        private System.Windows.Forms.TextBox txtApplicationTypeFees;
        private System.Windows.Forms.Label lblApplicationTypeID;
        private System.Windows.Forms.Button btnSaveApplicationTypes;
        private System.Windows.Forms.Button btnCloseApplicationTypes;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}