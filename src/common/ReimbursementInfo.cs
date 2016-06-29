using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace COMSSmobilerDemo.common
{
    class ReimbursementInfo
    {
    /// <summary>
    /// 报销信息
    /// </summary>
    public DataTable GetRBinfo()
    {
         DataTable table = new DataTable();
        table.Columns.Add("RB_NO", typeof(System.String));
        table.Columns.Add("RB_COSTCENTER", typeof(System.String));
        table.Columns.Add("RB_USER", typeof(System.String));
        table.Columns.Add("RB_NOTE", typeof(System.String));
        table.Columns.Add("RB_STATE", typeof(System.String));
        table.Columns.Add("RB_STATE_FORMAT", typeof(System.String));
        table.Columns.Add("RBROW_AMOUNT", typeof(System.Decimal));
        table.Columns.Add("CREATEDATE", typeof(System.DateTime));
        table.Rows.Add("RB0001", "2015年项目预算", "Demo", "3月份报销", 0, "已创建(可编辑)", 250.0, DateTime.Now);
        table.Rows.Add("RB0002", "2015年项目预算", "Demo", "4月份报销", 1, "已提交", 400, DateTime.Now);
        table.Rows.Add("RB0003", "2015年项目预算", "Demo", "2月份报销", 2, "责任人已审核", 300, DateTime.Now);
        table.Rows.Add("RB0004", "2015年项目预算", "Demo", "1月份报销", 3, "行政已审核", 1000, DateTime.Now);
        table.Rows.Add("RB0004", "2015年项目预算", "Demo", "1月份报销", 4, "行政已审核", 6000, DateTime.Now);
        table.Rows.Add("RB0004", "2015年项目预算", "Demo", "5月份报销", -1, "已拒绝", 100, DateTime.Now);
        return table;
    }

        /// <summary>
        /// 送审
        /// </summary>
    public DataTable GetRBinfo1() 
    {
       DataTable table = new DataTable();
        table.Columns.Add("RB_NO", typeof(System.String));
        table.Columns.Add("RB_COSTCENTER", typeof(System.String));
        table.Columns.Add("RB_USER", typeof(System.String));
        table.Columns.Add("RB_NOTE", typeof(System.String));
        table.Columns.Add("RB_STATE", typeof(System.String));
        table.Columns.Add("RB_STATE_FORMAT", typeof(System.String));
        table.Columns.Add("RBROW_AMOUNT", typeof(System.Decimal));
        table.Columns.Add("CREATEDATE", typeof(System.DateTime));
        table.Rows.Add("RB0001", "2015年项目预算", "Demo", "3月份报销", 0, "已创建(可编辑)", 250.0, DateTime.Now);
        table.Rows.Add("RB0002", "2015年项目预算", "Demo", "4月份报销", 0, "已创建(可编辑)", 1000, DateTime.Now);
        return table;
    }
    /// <summary>
    /// 责任人审批
    /// </summary>
    /// <returns></returns>
    public DataTable GetRBinfo2() 
    {
      DataTable table = new DataTable();
        table.Columns.Add("RB_NO", typeof(System.String));
        table.Columns.Add("RB_COSTCENTER", typeof(System.String));
        table.Columns.Add("RB_USER", typeof(System.String));
        table.Columns.Add("RB_NOTE", typeof(System.String));
        table.Columns.Add("RB_STATE", typeof(System.String));
        table.Columns.Add("RB_STATE_FORMAT", typeof(System.String));
        table.Columns.Add("RBROW_AMOUNT", typeof(System.Decimal));
        table.Columns.Add("CREATEDATE", typeof(System.DateTime));
        table.Rows.Add("RB0001", "2015年项目预算", "Demo", "2月份报销", 1, "已提交", 2050.0, DateTime.Now);
        table.Rows.Add("RB0002", "2015年项目预算", "Demo", "1月份报销", 1, "已提交", 3000, DateTime.Now);
        return table;
    }
        /// <summary>
        /// 行政审批
        /// </summary>
        /// <returns></returns>
    public DataTable GetRBinfo3()
    {
        DataTable table = new DataTable();
        table.Columns.Add("RB_NO", typeof(System.String));
        table.Columns.Add("RB_COSTCENTER", typeof(System.String));
        table.Columns.Add("RB_USER", typeof(System.String));
        table.Columns.Add("RB_NOTE", typeof(System.String));
        table.Columns.Add("RB_STATE", typeof(System.String));
        table.Columns.Add("RB_STATE_FORMAT", typeof(System.String));
        table.Columns.Add("RBROW_AMOUNT", typeof(System.Decimal));
        table.Columns.Add("CREATEDATE", typeof(System.DateTime));
        table.Rows.Add("RB0001", "2015年项目预算", "Demo", "2月份报销", 2, "责任人已审核", 2050.0, DateTime.Now);
        table.Rows.Add("RB0002", "2015年项目预算", "Demo", "1月份报销", 2, "责任人已审核", 10000, DateTime.Now);
        return table;
    }

        /// <summary>
        /// 财务审批
        /// </summary>
        /// <returns></returns>
    public DataTable GetRBinfo4()
    {
         DataTable table = new DataTable();
        table.Columns.Add("RB_NO", typeof(System.String));
        table.Columns.Add("RB_COSTCENTER", typeof(System.String));
        table.Columns.Add("RB_USER", typeof(System.String));
        table.Columns.Add("RB_NOTE", typeof(System.String));
        table.Columns.Add("RB_STATE", typeof(System.String));
        table.Columns.Add("RB_STATE_FORMAT", typeof(System.String));
        table.Columns.Add("RBROW_AMOUNT", typeof(System.Decimal));
        table.Columns.Add("CREATEDATE", typeof(System.DateTime));
        table.Rows.Add("RB0001", "2015年项目预算", "Demo", "2月份报销", 3, "行政已审核", 2050.0, DateTime.Now);
        table.Rows.Add("RB0002", "2015年项目预算", "Demo", "1月份报销", 3, "行政已审核", 1500, DateTime.Now);
        return table;
    }
    }
}
