using DVLD_Mery_Buisness;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD_Mery
{
    public partial class frmManageLocalLicenseApplications : Form
    {
        DataTable _dtLDLApplications; DataView _dvLDLApplications; Form _frm;

        public frmManageLocalLicenseApplications()
        {
            InitializeComponent();
        }
       
        private void frmManageLocalLicenseApplications_Load(object sender, EventArgs e)
        {
            _LoadLDLApplicationsTable();

            _DataTableUI();

            _FilterUI();
        }

        private void _DataTableUI()
        {
           if(dgvLDLApplications.Rows.Count > 0)
            {
                dgvLDLApplications.Columns[0].Width = 150;
                dgvLDLApplications.Columns[1].Width = 250;
                dgvLDLApplications.Columns[2].Width = 85;
                dgvLDLApplications.Columns[3].Width = 275;
                dgvLDLApplications.Columns[4].Width = 150;
                dgvLDLApplications.Columns[5].Width =100;
                dgvLDLApplications.Columns[6].Width = 85;
            }
        }

        private void _FilterUI()
        {
            txtLDLAppsFilter.Visible = false;

            _FillLicenseClassesInComoboBox();
            cmbLicenseClasses.Visible = false;
            cmbLicenseClasses.SelectedIndex = 0;

            cmbLDLAppStatus.Visible = false;
            cmbLDLAppStatus.SelectedIndex = 0;

            lnklblClearFilter.Visible = false;
        }

        private void _FillLicenseClassesInComoboBox()
        {
            foreach (DataRow row in clsLicenseClass.GetAllLicenseClasss().Rows)
                cmbLicenseClasses.Items.Add(row["ClassName"]);
        }

        private void _LoadLDLApplicationsTable()
        {
            _dtLDLApplications = clsLocalDrivingLicenseApplication.GetAllLocalDrivingLicenseApplications();

            dgvLDLApplications.DataSource = _dtLDLApplications;

            _dvLDLApplications = _dtLDLApplications.DefaultView;

            cmbFilterLDLAppsByProperity.SelectedIndex = 0;

            lblLDLApplicationsRecords.Text = dgvLDLApplications.Rows.Count.ToString();
        }

        private void btnAddNewLDLApp_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditLocalDrivingLicenseApplication();
            frm.ShowDialog();

            _LoadLDLApplicationsTable();
        }

        private void cmbFilterLDLAppsByProperity_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtLDLAppsFilter.Visible = (cmbFilterLDLAppsByProperity.Text != "None" && cmbFilterLDLAppsByProperity.Text != "DrivingClass" && cmbFilterLDLAppsByProperity.Text != "Status");
            cmbLicenseClasses.Visible = (cmbFilterLDLAppsByProperity.Text != "None" && cmbFilterLDLAppsByProperity.Text == "DrivingClass");
            cmbLDLAppStatus.Visible = (cmbFilterLDLAppsByProperity.Text != "None" && cmbFilterLDLAppsByProperity.Text == "Status");
            lnklblClearFilter.Visible = txtLDLAppsFilter.Visible || cmbLicenseClasses.Visible || cmbLDLAppStatus.Visible;

            _ClearFilteringUI();
        }

        private void txtLDLAppsFilter_TextChanged(object sender, EventArgs e)
        {
            if (cmbFilterLDLAppsByProperity.Text == "")
            {
                _dvLDLApplications.RowFilter = string.Empty;
                lblLDLApplicationsRecords.Text = dgvLDLApplications.Rows.Count.ToString();
                return;
            }

            if (_dtLDLApplications != null && _dtLDLApplications.Columns.Contains(cmbFilterLDLAppsByProperity.Text))
            {
                string FilteringProperty = cmbFilterLDLAppsByProperity.Text;
                if (FilteringProperty == "LDLAppID")
                {
                    if (int.TryParse(txtLDLAppsFilter.Text, out int LDLAppID))
                        _dvLDLApplications.RowFilter = $"LDLAppID = {LDLAppID}";
                    else
                        _dvLDLApplications.RowFilter = string.Empty;
                }
                else if (FilteringProperty == "PassedTests")
                {
                    if (int.TryParse(txtLDLAppsFilter.Text, out int PassedTestsNum))
                        _dvLDLApplications.RowFilter = $"PassedTests = {PassedTestsNum}";
                    else
                        _dvLDLApplications.RowFilter = string.Empty;
                }
                else if (FilteringProperty != "DrivingClass" && FilteringProperty != "Status")
                    _dvLDLApplications.RowFilter = $"{FilteringProperty} Like \'%{txtLDLAppsFilter.Text}%\'";

                lblLDLApplicationsRecords.Text = dgvLDLApplications.Rows.Count.ToString();
            }

        }

        private void cmbLicenseClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            _dvLDLApplications.RowFilter = cmbLicenseClasses.Text == "All" ? string.Empty : $" DrivingClass = \'{cmbLicenseClasses.Text}\'";
            lblLDLApplicationsRecords.Text = dgvLDLApplications.Rows.Count.ToString();
        }

        private void cmbLDLAppStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            _dvLDLApplications.RowFilter = cmbLDLAppStatus.Text == "All" ? string.Empty : $" Status = \'{cmbLDLAppStatus.Text}\'";
            lblLDLApplicationsRecords.Text = dgvLDLApplications.Rows.Count.ToString();
        }

        private void llClearFilter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _ClearFilteringUI();
        }

        private void _ClearFilteringUI()
        {
            txtLDLAppsFilter.Text = "";
            txtLDLAppsFilter.Focus();
            cmbLicenseClasses.SelectedIndex = 0;
            cmbLDLAppStatus.SelectedIndex = 0;
            _dvLDLApplications.RowFilter = string.Empty;
        }

        private void txtLDLAppsFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbFilterLDLAppsByProperity.Text == "LDLAppID" || cmbFilterLDLAppsByProperity.Text == "PassedTests")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private int _GetCellLDLAppID()
        {
            return Convert.ToInt32(dgvLDLApplications.CurrentRow.Cells[0].Value);
        }

        // handle this later (not sure)
        private string _GetCellLDLAppNationalNo()
        {
            return dgvLDLApplications.CurrentRow.Cells[2].Value.ToString();
        }

        private string _GetCellLDLAppStatus()
        {
            return dgvLDLApplications.CurrentRow.Cells[6].Value.ToString();
        }

        private int _GetCellLDLAppPassedTests()
        {
            return Convert.ToInt32(dgvLDLApplications.CurrentRow.Cells[5].Value);
        }

        private void ShowApplicationDetailstoolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmShowLDLAppDetails(_GetCellLDLAppID());
            frm.ShowDialog();

            _LoadLDLApplicationsTable();
        }

        private void AddNewLDLAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditLocalDrivingLicenseApplication();
            frm.ShowDialog();

            _LoadLDLApplicationsTable();
        }

        private void EdittoolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditLocalDrivingLicenseApplication(_GetCellLDLAppID());
            frm.ShowDialog();

            _LoadLDLApplicationsTable();
        }

        private void DeletetoolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LDLAppID = _GetCellLDLAppID();
            if (MessageBox.Show($"Are you sure you want to delete this L.D.L.Application with ID [{LDLAppID}]?", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
            {
                if (clsLocalDrivingLicenseApplication.DeleteLocalDrivingLicenseApplication(LDLAppID))
                {
                int AppID =clsLocalDrivingLicenseApplication.GetApplicationIDByLDLAppID(LDLAppID);

                    if (clsApplication.UpdateStatus(AppID, clsApplication.enApplicationStatus.Cancelled, DateTime.Now))
                    {
                        _LoadLDLApplicationsTable();

                        MessageBox.Show($"L.D.L.Application with ID [{LDLAppID}] deleted successfuly");
                    }
                }
                else  
                    MessageBox.Show("L.D.L.Application was not deleted because it has data linked to it!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelApplicationtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LDLAppID = _GetCellLDLAppID();
            if (MessageBox.Show($"Are you sure you want to Cancel this L.D.L.Application with ID [{LDLAppID}]?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes) 
            {
                clsLocalDrivingLicenseApplication LDLApp = clsLocalDrivingLicenseApplication.FindByID(LDLAppID);
                if(LDLApp != null)
                {
                    if (LDLApp.UpdateStatus(clsApplication.enApplicationStatus.Cancelled,DateTime.Now))
                    {
                        _LoadLDLApplicationsTable();
                        MessageBox.Show($"L.D.L.Application with ID [{LDLAppID}] Cancelled successfuly", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show($"L.D.L.Application with ID [{LDLAppID}] Cancelled successfuly", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show($"Not found", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void _UpdateScheduleTestsMenuItemsEnable(bool VisionTest,bool WrittenTest, bool StreetTest)
        {
            ScheduleTestsMenuItem.DropDownItems["scheduleVisionTestToolStripMenuItem"].Enabled = VisionTest;
            ScheduleTestsMenuItem.DropDownItems["scheduleWrittenTestToolStripMenuItem"].Enabled = WrittenTest;
            ScheduleTestsMenuItem.DropDownItems["scheduleStreetTestToolStripMenuItem"].Enabled = StreetTest;
        }

        private void dgvLDLApplications_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            string LDLAppStatus = _GetCellLDLAppStatus();
            int LDLAppPassedTests = _GetCellLDLAppPassedTests();

            // this feature Always available
            // ShowPersonLicenseHistoryToolStripMenuItem.Enabled = true;

            if (LDLAppStatus == "Cancelled")
            {
                foreach (ToolStripItem item in cmsLDLApp.Items)
                    item.Enabled = false;

                ShowApplicationDetailstoolStripMenuItem.Enabled = true;
                ShowPersonLicenseHistoryToolStripMenuItem.Enabled = true;
                return;
            }

            if (LDLAppStatus == "Completed")
            {
                ScheduleTestsMenuItem.Enabled = false;
                EdittoolStripMenuItem.Enabled = false;
                DeletetoolStripMenuItem.Enabled = false;
                CancelApplicationtoolStripMenuItem.Enabled = false;
                IssueDrivingLicenseFTtoolStripMenuItem.Enabled = false;

                ShowLicensetoolStripMenuItem.Enabled = true;
                return;
            }

            if (LDLAppStatus == "New")
            {
                ScheduleTestsMenuItem.Enabled = true;
                IssueDrivingLicenseFTtoolStripMenuItem.Enabled = false;
                ShowLicensetoolStripMenuItem.Enabled = false;
            }

            if (LDLAppPassedTests == 0)
                _UpdateScheduleTestsMenuItemsEnable(true,false,false);
            
            else if (LDLAppPassedTests == 1)
                _UpdateScheduleTestsMenuItemsEnable(false, true, false);

            else if (LDLAppPassedTests == 2)
                _UpdateScheduleTestsMenuItemsEnable(false, false, true);

            if ((LDLAppPassedTests == 3))
            {
                ScheduleTestsMenuItem.Enabled = false;
                IssueDrivingLicenseFTtoolStripMenuItem.Enabled = true;
            }
        }

        private void scheduleVisionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frm = new frmTestAppointmentSchedule(clsTestType.enTestType.VisionTest, _GetCellLDLAppID(),_GetCellLDLAppPassedTests());
             _frm.ShowDialog();

            _LoadLDLApplicationsTable();
        }

        private void scheduleWrittenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frm = new frmTestAppointmentSchedule(clsTestType.enTestType.WrittenTest,_GetCellLDLAppID(), _GetCellLDLAppPassedTests());
            _frm.ShowDialog();

            _LoadLDLApplicationsTable();
        }

        private void scheduleStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frm = new frmTestAppointmentSchedule(clsTestType.enTestType.StreetTest ,_GetCellLDLAppID(), _GetCellLDLAppPassedTests()) ;
            _frm.ShowDialog();

            _LoadLDLApplicationsTable();
        }

        private void IssueDrivingLicenseFTtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frm = new frmIssueDrivingLicense( _GetCellLDLAppID());
            _frm.ShowDialog();

            _LoadLDLApplicationsTable();
        }

        private void ShowLicensetoolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frm = new frmShowLicenseDetails(clsLicense.GetIssuedLicenseIDByLDLAppID(_GetCellLDLAppID()));
            _frm.ShowDialog();

            _LoadLDLApplicationsTable();
           
        }

        private void ShowPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frm = new frmShowPersonLicenseHistory(_GetCellLDLAppNationalNo());
            _frm.ShowDialog();

            _LoadLDLApplicationsTable();
        }

        private void btnExitManageLocalLicenseApplications_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
