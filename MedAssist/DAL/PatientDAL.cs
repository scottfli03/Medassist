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

    }
}
