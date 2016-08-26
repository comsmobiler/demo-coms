using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMSSmobilerDemo.common
{
    class NBRecordInfo
    {
        /// <summary>
        /// 获取笔记本数据
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pagesize"></param>
        /// <returns></returns>
        public DataTable GetNBData()
        {

            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(System.String));
            table.Columns.Add("NBR_OTYPENAME", typeof(System.String));
            table.Columns.Add("USER", typeof(System.String));
            table.Columns.Add("NBR_ODATE", typeof(System.DateTime ));
            table.Rows.Add("1", "开始使用", "Demo", DateTime.Now);
            table.Rows.Add("2", "报修", "Demo", DateTime.Now);
            table.Rows.Add("3", "归还", "Demo", DateTime.Now);      
            return table;
        }
       
        /// <summary>
        /// 笔记本类型数据
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        public DataTable  StateData()
        {
            try
            {
                DataTable table = new DataTable();
                table.Columns.Add("State", typeof(System.Int32));
                table.Columns.Add("StateName", typeof(System.String));
                table.Rows.Add(Convert.ToInt32(NBROTYPE.开始使用), NBROTYPE.开始使用);
                table.Rows.Add(Convert.ToInt32(NBROTYPE.报修), NBROTYPE.报修);
                table.Rows.Add(Convert.ToInt32(NBROTYPE.归还), NBROTYPE.归还);
                return table;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 用户
        /// </summary>
        /// <returns></returns>
        public DataTable GetUserData()
        {
            DataTable table = new DataTable();
            table.Columns.Add("USER_ID", typeof(System.String));
            table.Columns.Add("USER_NAME", typeof(System.String));
            table.Rows.Add("Demo", "测试用户");
            table.Rows.Add("A", "张三");
            table.Rows.Add("B", "李四");
            table.Rows.Add("C", "王五");
            table.Rows.Add("D", "赵六");
            table.Rows.Add("E", "小七");
            return table;
        }
    }
}
public enum NBROTYPE
{
    /// <summary>
    /// 开始使用
    /// </summary>
    /// <remarks></remarks>
    开始使用 = 1,

    /// <summary>
    /// 报修
    /// </summary>
    /// <remarks></remarks>
    报修 = 2,

    /// <summary>
    /// 归还
    /// </summary>
    /// <remarks></remarks>
    归还 = 3
}