using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_Mery_DataAccess
{
    static public class clsLocalDrivingLicenseApplicationData
    {
        static public bool GetLocalDrivingLicenseApplicationInfo(int LocalDrivingLicenseApplicationID,ref int ApplicationID,ref int LicenseClassID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetLocalDrivingLicenseApplicationByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                ApplicationID = (int)reader["ApplicationID"];
                                LicenseClassID = (int)reader["LicenseClassID"];
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

        static public bool GetLocalDrivingLicenseApplicationInfo(ref int LocalDrivingLicenseApplicationID,  int ApplicationID, ref int LicenseClassID)
        {
            bool isFound = false;
            using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetLocalDrivingLicenseApplicationByApplicationID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                LocalDrivingLicenseApplicationID = (int)reader["LocalDrivingLicenseApplicationID"];
                                LicenseClassID = (int)reader["LicenseClassID"];

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

        static public int AddNewLocalDrivingLicenseApplication(int ApplicationID,  int LicenseClassID)
        {
            int LocalDrivingLicenseApplicationID = -1;
            using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_AddNewLocalDrivingLicenseApplication", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                    command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

                    SqlParameter outputParam = new SqlParameter
                    {
                        ParameterName = "@NewLocalDrivingLicenseApplicationID",
                        SqlDbType = SqlDbType.Int,
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(outputParam);

                    try
                    {
                        connection.Open();

                        command.ExecuteNonQuery();

                        LocalDrivingLicenseApplicationID = (int)outputParam.Value;
                    }
                    catch (Exception ex)
                    {
                        DataAccessSettings.LogException($"Exception: {ex.Message}", EventLogEntryType.Error);
                    }
                }
            }
            return LocalDrivingLicenseApplicationID;
        }

        static public bool UpdateLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID, int ApplicationID, int LicenseClassID)
        {
            bool isUpdated = false;
            using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_UpdateLocalDrivingLicenseApplication", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
                    command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                    command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();

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

        static public bool DeleteLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID)
        {
            bool isDeleted = false;

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_DeleteLocalDrivingLicenseApplication", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

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

        static public DataTable GetAllLocalDrivingLicenseApplications()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetAllLocalDrivingLicenseApplications", connection))
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

        /// <summary>
        /// Checks if a person has an active driving license application for a specified class.
        /// </summary>
        /// <param name="NationalNo">The national identification number of the person.</param>
        /// <param name="ClassName">The class name of the driving license.</param>
        /// <returns>
        /// The ApplicationID of the active application if found; otherwise, -1.
        /// </returns>
        /// <remarks>
        /// Queries the database for a 'New' status application matching the given NationalNo and ClassName, 
        /// using the "SP_CheckIPersonHasActiveApplication" stored procedure. Logs exceptions.
        /// </remarks>
        static public int IsPersonHasActiveApplication(string NationalNo, string ClassName)
        {
            int ApplicationID = -1;
            using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_CheckIPersonHasActiveApplication", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@NationalNo", NationalNo);
                    command.Parameters.AddWithValue("@ClassName", ClassName);

                    SqlParameter outputParam = new SqlParameter
                    {
                        ParameterName = "@ApplicationID",
                        SqlDbType = SqlDbType.Int,
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(outputParam);

                    try
                    {
                        connection.Open();
                        command.ExecuteScalar();

                        ApplicationID = (int)outputParam.Value;

                    }
                    catch (Exception ex)
                    {
                        DataAccessSettings.LogException($"Exception: {ex.Message}", EventLogEntryType.Error);
                    }
                }
            }

            return ApplicationID;
        }

        static public int GetApplicationIDByLDLicenseID(int LocalDrivingLicenseApplicationID)
        {
            int ApplicationID = 0;
            using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetApplicationIDByLocalDrivingLicenseApplicationID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
                    SqlParameter outputParam = new SqlParameter
                    {
                        ParameterName = "@ApplicationID",
                        SqlDbType = SqlDbType.Int,
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(outputParam);

                    try
                    {
                        connection.Open();
                        command.ExecuteScalar();
                       
                        ApplicationID = (int)outputParam.Value;

                    }
                    catch (Exception ex)
                    {
                        DataAccessSettings.LogException($"Exception: {ex.Message}", EventLogEntryType.Error);
                    }
                }
            }
          


            return ApplicationID;
        }


        /// <summary>
        /// Retrieves the count of passed tests for a specific driving license application.
        /// </summary>
        /// <param name="LocalDrivingLicenseApplicationID">The ID of the driving license application.</param>
        /// <returns>The count of passed tests or 0 if no data is found.</returns>
        /// <remarks>
        /// Queries the database using the "SP_GetPassedTestsCount" stored procedure. Logs exceptions.
        /// </remarks>
        static public int GetPassedTestsCount(int LocalDrivingLicenseApplicationID)
        {
            int PassedTests = 0;
            using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetPassedTestsCount", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

                    SqlParameter outputParam = new SqlParameter
                    {
                        ParameterName = "@PassedTests",
                        SqlDbType = SqlDbType.Int,
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(outputParam);

                    try
                    {
                        connection.Open();
                        command.ExecuteScalar();

                        PassedTests = (int)outputParam.Value;

                    }
                    catch (Exception ex)
                    {
                        DataAccessSettings.LogException($"Exception: {ex.Message}", EventLogEntryType.Error);
                    }
                }
            }

            return PassedTests;
        }
    }
}

