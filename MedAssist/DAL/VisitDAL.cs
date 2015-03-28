using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedAssist.Model;
using System.Data.SqlClient;

namespace MedAssist.DAL
{
    class VisitDAL
    {
        public VisitDAL() { }

        public int createVisit(Visit visit)
        {
            SqlConnection connection = MedassistDB.GetConnection();
            string insertStatement = "INSERT INTO Visits " +
                "(VisitDate, NurseID, PatientID, DoctorID, Diagnosis, Systolic, Diastolic, " +
                    "Temperature, RespirationRate, HeartRate, Symptoms) " +
                "VALUES (@VisitDate, @NurseID, @PatientID, @DoctorID, @Diagnosis, @Systolic, @Diastolic, " +
                    "@Temperature, @RespirationRate, @HeartRate, @Symptoms)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue("@VisitDate", visit.VisitDate);
            insertCommand.Parameters.AddWithValue("@NurseID", visit.NurseID);
            insertCommand.Parameters.AddWithValue("@PatientID", visit.PatientID);
            insertCommand.Parameters.AddWithValue("@DoctorID", visit.DoctorID);
            insertCommand.Parameters.AddWithValue("@Diagnosis", visit.Diagnosis);
            insertCommand.Parameters.AddWithValue("@Systolic", visit.Systolic);
            insertCommand.Parameters.AddWithValue("@Diastolic", visit.Diastolic);
            insertCommand.Parameters.AddWithValue("@Temperature", visit.Temperature);
            insertCommand.Parameters.AddWithValue("@RespirationRate", visit.RespirationRate);
            insertCommand.Parameters.AddWithValue("@HeartRate", visit.HeartRate);
            insertCommand.Parameters.AddWithValue("@Symptoms", visit.Symptoms);
            try
            {
                connection.Open();
                insertCommand.ExecuteNonQuery();
                string selectStatement = "SELECT IDENT_CURRENT('Visits') FROM Visits";
                SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
                int visitID = Convert.ToInt32(selectCommand.ExecuteScalar());
                return visitID;
            }
            catch (SqlException ex)
            {
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
