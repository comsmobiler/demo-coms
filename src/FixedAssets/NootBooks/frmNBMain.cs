using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;

namespace COMSSmobilerDemo.FixedAssets.NootBooks
{
    partial class frmNBMain : Smobiler.Core.MobileForm
    {

        #region ""
        //总页数
        public int pagesCount = 0;
        //当前页(第二页开始)
        public int pageIndex = 0;
        //当前页显示条数
        public int pagesize = 3;
        //总条数
        public int recordCount = 0;
        #endregion
        /// <summary>
        /// 初始化方法绑定数据
        /// </summary>
        /// <remarks></remarks>
        private void Bind()
        {
            try
            {
                pageIndex = 0;
                pagesCount = 3;
                DataTable table = GetNootBooksData();
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
        private DataTable GetNootBooksData()
        {
            COMSSmobilerDemo.common.NBInfo NBInfo = new COMSSmobilerDemo.common.NBInfo();
            DataTable table = NBInfo.GetNootBooksData(pageIndex, pagesize);
            return table;
        }



        private void frmNBMain_TitleImageClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNBMain_KeyDown(object sender, KeyDownEventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void frmNBMain_Load(object sender, EventArgs e)
        {
            Bind();
        }
        /// <summary>
        /// Toolbar事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void frmNBMain_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
        {
            try
            {
                if (e.Name.Equals(add.Name))
                {
                    frmNBCreate frm = new frmNBCreate();
                    Redirect(frm, (MobileForm form, object args) =>
                    {
                        try
                        {
                            if (frm.ShowResult == Smobiler.Core.ShowResult.Yes)
                            {
                                Bind();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    });
                }
                if (e.Name.Equals(add2.Name))
                {
                    frmNBRecordCreate frm = new frmNBRecordCreate();
                    Redirect(frm);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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
                    DataTable table = GetNootBooksData();
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
            string NO = e.Cell.Items["lblNB_SN"].Value.ToString ();
            frmNBDetail frm = new frmNBDetail();
            frm.NO  = NO;
            Redirect(frm, (MobileForm form, object args) =>
            {
                if (frm.ShowResult == Smobiler.Core.ShowResult.Yes)
                {
                    Bind();
                }
            });
        }
    }
}