using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_Mery_DataAccess
{
    static public class clsTestAppointmentData
    {
        static public bool GetTestAppointmentInfo( int TestAppointmentID, ref int TestTypeID, ref int LocalDrivingLicenseApplicationID, ref DateTime AppointmentDate, ref decimal PaidFees, ref int CreatedByUserID, ref bool IsLocked,ref int RetakeTestApplicationID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM TestAppointments WHERE TestAppointmentID = @TestAppointmentID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    TestTypeID = (int)reader["TestTypeID"];
                    LocalDrivingLicenseApplicationID = (int)reader["LocalDrivingLicenseApplicationID"];
                    AppointmentDate = (DateTime)reader["AppointmentDate"];
                    PaidFees = (decimal)reader["PaidFees"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    IsLocked = (bool)reader["IsLocked"];
                    if (reader["RetakeTestApplicationID"] == DBNull.Value)
                        RetakeTestApplicationID = -1;
                    else
                        RetakeTestApplicationID = (int)reader["RetakeTestApplicationID"];
                    
                }

                reader.Close();
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
             
        }

        static public int AddNewTestAppointment(  int TestTypeID,  int LocalDrivingLicenseApplicationID,  DateTime AppointmentDate,  decimal PaidFees,  int CreatedByUserID,  bool IsLocked,  int RetakeTestApplicationID)
        {
            int TestAppointmentID = -1;
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"INSERT INTO [dbo].[TestAppointments]
                             ([TestTypeID], [LocalDrivingLicenseApplicationID], [AppointmentDate],[PaidFees], [CreatedByUserID], [IsLocked], [RetakeTestApplicationID])
                             VALUES (@TestTypeID, @LocalDrivingLicenseApplicationID, @AppointmentDate,@PaidFees, @CreatedByUserID, @IsLocked, @RetakeTestApplicationID);
                                SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@IsLocked", IsLocked);
            if (RetakeTestApplicationID == -1)
                command.Parameters.AddWithValue("@RetakeTestApplicationID", DBNull.Value);
            else
                command.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID);



            try
            {
                connection.Open();
                Object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    TestAppointmentID = insertedID;
            }
            catch
            {
                return -1;
            }
            finally
            {
                connection.Close();
            }

            return TestAppointmentID;
        }

        static public bool UpdateTestAppointment(int TestAppointmentID, int TestTypeID, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, decimal PaidFees, int CreatedByUserID, bool IsLocked, int RetakeTestApplicationID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"UPDATE [dbo].[TestAppointments]
                            SET [TestTypeID] = @TestTypeID,
                                [LocalDrivingLicenseApplicationID] = @LocalDrivingLicenseApplicationID,  
                                [AppointmentDate] = @AppointmentDate,  
                                [PaidFees] = @PaidFees,  
                                [CreatedByUserID] = @CreatedByUserID,  
                                [IsLocked] = @IsLocked,  
                                [RetakeTestApplicationID] = @RetakeTestApplicationID
                                WHERE TestAppointmentID = @TestAppointmentID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@IsLocked", IsLocked);
            if (RetakeTestApplicationID == -1)
                command.Parameters.AddWithValue("@RetakeTestApplicationID", DBNull.Value);
            else
                command.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID);


            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

        static public DataTable GetAllAppointmentsByTestTypeAndLDLAppID(int TestTypeID, int LocalDrivingLicenseApplicationID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"SELECT  TestAppointments.TestAppointmentID, TestAppointments.AppointmentDate, TestAppointments.PaidFees, TestAppointments.IsLocked
                                FROM  TestAppointments
						            Where TestAppointments.TestTypeID = @TestTypeID And TestAppointments.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    dt.Load(reader);

                reader.Close();

            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }


            return dt;
        }

        static public DateTime GetLastTestAppointmentDate(int TestTypeID, int LocalDrivingLicenseApplicationID)
        {
            DateTime LastTestAppointmentDate = DateTime.Now;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"SELECT top 1 TestAppointments.AppointmentDate
                                FROM  TestAppointments
                                    Where TestAppointments.TestTypeID = @TestTypeID And TestAppointments.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID
									Order by  TestAppointments.AppointmentDate desc;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && DateTime.TryParse(result.ToString(), out DateTime Date))
                    LastTestAppointmentDate = Date;

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Exception: " + ex.Message);
                return DateTime.Now;
            }
            finally
            {
                connection.Close();
            }


            return LastTestAppointmentDate;
        }

        static public DateTime GetTestAppointmentDate(int TestAppointmentID)
        {
            DateTime TestAppointmentDate = DateTime.Now;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"select AppointmentDate from TestAppointments where TestAppointmentID = @TestAppointmentID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && DateTime.TryParse(result.ToString(), out DateTime Date))
                    TestAppointmentDate = Date;

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Exception: " + ex.Message);
                return DateTime.Now;
            }
            finally
            {
                connection.Close();
            }

            return TestAppointmentDate;
        }

        static public bool IfThereAnOpenAppointment(int TestTypeID,int LocalDrivingLicenseApplicationID)
        {
            int OpenAppointments = 0;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"SELECT Count(*) as OpenAppointments FROM TestAppointments 
                            WHERE   (TestAppointments.TestTypeID = @TestTypeID) AND (TestAppointments.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID) AND(TestAppointments.IsLocked = 0);";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int Count))
                    OpenAppointments = Count;

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Exception: " + ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }


            return (OpenAppointments > 0);
        }

        static public bool IfThereAPassedLockedTestAppointment(int TestTypeID, int LocalDrivingLicenseApplicationID)
        {
            int PassedLockedTestAppointment = 0;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"SELECT Count(*) as PassedLockedTestAppointment
                            FROM TestAppointments INNER JOIN
                                    Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
						            Where (TestAppointments.TestTypeID = @TestTypeID) AND (TestAppointments.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID) AND(TestAppointments.IsLocked = 1) AND(Tests.TestResult = 1) ;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int Count))
                    PassedLockedTestAppointment = Count;

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Exception: " + ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }


            return (PassedLockedTestAppointment > 0);
        }

        static public bool IfThereAFailedLockedTestAppointment(int TestTypeID, int LocalDrivingLicenseApplicationID)
        {
            int PassedLockedTestAppointment = 0;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"SELECT Count(*) as PassedLockedTestAppointment
                            FROM TestAppointments INNER JOIN
                                    Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
						            Where (TestAppointments.TestTypeID = @TestTypeID) AND (TestAppointments.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID) AND(TestAppointments.IsLocked = 1) AND(Tests.TestResult = 0) ;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int Count))
                    PassedLockedTestAppointment = Count;

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Exception: " + ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }


            return (PassedLockedTestAppointment > 0);
        }

        static public int CountTrials(int TestTypeID, int LocalDrivingLicenseApplicationID)
        {
            int Trials = 0;
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"select Count(*) as Trials From TestAppointments
                        where TestTypeID = @TestTypeID AND LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID ;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

            try
            {
                connection.Open();
                Object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int count))
                    Trials = count;
            }
            catch
            {
                return -1;
            }
            finally
            {
                connection.Close();
            }

            return Trials;
        }

        static public bool isLocked(int TestAppointmentID)
        {
            bool IsLocked = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"SELECT IsLocked FROM TestAppointments 
                            WHERE TestAppointmentID = @TestAppointmentID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && bool.TryParse(result.ToString(), out bool locked))
                    IsLocked = locked;

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Exception: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }


            return IsLocked;
        }

      /*  static public bool isPassedTest(int TestTypeID, int LocalDrivingLicenseApplicationID)
        {
            int Result = 0 ;
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"SELECT Count(*) as PassedTest
                            FROM TestAppointments INNER JOIN
                                    Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
						            Where (TestAppointments.TestTypeID = @TestTypeID) AND (TestAppointments.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID)  AND(Tests.TestResult = 1) ;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

            try
            {
                connection.Open();
                Object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int count))
                    Result = count;
            }
            catch
            {
               // return false;
            }
            finally
            {
                connection.Close();
            }

            return Result > 0; //or == 1
        }
*/
        public static int GetTestID(int TestAppointmentID)
        {
            int TestID = -1;
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"select TestID from Tests where TestAppointmentID=@TestAppointmentID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int ID))
                    TestID = ID;
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return -1;
            }

            finally
            {
                connection.Close();
            }

            return TestID;
        }

        /* static public bool isThereATakenTest(int TestTypeID, int LocalDrivingLicenseApplicationID)
         {
             int TestResult = 0;
             SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

             string query = @"SELECT         Tests.TestResult
                                      FROM            TestAppointments INNER JOIN
                                                       Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                                         WHERE        (TestAppointments.TestTypeID = @TestTypeID) AND (TestAppointments.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID5) AND (TestAppointments.IsLocked = 1);";

             SqlCommand command = new SqlCommand(query, connection);
             command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
             command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

             try
             {
                 connection.Open();
                 Object result = command.ExecuteScalar();

                 if (result != null && int.TryParse(result.ToString(), out int testResult))
                     TestResult = testResult;
             }
             catch
             {
                 // return false;
             }
             finally
             {
                 connection.Close();
             }

             return TestResult == 1;
         }*/
    }
}
