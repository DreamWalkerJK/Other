using Dapper;
using System;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace DataGridViewPaged_WinForm
{
    public class DBUtil
    {
        public static SQLiteConnection GetSQLiteConnection()
        {
            // sqlite 数据库地址
            string dir = AppDomain.CurrentDomain.BaseDirectory;
            var con = new SQLiteConnection("Data Source=" + dir + "\\Data.db");
            return con;
        }

        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="recordCount"></param>
        /// <returns></returns>
        public static DataTable GetListTable(int pageIndex, int pageSize, ref int recordCount)
        {
            using (IDbConnection conn = new SQLiteConnection(GetSQLiteConnection()))
            {
                pageIndex--;
                DataTable dt = new DataTable();
                conn.Open();

                StringBuilder sbCountSQL = new StringBuilder();
                sbCountSQL.Append(@"select count(Id) recordCount from User where 1 = 1");
                StringBuilder sbQuerySQL = new StringBuilder();
                sbQuerySQL.Append(@"select * from User where 1 = 1");

                recordCount = conn.Query<int>(sbCountSQL.ToString()).FirstOrDefault();
                sbQuerySQL.Append(" order by Id asc");
                sbQuerySQL.AppendFormat(" limit {0} offset {1}", pageSize, pageSize * pageIndex);

                var reader = conn.ExecuteReader(sbQuerySQL.ToString());
                dt.Load(reader);

                return dt;
            }
        }
    }
}
