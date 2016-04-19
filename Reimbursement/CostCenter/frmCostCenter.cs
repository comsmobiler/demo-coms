
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
using Smobiler.Core.Controls;
using COMSSmobilerDemo.common;
namespace COMSSmobilerDemo.Reimbursement.CostCenter
{
    public partial class frmCostCenter : Smobiler.Core.MobileForm
    {


        public string CC_ID;

        private void Bind(string confirmUser, string CCNAME)
        {
            try
            {
                CostCenterInfo CostCenterInfo = new CostCenterInfo();
                DataTable cctable = CostCenterInfo.GetCostCenterInfo();
                if (cctable.Rows.Count > 0)
                {
                    this.GridView1.DataSource = cctable;
                    this.GridView1.DataBind();
                    foreach (GridViewRow ROW in GridView1.Rows)
                    {
                        ROW.Cell.Items["lblRB_COSTCENTER"].Text = ROW.Cell.Items["lblRB_COSTCENTER"].Text + "/" + ROW.Cell.Items["lblRB_COSTCENTER"].Value;
                    }
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
        /// 左右侧栏点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="cell"></param>
        /// <param name="cellItem"></param>
        private void frmCostCenter_ItemClick(object sender, MobileFormLayoutItemEventArgs e)
        {

            try
            {
                switch (e.CellItem.Name)
                {
                    case "btnchoice":
                        DataTable cctable = new DataTable();
                        cctable.Columns.Add("USER_ID", typeof(System.String));
                        cctable.Rows.Add("MobilerUser");
                        cctable.Rows.Add("MUser");
                        PopListGroup poli = new PopListGroup();
                        popList1.Groups.Add(poli);
                        int liindex = 0;
                        //设置PopListTitle
                        poli.Text = "成本中心责任人";
                        //显示样式
                        foreach (DataRow rowli in cctable.Rows)
                        {
                            poli.Items.Add(rowli["USER_ID"].ToString(), liindex.ToString());
                            liindex += 1;
                        }

                        popList1.Show();
                        break;

                    case "btnsearch":
                        string confirmUser = this.LeftLayoutData.Items["txtCCUser"].Text;
                        string CCNAME = this.LeftLayoutData.Items["txtCCName"].Text;
                        Bind(confirmUser, CCNAME);
                        this.CloseSlider();
                        //隐藏左右屏幕
                        break;
                    case "btncurrentUser":
                        this.LeftLayoutData.Items["txtCCUser"].Text = "MobilerUser";
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Handler事件
        /// </summary>
        /// <param name="item"></param>
        /// <param name="errorinfo"></param>
        /// <param name="args"></param>
        private void HandlerCostCenterPopList(object s, EventArgs e)
        {
            try
            {

                if (this.popList1.Selection != null)
                {
                    this.LeftLayoutData.Items["txtCCUser"].Text = this.popList1.Selection.Text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void GridView1_ItemClick(object sender, GridViewCellItemEventArgs e)
        {
            try
            {
                this.ShowResult = Smobiler.Core.ShowResult.Yes;
                this.Close();
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
        private void frmCostCenter_Load(object sender, EventArgs e)
        {
            try
            {
                Bind("", "");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmCostCenter_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
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
                    });

                }
                if (e.Name.Equals(tSearch.Name))
                {
                    this.ShowSlider();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
   
}

