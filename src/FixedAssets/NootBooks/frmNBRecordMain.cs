using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;

namespace COMSSmobilerDemo.FixedAssets.NootBooks
{
    partial class frmNBRecordMain : Smobiler.Core.MobileForm
    {

        #region ""
        //总页数
        public int pagesCount = 0;
        //当前页(第二页开始)
        public int pageIndex = 0;
        //当前页显示条数
        public int pagesize = 5;
        //总条数
        public int recordCount = 0;
        internal string NB_EQNO;
        #endregion
        internal string NBSN;

        /// <summary>
        /// 初始化方法绑定数据
        /// </summary>
        /// <remarks></remarks>
        private void Bind()
        {
            try
            {
                pagesCount =1;
                pageIndex = 0;
                TitleText = "E530 L_x0035";
                DataTable table = GetNootBooksRData();
                if (table.Rows.Count > 0)
                {
                    this.GridView1.DataSource = table;
                    this.GridView1.DataBind();
                }
                else
                {
                    this.GridView1.Rows.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 获取笔记本使用记录
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        private DataTable GetNootBooksRData()
        {
            COMSSmobilerDemo.common.NBRecordInfo NBRecordInfo = new COMSSmobilerDemo.common.NBRecordInfo();
            DataTable table = NBRecordInfo.GetNBData();
            return table;
        }


        private void frmNBRecordMain_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
        {
            if (e.Name.Equals(add.Name))
            {
                frmNBRecordCreate frm = new frmNBRecordCreate();
                frm.NB_EQNO = NB_EQNO;
                Redirect(frm, (MobileForm form, object args) =>
                {
                    try
                    {
                        if (frm.ShowResult == Smobiler.Core.ShowResult.Yes)
                        {
                            ShowResult = Smobiler.Core.ShowResult.Yes;
                            Bind();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                });
            }
        }

        private void frmNBRecordMain_TitleImageClick(object sender, EventArgs e)
        {
            Close();
        }

        private void frmNBRecordMain_KeyDown(object sender, KeyDownEventArgs e)
        {
            Close();
        }
        /// <summary>
        /// 下拉事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void GridView1_DownSlippling(object sender, EventArgs e)
        {
            Toast("数据已加载完成!", ToastLength.SHORT);
        }

        /// <summary>
        /// 上拉事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void GridView1_UpSlippling(object sender, EventArgs e)
        {
            try
            {
                pageIndex += 1;
                if (pageIndex < pagesCount)
                {
                    DataTable table = GetNootBooksRData();
                    if (table.Rows.Count > 0)
                    {
                        this.GridView1.AddData(table);
                    }
                }
                else
                {
                    Toast("数据已加载完成!", ToastLength.SHORT);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /// <summary>
        /// GridView点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void GridView1_CellClick(object sender, GridViewCellEventArgs e)
        {
            try
            {
                string ID = e.Cell.Items["lblID"].Value.ToString ();
                frmNBRecordDetail frm = new frmNBRecordDetail();
                frm.ID = ID;
                Redirect(frm, (MobileForm form, object args) =>
                {
                    if (frm.ShowResult == Smobiler.Core.ShowResult.Yes)
                    {
                        Bind();
                    }
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void frmNBRecordMain_Load(object sender, EventArgs e)
        {
            Bind();
        }
    }
}