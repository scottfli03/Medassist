﻿using MedAssist.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedAssist.DAL
{
    class PatientDAL
    {

        /// <summary>
        /// Gets patient to Update
        /// </summary>
        /// <param name="patientID"></param>
        /// <returns>The Patient</returns>
        public static Patient GetPatientToUpdateWithNoID(string FirstName, string LastName, DateTime DOB)
        {
            Patient patient = new Patient();
            SqlConnection connection = MedassistDB.GetConnection();
            string selectStatement =

                   "SELECT PatientID, FirstName, MInit, DOB, Gender, SSN, LastName, StreetAddress1, StreetAddress2, City, State, ZipCode, Phone " +
                   "FROM Patients " +
                   "WHERE FirstName = @FirstName AND LastName = @LastName AND DOB = @DOB";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            SqlDataReader reader = null;
            selectCommand.Parameters.AddWithValue("@FirstName", FirstName);
            selectCommand.Parameters.AddWithValue("@LastName", LastName);
            selectCommand.Parameters.AddWithValue("@DOB", DOB);
            try
            {
                connection.Open();
                reader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (reader.Read())
                {
                    patient.PatientID = (int)reader["PatientID"];
                    patient.FirstName = reader["FirstName"].ToString();
                    patient.LastName = reader["LastName"].ToString();
                    
                    //if (reader["MInit"] == DBNull.Value)
                    //{
                    //    patient.MInit = '\0';
                    //}
                    //else
                    //{
                    //    patient.MInit = Convert.ToChar(reader["Minit"]);
                    //}

                    patient.DOB = (DateTime)reader["DOB"];
                    patient.Gender = Convert.ToChar(reader["Gender"]);
                    patient.SSN = Convert.ToInt32(reader["SSN"]);
                    patient.StreetAddr1 = reader["StreetAddress1"].ToString();
                    patient.StreetAddr2 = reader["StreetAddress2"].ToString();
                    patient.City = reader["City"].ToString();
                    patient.State = reader["State"].ToString();
                    patient.ZipCode = Convert.ToInt64(reader["ZipCode"]);
                    patient.Phone = Convert.ToInt64(reader["Phone"]);
                }
                else
                {
                    patient = null;
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
            return patient;
        }
        
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
            SqlDataReader reader = null;
            selectCommand.Parameters.AddWithValue("@PatientID", patientID);
            try
            {
                connection.Open();
                reader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (reader.Read())
                {
                    patient.PatientID = (int)reader["PatientID"];
                    patient.FirstName = reader["FirstName"].ToString();
                    patient.LastName = reader["LastName"].ToString();
                    patient.MInit = reader["Minit"].ToString();

                    //if (reader["MInit"] == DBNull.Value) {
                    //    patient.MInit = '\0';
                    //}
                    //else
                    //{
                    //    patient.MInit = Convert.ToChar(reader["Minit"]);
                    //}
                    patient.DOB = (DateTime)reader["DOB"];
                    patient.Gender = Convert.ToChar(reader["Gender"]);
                    patient.SSN =  Convert.ToInt32(reader["SSN"]);
                    patient.StreetAddr1 = reader["StreetAddress1"].ToString();
                    patient.StreetAddr2 = reader["StreetAddress2"].ToString();
                    patient.City = reader["City"].ToString();
                    patient.State = reader["State"].ToString();
                    patient.ZipCode = Convert.ToInt64(reader["ZipCode"]);
                    patient.Phone = Convert.ToInt64(reader["Phone"]);
                }
                else
                {
                    patient = null;
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
                    patient.Phone = (int)reader["MInit"];
                    //patient.MInit = reader["MInit"].ToString()[0];
                    patient.MInit = reader["MInit"].ToString();
                    patient.LastName = reader["LastName"].ToString();
                    patient.DOB = (DateTime)reader["DOB"];
                    patient.Gender = reader["Gender"].ToString()[0];
                    patient.StreetAddr1 = reader["StreetAddress1"].ToString();
                    patient.StreetAddr2 = reader["StreetAddress2"].ToString();
                    patient.City = reader["City"].ToString();
                    patient.State = reader["State"].ToString();
                    patient.ZipCode = (long)reader["ZipCode"];
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

        /// <summary>
        /// Gets patients in the db by Date of birth
        /// </summary>
        /// <param name="patientDob"></param>
        /// <returns></returns>
        public static List<Patient> GetPatientsByDOB(DateTime patientDob)
        {
            List<Patient> patientList = new List<Patient>();
            SqlConnection connection = MedassistDB.GetConnection();

            var selectStatement = string.Format(@"
                SELECT  
                     Patients.FirstName
                    ,Patients.MInit
                    ,Patients.LastName
                    ,Patients.DOB      
                    ,Visits.VisitID
                    ,Visits.VisitDate
                    ,Visits.PatientID
                    ,Visits.Diagnosis
                    ,Visits.Systolic
                    ,Visits.Diastolic
                    ,Visits.Temperature
                    ,Visits.RespirationRate
                    ,Visits.HeartRate
                    ,Visits.Symptoms
                    ,Orders.Result
                    ,Orders.TestID
                    ,Tests.TestName
                FROM Patients
                LEFT JOIN Visits
                ON Patients.PatientID = Visits.PatientID 
                LEFT OUTER JOIN Orders ON Visits.VisitID = Orders.VisitID
                LEFT OUTER JOIN Tests ON Orders.TestID = Tests.TestID
                WHERE Patients.DOB = '{0}'", patientDob);

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            SqlDataReader reader = null;
            try
            {
                connection.Open();
                reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {

                    Patient patient = new Patient();
                    patient.FirstName = reader["FirstName"].ToString();

                    patient.MInit = reader["MInit"].ToString();
                    //if (patient.MInit != null)
                    //{
                    //    patient.MInit = (char)reader["MInit"];
                    //}
                    //else
                    //{
                    //    patient.MInit = null;
                    //}

                    patient.LastName = reader["LastName"].ToString();
                    patient.DOB = (DateTime)reader["DOB"];
                    if (patient.VisitDate != null)
                    {
                        patient.VisitDate = (DateTime?)reader["VisitDate"];
                    }
                    else
                    {
                        patient.VisitDate = null;
                    }
                    
                    //patient.PatientID = (int)reader["PatientID"];
                    if (patient.Systolic != null)
                    {
                        patient.Systolic = (int?)reader["Systolic"];
                    }
                    else
                    {
                        patient.Systolic = null;
                    }
                    if (patient.Diastolic != null)
                    {
                        patient.Diastolic = (int)reader["Diastolic"];
                    }
                    else
                    {
                        patient.Diastolic = null;
                    }

                    if (patient.Temperature != null)
                    {
                        patient.Temperature = (decimal)reader["Temperature"];
                    }

                    if (patient.RespirationRate != null)
                    {
                        patient.RespirationRate = (int)reader["RespirationRate"];
                    }
                    else
                    {
                        patient.RespirationRate = null;
                    }

                    if (patient.HeartRate != null)
                    {
                        patient.HeartRate = (int)reader["HeartRate"];
                    }
                    else
                    {
                        patient.HeartRate = null;
                    }

                    if (patient.Symptoms != null)
                    {
                       patient.Symptoms = reader["Symptoms"].ToString(); 
                    }
                    else
                    {
                        patient.Symptoms = null;
                    }

                    if (patient.Result != null)
                    {
                        patient.Result = reader["Result"].ToString();
                    }
                    else
                    {
                        patient.Result = null;
                    }
                    if (patient.TestID != null)
                    {
                        patient.TestID = (int)reader["TestID"];
                    }
                    else
                    {
                        patient.TestID = null;
                    }

                    if (patient.TestName != null)
                    {
                        patient.TestName = reader["TestName"].ToString();
                    }
                    else
                    {
                        patient.TestName = null;
                    }

                    if (patient.Diagnosis != null)
                    {
                        patient.Diagnosis = reader["Diagnosis"].ToString();
                    }
                    else
                    {
                        patient.Diagnosis = null;
                    }

                    if (patient.VisitID != null)
                    {
                        patient.VisitID = (int)reader["VisitID"];
                    }
                    else
                    {
                        patient.VisitID = null;
                    }
                    


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


        /// <summary>
        /// Gets List of visits for patients by there first and last name
        /// Added by Greene
        /// </summary>
        /// <returns></returns>
        public static List<Patient> GetVisitForPatientWithDobAndLName(string lName, DateTime patientDob)
        {
            List<Patient> patientList = new List<Patient>();
            SqlConnection connection = MedassistDB.GetConnection();

            var selectStatement = string.Format(@"
                SELECT        
                    Visits.VisitID
                    ,Visits.VisitDate
                    ,Visits.PatientID
                    ,Visits.Diagnosis
                    ,Visits.Systolic
                    ,Visits.Diastolic
                    ,Visits.Temperature
                    ,Visits.RespirationRate
                    ,Visits.HeartRate
                    ,Visits.Symptoms
                    ,Patients.FirstName
                    ,Patients.MInit
                    ,Patients.LastName
                    ,Patients.DOB
                    ,Orders.Result
                    ,Orders.TestID
                    ,Tests.TestName
                FROM Patients 
                LEFT JOIN Visits
                ON Visits.PatientID = Patients.PatientID
                LEFT JOIN Orders ON Visits.VisitID = Orders.VisitID
                LEFT JOIN Tests ON Orders.TestID = Tests.TestID
                WHERE
                    
                    Patients.LastName = '{0}'
                    AND Patients.DOB = '{1}'", lName, patientDob);

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            SqlDataReader reader = null;
            try
            {
                connection.Open();
                reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
     
                    Patient patient = new Patient();

                    if (patient.VisitID != null)
                    {
                        patient.VisitID = (int?)reader["VisitID"];
                    }
                    else
                    {
                        patient.VisitID = null;
                    }


                    if (patient.VisitDate != null)
                    {
                        patient.VisitDate = (DateTime?)reader["VisitDate"];
                    }
                    else
                    {
                        patient.VisitDate = null;
                    }

                    //patient.PatientID = (int)reader["PatientID"];

                    patient.FirstName = reader["FirstName"].ToString();
                    patient.MInit = reader["MInit"].ToString();
                    //if (patient.MInit != null)
                    //{
                    //    patient.MInit = (char)reader["MInit"];
                    //}
                    //else
                    //{
                    //    patient.MInit = null;
                    //}

                    patient.LastName = reader["LastName"].ToString();
                    patient.DOB = (DateTime)reader["DOB"];
                    if (patient.Systolic != null)
                    {
                        patient.Systolic = (int)reader["Systolic"];
                    }
                    else
                    {
                        patient.Systolic = null;
                    }

                    if (patient.Diastolic != null)
                    {
                        patient.Diastolic = (int)reader["Diastolic"];
                    }
                    else
                    {
                        patient.Diastolic = null;
                    }

                    if (patient.Temperature != null)
                    {
                        patient.Temperature = (int)reader["Temperature"];
                    }
                    else
                    {
                        patient.Temperature = null;
                    }

                    if (patient.RespirationRate != null)
                    {
                        patient.RespirationRate = (int)reader["RespirationRate"];
                    }
                    else
                    {
                        patient.RespirationRate = null;
                    }

                    if (patient.HeartRate != null)
                    {
                        patient.HeartRate = (int)reader["HeartRate"];
                    }
                    else
                    {
                        patient.HeartRate = null;
                    }


                    patient.Symptoms = reader["Symptoms"].ToString();
                    patient.Result = reader["Result"].ToString();

                    if (patient.TestID != null)
                    {
                        patient.TestID = (int?)reader["TestID"];
                    }
                    else
                    {
                        patient.TestID = null;
                    }

                    if (patient.TestName != null)
                    {
                        patient.TestName = reader["TestName"].ToString();
                    }
                    else
                    {
                        patient.TestName = null;
                    }

                    if (patient.Diagnosis != null)
                    {
                        patient.Diagnosis = reader["Diagnosis"].ToString();
                    }
                    else
                    {
                        patient.Diagnosis = null;
                    }

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



        /// <summary>
        /// Gets List of visits for patients by there first and last name
        /// Added by Greene
        /// </summary>
        /// <returns></returns>
        public static List<Patient> GetVisitForPatient(string fName, string lName)
        {
            List<Patient> patientList = new List<Patient>();
            SqlConnection connection = MedassistDB.GetConnection();

            var selectStatement = string.Format(@"
                SELECT        
                    Visits.VisitID
                    ,Visits.VisitDate
                    ,Visits.PatientID
                    ,Visits.Diagnosis
                    ,Visits.Systolic
                    ,Visits.Diastolic
                    ,Visits.Temperature
                    ,Visits.RespirationRate
                    ,Visits.HeartRate
                    ,Visits.Symptoms
                    ,Patients.FirstName
                    ,Patients.MInit
                    ,Patients.LastName
                    ,Patients.DOB
                    ,Orders.Result
                    ,Orders.TestID
                    ,Tests.TestName
                FROM Patients 
                LEFT JOIN Visits
                ON Visits.PatientID = Patients.PatientID
                LEFT JOIN Orders ON Visits.VisitID = Orders.VisitID
                LEFT JOIN Tests ON Orders.TestID = Tests.TestID
                WHERE
                    Patients.FirstName = '{0}'
                    AND Patients.LastName = '{1}'", fName, lName);

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            SqlDataReader reader = null;
            try
            {
                connection.Open();
                reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Patient patient = new Patient();
                    
                    if (patient.VisitID != null)
                    {
                        patient.VisitID = (int?)reader["VisitID"];
                    }
                    else
                    {
                        patient.VisitID = null;
                    }
                    
                    
                    if (patient.VisitDate != null)
                    {
                        patient.VisitDate = (DateTime?)reader["VisitDate"];
                    }
                    else
                    {
                        patient.VisitDate = null;
                    }
                   
                    //patient.PatientID = (int)reader["PatientID"];
                    
                    patient.FirstName = reader["FirstName"].ToString();
                    patient.MInit = reader["MInit"].ToString();
                    //if (patient.MInit != null)
                    //{
                    //   patient.MInit = (char)reader["MInit"];
                    //}
                    //else
                    //{
                    //    patient.MInit = null;
                    //}
                    
                    patient.LastName = reader["LastName"].ToString();
                    patient.DOB = (DateTime)reader["DOB"];
                    if (patient.Systolic != null)
                    {
                        patient.Systolic = (int)reader["Systolic"];
                    }
                    else
                    {
                        patient.Systolic = null;
                    }

                    if (patient.Diastolic != null)
                    {
                        patient.Diastolic = (int)reader["Diastolic"];
                    }
                    else
                    {
                        patient.Diastolic = null;
                    }

                    if (patient.Temperature != null)
                    {
                        patient.Temperature = (int)reader["Temperature"];
                    }
                    else
                    {
                        patient.Temperature = null;
                    }

                    if (patient.RespirationRate != null)
                    {
                        patient.RespirationRate = (int)reader["RespirationRate"];
                    }
                    else
                    {
                        patient.RespirationRate = null;
                    }

                    if (patient.HeartRate != null)
                    {
                        patient.HeartRate = (int)reader["HeartRate"];
                    }
                    else
                    {
                        patient.HeartRate = null;
                    }

                    
                    patient.Symptoms = reader["Symptoms"].ToString();
                    patient.Result = reader["Result"].ToString();

                    if (patient.TestID != null)
                    {
                        patient.TestID = (int?)reader["TestID"];
                    }
                    else
                    {
                        patient.TestID = null;
                    }

                    if (patient.TestName != null)
                    {
                        patient.TestName = reader["TestName"].ToString();
                    }
                    else
                    {
                        patient.TestName = null;
                    }
                        
                    if (patient.Diagnosis != null)
                    {
                        patient.Diagnosis = reader["Diagnosis"].ToString();
                    }
                    else
                    {
                        patient.Diagnosis = null;
                    }
                    


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



