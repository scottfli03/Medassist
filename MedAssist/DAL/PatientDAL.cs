using MedAssist.Model;
using System;
using System.Collections.Generic;
using System.Data;
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
                "(FirstName, MInit, LastName, SSN, StreetAddress1, StreetAddress2, City, State, ZipCode, Phone, DOB, Gender) " +
                "Values (@FirstName, @MInit, @LastName, @SSN, @StreetAddress1, @StreetAddress2, @City, @State, @ZipCode, @Phone, @DOB, @Gender)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue("@SSN", patient.SSN);
            insertCommand.Parameters.AddWithValue("@FirstName", patient.FirstName);
            insertCommand.Parameters.AddWithValue("@LastName", patient.LastName);
            insertCommand.Parameters.AddWithValue("@MInit", patient.MInit);
            insertCommand.Parameters.AddWithValue("@StreetAddress1", patient.StreetAddr1);
            insertCommand.Parameters.AddWithValue("@StreetAddress2", patient.StreetAddr2);
            insertCommand.Parameters.AddWithValue("@City", patient.City);
            insertCommand.Parameters.AddWithValue("@State", patient.State);
            insertCommand.Parameters.AddWithValue("@ZipCode", patient.ZipCode);
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


        /// <summary>
        /// Update Patient Info
        /// </summary>
        /// <param name="oldPatient"></param>
        /// <param name="newPatient"></param>
        /// <returns>If the update is successful or not</returns>
        public static bool UpdatePatient(Patient oldPatient, Patient newPatient)
        {
            SqlConnection connection = MedassistDB.GetConnection();
            string updateStatement =
                "UPDATE Patients SET " +
                "FirstName = @NewFirstName, " +
                "LastName = @NewLastName, " +
                "MInit = @NewMInit, " +
                "StreetAddress1 = @NewStreetAddress1, " +
                "StreetAddress2 = @NewStreetAddress2, " +
                "Phone = @NewPhone, " +
                "City = @NewCity, " +
                "State = @NewState, " +
                "ZipCode = @NewZipCode " +
                "WHERE PatientID = @OldPatientID";
            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
            updateCommand.Parameters.AddWithValue("@NewFirstName", newPatient.FirstName);
            updateCommand.Parameters.AddWithValue("@NewLastName", newPatient.LastName);
            updateCommand.Parameters.AddWithValue("@NewMInit", newPatient.MInit);
            updateCommand.Parameters.AddWithValue("@NewStreetAddress1", newPatient.StreetAddr1);
            updateCommand.Parameters.AddWithValue("@NewStreetAddress2", newPatient.StreetAddr2);
            updateCommand.Parameters.AddWithValue("@NewPhone", newPatient.Phone);
            updateCommand.Parameters.AddWithValue("@NewCity", newPatient.City);
            updateCommand.Parameters.AddWithValue("@NewState", newPatient.State);
            updateCommand.Parameters.AddWithValue("@NewZipCode", newPatient.ZipCode);
            updateCommand.Parameters.AddWithValue("@OldPatientID", oldPatient.PatientID);
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
                if (connection != null)
                    connection.Close();
            }
        }

        /// <summary>
        /// Gets patient to Update
        /// </summary>
        /// <param name="patientID"></param>
        /// <returns>The Patient</returns>
        public static Patient GetPatientToUpdate(int patientID)
        {
            Patient patient = new Patient();
            SqlConnection connection = MedassistDB.GetConnection();
            string selectStatement =

                   "SELECT PatientID, FirstName, MInit, DOB, Gender, SSN, LastName, StreetAddress1, StreetAddress2, City, State, ZipCode, Phone " +
                   "FROM Patients " +
                   "WHERE PatientID = @PatientID";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@PatientID", patientID);

            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (reader.Read())
                {

                    patient.PatientID = (int)reader["PatientID"];
                    patient.FirstName = reader["FirstName"].ToString();
                    patient.LastName = reader["LastName"].ToString();
                    patient.MInit = Convert.ToChar(reader["Minit"]);
                    patient.DOB = (DateTime)reader["DOB"];
                    patient.Gender = Convert.ToChar(reader["Gender"]);
                    patient.SSN = reader["SSN"].ToString();
                    patient.StreetAddr1 = reader["StreetAddress1"].ToString();
                    patient.StreetAddr2 = reader["StreetAddress2"].ToString();
                    patient.City = reader["City"].ToString();
                    patient.State = reader["State"].ToString();
                    patient.ZipCode = reader["ZipCode"].ToString();
                    patient.Phone = reader["Phone"].ToString();

                }
                else
                {
                    patient = null;
                }
                reader.Close();
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
            return patient;
        }

        /// <summary>
        /// Gets List of Patients
        /// </summary>
        /// <returns>List of Patient Objects</returns>
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
                    patient.PatientID = (int)reader["PatientID"];
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
