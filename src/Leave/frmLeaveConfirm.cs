using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace COMSSmobilerDemo.Leave
{
    partial class frmLeaveConfirm : Smobiler.Core.MobileForm
    {

        #region "Properties"
        private bool isSaving = false;
        internal string L_NO;
        public string GetL_NO
        {
            get { return L_NO; }
            set { L_NO = value; }
        }
        #endregion
        //通过审批
        private void CheckBox2_CheckChanged(object sender, CheckEventArgs e)
        {
            try
            {
                if (CheckBox2.Checked)
                {
                    CheckBox1.Checked = false;
                    txtL_REASON.Visible = true;
                    
                }
                else
                {
                    CheckBox1.Checked = true;
                    txtL_REASON.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //拒绝审批
        private void CheckBox3_CheckChanged(object sender, CheckEventArgs e)
        {
            try
            {
                if (CheckBox1.Checked)
                {
                    CheckBox2.Checked = false;
                    txtL_REASON.Visible = false;
                    

                }
                else
                {
                    CheckBox2.Checked = true;
                    txtL_REASON.Visible = true;
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmLeaveConfirm_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
        {
            try
            {

                if (e.Name.Equals(Confirm.Name))
                {
                    if (CheckBox1.Checked.Equals(true))
                    {
                        MessageBox.Show("审批成功！", (Object s, MessageBoxHandlerArgs args) =>
                        {
                            ShowResult = Smobiler.Core.ShowResult.Yes;
                        });
                    }
                    if (CheckBox2.Checked.Equals(true))
                    {
                        MessageBox.Show("拒绝！", (Object s, MessageBoxHandlerArgs args) =>
                        {
                            ShowResult = Smobiler.Core.ShowResult.Yes;
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