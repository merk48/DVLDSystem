using System;
using System.Windows.Forms;

namespace DVLD_Mery
{
    public partial class frmShowInternatioanlLicenseDetails : Form
    {
        int _IntLAppID = -1;
        public frmShowInternatioanlLicenseDetails(int IntLAppID)
        {
            InitializeComponent();
            _IntLAppID = IntLAppID;
        }

        private void frmShowInternatioanlLicenseDetails_Load(object sender, EventArgs e)
        {
            ctrlDriverInternationalLicenseCard1.LoadLicenseInfo(_IntLAppID);
        }

        private void btnExitIntLAppDetailsCard_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
