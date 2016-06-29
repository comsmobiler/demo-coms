using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace COMSSmobilerDemo.common
{
    class CostCenterInfo
    {
        /// <summary>
        /// 成本中心
        /// </summary>
        /// <returns></returns>
        public DataTable GetCostCenterInfo()
        {
            DataTable table = new DataTable();
            table.Columns.Add("CC_ID", typeof(System.String));
            table.Columns.Add("CC_NAME", typeof(System.String));
            table.Columns.Add("CC_USER", typeof(System.String));
            table.Rows.Add("C0001", "2015年项目预算", "Demo");
            table.Rows.Add("C0002", "2015年项目预算2", "Demo");
            return table;
        }
    }
}
