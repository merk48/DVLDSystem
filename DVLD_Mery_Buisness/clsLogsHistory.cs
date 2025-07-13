using DVLD_Mery_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Mery_Buisness
{
    public class clsLogsHistory
    {
        static public int AddLoginLog(clsUser User)
        {
            return clsLogsHistoryData.AddLoginLog(User.UserID, User.PersonInfo.FullName, User.Username, DateTime.Now, DateTime.MaxValue);
        }

        static public bool AddLogoutLog(int LoginID)
        {
            return clsLogsHistoryData.UpdateLoginLog(LoginID, DateTime.Now);
        }

        static public DataTable GetLoginLogsPage(int PageNumber, int RowPerPage, string Username)
        {
            return clsLogsHistoryData.GetLoginLogsPage(PageNumber, RowPerPage, Username);
        }

        static public int GetAllLoginLogsCount(string Username)
        {
            return clsLogsHistoryData.GetAllLoginLogsCount(Username);
        }

        static public DataTable GetPeopleUpdateLogsPerPage(int PageNumber, int RowPerPage, string Username)
        {
            return clsLogsHistoryData.GetPeopleUpdateLogsPerPage(PageNumber, RowPerPage, Username);
        }

        static public int GetPeopleUpdateLogsCount(string Username)
        {
            return clsLogsHistoryData.GetPeopleUpdateLogsCount(Username);
        }

        static public DataTable GetLDLApplicationsUpdateLogsPerPage(int PageNumber, int RowPerPage, string Username)
        {
            return clsLogsHistoryData.GetLDLApplicationsUpdateLogsPerPage(PageNumber, RowPerPage, Username);
        }

        static public int GetLDLApplicationsUpdateLogsCount(string Username)
        {
            return clsLogsHistoryData.GetLDLApplicationsUpdateLogsCount(Username);
        }

        static public DataTable GetPeopleDeleteLogsPerPage(int PageNumber, int RowPerPage, string Username)
        {
            return clsLogsHistoryData.GetPeopleDeleteLogsPerPage(PageNumber, RowPerPage, Username);
        }

        static public int GetPeopleDeleteLogsCount(string Username)
        {
            return clsLogsHistoryData.GetPeopleDeleteLogsCount(Username);
        }

    }
}
