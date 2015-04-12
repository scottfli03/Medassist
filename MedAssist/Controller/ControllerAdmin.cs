using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedAssist.DAL;
using MedAssist.Model;

namespace MedAssist.Controller
{
    class ControllerAdmin
    {
        public Administrator GetAdmin(string userName, string password)
        {
            return AdminDAL.GetAdmin(userName, password);
        }
    }
}
