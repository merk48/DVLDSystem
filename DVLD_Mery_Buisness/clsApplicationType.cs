using System.Data;
using DVLD_Mery_DataAccess;

namespace DVLD_Mery_Buisness
{
    public class clsApplicationType
    {
        public enum enApplicationType
        {
            NewDrivingLicense = 1, RenewDrivingLicense = 2, ReplaceLostDrivingLicense = 3,
            ReplaceDamagedDrivingLicense = 4, ReleaseDetainedDrivingLicsense = 5, NewInternationalLicense = 6, RetakeTest = 7
        };

        public enApplicationType ApplicationTypeID { get; set; }
        public string ApplicationTypeTitle { get; set; }
        public decimal ApplicationFees { get; set; }

        public clsApplicationType()
        {
            ApplicationTypeID = enApplicationType.NewDrivingLicense;
            ApplicationTypeTitle = "";
            ApplicationFees = 0;
        }

        private clsApplicationType(enApplicationType ApplicationTypeID,string ApplicationTypeTitle, decimal ApplicationFees)
        {
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationTypeTitle = ApplicationTypeTitle;
            this.ApplicationFees = ApplicationFees;
        }

        static public clsApplicationType Find(enApplicationType ApplicationTypeID)
        {
            string ApplicationTypeTitle = "";
            decimal ApplicationFees = 0;

            if (clsApplicationTypeData.GetApplicationTypeInfo((int)ApplicationTypeID, ref ApplicationTypeTitle,ref ApplicationFees))
                return new clsApplicationType((enApplicationType)ApplicationTypeID, ApplicationTypeTitle, ApplicationFees);
            else
                return null;
        }

        private bool _UpdateApplicationType()
        {
            return clsApplicationTypeData.UpdateApplicationType((int)this.ApplicationTypeID, this.ApplicationTypeTitle, this.ApplicationFees);
        }

        public bool Save()
        {
            return _UpdateApplicationType();
        }

        static public decimal GetApplicationTypeFee(enApplicationType ApplicationTypeID)
        {
            return clsApplicationTypeData.GetApplicationTypeFee((int)ApplicationTypeID);
        }

        static public string GetApplicationTypeTitle(enApplicationType ApplicationTypeID)
        {
            return clsApplicationTypeData.GetApplicationTypeTitle((int)ApplicationTypeID);
        }
        
        static public DataTable GetAllApplicationTypes()
        {
            return clsApplicationTypeData.GetAllApplicationTypes();
        }
    }
}
