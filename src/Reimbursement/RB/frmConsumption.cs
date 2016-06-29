
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
namespace COMSSmobilerDemo.Reimbursement.RB
{
    public partial class frmConsumption : Smobiler.Core.MobileForm
    {

        #region "Properties"
        internal string COSPID;
        public string GetCOSPID
        {
            get { return COSPID; }
            set { COSPID = value; }
        }
        private string TYPEID;
        #endregion

        /// <summary>
        /// 消费类型选择按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void btnRBType_Click(object sender, EventArgs e)
        {
            try
            {
                frmRBRowType frm = new frmRBRowType();
                this.Redirect(frm, (MobileForm sender1, object args) =>
                {
                    try
                    {
                        if (frm.ShowResult == Smobiler.Core.ShowResult.Yes)
                        {
                            string TYPEIDs = frm.TYPEID;
                            if (TYPEIDs.Length > 0)
                            {
                                string[] types = TYPEIDs.Split(new char[] { '/' });
                                TYPEID = types[0];
                                this.btnRBType.Text = types[1];
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                });
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
        /// <remarks></remarks>
        private void frmConsumption_Load(object sender, EventArgs e)
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
                if (string.IsNullOrWhiteSpace(COSPID) == false)
                {
                    this.TitleText = "消费记录编辑";
                    this.btnRBType.Text = "餐费";
                    this.txtMoney.Text = "50.0";
                    this.txtNote.Text = "中餐+晚餐";
                }
                else
                {
                    this.TitleText  = "消费记录创建";
                    this.btnRBType.Text = "选择类型";
                    this.delete.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// toolbar按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmConsumption_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
        {
            try
            {
                if (e.Name.Equals(save.Name))
                {
                    if (string.IsNullOrWhiteSpace(COSPID) == false)
                    {
                        MessageBox.Show("消费记录修改保存成功!");
                    }
                    else
                    {

                        MessageBox.Show("消费记录创建保存成功!", (Object s, MessageBoxHandlerArgs args) =>
                            {
                                this.Close();
                            });

                    }
                }
                if (e.Name.Equals(delete.Name))
                {
                    if (string.IsNullOrWhiteSpace(COSPID) == false)
                    {
                        MessageBox.Show("消费记录删除成功!","删除", (Object s, MessageBoxHandlerArgs args) =>
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