using System;
using System.Data;
using DVLD_Mery_DataAccess;


namespace DVLD_Mery_Buisness
{
    public class clsDriver
    {
        public enum enMode { AddNew, Update }
        public enMode Mode;

        public int DriverID { get; set; }
        public int PersonID { get; set; }
        public clsPerson PersonInfo { get; set; }
        public int CreatedByUserID { get; set; }
        public clsUser CreatedByUserInfo { get; set; }
        public DateTime CreatedDate { get; set; }


        public clsDriver()
        {
            DriverID = -1;
            PersonID = -1;
            CreatedByUserID = -1;
            CreatedDate = DateTime.Now;
            Mode = enMode.AddNew;
        }

        private clsDriver(int DriverID, int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {
            this.DriverID = DriverID;
            this.PersonID = PersonID;
            this.PersonInfo = clsPerson.Find(PersonID);
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedByUserInfo = clsUser.FindByID(CreatedByUserID);
            this.CreatedDate = CreatedDate;
            Mode = enMode.Update;
        }

        static public clsDriver FindByID(int DriverID)
        {
            int PersonID = -1, CreatedByUserID = -1;
            DateTime CreatedDate = DateTime.Now;

            if(clsDriverData.GetDriverInfo(DriverID, ref PersonID, ref CreatedByUserID, ref CreatedDate))
                return new clsDriver(DriverID, PersonID, CreatedByUserID, CreatedDate);
            else
                return null;
        }

        static public clsDriver FindByPersonID(int PersonID)
        {
            int DriverID = -1, CreatedByUserID = -1;
            DateTime CreatedDate = DateTime.Now;

            if (clsDriverData.GetDriverInfo(ref DriverID,  PersonID, ref CreatedByUserID, ref CreatedDate))
                return new clsDriver(DriverID, PersonID, CreatedByUserID, CreatedDate);
            else
                return null;
        }

        private bool _AddNewDriver()
        {
            this.DriverID = clsDriverData.AddNewDriver(this.PersonID, this.CreatedByUserID, this.CreatedDate);
            return (DriverID != -1);
        }

        private bool _UpdateDriver()
        {
            return clsDriverData.UpdateDriver(this.DriverID, this.PersonID, this.CreatedByUserID, this.CreatedDate);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewDriver())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
                case enMode.Update:
                    return _UpdateDriver();
            }
            return false;
        }

        /*static public bool DeleteDriverByID(int UserID)
        {
            return clsDriverData.DeleteDriverByID(UserID);
        }*/

       /* static public bool IsDriverExists(int DriverID)
        {
            return clsDriverData.IsDriverExists(DriverID);
        }*/

      /*  static public bool IsPersonADriver(int PersonID)
        {
            return DriverData.IsPersonADriver(PersonID);
        }
*/
        static public DataTable GetAllDrivers()
        {
            return clsDriverData.GetAllDrivers();
        }
    }
}
