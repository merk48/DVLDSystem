using DVLD_Mery.Global_Classes;
using DVLD_Mery_Buisness;
using System;
using System.Windows.Forms;

namespace DVLD_Mery
{
    public partial class ctrlReleaseDetainedLicenseApplicationCard : UserControl
    {
        public ctrlReleaseDetainedLicenseApplicationCard()
        {
            InitializeComponent();
        }

        private void ctrlReleaseDetainedLicenseApplicationInfo_Load(object sender, EventArgs e)
        {
            lblReleaseAppFees.Text = clsApplicationType.GetApplicationTypeFee(clsApplicationType.enApplicationType.ReleaseDetainedDrivingLicsense).ToString();
        }

        public void LoadDetainInfo(clsDetainLicense Detaine)
        {
            if (Detaine != null)
            {
                lblDetainID.Text = Detaine.DetainID.ToString();
                lblDetainDate.Text = clsFormat.DateToShort(Detaine.DetainDate);
                lblCreatedBy.Text = Detaine.CreatedByUserInfo.Username;
                lblDetainedLicenseID.Text = Detaine.LicenseID.ToString();
                lblDetainFineFees.Text = Detaine.FineFees.ToString();
                lblTotalFees.Text = (Detaine.FineFees + clsApplicationType.GetApplicationTypeFee(clsApplicationType.enApplicationType.ReleaseDetainedDrivingLicsense)).ToString();
            }
            else
            {
                MessageBox.Show("Detaine not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void LoadReleaseDetainedLicenseAppInfo(int ReleaseAppID)
        {
            lblReleaseAppID.Text = ReleaseAppID.ToString();
        }
       
    }
}
