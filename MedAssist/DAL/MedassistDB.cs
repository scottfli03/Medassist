using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace MedAssist.DAL
{
    /// <summary>
    /// Gets a connection to the Medassist Database
    /// </summary>
    class MedassistDB
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = "Data Source=localhost; Initial Catalog=cs6232-g5;" +
                "Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
