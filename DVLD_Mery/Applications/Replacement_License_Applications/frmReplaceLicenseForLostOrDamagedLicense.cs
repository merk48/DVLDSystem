using DVLD_Mery_Buisness;
using System;
using System.Windows.Forms;

namespace DVLD_Mery
{
    public partial class frmReplaceLicenseForLostOrDamagedLicense : Form
    {
        clsApplicationType.enApplicationType ReplaceReason = clsApplicationType.enApplicationType.ReplaceDamagedDrivingLicense;

        int _SelectedLicenseID = -1;
        clsLicense _SelectedLicense;clsLicense _NewLicense;
        Form _frm;

        public frmReplaceLicenseForLostOrDamagedLicense()
        {
            InitializeComponent();
        }
        
        private void frmReplaceLicenseForLostOrDamagedLicense_Load(object sender, EventArgs e)
        {
            rbDamageLicense.Checked = true;
            ctrlReplacementApplicationInfoCard1.lblRLAppFees.Text = clsApplicationType.GetApplicationTypeFee(ReplaceReason).ToString();

            btnReplaceLicense.Enabled = false;
            lnklblShowNewLicenseInfo.Enabled = false;
            lnklblShowLicenseHistory.Enabled = false;
        }

        private void ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected(object sender, ctrlDriverLicenseInfoWithFilter.LicenseSelectedEventsArgs e)
        {
            _SelectedLicenseID = e.LicenseID;
            _SelectedLicense = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo;

            if (_SelectedLicense == null)
            {
                btnReplaceLicense.Enabled = false;
                return;
            }

            if (_IsLicenseValidForReplace())
            {
                btnReplaceLicense.Enabled = true;

                gbReplacementFor.Enabled = true;
                ctrlReplacementApplicationInfoCard1.Enabled = true;
                ctrlReplacementApplicationInfoCard1.LoadOldLicenseInfo(_SelectedLicense.LicenseID);
            }
            else
            {
                btnReplaceLicense.Enabled = false;

                gbReplacementFor.Enabled = false;
                ctrlReplacementApplicationInfoCard1.Enabled = false;
            }

            lnklblShowLicenseHistory.Enabled = true;
        }
      
        private void rbDamageLostLicense_CheckedChanged(object sender, EventArgs e)
        {
            ReplaceReason = rbDamageLicense.Checked ? clsApplicationType.enApplicationType.ReplaceDamagedDrivingLicense : clsApplicationType.enApplicationType.ReplaceLostDrivingLicense;
            ctrlReplacementApplicationInfoCard1.lblRLAppFees.Text =clsApplicationType.GetApplicationTypeFee(ReplaceReason).ToString();
            lblTitle.Text = ReplaceReason == clsApplicationType.enApplicationType.ReplaceDamagedDrivingLicense ? "Replacement for Damaged License" : "Replacement for Lost License";
        }
        
        private bool _IsLicenseValidForReplace()
        {
            // should be Active and Not expired

            if (!_SelectedLicense.IsActive)
            {
                MessageBox.Show($"Selected License is not Active! you can not Issue a replacement for this License", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (_SelectedLicense.ExpirationDate < DateTime.Now)
            {
                MessageBox.Show($"Selected License is expired!, you can not Issue a replacement for this License: {_SelectedLicense.ExpirationDate}", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnReplaceLicense_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you to want to Issue a Replacement for the License?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                _NewLicense = _SelectedLicense.Replace(ReplaceReason, clsGlobal.CurrentUser.UserID);

                if (_NewLicense == null)
                {
                    MessageBox.Show("Faild to Replace the License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ctrlDriverLicenseInfoWithFilter1.LoadLicenseInfo(_SelectedLicense.LicenseID);
                ctrlDriverLicenseInfoWithFilter1.gbLicenseFilter.Enabled = false;
                ctrlReplacementApplicationInfoCard1.LoadReplacementAppInfo(_NewLicense.LicenseID);
                gbReplacementFor.Enabled = false;
                btnReplaceLicense.Enabled = false;
                lnklblShowNewLicenseInfo.Enabled = true;

                MessageBox.Show($"License Replaced Successfuly with ID = {_NewLicense.LicenseID}", "License Replaced", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lnklblShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _frm = new frmShowLicenseDetails(_NewLicense.LicenseID);
            _frm.ShowDialog();
        }

        private void lnklblShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _frm = new frmShowPersonLicenseHistory(_SelectedLicense.DriverInfo.PersonInfo.NationalNo);
            _frm.ShowDialog();

            ctrlReplacementApplicationInfoCard1.LoadReplacementAppInfo(_SelectedLicenseID);
        }

        private void btnExitReplacemenLicenseApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}

