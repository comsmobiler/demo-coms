using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMSSmobilerDemo.common
{
    class BookInfo
    {
        /// <summary>
        /// 获取笔记本数据
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pagesize"></param>
        /// <returns></returns>
        public DataTable GetBookData(int pageIndex, int pagesize)
        {

            DataTable table = new DataTable();
            table.Columns.Add("BOOKIMG", typeof(System.String));
            table.Columns.Add("BOOKNO", typeof(System.String));
            table.Columns.Add("BOOKNAME", typeof(System.String));
            table.Columns.Add("MONEY", typeof(System.Decimal));
            table.Columns.Add("QTY", typeof(System.Int32));
            table.Columns.Add("GRADE", typeof(System.String));
            table.Columns.Add("GRADEIMG", typeof(System.String));
            table.Columns.Add("BOOKPUBLIDATE", typeof(System.DateTime));
            switch (pageIndex)
            {
                case 0:
                    table.Rows.Add("Book1", "B001", "ASP.NET基础", 50, 2, "好", "!\\ue545255000000", DateTime.Now);
                    table.Rows.Add("Book2", "B002", ".NET高级编程", 40, 2, "较好", "!\\ue545255128064", DateTime.Now);
                    table.Rows.Add("Book3", "B003", "设计模式", 30, 2, "一般", "!\\ue545255255128", DateTime.Now);
                    break;
                case 1:
                    table.Rows.Add("Book2", "B005", "ASP.NET基础2", 50, 2, "好", "!\\ue545255000000", DateTime.Now);
                    table.Rows.Add("Book1", "B006", ".NET高级编程2", 40, 2, "较好", "!\\ue545255128064", DateTime.Now);
                    table.Rows.Add("Book3", "B007", "设计模式2", 30, 2, "较差", "!\\ue545000128064", DateTime.Now);
                    break;
                case 2:
                    table.Rows.Add("Book2", "B008", "设计模式3", 30, 2, "一般", "!\\ue545255255128", DateTime.Now);
                    break;

            }
            return table;
        }
    }
}