using DVLD_Mery.DriversManagement;
using System;
using System.Windows.Forms;

namespace DVLD_Mery
{
    public partial class frmMain : Form
    {
        Form _frm;
        
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMainMenue_Load(object sender, EventArgs e)
        {
            lblCurrentUser.Text = clsGlobal.CurrentUser.Username;
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frm = new frmManagePeople();
            _frm.ShowDialog();
        }

        private void usersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _frm = new frmManageUsers();
            _frm.ShowDialog();
        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frm = new frmUserDetails(clsGlobal.CurrentUser.UserID);
            _frm.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frm = new frmChangeUserPassword(clsGlobal.CurrentUser.UserID);
            _frm.ShowDialog();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentUser = null;

            this.Close();

            this.Hide();

            _frm = new frmLogin();
            _frm.ShowDialog();
        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frm = new frmManageDrivers();
            _frm.ShowDialog();
        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frm = new frmAddEditLocalDrivingLicenseApplication();
            _frm.ShowDialog();
        }

        private void internationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frm = new frmAddEdiInternationalDrivingLicenseApplication();
            _frm.ShowDialog();
        }

        private void renewDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frm = new frmRenewLocalDrivingLicense();
            _frm.ShowDialog();
        }

        private void replecementForLostOrDamagedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frm = new frmReplaceLicenseForLostOrDamagedLicense();
            _frm.ShowDialog();
        }

        private void releaseDetainedDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frm = new frmReleaseDetainedLicense();
            _frm.ShowDialog();
        }

        private void retakeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frm = new frmManageLocalLicenseApplications();
            _frm.ShowDialog();
        }

        private void ManageLocalLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frm = new frmManageLocalLicenseApplications();
            _frm.ShowDialog();
        }

        private void ManageInternationalLicenseApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frm = new frmManageInternationalLicenseApplications();
            _frm.ShowDialog();
        }

        private void manageDetainedLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frm = new frmManageDetainedlLicenseApplications();
            _frm.ShowDialog();
        }

        private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frm = new frmDetainLicense();
            _frm.ShowDialog();
        }

        private void realesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frm = new frmReleaseDetainedLicense();
            _frm.ShowDialog();
        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frm = new frmManageApplicationTypes();
            _frm.ShowDialog();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frm = new frmManageTestTypes();
            _frm.ShowDialog();
        }

        private void btnCloseMainMenue_Click(object sender, EventArgs e)
        {
            this.Close();
            clsGlobal.CurrentUser = null;
        }
    }
}
