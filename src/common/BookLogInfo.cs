using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMSSmobilerDemo.common
{
    class BookLogInfo
    {
        /// <summary>
        /// 获取借阅记录信息
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        public DataTable GetBookDataByMode(int btnMode, int pageIndex, int pagesize)
        {
            try
            {
                DataTable table = new DataTable();
                table.Columns.Add("BOOKLOGID", typeof(System.String));
                table.Columns.Add("BOOKNAME", typeof(System.String));
                table.Columns.Add("STATENAME", typeof(System.String));
                table.Columns.Add("BOOKSN", typeof(System.String));
                table.Columns.Add("BOOKDATE", typeof(System.String));
               
                switch (btnMode)
                {
                    case 0:
                        if (pageIndex == 0)
                        {
                            table.Rows.Add("log004", "ASP.NET基础", "借出", "BSN001 Demo 好", DateTime.Now);
                            table.Rows.Add("log005", "ASP.NET基础", "归还", "BSN002 Demo 好", DateTime.Now);
                            table.Rows.Add("log006", ".NET高级编程", "借出", "BSN003 Demo 好", DateTime.Now);
                        }
                        if (pageIndex == 1)
                        {
                            table.Rows.Add("log007", ".NET高级编程", "归还", "BSN003 Demo 较好", DateTime.Now);

                        }
                        break;
                    case 1:
                        if (pageIndex == 0)
                        {
                            table.Rows.Add("log001", "ASP.NET基础", "借出", "BSN001 A 好", DateTime.Now);
                            table.Rows.Add("log002", "ASP.NET基础", "归还", "BSN002 A 好", DateTime.Now);
                            table.Rows.Add("log004", "ASP.NET基础", "借出", "BSN001 Demo 好", DateTime.Now);
                        }
                        if (pageIndex == 1)
                        {
                            table.Rows.Add("log005", "ASP.NET基础", "归还", "BSN002 Demo 好", DateTime.Now);
                            table.Rows.Add("log006", ".NET高级编程", "借出", "BSN003 Demo 好", DateTime.Now);
                            table.Rows.Add("log007", ".NET高级编程", "归还", "BSN003 Demo 较好", DateTime.Now);
                        }
                        break;
                }

                return table;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 图书借阅状态数据
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        public DataTable StateData()
        {
            try
            {
                DataTable table = new DataTable();
                table.Columns.Add("State", typeof(System.Int32));
                table.Columns.Add("StateName", typeof(System.String));
                table.Rows.Add(Convert .ToInt32 (BooksNSState.借出), BooksNSState.借出);
                table.Rows.Add(Convert.ToInt32(BooksNSState.遗失), BooksNSState.遗失);
                table.Rows.Add(Convert.ToInt32(BooksNSState.归还), BooksNSState.归还);
                return table;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 用户
        /// </summary>
        /// <returns></returns>
        public DataTable GetUserData()
        {
            DataTable table = new DataTable();
            table.Columns.Add("USER_ID", typeof(System.String));
            table.Columns.Add("USER_NAME", typeof(System.String));
            table.Rows.Add("Demo", "测试用户");
            table.Rows.Add("A", "张三");
            table.Rows.Add("B", "李四");
            table.Rows.Add("C", "王五");
            table.Rows.Add("D", "赵六");
            table.Rows.Add("E", "小七");
            return table;
        }
    }
}
/// <summary>
/// 图书状态定义
/// </summary>
/// <remarks></remarks>
public enum BooksNSState
{
    /// <summary>
    /// 入库
    /// </summary>
    /// <remarks></remarks>
    入库 = 0,
    /// <summary>
    /// 借出
    /// </summary>
    /// <remarks></remarks>
    借出 = 1,
    /// <summary>
    /// 归还
    /// </summary>
    /// <remarks></remarks>
    归还 = 2,
    /// <summary>
    /// 遗失
    /// </summary>
    /// <remarks></remarks>
    遗失 = -1
}