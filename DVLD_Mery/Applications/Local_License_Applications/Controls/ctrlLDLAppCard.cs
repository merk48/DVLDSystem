using DVLD_Mery_Buisness;
using System.Windows.Forms;

namespace DVLD_Mery
{
    public partial class ctrlLDLAppCard : UserControl
    {
        private int _LDLAppID = -1; clsLocalDrivingLicenseApplication _LDLApp; int _LicenseID = -1;

        public int LDLAppID { get { return _LDLAppID; } }

        public ctrlLDLAppCard()
        {
            InitializeComponent();
        }

        public void LoadLDLAppInfo(int LDLAppID)
        {
            _LDLAppID = LDLAppID;
            _LDLApp = clsLocalDrivingLicenseApplication.FindByID(LDLAppID);

            if (_LDLApp == null)
            {
                _ResetLDLAppInfo();
                MessageBox.Show($"No L.D.L.App with ID = {LDLAppID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillLDLAppInfo();
        }

        private void _FillLDLAppInfo()
        {
            _LicenseID = clsLicense.IsPersonHasActiveLicense(_LDLApp.ApplicantPersonID, _LDLApp.LicenseClassID);
            llShowLicenseInfo.Enabled = (_LicenseID != -1);

            lblLDLAppID.Text = _LDLApp.LocalDrivingLicenseApplicationID.ToString();
            lblLDLAppAppliedForLicense.Text = _LDLApp.LicenseClassInfo.ClassName;
            lblLDLAppPassedTests.Text = clsLocalDrivingLicenseApplication.GetPassedTestsCount(_LDLApp.LocalDrivingLicenseApplicationID).ToString();
            ctrlApplicationBasicInfoCard1.LoadApplicationInfo(_LDLApp.ApplicationID);
        }

        private void _ResetLDLAppInfo()
        {
            lblLDLAppID.Text = _LDLApp.LocalDrivingLicenseApplicationID.ToString();
            lblLDLAppAppliedForLicense.Text = "[???]";
            lblLDLAppPassedTests.Text = "[???]";
            ctrlApplicationBasicInfoCard1.ResetApplcationInfo();
        }

        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseDetails frm = new frmShowLicenseDetails(_LicenseID);
            frm.ShowDialog();
        }
    }
}
