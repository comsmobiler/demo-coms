using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;
using COMSSmobilerDemo.common;

namespace COMSSmobilerDemo.SignIn
{
    partial class frmSignInMain : Smobiler.Core.MobileForm
    {

        #region ""
        private int btnMode;
        //总页数
        public int pagesCount = 0;
        //当前页(第二页开始)
        public int pageIndex = 0;
        //当前页显示条数
        public int pagesize = 3;
        #endregion
        private void frmSignIn_Load(object sender, EventArgs e)
        {
            btnMode = 1;
            Bind();
        }
        private void Bind()
        {
            try
            {
                pageIndex = 0;
                pagesCount =2;
                switch (btnMode)
                {
                    case 1:
                        TextTabBar1.SelectItemIndex = 0;
                        break;
                    case 2:
                        TextTabBar1.SelectItemIndex = 1;
                        break;
                    case 3:
                        TextTabBar1.SelectItemIndex = 2;
                        break;
                }
                DataTable table = getSignIninfoData();
                if (table.Rows.Count > 0)
                {
                    GridView1.DataSource = table;
                    GridView1.DataBind();
                }
                else
                {
                    GridView1.Rows.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private DataTable  getSignIninfoData()
        {
             DataTable table =new DataTable ();
            try
            {
                SignIninfo signIninfo = new SignIninfo();
                table = signIninfo.GetDataBySMode(btnMode, pageIndex, pagesize);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return table;
        }




     

        /// <summary>
        /// GridView上拉事件
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
                    DataTable table = getSignIninfoData();
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
        /// GridView下拉事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void GridView1_DownSlippling(object sender, EventArgs e)
        {
           Toast("数据已加载完成!");
        }
        /// <summary>
        /// 左滑事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSignIn_LeftSlipping(object sender, EventArgs e)
        {
            try
            {
                if (btnMode > 1 & btnMode <= 3)
                {
                    btnMode -= 1;
                    Bind();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 右滑事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSignIn_RightSlipping(object sender, EventArgs e)
        {
            try
            {
                if (btnMode >= 1 & btnMode < 3)
                {
                    btnMode += 1;
                    Bind();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Toolbar事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSignIn_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
        {
            switch (e.Name)
            {
                case "add":
                    frmSignInCreate frm = new frmSignInCreate();
                    Redirect(frm, (MobileForm form,object args) =>
                    {
                        if (frm.ShowResult == Smobiler.Core.ShowResult.Yes)
                        {
                            Bind();
                        }
                    });
                    break;
            }


        }

        /// <summary>
        /// TextTabBar点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextTabBar1_ItemClick(object sender, TabBarItemClickEventArgs e)
        {

            try
            {
                switch (e.Item.Value)
                {
                    case "DaySign":
                        btnMode = 1;
                        break;
                    case "SDaySign":
                        btnMode = 2;
                        break;
                    case "MDaySign":
                        btnMode = 3;
                        break;
                }
                Bind();
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
        private void frmSignInMain_TitleImageClick(object sender, EventArgs e)
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
    }
}