using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedAssist.Model;
using System.Data;
using System.Data.SqlClient;

namespace MedAssist.DAL
{
    class NurseDAL
    {

        public static List<Nurse> GetNurses()
        {
            List<Nurse> NurseList = new List<Nurse>();

            String selectStatement = "SELECT n.UserName, u.Password " +
                "FROM Nurses JOIN UserSecurity u ON n.UserName = u.UserName";

            try
            {
                using (SqlConnection connection = MedassistDB.GetConnection())
                {

                    connection.Open();
                    using (SqlCommand cmnd = new SqlCommand(selectStatement, connection))
                    {

                        using (SqlDataReader reader = cmnd.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                Nurse nurse = new Nurse();

                                nurse.UserName = reader["UserName"].ToString();
                                nurse.Password = reader["Password"].ToString();

                                NurseList.Add(nurse);

                            }

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

            return NurseList;
        }
    }
}