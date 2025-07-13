using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Net;
using System.Security.Policy;

namespace DVLD_Mery_DataAccess
{
    static public class clsPersonData
    {
        public static bool GetPersonInfo(int PersonID, ref string NationalNo, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref byte Gender, ref string Address, ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetPersonByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PersonID", PersonID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                NationalNo = reader["NationalNo"] as string ?? "";
                                FirstName = (string)reader["FirstName"];
                                SecondName = (string)reader["SecondName"];
                                LastName = (string)reader["LastName"];
                                Address = (string)reader["Address"];
                                DateOfBirth = (DateTime)reader["DateOfBirth"];
                                Gender = (byte)reader["Gender"];
                                Phone = (string)reader["Phone"];
                                NationalityCountryID = (int)reader["NationalityCountryID"];

                                if (reader["ThirdName"] != DBNull.Value)
                                    ThirdName = (string)reader["ThirdName"];
                                else
                                    ThirdName = "";

                                if (reader["Email"] != DBNull.Value)
                                    Email = (string)reader["Email"];
                                else
                                    Email = "";

                                if (reader["ImagePath"] != DBNull.Value)
                                    ImagePath = (string)reader["ImagePath"];
                                else
                                    ImagePath = "";
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        DataAccessSettings.LogException($"Exception: {ex.Message}", EventLogEntryType.Error);
                    }
                }
            }
            return isFound;
        }

        static public bool GetPersonInfo(ref int PersonID, string NationalNo, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref byte Gender, ref string Address, ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetPersonByNationalNo", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@NationalNo", NationalNo);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())

                            if (reader.Read())
                            {
                                isFound = true;

                                PersonID = (int)reader["PersonID"];
                                FirstName = (string)reader["FirstName"];
                                SecondName = (string)reader["SecondName"];
                                LastName = (string)reader["LastName"];
                                Address = (string)reader["Address"];
                                DateOfBirth = (DateTime)reader["DateOfBirth"];
                                Gender = (byte)reader["Gender"];
                                Phone = (string)reader["Phone"];
                                NationalityCountryID = (int)reader["NationalityCountryID"];

                                if (reader["ThirdName"] != DBNull.Value)
                                    ThirdName = (string)reader["ThirdName"];
                                else
                                    ThirdName = "";

                                if (reader["Email"] != DBNull.Value)
                                    Email = (string)reader["Email"];
                                else
                                    Email = "";

                                if (reader["ImagePath"] != DBNull.Value)
                                    ImagePath = (string)reader["ImagePath"];
                                else
                                    ImagePath = "";
                            }
                    }
                    catch (Exception ex)
                    {
                        DataAccessSettings.LogException($"Exception: {ex.Message}", EventLogEntryType.Error);
                    }
                }
            }
            return isFound;
        }

        static public int AddNewPerson(string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName, DateTime DateOfBirth, byte Gender, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {
            int PersonID = -1;

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_AddNewPerson", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@NationalNo", NationalNo);
                    command.Parameters.AddWithValue("@FirstName", FirstName);
                    command.Parameters.AddWithValue("@SecondName", SecondName);
                    command.Parameters.AddWithValue("@LastName", LastName);
                    command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                    command.Parameters.AddWithValue("@Gender", Gender);
                    command.Parameters.AddWithValue("@Address", Address);
                    command.Parameters.AddWithValue("@Phone", Phone);
                    command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

                    if (ThirdName != "" && ThirdName != null)
                        command.Parameters.AddWithValue("@ThirdName", ThirdName);
                    else
                        command.Parameters.AddWithValue("@ThirdName", System.DBNull.Value);

                    if (Email != "" && Email != null)
                        command.Parameters.AddWithValue("@Email", Email);
                    else
                        command.Parameters.AddWithValue("@Email", System.DBNull.Value);

                    if (ImagePath != "" && ImagePath != null)
                        command.Parameters.AddWithValue("@ImagePath", ImagePath);
                    else
                        command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
                    
                    SqlParameter outputParam = new SqlParameter
                    {
                        ParameterName = "@NewPersonID",
                        SqlDbType = SqlDbType.Int,
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(outputParam);

                    try
                    {
                        connection.Open(); 

                        command.ExecuteNonQuery();

                        PersonID = (int)outputParam.Value;
                    }
                    catch(Exception ex)
                    {
                        DataAccessSettings.LogException($"Exception: {ex.Message}", EventLogEntryType.Error);
                    }
                }
            }
            return PersonID;
        }

        static public bool UpdatePerson(int PersonID,string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName, DateTime DateOfBirth, byte Gender, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {
            bool isUpdated = false;
            using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString)) 
            {

                using (SqlCommand command = new SqlCommand("SP_UpdatePerson", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@PersonID", PersonID);
                    command.Parameters.AddWithValue("@NationalNo", NationalNo);
                    command.Parameters.AddWithValue("@FirstName", FirstName);
                    command.Parameters.AddWithValue("@SecondName", SecondName);
                    command.Parameters.AddWithValue("@LastName", LastName);
                    command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                    command.Parameters.AddWithValue("@Gender", Gender);
                    command.Parameters.AddWithValue("@Address", Address);
                    command.Parameters.AddWithValue("@Phone", Phone);
                    command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

                    if (ThirdName != "" && ThirdName != null)
                        command.Parameters.AddWithValue("@ThirdName", ThirdName);
                    else
                        command.Parameters.AddWithValue("@ThirdName", System.DBNull.Value);

                    if (Email != "" && Email != null)
                        command.Parameters.AddWithValue("@Email", Email);
                    else
                        command.Parameters.AddWithValue("@Email", System.DBNull.Value);

                    if (ImagePath != "" && ImagePath != null)
                        command.Parameters.AddWithValue("@ImagePath", ImagePath);
                    else
                        command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);

                    try
                    {
                        connection.Open();

                        isUpdated = (command.ExecuteNonQuery() > 0);
                    }
                    catch (Exception ex)
                    {
                        DataAccessSettings.LogException($"Exception: {ex.Message}", EventLogEntryType.Error);
                    }
                }
            }
            return isUpdated ;
        }

        static public bool DeletePerson(int PersonID)
        {
            bool isDeleted = false;

            using(SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_DeletePerson", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PersonID", PersonID);
                   
                    try
                    {
                        connection.Open();
                        
                        isDeleted = (command.ExecuteNonQuery() > 0);
                    }
                    catch (Exception ex)
                    {
                        DataAccessSettings.LogException($"Exception: {ex.Message}", EventLogEntryType.Error);
                    }
                }
            }
            return isDeleted;
        }

        static public bool IsPersonExists(int PersonID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_CheckPersonExistsByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PersonID", PersonID);

                    SqlParameter returnValue = new SqlParameter();
                    returnValue.Direction = ParameterDirection.ReturnValue;
                    command.Parameters.Add(returnValue);

                    try
                    {
                        connection.Open();

                        command.ExecuteNonQuery();

                        isFound = (Convert.ToInt32(returnValue.Value) > 0);
                    }
                    catch (Exception ex)
                    {
                        DataAccessSettings.LogException($"Exception: {ex.Message}", EventLogEntryType.Error);
                    }
                }
            }
            return isFound;
        }

        static public bool IsPersonExists(string NationalNo)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                using(SqlCommand command = new SqlCommand("SP_CheckPersonExistsByNationalNo", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@NationalNo", NationalNo);

                    SqlParameter returnValue = new SqlParameter();
                    returnValue.Direction = ParameterDirection.ReturnValue;
                    command.Parameters.Add(returnValue);

                    try
                    {
                        connection.Open();
                      
                        command.ExecuteNonQuery();

                        isFound = (Convert.ToInt32(returnValue.Value) > 0);
                    }
                    catch (Exception ex)
                    {
                        DataAccessSettings.LogException($"Exception: {ex.Message}", EventLogEntryType.Error);
                    }
                }
            }
            return isFound;
        }

        static public string GetPersonNationalNoByID(int PersonID)
        {
            string NationalNo = "";

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetPersonNationalNoByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PersonID", PersonID);

                    try
                    {
                        connection.Open();

                        Object result = command.ExecuteScalar();

                        if (result != null)
                            NationalNo = result.ToString();
                    }
                    catch (Exception ex)
                    {
                        DataAccessSettings.LogException($"Exception: {ex.Message}", EventLogEntryType.Error);
                    }
                }
            }
            return NationalNo;
        }

        static public int GetPersonIDByNationalNo(string NationalNo)
        {
            int PersonID = -1;

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetPersonIDByNationalNo", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@NationalNo", NationalNo);

                    try
                    {
                        connection.Open();

                        Object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int ID))
                            PersonID = ID;

                    }
                    catch (Exception ex)
                    {
                        DataAccessSettings.LogException($"Exception: {ex.Message}", EventLogEntryType.Error);
                    }
                }
            }
            return PersonID;
        }
        
        static public DataTable GetAllPeople()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetAllPeople", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader()) 
                        {
                            if (reader.HasRows)
                                dt.Load(reader);
                        }

                    }
                    catch (Exception ex)
                    {
                        DataAccessSettings.LogException($"Exception: {ex.Message}", EventLogEntryType.Error);
                    }
                }
            }
            return dt;
        }

        static public int GetPersonAge(int PersonID)
        {
            int Age = 0;

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetPersonAge", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PersonID", PersonID);

                    try
                    {
                        connection.Open();

                        Object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int ID))
                            Age = ID;

                    }
                    catch (Exception ex)
                    {
                        DataAccessSettings.LogException($"Exception: {ex.Message}", EventLogEntryType.Error);
                    }
                }
            }
            return Age;
        }

        static public bool RestorePerson(int PersonID)
        {
            bool isUpdated = false;
            using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("SP_RestorePerson", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PersonID", PersonID);
                    
                    try
                    {
                        connection.Open();

                        isUpdated = (command.ExecuteNonQuery() > 0);
                    }
                    catch (Exception ex)
                    {
                        DataAccessSettings.LogException($"Exception: {ex.Message}", EventLogEntryType.Error);
                    }
                }
            }
            return isUpdated;
        }
    }
}
