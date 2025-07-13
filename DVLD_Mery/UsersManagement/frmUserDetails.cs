using System;
using System.Windows.Forms;

namespace DVLD_Mery
{
    public partial class frmUserDetails : Form
    {
        int _UserID;

        public frmUserDetails(int UserID)
        {
            InitializeComponent();

            _UserID = UserID;
        }

        private void frmUserDetails_Load(object sender, EventArgs e)
        {
            ctrlUserCard1.LoadUserInfo(_UserID);
        }

        private void btnExitUserDetailsCard_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
