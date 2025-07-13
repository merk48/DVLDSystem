using System.Data;
using DVLD_Mery_DataAccess;

namespace DVLD_Mery_Buisness
{
    public class clsLicenseClass
    {
        public enum enLicenseClass
        {
            SmallMotorcycleLicense = 1, HeavyMotorcycleLicense = 2, OrdinaryDrivingLicense = 3, CommercialLicense = 4,
            AgriculturalLicense = 5, SmallMediumBusLicense = 6, TruckandHeavyVehicle
        }

        public enLicenseClass LicenseClassID { get; set; }
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
        public byte MinimumAllowedAge { get; set; }
        public byte DefaultValidityLength { get; set; }
        public decimal ClassFees { get; set; }


        public clsLicenseClass()
        {
            LicenseClassID = enLicenseClass.OrdinaryDrivingLicense;
            ClassName = "";
            ClassDescription = "";
            MinimumAllowedAge = 0;
            DefaultValidityLength = 0;
            ClassFees = 0;

        }

        private clsLicenseClass(enLicenseClass LicenseClassID, string ClassName, string ClassDescription, byte MinimumAllowedAge, byte DefaultValidityLength, decimal ClassFees) { 
            
            this.LicenseClassID = LicenseClassID;
            this.ClassName = ClassName;
            this.ClassDescription = ClassDescription;
            this.MinimumAllowedAge = MinimumAllowedAge;
            this.DefaultValidityLength = DefaultValidityLength;
            this.ClassFees = ClassFees;

        }

        static public clsLicenseClass Find(enLicenseClass LicenseClassID)
        {
            string ClassName = "", ClassDescription = "";
            byte MinimumAllowedAge = 0, DefaultValidityLength = 0;
            decimal ClassFees = 0;

            if (clsLicenseClassData.GetLicenseClassInfo((int)LicenseClassID, ref ClassName, ref ClassDescription,ref MinimumAllowedAge, ref DefaultValidityLength, ref ClassFees))
                return new clsLicenseClass(LicenseClassID, ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees);
            else
                return null;
        }

        static public DataTable GetAllLicenseClasss()
        {
            return clsLicenseClassData.GetAllLicenseClasss();
        }

        static public byte GetLicenseClassValidityLength(clsLicenseClass.enLicenseClass LicenseClassID)
        {
            return clsLicenseClassData.GetLicenseClassValidityLength((int)LicenseClassID);
        }

        static public string GetLicenseClassNameByID(clsLicenseClass.enLicenseClass LicenseClassID)
        {
            return clsLicenseClassData.GetLicenseClassNameByID((int)LicenseClassID);
        }

        static public decimal GetLicenseClassPaidFees(clsLicenseClass.enLicenseClass LicenseClassID)
        {
            return clsLicenseClassData.GetLicenseClassPaidFees((int)LicenseClassID);
        }

        static public byte GetLicenseClassMinimumAllowedAge(clsLicenseClass.enLicenseClass LicenseClassID)
        {
            return clsLicenseClassData.GetLicenseClassMinimumAllowedAge((int)LicenseClassID);
        }
    }
}
