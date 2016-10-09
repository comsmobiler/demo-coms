using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace COMSSmobilerDemo.FixedAssets.Books
{
    partial class frmBookLogDetail : Smobiler.Core.MobileForm
    {

        internal string bLogID;
        internal string Authority;
        private void frmBookLogDetail_TitleImageClick(object sender, EventArgs e)
        {
            Close();
        }

        private void frmBookLogDetail_KeyDown(object sender, KeyDownEventArgs e)
        {
            Close();
        }

        private void frmBookLogDetail_Load(object sender, EventArgs e)
        {
            Bind();
        }

        /// <summary>
        /// 初始化方法
        /// </summary>
        /// <remarks></remarks>
        private void Bind()
        {
            try
            {

                    lblBOOKLOGID.Text = "BL001";
                    lblBOOKSNID.Text = "SN001";
                    lblBOOKNAME.Text = "ASP.NET基础";
                    lblBORROWER.Text = "Demo";
                    lblENDDATE.Text =DateTime .Now .ToString ();
                    lblRETURNDATE.Text = "";
                    lblLOSEDATE.Text = "";
                    lblSTATUS.Text = "借出";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 归还或遗失
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void frmBookLogDetail_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
        {
            try
            {
                switch (e.Name)
                {
                    case "Grade":
                        if (RatingBar1.Value > 0)
                        {
                            Toast("评分成功！", ToastLength.SHORT);
                        }
                        else
                        {
                            throw new Exception("您还没有对本书进行评分！");
                        }
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