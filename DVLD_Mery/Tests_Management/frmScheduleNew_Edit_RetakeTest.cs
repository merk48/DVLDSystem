using DVLD_Mery.Properties;
using DVLD_Mery_Buisness;
using System;
using System.Windows.Forms;

namespace DVLD_Mery
{
    public partial class frmScheduleNew_Edit_RetakeTest : Form
    {
        enum enMode { AddNew, Update } enMode _Mode = enMode.AddNew;
        enum enCreationMode { FirstTimeSchedule, RetakeTimeSchedule } enCreationMode CreationMode = enCreationMode.FirstTimeSchedule;
        int _TestAppointmentID = -1; int _LDLAppID = -1;  clsTestType.enTestType _TestTypeID = clsTestType.enTestType.VisionTest;
        clsTestAppointment _TestAppointment; clsLocalDrivingLicenseApplication _LDLApp;

        public frmScheduleNew_Edit_RetakeTest(clsTestType.enTestType TestTypeID, int LDLAppID, int TestAppointmentID = -1)
        {
            InitializeComponent();
           
            _TestAppointmentID = TestAppointmentID;
            _TestTypeID = TestTypeID;
            _LDLAppID = LDLAppID;
        }

        private void frmSheduleNew_Edit_RetakeTest_Load(object sender, EventArgs e)
        {
            _ValidateTestSetup();

            _SetMode();

            _LoadTestInfo(); // I made it in one fn because it all similar except of the date >> to achieve DRY

            if (CreationMode == enCreationMode.RetakeTimeSchedule) _RetakeUI();
        }

        private void _ValidateTestSetup()
        {
            // this time I put these lines in here not in the constructor because I want to close in certain condition that made a problem when fired in the constructor
            // consdir moving all to here instead of constructer I think it is more clear
            if (_TestAppointmentID == -1)
            {
                _Mode = enMode.AddNew;

                _CheckIsThereAFailedTakenTest();
            }
            else
            {
                _Mode = enMode.Update;

                _CheckLocked();
            }
        }

        private void _CheckLocked()
        {
            if (clsTestAppointment.isLocked(_TestAppointmentID))
                _LookedTestUI();
        }

        private void _LookedTestUI()
        {
            lblAppointmentLocked.Visible = true;
            dtpTestDate.Enabled = false;
            dtpTestTime.Enabled = false;
            btnSaveTestAppointment.Enabled = false;
        }

        private void _CheckRetake()
        {
            if (_TestAppointment.RetakeTestApplicationID != -1)
                CreationMode = enCreationMode.RetakeTimeSchedule;
        }

        private void _CheckIsThereAFailedTakenTest()
        {
            if (clsTestAppointment.IfThereAFailedLockedTestAppointment(_TestTypeID, _LDLAppID))
                CreationMode = enCreationMode.RetakeTimeSchedule;
        }

        private void _SetMode()
        {
            if (_Mode == enMode.AddNew)
                _AddNewTestAppointment();
            else 
                _UpdateTestAppointment();
        }

        private void _AddNewTestAppointment()
        {
            if (CreationMode == enCreationMode.RetakeTimeSchedule)
                dtpTestDate.MinDate = clsTestAppointment.GetLastTestAppointmentDate(_TestTypeID, _LDLAppID);
            else
                dtpTestDate.MinDate = DateTime.Now; 

            gbRetakeTestInfo.Enabled = (CreationMode == enCreationMode.RetakeTimeSchedule);

            _TestAppointment = new clsTestAppointment();
        }

