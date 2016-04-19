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
                    this.txtworkday1.Visible = false;
                    this.txtworkday2.Visible = true;
                    this.lblCDNO.Visible = true;
                    this.txtCDNO.Visible = true;
                    this.lblworkday.Text = "工单其他人天";
                    this.txtCDNO.Top = 48;
                    this.txtworkday1.Text = "";
                    this.TxtNote.Top = this.txtCDNO.Top + this.txtCDNO.Height + 3;
                    this.lblNote.Top = this.TxtNote.Top;
                    break;
                case "002":
                    this.txtworkday1.Visible = true;
                    this.txtworkday2.Visible = false;
                    this.lblCDNO.Visible = false;
                    this.txtCDNO.Visible = false;
                    this.lblworkday.Text = "工单业务人天";
                    this.TxtNote.Top = 65 - this.txtCDNO.Height;
                    this.lblNote.Top = this.TxtNote.Top;
                    this.txtworkday2.Text = "";
                    this.txtCDNO.Text = "";
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
                    MessageBox.Show("工单修改成功！", (Object s, MessageBoxHandlerArgs args) =>
                    {
                        ShowResult = Smobiler.Core.ShowResult.Yes;
                    });
                }
                else if (e.Name.Equals(post.Name))
                {
                    MessageBox.Show("工单送审成功！", (Object s, MessageBoxHandlerArgs args) =>
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
    }
}