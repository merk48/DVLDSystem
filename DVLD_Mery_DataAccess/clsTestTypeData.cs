using System;
using System.Data;
using System.Data.SqlClient;


namespace DVLD_Mery_DataAccess
{
    static public class clsTestTypeData
    {
        static public bool GetTestTypeInfo(int TestTypeID,ref string TestTypeTitle, ref string TestTypeDescription, ref decimal TestTypeFees)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = "SELECT * FROM TestTypes WHERE TestTypeID = @TestTypeID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    TestTypeTitle = (string)reader["TestTypeTitle"];
                    TestTypeDescription = (string)reader["TestTypeDescription"];
                    TestTypeFees = (decimal)reader["TestTypeFees"];
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                return false;
                //Console.WriteLine("Exception: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        static public bool UpdateTestType(int TestTypeID, string TestTypeTitle, string TestTypeDescription, decimal TestTypeFees)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"UPDATE [dbo].[TestTypes]
                           SET [TestTypeTitle] = @TestTypeTitle
                              ,[TestTypeDescription] = @TestTypeDescription
                              ,[TestTypeFees] = @TestTypeFees                              
                         WHERE TestTypeID = @TestTypeID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle);
            command.Parameters.AddWithValue("@TestTypeDescription", TestTypeDescription);
            command.Parameters.AddWithValue("@TestTypeFees", TestTypeFees);

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

        static public DataTable GetAllTestTypes()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"SELECT * from TestTypes";

            SqlCommand command = new SqlCommand(query, connection);

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
                return new DataTable();
            }
            finally
            {
                connection.Close();
            }


            return dt;
        }

        static public decimal GetTestTypeFees(int TestTypeID)
        {
            decimal TestTypeFees = 0;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"SELECT TestTypeFees from TestTypes Where TestTypeID = @TestTypeID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && decimal.TryParse(result.ToString(), out decimal fees))
                    TestTypeFees = fees;

            }
            catch
            {
                return 0;
            }
            finally
            {
                connection.Close();
            }


            return TestTypeFees;
        }

       /* static public int GetTestTypeID(string TestTypeTitle)
        {
            int TestTypeID = 0;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"SELECT TestTypeID from TestTypes Where TestTypeTitle = @TestTypeTitle";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int ID))
                    TestTypeID = ID;
            }
            catch
            {
                return -1;
            }
            finally
            {
                connection.Close();
            }


            return TestTypeID;
        }*/
    }
}
