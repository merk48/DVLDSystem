namespace DVLD_Mery
{
    partial class frmManagePeople
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManagePeople));
            this.dgvPeople = new System.Windows.Forms.DataGridView();
            this.cmsPerson = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbFilterPeopleByProperity = new System.Windows.Forms.ComboBox();
            this.txtPeopleFilter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPApplicationTypesRecords = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddNewPerson = new System.Windows.Forms.Button();
            this.pnlGenderFilter = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.rdbFilterFemale = new System.Windows.Forms.RadioButton();
            this.rdbFilterMale = new System.Windows.Forms.RadioButton();
            this.lnklblClearFilter = new System.Windows.Forms.LinkLabel();
            this.btnExitManagePeople = new System.Windows.Forms.Button();
            this.btnCloseManagePeople = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).BeginInit();
            this.cmsPerson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlGenderFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPeople
            // 
            this.dgvPeople.AllowUserToAddRows = false;
            this.dgvPeople.AllowUserToDeleteRows = false;
            this.dgvPeople.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPeople.BackgroundColor = System.Drawing.Color.White;
            this.dgvPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeople.ContextMenuStrip = this.cmsPerson;
            this.dgvPeople.Location = new System.Drawing.Point(30, 209);
            this.dgvPeople.Name = "dgvPeople";
            this.dgvPeople.ReadOnly = true;
            this.dgvPeople.Size = new System.Drawing.Size(1145, 358);
            this.dgvPeople.TabIndex = 16;
            this.dgvPeople.DoubleClick += new System.EventHandler(this.dgvPeople_DoubleClick);
            // 
            // cmsPerson
            // 
            this.cmsPerson.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsPerson.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.cmsPerson.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.addNewPersonToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.sendEmailToolStripMenuItem,
            this.phoneCallToolStripMenuItem});
            this.cmsPerson.Name = "cmsPerson";
            this.cmsPerson.Size = new System.Drawing.Size(190, 220);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Image = global::DVLD_Mery.Properties.Resources.PersonDetails_32;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(189, 36);
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // addNewPersonToolStripMenuItem
            // 
            this.addNewPersonToolStripMenuItem.Image = global::DVLD_Mery.Properties.Resources.AddPerson_32;
            this.addNewPersonToolStripMenuItem.Name = "addNewPersonToolStripMenuItem";
            this.addNewPersonToolStripMenuItem.Size = new System.Drawing.Size(189, 36);
            this.addNewPersonToolStripMenuItem.Text = "Add New Person";
            this.addNewPersonToolStripMenuItem.Click += new System.EventHandler(this.addNewPersonToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::DVLD_Mery.Properties.Resources.EditPerson;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(189, 36);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::DVLD_Mery.Properties.Resources.Delete2;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(189, 36);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.Image = global::DVLD_Mery.Properties.Resources.SendEmail_removebg_preview;
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(189, 36);
            this.sendEmailToolStripMenuItem.Text = "Send Email";
            this.sendEmailToolStripMenuItem.Click += new System.EventHandler(this.sendEmailToolStripMenuItem_Click);
            // 
            // phoneCallToolStripMenuItem
            // 
            this.phoneCallToolStripMenuItem.Image = global::DVLD_Mery.Properties.Resources.CallPhone_removebg_preview;
            this.phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            this.phoneCallToolStripMenuItem.Size = new System.Drawing.Size(189, 36);
            this.phoneCallToolStripMenuItem.Text = "Phone Call";
            this.phoneCallToolStripMenuItem.Click += new System.EventHandler(this.phoneCallToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Montserrat", 22F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(488, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 39);
            this.label1.TabIndex = 17;
            this.label1.Text = "Manage People";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "Filter By";
            // 
            // cmbFilterPeopleByProperity
            // 
            this.cmbFilterPeopleByProperity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterPeopleByProperity.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cmbFilterPeopleByProperity.FormattingEnabled = true;
            this.cmbFilterPeopleByProperity.Items.AddRange(new object[] {
            "None",
            "PersonID",
            "NationalNo",
            "FirstName",
            "SecondName",
            "ThirdName",
            "LastName",
            "Nationality",
            "Gender",
            "Phone",
            "Email"});
            this.cmbFilterPeopleByProperity.Location = new System.Drawing.Point(121, 176);
            this.cmbFilterPeopleByProperity.Name = "cmbFilterPeopleByProperity";
            this.cmbFilterPeopleByProperity.Size = new System.Drawing.Size(169, 21);
            this.cmbFilterPeopleByProperity.TabIndex = 21;
            this.cmbFilterPeopleByProperity.SelectedIndexChanged += new System.EventHandler(this.cmbFilterByProperity_SelectedIndexChanged);
            // 
            // txtPeopleFilter
            // 
            this.txtPeopleFilter.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtPeopleFilter.Location = new System.Drawing.Point(308, 179);
            this.txtPeopleFilter.Name = "txtPeopleFilter";
            this.txtPeopleFilter.Size = new System.Drawing.Size(184, 20);
            this.txtPeopleFilter.TabIndex = 22;
            this.txtPeopleFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            this.txtPeopleFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeopleFilter_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 581);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 35;
            this.label2.Text = "# Records: ";
            // 
            // lblPApplicationTypesRecords
            // 
            this.lblPApplicationTypesRecords.AutoSize = true;
            this.lblPApplicationTypesRecords.BackColor = System.Drawing.Color.Transparent;
            this.lblPApplicationTypesRecords.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.lblPApplicationTypesRecords.ForeColor = System.Drawing.Color.White;
            this.lblPApplicationTypesRecords.Location = new System.Drawing.Point(132, 581);
            this.lblPApplicationTypesRecords.Name = "lblPApplicationTypesRecords";
            this.lblPApplicationTypesRecords.Size = new System.Drawing.Size(23, 18);
            this.lblPApplicationTypesRecords.TabIndex = 36;
            this.lblPApplicationTypesRecords.Text = "...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::DVLD_Mery.Properties.Resources.People_400;
            this.pictureBox1.Location = new System.Drawing.Point(546, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // btnAddNewPerson
            // 
            this.btnAddNewPerson.BackColor = System.Drawing.Color.White;
            this.btnAddNewPerson.BackgroundImage = global::DVLD_Mery.Properties.Resources.AddPerson_32;
            this.btnAddNewPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddNewPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewPerson.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnAddNewPerson.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddNewPerson.Image = global::DVLD_Mery.Properties.Resources.AddNewPersonimg_removebg_preview;
            this.btnAddNewPerson.Location = new System.Drawing.Point(1107, 152);
            this.btnAddNewPerson.Name = "btnAddNewPerson";
            this.btnAddNewPerson.Size = new System.Drawing.Size(68, 45);
            this.btnAddNewPerson.TabIndex = 19;
            this.btnAddNewPerson.UseVisualStyleBackColor = false;
            this.btnAddNewPerson.Click += new System.EventHandler(this.btnAddNewPerson_Click);
            // 
            // pnlGenderFilter
            // 
            this.pnlGenderFilter.BackColor = System.Drawing.Color.Transparent;
            this.pnlGenderFilter.Controls.Add(this.label13);
            this.pnlGenderFilter.Controls.Add(this.rdbFilterFemale);
            this.pnlGenderFilter.Controls.Add(this.rdbFilterMale);
            this.pnlGenderFilter.Location = new System.Drawing.Point(307, 172);
            this.pnlGenderFilter.Name = "pnlGenderFilter";
            this.pnlGenderFilter.Size = new System.Drawing.Size(165, 35);
            this.pnlGenderFilter.TabIndex = 37;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Image = global::DVLD_Mery.Properties.Resources.genderfemaleicon;
            this.label13.Location = new System.Drawing.Point(114, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 13);
            this.label13.TabIndex = 91;
            // 
            // rdbFilterFemale
            // 
            this.rdbFilterFemale.AutoSize = true;
            this.rdbFilterFemale.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFilterFemale.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rdbFilterFemale.Location = new System.Drawing.Point(83, 8);
            this.rdbFilterFemale.Name = "rdbFilterFemale";
            this.rdbFilterFemale.Size = new System.Drawing.Size(74, 20);
            this.rdbFilterFemale.TabIndex = 1;
            this.rdbFilterFemale.Text = "Female";
            this.rdbFilterFemale.UseVisualStyleBackColor = true;
            this.rdbFilterFemale.CheckedChanged += new System.EventHandler(this.rdbFilterGender_CheckedChanged);
            // 
            // rdbFilterMale
            // 
            this.rdbFilterMale.AutoSize = true;
            this.rdbFilterMale.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFilterMale.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rdbFilterMale.Location = new System.Drawing.Point(5, 7);
            this.rdbFilterMale.Name = "rdbFilterMale";
            this.rdbFilterMale.Size = new System.Drawing.Size(58, 20);
            this.rdbFilterMale.TabIndex = 0;
            this.rdbFilterMale.Text = "Male";
            this.rdbFilterMale.UseVisualStyleBackColor = true;
            this.rdbFilterMale.CheckedChanged += new System.EventHandler(this.rdbFilterGender_CheckedChanged);
            // 
            // lnklblClearFilter
            // 
            this.lnklblClearFilter.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.lnklblClearFilter.AutoSize = true;
            this.lnklblClearFilter.BackColor = System.Drawing.Color.Transparent;
            this.lnklblClearFilter.Font = new System.Drawing.Font("Montserrat", 8F);
            this.lnklblClearFilter.LinkColor = System.Drawing.Color.MidnightBlue;
            this.lnklblClearFilter.Location = new System.Drawing.Point(496, 184);
            this.lnklblClearFilter.Name = "lnklblClearFilter";
            this.lnklblClearFilter.Size = new System.Drawing.Size(67, 14);
            this.lnklblClearFilter.TabIndex = 38;
            this.lnklblClearFilter.TabStop = true;
            this.lnklblClearFilter.Text = "Clear Filter";
            this.lnklblClearFilter.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblClearFilter_LinkClicked);
            // 
            // btnExitManagePeople
            // 
            this.btnExitManagePeople.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnExitManagePeople.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnExitManagePeople.ForeColor = System.Drawing.Color.White;
            this.btnExitManagePeople.Location = new System.Drawing.Point(1149, 4);
            this.btnExitManagePeople.Name = "btnExitManagePeople";
            this.btnExitManagePeople.Size = new System.Drawing.Size(50, 43);
            this.btnExitManagePeople.TabIndex = 39;
            this.btnExitManagePeople.Text = "X";
            this.btnExitManagePeople.UseVisualStyleBackColor = false;
            this.btnExitManagePeople.Click += new System.EventHandler(this.btnCloseManagePeople_Click);
            // 
            // btnCloseManagePeople
            // 
            this.btnCloseManagePeople.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCloseManagePeople.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseManagePeople.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseManagePeople.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCloseManagePeople.Image = global::DVLD_Mery.Properties.Resources.Close_321;
            this.btnCloseManagePeople.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseManagePeople.Location = new System.Drawing.Point(1071, 573);
            this.btnCloseManagePeople.Name = "btnCloseManagePeople";
            this.btnCloseManagePeople.Size = new System.Drawing.Size(104, 35);
            this.btnCloseManagePeople.TabIndex = 132;
            this.btnCloseManagePeople.Text = "Close";
            this.btnCloseManagePeople.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCloseManagePeople.UseVisualStyleBackColor = true;
            this.btnCloseManagePeople.Click += new System.EventHandler(this.btnCloseManagePeople_Click);
            // 
            // frmManagePeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DVLD_Mery.Properties.Resources.DVLDbackground1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnCloseManagePeople;
            this.ClientSize = new System.Drawing.Size(1204, 616);
            this.Controls.Add(this.btnCloseManagePeople);
            this.Controls.Add(this.btnExitManagePeople);
            this.Controls.Add(this.lnklblClearFilter);
            this.Controls.Add(this.pnlGenderFilter);
            this.Controls.Add(this.lblPApplicationTypesRecords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPeopleFilter);
            this.Controls.Add(this.cmbFilterPeopleByProperity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddNewPerson);
            this.Controls.Add(this.dgvPeople);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmManagePeople";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManagePeople";
            this.Load += new System.EventHandler(this.frmManagePeople_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).EndInit();
            this.cmsPerson.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlGenderFilter.ResumeLayout(false);
            this.pnlGenderFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPeople;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddNewPerson;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbFilterPeopleByProperity;
        private System.Windows.Forms.TextBox txtPeopleFilter;
        private System.Windows.Forms.ContextMenuStrip cmsPerson;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneCallToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPApplicationTypesRecords;
        private System.Windows.Forms.Panel pnlGenderFilter;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton rdbFilterFemale;
        private System.Windows.Forms.RadioButton rdbFilterMale;
        private System.Windows.Forms.LinkLabel lnklblClearFilter;
        private System.Windows.Forms.Button btnExitManagePeople;
        private System.Windows.Forms.Button btnCloseManagePeople;
    }
}