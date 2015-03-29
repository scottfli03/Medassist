using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedAssist.Model;
using MedAssist.DAL;

namespace MedAssist.Controller
{
    class ControllerNurse
    {
        public Nurse GetNurse(string userName, string password)
        {
            return NurseDAL.GetNurse(userName, password);
        }
    }
}
