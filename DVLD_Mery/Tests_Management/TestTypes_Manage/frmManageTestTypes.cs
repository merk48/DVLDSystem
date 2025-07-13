using DVLD_Mery_Buisness;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD_Mery
{
    public partial class frmManageTestTypes : Form
    {
        DataTable _dtTestTypes;

        public frmManageTestTypes()
        {
            InitializeComponent();
        }

        private void frmManageTestTypes_Load(object sender, EventArgs e)
        {
            _LoadTestTypesDataTable();

            _DataTableUI();
        }

        private void _LoadTestTypesDataTable()
        {
            _dtTestTypes = clsTestType.GetAllTestTypes();

            dgvTestTypes.DataSource = _dtTestTypes;

            lblTestTypesRecords.Text = dgvTestTypes.Rows.Count.ToString();
        }

        private void _DataTableUI()
        {
            if(dgvTestTypes.Rows.Count > 0)
            {
                dgvTestTypes.Columns[0].HeaderText = "ID";
                dgvTestTypes.Columns[0].Width = 120;

                dgvTestTypes.Columns[1].HeaderText = "Title";
                dgvTestTypes.Columns[1].Width = 200;

                dgvTestTypes.Columns[2].HeaderText = "Description";
                dgvTestTypes.Columns[2].Width = 400;

                dgvTestTypes.Columns[3].HeaderText = "Fees";
                dgvTestTypes.Columns[3].Width = 100;
            }
        }

        private int _GetCellTestTypeID()
        {
            return Convert.ToInt32(dgvTestTypes.CurrentRow.Cells[0].Value);
        }

        private void EditApplicationTypetoolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmEditTestTypes((clsTestType.enTestType)_GetCellTestTypeID());
            frm.ShowDialog();

            _LoadTestTypesDataTable();
        }

        private void btnExitManageTestTpes_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
