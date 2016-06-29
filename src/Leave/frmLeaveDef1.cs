using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace COMSSmobilerDemo.Leave
{
    partial class frmLeaveDef1 : Smobiler.Core.MobileForm
    {
        private void frmLeaveDef1_Load(object sender, EventArgs e)
        {
            Bind();
        }
        private void Bind()
        {
            lbllNO.Text = "L001";
            lbllType.Text = "事假";
            lblbDate.Text = DateTime.Now.ToShortDateString();
            lbleDate.Text = DateTime.Now.ToShortDateString();
            lbllDay.Text = "1.00";
            lbllReason.Text = "家里有事";
            lblCUser.Text = "A";
            lblCreateUser.Text = "B";
            lblCreateDate.Text = DateTime.Now.ToShortDateString();
            lblState.Text = "已送审";
        }

        /// <summary>
        /// toolbar事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmLeaveDef1_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
        {
            if (e.Name.Equals(Confirm .Name ))
            {
                frmLeaveConfirm frm = new frmLeaveConfirm();
                Redirect(frm);
            }
            if (e.Name.Equals(CopyTo.Name))
            {
                frmLCopyToUser frm = new frmLCopyToUser();
                Redirect(frm);
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