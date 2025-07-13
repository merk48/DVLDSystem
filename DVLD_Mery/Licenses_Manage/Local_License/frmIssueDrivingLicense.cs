using DVLD_Mery_Buisness;
using System;
using System.Windows.Forms;

namespace DVLD_Mery
{
    public partial class frmIssueDrivingLicense : Form
    {
        int _LDLAppID = -1; clsLocalDrivingLicenseApplication _LDLApp;

        public frmIssueDrivingLicense(int LDLAppID)
        {
            InitializeComponent();

            _LDLAppID = LDLAppID;
        }

        private void frmIssueDrivingLicense_Load(object sender, EventArgs e)
        {
            // just in case
            _ValidateConditions();

            ctrlLDLAppCard1.LoadLDLAppInfo(_LDLAppID);
            txtLicenseNotes.Focus();
        }

        private void _ValidateConditions()
        {
            _LDLApp = clsLocalDrivingLicenseApplication.FindByID(_LDLAppID);
            if (_LDLApp == null)
                MessageBox.Show("LDLApp not found");

            if (clsLocalDrivingLicenseApplication.GetPassedTestsCount(_LDLApp.LocalDrivingLicenseApplicationID) != 3)
            {
                MessageBox.Show("Person Should Pass All Tests First.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            int LicenseID = clsLicense.IsPersonHasLicense(_LDLApp.ApplicantPersonID, _LDLApp.LicenseClassID);
            if (LicenseID != -1)
            {
                MessageBox.Show("Person already has License before with License ID=" + LicenseID.ToString(), "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
        }

        private void btnIssueDrivingLicense_Click(object sender, EventArgs e)
        {
            int LicenseID = _LDLApp.IssueLicenseForTheFirtTime(txtLicenseNotes.Text.Trim(), clsGlobal.CurrentUser.UserID);

            if (LicenseID != -1)
            {
                MessageBox.Show("License Issued Successfully with License ID = " + LicenseID.ToString(), "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("License Was not Issued ! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCloseIssueDrivingLicense_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
