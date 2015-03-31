using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedAssist.Model;
using System.Data;
using System.Data.SqlClient;

namespace MedAssist.DAL
{
    /// <summary>
    /// Used to interact with the Employee Table of the database
    /// </summary>
    class EmployeeDAL
    {
        public EmployeeDAL() { }

        /// <summary>
        /// Gets a list of Employees that are doctors and returns that list.
        /// </summary>
        /// <returns>Employee List of Doctor Employees</returns>
        public List<Employee> GetListOfDoctorEmployees()
        {
            List<Employee> employeeList = new List<Employee>();
            SqlConnection connection = MedassistDB.GetConnection();
            String selectStatement = "SELECT EmployeeID, SSN, FirstName, MInit, LastName, DOB, Gender, " +
	            "StreetAddress1, StreetAddress2, Phone, City, State, ZipCode " +
                "FROM Employees e JOIN Doctors d ON e.EmployeeID = d.DoctorID";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            SqlDataReader reader = null;
            try
            {
                connection.Open();
                reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Employee employee = new Employee();
                    employee.EmployeeID = (int)reader["EmployeeID"];
                    employee.SSN = reader["SSN"].ToString();
                    employee.FirstName = reader["FirstName"].ToString();
                    employee.Phone = reader["MInit"].ToString();
                    employee.LastName = reader["LastName"].ToString();
                    employee.DOB = (DateTime)reader["DOB"];
                    employee.Gender = reader["Gender"].ToString()[0];
                    employee.StreetAddr1 = reader["StreetAddress1"].ToString();
                    employee.StreetAddr2 = reader["StreetAddress2"].ToString();
                    employee.Phone = reader["Phone"].ToString();
                    employee.City = reader["City"].ToString();
                    employee.State = reader["State"].ToString();
                    employee.ZipCode = reader["ZipCode"].ToString();
                    employeeList.Add(employee);
                }
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
                if (reader != null)
                    reader.Close();
            }
            return employeeList;
        }
    }
}
