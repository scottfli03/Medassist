using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MedAssist.Model;

namespace MedAssist.DAL
{
    class UserSecurityDAL
    {
        public static bool UpdatePassword(UserSecurity oldUser, UserSecurity newUser)
        {
            string updateCommand = "UPDATE UserSecurity SET " +
                "Password = @newPassword " +
                "WHERE UserName = @oldUserName AND " +
                "Password = @oldPassword";

            try
            {
                using (SqlConnection connection = new SqlConnection())
                {
                    connection.Open();

                    using (SqlCommand cmnd = new SqlCommand(updateCommand, connection))
                    {
                        cmnd.Parameters.AddWithValue("@newPassword", newUser.Password);
                        cmnd.Parameters.AddWithValue("@oldUserName", oldUser.UserName);
                        cmnd.Parameters.AddWithValue("@oldPassword", oldUser.Password);

                        int count = cmnd.ExecuteNonQuery();
                        if (count > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }


                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            catch (Exception ex)
            {
                throw ex;
            }

        }

       
       
    }

   
}


