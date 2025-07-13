using DVLD_Mery_Buisness;
using System;
using System.Windows.Forms;

namespace DVLD_Mery
{
    public partial class frmEditApplicationTypes : Form
    {
        clsApplicationType _ApplicationType; clsApplicationType.enApplicationType _ApplicationTypeID = clsApplicationType.enApplicationType.NewDrivingLicense;

        public frmEditApplicationTypes(clsApplicationType.enApplicationType ApplicationTypeID)
        {
            _ApplicationTypeID = ApplicationTypeID;

            InitializeComponent();
        }

        private void frmEditApplicationTypes_Load(object sender, EventArgs e)
        {
            _LoadApplicationTypeInfo();
        }

        private void _LoadApplicationTypeInfo()
        {
            _ApplicationType = clsApplicationType.Find(_ApplicationTypeID);

            if (_ApplicationType != null)
            {
                lblApplicationTypeID.Text = _ApplicationType.ApplicationTypeID.ToString();
                txtApplicationTypeTitle.Text = _ApplicationType.ApplicationTypeTitle;
                txtApplicationTypeFees.Text = _ApplicationType.ApplicationFees.ToString();
            }
            else
            {
                MessageBox.Show("ApplicationTyoe not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnSaveApplicationTypes_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtApplicationTypeFees.Text.Trim()) || string.IsNullOrEmpty(txtApplicationTypeTitle.Text.Trim()))
                if (!this.ValidateChildren())
                {
                    MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            _ApplicationType.ApplicationTypeTitle = txtApplicationTypeTitle.Text;
            _ApplicationType.ApplicationFees = Convert.ToDecimal(txtApplicationTypeFees.Text);

            if (_ApplicationType.Save())
            {
                MessageBox.Show("Data Saved Successfuly?", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Saved Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCloseApplicationTypes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetError(Control control, bool condition, string errorMessage)
        {
            if (condition)
                errorProvider1.SetError(control, errorMessage);
            else
                errorProvider1.SetError(control, "");
        }

        private void txtApplicationTypeTitle_Validating(object sender, EventArgs e)
        {
            SetError(txtApplicationTypeTitle, string.IsNullOrEmpty(txtApplicationTypeTitle.Text.Trim()), "Title cannot be empty!");
        }

        private void txtApplicationTypeFees_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
             SetError(txtApplicationTypeFees, string.IsNullOrEmpty(txtApplicationTypeFees.Text.Trim()), "Fees cannot be empty!");
        }

        private void txtApplicationTypeFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
