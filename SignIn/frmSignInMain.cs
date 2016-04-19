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
                switch (btnMode)
                {
                    case 1:
                        this.btnDaySign.ForeColor = System.Drawing.Color.DeepSkyBlue;
                        this.btnSDaySign.ForeColor = System.Drawing.Color.Gray;
                        this.btnMonthSign.ForeColor = System.Drawing.Color.Gray;
                        this.l_DaySign.BackColor = System.Drawing.Color.DeepSkyBlue;
                        this.L_SDaySign.BackColor = System.Drawing.Color.White;
                        this.L_MonthSign.BackColor = System.Drawing.Color.White;
                        break;
                    case 2:
                        this.btnDaySign.ForeColor = System.Drawing.Color.Gray;
                        this.btnSDaySign.ForeColor = System.Drawing.Color.DeepSkyBlue;
                        this.btnMonthSign.ForeColor = System.Drawing.Color.Gray;
                        this.l_DaySign.BackColor = System.Drawing.Color.White;
                        this.L_SDaySign.BackColor = System.Drawing.Color.DeepSkyBlue;
                        this.L_MonthSign.BackColor = System.Drawing.Color.White;
                        break;
                    case 3:
                        this.btnDaySign.ForeColor = System.Drawing.Color.Gray;
                        this.btnSDaySign.ForeColor = System.Drawing.Color.Gray;
                        this.btnMonthSign.ForeColor = System.Drawing.Color.DeepSkyBlue;
                        this.l_DaySign.BackColor = System.Drawing.Color.White;
                        this.L_SDaySign.BackColor = System.Drawing.Color.White;
                        this.L_MonthSign.BackColor = System.Drawing.Color.DeepSkyBlue;
                        break;
                }               
                pagesCount =2;
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
        /// 今天签到的
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void btnDaySign_Click(object sender, EventArgs e)
        {
            btnMode = 1;
            Bind();
        }

        /// <summary>
        /// 最近七天签到
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void btnSDaySign_Click(object sender, EventArgs e)
        {
            btnMode = 2;
            Bind();
        }

        /// <summary>
        /// 最近一个月签到
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void btnMonthSign_Click(object sender, EventArgs e)
        {
            btnMode = 3;
            Bind();
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
                    MessageBox.Show("数据已加载完成!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void GridView1_DownSlippling(object sender, EventArgs e)
        {
            MessageBox.Show("数据已加载完成!");
        }

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
                case "tExit":
                    this.Close();
                    break;
            }


        }

    }
}