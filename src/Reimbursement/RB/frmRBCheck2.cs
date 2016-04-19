
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
using COMSSmobilerDemo.common;
namespace COMSSmobilerDemo.Reimbursement.RB
{
    public partial class frmRBCheck2 : Smobiler.Core.MobileForm
    {
     

        /// <summary>
        /// 初始化方法
        /// </summary>
        /// <remarks></remarks>
        private void Bind()
        {
            try
            {
                ReimbursementInfo ReimbursementInfo = new ReimbursementInfo();
                DataTable table = ReimbursementInfo.GetRBinfo2();
                if (table.Rows.Count > 0)
                {
                    table.Columns.Add("RB_COSTCENTERNAME", typeof(System.String));
                    table.Columns.Add("RBROW_AMOUNT_FORMAT", typeof(System.String));
                    table.Columns.Add("RBUSERDATE", typeof(System.String));
                    table.Columns.Add("NOTE", typeof(System.String));
                    foreach (DataRow row in table.Rows)
                    {
                        row["RB_COSTCENTERNAME"] = row["RB_COSTCENTER"] + "/MobilerUser";
                        row["RBROW_AMOUNT_FORMAT"] = "￥" + row["RBROW_AMOUNT"].ToString();

                        if (row["RB_NOTE"].ToString().Length > 20)
                        {
                            row["NOTE"] = "备注：" + row["NOTE"].ToString().Substring(0, 20) + "…";
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
        /// 初始化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void frmRBCheck2_Load(object sender, EventArgs e)
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


        /// <summary>
        /// Toolbar按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void frmRBCheck2_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
        {
            try
            {
                if (e.Name.Equals(tExit.Name))
                {
                    this.Close();
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
        private void GridView1_CellClick(object sender, Smobiler.Core.Controls.GridViewCellEventArgs e)
        {
            try
            {
                frmRBDetail1 frm = new frmRBDetail1();
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
    }
}