using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedAssist.Model
{
    class Administrator
    {
        private int adminID;
        private string userName;

        public Administrator() { }

        public int AdminID
        {
            get
            {
                return adminID;
            }
            set
            {
                adminID = value;
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
