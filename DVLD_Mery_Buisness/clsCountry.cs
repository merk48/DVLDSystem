using System.Data;
using DVLD_Mery_DataAccess;

namespace DVLD_Mery_Buisness
{
    public class clsCountry
    {
        public int CountryID { get; set; }
        public string CountryName { get; set; }

        public clsCountry()
        {
            CountryID = -1;
            CountryName = "";
        }

        private clsCountry(int CountryID,string CountryName)
        {
            this.CountryID = CountryID;
            this.CountryName = CountryName;
        }

        static public clsCountry Find(int CountryID)
        {
            string CountryName = "";

            if(clsCountryData.GetCountryInfo(CountryID,ref CountryName))
                return new clsCountry(CountryID, CountryName);
            else
                return null;
        }

        static public clsCountry Find(string CountryName)
        {
            int CountryID = -1;

            if (clsCountryData.GetCountryInfo(ref CountryID,  CountryName))
                return new clsCountry(CountryID, CountryName);
            else
                return null;
        }

        static public DataTable GetAllCountries()
        {
            return clsCountryData.GetAllCountries();
        }

        static public int GetCountryIDByName(string CountryName)
        {
            return clsCountryData.GetCountryIDByName(CountryName);
        }

        static public string GetCountryNameByID(int CountryID)
        {
            return clsCountryData.GetCountryNameByID(CountryID);
        }
    }
}
