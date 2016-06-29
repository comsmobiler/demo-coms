
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
        /// Handler事件
        /// </summary>
        /// <param name="item"></param>
        /// <param name="errorinfo"></param>
        /// <param name="args"></param>
        private void HandlerCostCenterPopList(object s, EventArgs e)
        {
            try
            {

                if (this.PopList1.Selection != null)
                {
                    this.LeftLayoutData.Items["txtCCUser"].Text = this.PopList1.Selection.Text;
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
        /// <summary>
        /// toolbar事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCostCenter_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
        {
            try
            {
              
                if (e.Name.Equals(tSearch.Name))
                {
                    this.ShowFooterBar("frmCCFootbarLayout");

                }
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

        /// <summary>
        /// 点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridView1_CellClick(object sender, GridViewCellEventArgs e)
        {
            try
            {
                CC_ID = e.Cell.Items["lblCC_ID"].Value + "/" + e.Cell.Items["lblRB_COSTCENTER"].Text;
                this.ShowResult = Smobiler.Core.ShowResult.Yes;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// FooterBarDialog点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCostCenter_FooterBarDialogLayoutItemClick(object sender, MobileFormLayoutItemEventArgs e)
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
                        PopList1.Groups.Add(poli);
                        int liindex = 0;
                        //设置PopListTitle
                        poli.Text = "成本中心责任人筛选";
                        //显示样式
                        foreach (DataRow rowli in cctable.Rows)
                        {
                            poli.Items.Add(rowli["USER_ID"].ToString(), liindex.ToString());
                            liindex += 1;
                        }

                        PopList1.ShowDialog();
                        break;

                    case "btnsearch":
                        string confirmUser = this.FooterBarDialogData.Items["txtCCUser"].Text;
                        string CCNAME = this.FooterBarDialogData.Items["txtCCName"].Text;
                        Bind(confirmUser, CCNAME);
                        this.CloseFooterBar();
                        //隐藏FooterBarLayout
                        break;
                    case "btncurrentUser":
                        this.FooterBarDialogData.Items["txtCCUser"].Text = "Demo";
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

