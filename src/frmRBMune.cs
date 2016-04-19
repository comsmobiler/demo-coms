using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using COMSSmobilerDemo.Reimbursement.RB;
using COMSSmobilerDemo.Reimbursement.CostCenter;
using COMSSmobilerDemo.Message;

namespace COMSSmobilerDemo
{
    partial class frmRBMune : Smobiler.Core.MobileForm
    {
        internal string ToolBarName = "";
        /// <summary>
        /// 显示左侧栏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRBMune_TitleImageClick(object sender, EventArgs e)
        {
            ShowSlider(Slider.Left);
        }

        /// <summary>
        /// 菜单项点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IconMenuView1_MenuItemClick(object sender, MenuItemEventArgs e)
        {
            try
            {
                switch (e.Item.Value)
                {
                    case "frmRBMain":
                        frmRBMain frmRBMain = new frmRBMain();
                        Redirect(frmRBMain);
                        break;
                    case "frmRBPostMain":
                        frmRBPostMain frmRBPostMain = new frmRBPostMain();
                        Redirect(frmRBPostMain);
                        break;
                    case "frmRBCheck2":
                        frmRBCheck2 frmRBCheck2 = new frmRBCheck2();
                        Redirect(frmRBCheck2);
                        break;
                    case "frmRBCheck3":
                        frmRBCheck3 frmRBCheck3 = new frmRBCheck3();
                        Redirect(frmRBCheck3);
                        break;
                    case "frmRBCheck4":
                        frmRBCheck4 frmRBCheck4 = new frmRBCheck4();
                        Redirect(frmRBCheck4);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// toolbar点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRBMune_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
        {
            try
            {

                switch (e.Name)
                {
                    case "Message":
                        frmMessage frmMessage = new frmMessage();
                        this.Redirect(frmMessage, (MobileForm form, object args) => { this.Close(); });
                        break;
                    case "Other":
                        frmOtherMune frmOtherMune = new frmOtherMune();
                        this.Redirect(frmOtherMune, (MobileForm form, object args) => { this.Close(); });
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

        private void frmRBMune_LeftLayoutItemClick(object sender, MobileFormLayoutItemEventArgs e)
        {

            try
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
                        frm.muneMode = 1;
                        this.Redirect(frm, (MobileForm form, object args) => this.Close());
                        break;
                    case "btnUser":
                        frmUserDetail frmUserDetail = new frmUserDetail();
                        frmUserDetail.muneMode = 1;
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}