
using System.Security.Cryptography;
using System.Text;
using System;
using System.Diagnostics;
using System.Configuration;

namespace DVLD_Mery_DataAccess
{
    static class DataAccessSettings
    {

        public static string ConnectionString = @"Server=.\MSSQLSERVER2022;Database=DVLD;User Id=sa;Password=sa123456;";
        //public static string ConnectionString = ConfigurationManager.ConnectionStrings["DVLDConnectionString"].ConnectionString;

        const string sourceApp = "DVLD_Mery_Project";

        static public string ComputeHash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));

                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }

        static public void LogException(string EventMessage, EventLogEntryType eventLogEntryType)
        {
            try
            {
                if (!EventLog.SourceExists(sourceApp))
                    EventLog.CreateEventSource(sourceApp, "Application");

                EventLog.WriteEntry(sourceApp, EventMessage, eventLogEntryType);

            }
            catch (Exception ex)
            {
                EventLog.WriteEntry(sourceApp, "Exception in LogException method: " + ex.Message, EventLogEntryType.Error);
            }

        }
    }
}
