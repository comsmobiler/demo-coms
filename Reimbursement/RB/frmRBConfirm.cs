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
                    lblREASON.Visible = false;
                }
                else
                {
                    CheckBox2.Checked = true;
                    txtRB_REASON.Visible = true;
                    lblREASON.Visible = true;
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
                    lblREASON.Visible = true;
                }
                else
                {
                    CheckBox1.Checked = true;
                    txtRB_REASON.Visible = false;
                    lblREASON.Visible = false;
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
