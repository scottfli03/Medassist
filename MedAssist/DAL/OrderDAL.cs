using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using MedAssist.Model;

namespace MedAssist.DAL
{
    class OrderDAL
    {
        public OrderDAL() { }

        public static bool OrderTests(BindingList<Test> tests, int visitID) 
        {
            int count = 0;
            SqlTransaction tran = null;
            SqlConnection connection = MedassistDB.GetConnection();
            string insertStatement =
                "Insert Orders " +
                "(OrderDate, TestID, VisitID) " +
                "Values (@OrderDate, @TestID, @VisitID)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            try
            {
                connection.Open();
                tran = connection.BeginTransaction();
                foreach (Test test in tests)
                {
                    insertCommand.Parameters.AddWithValue("@OrderDate", DateTime.Today);
                    insertCommand.Parameters.AddWithValue("@VisitID", visitID);
                    insertCommand.Parameters.AddWithValue("@TestID", test.TestID);
                    insertCommand.Transaction = tran;
                    count += insertCommand.ExecuteNonQuery();
                    insertCommand.Parameters.Clear();
                }
                if (count == tests.Count)
                {
                    tran.Commit();
                    return true;
                }
                else
                {
                    tran.Rollback();
                    return false;
                }
            }
            catch (SqlException ex)
            {
                tran.Rollback();
                throw ex;
            }
            finally
            {
                if (connection != null)
                connection.Close();
            }
        }
    }
}
