using DVLD_Mery_Buisness;
using System;
using System.Windows.Forms;

namespace DVLD_Mery
{
    public partial class frmReleaseDetainedLicense : Form
    {
        int _SelectedLicenseID = -1;
        clsLicense _SelectedLicense; clsDetainLicense _Detain;

        public frmReleaseDetainedLicense()
        {
            InitializeComponent();
        }

        public frmReleaseDetainedLicense(int LicenseID)
        {
            InitializeComponent();

            _SelectedLicenseID = LicenseID;
            ctrlDriverLicenseInfoWithFilter1.LoadLicenseInfoAndRaiseEvent(LicenseID);
            ctrlDriverLicenseInfoWithFilter1.gbLicenseFilter.Enabled = false;
        }

        private void frmReleaseDetainedLicense_Load(object sender, EventArgs e)
        {
           if(_SelectedLicenseID == -1)
            {
                btnReleaseDetainedLicense.Enabled = false;
                lnklblShowLicenseHistory.Enabled = false;
            }
        }
        private void ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected(object sender, ctrlDriverLicenseInfoWithFilter.LicenseSelectedEventsArgs e)
        {
            _SelectedLicenseID = e.LicenseID;

            _SelectedLicense = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo;

            if (_SelectedLicense == null)
            {
                btnReleaseDetainedLicense.Enabled = false;
                return;
            }

            if (_IsLicenseValidForRelease())
            {
                btnReleaseDetainedLicense.Enabled = true;

                ctrlReleaseDetainedLicenseApplicationInfo1.Enabled = true;

                ctrlReleaseDetainedLicenseApplicationInfo1.LoadDetainInfo(_SelectedLicense.DetainInfo);
            }
            else
            {
                btnReleaseDetainedLicense.Enabled = false;

                ctrlReleaseDetainedLicenseApplicationInfo1.Enabled = false;
            }

            lnklblShowLicenseHistory.Enabled = true;
        }
       

        private bool _IsLicenseValidForRelease()
        {
            if (!_SelectedLicense.IsDetained)
            {
                MessageBox.Show($"Selected License is not detained! you can not Release a not detained License", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (_SelectedLicense.IsActive)
            {
                MessageBox.Show($"Selected License is Active! you can not Release a not detained License", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            /* if (_License.ExpirationDate < DateTime.Now)
             {
                 MessageBox.Show($"Selected License is expired!, you can not Issue a replacement for this License: {_License.ExpirationDate}", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return false;
             }*/

            return true;
        }

        private void btnReleaseDetainedLicense_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you to want to release this detained License?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                int ApplicationID = -1;

                bool IsReleased = _SelectedLicense.ReleaseDetainedLicense(clsGlobal.CurrentUser.UserID,ref ApplicationID);

                if (!IsReleased)
                {
                    MessageBox.Show("Faild to to release the Detain License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ctrlDriverLicenseInfoWithFilter1.LoadLicenseInfo(_SelectedLicense.LicenseID);
                ctrlDriverLicenseInfoWithFilter1.gbLicenseFilter.Enabled = false;
                ctrlReleaseDetainedLicenseApplicationInfo1.LoadReleaseDetainedLicenseAppInfo(ApplicationID);
                btnReleaseDetainedLicense.Enabled = false;
                lnklblShowLicenseHistory.Enabled = true;

                MessageBox.Show($"License released Successfuly with ID = {_SelectedLicense.LicenseID}", "License Released", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lnklblShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonLicenseHistory _frm = new frmShowPersonLicenseHistory(_SelectedLicense.DriverInfo.PersonInfo.NationalNo);
            _frm.ShowDialog();
        }

        private void btnExitReleaseDetainedLicenseApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    
    }
}
