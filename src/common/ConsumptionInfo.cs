using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMSSmobilerDemo.common
{
    class ConsumptionInfo
    {
        /// <summary>
        /// 消费记录
        /// </summary>
        /// <returns></returns>
        public DataTable GetConsumptioninfo()
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(System.Int32));
            table.Columns.Add("RB_NO", typeof(System.String));
            table.Columns.Add("RBROW_DATE", typeof(System.DateTime));
            table.Columns.Add("RBROW_TYPE", typeof(System.String));
            table.Columns.Add("RBROW_TYPENAME", typeof(System.String));
            table.Columns.Add("RBROW_AMOUNT", typeof(System.Decimal));
            table.Columns.Add("RBROW_NOTE", typeof(System.String));
            table.Columns.Add("RBROW_AMOUNT_FORMAT", typeof(System.String));
            table.Rows.Add(1, string.Empty, DateTime.Now, "CF", "餐费", 50, "中餐+晚餐","￥50.00");
            table.Rows.Add(2, string.Empty, DateTime.Now, "JT", "交通费", 200, "的士+火车票", "￥200.00");
            return table;
        }
    }
}
