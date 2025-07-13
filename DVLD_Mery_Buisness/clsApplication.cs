using System;
using System.Data;
using DVLD_Mery_DataAccess;

namespace DVLD_Mery_Buisness
{
    public class clsApplication
    {
        public enum enMode { AddNew, Update };
        public enMode Mode;
        
        public enum enApplicationStatus { New = 1, Cancelled = 2, Completed = 3 };

        public int ApplicationID { get; set; }
        public int ApplicantPersonID { get; set; }
        public clsPerson ApplicantPersonInfo;
        public DateTime ApplicationDate { get; set; }
        public clsApplicationType.enApplicationType ApplicationTypeID { get; set; }
        public clsApplicationType ApplicationTypeInfo;
        public enApplicationStatus ApplicationStatus { get; set; }
        public DateTime LastStatusDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public clsUser CreatedByUserInfo;


        public clsApplication()
        {
            ApplicationID = -1;
            ApplicantPersonID= -1;
            ApplicationDate = DateTime.Now;
            ApplicationTypeID = clsApplicationType.enApplicationType.NewDrivingLicense;
            ApplicationStatus = enApplicationStatus.New;
            LastStatusDate = DateTime.Now;
             PaidFees = 0;
            CreatedByUserID= -1;

            Mode = enMode.AddNew;
        }

        protected clsApplication(int ApplicationID, int ApplicantPersonID, DateTime ApplicationDate, clsApplicationType.enApplicationType ApplicationTypeID, enApplicationStatus ApplicationStatus, DateTime LastStatusDate, decimal PaidFees, int CreatedByUserID)
        {
            this.ApplicationID = ApplicationID;
            this.ApplicantPersonID = ApplicantPersonID;
            this.ApplicantPersonInfo = clsPerson.Find(this.ApplicantPersonID);
            this.ApplicationDate = ApplicationDate;
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationTypeInfo = clsApplicationType.Find(this.ApplicationTypeID);
            this.ApplicationStatus = ApplicationStatus;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedByUserInfo = clsUser.FindByID(this.CreatedByUserID);

            Mode = enMode.Update;
        }

        static public clsApplication Find(int ApplicationID)
        {
            int ApplicantPersonID = 0, ApplicationTypeID = 0 , CreatedByUserID = 0;
            byte ApplicationStatus = 1;
            decimal PaidFees = 0;
            DateTime ApplicationDate = DateTime.Now, LastStatusDate = DateTime.Now;

            if (clsApplicationData.GetApplicationInfo(ApplicationID, ref ApplicantPersonID, ref ApplicationDate, ref ApplicationTypeID, ref ApplicationStatus, ref LastStatusDate, ref PaidFees, ref CreatedByUserID))
                return new clsApplication(ApplicationID, ApplicantPersonID, ApplicationDate,(clsApplicationType.enApplicationType) ApplicationTypeID, (enApplicationStatus)ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);
            else
                return null;
        }

        private bool _AddNewApplication()
        {
            this.ApplicationID = clsApplicationData.AddNewApplication(this.ApplicantPersonID, this.ApplicationDate,(int) this.ApplicationTypeID, (byte)this.ApplicationStatus, this.LastStatusDate, this.PaidFees, this.CreatedByUserID);
            return (this.ApplicationID != -1);
        }

        private bool _UpdateApplication()
        {
            return clsApplicationData.UpdateApplication(this.ApplicationID, this.ApplicantPersonID, this.ApplicationDate,(int) this.ApplicationTypeID, (byte)this.ApplicationStatus, this.LastStatusDate, this.PaidFees, this.CreatedByUserID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewApplication())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
                case enMode.Update:
                    return _UpdateApplication();
            }
            return false;
        }

        static public bool DeleteApplication(int ApplicationID)
        {
            return clsApplicationData.DeleteApplication(ApplicationID);
        }
/*
        static public DataTable GetApplicationsByPersonID(int ApplicantPersonID)
        {
            return clsApplicationData.GetApplicationsByPersonID(ApplicantPersonID);
        }*/

        static public int GetApplicantID(int ApplicationID)
        {
            return clsApplicationData.GetApplicantID(ApplicationID);
        }

        static public DataTable GetAllApplications()
        {
            return clsApplicationData.GetAllApplications();
        }

        public bool UpdateStatus(enApplicationStatus NewApplicationStatus, DateTime LastStatusDate)
        {
            return clsApplicationData.UpdateStatus(this.ApplicationID, (byte)NewApplicationStatus, LastStatusDate);
        }
        static public bool UpdateStatus(int ApplicationID,enApplicationStatus NewApplicationStatus, DateTime LastStatusDate)
        {
            return clsApplicationData.UpdateStatus(ApplicationID, (byte)NewApplicationStatus, LastStatusDate);
        }
    }
}
