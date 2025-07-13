using System;
using System.Windows.Forms;

namespace DVLD_Mery
{
    public partial class frmShowPersonDetails : Form
    {
        public frmShowPersonDetails(int PersonID)
        {
            InitializeComponent();

            ctrlPersonCard1.LoadPersonInfo(PersonID);
        }

        public frmShowPersonDetails(string NationalNo)
        {
            InitializeComponent();

            ctrlPersonCard1.LoadPersonInfo(NationalNo);
        }

        private void btnExitPersonDetailsCard_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
