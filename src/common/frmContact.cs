using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMSSmobilerDemo.common
{
    class frmContact
    {
        /// <summary>
        /// 获取联系人数据
        /// </summary>
        /// <returns></returns>
        public DataTable GetContactData()
        {

            DataTable table = new DataTable();
            table.Columns.Add("UserID", typeof(System.String));
            table.Columns.Add("PortraitUri", typeof(System.String));
            table.Rows.Add("A", "A.PNG");
            table.Rows.Add("B", "B.PNG");
            return table;
        }

        /// <summary>
        /// 获取联系人数据
        /// </summary>
        /// <returns></returns>
        public DataTable GetContactData1()
        {

            DataTable table = new DataTable();
            table.Columns.Add("UserID", typeof(System.String));
            table.Columns.Add("PortraitUri", typeof(System.String));
            table.Columns.Add("isAddC", typeof(System.Boolean));
            table.Rows.Add("A", "A.PNG",true );
            table.Rows.Add("B", "B.PNG", true);
            table.Rows.Add("C", "C.PNG", false );
            table.Rows.Add("D", "D.PNG", false);
            table.Rows.Add("E", "E.PNG", false);
            return table;
        }
    }
}
