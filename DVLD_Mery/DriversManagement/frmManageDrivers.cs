using DVLD_Mery_Buisness;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD_Mery.DriversManagement
{
    public partial class frmManageDrivers : Form
    {
        DataTable _dtDrivers; DataView _dvDrivers;
        Form _frm;

        public frmManageDrivers()
        {
            InitializeComponent();
        }

        private void frmManageDrivers_Load(object sender, EventArgs e)
        {
            _LoadDriversTable();

            _DataTableUI();

            _FilterUI();
        }

        private void _LoadDriversTable()
        {
            _dtDrivers = clsDriver.GetAllDrivers();

            dgvDrivers.DataSource = _dtDrivers;

            _dvDrivers = _dtDrivers.DefaultView;

            cmbFilterDriversByProperity.SelectedIndex = 0;

            lblPDriversRecords.Text = dgvDrivers.Rows.Count.ToString();
        }

        private void _DataTableUI()
        {
            if(dgvDrivers.Rows.Count  > 0)
            {
                dgvDrivers.Columns[0].Width = 120;
                dgvDrivers.Columns[1].Width = 120;
                dgvDrivers.Columns[2].Width = 140;
                dgvDrivers.Columns[3].Width = 320;
                dgvDrivers.Columns[4].Width = 170;
                dgvDrivers.Columns[5].Width = 150;
            }
        }

        private void _FilterUI()
        {
            txtDriverseFilter.Visible = false;
            lnklblClearFilter.Visible = false;
        }

        private void btnExitManagerDrivers_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbFilterDriversByProperity_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDriverseFilter.Visible = cmbFilterDriversByProperity.Text != "None" ;
            lnklblClearFilter.Visible = txtDriverseFilter.Visible;

            _ClearFilteringUI();
        }

        private void txtDriverseFilter_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDriverseFilter.Text))
            {
                _dvDrivers.RowFilter = string.Empty;
                lblPDriversRecords.Text = dgvDrivers.Rows.Count.ToString();
                return;
            }

            if (_dtDrivers != null && _dtDrivers.Columns.Contains(cmbFilterDriversByProperity.Text))
            {
                if (cmbFilterDriversByProperity.Text == "DriverID" ||cmbFilterDriversByProperity.Text == "PersonID")
                {
                    if (int.TryParse(txtDriverseFilter.Text, out int ID))
                        _dvDrivers.RowFilter = $"{cmbFilterDriversByProperity.Text} = {ID}";
                    else
                        _dvDrivers.RowFilter = string.Empty;
                }
                else 
                    _dvDrivers.RowFilter = $"{cmbFilterDriversByProperity.Text} LIKE '%{txtDriverseFilter.Text.Replace("'", "''")}%'";
           
                lblPDriversRecords.Text = dgvDrivers.Rows.Count.ToString();
            }
        }
        private void _ClearFilteringUI()
        {
            _dvDrivers.RowFilter = string.Empty;
            txtDriverseFilter.Text = "";
        }

        private void lnklblClearFilter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _ClearFilteringUI();
        }

        private void txtDriverseFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbFilterDriversByProperity.Text == "DriverID" || cmbFilterDriversByProperity.Text == "PersonID")
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                    e.Handled = true; // Reject invalid input Non integer
                else
                    e.Handled = false;
        }

        private string _GetCellDriverNationalNo()
        {
            return dgvDrivers.CurrentRow.Cells[2].Value.ToString();
        }

        private void showLicenseDetailsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            _frm = new frmShowPersonDetails(_GetCellDriverNationalNo());
            _frm.ShowDialog();

            _LoadDriversTable();
        }

        private void ShowLicenseDetailstoolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frm = new frmShowPersonLicenseHistory(_GetCellDriverNationalNo());
            _frm.ShowDialog();

            _LoadDriversTable();
        }

        private void dgvDrivers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _frm = new frmShowPersonDetails(_GetCellDriverNationalNo());
            _frm.ShowDialog();

            _LoadDriversTable();
        }
       
    }
}
