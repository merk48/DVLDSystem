using System;
using System.Data;
using DVLD_Mery_DataAccess;

namespace DVLD_Mery_Buisness
{
    public class clsLicense
    {
        public enum enMode { AddNew, Update };
        public enMode Mode = enMode.AddNew;

        public enum enIssueReason { FirstTime = 1, Renew = 2, DamagedReplacement = 3, LostReplacement = 4 };

        public int LicenseID {  get; set; }
        public int ApplicationID {  get; set; }
        public clsApplication ApplicationInfo { get; set; }
        public int DriverID {  get; set; }
        public clsDriver DriverInfo { get; set; }
        public clsLicenseClass.enLicenseClass LicenseClassID {  get; set; }
        public clsLicenseClass LicenseClassInfo;
        public DateTime IssueDate {  get; set; }
        public DateTime ExpirationDate {  get; set; }
        public string Notes {  get; set; } // null
        public decimal PaidFees { get; set; }
        public bool IsActive { get; set; }
        public enIssueReason IssueReason { get; set; }
        public clsDetainLicense DetainInfo { get; set; }
        public int CreatedByUserID {  get; set; }
        public clsUser CreatedByUserInfo { get; set; }
        public bool IsDetained { get { return clsDetainLicense.IsLicenseDetained(this.LicenseID); } set { } }


        public clsLicense()
        {
            LicenseID = -1;
            ApplicationID = -1;
            DriverID = -1;
            LicenseClassID = clsLicenseClass.enLicenseClass.OrdinaryDrivingLicense;
            IssueDate = DateTime.Now;
            ExpirationDate = DateTime.Now;
            Notes = "";
            PaidFees = 0;
            IsActive = false;
            IssueReason = enIssueReason.FirstTime;
            CreatedByUserID = -1;
            Mode = enMode.AddNew;
        }

        private clsLicense(int LicenseID, int ApplicationID, int DriverID, clsLicenseClass.enLicenseClass LicenseClassID, DateTime IssueDate, DateTime ExpirationDate, string Notes, decimal PaidFees, bool IsActive, enIssueReason IssueReason, int CreatedByUserID)
        {
            this.LicenseID = LicenseID;
            this.ApplicationID = ApplicationID;
            this.ApplicationInfo = clsApplication.Find(ApplicationID);
            this.DriverID = DriverID;
            this.DriverInfo = clsDriver.FindByID(DriverID);
            this.LicenseClassID = LicenseClassID;
            this.LicenseClassInfo = clsLicenseClass.Find(LicenseClassID);
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.Notes = Notes;
            this.PaidFees = PaidFees;
            this.IsActive = IsActive;
            this.IssueReason = IssueReason;
            this.DetainInfo = clsDetainLicense.FindByLicenseID(this.LicenseID);
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedByUserInfo = clsUser.FindByID(CreatedByUserID);
            Mode = enMode.Update;
        }

        public static clsLicense Find(int LicenseID)
        {
            int ApplicationID = -1; int DriverID = -1; int LicenseClass = -1;
            DateTime IssueDate = DateTime.Now; DateTime ExpirationDate = DateTime.Now;
            string Notes = "";
            decimal PaidFees = 0; bool IsActive = true; int CreatedByUserID = 1;
            byte IssueReason = 1;

            if (clsLicenseData.GetLicenseInfo(LicenseID, ref ApplicationID, ref DriverID, ref LicenseClass,ref IssueDate, ref ExpirationDate, ref Notes,ref PaidFees, ref IsActive, ref IssueReason, ref CreatedByUserID))

                return new clsLicense(LicenseID, ApplicationID, DriverID, (clsLicenseClass.enLicenseClass)LicenseClass,IssueDate, ExpirationDate, Notes,PaidFees, IsActive, (enIssueReason)IssueReason, CreatedByUserID);
            else
                return null;

        }
        
