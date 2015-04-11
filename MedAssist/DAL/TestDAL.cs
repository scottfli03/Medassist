using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MedAssist.Model;

namespace MedAssist.DAL
{
    class TestDAL
    {
        // inserts incident to database
        public static bool CreateTest(Test test)
        {
            Test newTest = new Test();
            SqlConnection connection = MedassistDB.GetConnection();
            string insertStatement =
            "INSERT Tests " +
                "(TestID, TestName)" +
                "Values (@TestID, @TestName)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue("@TestID", test.TestID);
            insertCommand.Parameters.AddWithValue("@TestName", test.TestName);

            try
            {
                connection.Open();
                int count = insertCommand.ExecuteNonQuery();
                if (count > 0)
                    return true;
                else
                    return false;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }


        public static List<Test> GetTest()
        {
            List<Test> testList = new List<Test>();
            SqlConnection connection = MedassistDB.GetConnection();
            string selectStatement = @"Select
            Tests.TestID, Tests.TestName 
            FROM Tests";
            SqlCommand selectCommand =
                new SqlCommand(selectStatement, connection);
            
            try
            {
                connection.Open();
                SqlDataReader reader =
                    selectCommand.ExecuteReader();
                if (reader.Read())
                {
                    Test test = new Test();
                    test.TestName = reader["TestName"].ToString();
                    test.TestID = (int)reader["TestID"];
                    testList.Add(test);


                }     
                reader.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return testList;
        }

        public static Test GetTestWithID(int testID)
        {
            Test test  = new Test();
            SqlConnection connection = MedassistDB.GetConnection();
            string selectStatement = @"Select
            Tests.TestID, Tests.TestName 
            FROM Tests";
            SqlCommand selectCommand =
                new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@TestID", testID);
            try
            {
                connection.Open();
                SqlDataReader reader =
                    selectCommand.ExecuteReader();
                if (reader.Read())
                {
                   
                    test.TestName = reader["TestName"].ToString();
                    test.TestID = (int)reader["TestID"];
                    
                }
                else
                {
                    test = null;
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return test;
        }

        public static bool UpdateTest(Test oldTest, Test newTest)
        {
            SqlConnection connection = MedassistDB.GetConnection();
            string updateStatement =
                "UPDATE Tests SET " +
                "TestID = @TestID, " +
                "TestName = @TestName " +
                "WHERE TestID = @OldTestID " +
                "AND TestName = @OldTestName";
            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
            updateCommand.Parameters.AddWithValue("@TestID", newTest.TestID);
            updateCommand.Parameters.AddWithValue("@TestName", newTest.TestName);
            updateCommand.Parameters.AddWithValue("@OldTestID", oldTest.TestID);
            updateCommand.Parameters.AddWithValue("@OldTestName", oldTest.TestName);
            
            try
            {
                connection.Open();
                int count = updateCommand.ExecuteNonQuery();
                if (count > 0)
                    return true;
                else
                    return false;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
    
    
    
    
    
    
    }
}
