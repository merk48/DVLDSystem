namespace DVLD_Mery
{
    partial class ctrlPersonCardWithFilter
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
            this.gbPersonFilter = new System.Windows.Forms.GroupBox();
            this.btnAddNewPerson = new System.Windows.Forms.Button();
            this.btnSearchPerson = new System.Windows.Forms.Button();
            this.txtPeopleFilterToSelect = new System.Windows.Forms.TextBox();
            this.cmbFilterPeopleToSelect = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ctrlPersonCard1 = new DVLD_Mery.ctrlPersonCard();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbPersonFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPersonFilter
            // 
            this.gbPersonFilter.BackColor = System.Drawing.Color.Transparent;
            this.gbPersonFilter.Controls.Add(this.btnAddNewPerson);
            this.gbPersonFilter.Controls.Add(this.btnSearchPerson);
            this.gbPersonFilter.Controls.Add(this.txtPeopleFilterToSelect);
            this.gbPersonFilter.Controls.Add(this.cmbFilterPeopleToSelect);
            this.gbPersonFilter.Controls.Add(this.label3);
            this.gbPersonFilter.ForeColor = System.Drawing.Color.Crimson;
            this.gbPersonFilter.Location = new System.Drawing.Point(5, 3);
            this.gbPersonFilter.Name = "gbPersonFilter";
            this.gbPersonFilter.Size = new System.Drawing.Size(1165, 57);
            this.gbPersonFilter.TabIndex = 40;
            this.gbPersonFilter.TabStop = false;
            this.gbPersonFilter.Text = "Filter";
            // 
            // btnAddNewPerson
            // 
            this.btnAddNewPerson.BackgroundImage = global::DVLD_Mery.Properties.Resources.AddPerson_32;
            this.btnAddNewPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddNewPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewPerson.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewPerson.Location = new System.Drawing.Point(594, 6);
            this.btnAddNewPerson.Name = "btnAddNewPerson";
            this.btnAddNewPerson.Size = new System.Drawing.Size(62, 51);
            this.btnAddNewPerson.TabIndex = 2;
            this.btnAddNewPerson.UseVisualStyleBackColor = true;
            this.btnAddNewPerson.Click += new System.EventHandler(this.btnAddNewPerson_Click);
            // 
            // btnSearchPerson
            // 
            this.btnSearchPerson.BackgroundImage = global::DVLD_Mery.Properties.Resources.SearchPerson;
            this.btnSearchPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearchPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchPerson.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchPerson.Location = new System.Drawing.Point(517, 6);
            this.btnSearchPerson.Name = "btnSearchPerson";
            this.btnSearchPerson.Size = new System.Drawing.Size(62, 51);
            this.btnSearchPerson.TabIndex = 1;
            this.btnSearchPerson.UseVisualStyleBackColor = true;
            this.btnSearchPerson.Click += new System.EventHandler(this.btnSearchPerson_Click);
            // 
            // txtPeopleFilterToSelect
            // 
            this.txtPeopleFilterToSelect.ForeColor = System.Drawing.Color.Crimson;
            this.txtPeopleFilterToSelect.Location = new System.Drawing.Point(287, 25);
            this.txtPeopleFilterToSelect.Name = "txtPeopleFilterToSelect";
            this.txtPeopleFilterToSelect.Size = new System.Drawing.Size(184, 20);
            this.txtPeopleFilterToSelect.TabIndex = 0;
            this.txtPeopleFilterToSelect.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeopleFilterToSelect_KeyPress);
            this.txtPeopleFilterToSelect.Validating += new System.ComponentModel.CancelEventHandler(this.txtPeopleFilterToSelect_Validating);
            // 
            // cmbFilterPeopleToSelect
            // 
            this.cmbFilterPeopleToSelect.AutoCompleteCustomSource.AddRange(new string[] {
            "None",
            "UserID",
            "PersonID",
            "Username",
            "Full Name",
            "Is Active"});
            this.cmbFilterPeopleToSelect.ForeColor = System.Drawing.Color.Crimson;
            this.cmbFilterPeopleToSelect.FormattingEnabled = true;
            this.cmbFilterPeopleToSelect.Items.AddRange(new object[] {
            "PersonID",
            "NationalNo"});
            this.cmbFilterPeopleToSelect.Location = new System.Drawing.Point(100, 25);
            this.cmbFilterPeopleToSelect.Name = "cmbFilterPeopleToSelect";
            this.cmbFilterPeopleToSelect.Size = new System.Drawing.Size(169, 21);
            this.cmbFilterPeopleToSelect.TabIndex = 3;
            this.cmbFilterPeopleToSelect.SelectedIndexChanged += new System.EventHandler(this.cmbFilterPeopleToSelect_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 32;
            this.label3.Text = "Filter By";
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlPersonCard1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlPersonCard1.Location = new System.Drawing.Point(3, 67);
            this.ctrlPersonCard1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(1178, 334);
            this.ctrlPersonCard1.TabIndex = 39;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // ctrlPersonCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gbPersonFilter);
            this.Controls.Add(this.ctrlPersonCard1);
            this.Name = "ctrlPersonCardWithFilter";
            this.Size = new System.Drawing.Size(1175, 406);
            this.Load += new System.EventHandler(this.ctrlPersonCardWithFilter_Load);
            this.gbPersonFilter.ResumeLayout(false);
            this.gbPersonFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox gbPersonFilter;
        private System.Windows.Forms.Button btnAddNewPerson;
        private System.Windows.Forms.Button btnSearchPerson;
        public System.Windows.Forms.TextBox txtPeopleFilterToSelect;
        private System.Windows.Forms.ComboBox cmbFilterPeopleToSelect;
        private System.Windows.Forms.Label label3;
        public ctrlPersonCard ctrlPersonCard1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}
