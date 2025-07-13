using DVLD_Mery_Buisness;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD_Mery
{
    public partial class frmManageApplicationTypes : Form
    {
        DataTable _dtApplicationTypes;
        public frmManageApplicationTypes()
        {
            InitializeComponent();
        }

        private void frmManageApplicationTypes_Load(object sender, EventArgs e)
        {
            _LoadApplicationTypeData();

            _DataTableUI();
        }

        private void _LoadApplicationTypeData()
        {
            _dtApplicationTypes = clsApplicationType.GetAllApplicationTypes();

            dgvApplicationTypes.DataSource = _dtApplicationTypes;

            lblApplicationsTypes.Text = dgvApplicationTypes.Rows.Count.ToString();
        }

        private void _DataTableUI()
        {
            if(dgvApplicationTypes.Rows.Count > 0)
            {
                dgvApplicationTypes.Columns[0].HeaderText = "ID";
                dgvApplicationTypes.Columns[0].Width = 110;

                dgvApplicationTypes.Columns[1].HeaderText = "Title";
                dgvApplicationTypes.Columns[1].Width = 400;

                dgvApplicationTypes.Columns[2].HeaderText = "Fees";
                dgvApplicationTypes.Columns[2].Width = 100;
            }
        }

        private int _GetCellApplicationTypeID()
        {
            return Convert.ToInt32(dgvApplicationTypes.CurrentRow.Cells[0].Value);
        }

        private void EditApplicationTypetoolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmEditApplicationTypes((clsApplicationType.enApplicationType)_GetCellApplicationTypeID());
            frm.ShowDialog();

            _LoadApplicationTypeData();
        }

        private void btnExitManageApplicationTypes_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
