using DVLD_Mery_Buisness;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DVLD_Mery
{
    public partial class frmChangeUserPassword : Form
    {
        clsUser _User; int _UserID = -1;

        public frmChangeUserPassword(int UserID)
        {
            InitializeComponent();

            _UserID = UserID;
        }

        private void frmChangeUserPassword_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();
        }

        private void _ResetDefualtValues()
        {
            txtCurrentPassword.Focus();

            _User = clsUser.FindByID(_UserID);

            if (_User != null)
                ctrlUserCard1.LoadUserInfo(_User.UserID);
            else
            {
                MessageBox.Show("The Form Will be Closed Because User Not Found", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
        }

        private bool _ValidateInput()
        {
            if (string.IsNullOrEmpty(txtCurrentPassword.Text) || txtCurrentPassword.Text != _User.Password || string.IsNullOrEmpty(txtNewPassword.Text) ||
               string.IsNullOrEmpty(txtConfirmNewPassword.Text) || txtConfirmNewPassword.Text != txtNewPassword.Text)
             
                if (this.ValidateChildren())
                    return false;

            return true;
        }

        private void btnSaveUserChangePassword_Click(object sender, EventArgs e)
        {
           if(!_ValidateInput())
            {
                MessageBox.Show("Some fields are not valid, hover on the red icon to see the error!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(_User.ChangePassword(txtNewPassword.Text))
                MessageBox.Show("Password Changed Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("An Erro Occured, Password Saved Failed", "Not Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private bool SetError(Control control, bool condition, string errorMessage)
        {
            if (condition)
            {
                errorpChangePassword.SetError(control, errorMessage);
                return true;
            }
            else
            {
                errorpChangePassword.SetError(control, "");
                return false;
            }
        }

        private void txtCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            if(!SetError(txtCurrentPassword, txtCurrentPassword.Text.Trim() != _User.Password, "Wrong Password!"))
                SetError(txtNewPassword, string.IsNullOrEmpty(txtNewPassword.Text), "Field is Required");
        }

        private void txtNewPassword_Validating(object sender, CancelEventArgs e)
        {
            SetError(txtNewPassword, string.IsNullOrEmpty(txtNewPassword.Text), "Field is Required");
        }

        private void txtConfirmNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if(!SetError(txtConfirmNewPassword, txtConfirmNewPassword.Text.Trim() != txtNewPassword.Text.Trim(), "Password not match!"))
                SetError(txtConfirmNewPassword, string.IsNullOrEmpty(txtConfirmNewPassword.Text), "Field is Required");
        }

        private void btnExitUserChangePassword_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
