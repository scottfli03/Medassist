﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedAssist.Model
{
    /// <summary>
    /// A Nurse Object that has a NurseID and 
    /// </summary>
    class Nurse
    {
        private int nurseID;
        private string userName;

        public Nurse() { }

        public int NurseID
        {
            get
            {
                return nurseID;
            }
            set
            {
                nurseID = value;
            }
        }

        public string UserName
        {
            get
            {
                return userName;
            }
            set
            {
                userName = value;
            }
        }
    }
}
