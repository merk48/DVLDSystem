using DVLD_Mery_Buisness;
using System.Windows.Forms;

namespace DVLD_Mery
{
    public partial class ctrlApplicationBasicInfoCard : UserControl
    {
        clsApplication _App;

        clsApplication.enApplicationStatus mery { get; set; }

        public ctrlApplicationBasicInfoCard()
        {
            InitializeComponent();
        }

        public void LoadApplicationInfo(int AppID)
        {
             _App = clsApplication.Find(AppID);
            if (_App != null)
            {
                lblAppID.Text = _App.ApplicationID.ToString();
                lblAppStatus.Text = _App.ApplicationStatus == clsApplication.enApplicationStatus.New ? "New" : _App.ApplicationStatus == clsApplication.enApplicationStatus.Cancelled ? "Cancelled" : "Completed";
                lblApplicantName.Text = clsPerson.Find(_App.ApplicantPersonID).FullName;
                lblAppFees.Text = _App.PaidFees.ToString();
                lblAppType.Text = clsApplicationType.GetApplicationTypeTitle(_App.ApplicationTypeID);
                lblAppDate.Text = _App.ApplicationDate.ToString();
                lblAppStatusDate.Text = _App.LastStatusDate.ToString();
                lblAppCreatedBy.Text = _App.CreatedByUserID.ToString();
            }
            else
                MessageBox.Show("Not found");
        }

        public void ResetApplcationInfo()
        {
            lblAppID.Text = "[???]";
            lblAppStatus.Text = "[???]";
            lblApplicantName.Text = "[???]";
            lblAppFees.Text = "[$$$]";
            lblAppType.Text = "[???]";
            lblAppDate.Text = "[???]";
            lblAppStatusDate.Text = "[???]";
            lblAppCreatedBy.Text = "[???]";

        }
        private void lnklblViewPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonDetails frm = new frmShowPersonDetails(_App.ApplicantPersonID);
            frm.ShowDialog();

            LoadApplicationInfo(_App.ApplicationID);
        }
    }
}
