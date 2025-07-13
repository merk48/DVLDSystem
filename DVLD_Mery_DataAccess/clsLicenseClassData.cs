using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_Mery_DataAccess
{
    static public class clsLicenseClassData
    {
        static public bool GetLicenseClassInfo(int LicenseClassID, ref string ClassName, ref string ClassDescription, ref byte MinimumAllowedAge, ref byte DefaultValidityLength, ref decimal ClassFees)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = "SELECT * FROM LicenseClasses WHERE LicenseClassID = @LicenseClassID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    ClassName = (string)reader["ClassName"];
                    ClassDescription = (string)reader["ClassDescription"];
                    MinimumAllowedAge = (byte)reader["MinimumAllowedAge"]; 
                    DefaultValidityLength = (byte)reader["DefaultValidityLength"]; 
                    ClassFees = (decimal)reader["ClassFees"]; 
                }
    
                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Exception: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        static public DataTable GetAllLicenseClasss()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"Select * from LicenseClasses";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    dt.Load(reader);

                reader.Close();

            }
            catch (Exception ex)
            {
               // Console.WriteLine("Exception: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        static public byte GetLicenseClassValidityLength(int LicenseClassID)
        {
            byte  Validity = 0;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"Select DefaultValidityLength from LicenseClasses Where LicenseClassID = @LicenseClassID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                connection.Open();

                Object result = command.ExecuteScalar();

                if (result != null && byte.TryParse(result.ToString(), out byte Length))
                    Validity = Length;

            }
            catch (Exception ex)
            {
                // Console.WriteLine("Exception: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return Validity;
        }

        static public string GetLicenseClassNameByID(int LicenseClassID)
        {
            string ClassName = "";

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"Select ClassName from LicenseClasses Where LicenseClassID = @LicenseClassID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                connection.Open();

                Object result = command.ExecuteScalar();

                if (result != null )
                    ClassName = result.ToString();

            }
            catch (Exception ex)
            {
                // Console.WriteLine("Exception: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return ClassName;
        }

        static public decimal GetLicenseClassPaidFees(int LicenseClassID)
        {
            decimal ClassFees = 0;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"Select ClassFees from LicenseClasses Where LicenseClassID = @LicenseClassID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                connection.Open();

                Object result = command.ExecuteScalar();

                if (result != null && decimal.TryParse(result.ToString(), out decimal fees))
                    ClassFees = fees;

            }
            catch (Exception ex)
            {
                // Console.WriteLine("Exception: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return ClassFees;
        }

        static public byte GetLicenseClassMinimumAllowedAge(int LicenseClassID)
        {
            byte MinimumAllowedAge = 0;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"Select MinimumAllowedAge from LicenseClasses Where LicenseClassID = @LicenseClassID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                connection.Open();

                Object result = command.ExecuteScalar();

                if (result != null && byte.TryParse(result.ToString(), out byte Age))
                    MinimumAllowedAge = Age;

            }
            catch (Exception ex)
            {
                // Console.WriteLine("Exception: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return MinimumAllowedAge;
        }
    }
}
