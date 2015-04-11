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
        private string patientName;
        private int patientID;

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

        // this was DoctorID. Changed by Greene. 
        public string TestName
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

        public string PatientName
        {
            get
            {
                return patientName;
            }
            set
            {
                patientName = value;
            }
        }

        public int PatientID
        {
            get
            {
                return patientID;
            }
            set 
            {
                patientID = value;
            }
        }
    }
}
