using DVLD_Mery_Buisness;
using System;
using System.Windows.Forms;

namespace DVLD_Mery
{
    public partial class frmDetainLicense : Form
    {
        int _DetainID = -1;
        clsLicense _SelectedLicense;

        public frmDetainLicense()
        {
            InitializeComponent();
        }

        private void frmDetainLicense_Load(object sender, EventArgs e)
        {
            btnDetainLicense.Enabled = false;
            lnklblShowLicenseHistory.Enabled = false;
        }

        private void ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected(object sender, ctrlDriverLicenseInfoWithFilter.LicenseSelectedEventsArgs e)
        {
            int _SelectedLicenseID = e.LicenseID;

            _SelectedLicense = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo;

            if (_SelectedLicense == null)
            {
                btnDetainLicense.Enabled = false;
                return;
            }


            if (_IsLicenseValidForDetain())
            {
                btnDetainLicense.Enabled = true;

                ctrlDetainLicenseInfo1.Enabled = true;

                ctrlDetainLicenseInfo1.LoadLicenseInfo(_SelectedLicense.LicenseID);
            }
            else
            {
                btnDetainLicense.Enabled = false;

                ctrlDetainLicenseInfo1.Enabled = false;
            }

            lnklblShowLicenseHistory.Enabled = true;
        }

        private bool _IsLicenseValidForDetain()
        {
            if (_SelectedLicense.IsDetained)
            {
                MessageBox.Show($"Selected License is alreaedy detained!", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!_SelectedLicense.IsActive)
             {
                 MessageBox.Show($"Selected License is not Active! you can not Detain this License", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return false;
             }
            /*  if (_License.ExpirationDate < DateTime.Now)
              {
                  MessageBox.Show($"Selected License is expired!, you can not Detain this License: {_License.ExpirationDate}", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  return false;
              }
 */
            return true;
        }

        private void btnDetainLicense_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ctrlDetainLicenseInfo1.txtDetainFineFees.Text))
                if (this.ValidateChildren())
                {
                    MessageBox.Show("Enter Paid Fees Ammount first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            if (MessageBox.Show("Are you sure you to want to detain this License?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                _DetainID =  _SelectedLicense.Detain(Convert.ToDecimal(ctrlDetainLicenseInfo1.txtDetainFineFees.Text), clsGlobal.CurrentUser.UserID);

                if (_DetainID == -1)
                {
                    MessageBox.Show("Faild to Detain License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("after detain _DetainID: " + _DetainID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("after detain LicenseID: " + clsDetainLicense.FindByID(_DetainID).LicenseID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                btnDetainLicense.Enabled = false;
                ctrlDriverLicenseInfoWithFilter1.LoadLicenseInfo(_SelectedLicense.LicenseID);
                ctrlDriverLicenseInfoWithFilter1.gbLicenseFilter.Enabled = false;
                ctrlDetainLicenseInfo1.LoadDetainLicenseInfo(_DetainID);

                MessageBox.Show($"License Detained Successfuly with ID = {_SelectedLicense.LicenseID}", "License Detained", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lnklblShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonLicenseHistory _frm = new frmShowPersonLicenseHistory(_SelectedLicense.DriverInfo.PersonInfo.NationalNo);
            _frm.ShowDialog();
        }

        private void btnExitDetainLicenseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
