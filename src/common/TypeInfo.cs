using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace COMSSmobilerDemo.common
{
    class TypeInfo
    {
        /// <summary>
        /// 消费类型
        /// </summary>
        /// <returns></returns>
         public DataTable Gettypeofinfo()
         {
             DataTable table = new DataTable();
        table.Columns.Add("TYPE", typeof(System.String));
        table.Columns.Add("TYPENAME", typeof(System.String));
        table.Rows.Add("CF", "餐费");
        table.Rows.Add("JT", "交通费");
        table.Rows.Add("FZ", "房租");
        table.Rows.Add("TXF", "通讯费");
        table.Rows.Add("CB", "出差补贴");
        table.Rows.Add("KD", "快递费");
        table.Rows.Add("TC", "停车费");
        table.Rows.Add("QT", "其他");
        return table;
        }
        /// <summary>
        /// 消费类型
        /// </summary>
        /// <returns></returns>
    public DataTable Gettypeofinfo1() 
    {
        DataTable table = new DataTable();
        table.Columns.Add("RBROW_TYPE", typeof(System.String));
        table.Columns.Add("TYPENAME", typeof(System.String));
        table.Columns.Add("AMOUNT", typeof(System.Decimal));
        table.Columns.Add("TYPECOUNT", typeof(System.Int32 ));
        table.Rows.Add("CF", "餐费", 50.00,1);
        table.Rows.Add("JT", "交通费",200.00,1);
        return table;
    }
    }
}
