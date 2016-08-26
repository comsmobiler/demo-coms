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
        table.Rows.Add("RB0001", "2015年项目预算", "Demo", "3月份报销", 0, "yichuangjian", 250.0, DateTime.Now);
        table.Rows.Add("RB0002", "2015年项目预算", "Demo", "4月份报销", 1, "yitijiao", 400, DateTime.Now);
        table.Rows.Add("RB0003", "2015年项目预算", "Demo", "2月份报销", 2, "zerenr", 300, DateTime.Now);
        table.Rows.Add("RB0004", "2015年项目预算", "Demo", "1月份报销", 3, "xingzheng", 1000, DateTime.Now);
        table.Rows.Add("RB0004", "2015年项目预算", "Demo", "1月份报销", 4, "caiwu", 6000, DateTime.Now);
        table.Rows.Add("RB0004", "2015年项目预算", "Demo", "5月份报销", -1, "yijujue", 100, DateTime.Now);
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
        table.Rows.Add("RB0001", "2015年项目预算", "Demo", "3月份报销", 0, "yichuangjian", 250.0, DateTime.Now);
        table.Rows.Add("RB0002", "2015年项目预算", "Demo", "4月份报销", 0, "yichuangjian", 1000, DateTime.Now);
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
        table.Rows.Add("RB0001", "2015年项目预算", "Demo", "2月份报销", 1, "yitijiao", 2050.0, DateTime.Now);
        table.Rows.Add("RB0002", "2015年项目预算", "Demo", "1月份报销", 1, "yitijiao", 3000, DateTime.Now);
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
        table.Rows.Add("RB0001", "2015年项目预算", "Demo", "2月份报销", 2, "zerenr", 2050.0, DateTime.Now);
        table.Rows.Add("RB0002", "2015年项目预算", "Demo", "1月份报销", 2, "zerenr", 10000, DateTime.Now);
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
        table.Rows.Add("RB0001", "2015年项目预算", "Demo", "2月份报销", 3, "xingzheng", 2050.0, DateTime.Now);
        table.Rows.Add("RB0002", "2015年项目预算", "Demo", "1月份报销", 3, "xingzheng", 1500, DateTime.Now);
        return table;
    }

    /// <summary>
    /// 报表
    /// </summary>
    /// <returns></returns>
    /// <remarks></remarks>
    public DataTable GetSanalysis(int btnMode, string type)
    {
        try
        {
            DataTable table = new DataTable();
            table.Columns.Add("NAME", typeof(System.String));
            table.Columns.Add("NAMECOUNT", typeof(System.String));
            table.Columns.Add("AMOUNT", typeof(System.Decimal ));
            switch (btnMode)
            {
                    
                case 0:
                    switch (type)
                    {
                        case "xiaofei":
                            table.Rows.Add("1月份", "1月份（0）", 0);
                            table.Rows.Add("2月份", "2月份（0）", 0);
                            table.Rows.Add("3月份", "3月份（0）", 955);
                            table.Rows.Add("4月份", "4月份（0）", 9155);
                            table.Rows.Add("5月份", "5月份（0）", 2282);
                            table.Rows.Add("6月份", "6月份（0）", 0);
                            table.Rows.Add("7月份", "7月份（0）", 8278);
                            table.Rows.Add("8月份", "8月份（0）", 3012);
                            table.Rows.Add("9月份", "9月份（0）", 0);
                            table.Rows.Add("10月份", "10月份（0）", 0);
                            table.Rows.Add("11月份", "11月份（0）", 0);
                            table.Rows.Add("12月份", "12月份（0）", 0);
                            break;
                        case "baoxiao":
                             table.Rows.Add("1月份", "1月份（0）", 7000);
                             table.Rows.Add("2月份", "2月份（0）", 12050);
                            table.Rows.Add("3月份", "3月份（0）", 500);
                            table.Rows.Add("4月份", "4月份（0）",400);
                            table.Rows.Add("5月份", "5月份（0）", 5050);
                            table.Rows.Add("6月份", "6月份（0）", 0);
                            table.Rows.Add("7月份", "7月份（0）", 700);
                            table.Rows.Add("8月份", "8月份（0）", 0);
                            table.Rows.Add("9月份", "9月份（0）", 0);
                            table.Rows.Add("10月份", "10月份（0）", 0);
                            table.Rows.Add("11月份", "11月份（0）", 0);
                            table.Rows.Add("12月份", "12月份（0）", 0);
                            break;
                    }
                    break;
                case 1:
                    switch (type)
                    {
                        case "xiaofei":
                            table.Rows.Add("保洁费", "保洁费（10）", 955);
                            table.Rows.Add("笔记本", "笔记本（2）", 9155);
                            table.Rows.Add("房租", "房租（2）", 8278);
                            table.Rows.Add("出差补贴", "行政已审核（2）",3012 );
                            table.Rows.Add("餐费", "餐费（15）", 2282);
                            break;
                        case "baoxiao":
                            table.Rows.Add("已创建", "已创建（2）",1000);
                            table.Rows.Add("已提交", "已提交（2）", 5050);
                            table.Rows.Add("责任人已审核", "责任人已审核（2）", 12050);
                            table.Rows.Add("行政已审核", "行政已审核（2）", 3550);
                            table.Rows.Add("财务已审核", "财务已审核（2）", 3550);
                            table.Rows.Add("已拒绝", "已拒绝（1）", 500);
                            break;
                    }
                    break;
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
