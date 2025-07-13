using DVLD_Mery_Buisness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Mery
{
    public partial class ctrlDriverInternationalLicenseCard : UserControl
    {

        int _AppID;

        clsLicense _License;
        clsPerson _Person;

        clsInternationalLicense _IntLicense;

        public ctrlDriverInternationalLicenseCard()
        {
            InitializeComponent();
        }

        public void LoadLicenseInfo(int IntAppID)
        {

            _IntLicense = clsInternationalLicense.FindByID(IntAppID);

            if (_IntLicense != null)
            {
                _License = clsLicense.Find(_IntLicense.IssuedUsingLocalLicenseID);

                if (_License != null)
                {
                    _Person = clsPerson.Find(clsApplication.GetApplicantID(_License.ApplicationID));

                    if (_Person != null)
                    {
                        lblIntLicensePersonName.Text = _Person.FullName.ToString(); ;
                        lblIntLicenseID.Text = _IntLicense.InternationalLicenseID.ToString();
                        lblLicenseID.Text = _License.LicenseID.ToString();
                        lblIntLicensePersonNationalNo.Text = _Person.NationalNo;
                        lblIntLicensePersonGender.Text = _Person.Gender == 0 ? "Male" : "Female"; // later will be handled by enum
                        lblIntLicenseIssueDate.Text = _License.IssueDate.ToString();
                        lblIntAppID.Text = _License.ApplicationID.ToString();
                        lblIntLicenseIsActive.Text = _License.IsActive ? "Yes" : "No";
                        lblIntLicensePersonDateOfBirth.Text = _Person.DateOfBirth.ToString();
                        lblIntLicenseDriverID.Text = _License.DriverID.ToString();
                        lblIntLicenseExpirationDate.Text = _License.ExpirationDate.ToString();
                        pbIntLicensePersonImage.ImageLocation = _Person.ImagePath;
                    }
                    else MessageBox.Show("Person Not found");
                }
                else MessageBox.Show("License Not found");
            }
            else MessageBox.Show("_IntLicense Not found");
        }

    }
}
