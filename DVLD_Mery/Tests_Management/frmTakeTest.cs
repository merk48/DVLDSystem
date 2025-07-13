using DVLD_Mery.Properties;
using DVLD_Mery_Buisness;
using System;
using System.Windows.Forms;

namespace DVLD_Mery
{
    public partial class frmTakeTest : Form
    {

        int _TestAppointmentID = -1; int _LDLAppID = -1; 
        clsTestType.enTestType _TestTypeID = clsTestType.enTestType.VisionTest;

        public frmTakeTest(int TestAppointmentID, clsTestType.enTestType TestTypeID, int LDLAppID)
        {
            InitializeComponent();

            _TestAppointmentID = TestAppointmentID;
            _TestTypeID = TestTypeID;
            _LDLAppID = LDLAppID;
        }

        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            btnSaveTestAppointment.Enabled = false;

            _LoadTestInfo();
        }

        private void _LoadTestInfo()
        {
            clsLocalDrivingLicenseApplication LDLApp = clsLocalDrivingLicenseApplication.FindByID(_LDLAppID);

            if (LDLApp != null)
            {
                gbTest.Text = _TestTypeID.ToString();
                pbTestImage.Image = _TestTypeID == clsTestType.enTestType.VisionTest ? Resources.Vision_512 : _TestTypeID == clsTestType.enTestType.WrittenTest ? Resources.Written_Test_512 : Resources.driving_test_512;
                lblTestLDLAppID.Text = LDLApp.LocalDrivingLicenseApplicationID.ToString();
                lblTestDrivngClass.Text = LDLApp.LicenseClassInfo.ClassName;
                lblTestApplicantName.Text = LDLApp.ApplicantPersonInfo.FullName;
                lblTestTrial.Text = clsTestAppointment.CountTrials(_TestTypeID, LDLApp.LocalDrivingLicenseApplicationID).ToString();
                lblTestFees.Text = clsTestType.GetTestTypeFees(_TestTypeID).ToString();

                lblTestDate.Text = clsTestAppointment.GetTestAppointmentDate(_TestAppointmentID).ToString();
            }
            else
            {
                MessageBox.Show("The Form Will be Closed Because L.D.L.App Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
        }

        private void btnSaveTestAppointment_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to save? After that you cannot change the Test Result anymore!", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                clsTest Test = new clsTest();

                Test.TestAppointmentID = _TestAppointmentID;
                Test.CreatedByUserID = clsGlobal.CurrentUser.UserID;
                Test.TestResult = rbPass.Checked;
                Test.Notes = txtNotes.Text;

                if (Test.Save())
                {
                    MessageBox.Show("Data Saved Successfuly!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Data Saved Failed!", "Saved Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
        }


        private void radiobuttonPassFail_CheckedChanged(object sender, EventArgs e)
        {
            btnSaveTestAppointment.Enabled = true;
        }

        private void btnCloseScheduleTest_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
