using System;
using System.Windows.Forms;

namespace DVLD_Mery
{
    public partial class frmShowLDLAppDetails : Form
    {
        int _LDLAppID = -1;
        public frmShowLDLAppDetails(int LDLAppID)
        {
            _LDLAppID = LDLAppID;

            InitializeComponent();
        }
        private void frmShowLDLAppDetails_Load(object sender, EventArgs e)
        {
            ctrlLDLAppCard1.LoadLDLAppInfo(_LDLAppID);
        }

        private void btnExitLDLAppDetailsCard_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
