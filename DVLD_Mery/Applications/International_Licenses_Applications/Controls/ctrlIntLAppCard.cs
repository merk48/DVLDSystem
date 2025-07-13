using DVLD_Mery.Global_Classes;
using DVLD_Mery_Buisness;
using System;
using System.Windows.Forms;

namespace DVLD_Mery
{
    public partial class ctrlIntLAppCard : UserControl
    {
        public ctrlIntLAppCard()
        {
            InitializeComponent();
        }

        private void ctrlIntLAppCard_Load(object sender, EventArgs e)
        {
            lblAppDate.Text = DateTime.Now.ToString();
            lblAppIssueDate.Text = DateTime.Now.ToString();
            lblAppExpirationDate.Text = DateTime.Now.AddYears(1).ToString(); // ???
            lblAppFees.Text = clsApplicationType.GetApplicationTypeFee(clsApplicationType.enApplicationType.NewInternationalLicense).ToString();
            lblAppCreatedBy.Text = clsGlobal.CurrentUser.Username;
        }

        public void LoadLiceneseID(int LiceneseID)
        {
            lblLicenseID.Text = LiceneseID.ToString();
        }

        public void LoadIntAppInfo(clsInternationalLicense IntLicense)
        {
            if (IntLicense != null)
            {
                lblIntLApplicationID.Text = IntLicense.ApplicationID.ToString();
                lblIntLicenseID.Text = IntLicense.InternationalLicenseID.ToString();
                lblAppDate.Text = clsFormat.DateToShort(IntLicense.ApplicationDate);
                lblAppIssueDate.Text = clsFormat.DateToShort(IntLicense.IssueDate);
                lblAppExpirationDate.Text = clsFormat.DateToShort(IntLicense.ExpirationDate);
            }
            else
            {
                MessageBox.Show("International License Not Found!", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
        }
      
    }
}
