
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
                        this.btnRBConsumption.ForeColor = System.Drawing.Color.DeepSkyBlue;//更改消费记录按钮字体颜色
                        this.l_RBConsumption.BackColor = System.Drawing.Color.DeepSkyBlue;
                        this.btnRB.ForeColor = System.Drawing.Color.Gray;
                        this.l_RB.BackColor = System.Drawing.Color.White;
                        this.GridView1.Layout = "frmConsumptionLayout";
                        ConsumptionInfo Consumptioninfo = new ConsumptionInfo();
                        table = Consumptioninfo.GetConsumptioninfo();
                        break;
                    case 2:
                        this.btnRBConsumption.ForeColor = System.Drawing.Color.Gray;
                        this.l_RBConsumption.BackColor = System.Drawing.Color.White;
                        this.btnRB.ForeColor = System.Drawing.Color.DeepSkyBlue;
                        this.l_RB.BackColor = System.Drawing.Color.DeepSkyBlue;
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
                            table.Columns.Add("RBROW_AMOUNT_FORMAT", typeof(System.String));
                            table.Columns.Add("ROW_DATE", typeof(System.String));
                            table.Columns.Add("ROW_NOTE", typeof(System.String));
                            foreach (DataRow row in table.Rows)
                            {
                                if (table.Rows[0]["RBROW_AMOUNT"].ToString().Length <= 0)
                                {
                                    row["RBROW_AMOUNT_FORMAT"] = "￥0.00";
                                }
                                if (table.Rows[0]["RBROW_AMOUNT"].ToString().Length > 0)
                                {
                                    row["RBROW_AMOUNT_FORMAT"] = "￥" + row["RBROW_AMOUNT"].ToString();
                                }

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
                                row["RB_COSTCENTERNAME"] = row["RB_COSTCENTER"] + "/Demo";
                                row["RBROW_AMOUNT_FORMAT"] = "￥" + row["RBROW_AMOUNT"].ToString();

                                if (row["RB_NOTE"].ToString().Length > 20)
                                {
                                    row["NOTE"] = "备注：" + row["RB_NOTE"].ToString().Substring(0, 20) + "…";
                                }
                                else if (row["RB_NOTE"].ToString().Length <= 20 & row["RB_NOTE"].ToString().Length > 0)
                                {
                                    row["NOTE"] = "备注：" + row["RB_NOTE"];
                                }
                                else
                                {
                                    row["NOTE"] = "备注：无";
                                }

                                row["RBUSERDATE"] = row["RB_USER"] + " " + Convert.ToDateTime(row["CREATEDATE"]).ToShortDateString();
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
                if (e.Name.Equals(tExit.Name))
                {
                    MessageBox.Show("是否确定返回？", MessageBoxButtons.YesNo, (Object s, MessageBoxHandlerArgs args) =>
                    {
                        if (args.Result == Smobiler.Core.ShowResult.Yes)
                        {
                            this.Close();
                        }
                    }
                    );
                }
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 消费记录显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void btnRBConsumption_Click(object sender, EventArgs e)
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
        /// 报销单显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void btnRB_Click(object sender, EventArgs e)
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

   

        /// <summary>
        /// 消费记录类型或报销单状态筛选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void ImageButton2_Click(object sender, EventArgs e)
        {
            try
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
        /// 责任人审批按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImageButton3_Click(object sender, EventArgs e)
        {
            try
            {
                frmRBCheck2 frm = new frmRBCheck2();
                this.Redirect(frm, (MobileForm sender1, object args) =>
                {
                    Bind();
                });
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
    }
}