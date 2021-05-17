using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace TimeTable
{
    public class ConnectionManager
    {
        public static SqlConnection NewCon;
        public static string Constr = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;     

        public static SqlConnection GetConnection()
        {
            NewCon = new SqlConnection(Constr);
            return NewCon;
        }

    }
}
