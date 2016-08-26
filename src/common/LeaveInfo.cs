using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMSSmobilerDemo.common
{
    class LeaveInfo
    {
        /// <summary>
        /// 根据类型获取当前页请假信息
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        public DataTable GetDataByLMode(int btnMode, int pageIndex, int pagesize)
        {
            try
            {
                DataTable table = new DataTable();
                table.Columns.Add("L_TYPE", typeof(System.String));
                table.Columns.Add("L_TYPEDESC", typeof(System.String));
                table.Columns.Add("L_LEAVEDAY", typeof(System.String));
                table.Columns.Add("LUSERDATE", typeof(System.String));
                table.Columns.Add("L_REASON", typeof(System.String));
                table.Columns.Add("L_STATE", typeof(System.Int32));
                table.Columns.Add("L_STATE_FORMAT", typeof(System.String));
                switch (btnMode)
                {
                    case 1:
                        if (pageIndex == 0)
                        {
                            table.Rows.Add("shijia", "事假", "1.00天", DateTime.Now.ToShortDateString(), "家里有事", 0, "yichuangjian");
                            table.Rows.Add("bingjia","病假", "1.00天", DateTime.Now.ToShortDateString(), "生病", 1, "yisongshen");
                            table.Rows.Add("shijia", "事假", "1.00天", DateTime.Now.ToShortDateString(), "家里有事", 0, "yichuangjian");
                        }
                        if (pageIndex == 1)
                        {
                            table.Rows.Add("hunjia", "婚假", "3.00天", DateTime.Now.ToShortDateString(), "结婚", 0, "yichuangjian");

                        }
                        break;
                    case 2:
                        if (pageIndex == 0)
                        {
                            table.Rows.Add("hunjia", "婚假", "3.00天", DateTime.Now.ToShortDateString(), "结婚", 1, "yisongshen");
                            table.Rows.Add("hunjia", "婚假", "5.00天", DateTime.Now.ToShortDateString(), "结婚", 1, "yisongshen");
                            table.Rows.Add("hunjia", "婚假", "4.00天", DateTime.Now.ToShortDateString(), "结婚", 1, "yisongshen");
                        }
                        if (pageIndex == 1)
                        {
                            table.Rows.Add("shijia", "事假", "1.00天", DateTime.Now.ToShortDateString(), "家里有事", 1, "yisongshen");
                            table.Rows.Add("shijia", "病假", "1.00天", DateTime.Now.ToShortDateString(), "生病", 1, "yisongshen");
                            table.Rows.Add("shijia", "事假", "1.00天", DateTime.Now.ToShortDateString(), "家里有事", 1, "yisongshen");
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

        /// <summary>
        /// 审批人或抄送人
        /// </summary>
        /// <returns></returns>
        public DataTable GetConfirmUser()
        {
            DataTable table = new DataTable();
            table.Columns.Add("USER_ID", typeof(System.String));
            table.Columns.Add("USER_NAME", typeof(System.String));
            table.Rows.Add("Demo", "测试用户");
            table.Rows.Add("A","张三");
            table.Rows.Add("B","李四");
            table.Rows.Add("C","王五");
            table.Rows.Add("D","赵六");
            table.Rows.Add("E", "小七");
            return table;
        }

        /// <summary>
        /// 请假类型
        /// </summary>
        /// <returns></returns>
        public DataTable GetLeaveType()
        {
            DataTable table = new DataTable();
            table.Columns.Add("L_TYPE", typeof(System.String));
            table.Columns.Add("L_TYPEDESC", typeof(System.String));
            table.Rows.Add("shijia", "事假");
            table.Rows.Add("bingjia", "病假");
            table.Rows.Add("nianjia", "年假");
            table.Rows.Add("tiaoxiu", "调休");
            table.Rows.Add("hunjia", "婚假");
            table.Rows.Add("chanjia", "产假");
            table.Rows.Add("peichanjia", "陪产假");
            table.Rows.Add("qita", "其他");
            return table;
        }
    }
}
