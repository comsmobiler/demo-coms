using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;
using COMSSmobilerDemo.common;

namespace COMSSmobilerDemo.WorkDocument
{
    partial class frmWorkDMain : Smobiler.Core.MobileForm
    {

        #region ""
        private int btnMode;
        //总页数
        public int pagesCount = 0;
        //当前页(第二页开始)
        public int pageIndex = 0;
        //当前页显示条数
        public int pagesize = 10;
        //总条数
        public int recordCount = 0;
        //状态
        internal string STATE = "";
        public string GetSTATE
        {
            get { return STATE; }
            set { STATE = value; }
        }
        #endregion
        /// <summary>
        /// bind方法
        /// </summary>
        /// <remarks></remarks>
        private void Bind()
        {
            try
            {
                switch (btnMode)
                {
                    case 1:
                        TextTabBar1.SelectItemIndex = 0;
                        break;
                    case 2:
                        TextTabBar1.SelectItemIndex = 1;
                        break;
                }
                pagesCount =2;
                //获取我创建或我审批工作单的总条数
                DataTable table = GetData();
                //我创建的或我审批的数据
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
        /// GetData方法
        /// </summary>
        /// <remarks></remarks>
        private DataTable GetData()
        {
            DataTable table=new DataTable ();
            try
            {
                WorkDInfo WorkDInfo = new WorkDInfo();
                table = WorkDInfo.GetWorkDInfodate(btnMode, STATE, pageIndex, pagesize);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return table;
        }

     
        /// <summary>
        /// 初始化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void frmWorkDocumentMain_Load(object sender, EventArgs e)
        {
            btnMode = 1;
            Bind();
        }

        /// <summary>
        /// toolbar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void frmWorkDocumentMain_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
        {
            try
            {
                switch (e.Name)
                {
                    case "KPI":
                        frmUserKPI frmUserKPI = new frmUserKPI();
                        this.Redirect(frmUserKPI);
                        break;
                    case "SX":
                        //筛选
                         frmWorkDocumentMainRight frmD = new frmWorkDocumentMainRight();
                         frmD.STATE = STATE;
                         frmD.btnMode = btnMode;
                         this.Redirect(frmD, (MobileForm form, object args) =>
                                {
                                    try
                                    {
                                        if (frmD.ShowResult == Smobiler.Core.ShowResult.Yes)
                                        {
                                            STATE = frmD.STATE;
                                            Bind();
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                    }
                                });
                        break;
                    case "add":
                        //新增工作单
                        frmWorkDocumentCreate frm = new frmWorkDocumentCreate();
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
        /// 左滑事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void frmWorkDocumentMain_LeftSlipping(object sender, EventArgs e)
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

        /// <summary>
        /// 右滑事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void frmWorkDocumentMain_RightSlipping(object sender, EventArgs e)
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
        private void GridView1_DownSlippling(object sender, EventArgs e)
        {
            try
            {
                Toast ("数据已加载完成！");
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
        private void GridView1_UpSlippling(object sender, EventArgs e)
        {
            try
            {
                pageIndex += 1;
                if (pageIndex < pagesCount)
                {    
                    DataTable table = GetData();   
                    if (table.Rows.Count > 0)
                    {
                        this.GridView1.AddData(table);
                    }
                }
                else
                {
                    Toast ("数据已加载完成！");
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
                //更新gridview的cell中，cellitem背景颜色
                e.Cell.Items["lblState"].BackColor = System.Drawing.Color.Green;
                e.Cell.Items["lblState"].ForeColor = System.Drawing.Color.White;
                int state=0;
                switch (btnMode)
                {
                    case 1:
                        if (state==0)
                        {       
                            frmWorkDocumentEdit frmWorkDocumentEdit = new frmWorkDocumentEdit();
                            this.Redirect(frmWorkDocumentEdit, (MobileForm form ,object args) =>
                            {
                                if (frmWorkDocumentEdit.ShowResult == Smobiler.Core.ShowResult.Yes)
                                {
                                    Bind();
                                }
                            });
                            break;
                        }
                        else 
                        {
                            frmWorkDocumentDetail frmWorkDocumentDetail = new frmWorkDocumentDetail();
                            this.Redirect(frmWorkDocumentDetail);
                            break;
                        }
            
                    case 2:
                        frmWorkDocumentDetail1 frm1 = new frmWorkDocumentDetail1();
                        this.Redirect(frm1, (MobileForm form, object args) =>
                        {
                            if (frm1.ShowResult == Smobiler.Core.ShowResult.Yes)
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
        /// TextTabBar事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextTabBar1_ItemClick(object sender, TabBarItemClickEventArgs e)
        {
            try
            {
                switch (e.Item.Value)
                {
                    case "WDCreate":
                        btnMode = 1;
                        break;
                    case "WDCheck":
                        btnMode = 2;
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
    }
}