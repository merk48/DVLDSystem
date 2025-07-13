using DVLD_Mery_Buisness;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DVLD_Mery
{
    public partial class frmAddEditNewUser : Form
    {
        enum enMode { AddNew, Update }
        enMode _Mode = enMode.AddNew;

        int _UserID = -1; clsUser _User; int _PersonID = -1;

        public frmAddEditNewUser()
        {
            InitializeComponent();

            _Mode = enMode.AddNew;
        }

        public frmAddEditNewUser(int UserID)
        {
            InitializeComponent();

            _UserID = UserID;
           _Mode = enMode.Update;
        }

        private void frmAddNewUser_Load(object sender, EventArgs e)
        {
            _SetMode();
        }

        private void _SetMode()
        {
            if (_Mode == enMode.AddNew)
                _AppNewUser();
            else
                _UpdateUser();
        }

        private void _AppNewUser()
        {
            lblUserCardTitle.Text = "Add New User";
            this.Text = "Add New User";
            lblUserID.Text = "???";
            btnSaveAddNewUser.Enabled = false;

            ctrlPersonCardWithFilter1.txtPeopleFilterToSelect.Focus();

            _User = new clsUser();
        }

        private void _UpdateUser()
        {
            lblUserCardTitle.Text = "Update User";
            this.Text = "Update User";
            btnSaveAddNewUser.Enabled = true;

            ctrlPersonCardWithFilter1.gbPersonFilter.Enabled = false;

            _User = clsUser.FindByID(_UserID);

            _LoadData();
        }

        private void _LoadData()
        {
            if (_User != null)
            {
                lblUserID.Text = _User.UserID.ToString();
                txtUsername.Text = _User.Username;
                txtUserPassword.Text = _User.Password;
                txtUserConfirmPassword.Text = _User.Password;
                chcUserIsActive.Checked = _User.isActive;

                ctrlPersonCardWithFilter1.LoadPersonInfo(_User.PersonID);
                ctrlPersonCardWithFilter1.txtPeopleFilterToSelect.Text = _User.PersonInfo.NationalNo;
            }
            else
            {
                MessageBox.Show("The Form Will be Closed Because User Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
        }

        private bool _ValidateInput()
        {
            if (string.IsNullOrEmpty(txtUserPassword.Text) || string.IsNullOrEmpty(txtUserConfirmPassword.Text) || (_Mode == enMode.AddNew && clsUser.IsUserExistsByUsername(txtUsername.Text)))
                if (this.ValidateChildren())
                    return false;
            
            return true;
        }

        private void btnSaveAddNewUser_Click(object sender, EventArgs e)
        {
          if(!_ValidateInput())
            {
                MessageBox.Show("Some fields are not valid, hover on the red icon to see the error!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        
            _User.PersonID = _PersonID; 
            _User.Username = txtUsername.Text.Trim();
            _User.Password = txtUserPassword.Text.Trim();
            _User.isActive = chcUserIsActive.Checked;

            if(_User.Save())
            {
                MessageBox.Show("Data Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _Mode = enMode.Update;

                _UserID = _User.UserID;
                _UpdateUser();
            }
            else
                MessageBox.Show("Data Saved Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool _CheckAndNavigateToNextTab()
        {
            if (_PersonID == -1)
            {
                MessageBox.Show("Select a person then try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (clsUser.IsUserExistsByPersonID(_PersonID))
            {
                MessageBox.Show("Selected person already has a user, try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.AddNew)
                if (_CheckAndNavigateToNextTab())
                {
                    tcUserInfo.SelectedIndex = 1;
                    btnSaveAddNewUser.Enabled = true;
                }
                else
                    btnSaveAddNewUser.Enabled = false;
            else
                tcUserInfo.SelectedIndex = 1;
        }

        private void tcUserInfo_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (_Mode == enMode.AddNew)
            {
                if (e.TabPageIndex == 1)
                {
                    bool Navigate = _CheckAndNavigateToNextTab();

                    tcUserInfo.SelectedIndex = Navigate ? 1 : 0;
                    btnSaveAddNewUser.Enabled = Navigate ? true : false;
                }
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            tcUserInfo.SelectedIndex -= 1;
        }

        private void SetError(Control control, bool condition, string errorMessage)
        {
            if (condition)
                errpAddNewUserCard.SetError(control, errorMessage);
            else
                errpAddNewUserCard.SetError(control, "");
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            SetError(txtUsername, string.IsNullOrEmpty(txtUsername.Text), "Field is required!");
            if (_Mode == enMode.AddNew)
                SetError(txtUsername, clsUser.IsUserExistsByUsername(txtUsername.Text), "Username is not available!");
        }

        private void txtUserPassword_Validating(object sender, CancelEventArgs e)
        {
            SetError(txtUserPassword, string.IsNullOrEmpty(txtUserPassword.Text), "Field is required");
        }

        private void txtUserConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            SetError(txtUserConfirmPassword, string.IsNullOrEmpty(txtUserConfirmPassword.Text), "Field is required");
            SetError(txtUserConfirmPassword, txtUserConfirmPassword.Text != txtUserPassword.Text, "Password not match!");
        }

        private void btnCancelAddNewUser_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrlPersonCardWithFilter1_OnPersonSelected(object sender, ctrlPersonCardWithFilter.PersonSelectedEventsArgs e)
        {
            _PersonID = e.PersonID;
        }

    }
}
