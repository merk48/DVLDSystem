using System;
using System.Data;
using DVLD_Mery_DataAccess;

namespace DVLD_Mery_Buisness
{
    public class clsTestAppointment
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int TestAppointmentID { get; set; }
        public clsTestType.enTestType TestTypeID { get; set; }
        public int LocalDrivingLicenseApplicationID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsLocked { get; set; }
        public int RetakeTestApplicationID { get; set; }
        public clsApplication RetakeTestAppInfo { set; get; }
        public int TestID
        {
            get { return _GetTestID(); }

        }

        public clsTestAppointment()
        {
            TestAppointmentID = -1;
            TestTypeID = clsTestType.enTestType.VisionTest;
            LocalDrivingLicenseApplicationID = -1;
            AppointmentDate = DateTime.Now;
            PaidFees = 0;
            CreatedByUserID = -1;
            IsLocked = false;
            RetakeTestApplicationID = -1;

            Mode = enMode.AddNew;
        }

        private  clsTestAppointment(int TestAppointmentID, clsTestType.enTestType TestTypeID, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, decimal PaidFees, int CreatedByUserID, bool IsLocked, int RetakeTestApplicationID)
        {
            this.TestAppointmentID = TestAppointmentID;
            this.TestTypeID = TestTypeID;
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.AppointmentDate = AppointmentDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsLocked = IsLocked;
            this.RetakeTestApplicationID = RetakeTestApplicationID;
            RetakeTestAppInfo = clsApplication.Find(RetakeTestApplicationID);

            Mode = enMode.Update;
        }

        static public clsTestAppointment Find(int TestAppointmentID)
        {
            int TestTypeID = 1;
            int LocalDrivingLicenseApplicationID = -1, CreatedByUserID = -1, RetakeTestApplicationID = -1;
            DateTime AppointmentDate = DateTime.Now;
            decimal PaidFees = 0;
            bool IsLocked = false;

            if (clsTestAppointmentData.GetTestAppointmentInfo(TestAppointmentID, ref TestTypeID, ref LocalDrivingLicenseApplicationID, ref AppointmentDate, ref PaidFees, ref CreatedByUserID, ref IsLocked, ref RetakeTestApplicationID))
                return new clsTestAppointment(TestAppointmentID,  (clsTestType.enTestType)TestTypeID,  LocalDrivingLicenseApplicationID,  AppointmentDate,  PaidFees,  CreatedByUserID,  IsLocked,  RetakeTestApplicationID);
            else 
                return null;
        }

        private bool _AddNewTestAppointment()
        {
            this.TestAppointmentID = clsTestAppointmentData.AddNewTestAppointment((int)this.TestTypeID, this.LocalDrivingLicenseApplicationID,
                this.AppointmentDate, this.PaidFees, this.CreatedByUserID, this.IsLocked, this.RetakeTestApplicationID);

            return (this.TestAppointmentID != -1);
        }

        private bool _UpdateTestAppointment()
        {
            return clsTestAppointmentData.UpdateTestAppointment(this.TestAppointmentID, (int)this.TestTypeID, this.LocalDrivingLicenseApplicationID,
                this.AppointmentDate, this.PaidFees, this.CreatedByUserID, this.IsLocked, this.RetakeTestApplicationID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTestAppointment())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:

                    return _UpdateTestAppointment();
            }

            return false;
        }

        public static DataTable GetAllAppointmentsByTestTypeAndLDLAppID(clsTestType.enTestType TestTypeID,int LocalDrivingLicenseApplicationID)
        {
            return clsTestAppointmentData.GetAllAppointmentsByTestTypeAndLDLAppID((int)TestTypeID,  LocalDrivingLicenseApplicationID);
        }

        static public bool IfThereAnOpenAppointment(clsTestType.enTestType TestTypeID, int LocalDrivingLicenseApplicationID)
        {
            return clsTestAppointmentData.IfThereAnOpenAppointment((int)TestTypeID, LocalDrivingLicenseApplicationID);
        }

        static public bool IfThereAFailedLockedTestAppointment(clsTestType.enTestType TestTypeID, int LocalDrivingLicenseApplicationID)
        {
            return clsTestAppointmentData.IfThereAFailedLockedTestAppointment((int)TestTypeID, LocalDrivingLicenseApplicationID);
        }

        static public bool IfThereAPassedLockedTestAppointment(clsTestType.enTestType TestTypeID, int LocalDrivingLicenseApplicationID)
        {
            return clsTestAppointmentData.IfThereAPassedLockedTestAppointment((int)TestTypeID, LocalDrivingLicenseApplicationID);
        }

        static public DateTime GetLastTestAppointmentDate(clsTestType.enTestType TestTypeID, int LocalDrivingLicenseApplicationID)
        {
            return clsTestAppointmentData.GetLastTestAppointmentDate((int)TestTypeID, LocalDrivingLicenseApplicationID);
        }

        static public DateTime GetTestAppointmentDate(int TestAppointmentID)
        {
            return clsTestAppointmentData.GetTestAppointmentDate(TestAppointmentID);
        }

        static public int CountTrials(clsTestType.enTestType TestTypeID, int LocalDrivingLicenseApplicationID)
        {
            return clsTestAppointmentData.CountTrials((int)TestTypeID, LocalDrivingLicenseApplicationID);
        }

        static public bool isLocked(int TestAppointmentID)
        {
            return clsTestAppointmentData.isLocked(TestAppointmentID);

        }
        /*static public bool isPassedTest(clsTestType.enTestType TestTypeID, int LocalDrivingLicenseApplicationID)
        {
            return clsTestAppointmentData.isPassedTest((int)TestTypeID, LocalDrivingLicenseApplicationID);

        }*/
        private int _GetTestID()
        {
            return clsTestAppointmentData.GetTestID(TestAppointmentID);
        }

        /*static public bool isThereATakenTest(clsTestType.enTestType TestTypeID, int TestAppointmentID)
        {
            return clsTestAppointmentData.isThereATakenTest((int)TestTypeID, TestAppointmentID);

        }*/
    }
}
