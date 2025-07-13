using DVLD_Mery_Buisness;
using System;
using System.Windows.Forms;

namespace DVLD_Mery
{
    public partial class frmRenewLocalDrivingLicense : Form
    {
        int _SelectedLicenseID = -1;
        clsLicense _SelectedLicense; clsLicense _NewLicense;

        Form _frm;

        public frmRenewLocalDrivingLicense()
        {
            InitializeComponent();
        }

        private void frmRenewLocalDrivingLicense_Load(object sender, EventArgs e)
        {
            ctrlRenewLicenseApplicationCard1.txtRenewedLicenseNotes.Focus();

            btnRenewLicense.Enabled = false;
            lnklblNewShowLicenseInfo.Enabled = false;
            lnklblShowLicenseHistory.Enabled = false;
        }

        private void ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected(object sender, ctrlDriverLicenseInfoWithFilter.LicenseSelectedEventsArgs e)
        {
            _SelectedLicenseID = e.LicenseID;
            _SelectedLicense = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo;

            if (_SelectedLicense == null)
            {
                btnRenewLicense.Enabled = false;
                return;
            }

            if (_IsLicenseValidForRenew())
            {
                btnRenewLicense.Enabled = true;

                ctrlRenewLicenseApplicationCard1.Enabled = true;
                ctrlRenewLicenseApplicationCard1.LoadOldLicensepInfo(_SelectedLicense);
            }
            else
            {
                btnRenewLicense.Enabled = false;

                ctrlRenewLicenseApplicationCard1.Enabled = false;
            }

            lnklblShowLicenseHistory.Enabled = true;
        }


        private bool _IsLicenseValidForRenew()
        {
            // To be valid should be Active and Expired

            if (_SelectedLicense.ExpirationDate > DateTime.Now)
            {
                MessageBox.Show($"Selected License is not yet expired!, It will expired on: {_SelectedLicense.ExpirationDate}", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!_SelectedLicense.IsActive)
            {
                MessageBox.Show($"Selected License is not Active! you can not renew it", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool _IsPersonHasAnotherValidLicense()
        {
            int ActiveLicenseID = clsLicense.IsPersonHasActiveLicense(_SelectedLicense.DriverInfo.PersonInfo.PersonID, _SelectedLicense.LicenseClassID);

            if (ActiveLicenseID != -1)
            {
                ctrlRenewLicenseApplicationCard1.Enabled = false;
                btnRenewLicense.Enabled = false;
                lnklblNewShowLicenseInfo.Enabled = true;

                _SelectedLicenseID = ActiveLicenseID;

                ctrlDriverLicenseInfoWithFilter1.LoadLicenseInfo(_SelectedLicenseID);
                MessageBox.Show($"You Can't Renew This license because another Active and Non Expired License Found for Person with ID {_SelectedLicense.DriverInfo.PersonInfo.PersonID}, with the Same License Class which is License with ID ={ActiveLicenseID}!", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return true;
            }
            return false;
        }

        private void btnRenewLicense_Click(object sender, EventArgs e)
        {
            // Expired and Active ✔️ >>search for another license that is Active and Not Expired >> so he can't
            if (_IsPersonHasAnotherValidLicense())
                return;

            if (MessageBox.Show("Are you sure you to Renew this License?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                _NewLicense = _SelectedLicense.RenewLicense(ctrlRenewLicenseApplicationCard1.RenewedLicenseNotes, clsGlobal.CurrentUser.UserID);

                if (_NewLicense == null)
                {
                    MessageBox.Show("Faild to Renew the License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ctrlDriverLicenseInfoWithFilter1.LoadLicenseInfo(_SelectedLicense.LicenseID);
                ctrlDriverLicenseInfoWithFilter1.gbLicenseFilter.Enabled = false;
                ctrlRenewLicenseApplicationCard1.LoadRenewLicenseInfo(_NewLicense.LicenseID);
                ctrlRenewLicenseApplicationCard1.txtRenewedLicenseNotes.Enabled = false;
                btnRenewLicense.Enabled = false;
                lnklblNewShowLicenseInfo.Enabled = true;

                MessageBox.Show($"License Renewed Successfuly with ID = {_NewLicense.LicenseID}", "License Renewd", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            ctrlDriverLicenseInfoWithFilter1.LoadLicenseInfo(_SelectedLicense.LicenseID);
        }
       
        private void btnExitRenewLDLicense_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
