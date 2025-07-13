using DVLD_Mery_Buisness;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD_Mery
{
    public partial class frmShowPersonLicenseHistory : Form
    {
        int _PersonID = -1; clsDriver _Driver;

        DataTable _dtLocalLicenses;DataTable _dtInternationalLicenses;
        Form _frm;

        bool _isEmpty = true;

        public frmShowPersonLicenseHistory(string NationalNo)
        {
            InitializeComponent();

            _PersonID = clsPerson.GetPersonIDByNationalNo(NationalNo);
            ctrlPersonCard1.LoadPersonInfo(NationalNo);
        }

        // check from this
        public frmShowPersonLicenseHistory(int ApplicationID)
        {
            InitializeComponent();

            _PersonID = clsApplication.GetApplicantID(ApplicationID);

            ctrlPersonCard1.LoadPersonInfo(_PersonID);
        }

        private void frmShowPersonLicenseHistory_Load(object sender, EventArgs e)
        {
            _LoadLicensesTable();
        }

        private void _LoadLicensesTable()
        {
            _Driver = clsDriver.FindByPersonID(_PersonID); //Handle this in separate method

            if(_Driver != null)
            {
                _isEmpty = false;
                
                _LoadLocalLicenses();

                _LoadInternationalicenses();

                lblLicensesRecords.Text = dgvLocalLicenses.Rows.Count.ToString();

            }
            else
            {
                _isEmpty = true;
                lblLicensesRecords.Text = "0";

               // MessageBox.Show($"Driver with ID = [{_Driver.DriverID}] NOT Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void _LoadLocalLicenses()
        {
            _dtLocalLicenses = clsLicense.GetLicensesByDriverID(_Driver.DriverID);
            dgvLocalLicenses.DataSource = _dtLocalLicenses;
        }

        private void _LoadInternationalicenses()
        {
            _dtInternationalLicenses = clsInternationalLicense.GetAllInternationalLicensesBtDriverID(_Driver.DriverID);
            dgvInternationalLicenses.DataSource = _dtInternationalLicenses;
        }
       
        private void tabControl1_Selecting_1(object sender, TabControlCancelEventArgs e)
        {
            if (!_isEmpty)
            {
                if (e.TabPageIndex == 0)
                    lblLicensesRecords.Text = dgvLocalLicenses.Rows.Count.ToString();
                else
                    lblLicensesRecords.Text = dgvInternationalLicenses.Rows.Count.ToString();
            }
        }

        private int _GetCellLicenseID()
        {
            return Convert.ToInt32(dgvLocalLicenses.CurrentRow.Cells[0].Value);
        }

        private int _GetCellIntLicenseID()
        {
            return Convert.ToInt32(dgvInternationalLicenses.CurrentRow.Cells[0].Value);
        }

        private void ShowLicenseDetailstoolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frm = new frmShowLicenseDetails(_GetCellLicenseID());
            _frm.ShowDialog();
        }

        private void ShowInternationalLicneseDetails_Click(object sender, EventArgs e)
        {
            _frm = new frmShowInternatioanlLicenseDetails(_GetCellIntLicenseID());
            _frm.ShowDialog();
        }

        private void btnCloseLicenseHistory_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
