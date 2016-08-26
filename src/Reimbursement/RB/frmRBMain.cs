
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Net;
using System.IO;
using System.Net.Security;
using System.Text;
using System.Xml;
using System.Security.Cryptography.X509Certificates;
using COMSSmobilerDemo.common;
using COMSSmobilerDemo.Reimbursement.CostCenter;

namespace COMSSmobilerDemo.Reimbursement.RB
{
    public partial class frmRBMain : Smobiler.Core.MobileForm
    {
        #region "Properties"
        private int btnMode;
        internal string ROWTYPE;
        public string GetROWTYPE
        {
            get { return ROWTYPE; }
            set { ROWTYPE = value; }
        }
        internal string STATE;
        public string GetSTATE
        {
            get { return STATE; }
            set { STATE = value; }
        }
        #endregion

        /// <summary>
        /// 初始化方法
        /// </summary>
        /// <remarks></remarks>
        private void Bind()
        {
            try
            {
                DataTable table = new DataTable();
                switch (btnMode)
                {
                    case 1:
                        TextTabBar1.SelectItemIndex = 0;
                        this.GridView1.Layout = "frmConsumptionLayout";
                        ConsumptionInfo Consumptioninfo = new ConsumptionInfo();
                        table = Consumptioninfo.GetConsumptioninfo();
                        break;
                       
                    case 2:
                        TextTabBar1.SelectItemIndex = 1;
                        this.GridView1.Layout = "frmRBlayout";
                        ReimbursementInfo ReimbursementInfo = new ReimbursementInfo();
                        table = ReimbursementInfo.GetRBinfo();
                        break;
                }
                if (table.Rows.Count > 0)
                {
                    switch (btnMode)
                    {
                        case 1:
                           
                            table.Columns.Add("ROW_DATE", typeof(System.String));
                            table.Columns.Add("ROW_NOTE", typeof(System.String));
                            foreach (DataRow row in table.Rows)
                            {
                                

                                if (row["RBROW_NOTE"].ToString().Length > 0)
                                {
                                    row["ROW_NOTE"] = row["RBROW_NOTE"];
                                }
                                else
                                {
                                    row["ROW_NOTE"] = "无";
                                }
                             
                                row["ROW_DATE"] = Convert.ToDateTime(row["RBROW_DATE"]).ToShortDateString();
                            }

                            break;
                        case 2:
                            table.Columns.Add("RB_COSTCENTERNAME", typeof(System.String));
                            table.Columns.Add("RBROW_AMOUNT_FORMAT", typeof(System.String));
                            table.Columns.Add("RBUSERDATE", typeof(System.String));
                            table.Columns.Add("NOTE", typeof(System.String));
                            foreach (DataRow row in table.Rows)
                            {
                                row["RB_COSTCENTERNAME"] = row["RB_COSTCENTER"] + " Demo";
                                row["RBROW_AMOUNT_FORMAT"] = "￥" + row["RBROW_AMOUNT"].ToString();

                                if (row["RB_NOTE"].ToString().Length > 0)
                                {
                                  
                                    row["NOTE"] = "备注：" + row["RB_NOTE"];
                                }
                                else
                                {
                                    row["NOTE"] = "备注：";
                                }

                                row["RBUSERDATE"] = Convert.ToDateTime(row["CREATEDATE"]).ToShortDateString();
                            }

                            break;
                    }
                    //赋值GridView1数据
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
        /// toolbar按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void frmRBMain_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
        {
            try
            {
                
                if (e.Name.Equals(xfadd.Name))
                {
                    frmConsumption frm = new frmConsumption();
                    this.Redirect(frm, (MobileForm from,object args) =>
                    {
                        if (frm.ShowResult == Smobiler.Core.ShowResult.Yes)
                        {
                            Bind();
                        }
                    });
                }
                    
                if (e.Name.Equals(RBadd.Name))
                {
                    frmRBCreate frm = new frmRBCreate();
                    this.Redirect(frm, (MobileForm from, object args) =>
                    {
                        if (frm.ShowResult == Smobiler.Core.ShowResult.Yes)
                        {
                            Bind();
                        }
                    });
                }
                if (e.Name.Equals(SX.Name))//消费记录或报销筛选
                {
                    switch (btnMode)
                    {
                        case 1:
                            frmConsumptionMainRight frm = new frmConsumptionMainRight();
                            frm.ROWTYPE = ROWTYPE;
                            this.Redirect(frm, (MobileForm sender1, object args) =>
                            {
                                try
                                {
                                    if (frm.ShowResult == Smobiler.Core.ShowResult.Yes)
                                    {
                                        ROWTYPE = frm.ROWTYPE;
                                        Bind();
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                            });
                            break;
                        case 2:
                            frmRBMainRight frm1 = new frmRBMainRight();
                            frm1.STATE = STATE;
                            this.Redirect(frm1, (MobileForm sender1, object args) =>
                            {
                                try
                                {
                                    if (frm1.ShowResult == Smobiler.Core.ShowResult.Yes)
                                    {
                                        STATE = frm1.STATE;
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
                if (e.Name.Equals(Report .Name ))
                {
                    frmStatementAnalysis frm = new frmStatementAnalysis();
                    frm.Mode = btnMode;
                    this.Redirect(frm);                  
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
        private void frmRBMain_Load(object sender, EventArgs e)
        {
            try
            {
                btnMode = 1;
                ROWTYPE = "";
                STATE = "";
                Bind();
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
        private void frmRBMain_LeftSlipping(object sender, EventArgs e)
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

        /// <summary>
        /// 右滑事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void frmRBMain_RightSlipping(object sender, EventArgs e)
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
        /// gridview点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridView1_CellClick(object sender, GridViewCellEventArgs e)
        {
            try
            {
                switch (btnMode)
                {
                    case 1:
                        string ID = "1";
                        frmConsumption frm = new frmConsumption();
                        frm.COSPID = ID;
                        this.Redirect(frm, (MobileForm sender1, object args) =>
                        {
                            Bind();
                        });
                        break;
                    case 2:
                        int state = Convert.ToInt32(e.Cell.Items["lblState"].Value);
                        string RB_NO = e.Cell.Items["lblCC"].Value.ToString();
                        switch (state)
                        {
                            case 0:
                                frmRBEdit frm1 = new frmRBEdit();
                                frm1.RB_NO = RB_NO;
                                this.Redirect(frm1, (MobileForm sender1, object args) =>
                                {
                                    Bind();
                                });
                                break;
                            default:
                                frmRBDetail frm2 = new frmRBDetail();
                                frm2.RB_NO = RB_NO;
                                this.Redirect(frm2, (MobileForm sender1, object args) =>
                                {
                                    Bind();
                                });
                                break;
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// TextTabBar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextTabBar1_ItemClick(object sender, TabBarItemClickEventArgs e)
        {
            try
            {
                switch (e.Item.Value)
                {
                    case "xf":
                        btnMode = 1;
                        break;
                    case "bx":
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