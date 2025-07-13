using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Mery_Buisness;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DVLD_Mery
{
    public partial class frmLogin : Form
    {
        int _Trials = 3;  string RemembermeUserInfoFilePath;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            lblLoggingInLoad.Visible = false;

            string Username ="", Password = "";

            if (clsGlobal.GetStoredCredential(ref Username, ref Password))
            {
                txtUsername.Text = Username;
                txtPassword.Text = Password;
                chkRememberMe.Checked = true;
            }
        }

        public delegate void LoggingInEventHandler(clsUser User);

        static public event LoggingInEventHandler LoggedIn;

         private async Task _LoadAccountUI()
         {
             lblLoggingInLoad.Visible = true;
             await Task.Delay(200);
             lblLoggingInLoad.Text = "Logging In.";
             await Task.Delay(200);
             lblLoggingInLoad.Text = "Logging In..";
             await Task.Delay(200);
             lblLoggingInLoad.Text = "Logging In...";
             await Task.Delay(200);
             lblLoggingInLoad.Text = "Logging In.";
             await Task.Delay(200);
             lblLoggingInLoad.Text = "Logging In..";
             await Task.Delay(200);
             lblLoggingInLoad.Text = "Logging In...";

            /*LoggedIn?.Invoke(Username);
            await Task.Delay(500);*/
        }

        /* private  void _LoadAccountUI()
         {
             lblLoggingInLoad.Visible = true;
              Thread.Sleep(200);
             lblLoggingInLoad.Text = "Logging In.";
             Thread.Sleep(200);
             lblLoggingInLoad.Text = "Logging In..";
             Thread.Sleep(200);
             lblLoggingInLoad.Text = "Logging In...";
             Thread.Sleep(200);
             lblLoggingInLoad.Text = "Logging In.";
             Thread.Sleep(200);
             lblLoggingInLoad.Text = "Logging In..";
             Thread.Sleep(200);
             lblLoggingInLoad.Text = "Logging In...";
         }
 */

        private void LogUserToUserRegisterFile(clsUser User)
        {
            string FilePath = "UserLogRegister.txt";

            string logUserInfo = $"[ User: {User.Username} - UserID: {User.UserID} - PersonID: {User.PersonID} - in Date:{DateTime.Now} ] logged in.";

            using (StreamWriter writer = new StreamWriter(FilePath, append: true))
            {
                writer.WriteLine(logUserInfo);
            }
        }
      

        private void LoadLogginInResultUI(string Username)
        {
            //lblLoggingInLoad.Text = User != null ? "Success ✅" : "Failed ❎";
            //lblLoggingInLoad.Text ="Success ✅" ;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Please complete Login Info", "Information incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //taks 1 UI
            //task 2 Get user

            clsUser _User = null;

            Task<clsUser> LoadUserInfoTask = Task.Run(() => _User = clsUser.FindByUsernameAndPassword(txtUsername.Text.Trim(), clsGlobal.ComputeHash(txtPassword.Text.Trim())));
             Task LoadAccountUITask = _LoadAccountUI();

             await Task.WhenAll(LoadAccountUITask, LoadUserInfoTask);
            

            if (_User != null )
            {
                if (!_User.isActive)
                {
                    MessageBox.Show("Username is deactivated ,For more information contact User Services at policy@dvld.com", "You're account is deactivated!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                LoggedIn += LogUserToUserRegisterFile;
                LoggedIn(_User);


                if (chkRememberMe.Checked)
                    clsGlobal.RememberUsernameAndPassword(txtUsername.Text.Trim(), txtPassword.Text.Trim());
                else
                    clsGlobal.RememberUsernameAndPassword("", "");

                clsGlobal.CurrentUser = _User;

                Form frm = new frmMain();
                frm.ShowDialog();

                this.Close();
            }
            else
            {
                _Trials--;

                txtUsername.Focus();
                lblLoginFailed.Visible = true;
                lblLoginFailed.Text = $"Invalid Username Or Password!\nYou have only {_Trials} Trial(s) before lock your account!";
                errpLogin.SetError(txtUsername, "Try again!");
                errpLogin.SetError(txtPassword, "Try again!");
                txtUsername.Text = "";
                txtPassword.Text = "";


                if (_Trials == 0)
                {
                    MessageBox.Show("Your Account is Locked after 3 failed trials to login!", "You're account is locked!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    clsGlobal.LogException($"This error accured due to 3 failed login attempts at \"Date: {DateTime.Now}\"", EventLogEntryType.Error);

                    this.Close();
                }

                lblLoginFailed.Visible = false;
            }

            lblLoggingInLoad.Visible = false;
        }

        private void SetError(Control control, bool condition, string errorMessage)
        {
            if (condition)
                errpLogin.SetError(control, errorMessage);
            else
                errpLogin.SetError(control, "");
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            SetError(txtUsername, string.IsNullOrEmpty(txtUsername.Text), "Username is required!");
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            SetError(txtPassword, string.IsNullOrEmpty(txtPassword.Text), "Password is required!");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to leave!", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                this.Close();
        }

    }
}
