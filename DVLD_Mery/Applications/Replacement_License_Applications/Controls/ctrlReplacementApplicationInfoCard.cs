using DVLD_Mery.Global_Classes;
using DVLD_Mery_Buisness;
using System;
using System.Windows.Forms;

namespace DVLD_Mery
{
    public partial class ctrlReplacementApplicationInfoCard : UserControl
    {
        public ctrlReplacementApplicationInfoCard()
        {
            InitializeComponent();
        }

        private void ctrlReplacementApplicationInfoCard_Load(object sender, EventArgs e)
        {
            lblReplacementLAppDate.Text = DateTime.Now.ToShortDateString();
            lblCreatedBy.Text = clsGlobal.CurrentUser.Username;
        }

        public void LoadOldLicenseInfo(int LicenseID)
        {
            lblOldLicenseID.Text = LicenseID.ToString();
        }

        public void LoadReplacementAppInfo(int ReplacementLicenseID)
        {
            clsLicense ReplacementLicense = clsLicense.Find(ReplacementLicenseID);

            if (ReplacementLicense != null)
            {
                    lblReplacementLAppID.Text = ReplacementLicense.ApplicationInfo.ApplicationID.ToString();
                    lblRLAppFees.Text = ReplacementLicense.ApplicationInfo.PaidFees.ToString();
                    lblReplacementLicenseID.Text = ReplacementLicense.LicenseID.ToString();

                    lblReplacementLAppDate.Text = clsFormat.DateToShort(ReplacementLicense.ApplicationInfo.ApplicationDate);
            }
            else
                MessageBox.Show("License Not Found");
            }
    }
}
