using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMSSmobilerDemo.common
{
    class RecipientsItemsInfo
    {
       
        /// <summary>
        /// 获取物品领用信息
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        public DataTable GetRItemsData(int pageIndex, int pagesize)
        {
            try
            {
                DataTable table = new DataTable();
                table.Columns.Add("ITEM_NAME", typeof(System.String));
                table.Columns.Add("ITEM_USER", typeof(System.String));
                table.Columns.Add("ITEM_DATE", typeof(System.DateTime ));
              
                if (pageIndex == 0)
                {
                    table.Rows.Add("沐浴露", "Demo",  DateTime.Now);
                    table.Rows.Add("月饼", "A", DateTime.Now);
                    table.Rows.Add("沐浴露", "B", DateTime.Now);
                }
                if (pageIndex == 1)
                {
                    table.Rows.Add("淋浴头", "Demo", DateTime.Now);
                    table.Rows.Add("洗发露", "Demo", DateTime.Now);
                }
                return table;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
