using System;
using System.Windows.Forms;

namespace DataGridViewPaged_WinForm
{
    /// <summary>
    /// WinForm + Dapper + SQLite
    /// </summary>
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

//#region Data.db 测试数据
//create table "User"(
//	"Id" integer not null primary key autoincrement,
//	"UserName" text not null,
//	"Age" integer not null,
//	"Address" text not null,
//	"Hobby" text,
//    unique("Id" asc)
//);

//insert into "User"("Id", "UserName","Age", "Address","Hobby")
//values
//(1, 'xiyangyang', 10, 'qingqingcaoyuan', 'Read'),
//(2, 'lanlanyangyang', 8, 'qingqingcaoyuan', 'eat'),
//(3, 'tom', 13, 'anywhere', 'catch'),
//(4, 'jerry', 12, 'cave', 'sleep'),
//(5, 'zhangsan', 15, 'Address', 'sport'),
//(6, 'lisi', 14, 'Address', 'sport'),
//(7, 'wangwu', 16, 'Address', 'sport'),
//(8, 'jack', 18, 'Address', 'sport'),
//(9, 'rose', 19, 'Address', 'sport'),
//(10, 'user1', 20, 'Address', 'sport'),
//(11, 'user2', 21, 'Address', 'sport'),
//(12, 'user3', 22, 'Address', 'sport'),
//(13, 'user4', 23, 'Address', 'sport'),
//(14, 'user5', 24, 'Address', 'sport');


//select* from User;
//#endregion
