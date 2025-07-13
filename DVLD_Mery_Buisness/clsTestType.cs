using System.Data;
using DVLD_Mery_DataAccess;

namespace DVLD_Mery_Buisness
{
    public class clsTestType
    {
        public enum enTestType { VisionTest = 1, WrittenTest = 2, StreetTest = 3 };

        public clsTestType.enTestType TestTypeID {  get; set; }
        public string TestTypeTitle {  get; set; }
        public string TestTypeDescription {  get; set; }
        public decimal TestTypeFees {  get; set; }


        public clsTestType()
        {
            TestTypeID = clsTestType.enTestType.VisionTest;
            TestTypeTitle = "";
            TestTypeDescription = "";
            TestTypeFees = 0;
        }

        private clsTestType(clsTestType.enTestType TestTypeID, string TestTypeTitle, string TestTypeDescription, decimal TestTypeFees)
        {
            this.TestTypeID = TestTypeID;
            this.TestTypeTitle = TestTypeTitle;
            this.TestTypeDescription = TestTypeDescription;
            this.TestTypeFees = TestTypeFees;
        }

        static public clsTestType Find(clsTestType.enTestType TestTypeID)
        {
            string TestTypeTitle = "", TestTypeDescription = "";
            decimal TestTypeFees = 0;

            if (clsTestTypeData.GetTestTypeInfo((int)TestTypeID, ref TestTypeTitle, ref TestTypeDescription, ref TestTypeFees))
                return new clsTestType(TestTypeID,  TestTypeTitle,  TestTypeDescription,  TestTypeFees);
            else
                return null;
        }

        private bool _UpdateTestType()
        {
            return clsTestTypeData.UpdateTestType((int)this.TestTypeID,this.TestTypeTitle, this.TestTypeDescription, this.TestTypeFees);
        }

        public bool Save()
        {
            return _UpdateTestType();
        }

        static public DataTable GetAllTestTypes()
        {
            return clsTestTypeData.GetAllTestTypes();
        }

        static public decimal GetTestTypeFees(enTestType TestTypeID)
        {
            return clsTestTypeData.GetTestTypeFees((int)TestTypeID);
        }

        /*static public enTestType GetTestTypeID(string TestTypeTitle)
        {
            return (enTestType)clsTestTypeData.GetTestTypeID(TestTypeTitle);
        }*/
    }
}
