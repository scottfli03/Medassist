using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedAssist.DAL;
using MedAssist.Model;

namespace MedAssist.Controller
{
    class PatientController
    {
        public PatientController() { }

        /// <summary>
        /// Returns a list of Patients
        /// </summary>
        /// <returns>The list of Patients</returns>
        public List<Patient> GetPatientList()
        {
            return PatientDAL.GetPatientList();
        }

        public static List<Patient> GetVisitForPatient(string fName, string lName) {
            
            return PatientDAL.GetVisitForPatient(fName, lName);
        }

        public static List<Patient> GetPatientsByDOB(DateTime patientDob)
        {
            return PatientDAL.GetPatientsByDOB(patientDob);
        }

        public static List<Patient> GetVisitForPatientWithDobAndLName(string lName, DateTime patientDob)
        {
            return PatientDAL.GetVisitForPatientWithDobAndLName(lName, patientDob);
        }
    }
}
