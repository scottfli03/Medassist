using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedAssist.Model;
using MedAssist.DAL;


namespace MedAssist.Controller
{
    static class UserSecurityController
    {
        public static Nurse NurseLoggedIn = null;

        public static Administrator AdminLoggedIn = null;

        public static bool UpdatePassword(UserSecurity oldUser, UserSecurity newUser)
        {
            return UpdatePassword(oldUser, newUser);
        }
    }

   
}
