using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace DVLD_Mery_DataAccess
{
    static public class clsUserData
    {
        static public bool GetUserInfoByID(int UserID, ref int PersonID, ref string Username, ref string Password, ref bool isActive)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetUserByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserID", UserID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                PersonID = (int)reader["PersonID"];
                                Username = (string)reader["Username"];
                                Password = (string)reader["Password"];
                                isActive = (bool)reader["isActive"];
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        DataAccessSettings.LogException($"Exception: {e.Message}", EventLogEntryType.Error);
                    }

                    return isFound;
                }
            }
        }

        static public bool GetUserInfoByUsernameAndPassword(ref int UserID, ref int PersonID,  string Username, string Password, ref bool isActive)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetUserByUsernameAndPassword", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Username", Username);
                    command.Parameters.AddWithValue("@Password", Password);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                PersonID = (int)reader["PersonID"];
                                Password = (string)reader["Password"];
                                UserID = (int)reader["UserID"];
                                isActive = (bool)reader["isActive"];
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        DataAccessSettings.LogException($"Exception: {e.Message}", EventLogEntryType.Error);
                    }
                }
            }
            return isFound;
        }

        static public bool GetUserInfoByUsername(ref int UserID, ref int PersonID, string Username, ref string Password, ref bool isActive)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetUserByUsername", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Username", Username);

                    try
                    {
                        connection.Open();
                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                PersonID = (int)reader["PersonID"];
                                UserID = (int)reader["UserID"];
                                isActive = (bool)reader["isActive"];
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        DataAccessSettings.LogException($"Exception: {e.Message}", EventLogEntryType.Error);
                    }
                }
            }
            return isFound;
        }
        
        static public int AddNewUser(int PersonID, string Username, string Password, bool isActive)
        {
            int UserID = -1;

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_AddNewUser", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PersonID", PersonID);
                    command.Parameters.AddWithValue("@Username", Username);
                    command.Parameters.AddWithValue("@Password", DataAccessSettings.ComputeHash(Password));
                    command.Parameters.AddWithValue("@isActive", isActive);

                    SqlParameter outputParam = new SqlParameter
                    {
                        ParameterName = "@NewUserID",
                        SqlDbType = SqlDbType.Int,
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(outputParam);

                    try
                    {
                        connection.Open();

                        command.ExecuteNonQuery();

                        UserID = (int)outputParam.Value;
                    }
                    catch (Exception e)
                    {
                        DataAccessSettings.LogException($"Exception: {e.Message}", EventLogEntryType.Error);
                    }
                }
            }
            return UserID;
        }

        static public bool UpdateUser( int UserID, int PersonID, string Username, string Password, bool isActive)
        {
            bool isUpdated = false;

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_UpdateUser", connection))
                {

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserID", UserID);
                    command.Parameters.AddWithValue("@PersonID", PersonID);
                    command.Parameters.AddWithValue("@Username", Username);
                    command.Parameters.AddWithValue("@Password", DataAccessSettings.ComputeHash(Password));
                    command.Parameters.AddWithValue("@IsActive", isActive);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();

                        isUpdated = (command.ExecuteNonQuery() > 0);
                    }
                    catch (Exception e)
                    {
                        DataAccessSettings.LogException($"Exception: {e.Message}", EventLogEntryType.Error);
                    }
                }
            }

            return isUpdated;
        }

        static public bool DeleteUserByID(int UserID)
        {
            bool isDeleted = false;

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_DeleteUser", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserID", UserID);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();

                        isDeleted = (command.ExecuteNonQuery() > 0);
                    }
                    catch (Exception e)
                    {
                        DataAccessSettings.LogException($"Exception: {e.Message}", EventLogEntryType.Error);
                    }
                }
            }

            return isDeleted;
        }

        static public bool IsUserExistsByPersonID(int PersonID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_CheckUserExistsByPersonID", connection))
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
                    catch (Exception e)
                    {
                        DataAccessSettings.LogException($"Exception: {e.Message}", EventLogEntryType.Error);
                    }
                }
            }

            return isFound;
        }

        static public bool IsUserExistsByUsername(string Username)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_CheckUserExistsByUsername", connection))
                {

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Username", Username);

                    SqlParameter returnValue = new SqlParameter();
                    returnValue.Direction = ParameterDirection.ReturnValue;
                    command.Parameters.Add(returnValue);

                    try
                    {
                        connection.Open();

                        command.ExecuteNonQuery();

                        isFound = (Convert.ToInt32(returnValue.Value) > 0);

                    }
                    catch (Exception e)
                    {
                        DataAccessSettings.LogException($"Exception: {e.Message}", EventLogEntryType.Error);
                    }
                }
            }

            return isFound;
        }

        static public bool ChangePassword(int UserID,  string NewPassword)
        {
            bool isUpdated = false;

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_ChangeUserPassword", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserID", UserID);
                    command.Parameters.AddWithValue("@Password", DataAccessSettings.ComputeHash(NewPassword));

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();

                        isUpdated = (command.ExecuteNonQuery() > 0);
                    }
                    catch (Exception e)
                    {
                        DataAccessSettings.LogException($"Exception: {e.Message}", EventLogEntryType.Error);
                    }
                }
            }

            return isUpdated;
        }

        static public DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("SP_GetAllUsers", connection))
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
                catch (Exception e)
                {
                        DataAccessSettings.LogException($"Exception: {e.Message}", EventLogEntryType.Error);
                    }
                }
            } 
            return dt;
        }

    }
}
