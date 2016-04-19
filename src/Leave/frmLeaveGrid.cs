using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;
using COMSSmobilerDemo.common;

namespace COMSSmobilerDemo.Leave
{
    partial class frmLeaveGrid : Smobiler.Core.MobileForm
    {

        #region ""
        private bool isSaving = false;
        private int btnMode;
        //总页数
        public int pagesCount = 0;
        //当前页(第二页开始)
        public int pageIndex = 0;
        //当前页显示条数
        public int pagesize = 5;
      
        #endregion
        //选择我审批的
        private void btnLCHECK_Click(object sender, EventArgs e)
        {
            try
            {
                btnMode = 2;
                Bind();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //选择我创建的
        private void btnLME_Click(object sender, EventArgs e)
        {
            try
            {
                btnMode = 1;
                Bind();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //窗体左滑时
        private void frmLeaveGrid_LeftSlipping(object sender, EventArgs e)
        {
            try
            {
                if (btnMode > 1 & btnMode <= 2)
                {
                    switch (btnMode)
                    {
                        case 2:
                            btnMode -= 1;
                            break;
                    }
                    Bind();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //窗体右滑时
        private void frmLeaveGrid_RightSlipping(object sender, EventArgs e)
        {
            try
            {
                if (btnMode >= 1 & btnMode < 2)
                {
                    switch (btnMode)
                    {
                        case 1:
                            btnMode += 1;
                            break;
                    }
                    Bind();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 初始化方法绑定数据
        /// </summary>
        /// <remarks></remarks>
        private void Bind()
        {
            try
            {
                switch (btnMode)
                {
                    case 1:
                        //设定样式并获取数据，我创建的
                        this.btnLME.ForeColor = System.Drawing.Color.DeepSkyBlue;
                        this.l_LMe.BackColor = System.Drawing.Color.DeepSkyBlue;
                        this.btnLCHECK.ForeColor = System.Drawing.Color.Gray;
                        this.l_LMeCheck.BackColor = System.Drawing.Color.White;
                        break;
                    case 2:
                        //设定样式并获取数据，我审批的
                        this.btnLME.ForeColor = System.Drawing.Color.Gray;
                        this.l_LMe.BackColor = System.Drawing.Color.White;
                        this.btnLCHECK.ForeColor = System.Drawing.Color.DeepSkyBlue;
                        this.l_LMeCheck.BackColor = System.Drawing.Color.DeepSkyBlue;
                        break;
                }
                pagesCount = 2;
                DataTable table = GetLeaveData();
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
        /// 获取请假数据
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        private DataTable GetLeaveData()
        {
            LeaveInfo LeaveInfo = new LeaveInfo();
            DataTable table = LeaveInfo.GetDataByLMode(btnMode, pageIndex, pagesize);
            return table;
        }

     
        /// <summary>
        /// Toolbar事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void frmLeaveGrid_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
        {
            try
            {
                try
                {
                    switch (e.Name)
                    {
                        case "addnew":
                            //跳转到创建页面
                            frmLeaveCreate frmLeaveCreate1 = new frmLeaveCreate();
                            this.Redirect(frmLeaveCreate1, (MobileForm form, object args) => Bind());
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
                finally
                {
                    isSaving = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //刚加载时显示我创建的请假单数据
        private void frmLeaveGrid_Load(object sender, EventArgs e)
        {
            try
            {
                btnMode = 1;
                Bind();
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
            MessageBox.Show("数据已加载完成");
        }

        /// <summary>
        /// 行项点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void GridView1_CellClick(object sender, GridViewCellEventArgs e)
        {
            try
            {
                string  state =e.Cell.Items["lblState"].Value.ToString ();
           
                if (btnMode == 2)
                {
                    frmLeaveDef1 frm = new frmLeaveDef1();
                    this.Redirect(frm, (MobileForm form, object args) =>
                    {
                        if (frm.ShowResult == Smobiler.Core.ShowResult.Yes)
                        {
                            Bind();
                        }
                    });
                }
                else if (btnMode == 1)
                {
                    switch (state)
                    {
                        case "0":
                       
                            frmLeaveEdit frmLeaveEdit = new frmLeaveEdit();

                            this.Redirect(frmLeaveEdit, (MobileForm form, object args) =>
                            {
                                if (frmLeaveEdit.ShowResult == Smobiler.Core.ShowResult.Yes)
                                {
                                    Bind();
                                }
                            });
                            break;
                        default:
                            frmLeaveDef frmLeaveDef = new frmLeaveDef();

                            this.Redirect(frmLeaveDef, (MobileForm form, object args) => Bind());
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                    DataTable table = GetLeaveData();
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