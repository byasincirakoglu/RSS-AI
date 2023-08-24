

using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Dinamik_Oto_Etiket.DataConnection.MSSQL
{
    public static class DbConnection
    {
        public static DataTable RunSql(string sql)
        {
            var connectionString = System.Configuration.ConfigurationManager.
                    ConnectionStrings["Test"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = sql;
                command.CommandType = CommandType.Text;
                DataTable dt = new DataTable();
                connection.Open();
                dt.Load(command.ExecuteReader());
                connection.Close();
                return dt;
            }
        }
    }
}
