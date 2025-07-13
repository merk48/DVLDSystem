using DVLD_Mery_Buisness;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD_Mery
{
    public partial class frmManageUsers : Form
    {
        DataTable _dtUsers; DataView _dvUsers;  Form _frm;

        public frmManageUsers()
        {
            InitializeComponent();
        }

        private void _LoadUsersTable()
        {
            _dtUsers = clsUser.GetAllUsers();

            dgvUsers.DataSource = _dtUsers;

            _dvUsers = _dtUsers.DefaultView;

            cmbFilterUsersByProperity.SelectedIndex = 0;

            lblUsersRecords.Text = dgvUsers.Rows.Count.ToString();
        }

        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            _LoadUsersTable();

            _DataTableUI();

            _FilterUI();
        }

        private void _DataTableUI()
        {
            if(dgvUsers.Rows.Count > 0)
            {
                dgvUsers.Columns[0].Width = 110;
                dgvUsers.Columns[1].Width = 120;
                dgvUsers.Columns[2].Width = 350;
                dgvUsers.Columns[3].Width = 120;
                dgvUsers.Columns[4].Width = 120;
            }
        }

        private void _FilterUI()
        {
            txtUsersFilter.Visible = false;
            lnklblClearFilter.Visible = false;
            panelrbIsActiveFilter.Visible = false;
        }

        private void cmbFilterUsersByProperity_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtUsersFilter.Visible  = (cmbFilterUsersByProperity.Text != "None" && cmbFilterUsersByProperity.Text != "IsActive");
            panelrbIsActiveFilter.Visible = (cmbFilterUsersByProperity.Text != "None" && cmbFilterUsersByProperity.Text == "IsActive");
            lnklblClearFilter.Visible = txtUsersFilter.Visible || panelrbIsActiveFilter.Visible;

            _ClearFilteringUI();
        }

        private void txtUsersFilter_TextChanged(object sender, EventArgs e)
        {
            if (txtUsersFilter.Text == "")
            {
                _dvUsers.RowFilter = string.Empty;
                lblUsersRecords.Text = dgvUsers.Rows.Count.ToString();
                return;
            }

            if (_dtUsers != null && _dtUsers.Columns.Contains(cmbFilterUsersByProperity.Text))
            {
                string FilteringProperty = cmbFilterUsersByProperity.Text.Trim();

                if (FilteringProperty == "UserID" || FilteringProperty == "PersonID")
                {
                    if (int.TryParse(txtUsersFilter.Text, out int ID))
                        _dvUsers.RowFilter = $"{FilteringProperty} = {ID}";
                    else
                        _dvUsers.RowFilter = string.Empty;
                }
                else if (FilteringProperty != "IsActive")
                    _dvUsers.RowFilter = $"{FilteringProperty} LIKE '%{txtUsersFilter.Text}%'";

                lblUsersRecords.Text = dgvUsers.Rows.Count.ToString();
            }
        }

        private void txtUsersFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbFilterUsersByProperity.Text == "PersonID" || cmbFilterUsersByProperity.Text == "UserID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            else
                e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void rdbFilterIsActive_CheckedChanged(object sender, EventArgs e)
        {
            _dvUsers.RowFilter = rdbFilterActive.Checked ? "isActive = 1" : rdbFilterDeActive.Checked ? "isActive = 0" : string.Empty;
            lblUsersRecords.Text = dgvUsers.Rows.Count.ToString();
        }

        private void _ClearFilteringUI()
        {
            _dvUsers.RowFilter = string.Empty;
            rdbFilterActive.Checked = false;
            rdbFilterDeActive.Checked = false;
            txtUsersFilter.Text = "";
            txtUsersFilter.Focus();
        }

        private void llClearFilter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _ClearFilteringUI();
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            _frm = new frmAddEditNewUser();
            _frm.ShowDialog();

            _LoadUsersTable();
        }

        private int _GetCellUserID()
        {
            return Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value);
        }

        private void AddNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frm = new frmAddEditNewUser();
            _frm.ShowDialog();

            _LoadUsersTable();
        }

        private void EdittoolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frm = new frmAddEditNewUser(_GetCellUserID());
            _frm.ShowDialog();

            _LoadUsersTable();
        }

        private void DeletetoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure you want to delete this User with ID [{_GetCellUserID()}]?", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
                if(clsUser.DeleteUserByID(_GetCellUserID()))
                {
                    _LoadUsersTable();

                    MessageBox.Show($"User with ID [{_GetCellUserID()}] deleted successfuly");
                }
                else
                    MessageBox.Show("User was not deleted because it has data linked to it!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ShowDetailstoolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frm = new frmUserDetails(_GetCellUserID());
            _frm.ShowDialog();

            _LoadUsersTable();
        }

        private void ChangePasswordtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frm = new frmChangeUserPassword(_GetCellUserID());
            _frm.ShowDialog();
        }

        private void SendEmailtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature not implemented yet!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void PhoneCalltoolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature not implemented yet!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dgvUsers_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _frm = new frmUserDetails(_GetCellUserID());
            _frm.ShowDialog();

            _LoadUsersTable();
        }

        private void btnCloseManageUsers_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
