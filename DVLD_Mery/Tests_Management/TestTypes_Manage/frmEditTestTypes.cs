using DVLD_Mery_Buisness;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DVLD_Mery
{
    public partial class frmEditTestTypes : Form
    {
        clsTestType _TestType; clsTestType.enTestType _TestTypeID = clsTestType.enTestType.VisionTest;

        public frmEditTestTypes(clsTestType.enTestType TestTypeID)
        {
            InitializeComponent();

            _TestTypeID = TestTypeID;
        }

        private void frmEditTestTypes_Load(object sender, EventArgs e)
        {
            _LoadTestTypeData();
        }

        private void _LoadTestTypeData()
        {
            _TestType = clsTestType.Find(_TestTypeID);

            if(_TestType != null)
            {
                lblTestTypeID.Text = _TestType.TestTypeID.ToString();
                txtTestTypeitle.Text = _TestType.TestTypeTitle;
                txtTestTypeDescription.Text = _TestType.TestTypeDescription;
                txtTestTypeFees.Text = _TestType.TestTypeFees.ToString();
            }
            else
            {
                MessageBox.Show("TestType not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnSaveUpdateTestTypes_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTestTypeitle.Text.Trim()) || string.IsNullOrEmpty(txtTestTypeDescription.Text.Trim())||string.IsNullOrEmpty(txtTestTypeFees.Text.Trim()))
                if (!this.ValidateChildren())
                {
                    MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            _TestType.TestTypeTitle = txtTestTypeitle.Text;
            _TestType.TestTypeDescription = txtTestTypeDescription.Text;
            _TestType.TestTypeFees = Convert.ToDecimal(txtTestTypeFees.Text);


            if (_TestType.Save())
            {
                MessageBox.Show("Data Saved Successfuly?", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Saved Failed?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void SetError(Control control, bool condition, string errorMessage)
        {
            if (condition)
                errorProvider1.SetError(control, errorMessage);
            else
                errorProvider1.SetError(control, "");
        }

        private void txtTestTypeitle_Validating(object sender, CancelEventArgs e)
        {
            SetError(txtTestTypeitle, string.IsNullOrEmpty(txtTestTypeitle.Text.Trim()), "Title cannot be empty!");
        }

        private void txtTestTypeDescription_Validating(object sender, CancelEventArgs e)
        {
            SetError(txtTestTypeDescription, string.IsNullOrEmpty(txtTestTypeDescription.Text.Trim()), "Description cannot be empty!");
        }

        private void txtTestTypeFees_Validating(object sender, CancelEventArgs e)
        {
            SetError(txtTestTypeFees, string.IsNullOrEmpty(txtTestTypeFees.Text.Trim()), "Fees cannot be empty!");
        }

        private void btnCloseUpdateTestTypes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTestTypeFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
