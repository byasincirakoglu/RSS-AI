

using System;
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
                try
                {
                    connection.Open();
                }
                catch(Exception ex) 
                {
                    MessageBox.Show("Connection Sağlanmadı" + "-----"+sql+"-------" + ex.Message);
                }

                try
                {
                    dt.Load(command.ExecuteReader());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tablo Doldurulamadı" + "-----" + sql + "-------" + ex.Message);
                }
                connection.Close();
                return dt;
            }
        }
    }
}
