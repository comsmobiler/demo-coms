using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMSSmobilerDemo.common
{
    class MessageInfo
    {
       /// <summary>
       /// 根据查询消息信息获取当前页的数据
       /// </summary>
       /// <param name="searchinfo"></param>
       /// <param name="pageIndex"></param>
       /// <param name="pagesize"></param>
       /// <returns></returns>
        public DataTable GetMessageData(string searchinfo,int pageIndex, int pagesize)
        {
           
            DataTable table = new DataTable();
            table.Columns.Add("NOTE", typeof(System.String));
            table.Columns.Add("NO", typeof(System.String));
            table.Columns.Add("STATE", typeof(System.Int32 ));
            table.Columns.Add("STATEDESC", typeof(System.String));
            table.Columns.Add("NOTE1", typeof(System.String));
            switch (pageIndex) 
            {
                case 0:
                    table.Rows.Add("请假一","L001",2,"qingjia","A在2016年3月27号申请请假");
                    table.Rows.Add("请假二", "L002", 2, "qingjia", "A在2016年3月28号申请请假");
                    table.Rows.Add("工单一", "WD001", 1, "gongdan", "B在2016年3月27号送审工作单");
                    table.Rows.Add("工单二", "WD002", 1, "gongdan", "C在2016年3月28号送审工作单");
                    table.Rows.Add("工单三", "WD003", 1, "gongdan", "B在2016年3月28号送审工作单");
                    break;
                case 1:
                    table.Rows.Add("请假三", "L003", 2, "qingjia", "A创建在2016年3月29号申请请假");
                    table.Rows.Add("工单四", "WD004", 1, "gongdan", "B在2016年3月27号送审工作单");
                    table.Rows.Add("工单五", "WD005", 1, "gongdan", "C在2016年3月28号送审工作单");
                    table.Rows.Add("工单六", "WD006", 1, "gongdan", "B在2016年3月28号送审工作单");
                    table.Rows.Add("工单七", "WD007", 1, "gongdan", "B在2016年3月28号送审工作单");
                    break;
                case 2:
                    table.Rows.Add("请假四", "L004", 2, "qingjia", "A创建在2016年3月30号申请请假");
                    table.Rows.Add("请假五", "L005", 2, "qingjia", "A创建在2016年3月31号申请请假");
                    table.Rows.Add("工单八", "WD008", 1, "gongdan", "B在2016年3月27号送审工作单");
                    table.Rows.Add("工单九", "WD009", 1, "gongdan", "C在2016年3月28号送审工作单");
                    table.Rows.Add("工单十", "WD0010", 1, "gongdan", "B在2016年3月28号送审工作单");
                    break;
                
            }
            return table;
        }

    }
}
public enum MessageStates
{
  
   // <summary>
   // 工作单
   // </summary>
   // <remarks></remarks>
    工作单 = 1,
   // <summary>
   // 请假
   // </summary>
   // <remarks></remarks>
    请假 = 2,
}