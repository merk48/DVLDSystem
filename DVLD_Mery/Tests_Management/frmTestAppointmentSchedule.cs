using DVLD_Mery.Properties;
using DVLD_Mery_Buisness;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD_Mery
{
    public partial class frmTestAppointmentSchedule : Form
    {
        DataTable _dtTestAppointments;

        clsTestType.enTestType _TestTypeID = clsTestType.enTestType.VisionTest ; int _LDLAppID = -1;

        public frmTestAppointmentSchedule(clsTestType.enTestType TestTypeID, int LDLAppID,int PassedTests)
        {
            InitializeComponent();

            _LDLAppID = LDLAppID;
            _TestTypeID = TestTypeID;
        }

        private void frmVisionTestAppointmentSchedule_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            _LoadTestAppointmentsTable();

            _DataTableUI();
        }

        private void _ResetDefaultValues()
        {
            ctrlLDLAppCard1.LoadLDLAppInfo(_LDLAppID);

            pbTestAppointmentImage.Image = _TestTypeID == clsTestType.enTestType.VisionTest ? Resources.Vision_512 : _TestTypeID == clsTestType.enTestType.WrittenTest ? Resources.Written_Test_512 : Resources.driving_test_512;
            lblTestAppointmentTitle.Text = _TestTypeID == clsTestType.enTestType.VisionTest ? "Vision Test Appointment" : _TestTypeID == clsTestType.enTestType.WrittenTest ? "Written Test Appointment" : "Street Test Appointment";
        }

        private void _LoadTestAppointmentsTable()
        {
            _dtTestAppointments = clsTestAppointment.GetAllAppointmentsByTestTypeAndLDLAppID(_TestTypeID, _LDLAppID);

            dgvTestAppintments.DataSource = _dtTestAppointments;

            lblTestAppointmentsRecords.Text = dgvTestAppintments.Rows.Count.ToString();
        }

        private void _DataTableUI()
        {
           if(dgvTestAppintments.Rows.Count > 0)
            {
                dgvTestAppintments.Columns[0].Width = 150;
                dgvTestAppintments.Columns[1].Width = 200;
                dgvTestAppintments.Columns[2].Width = 150;
                dgvTestAppintments.Columns[3].Width = 100;
            }
        }

        private void btnAddNewLDLApp_Click(object sender, EventArgs e)
        {
            // check if there already an An Open(Active) Appointment  >> he can't
            if (clsTestAppointment.IfThereAnOpenAppointment(_TestTypeID, _LDLAppID))
            {
                MessageBox.Show("Person already have an active appointment for this test, you can't add a new one!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            // check if there a locked Test Appointment & passed test >> he can't
            if (clsTestAppointment.IfThereAPassedLockedTestAppointment(_TestTypeID, _LDLAppID))
            {
                MessageBox.Show("This Person already passed this test before, you can only retake a failed test", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            // >>> So he can
            Form frm = new frmScheduleNew_Edit_RetakeTest(_TestTypeID, _LDLAppID);
            frm.ShowDialog(); 

            _LoadTestAppointmentsTable();
        }

        private void btnCloseTestAppointment_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int _GetCellTestAppointmentID()
        {
            return Convert.ToInt32(dgvTestAppintments.CurrentRow.Cells[0].Value);
        }
        private bool _GetCellTestAppointmentisLocked()
        {
            return Convert.ToBoolean(dgvTestAppintments.CurrentRow.Cells[3].Value);
        }

        private void EditTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmScheduleNew_Edit_RetakeTest( _TestTypeID, _LDLAppID, _GetCellTestAppointmentID());
            frm.ShowDialog();

            _LoadTestAppointmentsTable();
        }

        private void TakeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmTakeTest(_GetCellTestAppointmentID(), _TestTypeID, _LDLAppID);
            frm.ShowDialog();

            _LoadTestAppointmentsTable();
        }

        private void dgvTestAppintments_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            bool isLocked = _GetCellTestAppointmentisLocked();
            if (isLocked)
                TakeTestPersonToolStripMenuItem.Enabled = false;
            else
                TakeTestPersonToolStripMenuItem.Enabled = true;
        }

    }
}
