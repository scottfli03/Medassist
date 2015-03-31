using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedAssist.Model;
using MedAssist.DAL;

namespace MedAssist.Controller
{
    class EmployeeController
    {
        EmployeeDAL empDAL = new EmployeeDAL();
        public EmployeeController() { }

        public List<Employee> GetListOfDoctorEmployees()
        {
            return empDAL.GetListOfDoctorEmployees();
        }
    }
}
