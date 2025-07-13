using System;
using System.Windows.Forms;

namespace DVLD_Mery
{
    public partial class frmShowLicenseDetails : Form
    {
        int _LicenseID = -1;

        public frmShowLicenseDetails(int LicenseID)
        {
            InitializeComponent();

            _LicenseID = LicenseID;
        }

        private void frmShowLicenseDetails_Load(object sender, EventArgs e)
        {
            ctrlDriverLicenseCard1.LoadLicenseInfo(_LicenseID);
        }

        private void btnCloseIssueDrivingLicense_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
