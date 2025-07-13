using DVLD_Mery_Buisness;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD_Mery
{
    public partial class frmAddEditLocalDrivingLicenseApplication : Form
    {
        enum enMode { AddNew, Update } enMode _Mode = enMode.AddNew;

        int _LDLAppID = -1; int _PersonID = -1;

        clsLocalDrivingLicenseApplication _LDLApp;

        public frmAddEditLocalDrivingLicenseApplication()
        {
            InitializeComponent();

            _Mode = enMode.AddNew;
        }

        public frmAddEditLocalDrivingLicenseApplication(int LDLAppID)
        {
            InitializeComponent();

            _LDLAppID = LDLAppID;

            _Mode = enMode.Update;
        }

        private void frmNewLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            _FillLicenseClassesInComoboBox();   

            _SetMode();
        }
       
        private void _SetMode()
        {
            if (_Mode == enMode.AddNew)
                _AddNewLDLApp();
            else
                _UpdateLDLApp();
        }

        private void _AddNewLDLApp()
        {
            lblLDLAppFormTitle.Text = "Add New Local Driving License Application";
            lblApplicationID.Text = "[???]";
            cmbLicenseClasses.SelectedIndex = cmbLicenseClasses.FindString("Class 3 - Ordinary driving license");
            lblApplicationDate.Text = DateTime.Now.ToShortDateString();
            lblApplicationFees.Text = clsApplicationType.GetApplicationTypeFee(clsApplicationType.enApplicationType.NewDrivingLicense).ToString();
            lblCreatedByUser.Text = clsGlobal.CurrentUser.Username;

            btnSaveAddNewLocalDrivingLicenseApp.Enabled = false;

            ctrlPersonCardWithFilter1.txtPeopleFilterToSelect.Focus();

            _LDLApp = new clsLocalDrivingLicenseApplication();
        }

        private void _UpdateLDLApp()
        {
            lblLDLAppFormTitle.Text = "Update New Local Driving License Application";
            btnSaveAddNewLocalDrivingLicenseApp.Enabled = true;

            ctrlPersonCardWithFilter1.gbPersonFilter.Enabled = false;

            _LDLApp = clsLocalDrivingLicenseApplication.FindByID(_LDLAppID);

            _LoadDate();
        }

        private void _LoadDate()
        {
            if (_LDLApp != null)
            {
                lblApplicationID.Text = _LDLApp.ApplicationID.ToString();
                cmbLicenseClasses.SelectedIndex = (int)_LDLApp.LicenseClassID - 1;
                lblApplicationDate.Text = _LDLApp.ApplicationDate.ToString();
                lblApplicationFees.Text = _LDLApp.PaidFees.ToString();
                lblCreatedByUser.Text = _LDLApp.CreatedByUserInfo.Username;

                ctrlPersonCardWithFilter1.LoadPersonInfo(_LDLApp.ApplicantPersonID);
                ctrlPersonCardWithFilter1.txtPeopleFilterToSelect.Text = _LDLApp.ApplicantPersonInfo.NationalNo;
            }
            else
            {
                MessageBox.Show("The Form Will be Closed Because L.D.L.Application Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
        }

        private void _FillLicenseClassesInComoboBox()
        {
            foreach (DataRow row in clsLicenseClass.GetAllLicenseClasss().Rows)
                cmbLicenseClasses.Items.Add(row["ClassName"]);
        }

        private void ctrlPersonCardWithFilter1_OnPersonSelected(int obj)
        {
            _PersonID = obj;
        }

        private bool _ValidateApp()
        {
            // check to prevent same class that is new not cancelled or completed
            int ApplicationID = clsLocalDrivingLicenseApplication.IsPersonHasActiveApplication(clsPerson.GetPersonNationalNoByID(_PersonID), cmbLicenseClasses.Text);
            if (ApplicationID != -1)
            {
                MessageBox.Show($"Choosse another License Class, The selected person already have an active application for the selected class with ID: [{ApplicationID}]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            clsLicenseClass.enLicenseClass LicenseClassID = (clsLicenseClass.enLicenseClass)(cmbLicenseClasses.SelectedIndex + 1);

            // handle if he has already a license 
            int LicenseID = clsLicense.IsPersonHasLicense(_PersonID, LicenseClassID);
            //MessageBox.Show($"LicenseID: {LicenseID}");
            if (LicenseID != -1)
            {
                MessageBox.Show($"The selected person already has a License with the same applied driving class with ID: [{LicenseID}]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            byte MinAllowedAge = clsLicenseClass.GetLicenseClassMinimumAllowedAge(LicenseClassID);
            if (MinAllowedAge > Convert.ToByte(clsPerson.GetPersonAge(_PersonID)))
            {
                MessageBox.Show($"Person is not allowed for this Driving License Class, it requires a {MinAllowedAge} years old and above", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnSaveAddNewLocalDrivingLicenseApp_Click(object sender, EventArgs e)
        {
            if(!_ValidateApp())
                return;

            _LDLApp.ApplicantPersonID = _PersonID;
            _LDLApp.ApplicationDate = DateTime.Now;
            _LDLApp.ApplicationStatus = clsApplication.enApplicationStatus.New; ;
            _LDLApp.ApplicationTypeID = clsApplicationType.enApplicationType.NewDrivingLicense;
            _LDLApp.PaidFees = clsApplicationType.GetApplicationTypeFee(clsApplicationType.enApplicationType.NewDrivingLicense);
            _LDLApp.LicenseClassID = (clsLicenseClass.enLicenseClass)(cmbLicenseClasses.SelectedIndex + 1);
            _LDLApp.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            _LDLApp.LastStatusDate = DateTime.Now;

            if (_LDLApp.Save())
                {
                    MessageBox.Show("L.D.L.Application Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _Mode = enMode.Update;

                    _LDLAppID = _LDLApp.LocalDrivingLicenseApplicationID;
                    _UpdateLDLApp();
                }
                else
                    MessageBox.Show("L.D.L.Application Saved Failed", "Not Saved", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnPreviousAddNewLocalDrivingLicenseApp_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private bool _CheckAndNavigateToNextTab()
        {
            if (_PersonID == -1)
            {
                MessageBox.Show("Select a person then try again", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnNextAddNewLocalDrivingLicenseApp_Click(object sender, EventArgs e)
        {
            if (_CheckAndNavigateToNextTab())
            {
                tabControl1.SelectedIndex = 1;
                btnSaveAddNewLocalDrivingLicenseApp.Enabled = true;
            }
            else
                btnSaveAddNewLocalDrivingLicenseApp.Enabled = false;
        }

        private void tabControl1_Selecting_1(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPageIndex == 1)
            {
                bool Navigate = _CheckAndNavigateToNextTab();

                tabControl1.SelectedIndex = Navigate ? 1 : 0;
                btnSaveAddNewLocalDrivingLicenseApp.Enabled = Navigate ? true : false;
            }
        }

        private void btnExitAddNewLocalDrivingLicenseApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

