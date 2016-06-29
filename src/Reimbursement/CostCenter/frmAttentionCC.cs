
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

       

        private DateTime taosttime;
        private bool handleExit = false;
        private void MobileForm_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
            {
                HandleToast();
            }
        }

        private void HandleToast()
        {
            if (handleExit == true && taosttime.AddSeconds(3) >= DateTime.Now)
            {
                handleExit = false;
                this.Close();
            }
            else
            {
                handleExit = true;
                taosttime = DateTime.Now;
                this.Toast("再按一次退出界面", ToastLength.SHORT);
            }
        }
        /// <summary>
        /// TitleImage点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MobileForm_TitleImageClick(object sender, EventArgs e)
        {
            HandleToast();
        }

        
    }
}