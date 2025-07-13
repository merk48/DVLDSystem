using System;
using System.Data;
using DVLD_Mery_DataAccess;

namespace DVLD_Mery_Buisness
{
    public class clsLocalDrivingLicenseApplication : clsApplication
    {
        public enum enMode { AddNew, Update };
        public enMode Mode;

        public int LocalDrivingLicenseApplicationID { get; set; }
        public clsLicenseClass.enLicenseClass LicenseClassID { get; set; }
        public clsLicenseClass LicenseClassInfo { get; set; }

        public clsLocalDrivingLicenseApplication()
        {
            LocalDrivingLicenseApplicationID = -1;
            LicenseClassID = clsLicenseClass.enLicenseClass.OrdinaryDrivingLicense;

            Mode = enMode.AddNew;
        }

        private clsLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID, int ApplicationID, clsLicenseClass.enLicenseClass LicenseClassID
            , int ApplicantPersonID, DateTime ApplicationDate, clsApplicationType.enApplicationType ApplicationTypeID, enApplicationStatus ApplicationStatus, DateTime LastStatusDate, decimal PaidFees, int CreatedByUserID)
           : base(ApplicationID, ApplicantPersonID,  ApplicationDate,  ApplicationTypeID,  ApplicationStatus,  LastStatusDate,  PaidFees,  CreatedByUserID)
        {
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.LicenseClassID = LicenseClassID;
            this.LicenseClassInfo = clsLicenseClass.Find(this.LicenseClassID);
/*
            this.ApplicationID = ApplicationID;
            this.ApplicantPersonID = ApplicantPersonID;
            this.ApplicationDate = ApplicationDate;
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationStatus = enApplicationStatus.New;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;*/

            Mode = enMode.Update;
        }

        static public clsLocalDrivingLicenseApplication FindByID(int LocalDrivingLicenseApplicationID)
        {
            int ApplicationID = -1, LicenseClassID = 3;

            if (clsLocalDrivingLicenseApplicationData.GetLocalDrivingLicenseApplicationInfo(LocalDrivingLicenseApplicationID, ref ApplicationID, ref LicenseClassID))
            {
                clsApplication Application = clsApplication.Find(ApplicationID);
                if (Application != null)
                    return new clsLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID, ApplicationID,(clsLicenseClass.enLicenseClass) LicenseClassID, Application.ApplicantPersonID, Application.ApplicationDate, Application.ApplicationTypeID, Application.ApplicationStatus, Application.LastStatusDate, Application.PaidFees, Application.CreatedByUserID);
                else
                    return null;
            }
            else
                return null;
        }

        static public clsLocalDrivingLicenseApplication FindByApplicationID(int ApplicationID)
        {
            int LocalDrivingLicenseApplicationID = -1, LicenseClassID = -1;

            if (clsLocalDrivingLicenseApplicationData.GetLocalDrivingLicenseApplicationInfo(ref LocalDrivingLicenseApplicationID, ApplicationID, ref LicenseClassID))
            {
                clsApplication Application = clsApplication.Find(ApplicationID);
                if (Application != null)
                    return new clsLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID, ApplicationID, (clsLicenseClass.enLicenseClass)LicenseClassID, Application.ApplicantPersonID, Application.ApplicationDate, Application.ApplicationTypeID, Application.ApplicationStatus, Application.LastStatusDate, Application.PaidFees, Application.CreatedByUserID);
                else
                    return null;
            }
            else
                return null;
        }

        private bool _AddNewLocalDrivingLicenseApplication()
        {
            this.LocalDrivingLicenseApplicationID = clsLocalDrivingLicenseApplicationData.AddNewLocalDrivingLicenseApplication( this.ApplicationID,(int) this.LicenseClassID);
            return (this.LocalDrivingLicenseApplicationID != -1);
        }

        private bool _UpdateLocalDrivingLicenseApplication()
        {
            return clsLocalDrivingLicenseApplicationData.UpdateLocalDrivingLicenseApplication(this.LocalDrivingLicenseApplicationID, this.ApplicationID, (int)this.LicenseClassID);
        }

        public bool Save()
        {
            base.Mode = (clsApplication.enMode) this.Mode;
            if (!base.Save())
                return false;

            switch (this.Mode)
            {
                case enMode.AddNew:
                    if (_AddNewLocalDrivingLicenseApplication())
                    {
                        this.Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
                case enMode.Update:
                    return _UpdateLocalDrivingLicenseApplication();
            }
           
            return false;
        }

        static public bool DeleteLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID)
        {  
            return clsLocalDrivingLicenseApplicationData.DeleteLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID);
        }

        static public DataTable GetAllLocalDrivingLicenseApplications()
        {
            return clsLocalDrivingLicenseApplicationData.GetAllLocalDrivingLicenseApplications();
        }

        static public int IsPersonHasActiveApplication(string NationalNo, string ClassName)
        {
            return clsLocalDrivingLicenseApplicationData.IsPersonHasActiveApplication( NationalNo, ClassName);
        }
   
        static public int GetApplicationIDByLDLAppID(int LocalDrivingLicenseApplicationID)
        {
            return clsLocalDrivingLicenseApplicationData.GetApplicationIDByLDLicenseID(LocalDrivingLicenseApplicationID);
        }


        static public int GetPassedTestsCount(int LocalDrivingLicenseApplicationID)
        {
            return clsLocalDrivingLicenseApplicationData.GetPassedTestsCount(LocalDrivingLicenseApplicationID);
        }

        public int IssueLicenseForTheFirtTime(string Notes, int CreatedByUserID)
        {
            clsDriver Driver = clsDriver.FindByPersonID(this.ApplicantPersonID);

            if (Driver == null)
            {
                Driver = new clsDriver();

                Driver.PersonID = this.ApplicantPersonID;
                Driver.CreatedByUserID = CreatedByUserID;
                Driver.CreatedDate = DateTime.Now;

                if (!Driver.Save())
                    return -1;
            }

            /*if (Driver == null)
            {
                Driver = new clsDriver();

                Driver.PersonID = this.ApplicantPersonID;
                Driver.CreatedByUserID = CreatedByUserID;
                Driver.CreatedDate = DateTime.Now;

                if (Driver.Save())
                    DriverID = Driver.DriverID;
                else
                    return -1;
            }
            else
                DriverID = Driver.DriverID;*/
            clsLicense License = new clsLicense();

            License.ApplicationID = this.ApplicationID;
            License.DriverID = Driver.DriverID;
            License.LicenseClassID = this.LicenseClassID;
            License.IssueDate = DateTime.Now;
            License.ExpirationDate = DateTime.Now.AddYears(this.LicenseClassInfo.DefaultValidityLength);
            License.Notes = Notes;
            License.IsActive = true;
            License.PaidFees = this.LicenseClassInfo.ClassFees;
            License.IssueReason = clsLicense.enIssueReason.FirstTime;
            License.CreatedByUserID = CreatedByUserID;

            if (License.Save())
            {
                if (clsApplication.UpdateStatus(this.ApplicationID, clsApplication.enApplicationStatus.Completed, DateTime.Now))
                    return License.LicenseID;
                else
                    return -1; // AppStatus not updated
            }
            else
                return -1; // license not saved
        }

        public int GetActiveLicenseID()
        {
            return clsLicense.IsPersonHasActiveLicense(this.ApplicantPersonID, this.LicenseClassID);
        }
    }
}
