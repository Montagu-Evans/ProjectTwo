using System.Configuration;
using System.Data.SqlClient;

namespace DAL
{
    public class DB
    {
        public static string ConnectionString
        {
            get
            {
                string connectionString = ConfigurationManager.ConnectionStrings["Clocks"].ToString();

                var newConnectionString = new SqlConnectionStringBuilder(connectionString);
                newConnectionString.ApplicationName = ApplicationName ?? newConnectionString.ApplicationName;
                newConnectionString.ConnectTimeout = (ConnectionTimeout > 0)
                    ? ConnectionTimeout
                    : newConnectionString.ConnectTimeout;

                return newConnectionString.ToString();
            }
        }

        public static int ConnectionTimeout { get; set; }

        public static string ApplicationName { get; set; }

        public static SqlConnection GetSqlConnection()
        {
            var conn = new SqlConnection(ConnectionString);
            conn.Open();
            return conn;
        }
    }
}