        private void _UpdateTestAppointment()
        {
            _TestAppointment = clsTestAppointment.Find(_TestAppointmentID);
            if (_TestAppointment != null)
            {
                //we compare the current date with the appointment date to set the min date.
                if (DateTime.Compare(DateTime.Now, _TestAppointment.AppointmentDate) < 0)
                    dtpTestDate.MinDate = DateTime.Now;
                else
                    dtpTestDate.MinDate = _TestAppointment.AppointmentDate;

                dtpTestDate.Value = _TestAppointment.AppointmentDate;
                dtpTestTime.Value = _TestAppointment.AppointmentDate;

                _CheckRetake();

                gbRetakeTestInfo.Enabled = (CreationMode == enCreationMode.RetakeTimeSchedule);

                if (CreationMode == enCreationMode.RetakeTimeSchedule) lblRAppID.Text = _TestAppointment.RetakeTestApplicationID.ToString();
            }
            else
            {
                MessageBox.Show("The Form Will be Closed Because Test Appointment Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
        }

        private void _RetakeUI()
        {
            lblSheduleTestTitle.Text = "Shedule Retake Test";
            gbRetakeTestInfo.Enabled = true;
            lblRAppFees.Text = "5";
            lblTotalFees.Text = (clsTestType.GetTestTypeFees(_TestTypeID) + Convert.ToInt32(lblRAppFees.Text)).ToString();
        }

        private void _LoadTestInfo()
        {
            _LDLApp = clsLocalDrivingLicenseApplication.FindByID(_LDLAppID);

            if (_LDLApp != null)
            {
                gbTest.Text = _TestTypeID.ToString();
                pbTestImage.Image = _TestTypeID == clsTestType.enTestType.VisionTest ? Resources.Vision_512 : _TestTypeID == clsTestType.enTestType.WrittenTest ? Resources.Written_Test_512 : Resources.driving_test_512;
                lblTestLDLAppID.Text = _LDLApp.LocalDrivingLicenseApplicationID.ToString();
                lblTestDrivngClass.Text = _LDLApp.LicenseClassInfo.ClassName; 
                lblTestApplicantName.Text = _LDLApp.ApplicantPersonInfo.FullName; 
                lblTestTrial.Text = clsTestAppointment.CountTrials(_TestTypeID, _LDLApp.LocalDrivingLicenseApplicationID).ToString();
                lblTestFees.Text = clsTestType.GetTestTypeFees(_TestTypeID).ToString();
            }
            else
            {
                MessageBox.Show("The Form Will be Closed Because L.D.L.Application Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
        }

        private bool _ValidateDate(DateTime combinedDateTime)
        {
            if (combinedDateTime < DateTime.Now)
                return false;
            return true;
        }

        private void btnSaveTestAppointment_Click(object sender, EventArgs e)
        {
            DateTime combinedDateTime = dtpTestDate.Value.Date.Add(dtpTestTime.Value.TimeOfDay); // Adds the time to the date

            if (!_ValidateDate(combinedDateTime))
            {
                MessageBox.Show("The test appointment date must be in the future.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _TestAppointment.TestTypeID = _TestTypeID;
            _TestAppointment.LocalDrivingLicenseApplicationID = _LDLAppID;

            _TestAppointment.AppointmentDate = combinedDateTime;

            _TestAppointment.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            _TestAppointment.IsLocked = false;

            if (CreationMode == enCreationMode.RetakeTimeSchedule)
                _TestAppointment.PaidFees = Convert.ToDecimal(lblTotalFees.Text);
            else
                _TestAppointment.PaidFees = Convert.ToDecimal(lblTestFees.Text);

            if (_TestAppointment.Save())
            {
                if (CreationMode == enCreationMode.RetakeTimeSchedule)
                    {
                    clsApplication retakeApp = new clsApplication();
                    retakeApp.ApplicationStatus = clsApplication.enApplicationStatus.New;
                    retakeApp.ApplicationDate = DateTime.Now;
                    retakeApp.LastStatusDate = DateTime.Now;
                    retakeApp.CreatedByUserID = clsGlobal.CurrentUser.UserID;
                    retakeApp.ApplicationTypeID = clsApplicationType.enApplicationType.RetakeTest;
                    retakeApp.PaidFees = clsApplicationType.GetApplicationTypeFee(clsApplicationType.enApplicationType.RetakeTest);
                    retakeApp.ApplicantPersonID = _LDLApp.ApplicantPersonID;

                    if (retakeApp.Save())
                    {
                        _TestAppointment.RetakeTestApplicationID = retakeApp.ApplicationID;

                        if (_TestAppointment.Save())
                            lblRAppID.Text = _TestAppointment.RetakeTestApplicationID.ToString();
                    }

                    MessageBox.Show("Data Saved Successfuly!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _Mode = enMode.Update;
                    _LookedTestUI();
                }
                else
                    this.Close();
            }
            else
                MessageBox.Show("Data Saved Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCloseScheduleTest_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
