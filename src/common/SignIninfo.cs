using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMSSmobilerDemo.common
{
    class SignIninfo
    {
        /// <summary>
        /// 根据签到日期类型获取当前页
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        public DataTable GetDataBySMode(int btnMode,int pageIndex,int pagesize)
        {
            try
            {
                DataTable table = new DataTable();
                table.Columns.Add("SI_DATE", typeof(System.String));
                table.Columns.Add("TYPEDESC", typeof(System.String));
                table.Columns.Add("SI_ADDRESS", typeof(System.String));
                switch (btnMode)
                {
                    case 1:
                        if (pageIndex==0)
                        {
                         table.Rows.Add(DateTime .Now .ToString (), "xiabanqd","浙江省嘉兴市南湖区");
                         table.Rows.Add(DateTime.Now.ToString(), "xiabanqd", "浙江省上海市");
                         table.Rows.Add(DateTime.Now.ToString(), "shangbanqd", "浙江省上海市");
                        }
                        if (pageIndex == 1)
                        {
                            table.Rows.Add(DateTime.Now.ToString(), "xiabanqd", "浙江省嘉兴市南湖区12");
                        }
                        break;
                    case 2:
                        if (pageIndex==0)
                        {
                            table.Rows.Add(DateTime.Now.ToString(), "xiabanqd", "浙江省嘉兴市南湖区2");
                            table.Rows.Add(DateTime.Now.ToString(), "xiabanqd", "浙江省上海市2");
                            table.Rows.Add(DateTime.Now.ToString(), "shangbanqd", "浙江省上海市2");
                        }
                        if (pageIndex == 1)
                        {
                            table.Rows.Add(DateTime.Now.ToString(), "xiabanqd", "浙江省嘉兴市南湖区12");
                            table.Rows.Add(DateTime.Now.ToString(), "xiabanqd", "浙江省嘉兴市南湖区42");
                        }
                        break;
                    case 3:
                        if (pageIndex == 0)
                        {
                            table.Rows.Add(DateTime.Now.ToString(), "xiabanqd", "浙江省嘉兴市南湖区3");
                            table.Rows.Add(DateTime.Now.ToString(), "xiabanqd", "浙江省上海市3");
                            table.Rows.Add(DateTime.Now.ToString(), "shangbanqd", "浙江省上海市3");
                        }
                        if (pageIndex == 1)
                        {
                            table.Rows.Add(DateTime.Now.ToString(), "xiabanqd", "浙江省嘉兴市南湖区12");
                            table.Rows.Add(DateTime.Now.ToString(), "xiabanqd", "浙江省嘉兴市南湖区23");
                            table.Rows.Add(DateTime.Now.ToString(), "xiabanqd", "浙江省嘉兴市南湖区45");
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
        /// 签到考勤类型数据
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        public DataTable StateData1()
        {
            try
            {
                DataTable table = new DataTable();
                table.Columns.Add("State", typeof(System.Int32 ));
                table.Columns.Add("StateName", typeof(System.String));

                int state = Convert.ToInt32(SignInState.公司签到);
                int state1 = Convert.ToInt32(SignInState.外出签到);
                table.Rows.Add(state, SignInState.公司签到);
                table.Rows.Add(state1, SignInState.外出签到);
                return table;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 签到打卡类型数据
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        public DataTable  StateData()
        {
            try
            {
                DataTable table = new DataTable();
                table.Columns.Add("State", typeof(System.Int32 ));
                table.Columns.Add("StateName", typeof(System.String));
                int state = Convert.ToInt32(SignInPunchCardType.上班);
                int state1 = Convert.ToInt32(SignInPunchCardType.下班);
                table.Rows.Add(state, SignInPunchCardType.上班);
                table.Rows.Add(state1, SignInPunchCardType.下班);
                return table;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
public enum  SignInState
{
    公司签到 = 0,
    外出签到 = 1,
}
public enum SignInPunchCardType
{
    上班 = 0,
    下班 = 1,
}