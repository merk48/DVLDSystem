using DVLD_Mery_DataAccess;
using System.Data;

namespace DVLD_Mery_Buisness
{
    public class clsUser
    {
        public enum enMode {AddNew,Update }
        public enMode Mode = enMode.AddNew;

        public int UserID { get; set; }
        public int PersonID { get; set; }
        public clsPerson PersonInfo;
        public string Username { get; set; }
        public string Password { get; set; }
        public bool isActive { get; set; }

        public clsUser()
        {
            UserID = -1;
            PersonID = -1;
            Username = "";
            Password = "";
            isActive = false;
            Mode =enMode.AddNew;
        }

        private clsUser(int UserID, int PersonID, string Username,string Password,bool isActive)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.PersonInfo = clsPerson.Find(PersonID);
            this.Username = Username;
            this.Password = Password;
            this.isActive = isActive;
            Mode = enMode.Update;
        }

        static public clsUser FindByID(int UserID)
        {
            int PersonID = -1;
            string Username = "", Password = "";
            bool isActive = false;

            if (clsUserData.GetUserInfoByID(UserID, ref PersonID, ref Username, ref  Password,ref  isActive))
                return new clsUser(UserID, PersonID,  Username, Password, isActive);
            else
                return null;
        }

        static public clsUser FindByUsername(string Username)
        {
            int UserID = -1 ,PersonID = -1;
            string Password = "";
            bool isActive = false;

            if (clsUserData.GetUserInfoByUsername(ref UserID, ref PersonID,  Username, ref Password, ref isActive))
                return new clsUser(UserID, PersonID, Username, Password, isActive);
            else
                return null;
        }

        static public clsUser FindByUsernameAndPassword(string Username, string Password)
        {
            int UserID = -1,PersonID = -1;
            bool isActive = false;

            if (clsUserData.GetUserInfoByUsernameAndPassword(ref UserID, ref PersonID, Username,  Password, ref isActive))
                return new clsUser(UserID, PersonID,  Username, Password, isActive);
            else
                return null;
        }

        private bool _AddNewUser()
        {
            this.UserID = clsUserData.AddNewUser(this.PersonID, this.Username, this.Password, this.isActive);
            return (UserID != -1);
        }

        private bool _UpdateUser()
        {
            return clsUserData.UpdateUser(this.UserID , this.PersonID, this.Username, this.Password, this.isActive);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
                case enMode.Update:
                    return _UpdateUser();
            }
            return false;
        }

        static public bool DeleteUserByID(int UserID)
        {
            return clsUserData.DeleteUserByID(UserID);
        }

        static public DataTable GetAllUsers()
        {
            return clsUserData.GetAllUsers();
        }

        /*
        static public bool IsUserExistsByID(int UserID)
        {
            return clsUserData.IsUserExistsByID(UserID);
        }
*/
        static public bool IsUserExistsByPersonID(int PersonID)
        {
            return clsUserData.IsUserExistsByPersonID(PersonID);
        }

        static public bool IsUserExistsByUsername(string Username)
        {
            return clsUserData.IsUserExistsByUsername(Username);
        }

        public bool ChangePassword(string NewPassword)
        {
            return clsUserData.ChangePassword(this.UserID, NewPassword);
        }

    }
}
