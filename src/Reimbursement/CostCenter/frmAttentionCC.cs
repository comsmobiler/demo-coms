
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;

using Smobiler.Core.Controls;
using COMSSmobilerDemo.common;
using COMSSmobilerDemo.Reimbursement.RB;
using COMSSmobilerDemo.Message;
namespace COMSSmobilerDemo.Reimbursement.CostCenter
{
    public partial class frmAttentionCC : Smobiler.Core.MobileForm
    {
        internal string leftItemname = "";
        internal int muneMode;
        /// <summary>
        /// bind方法
        /// </summary>
        private void Bind()
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
                        ROW.Cell.Items["imgUserAttention"].DefaultValue = "unAttention";
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
        /// 初始化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAttentionCC_Load(object sender, EventArgs e)
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
        /// Toolbar按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAttentionCC_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
        {
            try
            {
                if (e.Name.Equals(save.Name))
                {

                    MessageBox.Show("保存成功。");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// GridView事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="cell"></param>
        /// <param name="cellItem"></param>
        private void GridView1_ItemClick(object sender, GridViewCellItemEventArgs e)
        {
            try
            {
                switch (e.CellItem.Name)
                {
                    case "imgUserAttention":
                        if (e.Cell.Items["imgUserAttention"].DefaultValue.ToString().Length > 0)
                        {
                            if (e.Cell.Items["imgUserAttention"].DefaultValue.ToString() == ("Attention"))
                            {
                                e.Cell.Items["imgUserAttention"].DefaultValue = "unAttention";
                            }
                            else
                            {
                                e.Cell.Items["imgUserAttention"].DefaultValue = "Attention";
                            }
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
        /// 显示左侧栏菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAttentionCC_TitleImageClick(object sender, EventArgs e)
        {
            try
            {
                this.ShowSlider(Slider.Left);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 左侧栏点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAttentionCC_LeftLayoutItemClick(object sender, MobileFormLayoutItemEventArgs e)
        {
            try
            {
                switch (e.CellItem.Name)
                {
                    case "imgbtnMain":
                    case "btnMain":
                        switch (muneMode)
                        {
                            case 0:
                                frmMessage frm = new frmMessage();
                                this.Redirect(frm, (MobileForm form, object args) => this.Close());
                                break;
                            case 1:
                                frmRBMune frmRBMune = new frmRBMune();
                                this.Redirect(frmRBMune, (MobileForm form, object args) => this.Close());
                                break;
                            case 2:
                                frmOtherMune frmOtherMune = new frmOtherMune();
                                this.Redirect(frmOtherMune, (MobileForm form, object args) => this.Close());
                                break;
                        }
                        break;
                    case "imgbtnUserCC":
                    case "btnUserCC":
                        this.CloseSlider();
                        break;
                    case "imgbtnUser":
                    case "btnUser":
                        frmUserDetail frmUserDetail = new frmUserDetail();
                        frmUserDetail.muneMode = muneMode;
                        this.Redirect(frmUserDetail, (MobileForm form, object args) =>
                        {
                            if (frmUserDetail.ShowResult == Smobiler.Core.ShowResult.Yes)
                            {
                                ((ImageButton)LeftLayoutData.Items["imgUser"].DefaultValue).Refresh();
                            }
                            this.Close();
                        });
                        break;
                    case "imgbtnHelp":
                    case "btnHelp":
                        this.RedirectUrl("帮助", "http://www.searching-info.com/coms/ComsSmobiler.html");
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