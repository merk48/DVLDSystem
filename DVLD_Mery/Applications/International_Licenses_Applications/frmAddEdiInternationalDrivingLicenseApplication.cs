using DVLD_Mery_Buisness;
using System;
using System.Windows.Forms;

namespace DVLD_Mery
{
    public partial class frmAddEdiInternationalDrivingLicenseApplication : Form
    {
        int _IntLAppID = -1 ;int _SelectedLicenseID = -1;
        clsLicense _SelectedLicense;
        Form _frm;

        public frmAddEdiInternationalDrivingLicenseApplication()
        {
            InitializeComponent();
        }

        private void frmAddEdiInternationalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            btnIssueIntLicense.Enabled = false;
            lnklblShowLicenseInfo.Enabled = false;
            lnklblShowLicenseHistory.Enabled = false; 
        }

       
        private void ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected(object sender, ctrlDriverLicenseInfoWithFilter.LicenseSelectedEventsArgs e)
        {
            _SelectedLicenseID = e.LicenseID;

            _SelectedLicense = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo;

            if (_SelectedLicense == null)
            {
                btnIssueIntLicense.Enabled = false;
                return;
            }

            if (_IsLicenseValidForIssueAsInternational())
            {
                btnIssueIntLicense.Enabled = true;

                ctrlIntLAppCard1.Enabled = true;
                ctrlIntLAppCard1.LoadLiceneseID(_SelectedLicense.LicenseID);
            }
            else
            {
                btnIssueIntLicense.Enabled = false;

                ctrlIntLAppCard1.Enabled = false;
            }

            lnklblShowLicenseHistory.Enabled = true;
        }

        private void btnExitManageIntLApplications_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool _IsLicenseValidForIssueAsInternational()
        {
            if (!_SelectedLicense.IsActive)
            {
                MessageBox.Show($"License is Not Active, you can't make it International, Choose another license!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (_SelectedLicense.ExpirationDate < DateTime.Now)
            {
                MessageBox.Show($"License is Expired!, you can't make it International!, Choose another license", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (_SelectedLicense.LicenseClassID != clsLicenseClass.enLicenseClass.OrdinaryDrivingLicense)
            {
                MessageBox.Show($"You can't make A Non Ordinary License International!, Choose another license", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool _IsPersonHasActiveIntLicense()
        {
            int ActiveIntLicenseID = clsInternationalLicense.GetActiveInternationalLicenseIDByDriverID(_SelectedLicense.DriverID);

            if (ActiveIntLicenseID != -1)
            {
                ctrlIntLAppCard1.Enabled = false;
                btnIssueIntLicense.Enabled = false;
                lnklblShowLicenseInfo.Enabled = true;

                _IntLAppID = ActiveIntLicenseID;

                ctrlDriverLicenseInfoWithFilter1.LoadLicenseInfo(_SelectedLicenseID);
                MessageBox.Show($"Person already have an Active International License with ID = [{ActiveIntLicenseID}]", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return true;
            }

            return false;
        }

        private void btnIssueIntLicense_Click(object sender, EventArgs e)
        {
            if (_IsPersonHasActiveIntLicense())
                return;

            if(MessageBox.Show("Are you sure you to Issue This International License?","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes)
            {
                clsInternationalLicense IntlLicense = new clsInternationalLicense();

                IntlLicense.ApplicantPersonID = _SelectedLicense.DriverInfo.PersonID;
                IntlLicense.ApplicationDate = DateTime.Now;
                IntlLicense.ApplicationStatus = clsApplication.enApplicationStatus.Completed;
                IntlLicense.LastStatusDate = DateTime.Now;
                IntlLicense.PaidFees = clsApplicationType.GetApplicationTypeFee(clsApplicationType.enApplicationType.NewInternationalLicense);
                IntlLicense.CreatedByUserID = clsGlobal.CurrentUser.UserID;
                IntlLicense.IsActive = true;

                IntlLicense.DriverID = _SelectedLicense.DriverID;
                IntlLicense.IssuedUsingLocalLicenseID = _SelectedLicense.LicenseID;
                IntlLicense.IssueDate = DateTime.Now;
                IntlLicense.ExpirationDate = DateTime.Now.AddYears(1);


                if (IntlLicense.Save())
                {
                    _IntLAppID = IntlLicense.InternationalLicenseID;

                    ctrlIntLAppCard1.LoadIntAppInfo(IntlLicense);
                    ctrlDriverLicenseInfoWithFilter1.LoadLicenseInfo(_SelectedLicense.LicenseID);
                    ctrlDriverLicenseInfoWithFilter1.gbLicenseFilter.Enabled = false;

                    btnIssueIntLicense.Enabled = false;
                    lnklblShowLicenseInfo.Enabled = true;
                    MessageBox.Show($"International Issued successfuly with ID = [{IntlLicense.InternationalLicenseID}]", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show($"International License not Saved", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnklblShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _frm = new frmShowInternatioanlLicenseDetails(_IntLAppID);
            _frm.ShowDialog();
        }

        private void lnklblShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _frm = new frmShowPersonLicenseHistory(_SelectedLicense.DriverInfo.PersonInfo.NationalNo);
            _frm.ShowDialog();

            ctrlDriverLicenseInfoWithFilter1.LoadLicenseInfo(_SelectedLicense.LicenseID);
        }

        
    }
}
