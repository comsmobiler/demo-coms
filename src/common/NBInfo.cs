using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMSSmobilerDemo.common
{
    class NBInfo
    {
        /// <summary>
        /// 获取笔记本数据
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pagesize"></param>
        /// <returns></returns>
        public DataTable GetNootBooksData( int pageIndex, int pagesize)
        {

            DataTable table = new DataTable();
            table.Columns.Add("NB_EQNO", typeof(System.String));
            table.Columns.Add("NBSN", typeof(System.String));
            table.Columns.Add("USER", typeof(System.String));
            table.Columns.Add("NB_STATE_FORMAT", typeof(System.String));
            table.Columns.Add("NBSYQTY", typeof(System.Int32 ));
            table.Columns.Add("NBWXQTY", typeof(System.Int32));
            table.Columns.Add("NB_BUYDATE", typeof(System.DateTime ));
            table.Columns.Add("NB_PRICE", typeof(System.Decimal ));
            switch (pageIndex)
            {
                case 0:
                    table.Rows.Add("NB001", "E530 L_x0035", "责任人：Demo", "zhengchang", 2, 0, DateTime.Now,"5000");
                    table.Rows.Add("NB002", "E530 L_x0036", "责任人：Demo", "sunhuai", 0, 0, DateTime.Now, "6000");
                    table.Rows.Add("NB003", "E530 L_x0037", "责任人：Demo", "weixiu", 0, 0, DateTime.Now, "4000");
                    break;
                case 1:
                    table.Rows.Add("NB004", "E530 L_x0038", "责任人：Demo", "baofei", 1, 0, DateTime.Now, "5000");
                    table.Rows.Add("NB005", "E530 L_x0039", "责任人：Demo", "zhengchang", 0, 0, DateTime.Now, "5000");
                    table.Rows.Add("NB006", "E530 L_x0040", "责任人：Demo", "zhengchang", 0, 0, DateTime.Now, "5000");
                    break;
                case 2:
                    table.Rows.Add("NB007", "E530 L_x0041", "责任人：Demo", "zhengchang", 1, 0, DateTime.Now, "5000");
                    table.Rows.Add("NB008", "E530 L_x0042", "责任人：Demo", "zhengchang", 0, 0, DateTime.Now, "5000");
                    break;

            }
            return table;
        }
        /// <summary>
        /// 笔记本状态数据
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
                table.Rows.Add(Convert.ToInt32(NBStates.正常), NBStates.正常);
                table.Rows.Add(Convert.ToInt32(NBStates.维修中), NBStates.维修中);
                table.Rows.Add(Convert.ToInt32(NBStates.损坏), NBStates.损坏);
                return table;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 笔记本地址数据
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        public DataTable  AddressData()
        {
            try
            {
                DataTable table = new DataTable();
                table.Columns.Add("ID", typeof(System.Int32));
                table.Columns.Add("Address", typeof(System.String));
                table.Rows.Add(Convert.ToInt32(NBAddress.上海), NBAddress.上海);
                table.Rows.Add(Convert.ToInt32(NBAddress.嘉兴), NBAddress.嘉兴);
                table.Rows.Add(Convert.ToInt32(NBAddress.郑州), NBAddress.郑州);

                return table;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 笔记本所有者数据
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        public DataTable  OwnerData()
        {
            try
            {
                DataTable table = new DataTable();
                table.Columns.Add("NB_OWNER", typeof(System.String));
                table.Columns.Add("NB_OWNER1", typeof(System.String));
                table.Rows.Add(Convert.ToInt32(NBOWNER.Smobiler), NBOWNER.Smobiler);
                table.Rows.Add(Convert.ToInt32(NBOWNER.个人), NBOWNER.个人);
                return table;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
/// <summary>
/// 状态
/// </summary>
/// <remarks></remarks>
public enum NBStates
{
    /// <summary>
    /// 正常
    /// </summary>
    /// <remarks></remarks>
    正常 = 0,

    /// <summary>
    /// 维修中
    /// </summary>
    /// <remarks></remarks>
    维修中 = 1,

    /// <summary>
    /// 损坏
    /// </summary>
    /// <remarks></remarks>
    损坏 = 2,

    /// <summary>
    /// 报废
    /// </summary>
    /// <remarks></remarks>
    报废 = -1


}
/// <summary>
/// 所有者
/// </summary>
/// <remarks></remarks>
public enum NBOWNER
{
    /// <summary>
    /// Smobiler
    /// </summary>
    /// <remarks></remarks>
    Smobiler = 0,

    /// <summary>
    /// 个人
    /// </summary>
    /// <remarks></remarks>
    个人 = 1
}
/// <summary>
/// 所在位置
/// </summary>
/// <remarks></remarks>
public enum NBAddress
{
    /// <summary>
    /// 上海
    /// </summary>
    /// <remarks></remarks>
    上海 = 0,

    /// <summary>
    /// 嘉兴
    /// </summary>
    /// <remarks></remarks>
    嘉兴 = 1,

    /// <summary>
    /// 郑州
    /// </summary>
    /// <remarks></remarks>
    郑州 = 2
}
