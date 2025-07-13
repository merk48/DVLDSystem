using System;
using System.Data;
using DVLD_Mery_DataAccess;

namespace DVLD_Mery_Buisness
{
    public class clsDetainLicense
    {
        public enum enMode { AddNew, Update };
        public enMode Mode = enMode.AddNew;

        public int DetainID { get; set; }
        public int LicenseID { get; set; }
       // public clsLicense LicenseInfo { get; set; }
        public DateTime DetainDate { get; set; }
        public decimal FineFees { get; set; }
        public int CreatedByUserID { get; set; }
        public clsUser CreatedByUserInfo { get; set; }
        public bool IsReleased { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int ReleasedByUserID { get; set; }
        public clsUser ReleasedByUserInfo { get; set; }
        public int ReleaseApplicationID { get; set; }
        public clsApplication ReleaseApplicationInfo { get; set; }


        public clsDetainLicense()
        {
            DetainID = - 1;
            LicenseID = -1;
            DetainDate = DateTime.Now;
            FineFees = 0;
            CreatedByUserID = -1;
            IsReleased = false;
            ReleaseDate = DateTime.MaxValue; 
            ReleasedByUserID = -1;
            ReleaseApplicationID = -1;

            Mode = enMode.AddNew;
        }

        private clsDetainLicense(int DetainID, int LicenseID, DateTime DetainDate, decimal FineFees, int CreatedByUserID, bool IsReleased, DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)
        {
            this.DetainID = DetainID;
            this.LicenseID = LicenseID;
            //this.LicenseInfo = clsLicense.Find(LicenseID);
            this.DetainDate = DetainDate;
            this.FineFees = FineFees;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedByUserInfo = clsUser.FindByID(CreatedByUserID);
            this.IsReleased = IsReleased ;
            this.ReleaseDate = ReleaseDate ;
            this.ReleasedByUserID = ReleasedByUserID;
            this.ReleasedByUserInfo = clsUser.FindByID(ReleasedByUserID);
            this.ReleaseApplicationID = ReleaseApplicationID ;

            Mode = enMode.Update;
        }

        static public clsDetainLicense FindByID(int DetainID)
        {
            int LicenseID = -1, CreatedByUserID = -1, ReleasedByUserID = -1, ReleaseApplicationID = -1;
            DateTime DetainDate = DateTime.Now, ReleaseDate = DateTime.Now;
            decimal FineFees = 0;
            bool IsReleased = false;

            if (clsDetaineLicenseData.GetDetainInfo(DetainID, ref LicenseID, ref DetainDate, ref FineFees, ref CreatedByUserID, ref IsReleased, ref ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationID))
                return new clsDetainLicense(DetainID,  LicenseID,  DetainDate,  FineFees,  CreatedByUserID,  IsReleased,  ReleaseDate,  ReleasedByUserID,  ReleaseApplicationID);
            else
                return null;
        }

        static public clsDetainLicense FindByLicenseID(int LicenseID )
        {
            int DetainID = -1, CreatedByUserID = -1, ReleasedByUserID = -1, ReleaseApplicationID = -1;
            DateTime DetainDate = DateTime.Now, ReleaseDate = DateTime.Now;
            decimal FineFees = 0;
            bool IsReleased = false;

            if (clsDetaineLicenseData.GetDetainInfo(ref DetainID,  LicenseID, ref DetainDate, ref FineFees, ref CreatedByUserID, ref IsReleased, ref ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationID))
                return new clsDetainLicense(DetainID, LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
            else
                return null;
        }
        
        private bool _AddNewDetainedLicense()
        {
            this.DetainID = clsDetaineLicenseData.AddNewDetain(
               this.LicenseID, this.DetainDate, this.FineFees, this.CreatedByUserID);

            return (this.DetainID != -1);
        }

        private bool _UpdateDetainedLicense()
        {
            return clsDetaineLicenseData.UpdateDetaine(this.DetainID, this.LicenseID, this.DetainDate, this.FineFees, this.CreatedByUserID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewDetainedLicense())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateDetainedLicense();

            }

            return false;

        }

        static public bool DeleteDetainedLicense(int DetainID)
        {
            return clsDetaineLicenseData.DeleteDetain(DetainID);
        }

        static public DataTable GetAllDetainedLicenses()
        {
            return clsDetaineLicenseData.GetAllDetains();
        }

        static public bool IsLicenseDetained(int LicenseID)
        {
            return clsDetaineLicenseData.IsLicenseDetained(LicenseID);
        }

        static public int GetDetaineID(int LicenseID)
        {
            return clsDetaineLicenseData.GetDetaineID(LicenseID);
        }

        public bool ReleaseDetainedLicense( int ReleasedByUserID, int ReleaseApplicationID)
        {
            return clsDetaineLicenseData.ReleaseDetainedLicense(DetainID, ReleasedByUserID, ReleaseApplicationID);
        }
        
    }
}
