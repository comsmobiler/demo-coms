using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMSSmobilerDemo.common
{
    class WorkDInfo
    {
        public DataTable GetWorkDInfodate(int btnMode, string STATE,int pageIndex, int pagesize)
        {
            DataTable table = new DataTable();
            table.Columns.Add("WDOC_NOTE", typeof(System.String));
            table.Columns.Add("CC_NAMEUSER", typeof(System.String));
            table.Columns.Add("WDOC_STATE", typeof(System.Int32 ));
            table.Columns.Add("STATEDESC", typeof(System.String));
            table.Columns.Add("WDOCMENDAYVFIELD", typeof(System.String));
            switch (btnMode )
            {
                case 1:
                    if (pageIndex == 0)
                    {
                        table.Rows.Add("工单一", "2015年项目预算",0,"已创建","2.00天");
                        table.Rows.Add("工单二", "2015年项目预算", 1, "已提交", "2.00天");
                        table.Rows.Add("工单三", "2015年项目预算", 0, "已创建", "2.00天");
                    }
                    if (pageIndex == 1)
                    {
                        table.Rows.Add("工单四", "2015年项目预算", 0, "已创建", "2.00天");
                        table.Rows.Add("工单五", "2015年项目预算", 0, "已创建", "2.00天");
                        table.Rows.Add("工单六", "2015年项目预算", 0, "已创建", "2.00天");
                    }
                    break;
                case 2: 
                    if (pageIndex == 0)
                    {
                        table.Rows.Add("工单七", "2015年项目预算",1,"已提交","2.00天");
                        table.Rows.Add("工单八", "2015年项目预算", 1, "已提交", "2.00天");
                        table.Rows.Add("工单九", "2015年项目预算", 1, "已提交", "2.00天");
                    }
                    if (pageIndex == 1)
                    {
                        table.Rows.Add("工单十", "2015年项目预算", 1, "已提交", "2.00天");
                    }
                    break;
            }
           
            return table;
        }
        /// <summary>
        /// 工作单类型
        /// </summary>
        /// <returns></returns>
        public DataTable GetWorkDType()
        {
            DataTable table = new DataTable();
            table.Columns.Add("WDOC_TYPE", typeof(System.String));
            table.Columns.Add("WDOCTYPE_NAME", typeof(System.String));
            table.Rows.Add("001", "日结单");
            table.Rows.Add("002", "协同单");
            return table;
        }
    }
}
