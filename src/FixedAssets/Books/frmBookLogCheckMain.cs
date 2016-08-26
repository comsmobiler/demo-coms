using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;

namespace COMSSmobilerDemo.FixedAssets.Books
{
    partial class frmBookLogCheckMain : Smobiler.Core.MobileForm
    {

        //总页数
        public int pagesCount = 0;
        //当前页(第二页开始)
        public int pageIndex = 0;
        //当前页显示条数
        public int pagesize = 3;
        //总条数
        public int recordCount = 0;
        /// <summary>
        /// 初始化方法绑定数据
        /// </summary>
        /// <remarks></remarks>
        private void Bind()
        {
            try
            {
                pageIndex = 0;
                pagesCount = 2;
                DataTable table = GetBookLogData();
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
        private DataTable GetBookLogData()
        {
            try
            {
                COMSSmobilerDemo.common.BookLogInfo BookLogInfo = new COMSSmobilerDemo.common.BookLogInfo();
                DataTable table = BookLogInfo.GetBookDataByMode(TextTabBar1.SelectItemIndex, pageIndex, pagesize);
                return table;
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
                    DataTable table = GetBookLogData();
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
        private void GridView1_CellClick(object sender, GridViewCellEventArgs e)
        {
            try
            {
                string ID = e.Cell.Items["lblID"].Value.ToString ();
                        frmBookLogDetail frm = new frmBookLogDetail();
                        frm.bLogID = ID;
                        Redirect(frm);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmBookLog_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
        {
            try
            {
                switch (e.Name)
                {
                    case "add":
                        frmBookLogCreate frm = new frmBookLogCreate();
                        this.Redirect(frm, (MobileForm form, object args) =>
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
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmBookLog_TitleImageClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBookLog_KeyDown(object sender, KeyDownEventArgs e)
        {
            this.Close();
        }

        private void TextTabBar1_ItemClick(object sender, TabBarItemClickEventArgs e)
        {
            try
            {
                Bind();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmBookLog_Load(object sender, EventArgs e)
        {
            Bind();
        }

        private void frmBookLogCheckMain_LeftSlipping(object sender, EventArgs e)
        {
            try
            {
                if (TextTabBar1.SelectItemIndex > 0 & TextTabBar1.SelectItemIndex <= 1)
                {
                    TextTabBar1.SelectItemIndex = 0;
                    Bind();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmBookLogCheckMain_RightSlipping(object sender, EventArgs e)
        {
            try
            {
                if (TextTabBar1.SelectItemIndex >= 0 & TextTabBar1.SelectItemIndex < 1)
                {
                    TextTabBar1.SelectItemIndex = 1;
                    Bind();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}