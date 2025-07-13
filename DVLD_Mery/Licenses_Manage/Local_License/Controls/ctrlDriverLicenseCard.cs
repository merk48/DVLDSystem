using DVLD_Mery.Properties;
using DVLD_Mery_Buisness;
using System.IO;
using System.Windows.Forms;

namespace DVLD_Mery
{
    public partial class ctrlDriverLicenseCard : UserControl
    {

        int _LicenseID = -1; clsLicense _License;

        public clsLicense SelectedLicenseInfo
        { get { return _License; } }

        public ctrlDriverLicenseCard()
        {
            InitializeComponent();
        }

        public void LoadLicenseInfo(int LicenseID)
        {

            _LicenseID = LicenseID;
            _License = clsLicense.Find(_LicenseID);

            if (_License == null)
            {
                MessageBox.Show($"License with ID = {_LicenseID} not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _LoadInfo();
        }

        private void _LoadInfo()
        {
            lblLicenseClass.Text = _License.LicenseClassInfo.ClassName;
            lblLicensePersonName.Text = _License.DriverInfo.PersonInfo.FullName.ToString(); 
            lblLicenseID.Text = _License.LicenseID.ToString();
            lblLicensePersonNationalNo.Text = _License.DriverInfo.PersonInfo.NationalNo;
            lblLicensePersonGender.Text = _License.DriverInfo.PersonInfo.Gender == 0 ? "Male" : "Female";
            lblLicenseIssueDate.Text = _License.IssueDate.ToString();
            lblLicenseIssueResoan.Text = _License.IssueReason == clsLicense.enIssueReason.FirstTime ? "First Time" : _License.IssueReason == clsLicense.enIssueReason.Renew ? "Renew" : _License.IssueReason == clsLicense.enIssueReason.DamagedReplacement ? "Replacement for Damaged" : "Replacement for Lost"; // later with enum
            lblLicenseNotes.Text = _License.Notes == "" ? "No Notes " : _License.Notes;
            lblLicenseIsActive.Text = _License.IsActive ? "Yes" : "No";
            lblLicensePersonDateOfBirth.Text = _License.DriverInfo.PersonInfo.DateOfBirth.ToString();
            lblLicenseDriverID.Text = _License.DriverID.ToString();
            lblLicenseExpirationDate.Text = _License.ExpirationDate.ToString();
            lblLicenseIsDetained.Text = _License.IsDetained ? "Yes" : "No";

            _LoadPersonImage();
        }

        private void _LoadPersonImage()
        {
            string ImagePath = _License.DriverInfo.PersonInfo.ImagePath;

            if (ImagePath != "")
            {
                if (File.Exists(ImagePath))
                    pbLicensePersonImage.ImageLocation = ImagePath;
                else
                    MessageBox.Show($"Could not find this image: = {ImagePath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                pbLicensePersonImage.Image = _License.DriverInfo.PersonInfo.Gender == 0 ? Resources.maledefaultimage : Resources.femaledefaultimage;
        }
    }
}
