using Oracle.ManagedDataAccess.Client;
using System.Data.SqlClient;

namespace capstone_Server
{
    internal class DBConn
    {
    }

    class DBConnection
    {
        private static string _connectionString =
                "Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = orcl)));" +
                "User id = SYSTEM" +
                "Password = 1234";
        private OracleConnection conn;

        public DBConnection()
        {
            try
            {
                if (conn == null)
                {
                    conn = new OracleConnection(_connectionString);
                    conn.Open();
                }
            }
            catch (SqlException e)
            {
                serverMainForm.serverMain.logTBox.AppendText(e.Message + "\r\n");
            }
        }

        private string sqlValueControl(OracleConnection conn, string sql)
        {
            string sqlValue = null;

            try
            {
                OracleCommand oc = new OracleCommand(sql, conn);
            }
            catch (SqlException e)
            {
                serverMainForm.serverMain.logTBox.AppendText(e.ToString() + "\r\n");
            }

            return sqlValue;
        }
    }
}
