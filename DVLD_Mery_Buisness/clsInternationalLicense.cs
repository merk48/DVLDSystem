using System;
using System.Data;
using DVLD_Mery_DataAccess;

namespace DVLD_Mery_Buisness
{
    public class clsInternationalLicense : clsApplication
    {
        public enum enMode { AddNew, Update };
        public enMode Mode;


        public int InternationalLicenseID  { get; set; }
        public int DriverID { get; set; }
        public clsDriver DriverInfo { get; set; }
        public int IssuedUsingLocalLicenseID { get; set; }
        public clsLicense IssuedUsingLocalLicenseInfo { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }
       

        public clsInternationalLicense()
        {
            InternationalLicenseID = -1;
            DriverID = -1;
            IssuedUsingLocalLicenseID = -1;
            IssueDate = DateTime.Now;
            ExpirationDate = DateTime.Now;
            IsActive = false;

            Mode = enMode.AddNew;
        }

        private clsInternationalLicense(int InternationalLicenseID, int ApplicationID, int DriverID, int IssuedUsingLocalLicenseID, DateTime IssueDate, DateTime ExpirationDate, bool IsActive
            , int ApplicantPersonID, DateTime ApplicationDate, clsApplicationType.enApplicationType ApplicationTypeID, enApplicationStatus ApplicationStatus, DateTime LastStatusDate, decimal PaidFees, int CreatedByUserID)
            : base(ApplicationID, ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID)
        {
            this.InternationalLicenseID = InternationalLicenseID ;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID ;
            this.DriverInfo = clsDriver.FindByID(DriverID);
            this.IssuedUsingLocalLicenseID = IssuedUsingLocalLicenseID ;
            this.IssuedUsingLocalLicenseInfo = clsLicense.Find(IssuedUsingLocalLicenseID);
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.IsActive = IsActive ;

            Mode = enMode.Update;
        }

        static public clsInternationalLicense FindByID(int InternationalLicenseID )
        {
            int ApplicationID = -1, DriverID = -1, IssuedUsingLocalLicenseID = -1, CreatedByUserID = -1;
            DateTime IssueDate = DateTime.Now, ExpirationDate = DateTime.Now;
            bool IsActive = false;

            if (clsInternationalLicenseData.GetInternationalLicenseInfo(InternationalLicenseID, ref ApplicationID, ref DriverID, ref IssuedUsingLocalLicenseID, ref IssueDate, ref ExpirationDate, ref IsActive, ref CreatedByUserID))
            {
                clsApplication Application = clsApplication.Find(ApplicationID);
                if (Application != null)
                    return new clsInternationalLicense(InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, Application.ApplicantPersonID, Application.ApplicationDate, Application.ApplicationTypeID, Application.ApplicationStatus, Application.LastStatusDate, Application.PaidFees, Application.CreatedByUserID);
                else
                    return null;
            }
            else
                return null;
        }

        private bool _AddNewInternationalLicense()
        {
            this.InternationalLicenseID = clsInternationalLicenseData.AddNewInternationalLicense(this.ApplicationID, this.DriverID, this.IssuedUsingLocalLicenseID, this.IssueDate, this.ExpirationDate, this.IsActive, this.CreatedByUserID);
            return (this.InternationalLicenseID != -1);
        }

        private bool _UpdateInternationalLicense()
        {
            return clsInternationalLicenseData.UpdateInternationalLicense(this.InternationalLicenseID, this.ApplicationID, this.DriverID, this.IssuedUsingLocalLicenseID, this.IssueDate, this.ExpirationDate, this.IsActive, this.CreatedByUserID);
        }

        public bool Save()
        {
            base.Mode = (clsApplication.enMode)this.Mode;
            if (!base.Save())
                return false;

            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewInternationalLicense())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
                case enMode.Update:
                    return _UpdateInternationalLicense();
            }
            return false;
        }

        static public bool DeleteInternationalLicense(int InternationalLicenseID)
        {
            return clsInternationalLicenseData.DeleteInternationalLicense(InternationalLicenseID);
        }

        static public DataTable GetAllInternationalLicenses()
        {
            return clsInternationalLicenseData.GetAllInternationalLicenses();
        }

        static public DataTable GetAllInternationalLicensesBtDriverID(int DriverID)
        {
            return clsInternationalLicenseData.GetAllInternationalLicensesBtDriverID(DriverID);
        }
/*
        static public int GetApplicationIDByIntLicenseID(int InternationalLicenseID)
        {
            return clsInternationalLicenseData.GetApplicationIDByIntLicenseID(InternationalLicenseID);
        }
       */
        public static int GetActiveInternationalLicenseIDByDriverID(int DriverID)
        {

            return clsInternationalLicenseData.GetActiveInternationalLicenseIDByDriverID(DriverID);

        }
        // or isExists// delete this if not htere a case to renew the international license
        static public bool IsThisInternationalLicense(int LicenseID)
        {
            return clsInternationalLicenseData.IsThisInternationalLicense(LicenseID);
        }
    }
    
}
