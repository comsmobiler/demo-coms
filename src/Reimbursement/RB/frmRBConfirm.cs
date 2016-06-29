using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
using Smobiler.Core.Controls;
namespace COMSSmobilerDemo.Reimbursement.RB
{
    public partial class frmRBConfirm : Smobiler.Core.MobileForm
    {
        /// <summary>
        /// CheckBox1点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckBox1_CheckChanged(object sender, CheckEventArgs e)
        {
            try
            {
                if (CheckBox1.Checked)
                {
                    CheckBox2.Checked = false;
                    txtRB_REASON.Visible = false;
                   
                }
                else
                {
                    CheckBox2.Checked = true;
                    txtRB_REASON.Visible = true;
              
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// CheckBox2点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckBox2_CheckChanged(object sender, CheckEventArgs e)
        {
            try
            {
                if (CheckBox2.Checked)
                {
                    CheckBox1.Checked = false;
                    txtRB_REASON.Visible = true;
                   
                }
                else
                {
                    CheckBox1.Checked = true;
                    txtRB_REASON.Visible = false;
                  
                }
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
        private void frmRBConfirm_ToolbarItemClick(Object sender, ToolbarClickEventArgs e)
        {
            try
            {
                if (e.Name.Equals(save.Name))
                {
                    if (CheckBox1.Checked)
                    {
                        MessageBox.Show("报销已审核！", (Object s, MessageBoxHandlerArgs args) =>
                           {
                               this.Close();
                           });
                    }
                    if (CheckBox2.Checked)
                    {
                        MessageBox.Show("报销被驳回！", (Object s, MessageBoxHandlerArgs args) =>
                       {
                           this.Close();
                       });
                    }
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
