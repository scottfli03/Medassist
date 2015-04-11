using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedAssist.Model;
using MedAssist.DAL;

namespace MedAssist.Controller
{
    /// <summary>
    /// Coordinates the actions between the EmployeeDAL and Views
    /// </summary>
    class EmployeeController
    {
        EmployeeDAL empDAL = new EmployeeDAL();
        public EmployeeController() { }

        /// <summary>
        /// Gets a list of Doctor Employees
        /// </summary>
        /// <returns>The list of Doctor Employees</returns>
        public List<Employee> GetListOfDoctorEmployees()
        {
            return empDAL.GetListOfDoctorEmployees();
        }

        /// <summary>
        /// Gets an employee by their ID
        /// </summary>
        /// <param name="id">EmployeeID</param>
        /// <returns>Employee</returns>
        public static Employee GetEmployeeByID(int id)
        {
            return EmployeeDAL.GetEmployeeByID(id);
        }
    }
}
