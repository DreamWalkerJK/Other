using MySql.Data.MySqlClient;
using Npgsql;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace DapperMultiDB.Data
{
    public class DataService
    {
        public static MySqlConnection GetMySqlConnection()
        {
            string mySQLDBStr = ConfigurationManager.ConnectionStrings["MySQLDB"].ConnectionString;
            var connection = new MySqlConnection(mySQLDBStr);
            connection.Open();
            return connection;
        }

        public static NpgsqlConnection GetPostgreConnection()
        {
            string postgreSQLDBStr = ConfigurationManager.ConnectionStrings["PostgreSQLDB"].ConnectionString;
            var connection = new NpgsqlConnection(postgreSQLDBStr);
            connection.Open();
            return connection;
        }

        public static SQLiteConnection GetSQLiteConnection()
        {
            string sqliteDBStr = ConfigurationManager.ConnectionStrings["SQLiteDB"].ConnectionString;
            var connection = new SQLiteConnection(sqliteDBStr);
            connection.Open();
            return connection;
        }

        public static SqlConnection GetSQLConnection()
        {
            string sqlDBStr = ConfigurationManager.ConnectionStrings["SQLDB"].ConnectionString;
            var connection = new SqlConnection(sqlDBStr);
            connection.Open();
            return connection;
        }
    }
}