        static public clsLicense FindByApplicationID(int ApplicationID)
        {
            int LicenseID = -1, DriverID = -1, LicenseClassID = -1, CreatedByUserID = -1;
            string Notes = "";
            DateTime IssueDate = DateTime.Now, ExpirationDate = DateTime.Now;
            decimal PaidFees = 0;
            byte IssueReason = 0;
            bool IsActive = false;

            if (clsLicenseData.GetLicenseInfo(ref LicenseID,  ApplicationID, ref DriverID, ref LicenseClassID, ref IssueDate, ref ExpirationDate, ref Notes, ref PaidFees, ref IsActive, ref IssueReason, ref CreatedByUserID))
                return new clsLicense(LicenseID, ApplicationID, DriverID,(clsLicenseClass.enLicenseClass) LicenseClassID, IssueDate, ExpirationDate, Notes, PaidFees, IsActive,(enIssueReason) IssueReason, CreatedByUserID);
            else
                return null;
        }

        private bool _AddNewLicense()
        {
            this.LicenseID = clsLicenseData.AddNewLicense( this.ApplicationID, this.DriverID,(int) this.LicenseClassID, this.IssueDate, this.ExpirationDate, this.Notes, this.PaidFees, this.IsActive,(byte) this.IssueReason, this.CreatedByUserID);
            return (this.LicenseID != -1);
        }

        private bool _UpdateLicense()
        { 
            return clsLicenseData.UpdateLicense(this.LicenseID, this.ApplicationID, this.DriverID,(int) this.LicenseClassID, this.IssueDate, this.ExpirationDate, this.Notes, this.PaidFees, this.IsActive, (byte)this.IssueReason, this.CreatedByUserID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewLicense())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
                case enMode.Update:
                    return _UpdateLicense();
            }
            return false;
        }

        static public bool DeleteLicense(int ApplicationID)
        {
            return clsLicenseData.DeleteLicense(ApplicationID);
        }

        static public DataTable GetLicensesByDriverID(int DriverID)
        {
            return clsLicenseData.GetLicensesByDriverID(DriverID);
        }
/*
        static public DataTable GetAllLicenses()
        {
            return clsLicenseData.GetAllLicenses();
        }*/

        static public int IsPersonHasLicense(int PersonID, clsLicenseClass.enLicenseClass LicenseClassID)
        {
            return clsLicenseData.IsPersonHasLicense(PersonID, (int)LicenseClassID);
        }

        static public int IsPersonHasActiveLicense(int PersonID, clsLicenseClass.enLicenseClass LicenseClassID)
        {
            return clsLicenseData.IsPersonHasActiveLicense(PersonID,(int) LicenseClassID);
        }

        public bool DeactivateCurrentLicense()
        {
            return clsLicenseData.DeactivateLicense(this.LicenseID);
        }

        public bool ActivateCurrentLicense()
        {
            return clsLicenseData.ActivateCurrentLicense(this.LicenseID);
        }
        
        static  public int GetIssuedLicenseIDByLDLAppID(int LocalDrivingLicenseApplicationID)
        {
            return clsLicenseData.GetIssuedLicenseIDByLDLAppID(LocalDrivingLicenseApplicationID);
        }

        public clsLicense RenewLicense(string Notes, int CreatedByUserID)
        {
            clsApplication _RenewApp = new clsApplication();

            _RenewApp.ApplicantPersonID = this.DriverInfo.PersonID;
            _RenewApp.ApplicationDate = DateTime.Now;
            _RenewApp.ApplicationTypeID = clsApplicationType.enApplicationType.RenewDrivingLicense;
            _RenewApp.ApplicationStatus = clsApplication.enApplicationStatus.Completed;
            _RenewApp.LastStatusDate = DateTime.Now;
            _RenewApp.PaidFees = clsApplicationType.GetApplicationTypeFee(_RenewApp.ApplicationTypeID);
            _RenewApp.CreatedByUserID = CreatedByUserID;

            if (!_RenewApp.Save())
                return null;

            clsLicense _NewLicense = new clsLicense();

            _NewLicense.ApplicationID = _RenewApp.ApplicationID;
            _NewLicense.DriverID = this.DriverID;
            _NewLicense.LicenseClassID = this.LicenseClassID;
            _NewLicense.IssueDate = DateTime.Now;
            _NewLicense.ExpirationDate = DateTime.Now.AddYears(clsLicenseClass.GetLicenseClassValidityLength(_NewLicense.LicenseClassID));
            _NewLicense.Notes = Notes;
            _NewLicense.PaidFees = this.PaidFees;
            _NewLicense.IsActive = true;
            _NewLicense.IssueReason = clsLicense.enIssueReason.Renew;
            _NewLicense.CreatedByUserID = CreatedByUserID;

            if (_NewLicense.Save())
            {
                DeactivateCurrentLicense();
                return _NewLicense;
            }
            else
                return null;

        }

