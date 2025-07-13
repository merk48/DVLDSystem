using DVLD_Mery.Properties;
using DVLD_Mery_Buisness;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.IO;
using DVLD_Mery.Global_Classes;
using DVLD.Classes;

namespace DVLD_Mery
{
    public partial class frmAddEditPerson : Form
    {
        //Declare a Delegate
        public delegate void DataBackEventHandler(Object Sender, int PersonID);

        //Declare an event using the delegate
        public event DataBackEventHandler DataBack;

        enum enMode { AddNew = 0, Update = 1 } enMode _Mode = enMode.AddNew;
        public enum enGendor { Male = 0, Female = 1 };

        int _PersonID = -1; clsPerson _Person;

        public frmAddEditPerson()
        {
            InitializeComponent();

            _Mode = enMode.AddNew;
        }

        public frmAddEditPerson(int PersonID)
        {
            InitializeComponent();

            _PersonID = PersonID;
            _Mode = enMode.Update;
        }

        private void frmAddNewPerson_Load(object sender, EventArgs e)
        {
            _SetDefaultValues();

            _SetMode();
        }

        private void _SetDefaultValues()
        {
            _FillCountriesInComoboBox();

            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            dtpDateOfBirth.MinDate = DateTime.Now.AddYears(-100);
        }

        private void _FillCountriesInComoboBox()
        {
            foreach (DataRow row in clsCountry.GetAllCountries().Rows)
                cmbCountry.Items.Add(row["CountryName"]);
        }

        private void _SetMode()
        {
            if (_Mode == enMode.AddNew)
                _AppNewPerson();
            else
                _UpdatePerson();
        }

        private void _AppNewPerson()
        {
            lblCardTitle.Text = "Add New Person";
            this.Text = "Add New Person";
            lblPersonID.Text = "N/A";
            llRemoveImage.Visible = false;

            rdbMale.Checked = true;
            pbPersonImage.Image = Resources.maledefaultimage;

            cmbCountry.SelectedIndex = cmbCountry.FindString("Jordan");

            dtpDateOfBirth.Value = dtpDateOfBirth.MaxDate.AddDays(-1);

            _Person = new clsPerson();
        }

        private void _UpdatePerson()
        {
            lblCardTitle.Text = "Update Person";
            this.Text = "Update Person";

            _Person = clsPerson.Find(_PersonID);

            _LoadData();
        }

