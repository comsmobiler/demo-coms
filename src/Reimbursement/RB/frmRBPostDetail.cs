using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using COMSSmobilerDemo.common;
using System.Data;

namespace COMSSmobilerDemo.Reimbursement.RB
{
    partial class frmRBPostDetail : Smobiler.Core.MobileForm
    {
        private void Bind()
        {
            try
            {
                this.lblRBNO.Text = "RB0001";
                this.lblRBCC.Text = "2015年项目预算";
                this.lblRBUser.Text = "Demo";
                int top = 85;
                int RB_STATE = 1;
                switch (RB_STATE)
                {
                    case -1:
                        string REASON = "报销不符合";
                        if (REASON.Length > 0)
                        {
                            txtRB_REASON.Text = "拒绝理由:" + REASON;
                        }
                        else
                        {
                            txtRB_REASON.Text = "拒绝理由:无";
                        }
                        txtRB_REASON.Visible = true;
                        lblRB_REASON1.Visible = true;
                       
                        GridView1.Top = 403;
                        break;
                    default:
                        txtRB_REASON.Visible = false;
                        lblRB_REASON1.Visible = false;
                        
                        GridView1.Top =295;
                        break;
                }
                switch (RB_STATE)
                {
                    case 0:
                        this.lblRBState.Text = "已创建(可编辑)";
                        break;
                    case 1:
                        this.lblRBState.Text = "已提交";
                        break;
                    case 2:
                        this.lblRBState.Text = "已审批(责任人已审核)";
                        break;
                    case 3:
                        this.lblRBState.Text = "已审批(行政已审核)";
                        break;
                    case 4:
                        this.lblRBState.Text = "已完成(财务已审核)";
                        break;
                    case -1:
                        this.lblRBState.Text = "已拒绝";
                        break;
                }
                this.lblnote.Text = "无";
                FooterBarLayoutData.Items["lblAmount"].DefaultValue = "￥250.00";
                //获取报销行项
                ConsumptionInfo Consumptioninfo = new ConsumptionInfo();
                DataTable rbrowtable = Consumptioninfo.GetConsumptioninfo();
                if (rbrowtable.Rows.Count > 0)
                {
                    rbrowtable.Columns.Add("ROW_NOTE", typeof(System.String));
                    rbrowtable.Columns.Add("ROW_DATE", typeof(System.String));
                    foreach (DataRow row in rbrowtable.Rows)
                    {
                        if (row["RBROW_NOTE"].ToString().Length > 0)
                        {
                            row["ROW_NOTE"] = row["RBROW_NOTE"];
                        }
                        
                        row["ROW_DATE"] = Convert.ToDateTime(row["RBROW_DATE"]).ToShortDateString();
                    }
                    this.GridView1.DataSource = rbrowtable;
                    this.GridView1.DataBind();
                }
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
        private void frmRBPostDetail_Load(object sender, EventArgs e)
        {
            Bind();
        }
        /// <summary>
        /// Toolbar事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRBPostDetail_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
        {
            try
            {  
                //送审
                if (e.Name.Equals(Post.Name))
                {

                    MessageBox.Show("报销送审成功！","送审", (Object s, MessageBoxHandlerArgs args) =>
                    {
                        this.Close();
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// TitleImage事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MobileForm_TitleImageClick(object sender, EventArgs e)
        {
            HandleToast();
        }
        /// <summary>
        /// 手机自带回退按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MobileForm_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
            {
                HandleToast();
            }
        }

        private void HandleToast()
        {
            this.Close();
        } 
    }
}