using DVLD_Mery_Buisness;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DVLD_Mery
{
    public partial class ctrlDriverLicenseInfoWithFilter : UserControl
    {
        public class LicenseSelectedEventsArgs : EventArgs
        {
            public int LicenseID { get; set; }

            public LicenseSelectedEventsArgs (int LicenseID)
            {
                this.LicenseID = LicenseID;
            }
        }

        public event EventHandler<LicenseSelectedEventsArgs> OnLicenseSelected;

        protected virtual void RaiseOnLicenseSelected(LicenseSelectedEventsArgs e)
        {
            OnLicenseSelected?.Invoke(this, e);
        }

        int _LicenseID = -1;

        public clsLicense SelectedLicenseInfo
        { get { return ctrlDriverLicenseCard1.SelectedLicenseInfo; } }

        public ctrlDriverLicenseInfoWithFilter()
        {
            InitializeComponent();
        }

        private void ctrlDriverLicenseInfoWithFilter_Load(object sender, EventArgs e)
        {
            txtLicenseToSelect.Focus();
        }

        private void txtLicenseToSelect_TextChanged(object sender, EventArgs e)
        {
            btnSearchLicense.Enabled = (txtLicenseToSelect.Text != "");
        }

        public void LoadLicenseInfo(int LicenseID)
        {
            _LicenseID = LicenseID;
            ctrlDriverLicenseCard1.LoadLicenseInfo(_LicenseID);
        }

        public void LoadLicenseInfoAndRaiseEvent(int LicenseID)
        {
            _LicenseID = LicenseID;
            ctrlDriverLicenseCard1.LoadLicenseInfo(_LicenseID);
            txtLicenseToSelect.Text = _LicenseID.ToString();
             _RaiseOnLicenseSelectedEvent();
        }

        private bool _ValidateInput()
        {
            if (string.IsNullOrEmpty(txtLicenseToSelect.Text))
                if (this.ValidateChildren())
                    return false;

            return true;
        }

        private void btnSearchLicense_Click(object sender, EventArgs e)
        {
            if (!_ValidateInput())
            {
                MessageBox.Show("Enter LicenseID first to search for it!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FindNow();
        }

        private void _FindNow()
        {
            if (int.TryParse(txtLicenseToSelect.Text, out int LicenseID))
            {
                _LicenseID = LicenseID;

                ctrlDriverLicenseCard1.LoadLicenseInfo(LicenseID);
            }

            _RaiseOnLicenseSelectedEvent();

        }

        private void _RaiseOnLicenseSelectedEvent()
        {
            if (OnLicenseSelected != null)
                RaiseOnLicenseSelected(new LicenseSelectedEventsArgs(_LicenseID));
        }

        private void txtLicenseToSelect_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtLicenseToSelect.Text.Trim()))
                errorProvider1.SetError(txtLicenseToSelect, "This field is required!");
            else
                errorProvider1.SetError(txtLicenseToSelect, null);
        }

        private void txtLicenseToSelect_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            if (e.KeyChar == (char)13)
                btnSearchLicense.PerformClick();
        }
    }
}
