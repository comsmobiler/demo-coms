using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMSSmobilerDemo.common
{
    class BookSNInfo
    {
        /// <summary>
        /// 获取书序号数据
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pagesize"></param>
        /// <returns></returns>
        public DataTable GetBookSNbyBookID()
        {

            DataTable table = new DataTable();
            table.Columns.Add("BOOKSNID", typeof(System.String));
            table.Columns.Add("STATENAME", typeof(System.String));
            table.Rows.Add("SN001", "借出");
            table.Rows.Add("SN002", "借出");
            table.Rows.Add("SN003", "入库");
            return table;
        }

        /// <summary>
        /// 获取书序号数据
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pagesize"></param>
        /// <returns></returns>
        public DataTable GetBookSNbyBookID1()
        {

            DataTable table = new DataTable();
            table.Columns.Add("BOOKLOGID", typeof(System.String));
            table.Columns.Add("BOOKNAME", typeof(System.String));
            table.Columns.Add("STATENAME", typeof(System.String));
            table.Columns.Add("BOOKSN", typeof(System.String));
            table.Columns.Add("BOOKDATE", typeof(System.String));
            table.Rows.Add("log001", "ASP.NET基础", "借出", "BSN001 Demo 好", DateTime.Now);
            table.Rows.Add("log002", ".NET高级编程", "借出", "BSN002 Demo一般", DateTime.Now);
            return table;
        }
    }
}
