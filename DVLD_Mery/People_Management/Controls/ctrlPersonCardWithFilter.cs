using DVLD_Mery_Buisness;
using System;
using System.Windows.Forms;

namespace DVLD_Mery
{
    public partial class ctrlPersonCardWithFilter : UserControl
    {
        public class PersonSelectedEventsArgs : EventArgs
        {
            public int PersonID { get; set; }

            public PersonSelectedEventsArgs(int personID)
            {
                this.PersonID = personID;
            }
        }

        public event EventHandler<PersonSelectedEventsArgs> OnPersonSelected;

        protected virtual void RaiseOnPersonSelected(PersonSelectedEventsArgs e)
        {
            OnPersonSelected?.Invoke(this, e);
        }

        int _PersonID = -1;

        public ctrlPersonCardWithFilter()
        {
            InitializeComponent();
        }

        private void ctrlPersonCardWithFilter_Load(object sender, EventArgs e)
        {
            cmbFilterPeopleToSelect.SelectedIndex = 1;
            txtPeopleFilterToSelect.Focus();

            ctrlPersonCard1.llEditPerson.Enabled = false;
        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson();

            frm.DataBack += LoadNewPersonInfo_DataBack; // Subscribe to the event

            frm.ShowDialog();
        }

        private void LoadNewPersonInfo_DataBack(Object Sender, int PersonID)
        {
            _PersonID = PersonID;
            txtPeopleFilterToSelect.Text = clsPerson.GetPersonNationalNoByID(_PersonID);
            _RaiseOnPersonSelectedEvent();
        }

        public void LoadPersonInfo( int PersonID)
        {
            _PersonID = PersonID;
            ctrlPersonCard1.LoadPersonInfo(_PersonID);
            txtPeopleFilterToSelect.Text = clsPerson.GetPersonNationalNoByID(_PersonID);
            _RaiseOnPersonSelectedEvent();
        }

        private void cmbFilterPeopleToSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPeopleFilterToSelect.Text = "";
            txtPeopleFilterToSelect.Focus();
        }

        private bool _ValidateInput()
        {
            if (string.IsNullOrEmpty(txtPeopleFilterToSelect.Text))
                if (this.ValidateChildren())
                    return false;

            return true;
        }

        private void btnSearchPerson_Click(object sender, EventArgs e)
        {
            if (!_ValidateInput())
            {
                MessageBox.Show($"Enter {cmbFilterPeopleToSelect.Text} first to search for it!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FindNow();
        }

        private void _FindNow()
        {
            string FilterProperty = cmbFilterPeopleToSelect.Text;

            if (FilterProperty == "PersonID")
            {
                if (int.TryParse(txtPeopleFilterToSelect.Text, out int PersonID))
                {
                    ctrlPersonCard1.LoadPersonInfo(PersonID);
                    _PersonID = clsPerson.IsPersonExists(PersonID) ? PersonID : -1;
                }
            }
            else if (FilterProperty == "NationalNo")
            {
                ctrlPersonCard1.LoadPersonInfo(txtPeopleFilterToSelect.Text);
                _PersonID = clsPerson.GetPersonIDByNationalNo(txtPeopleFilterToSelect.Text);
            }
            ctrlPersonCard1.llEditPerson.Enabled = true;


            _RaiseOnPersonSelectedEvent();

        }

        private void _RaiseOnPersonSelectedEvent()
        {
            if (OnPersonSelected != null)
                RaiseOnPersonSelected(new PersonSelectedEventsArgs(_PersonID)); 
        }

        private void txtPeopleFilterToSelect_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPeopleFilterToSelect.Text.Trim()))
                errorProvider1.SetError(txtPeopleFilterToSelect, "This field is required!");
            else
                errorProvider1.SetError(txtPeopleFilterToSelect, null);
        }

        private void txtPeopleFilterToSelect_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is Enter (character code 13)
            if (e.KeyChar == (char)13)
                btnSearchPerson.PerformClick();

            //this will allow only digits if person id is selected
            if (cmbFilterPeopleToSelect.Text == "PersonID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
