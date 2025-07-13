using DVLD_Mery_Buisness;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD_Mery
{
    public partial class frmManageDetainedlLicenseApplications : Form
    {
        DataTable _dtDetainedLicenses;DataView _dvDetainedLicenses;
        Form _frm;

        public frmManageDetainedlLicenseApplications()
        {
            InitializeComponent();
        }

        private void frmManageDetainedlLicenseApplications_Load(object sender, EventArgs e)
        {
            _LoadDetainedLicensesTable();

            _DataTableUI();

            _FilterUI();
        }

        private void _LoadDetainedLicensesTable()
        {
            _dtDetainedLicenses = clsDetainLicense.GetAllDetainedLicenses();

            dgvtDetainedLicenses.DataSource = _dtDetainedLicenses;

            _dvDetainedLicenses = _dtDetainedLicenses.DefaultView;

            cmbFiltertDetainedLicensesByProperity.SelectedIndex = 0;

            lbltDetainedLicensesRecords.Text = dgvtDetainedLicenses.Rows.Count.ToString();
        }

        private void _FilterUI()
        {
            txtDetainedLicensesFilter.Visible = false;
            pnlIsReleasedFilter.Visible = false;
            lnklblClearFilter.Visible = false;
        }

        private void _DataTableUI()
        {
           if (dgvtDetainedLicenses.Rows.Count > 0)
            {
                dgvtDetainedLicenses.Columns[0].Width = 90;
                dgvtDetainedLicenses.Columns[1].Width = 90;
                dgvtDetainedLicenses.Columns[2].Width = 160;
                dgvtDetainedLicenses.Columns[3].Width = 110;
                dgvtDetainedLicenses.Columns[4].Width = 110;
                dgvtDetainedLicenses.Columns[5].Width = 160;
                dgvtDetainedLicenses.Columns[6].Width = 90;
                dgvtDetainedLicenses.Columns[7].Width = 330;
                dgvtDetainedLicenses.Columns[8].Width = 150;
            }
        }

        private void cmbFiltertDetainedLicensesByProperity_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDetainedLicensesFilter.Visible = (cmbFiltertDetainedLicensesByProperity.Text != "None" && cmbFiltertDetainedLicensesByProperity.Text != "IsReleased");
            pnlIsReleasedFilter.Visible = (cmbFiltertDetainedLicensesByProperity.Text != "None" && cmbFiltertDetainedLicensesByProperity.Text == "IsReleased");
            lnklblClearFilter.Visible = txtDetainedLicensesFilter.Visible || pnlIsReleasedFilter.Visible ;

            _ClearFilteringUI();
        }

        private void txtDetainedLicensesFilter_TextChanged(object sender, EventArgs e)
        {
            if (cmbFiltertDetainedLicensesByProperity.Text == "")
            {
                _dvDetainedLicenses.RowFilter = string.Empty;
                lbltDetainedLicensesRecords.Text = dgvtDetainedLicenses.Rows.Count.ToString();

                return;
            }

            if (_dtDetainedLicenses != null && _dtDetainedLicenses.Columns.Contains(cmbFiltertDetainedLicensesByProperity.Text))
            {
                string FilteringProperty = cmbFiltertDetainedLicensesByProperity.Text;
                if (FilteringProperty == "DetainID" || FilteringProperty == "ReleaseApplicationID")
                {
                    if (int.TryParse(txtDetainedLicensesFilter.Text, out int ID))
                        _dvDetainedLicenses.RowFilter = $"{FilteringProperty} = {ID}";
                    else
                        _dvDetainedLicenses.RowFilter = string.Empty;
                }
                else if (FilteringProperty != "IsReleased" )
                    _dvDetainedLicenses.RowFilter = $"{FilteringProperty} Like \'%{txtDetainedLicensesFilter.Text}%\'";
            
                lbltDetainedLicensesRecords.Text = dgvtDetainedLicenses.Rows.Count.ToString();
            }
        }

        private void txtDetainedLicensesFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
             e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void _ClearFilteringUI()
        {
            txtDetainedLicensesFilter.Text = "";
            txtDetainedLicensesFilter.Focus();
            rbFilterReleased.Checked = false;
            rbFilterNotReleased.Checked = false;
            _dvDetainedLicenses.RowFilter = string.Empty;
        }

        private void lnklblClearFilter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _ClearFilteringUI();
        }

        private void rbFilterIsReleased_CheckedChanged(object sender, EventArgs e)
        {
            _dvDetainedLicenses.RowFilter = rbFilterReleased.Checked ? " IsReleased = 1"  : rbFilterNotReleased.Checked ? " IsReleased = 0" : string.Empty;
            lbltDetainedLicensesRecords.Text = dgvtDetainedLicenses.Rows.Count.ToString();
        }

        private void btnExitManagetDetainedLicenses_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string _GetCellDetainedLicenseNationalNo()
        {
            return dgvtDetainedLicenses.CurrentRow.Cells[6].Value.ToString();
        }

        private int _GetCellDetainLicenseID()
        {
            return Convert.ToInt32(dgvtDetainedLicenses.CurrentRow.Cells[1].Value);
        }

        private bool _GetCellIsReleased()
        {
            return Convert.ToBoolean(dgvtDetainedLicenses.CurrentRow.Cells[3].Value);
        }

        private void ShowPersonDetailstoolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frm = new frmShowPersonDetails(_GetCellDetainedLicenseNationalNo());
            _frm.ShowDialog();

            _LoadDetainedLicensesTable();
        }

        private void ShowLiceDetailsnsetoolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frm = new frmShowLicenseDetails(_GetCellDetainLicenseID());
            _frm.ShowDialog();

            _LoadDetainedLicensesTable();
        }

        private void ShowPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frm = new frmShowPersonLicenseHistory(_GetCellDetainedLicenseNationalNo());
            _frm.ShowDialog();

            _LoadDetainedLicensesTable();
        }

        private void dgvtDetainedLicenses_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            ReleaseDetainedLicenseFTtoolStripMenuItem.Enabled = !_GetCellIsReleased();
        }

        private void ReleaseDetainedLicenseFTtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frm = new frmReleaseDetainedLicense(_GetCellDetainLicenseID());
            _frm.ShowDialog();

            _LoadDetainedLicensesTable();
        }

        private void btnDetainLicense_Click(object sender, EventArgs e)
        {
            _frm = new frmDetainLicense();
            _frm.ShowDialog();

            _LoadDetainedLicensesTable();
        }

        private void btnReleaseLicense_Click(object sender, EventArgs e)
        {
            _frm = new frmReleaseDetainedLicense();
            _frm.ShowDialog();

            _LoadDetainedLicensesTable();
        }
    }
}
