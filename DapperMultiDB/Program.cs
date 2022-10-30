using DapperMultiDB.Data;
using DapperMultiDB.Model;
using System;
namespace DapperMultiDB
{
    class Program
    {
        static void Main(string[] args)
        {
            var classList = MySQLOperate.Query<Class>(string.Format("select * from Class where 1 = 1"));
            //var classList = PostgreSQLOperate.Query<Class>(string.Format("select * from public.Class where 1 = 1"));
            //var classList = SQLiteOperate.Query<Class>(string.Format("select * from Class where 1 = 1"));
            //var classList = SQLiteOperate.Query<Class>(string.Format("select * from Class where 1 = 1"));

            foreach(var c in classList)
            {
                Console.WriteLine($"{c.CId} : {c.CName}");
            }

            Console.ReadKey();
        }
    }
}
