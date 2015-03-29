using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedAssist.DAL;
using MedAssist.Model;

namespace MedAssist.Controller
{
    class VisitController
    {
        public VisitController() {}

        public static int CreateVisit(Visit visit)
        {
            VisitDAL visitDAL = new VisitDAL();
            return visitDAL.createVisit(visit);
        }
    }
}
