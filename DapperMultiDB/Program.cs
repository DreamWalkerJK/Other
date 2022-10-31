using DapperMultiDB.Data;
using DapperMultiDB.Model;
using System;
using System.Collections.Generic;

namespace DapperMultiDB
{
    class Program
    {
        static void Main(string[] args)
        {
            var addClass = new Class
            {
                CId = "C_1005",
                CName = "Temp"
            };

            // 增
            //var addTest = string.Format(@"insert into Class(CId, CName) values(@CId, @CName)");
            //PostgreSQLOperate.Add(addTest, addClass);

            //改
            //addClass.CName = "Temp1";
            //var updateTest = string.Format(@"Update public.Class set CName=@CName where CId=@CId");
            //PostgreSQLOperate.Update(updateTest, addClass);

            //查
            //var classList = MySQLOperate.Query<Class>(string.Format(@"select * from Class where 1 = 1"));
            //var classList = PostgreSQLOperate.Query<Class>(string.Format(@"select * from public.Class where 1 = 1"));
            //var classList = SQLiteOperate.Query<Class>(string.Format(@"select * from Class where 1 = 1"));
            //var classList = SQLiteOperate.Query<Class>(string.Format(@"select * from Class where 1 = 1"));

            //批量查询
            //var ids = new string[2] { "c_1002", "c_1003" };
            //var queryTest = "select * from public.Class where CId = ANY (@ids)";
            //var classList = PostgreSQLOperate.Query<Class>(queryTest, ids);

            //多重查询
            var classList = new List<Class>();
            var studentList = new List<Student>();
            PostgreSQLOperate.QueryMultiple<Class, Student>(string.Format(@"select * from public.Class;select * from public.Student;"), 
                out classList, out studentList);

            foreach (var c in classList)
            {
                Console.WriteLine($"{c.CId} : {c.CName}");
            }

            foreach(var s in studentList)
            {
                Console.WriteLine($"{s.SId}:{s.SName},{s.SAge},{s.SGender},{s.ClassId}");
            }

            // 删
            //PostgreSQLOperate.Delete(string.Format(@"delete from public.Class where CId=@CId;"), addClass);
            //classList = PostgreSQLOperate.Query<Class>(string.Format(@"select * from public.Class where 1 = 1"));

            //foreach (var c in classList)
            //{
            //    Console.WriteLine($"{c.CId} : {c.CName}");
            //}

            Console.ReadKey();
        }
    }
}
