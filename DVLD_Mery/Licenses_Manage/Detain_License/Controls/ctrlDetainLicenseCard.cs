using DVLD_Mery.Global_Classes;
using DVLD_Mery_Buisness;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DVLD_Mery
{
    public partial class ctrlDetainLicenseCard : UserControl
    {
        public ctrlDetainLicenseCard()
        {
            InitializeComponent();
        }

        private void ctrlDetainLicenseInfo_Load(object sender, EventArgs e)
        {
            lblDetainDate.Text = clsFormat.DateToShort(DateTime.Now);
            lblCreatedBy.Text = clsGlobal.CurrentUser.Username;
        }

        public void LoadLicenseInfo(int LicenseID)
        {
            lblDetainedLicenseID.Text = LicenseID.ToString();
        }

        public void LoadDetainLicenseInfo(int DetainID)
        {
            clsDetainLicense Detain = clsDetainLicense.FindByID(DetainID);

            if (Detain != null)
            {
                lblDetainID.Text = DetainID.ToString();
                lblDetainDate.Text = clsFormat.DateToShort(Detain.DetainDate);
            }
            else
            {
                MessageBox.Show($"No Detaine with ID = {DetainID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("after load detain", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void txtDetainFineFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtDetainFineFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtDetainFineFees.Text.Trim()))
                errorProvider1.SetError(txtDetainFineFees, "Fees cannot be empty!");
            else
                errorProvider1.SetError(txtDetainFineFees, null);
        }
    }
}
