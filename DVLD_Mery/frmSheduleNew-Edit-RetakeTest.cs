using DVLD_Mery.Properties;
using DVLD_Mery_Buisness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Mery
{
    public partial class frmSheduleNew_Edit_RetakeTest : Form
    {
        enum enMode { AddNew, Update ,Retake}
        enMode _Mode; 

        int _TestAppointmentID;
        clsTestType.enTestType _TestTypeID;
        int _LDLAppID;

        clsTestAppointment _TestAppointment;

        public frmSheduleNew_Edit_RetakeTest(int TestAppointmentID,clsTestType.enTestType TestTypeID, int LDLAppID)
        {
            InitializeComponent();

            _TestAppointmentID = TestAppointmentID;
            _TestTypeID = TestTypeID;
            _LDLAppID = LDLAppID;

            if(_TestAppointmentID == -1)
                _Mode = enMode.AddNew;
            else 
                _Mode = enMode.Update;

        }

        private void frmSheduleRetakeTest_Load(object sender, EventArgs e)
        {
             _CheckTestAppointmentMode();
           
             _LoadTestInfo();

             gbRetakeTestInfo.Enabled = false; // handle this 
            // handle retake 
        }

        private void _CheckTestAppointmentMode()
        {
            if (_Mode == enMode.AddNew)
                _AddNewTestAppointment();
            else
                _UpdateTestAppointment();
        }

        private void _AddNewTestAppointment()
        {
            _TestAppointment = new clsTestAppointment();
        }

        private void _UpdateTestAppointment()
        {
            _TestAppointment = clsTestAppointment.Find(_TestAppointmentID);
            if (_TestAppointment != null)
                dtpTestDate.Value = _TestAppointment.AppointmentDate;
            else
                MessageBox.Show("Not found");
        }

        private void _LoadTestInfo()
        {
            clsLocalDrivingLicenseApplication LDLApp = clsLocalDrivingLicenseApplication.FindByID(_LDLAppID);

            if(LDLApp != null)
            {
                gbTest.Text = _TestTypeID.ToString();
                pbTestImage.Image = _TestTypeID == clsTestType.enTestType.VisionTest ? Resources.Vision_512 : _TestTypeID == clsTestType.enTestType.VisionTest ?Resources.Written_Test_32_Sechdule : Resources.Street_Test_32;
                lblTestLDLAppID.Text = LDLApp.LocalDrivingLicenseApplicationID.ToString();
                lblTestDrivngClass.Text = clsLicenseClass.Find(LDLApp.LicenseClassID).ClassName; // hnadle later with LicenseClass Instanse of a getClassName Metod
                lblTestApplicantName.Text = clsPerson.Find(LDLApp.ApplicantPersonID).FullName; // not sure
                lblTestTrial.Text = clsTestAppointment.CountTrials(_TestTypeID, LDLApp.LocalDrivingLicenseApplicationID).ToString();
                dtpTestDate.MinDate = DateTime.Now;
                lblTestFees.Text = clsTestType.GetTestTypeFees(_TestTypeID).ToString();
            }
        }

        private void btnSaveUpdateTestTypes_Click(object sender, EventArgs e)
        {
            _TestAppointment.TestTypeID = clsTestType.enTestType.VisionTest;
            _TestAppointment.LocalDrivingLicenseApplicationID = _LDLAppID;
            _TestAppointment.AppointmentDate = dtpTestDate.Value;
            _TestAppointment.PaidFees = Convert.ToDecimal(lblTestFees.Text);
            _TestAppointment.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            _TestAppointment.IsLocked = false;
           // TestAppointment.RetakeTestApplicationID = -1;


            if(_TestAppointment.Save())
                MessageBox.Show("Data Saved Successfuly!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Data Saved Failed!", "Saved Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnExitSheduleTest_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
