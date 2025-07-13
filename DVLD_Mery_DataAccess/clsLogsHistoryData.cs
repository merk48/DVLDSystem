using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DVLD_Mery_DataAccess
{
    static public class clsLogsHistoryData
    {
        static public int AddLoginLog(int UserID, string FullName, string UserName, DateTime LoginDate, DateTime LogoutDate)
        {
            int LoginID = -1;

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_AddLoginLog", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserID", UserID);
                    command.Parameters.AddWithValue("@FullName", FullName);
                    command.Parameters.AddWithValue("@UserName", UserName);
                    command.Parameters.AddWithValue("@LoginDate", LoginDate);
                    if(LogoutDate != DateTime.MaxValue)
                        command.Parameters.AddWithValue("@LogoutDate", LogoutDate);
                    else
                        command.Parameters.AddWithValue("@LogoutDate", System.DBNull.Value);
                    SqlParameter outputParam = new SqlParameter
                    {
                        ParameterName = "@LoginID",
                        SqlDbType = SqlDbType.Int,
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(outputParam);

                    try
                    {
                        connection.Open();

                        command.ExecuteNonQuery();

                        LoginID = (int)outputParam.Value;
                    }

                    catch (Exception ex)
                    {
                        DataAccessSettings.LogException($"Exception: {ex.Message}", EventLogEntryType.Error);
                    }
                }
            }

            return LoginID;
        }

        static public bool UpdateLoginLog(int LoginID,  DateTime LogoutDate)
        {
            bool isUpdated = false;

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_UpdateLoginLog", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@LoginID", LoginID);
                    command.Parameters.AddWithValue("@LogoutDate", LogoutDate);
                   
                    try
                    {
                        connection.Open();

                        isUpdated = command.ExecuteNonQuery() == 1;
                    }

                    catch (Exception ex)
                    {
                        DataAccessSettings.LogException($"Exception: {ex.Message}", EventLogEntryType.Error);
                    }
                }
            }

            return isUpdated;
        }

        static public DataTable GetLoginLogsPage(int PageNumber, int RowPerPage, string Username)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetLoginLogsPage", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PageNumber", PageNumber);
                    command.Parameters.AddWithValue("@RowPerPage", RowPerPage);
                    command.Parameters.AddWithValue("@UserName", Username);
                    
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

        static public int GetAllLoginLogsCount(string Username)
        {
            int LogsCount = 0;

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetAllLoginLogsCount", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserName", Username);

                    SqlParameter outputParam = new SqlParameter
                    {
                        ParameterName = "@LogsCount",
                        SqlDbType = SqlDbType.Int,
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(outputParam);

                    try
                    {
                        connection.Open();

                        command.ExecuteNonQuery();

                        LogsCount = (int)outputParam.Value;
                    }

                    catch (Exception ex)
                    {
                        DataAccessSettings.LogException($"Exception: {ex.Message}", EventLogEntryType.Error);
                    }
                }
            }

            return LogsCount;
        }

        static public DataTable GetPeopleUpdateLogsPerPage(int PageNumber, int RowPerPage, string Username)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetPeopleUpdateLogsPerPage", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PageNumber", PageNumber);
                    command.Parameters.AddWithValue("@RowPerPage", RowPerPage);
                    command.Parameters.AddWithValue("@UserName", Username);

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

        static public int GetPeopleUpdateLogsCount(string Username)
        {
            int LogsCount = 0;

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetPeopleUpdateLogsCount", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserName", Username);

                    SqlParameter outputParam = new SqlParameter
                    {
                        ParameterName = "@LogsCount",
                        SqlDbType = SqlDbType.Int,
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(outputParam);

                    try
                    {
                        connection.Open();

                        command.ExecuteNonQuery();

                        LogsCount = (int)outputParam.Value;
                    }

                    catch (Exception ex)
                    {
                        DataAccessSettings.LogException($"Exception: {ex.Message}", EventLogEntryType.Error);
                    }
                }
            }

            return LogsCount;
        }

        static public DataTable GetLDLApplicationsUpdateLogsPerPage(int PageNumber, int RowPerPage, string Username)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetLDLApplicationsUpdateLogsPerPage", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PageNumber", PageNumber);
                    command.Parameters.AddWithValue("@RowPerPage", RowPerPage);
                    command.Parameters.AddWithValue("@UserName", Username);

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

        static public int GetLDLApplicationsUpdateLogsCount(string Username)
        {
            int LogsCount = 0;

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetLDLApplicationsUpdateLogsCount", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserName", Username);

                    SqlParameter outputParam = new SqlParameter
                    {
                        ParameterName = "@LogsCount",
                        SqlDbType = SqlDbType.Int,
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(outputParam);

                    try
                    {
                        connection.Open();

                        command.ExecuteNonQuery();

                        LogsCount = (int)outputParam.Value;
                    }

                    catch (Exception ex)
                    {
                        DataAccessSettings.LogException($"Exception: {ex.Message}", EventLogEntryType.Error);
                    }
                }
            }

            return LogsCount;
        }

        static public DataTable GetPeopleDeleteLogsPerPage(int PageNumber, int RowPerPage, string Username)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetPeopleDeleteLogsPerPage", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PageNumber", PageNumber);
                    command.Parameters.AddWithValue("@RowPerPage", RowPerPage);
                    command.Parameters.AddWithValue("@UserName", Username);

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

        static public int GetPeopleDeleteLogsCount(string Username)
        {
            int LogsCount = 0;

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetPeopleDeleteLogsCount", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserName", Username);

                    SqlParameter outputParam = new SqlParameter
                    {
                        ParameterName = "@LogsCount",
                        SqlDbType = SqlDbType.Int,
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(outputParam);

                    try
                    {
                        connection.Open();

                        command.ExecuteNonQuery();

                        LogsCount = (int)outputParam.Value;
                    }

                    catch (Exception ex)
                    {
                        DataAccessSettings.LogException($"Exception: {ex.Message}", EventLogEntryType.Error);
                    }
                }
            }

            return LogsCount;
        }
        

            

    }
}
