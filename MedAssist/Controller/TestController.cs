using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedAssist.Model;
using MedAssist.DAL;

namespace MedAssist.Controller
{
    class TestController
    {
        public TestController() { }

        public static Test GetTestWithID(int testID)
        {
            return TestDAL.GetTestWithID(testID);
        }
    }
}