        public clsLicense Replace(clsApplicationType.enApplicationType ApplicationTypeID, int CreatedByUserID)
        {
            clsLicense.enIssueReason IssueReason = ApplicationTypeID == clsApplicationType.enApplicationType.ReplaceDamagedDrivingLicense ? clsLicense.enIssueReason.DamagedReplacement : clsLicense.enIssueReason.LostReplacement;

            clsApplication _ReplacementLicenseApp = new clsApplication();

            _ReplacementLicenseApp.ApplicantPersonID = clsApplication.GetApplicantID(this.ApplicationID);
            _ReplacementLicenseApp.ApplicationDate = DateTime.Now;
            _ReplacementLicenseApp.ApplicationTypeID = ApplicationTypeID;
            _ReplacementLicenseApp.ApplicationStatus = clsApplication.enApplicationStatus.Completed;
            _ReplacementLicenseApp.LastStatusDate = DateTime.Now;
            _ReplacementLicenseApp.PaidFees = clsApplicationType.GetApplicationTypeFee(ApplicationTypeID);
            _ReplacementLicenseApp.CreatedByUserID = CreatedByUserID;

            if (!_ReplacementLicenseApp.Save())
                return null;


            clsLicense _NewLicense = new clsLicense();

            _NewLicense.ApplicationID = _ReplacementLicenseApp.ApplicationID;
            _NewLicense.DriverID = this.DriverID;
            _NewLicense.LicenseClassID = this.LicenseClassID;
            _NewLicense.IssueDate = _ReplacementLicenseApp.ApplicationDate;
            _NewLicense.ExpirationDate = this.ExpirationDate;
            _NewLicense.Notes = this.Notes;
            _NewLicense.PaidFees = 0;//
            _NewLicense.IsActive = true;
            _NewLicense.IssueReason = IssueReason;
            _NewLicense.CreatedByUserID = CreatedByUserID;

            if (_NewLicense.Save())
            {
                DeactivateCurrentLicense();
                return _NewLicense;
            }
            else
                return null;

        }

        public int Detain(decimal FineFees, int CreatedByUserID)
        {
            clsDetainLicense Detain = new clsDetainLicense();

            Detain.LicenseID = this.LicenseID;
            Detain.DetainDate = DateTime.Now;
            Detain.FineFees = FineFees;
            Detain.CreatedByUserID = CreatedByUserID;

             this.IsDetained = true;

            if (Detain.Save())
            {
                DeactivateCurrentLicense();

                return Detain.DetainID;
            }
            else
                return -1;
        }

        public bool ReleaseDetainedLicense(int ReleasedByUserID, ref int ApplicationID)
        {
            clsApplication ReleaseDetainedLicenseApp = new clsApplication();

            ReleaseDetainedLicenseApp.ApplicantPersonID = this.DriverInfo.PersonID;
            ReleaseDetainedLicenseApp.ApplicationDate = DateTime.Now;
            ReleaseDetainedLicenseApp.ApplicationTypeID = clsApplicationType.enApplicationType.ReleaseDetainedDrivingLicsense;
            ReleaseDetainedLicenseApp.ApplicationStatus = clsApplication.enApplicationStatus.Completed;
            ReleaseDetainedLicenseApp.LastStatusDate = DateTime.Now;
            ReleaseDetainedLicenseApp.PaidFees = clsApplicationType.GetApplicationTypeFee(clsApplicationType.enApplicationType.ReleaseDetainedDrivingLicsense);
            ReleaseDetainedLicenseApp.CreatedByUserID = ReleasedByUserID;

            if (!ReleaseDetainedLicenseApp.Save())
                return false;

            ActivateCurrentLicense();

            ApplicationID = ReleaseDetainedLicenseApp.ApplicationID;

            return this.DetainInfo.ReleaseDetainedLicense(ReleasedByUserID, ReleaseDetainedLicenseApp.ApplicationID);
            //return clsDetainLicense.FindByLicenseID(this.LicenseID).ReleaseDetainedLicense(ReleasedByUserID, ReleaseDetainedLicenseApp.ApplicationID);

        }
    }
}
