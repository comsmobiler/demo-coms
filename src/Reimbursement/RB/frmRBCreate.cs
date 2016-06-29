
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
using Smobiler.Core.Controls;
using COMSSmobilerDemo.common;
using COMSSmobilerDemo.Reimbursement.CostCenter;
namespace COMSSmobilerDemo.Reimbursement.RB
{
    public partial class frmRBCreate : Smobiler.Core.MobileForm
    {

        internal string RB_NO;
        public string GetRB_NO
        {
            get { return RB_NO; }
            set { RB_NO = value; }
        }
        private string RBCC;

        /// <summary>
        /// 成本中心选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void btnChioce_Click(object sender, EventArgs e)
        {
            try
            {
                frmCostCenter frmCostCenter = new frmCostCenter();
                this.Redirect(frmCostCenter, (MobileForm sender1, object args) =>
                {
                    try
                    {
                        if (frmCostCenter.ShowResult == Smobiler.Core.ShowResult.Yes)
                        {
                            string CC_ID = frmCostCenter.CC_ID;
                            string[] CCS = CC_ID.Split(new char[] { '/' });
                            RBCC = CCS[0];
                            this.btnRBCC.Text = CCS[1];
                            setbtnColor();
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
        /// 窗体初始化加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRBCreate_Load(object sender, EventArgs e)
        {
            try
            {
                Bind();
                setbtnColor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 动态更改控件字体颜色
        /// </summary>
        /// <remarks></remarks>
        private void setbtnColor()
        {
            if (string.IsNullOrWhiteSpace(RBCC) == false)
            {
                btnRBCC.ForeColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(102)), Convert.ToInt32(Convert.ToByte(99)), Convert.ToInt32(Convert.ToByte(99)));
            }
            else
            {
                btnRBCC.ForeColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(193)), Convert.ToInt32(Convert.ToByte(193)), Convert.ToInt32(Convert.ToByte(193)));
            }
        }
        /// <summary>
        /// Bind方法
        /// </summary>
        private void Bind()
        {
            try
            {
                ConsumptionInfo Consumptioninfo = new ConsumptionInfo();
                DataTable table = Consumptioninfo.GetConsumptioninfo();
                if (table.Rows.Count > 0)
                {
                    this.GridView1.Rows.Clear();
                    table.Columns.Add("RBCHECKED", typeof(System.Boolean));
                    table.Columns.Add("ROW_NOTE", typeof(System.String));
                    table.Columns.Add("ROW_DATE", typeof(System.String));
                    foreach (DataRow row in table.Rows)
                    {

                        if (row["RB_NO"].ToString().Length <= 0)
                        {
                            row["RBCHECKED"] = false;
                        }
                        else
                        {
                            row["RBCHECKED"] = true;
                        }

                        if (row["RBROW_NOTE"].ToString().Length > 0)
                        {
                            row["ROW_NOTE"] = row["RBROW_NOTE"];
                        }
                        else
                        {
                            row["ROW_NOTE"] = "无";
                        }
                        row["ROW_DATE"] = Convert.ToDateTime(row["RBROW_DATE"]).ToShortDateString();
                    }
                    this.GridView1.DataSource = table;
                    this.GridView1.DataBind();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        /// <summary>
        /// Toolbar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRBCreate_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
        {
            try
            {   
                //保存
                if (e.Name.Equals(save.Name))
                {

                    MessageBox.Show("报销已创建！", (Object s, MessageBoxHandlerArgs args) =>
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
        /// GridView1事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="cell"></param>
        /// <param name="cellItem"></param>
        private void GridView1_ItemClick(object sender, GridViewCellItemEventArgs e)
        {
            try
            {
                switch (e.CellItem.Name)
                {
                    case "Check":
                        getAmount();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        ///计算报销单报销总金额
        /// </summary>
        /// <remarks></remarks>
        public void getAmount()
        {
            try
            {
                decimal sumAmount = 0;
                foreach (GridViewRow ROW in GridView1.Rows)
                {
                    //判断消费记录是否选中，计算选中的消费记录总金额
                    if (Convert.ToBoolean(ROW.Cell.Items["Check"].DefaultValue) == true)
                    {
                        if (ROW.Cell.Items["lblMoney"].Value.ToString().Length > 0)
                        {
                            sumAmount += Convert.ToDecimal(ROW.Cell.Items["lblMoney"].Value);
                        }
                    }
                }
                FooterBarLayoutData.Items["lblAmount"].DefaultValue = "￥" + sumAmount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 全选
        /// </summary>
        private void getcheckall()
        {
            switch ((bool )FooterBarLayoutData.Items["Checkall"].DefaultValue)
            {
                case true:
                    FooterBarLayoutData.Items["lblCheckall"].DefaultValue = "全不选";
                    foreach (GridViewRow rows in GridView1.Rows)
                    {
                        rows.Cell.Items["Check"].DefaultValue = true;
                    }

                    break;
                case false:
                    FooterBarLayoutData.Items["lblCheckall"].DefaultValue = "全选";
                    foreach (GridViewRow rows in GridView1.Rows)
                    {
                        rows.Cell.Items["Check"].DefaultValue  = false;
                    }

                    break;
            }
            getAmount();
        }


        /// <summary>
        /// FooterBar点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRBCreate_FooterBarLayoutItemClick(object sender, MobileFormLayoutItemEventArgs e)
        {
            getcheckall();
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

