using DVLD_Mery_Buisness;
using System.Windows.Forms;

namespace DVLD_Mery
{
    public partial class ctrlUserCard : UserControl
    {
        int _UserID = -1; clsUser _User;

        // check if needed
        public int UserID {get{return _UserID;} }

        public ctrlUserCard()
        {
            InitializeComponent();
        }

        public void LoadUserInfo(int UserID)
        {
            _UserID =UserID;
            _User = clsUser.FindByID(UserID);

            if (_User == null)
            {
                _ResetPersonInfo();
                MessageBox.Show("No User with UserID = " + UserID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillUserInfo();
        }

        private void _FillUserInfo()
        {
            ctrlPersonCard1.LoadPersonInfo(_User.PersonID);
            lblUserID.Text = _User.UserID.ToString();
            lblUsername.Text = _User.Username;
            lblIsActive.Text = _User.isActive ? "Yes" : "No";
        }

        private void _ResetPersonInfo()
        {
            ctrlPersonCard1.ResetPersonInfo();
            lblUserID.Text = "[???]";
            lblUsername.Text = "[???]";
            lblIsActive.Text = "[???]";
        }

    }
}
