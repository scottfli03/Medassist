using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedAssist.Model;
using System.Data.SqlClient;

namespace MedAssist.DAL
{
    /// <summary>
    /// Interacts with the Visit Table
    /// </summary>
    class VisitDAL
    {
        public VisitDAL() { }

        /// <summary>
        /// Inserts a visit into the Visit Table
        /// </summary>
        /// <param name="visit">The Visit to enter into the table</param>
        /// <returns>The visit ID that was inserted</returns>
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
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

     /// <summary>
        /// Gets List of visits for patients by there first and last name
        /// Added by Greene
        /// </summary>
        /// <returns></returns>
        public static List<Visit> GetVisitForPatient(String fName, String lName)
        {
            List<Visit> visitList = new List<Visit>();
            SqlConnection connection = MedassistDB.GetConnection();
            String selectStatement = @"SELECT        
            Visits.VisitID, Visits.VisitDate, Visits.PatientID, Visits.Diagnosis, Visits.Systolic, 
            Visits.Diastolic, Visits.Temperature, Visits.RespirationRate, Visits.HeartRate, Visits.Symptoms, 
            Patients.FirstName, Patients.MInit, Patients.LastName, Patients.DOB
            FROM Visits 
            INNER JOIN Patients ON Visits.PatientID = Patients.PatientID";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            SqlDataReader reader = null;
            try
            {
                connection.Open();
                reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    
                    Visit visit = new Visit();
                    visit.VisitID = (int)reader["VisitID"];
                    visit.VisitDate = (DateTime)reader["VisitDate"];
                    visit.PatientID = (int)reader["PatientID"];
                    visit.FirstName = reader["FirstName"].ToString();
                    visit.MInit = reader["MInit"].ToString();
                    visit.LastName = reader["LastName"].ToString();
                    visit.DOB = (DateTime)reader["DOB"];
                    visit.Systolic = (int)reader["Systolic"];
                    visit.Diastolic = (int)reader["Diastolic"];
                    visit.Temperature = (int)reader["Temperature"];
                    visit.RespirationRate = (int)reader["RespirationRate"];
                    visit.HeartRate = (int)reader["HeartRate"];
                    visit.Symptoms = reader["Symptoms"].ToString();

                  

                    visitList.Add(visit);

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
            return visitList;
        }
     }
}

