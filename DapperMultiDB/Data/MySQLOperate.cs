using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperMultiDB.Data
{
    public class MySQLOperate
    {
        public static int Add<T>(string sql, T t)
            where T : class
        {
            using (IDbConnection connection = DataService.GetMySqlConnection())
            {
                return connection.Execute(sql, t);
            }
        }

        public static int Add<T>(string sql, List<T> t)
            where T : class
        {
            using (IDbConnection connection = DataService.GetMySqlConnection())
            {
                return connection.Execute(sql, t);
            }
        }

        public static int Delete<T>(string sql, T t)
            where T : class
        {
            using (IDbConnection connection = DataService.GetMySqlConnection())
            {
                return connection.Execute(sql, t);
            }
        }

        public static int Delete<T>(string sql, List<T> t)
            where T : class
        {
            using (IDbConnection connection = DataService.GetMySqlConnection())
            {
                return connection.Execute(sql, t);
            }
        }

        public static int Update<T>(string sql, T t)
            where T : class
        {
            using (IDbConnection connection = DataService.GetMySqlConnection())
            {
                return connection.Execute(sql, t);
            }
        }

        public static int Update<T>(string sql, List<T> t)
            where T : class
        {
            using (IDbConnection connection = DataService.GetMySqlConnection())
            {
                return connection.Execute(sql, t);
            }
        }

        public static T Query<T>(string sql, T t)
            where T : class
        {
            using (IDbConnection connection = DataService.GetMySqlConnection())
            {
                return connection.Query<T>(sql, t).SingleOrDefault();
            }
        }

        public static List<T> Query<T>(string sql)
            where T : class
        {
            using (IDbConnection connection = DataService.GetMySqlConnection())
            {
                return connection.Query<T>(sql).ToList();
            }
        }

        public static List<T> Query<T>(string sql, object[] ids)
            where T : class
        {
            using (IDbConnection connection = DataService.GetMySqlConnection())
            {
                return connection.Query<T>(sql, new { ids }).ToList();
            }
        }
    }
}
