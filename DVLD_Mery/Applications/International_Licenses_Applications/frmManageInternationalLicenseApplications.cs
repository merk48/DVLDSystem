using DVLD_Mery_Buisness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_Mery
{
    public partial class frmManageInternationalLicenseApplications : Form
    {
        DataTable _dtIntLApplications;
        DataView _dvIntLApplications;

        Form _frm;
        

        public frmManageInternationalLicenseApplications()
        {
            InitializeComponent();
        }

        private void frmManageInternationalLicenseApplications_Load(object sender, EventArgs e)
        {
            _LoadIntLApplicationsTable();

            _DataTableUI();

            _FilterUI();
        }

        

        private void _LoadIntLApplicationsTable()
        {
            _dtIntLApplications = clsInternationalLicense.GetAllInternationalLicenses();

            dgvIntLApplications.DataSource = _dtIntLApplications;

            _dvIntLApplications = _dtIntLApplications.DefaultView;

            cmbFilterIntLAppsByProperity.SelectedIndex = 0;

            lblIntLApplicationsRecords.Text = dgvIntLApplications.Rows.Count.ToString();
        }

        private void _FilterUI()
        {
            txtIntLAppsFilter.Visible = false;
            txtIntLAppsFilter.Focus();
            panelrbIsActiveFilter.Visible = false;
            lnklblClearFilter.Visible = false;
        }

        private void _DataTableUI()
        {
            if (dgvIntLApplications.Rows.Count > 0)
            {
                dgvIntLApplications.Columns[0].Width = 160;
                dgvIntLApplications.Columns[1].Width = 150;
                dgvIntLApplications.Columns[2].Width = 130;
                dgvIntLApplications.Columns[3].Width = 130;
                dgvIntLApplications.Columns[4].Width = 180;
                dgvIntLApplications.Columns[5].Width = 180;
                dgvIntLApplications.Columns[6].Width = 120;
            }
        }
        private void btnAddNewIntLApp_Click(object sender, EventArgs e)
        {
            _frm = new frmAddEdiInternationalDrivingLicenseApplication();
            _frm.ShowDialog();

            _LoadIntLApplicationsTable();
        }

        private void btnCloseManageIntLApplications_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtIntLAppsFilter_TextChanged(object sender, EventArgs e)
        {
            if (cmbFilterIntLAppsByProperity.Text == "")
            {
                _dvIntLApplications.RowFilter = string.Empty;
                lblIntLApplicationsRecords.Text = dgvIntLApplications.Rows.Count.ToString();
                return;
            }

            if (_dtIntLApplications != null && _dtIntLApplications.Columns.Contains(cmbFilterIntLAppsByProperity.Text))
            {
                string FilteringProperty = cmbFilterIntLAppsByProperity.Text;

                if (FilteringProperty != "IsActive" )
                {
                    if (int.TryParse(txtIntLAppsFilter.Text, out int ID))
                        _dvIntLApplications.RowFilter = $"{FilteringProperty} = {ID}";
                    else 
                        _dvIntLApplications.RowFilter = string.Empty;
                }

                lblIntLApplicationsRecords.Text = dgvIntLApplications.Rows.Count.ToString();

            }
        }

        private void _ClearFilteringUI()
        {
            _dvIntLApplications.RowFilter = string.Empty;
            txtIntLAppsFilter.Text = "";
            txtIntLAppsFilter.Focus();
            rdbFilterActive.Checked = false;
            rdbFilterDeActive.Checked = false;
        }

        private void cmbFilterIntLAppsByProperity_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIntLAppsFilter.Visible = (cmbFilterIntLAppsByProperity.Text != "None" && cmbFilterIntLAppsByProperity.Text != "IsActive" );
            panelrbIsActiveFilter.Visible = (cmbFilterIntLAppsByProperity.Text != "None" && cmbFilterIntLAppsByProperity.Text == "IsActive");
            lnklblClearFilter.Visible = txtIntLAppsFilter.Visible || panelrbIsActiveFilter.Visible;

            _ClearFilteringUI();
        }

        private void txtIntLAppsFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbFilterIntLAppsByProperity.Text != "IsActive")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void lnklblClearFilter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _ClearFilteringUI();
        }

        private void rdbFilterIsActive_CheckedChanged(object sender, EventArgs e)
        {
            _dvIntLApplications.RowFilter = rdbFilterActive.Checked ? "IsActive = 1" : rdbFilterDeActive.Checked ? "IsActive = 0" : string.Empty;
            lblIntLApplicationsRecords.Text = dgvIntLApplications.Rows.Count.ToString();
        }

        private void AddNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frm = new frmAddEdiInternationalDrivingLicenseApplication();
            _frm.ShowDialog();

            _LoadIntLApplicationsTable();
        }

        private int _GetCellIntLAppID()
        {
            return Convert.ToInt32(dgvIntLApplications.CurrentRow.Cells[0].Value);
        }

        private int _GetCellApplicationID()
        {
            return Convert.ToInt32(dgvIntLApplications.CurrentRow.Cells[1].Value);
        }

        private void ShowApplicationDetailstoolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frm = new frmShowPersonDetails(clsApplication.GetApplicantID(_GetCellApplicationID()));
            _frm.ShowDialog();

            _LoadIntLApplicationsTable();
        }

        private void ShowLicensetoolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frm = new frmShowInternatioanlLicenseDetails(_GetCellIntLAppID());
            _frm.ShowDialog();
        }
   
        private void ShowPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frm = new frmShowPersonLicenseHistory(_GetCellApplicationID());
            _frm.ShowDialog();

            _LoadIntLApplicationsTable();
        }

        private void dgvIntLApplications_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _frm = new frmShowInternatioanlLicenseDetails(_GetCellIntLAppID());
            _frm.ShowDialog();
        }
    }
}
