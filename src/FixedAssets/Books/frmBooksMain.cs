using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;

namespace COMSSmobilerDemo.FixedAssets.Books
{
    partial class frmBooksMain : Smobiler.Core.MobileForm
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
                pagesCount = 3;
                pageIndex = 0;
                DataTable table = GetBooksData();
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
        /// 获取图书
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        private DataTable GetBooksData()
        {
            COMSSmobilerDemo.common.BookInfo BookInfo = new COMSSmobilerDemo.common.BookInfo();
            DataTable table = BookInfo.GetBookData(pageIndex, pagesize);
            return table;
        }

       
        private void GridView1_DownSlippling(object sender, EventArgs e)
        {
            Toast("数据已加载完成!", ToastLength.SHORT);
        }
        private void GridView1_UpSlippling(object sender, EventArgs e)
        {
            try
            {
                pageIndex += 1;
                if (pageIndex < pagesCount)
                {
                    DataTable table = GetBooksData();
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
        /// 点击进入图书详情
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void GridView1_CellClick(object sender, GridViewCellEventArgs e)
        {
            try
            {
                string BOOKID = e.Cell.Items["lblBOOKID"].Value.ToString();
                frmBookDetail frm = new frmBookDetail();
                frm.BOOKID = BOOKID;
                this.Redirect(frm, (MobileForm form, object args) =>
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

        private void frmBooksMain_KeyDown(object sender, KeyDownEventArgs e)
        {
            Close();
        }

        private void frmBooksMain_TitleImageClick(object sender, EventArgs e)
        {
            Close();
        }

        private void frmBooksMain_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
        {
            try
            {
                switch (e.Name)
                {
                    case "add":
                        frmBookCreate frm = new frmBookCreate();
                        this.Redirect(frm, (MobileForm form, object args) =>
                        {
                            if (frm.ShowResult == Smobiler.Core.ShowResult.Yes)
                            {
                                Bind();
                            }
                        });
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmBooksMain_Load(object sender, EventArgs e)
        {
            Bind();
        }
    }
}