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
    /// Interacts with the Nurse DAL And the View
    /// </summary>
    class ControllerNurse
    {
        /// <summary>
        /// Gets a nurse using the userName and password
        /// </summary>
        /// <param name="userName">UserName</param>
        /// <param name="password">Password</param>
        /// <returns>Nurse</returns>
        public Nurse GetNurse(string userName, string password)
        {
            return NurseDAL.GetNurse(userName, password);
        }
    }
}
