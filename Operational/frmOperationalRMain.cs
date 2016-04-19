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
            DataTable table = OperationalInfo.GetOperationalRData(pageIndex, pagesize);
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
                    case "tExit":
                        this.Close();
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
               
                frmOperationalREdit frm = new frmOperationalREdit();
                this.Redirect(frm, (MobileForm form ,object args ) =>
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

        /// <summary>
        /// 下拉事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void GridView1_DownSlippling(object sender, EventArgs e)
        {
            MessageBox.Show("数据加载完成");
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
                    MessageBox.Show("数据已加载完成!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}