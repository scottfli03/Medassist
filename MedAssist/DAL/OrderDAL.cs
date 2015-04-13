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

        public static BindingList<OrderDetails> GetPatientsOrdersWithDetails(int patientID)
        {
            BindingList<OrderDetails> orderList = new BindingList<OrderDetails>();
            SqlConnection connection = MedassistDB.GetConnection();
            String selectStatement = "SELECT o.OrderID, o.OrderDate, o.DatePerformed, o.Result, o.TestID, v.VisitID " +
                "(p.LastName + ', ' + p.FirstName) AS PatientName, t.TestName " +
                "FROM Orders o JOIN Visits v ON o.VisitID = v.VisitID " +
                "JOIN Tests t ON t.TestID = o.TestID " +
                "WHERE v.PatientID = @PatientID";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@PatientID", patientID);
            SqlDataReader reader = null;
            try
            {
                connection.Open();
                reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    OrderDetails order = new OrderDetails();
                    order.OrderID = (int)reader["OrderID"];
                    order.OrderDate = (DateTime)reader["OrderDate"];
                    order.DatePerformed = (DateTime)reader["DatePerformed"];
                    order.Result = (char?)reader["Result"];
                    order.TestID = (int)reader["TestID"];
                    order.VisitID = (int)reader["VisitID"];
                    order.PatientName = reader["PatientName"].ToString();
                    order.TestName = reader["TestName"].ToString();
                    orderList.Add(order);
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
                if (reader != null)
                    reader.Close();
            }
            return orderList;
        }
    }
}
