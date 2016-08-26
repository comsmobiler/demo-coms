using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace COMSSmobilerDemo.RecipientsItems
{
    partial class frmRICreate : Smobiler.Core.MobileForm
    {

        private void imgbtnSignature_Click(object sender, EventArgs e)
        {
            Signature1.GetSignature();
        }

        private void Signature1_SignatureCompleted(object sender, BinaryData e)
        {
            if (string.IsNullOrEmpty(e.ErrorInfo))
            {
                string itemSname = "ItemS" + e.ResourceID;
                e.SaveFile(itemSname);
                imgbtnSignature.ResourceID = itemSname;
            }

        }

        private DateTime taosttime;
        private void MobileForm_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
            {
                HandleToast();
            }
        }
        private void HandleToast()
        {
            if ( taosttime.AddSeconds(3) >= DateTime.Now)
            {
                this.Close();
            }
            else
            {
                taosttime = DateTime.Now;
                this.Toast("再按一次退出界面", ToastLength.SHORT);
            }
        }

        private void frmRICreate_TitleImageClick(object sender, EventArgs e)
        {
            HandleToast();
        }

        private void frmRICreate_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
        {
            try
            {
                switch (e.Name)
                {
                    case "save"  :
                        if (txtITEM_NAME.Text.Trim().Length <= 0)
                        {
                            throw new Exception("请输入物品名称！");
                        }
                        if (txtITEM_QTY.Text.Trim().Length <= 0)
                        {
                            throw new Exception("请输入数量!");
                        }
                        if (txtITEM_USER.Text.Trim().Length <= 0)
                        {
                            throw new Exception("请输入领用人!");
                        }
                
                        if (imgbtnSignature.ResourceID.Trim().Length <= 0)
                        {
                            throw new Exception("请签名!");
                        }


                        MessageBox.Show("物品领用记录已创建成功！", (Object s, MessageBoxHandlerArgs args) =>
                        {
                            ShowResult = Smobiler.Core.ShowResult.Yes;
                            this.Close();
                        });

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