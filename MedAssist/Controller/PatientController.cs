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
    }
}
