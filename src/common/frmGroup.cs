using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMSSmobilerDemo.common
{
    class frmGroup
    {
        /// <summary>
        /// 获取群组数据
        /// </summary>
        /// <returns></returns>
        public DataTable GetGroupData()
        {
            DataTable table = new DataTable();
            table.Columns.Add("G_ID", typeof(System.String));
            table.Columns.Add("G_NAME", typeof(System.String));
            table.Rows.Add("G0001", "smobiler交流群");
            table.Rows.Add("G0002", "smobiler横屏交流群");            
            return table;
        }

        /// <summary>
        /// 获取笔记本数据
        /// </summary>
        /// <returns></returns>
        public DataTable GetGroupUserByID()
        {
            DataTable table = new DataTable();
            table.Columns.Add("G_ID", typeof(System.String));
            table.Columns.Add("G_NAME", typeof(System.String));
            table.Rows.Add("G0001", "smobiler交流群");
            table.Rows.Add("G0002", "smobiler横屏交流群");
            return table;
        }
    }
}
