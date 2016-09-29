using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMSSmobilerDemo
{
    class OperationalInfo
    {
        /// <summary>
        /// 获取维护数据
        /// </summary>
        /// <returns></returns>
        public DataTable GetOperationalRData(int pageIndex, int pagesize)
        {
            DataTable table = new DataTable();
            table.Columns.Add("OR_NO", typeof(System.String));
            table.Columns.Add("OR_FAULTINFO", typeof(System.String));
            table.Columns.Add("NOTE", typeof(System.String));
            if (pageIndex ==0)
            {
            table.Rows.Add("OR001","数据丢失", "客户一在"+DateTime .Now .ToShortDateString  ()+"申请了故障");
            table.Rows.Add("OR002", "数据丢失", "客户二在" + DateTime.Now.ToShortDateString() + "申请了故障");
            table.Rows.Add("OR003", "数据丢失", "客户三在" + DateTime.Now.ToShortDateString() + "申请了故障");
            }
             if (pageIndex ==1)
            {
                table.Rows.Add("OR004", "数据丢失", "客户四在" + DateTime.Now.ToShortDateString() + "申请了故障");
                table.Rows.Add("OR005", "数据丢失", "客户二在" + DateTime.Now.ToShortDateString() + "申请了故障");
            }
            return table;
        }
        /// <summary>
        /// 获取维护数据
        /// </summary>
        /// <returns></returns>
        public DataTable GetOperationalRData1(int pageIndex, int pagesize)
        {
            DataTable table = new DataTable();
            table.Columns.Add("CUST_NAME", typeof(System.String));
            table.Columns.Add("FinishedQTYNote", typeof(System.String));
            table.Columns.Add("TrackedQtyNote", typeof(System.String));
            table.Columns.Add("TotalQTY", typeof(System.Int32));
            if (pageIndex == 0)
            {
                table.Rows.Add("客户一", "已完成:1", "待跟踪：2",3);
                table.Rows.Add("客户二", "已完成:0", "待跟踪：2", 3);
                table.Rows.Add("客户三", "已完成:0", "待跟踪：0", 3);
            }
            if (pageIndex == 1)
            {
                table.Rows.Add("客户四", "已完成:1", "待跟踪：2", 3);
            }
            return table;
        }
        /// <summary>
        /// 获取维护数据
        /// </summary>
        /// <returns></returns>
        public DataTable GetORDataByCU()
        {
            DataTable table = new DataTable();
            table.Columns.Add("OR_NO", typeof(System.String));
            table.Columns.Add("OR_FAULTINFO", typeof(System.String));
            table.Columns.Add("OR_PROCESSRESULT", typeof(System.String));
            table.Columns.Add("OR_DECLAREDATE", typeof(System.DateTime ));
            table.Rows.Add("OR001", "数据丢失", "node1", DateTime.Now);
            table.Rows.Add("OR002", "维护系统", "node1", DateTime.Now);
            table.Rows.Add("OR003", "数据丢失1", "node2", DateTime.Now);
            return table;
        }
        /// <summary>
        /// 客户
        /// </summary>
        /// <returns></returns>
        public DataTable GetCUData()
        {
            DataTable table = new DataTable();
            table.Columns.Add("CUST_ID", typeof(System.String));
            table.Columns.Add("CUST_NAME", typeof(System.String));
            table.Rows.Add("CU001", "客户一");
            table.Rows.Add("CU002", "客户二");
            table.Rows.Add("CU003", "客户三");
            table.Rows.Add("CU004", "客户四");
            return table;
        }
    
        /// <summary>
        /// 处理结果
        /// </summary>
        /// <returns></returns>
    public DataTable GetProcessResultData()
    {
       
            DataTable table = new DataTable();
              table.Columns.Add("ProcessResultState", typeof(System.Int32 ));
              table.Columns.Add("ProcessResultStateName", typeof(System.String));
              int state = Convert.ToInt32(ProcessResultState.待跟踪);
              int state1 = Convert.ToInt32(ProcessResultState.已完成);
                table.Rows.Add(state, ProcessResultState.待跟踪);
                table.Rows.Add(state1,  ProcessResultState.已完成);
           return table;
    }
    /// <summary>
    /// 成本中心
    /// </summary>
    /// <returns></returns>
    public DataTable GetUserData()
    {
        DataTable table = new DataTable();
        table.Columns.Add("USER_ID", typeof(System.String));
        table.Rows.Add("A");
        table.Rows.Add("B");
        table.Rows.Add("C");
        table.Rows.Add("D");
        return table;
    }
    }
    }
public enum ProcessResultState
{
    /// <summary>
    /// 待跟踪
    /// </summary>
    待跟踪 = 0,
/// <summary>
    /// 已完成
/// </summary>
    已完成 = 1,
}
