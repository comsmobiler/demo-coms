using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace COMSSmobilerDemo.WorkDocument
{
    partial class frmWorkDocumentDetail1 : Smobiler.Core.MobileForm
    {
        private void frmWorkDocumentDetail1_Load(object sender, EventArgs e)
        {
            Bind();
        }
        private void Bind()
        {
            lbllNO.Text = "WD001";
            lbltype.Text = "日结单";
            lblCC.Text = "2015年项目预算";
            lblworkday.Text = "2.00";
            lblNote.Text = "测试";
            lblMenDay.Text = "人天值2.00天";
            lblState.Text = "已提交";
        }

        private void frmWorkDocumentDetail1_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
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
                else if (e.Name.Equals(save.Name))
                {
                    MessageBox.Show("工单审批成功！", (Object s, MessageBoxHandlerArgs args) =>
                    {
                        ShowResult = Smobiler.Core.ShowResult.Yes;
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