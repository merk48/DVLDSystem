using DVLD_Mery.Global_Classes;
using DVLD_Mery_Buisness;
using System;
using System.Windows.Forms;

namespace DVLD_Mery
{
    public partial class ctrlRenewLicenseApplicationCard : UserControl
    {
        public string RenewedLicenseNotes { get {return txtRenewedLicenseNotes.Text.Trim(); } }

        public ctrlRenewLicenseApplicationCard()
        {
            InitializeComponent();
        }

        private void ctrlApplicationNewLicenseInfo_Load(object sender, EventArgs e)
        {
            lblRLAppDate.Text = DateTime.Now.ToString();
            lblRenewedLicenseIssueDate.Text = DateTime.Now.ToString();
            lblCreatedBy.Text = clsGlobal.CurrentUser.Username;
            lblRenewedLicenseExpirationDate.Text = DateTime.Now.ToString();
        }

        public void LoadOldLicensepInfo(clsLicense OldLicense)
        {
            lblOldLicenseID.Text = OldLicense.LicenseID.ToString();
            lblLicenseFees.Text = OldLicense.PaidFees.ToString();
            decimal RenewAppPaidFees = clsApplicationType.GetApplicationTypeFee(clsApplicationType.enApplicationType.RenewDrivingLicense);
            lblRLAppFees.Text = RenewAppPaidFees.ToString();
            lblTotalFees.Text = (OldLicense.PaidFees + RenewAppPaidFees).ToString();
        }

        public void LoadRenewLicenseInfo(int RenwedLicenseID)
        {
            clsLicense RenewedLicense = clsLicense.Find(RenwedLicenseID);

            if (RenewedLicense != null)
            {
                lblRLAppID.Text = RenewedLicense.ApplicationID.ToString();
                lblRLAppDate.Text = RenewedLicense.ApplicationInfo.ApplicationDate.ToString();
                lblRenewedLicenseID.Text = RenewedLicense.LicenseID.ToString();
                lblRenewedLicenseExpirationDate.Text = clsFormat.DateToShort(RenewedLicense.ExpirationDate);
                lblTotalFees.Text = (RenewedLicense.ApplicationInfo.PaidFees + RenewedLicense.PaidFees).ToString();

                // the exact time just for UI
                lblRenewedLicenseIssueDate.Text = RenewedLicense.IssueDate.ToString();
                lblRLAppFees.Text = RenewedLicense.ApplicationInfo.PaidFees.ToString();
                lblCreatedBy.Text = RenewedLicense.CreatedByUserInfo.Username;
                lblRenewedLicenseExpirationDate.Text = RenewedLicense.ExpirationDate.ToString();
            }
            else
            {
                MessageBox.Show($"No License with ID = {RenwedLicenseID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
