using System;
using System.IO;
using System.Windows.Forms;
using DVLD_Mery.Properties;
using DVLD_Mery_Buisness;
using static DVLD_Mery.frmAddEditPerson;

namespace DVLD_Mery
{
    public partial class ctrlPersonCard : UserControl
    {
        private clsPerson _Person;

        public ctrlPersonCard()
        {
            InitializeComponent();
        }

        public void LoadPersonInfo(string NationalNo)
        {
            _Person = clsPerson.Find(NationalNo);

            if (_Person == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Person with National No. = " + NationalNo.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillPersonInfo();
        }

        public void LoadPersonInfo(int PersonID)
        {
            _Person = clsPerson.Find(PersonID);
            if (_Person == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Person with PersonID = " + PersonID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillPersonInfo();
        }

        public void ResetPersonInfo()
        {
            lblPersonID.Text = "[???]";
            lblPersonName.Text = "[???]";
            lblPersonGender.Text = "[???]";
            lblPersonEmail.Text = "[???]";
            lblPersonNationalNo.Text = "[???]";
            lblPersonDateOfBirth.Text = "[???]";
            lblPersonPhone.Text = "[???]";
            lblPersonAddress.Text = "[???]";
            lblPersonCountry.Text = "[???]";
            pbPersonImage.Image = Resources.maledefaultimage;

            llEditPerson.Enabled = false;
        }

        private void _FillPersonInfo()
        {
            lblPersonID.Text = _Person.PersonID.ToString();
            lblPersonName.Text = _Person.FullName;
            lblPersonGender.Text = _Person.Gender == 0 ? "Male" : "Female";
            lblPersonEmail.Text = _Person.Email;
            lblPersonNationalNo.Text = _Person.NationalNo;
            lblPersonDateOfBirth.Text = _Person.DateOfBirth.ToShortDateString(); ;
            lblPersonPhone.Text = _Person.Phone;
            lblPersonAddress.Text = _Person.Address;
            lblPersonCountry.Text = clsCountry.GetCountryNameByID(_Person.NationalityCountryID);
            _LoadPersonImage();

            llEditPerson.Enabled = true;

        }

        private void _LoadPersonImage()
        {
            pbPersonImage.Image = _Person.Gender == 0 ? Resources.maledefaultimage : Resources.femaledefaultimage;

            string ImagePath = _Person.ImagePath;

            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    pbPersonImage.ImageLocation = ImagePath;
                else
                    MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void llEditPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson(_Person.PersonID);

            frm.DataBack += LoadPersonInfo_DataBack; // Subscribe to the event

            frm.ShowDialog();
        }

        private void LoadPersonInfo_DataBack(Object Sender, int PersonID)
        {
            LoadPersonInfo(PersonID);
        }

    }
}
