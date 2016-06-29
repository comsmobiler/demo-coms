
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
    public partial class frmRBPostMain : Smobiler.Core.MobileForm
    {

        /// <summary>
        /// 初始化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void frmRBPostMain_Load(object sender, EventArgs e)
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
        /// 初始化方法
        /// </summary>
        /// <remarks></remarks>
        private void Bind()
        {
            try
            {
                ReimbursementInfo ReimbursementInfo = new ReimbursementInfo();
                DataTable table = ReimbursementInfo.GetRBinfo1();
                if (table.Rows.Count > 0)
                {
                    table.Columns.Add("RB_COSTCENTERNAME", typeof(System.String));
                    table.Columns.Add("RBROW_AMOUNT_FORMAT", typeof(System.String));
                    table.Columns.Add("RBUSERDATE", typeof(System.String));
                    table.Columns.Add("NOTE", typeof(System.String));
                    foreach (DataRow row in table.Rows)
                    {
                        row["RB_COSTCENTERNAME"] = row["RB_COSTCENTER"] + "/Demo";
                        row["RBROW_AMOUNT_FORMAT"] = "￥" + row["RBROW_AMOUNT"].ToString();
                        if (row["RB_NOTE"].ToString().Length > 0)
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
        /// gridview点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridView1_CellClick(object sender, Smobiler.Core.Controls.GridViewCellEventArgs e)
        {
            try
            {
                frmRBPostDetail frm = new frmRBPostDetail();
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

