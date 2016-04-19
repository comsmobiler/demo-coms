using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using COMSSmobilerDemo.WorkDocument;
using COMSSmobilerDemo.Leave;
using COMSSmobilerDemo.SignIn;
using COMSSmobilerDemo.Operational;
using COMSSmobilerDemo.Reimbursement.CostCenter;
using COMSSmobilerDemo.Message;

namespace COMSSmobilerDemo
{
    partial class frmOtherMune : Smobiler.Core.MobileForm
    {
        internal string ToolBarName = "";
        private void IconMenuView1_MenuItemClick(object sender, MenuItemEventArgs e)
        {
            try
            {
                switch (e.Item.Value)
                {
                    case "frmWorkDMain":
                        frmWorkDMain frmWorkDMain = new frmWorkDMain();
                        Redirect(frmWorkDMain);
                        break;
                    case "frmLeaveGrid":
                        frmLeaveGrid frmLeaveGrid = new frmLeaveGrid();
                        Redirect(frmLeaveGrid);
                        break;
                    case "frmSignInMain":
                        frmSignInMain frmSignInMain = new frmSignInMain();
                        Redirect(frmSignInMain);
                        break;
                    case "frmOperationalRMain":
                        frmOperationalRMain frmOperationalRMain = new frmOperationalRMain();
                        Redirect(frmOperationalRMain);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 显示左侧栏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmOtherMune_TitleImageClick(object sender, EventArgs e)
        {
            ShowSlider(Slider.Left);
        }
        /// <summary>
        /// toolbar事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmOtherMune_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
        {
            try
            {

                switch (e.Name)
                {
                    case "Message":
                        frmMessage frmMessage = new frmMessage();
                        this.Redirect(frmMessage, (MobileForm form, object args) => { this.Close(); });
                        break;
                    case "RB":
                        frmRBMune frmRBMune = new frmRBMune();
                        this.Redirect(frmRBMune, (MobileForm form, object args) => { this.Close(); });
                        break;
                    case "tExit":
                        MessageBox.Show("是否确定退出系统？", MessageBoxButtons.YesNo, (Object s, MessageBoxHandlerArgs args) =>
                   {
                       if (args.Result == Smobiler.Core.ShowResult.Yes)
                       {
                           this.Close();
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
        /// 左侧栏点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmOtherMune_LeftLayoutItemClick(object sender, MobileFormLayoutItemEventArgs e)
        {

            switch (e.CellItem.Name)
            {
                case "imgbtnMain":
                case "btnMain":
                    this.CloseSlider();
                    break;
                case "imgbtnUserCC":
                case "btnUserCC":
                    frmAttentionCC frm = new frmAttentionCC();
                    frm.muneMode = 2;
                    this.Redirect(frm, (MobileForm form, object args) => this.Close());
                    break;
                case "btnUser":
                    frmUserDetail frmUserDetail = new frmUserDetail();
                    frmUserDetail.muneMode = 2;
                    this.Redirect(frmUserDetail, (MobileForm form, object args) =>
                    {
                        if (frmUserDetail.ShowResult == Smobiler.Core.ShowResult.Yes)
                        {
                            ((ImageButton)LeftLayoutData.Items["imgUser"].DefaultValue).Refresh();
                        }
                        this.Close();
                    });
                    break;
                case "btnHelp":
                    this.RedirectUrl("帮助", "http://www.searching-info.com/coms/ComsSmobiler.html");
                    break;
            }

         
        }
    }
}