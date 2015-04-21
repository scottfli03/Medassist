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

        public static List<Test> GetTest()
        {
            return TestDAL.GetTest();
        }

        public static bool CreateTest(Test test)
        {
            return TestDAL.CreateTest(test);
        }

        public static bool UpdateTest(Test oldTest, Test newTest)
        {
            return TestDAL.UpdateTest(oldTest, newTest);
        }
    }
}
