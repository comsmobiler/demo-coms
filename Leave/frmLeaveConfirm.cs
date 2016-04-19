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
                    CheckBox3.Checked = false;
                    txtL_REASON.Visible = true;
                    lblREASON.Visible = true;
                }
                else
                {
                    CheckBox3.Checked = true;
                    txtL_REASON.Visible = false;
                    lblREASON.Visible = false;
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
                if (CheckBox3.Checked)
                {
                    CheckBox2.Checked = false;
                    txtL_REASON.Visible = false;
                    lblREASON.Visible = false;

                }
                else
                {
                    CheckBox2.Checked = true;
                    txtL_REASON.Visible = true;
                    lblREASON.Visible = true;
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

                if (e.Name.Equals(tExit.Name))
                {
                    MessageBox.Show("是否确定返回？", MessageBoxButtons.YesNo, (Object s, MessageBoxHandlerArgs args) =>
                    {
                        if (args.Result == Smobiler.Core.ShowResult.Yes)
                        {
                            this.Close();
                        }
                    }
                    );

                }
                if (e.Name.Equals(Confirm.Name))
                {
                    if(CheckBox3.Checked.Equals (true))
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
    }
}