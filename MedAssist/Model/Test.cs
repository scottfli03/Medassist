using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedAssist.Model
{
    class Test
    {
        private int testID;
        private string testName;

        public Test() { }

        public int TestID
        {
            get
            {
                return testID;
            }
            set
            {
                testID = value;
            }
        }

        public string DoctorID
        {
            get
            {
                return testName;
            }
            set
            {
                testName = value;
            }
        }
    }
}
