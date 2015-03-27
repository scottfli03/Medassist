using MedAssist.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedAssist.DAL
{
    class PatientDAL
    {
        /// <summary>
        /// Query to add patients
        /// </summary>
        /// <param name=patient"></param>
        /// <returns>incident added</returns>
        public static int AddPatient(Patient patient)
        {

            SqlConnection connection = MedassistDB.GetConnection();
            string insertStatement =
                "Insert Patients " +
                "(FirstName, MiddleInit, LastName, SSN, StreetAddress1,, StreetAddress2, City, State, Zip, Phone, DOB, Gender) " +
                "Values (@FirstName, @MiddleInit @LastName, @SSN, @StreetAddress1, @StreetAddress2, @City, @State, @Zip, @Phone, @DOB, @Gender)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue("@SSN", patient.SSN);
            insertCommand.Parameters.AddWithValue("@FirstName", patient.FirstName);
            insertCommand.Parameters.AddWithValue("@LastName", patient.LastName);
            insertCommand.Parameters.AddWithValue("@MInit", patient.MInit);
            insertCommand.Parameters.AddWithValue("@StreetAddress", patient.StreetAddr1);
            insertCommand.Parameters.AddWithValue("@StreetAddress", patient.StreetAddr2);
            insertCommand.Parameters.AddWithValue("@City", patient.City);
            insertCommand.Parameters.AddWithValue("@State", patient.State);
            insertCommand.Parameters.AddWithValue("@Zip", patient.ZipCode);
            insertCommand.Parameters.AddWithValue("@Phone", patient.Phone);
            insertCommand.Parameters.AddWithValue("@DOB", patient.DOB);
            insertCommand.Parameters.AddWithValue("@Gender", patient.Gender);


            try
            {
                connection.Open();
                insertCommand.ExecuteNonQuery();
                string selectStatement =
                    "Select Ident_Current('Patients') FROM Patients";
                SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
                int patientID = Convert.ToInt32(selectCommand.ExecuteScalar());
                return patientID;
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

        public static List<Patient> GetPatientList()
        {
            List<Patient> patientList = new List<Patient>();
            SqlConnection connection = MedassistDB.GetConnection();
            String selectStatement = "SELECT PatientID, SSN, FirstName, MInit, LastName, DOB, Gender, " +
                "StreetAddress1, StreetAddress2, Phone, City, State, ZipCode FROM Patients";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            SqlDataReader reader = null;
            try
            {
                connection.Open();
                reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Patient patient = new Patient();
                    patient.PatientID = (int)reader["TechID"];
                    patient.SSN = reader["SSN"].ToString();
                    patient.FirstName = reader["FirstName"].ToString();
                    patient.Phone = reader["MInit"].ToString();
                    patient.LastName = reader["LastName"].ToString();
                    patient.DOB = (DateTime)reader["DOB"];
                    patient.Gender = reader["Gender"].ToString()[0];
                    patient.StreetAddr1 = reader["StreetAddress1"].ToString();
                    patient.StreetAddr2 = reader["StreetAddress2"].ToString();
                    patient.Phone = reader["Phone"].ToString();
                    patient.City = reader["City"].ToString();
                    patient.State = reader["State"].ToString();
                    patient.ZipCode = reader["ZipCode"].ToString();
                    patientList.Add(patient);

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
            return patientList;
        }
    }
}
