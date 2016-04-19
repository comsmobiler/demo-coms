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
                        //我创建的
                        this.btnWorkDCreate.ForeColor = System.Drawing.Color.DeepSkyBlue;
                        this.l_WorkR.BackColor = System.Drawing.Color.DeepSkyBlue;
                        this.btnWorkDCheck.ForeColor = System.Drawing.Color.Gray;
                        this.l_WorkD.BackColor = System.Drawing.Color.White;
                        break;
                    case 2:
                        //我审批的
                        this.btnWorkDCreate.ForeColor = System.Drawing.Color.Gray;
                        this.l_WorkR.BackColor = System.Drawing.Color.White;
                        this.btnWorkDCheck.ForeColor = System.Drawing.Color.DeepSkyBlue;
                        this.l_WorkD.BackColor = System.Drawing.Color.DeepSkyBlue;
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
                    case "tExit":
                        //返回
                        this.Close();
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
        /// 工作单我创建的按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void btnWorkDCreate_Click(object sender, EventArgs e)
        {
            btnMode = 1;
            Bind();
        }

        /// <summary>
        /// 工作单我待审批的按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void btnWorkDCheck_Click(object sender, EventArgs e)
        {
            btnMode = 2;
            Bind();
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
                MessageBox.Show("数据已加载完成！");
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
                    MessageBox.Show("数据已加载完成！");
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
        /// 工作单筛选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void frmWorkDMain_TitleImageClick(object sender, EventArgs e)
        {
            try
            {
                frmWorkDocumentMainRight frm = new frmWorkDocumentMainRight();
                frm.STATE = STATE;
                frm.btnMode = btnMode;
                this.Redirect(frm, (MobileForm form ,object args) =>
                {
                    try
                    {
                        if (frm.ShowResult == Smobiler.Core.ShowResult.Yes)
                        {
                            STATE = frm.STATE;
                            Bind();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}