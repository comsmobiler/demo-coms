using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using COMSSmobilerDemo.Reimbursement.CostCenter;
using COMSSmobilerDemo.common;
using System.Data;

namespace COMSSmobilerDemo.WorkDocument
{
    partial class frmWorkDocumentEdit : Smobiler.Core.MobileForm
    {
         #region "Properties"
        private string Type;
        private string CC;
        #endregion
        private bool isSaving = false;

        /// <summary>
        /// 类型选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btntype_Click(object sender, EventArgs e)
        {
            PopList1.Groups.Clear();
            WorkDInfo frmWorkDocument = new WorkDInfo();
            DataTable table = frmWorkDocument.GetWorkDType();

            PopListGroup poli = new PopListGroup();
            PopList1.Groups.Add(poli);

            poli.Text = "类型";
            //显示样式
            foreach (DataRow rowli in table.Rows)
            {
                poli.Items.Add(rowli["WDOCTYPE_NAME"].ToString (), rowli["WDOC_TYPE"].ToString ());

                if (Type.Equals ( rowli["WDOC_TYPE"]))
                {
                    
                    PopListItem popitem = new PopListItem();
                    popitem.Value = rowli["WDOC_TYPE"].ToString ();
                    PopList1.SetSelections(poli.Items[(poli.Items.Count - 1)]);
                }

            }
            PopList1.ShowDialog();
        }

        private void frmWorkDocumentEdit_Load(object sender, EventArgs e)
        {
           
            //设置默认类型
            WorkDInfo WorkDInfo = new WorkDInfo();
            DataTable table = WorkDInfo.GetWorkDType();
            if (table.Rows.Count > 0)
            {
                Type = table.Rows[0]["WDOC_TYPE"].ToString ();
                this.btntype.Text = table.Rows[0]["WDOCTYPE_NAME"].ToString ();
            }
            txtworkday1 .Text ="2";
            lblMenDay .Text="1";
            lblState .Text ="已创建";
            getStyle();
        }


        /// <summary>
        /// 根据类型设置样式
        /// </summary>
        /// <remarks></remarks>
        private void getStyle()
        {
            switch (Type)
            {
                case "001":
                    this.txtworkday.Visible = false;
                    this.txtworkday1.Visible = true;
                    this.lblCDNO.Visible = true;
                    this.txtCDNO.Visible = true;
                    this.lblworkday.Text = "工单其他人天";
                    this.txtCDNO.Top = 120;
                    this.txtworkday.Text = "";
                    this.TxtNote.Top = this.txtCDNO.Top + this.txtCDNO.Height + 8;
                    this.lblNote.Top = this.TxtNote.Top;
                    this.lblMenDay.Top = this.TxtNote.Top + this.TxtNote.Height + 8;
                    this.lblState.Top = this.lblMenDay.Top + this.lblMenDay.Height;
                    this.lblMenDay1.Top = this.lblMenDay.Top;
                    this.lblState1.Top = this.lblState.Top;
                    txtworkday.Text = "";
                    break;
                case "002":
                    this.txtworkday.Visible = true;
                    this.txtworkday1.Visible = false;
                    this.lblCDNO.Visible = false;
                    this.txtCDNO.Visible = false;
                    this.lblworkday.Text = "工单业务人天";
                    this.TxtNote.Top = 162 - this.txtCDNO.Height;
                    this.lblNote.Top = this.TxtNote.Top;
                    this.txtworkday1.Text = "";
                    this.txtCDNO.Text = "";
                    this.lblMenDay.Top = this.TxtNote.Top + this.TxtNote.Height + 8;
                    this.lblState.Top = this.lblMenDay.Top + this.lblMenDay.Height;
                    this.lblMenDay1.Top = this.lblMenDay.Top;
                    this.lblState1.Top = this.lblState.Top;
                    txtworkday1.Text = "";
                    break;
            }
        }

        /// <summary>
        ///成本中心选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChoice_Click(object sender, EventArgs e)
        {
            try
            {
                frmCostCenter frmCostCenter = new frmCostCenter();
                this.Redirect(frmCostCenter, (MobileForm from,object s) =>
                {
                    try
                    {
                        if (frmCostCenter.ShowResult == Smobiler.Core.ShowResult.Yes)
                        {
                            string CC_ID = frmCostCenter.CC_ID;
                            string[] CCS = CC_ID.Split(new char[] { '/' });
                            CC = CCS[0];
                            this.btnCC.Text = CCS[1];
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
        /// 类型赋值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PopList1_Selected(object sender, EventArgs e)
        {
            try
            {
                if (PopList1.Selection != null)
                {
                    this.btntype.Text = PopList1.Selection.Text.Trim();
                    Type = PopList1.Selection.Value;
                    getStyle();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// toolbar事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmWorkDocumentEdit_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
        {
            try
            {
                if (e.Name.Equals(save.Name))
                {
                    MessageBox.Show("工单修改成功！", (Object s, MessageBoxHandlerArgs args) =>
                    {
                        ShowResult = Smobiler.Core.ShowResult.Yes;
                    });
                }
                else if (e.Name.Equals(post.Name))
                {
                    MessageBox.Show("工单送审成功！", "送审", (Object s, MessageBoxHandlerArgs args) =>
                    {
                        Close();
                    });
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