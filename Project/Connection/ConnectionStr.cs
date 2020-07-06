using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Connection
{
    class ConnectionStr
    {

        public static string strcon;
        public static string UserfullnameLogin;

        public static void connectsql()
        {
            strcon = "Data Source=DESKTOP-E8RQ441;Initial Catalog=Minimart;Integrated Security=True";
        }


        public static DataTable executsql(string sql)
        {
            SqlDataAdapter dtAdapter = default(SqlDataAdapter);
            SqlConnection objConn = new SqlConnection();
            DataTable dt = new DataTable();

            try
            {
                objConn.ConnectionString = strcon;
                objConn.Open();
                dtAdapter = new SqlDataAdapter(sql,objConn);
                dtAdapter.Fill(dt);
                objConn.Close();
                objConn = null;
                return dt;
            }
            catch (Exception Error)
            {
                Console.Write(Error.ToString());
                dt = null;

            }

            return dt;
        }
    }
}
