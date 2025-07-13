using DVLD_Mery_Buisness;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace DVLD_Mery
{
    public partial class frmManagePeople : Form
    {
        DataTable _dtPeople; DataView _dvPeople; Form _frm;

        public frmManagePeople()
        {
            InitializeComponent();
        }

        private void frmManagePeople_Load(object sender, EventArgs e)
        {
            _LoadPeopleTable();

            _DataTableUI();

            _FilterUI();
        }

        private void _LoadPeopleTable()
        {
            _dtPeople = clsPerson.GetAllPeople();

            dgvPeople.DataSource = _dtPeople;

            _dvPeople = _dtPeople.DefaultView;

            cmbFilterPeopleByProperity.SelectedIndex = 0;

            lblPApplicationTypesRecords.Text = dgvPeople.Rows.Count.ToString();
        }

        private void _DataTableUI()
        {
            if (dgvPeople.Rows.Count > 0)
            {
                dgvPeople.Columns[0].Width = 110;
                dgvPeople.Columns[1].Width = 120;
                dgvPeople.Columns[2].Width = 120;
                dgvPeople.Columns[3].Width = 140;
                dgvPeople.Columns[4].Width = 120;
                dgvPeople.Columns[5].Width = 120;
                dgvPeople.Columns[6].Width = 120;
                dgvPeople.Columns[7].Width = 140;
                dgvPeople.Columns[8].Width = 120;
                dgvPeople.Columns[9].Width = 120;
                dgvPeople.Columns[10].Width = 170;
            }
        }

        private void _FilterUI()
        {
            txtPeopleFilter.Visible = false;
            pnlGenderFilter.Visible = false;
            lnklblClearFilter.Visible = false;
        }

        private void cmbFilterByProperity_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPeopleFilter.Visible = (cmbFilterPeopleByProperity.Text != "None" && cmbFilterPeopleByProperity.Text != "Gender");
            pnlGenderFilter.Visible = (cmbFilterPeopleByProperity.Text != "None" && cmbFilterPeopleByProperity.Text == "Gender");
            lnklblClearFilter.Visible = txtPeopleFilter.Visible || pnlGenderFilter.Visible;

            _ClearFilteringUI();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            // Clear filter if the textbox is empty or There is no Filter at all
            if (string.IsNullOrWhiteSpace(txtPeopleFilter.Text))
            {
                _dvPeople.RowFilter = string.Empty;
                lblPApplicationTypesRecords.Text = dgvPeople.Rows.Count.ToString();
                return;
            }

            // this null check
            if (_dtPeople != null && _dtPeople.Columns.Contains(cmbFilterPeopleByProperity.Text.Trim()))
            {
                string FilteringProperty = cmbFilterPeopleByProperity.Text.Trim();
                if (FilteringProperty == "PersonID")
                {
                    if (int.TryParse(txtPeopleFilter.Text, out int ID))
                        _dvPeople.RowFilter = $"PersonID = {ID}";
                    else
                        _dvPeople.RowFilter = string.Empty;
                }
                else if (FilteringProperty != "Gender")
                    _dvPeople.RowFilter = $"{FilteringProperty} LIKE '%{txtPeopleFilter.Text}%'";


                lblPApplicationTypesRecords.Text = dgvPeople.Rows.Count.ToString();
            }
        }

        private void txtPeopleFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbFilterPeopleByProperity.Text == "PersonID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void rdbFilterGender_CheckedChanged(object sender, EventArgs e)
        {
            _dvPeople.RowFilter = rdbFilterMale.Checked ? "Gender = 'Male'" : rdbFilterFemale.Checked ? "Gender = 'Female'" : string.Empty;
            lblPApplicationTypesRecords.Text = dgvPeople.Rows.Count.ToString();
        }

        private void lnklblClearFilter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _ClearFilteringUI();
        }
        
        private void _ClearFilteringUI()
        {
            txtPeopleFilter.Text = "";
            txtPeopleFilter.Focus();
            rdbFilterMale.Checked = false;
            rdbFilterFemale.Checked = false;
            _dvPeople.RowFilter = string.Empty;
        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            _frm = new frmAddEditPerson();
            _frm.ShowDialog();

            _LoadPeopleTable();
        }

        private int _GetCellPersonID()
        {
            return Convert.ToInt32(dgvPeople.CurrentRow.Cells[0].Value);
        }

        private bool _DeletePersonImage(string PersonImagePath)
        {
            try
            {
                File.Delete(PersonImagePath);
                return true;
            }
            catch (IOException iox)
            {
                MessageBox.Show($"The image not deleted IOException: {iox}");
                return false;
            }
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frm = new frmShowPersonDetails(_GetCellPersonID());
            _frm.ShowDialog();

            _LoadPeopleTable();
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frm = new frmAddEditPerson();
            _frm.ShowDialog();

            _LoadPeopleTable();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frm = new frmAddEditPerson(_GetCellPersonID());
            _frm.ShowDialog();

            _LoadPeopleTable();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure you want to delete this person with ID [{_GetCellPersonID()}]?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                clsPerson _Person = clsPerson.Find(_GetCellPersonID());
                if (_Person != null)
                {
                    if (_Person.ImagePath != "")
                    {
                        if (!_DeletePersonImage(_Person.ImagePath))
                            MessageBox.Show("Person's Image deleted Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    if (clsPerson.DeletePerson(_Person.PersonID))
                    {
                        _LoadPeopleTable();
                        MessageBox.Show($"Person with ID [{_GetCellPersonID()}] deleted successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Person was not deleted because it has data linked to it!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature not implemented yet!","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature not implemented yet!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnCloseManagePeople_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPeople_DoubleClick(object sender, EventArgs e)
        {
            _frm = new frmShowPersonDetails(_GetCellPersonID());
            _frm.ShowDialog();

            _LoadPeopleTable();
        }
    }

}