        private void _LoadData()
        {
            if (_Person != null)
            {
                lblPersonID.Text = _Person.PersonID.ToString();
                txtFirstName.Text = _Person.FirstName;
                txtSecondName.Text = _Person.SecondName;
                txtThirdName.Text = _Person.ThirdName;
                txtLastName.Text = _Person.LastName;
                txtNationalNo.Text = _Person.NationalNo;
                dtpDateOfBirth.Value = _Person.DateOfBirth;
                txtPhone.Text = _Person.Phone;
                txtEmail.Text = _Person.Email;
                txtAddress.Text = _Person.Address;

                rdbMale.Checked = _Person.Gender == 0;
                rdbFemale.Checked = _Person.Gender == 1;

                cmbCountry.Text = clsCountry.Find(_Person.NationalityCountryID).CountryName;
                cmbCountry.SelectedIndex = cmbCountry.FindString(_Person.CountryInfo.CountryName);

                if (_Person.ImagePath != "")
                    pbPersonImage.ImageLocation = _Person.ImagePath;
                else
                    pbPersonImage.Image = rdbMale.Checked ? Resources.maledefaultimage : Resources.femaledefaultimage;

                llRemoveImage.Visible = (pbPersonImage.ImageLocation != null);
            }
            else
            {
                MessageBox.Show("The Form Will be Closed Because Person Not Found", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
        }

        private bool _ValidateInput()
        {
             if (string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtSecondName.Text) ||
                     string.IsNullOrEmpty(txtLastName.Text) || string.IsNullOrEmpty(txtPhone.Text) ||
                     string.IsNullOrEmpty(txtNationalNo.Text) || string.IsNullOrEmpty(txtAddress.Text) ||
                     (_Mode == enMode.AddNew && clsPerson.IsPersonExists(txtNationalNo.Text)))

                     if (this.ValidateChildren())
                                return false;

            return true;
        }

        private bool _HandlePersonImage()
        {
            //image changed >> update an existing image
            if (_Person.ImagePath != pbPersonImage.ImageLocation)
            {
                // delete the old image
                if (_Person.ImagePath != "")
                {
                    try
                    {
                        File.Delete(_Person.ImagePath);
                    }
                    catch (IOException iox)
                    {
                        MessageBox.Show($"The image not deleted IOException: {iox}");
                    }
                }

                // add the new image
                if (pbPersonImage.ImageLocation != null)
                {
                    //then we copy the new image to the image folder after we rename it
                    string SourceImageFile = pbPersonImage.ImageLocation.ToString();

                    if (clsUtil.CopyImageToProjectImagesFolder(ref SourceImageFile))
                    {
                        pbPersonImage.ImageLocation = SourceImageFile;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }

            // Still the same >> image not changed do not do anything
            return true;
        }

        private void btnSaveCard_Click(object sender, EventArgs e)
        {
            if (!_ValidateInput())
            {
                MessageBox.Show("Some fields are not valid, hover on the red icon to see the error!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!_HandlePersonImage())
                return;

            _Person.FirstName = txtFirstName.Text.ToString();
            _Person.SecondName = txtSecondName.Text.ToString();
            _Person.ThirdName = txtThirdName.Text.ToString();
            _Person.LastName = txtLastName.Text.ToString();
            _Person.NationalNo = txtNationalNo.Text.ToString();
            _Person.DateOfBirth = dtpDateOfBirth.Value;
            _Person.Gender = Convert.ToByte(rdbMale.Checked ? enGendor.Male : enGendor.Female);
            _Person.Phone = txtPhone.Text.ToString();
            _Person.Email = txtEmail.Text.ToString();
            _Person.Address = txtAddress.Text.ToString();
            _Person.NationalityCountryID = clsCountry.GetCountryIDByName(cmbCountry.Text);


            if (pbPersonImage.ImageLocation != null)
                _Person.ImagePath = pbPersonImage.ImageLocation;
            else
                _Person.ImagePath = "";

            if (_Person.Save())
            {
                _PersonID = _Person.PersonID;
                _Mode = enMode.Update;
                _UpdatePerson();

                MessageBox.Show("Data Saved Successfuly!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Trigger the event to send data bacl to PersonDetails Form (Form1)
                DataBack?.Invoke(this, _Person.PersonID);
            }
            else
                MessageBox.Show("Data Saved Failed!", "Saved Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            opfAddNewPersonCard.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            opfAddNewPersonCard.FilterIndex = 1;
            opfAddNewPersonCard.RestoreDirectory = true;

            if (opfAddNewPersonCard.ShowDialog() == DialogResult.OK)
            {
                string PersonImagePath = opfAddNewPersonCard.FileName;
               pbPersonImage.ImageLocation = PersonImagePath;  
               llRemoveImage.Visible = true;
               //pbPersonImage.Load(PersonImagePath);
               // llRemoveImage.Visible = true;
            }
        }

        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbPersonImage.ImageLocation = null;
            pbPersonImage.Image = rdbMale.Checked ? Resources.maledefaultimage : Resources.femaledefaultimage;
            llRemoveImage.Visible = false;
        }

        private bool SetError(Control control, bool condition, string errorMessage)
        {
            if (condition)
            {
                errpAddNewPersonCard.SetError(control, errorMessage);
                return true;
            }
            else
            {
                errpAddNewPersonCard.SetError(control, "");
                return false;
            }
        }

        private void TextBox_Validating(object sender, CancelEventArgs e)
        {
            System.Windows.Forms.TextBox textbox = (System.Windows.Forms.TextBox)sender;
            SetError(textbox, string.IsNullOrEmpty(textbox.Text), "This field is required");
        }

        private void txtNationalNo_Validating(object sender, CancelEventArgs e)
        {
            if (!SetError(txtNationalNo, (((_Mode == enMode.Update && txtNationalNo.Text.Trim() != _Person.NationalNo) || _Mode == enMode.AddNew) && clsPerson.IsPersonExists(txtNationalNo.Text.Trim())), "National Number is used for another person!"))
               SetError(txtNationalNo, string.IsNullOrEmpty(txtNationalNo.Text), "This field is required");
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            SetError(txtEmail, (!string.IsNullOrEmpty(txtEmail.Text) && !clsValidatoin.ValidateEmail(txtEmail.Text.Trim())), "Enter a valid email format: name@example.com");
        }

        private void GenderRadioButtons_CheckedChanged(object sender, EventArgs e)
        {
            if (pbPersonImage.ImageLocation == null)
                pbPersonImage.Image = rdbMale.Checked ? Resources.maledefaultimage : Resources.femaledefaultimage;
        }

        private void frmAddEditPerson_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnCloseCard_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
