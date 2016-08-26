using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;

namespace COMSSmobilerDemo.Operational
{
    partial class frmOperationalRMain : Smobiler.Core.MobileForm
    {

        #region ""
        //总页数
        public int pagesCount = 0;
        //当前页(第二页开始)
        public int pageIndex = 0;
        //当前页显示条数
        public int pagesize = 3;
        #endregion
        /// <summary>
        /// 初始化方法绑定数据
        /// </summary>
        /// <remarks></remarks>
        private void Bind()
        {
            try
            {
                pagesCount = 2;
                switch (TextTabBar1.SelectItemIndex)
                {
                    case 0:
                        GridView1.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(239)), Convert.ToInt32(Convert.ToByte(239)), Convert.ToInt32(Convert.ToByte(244)));
                        GridView1.Layout = "frmOperationalCULayout";
                        break;
                    case 1:
                        GridView1.BackColor = System.Drawing.Color.White;
                        GridView1.Layout = "frmOperationalLayout";
                        break;
                }
                DataTable table = GetOperationalRData();
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
        /// 获取运维记录
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        private DataTable GetOperationalRData()
        {
            OperationalInfo OperationalInfo = new OperationalInfo();
            DataTable table=new DataTable ();
            switch (TextTabBar1.SelectItemIndex)
            {
                case 0:
                    table = OperationalInfo.GetOperationalRData1(pageIndex, pagesize);
                    break;
                case 1:
                    table = OperationalInfo.GetOperationalRData(pageIndex, pagesize);
                    break;
            }
            return table;
        }


        /// <summary>
        /// toolbar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void frmOperationalRMain_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
        {

            try
            {
                switch (e.Name)
                {
                    case "add":
                        //跳转到创建页面
                        frmOperationalRCreate frm = new frmOperationalRCreate();
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

        /// <summary>
        /// 初始化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void frmOperationalRMain_Load(object sender, EventArgs e)
        {
            Bind();
        }

        /// <summary>
        /// gridview点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void GridView1_CellClick(object sender, GridViewCellEventArgs e)
        {
            try
            {
                switch (TextTabBar1.SelectItemIndex)
                {
                    case 0:
                        frmOperationalRDetail frm1 = new frmOperationalRDetail();
                    this.Redirect(frm1, (MobileForm form ,object args ) =>
                    {
                        if (frm1.ShowResult == Smobiler.Core.ShowResult.Yes)
                        {
                            Bind();
                        }
                    });
                        break;
                    case 1:
                       frmOperationalREdit frm = new frmOperationalREdit();
                        this.Redirect(frm, (MobileForm form ,object args ) =>
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

        /// <summary>
        /// 下拉事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void GridView1_DownSlippling(object sender, EventArgs e)
        {
            Toast ("数据加载完成");
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
                    DataTable table = GetOperationalRData();
                    if (table.Rows.Count > 0)
                    {
                        this.GridView1.AddData(table);
                    }
                }
                else
                {
                    Toast("数据已加载完成!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /// <summary>
        /// TitleImage事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MobileForm_TitleImageClick(object sender, EventArgs e)
        {
            HandleToast();
        }
        /// <summary>
        /// 手机自带回退按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MobileForm_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
            {
                HandleToast();
            }
        }

        private void HandleToast()
        {
            this.Close();
        }

        private void TextTabBar1_ItemClick(object sender, TabBarItemClickEventArgs e)
        {
            Bind();
        } 
    }
}