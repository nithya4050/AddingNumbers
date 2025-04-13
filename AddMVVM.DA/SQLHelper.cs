using Microsoft.Data.SqlClient;
using System.Data;

namespace AddMVVM.DA
{
    public class SQLHelper
    {
        public readonly string ConnectionString;

        public SQLHelper()
        {
            ConnectionString = "Integrated Security = SSPI; Persist Security Info = False ; Initial Catalog = jsquare; Data Source = NITHYA\\SQLEXPRESS;Encrypt=False";
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }

        public int Execute(string sqlquery)
        {
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            SqlCommand ocmd = new SqlCommand(sqlquery, sqlconn);
            int i = ocmd.ExecuteNonQuery();
            sqlconn.Close();
            return 1;
        }

        public int sqlExcuteNonQuery(string sqlquery, SqlParameter[] parameters)
        {
            int output = 0;
            using (SqlConnection sqlcon = GetConnection())
            {
                sqlcon.Open();
                using (SqlCommand sqlcmd = new SqlCommand(sqlquery, sqlcon))
                {
                    sqlcmd.Parameters.AddRange(parameters);
                    output = sqlcmd.ExecuteNonQuery();
                }
                sqlcon.Close();
            }
            return output;
        }

    }

   
}
