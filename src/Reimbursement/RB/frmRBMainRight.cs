
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
using Smobiler.Core.Controls;
namespace COMSSmobilerDemo.Reimbursement.RB
{
    public partial class frmRBMainRight : Smobiler.Core.MobileForm
    {

        #region "Properties"
        private int totalQty = 0;
        private decimal totalAmount = 0;
        internal string STATE;
        public string GetSTATE
        {
            get { return STATE; }
            set { STATE = value; }
        }
        #endregion

        /// <summary>
        /// 初始化窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void frmRBMainRightLayout_Load(object sender, EventArgs e)
        {
            try
            {
                Bind();
                this.btnALLRB1.Text = "（" + totalQty.ToString() + "）";
                this.btntotalAmount1.Text = "￥" + totalAmount.ToString();
                dynamic setColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(230)), Convert.ToInt32(Convert.ToByte(230)), Convert.ToInt32(Convert.ToByte(230))); 
                if (string.IsNullOrWhiteSpace(STATE) == true)
                {
                    btnALLRB.BackColor = setColor;
                    btnALLRB1.BackColor = setColor;
                    btntotalAmount.BackColor = setColor;
                    btntotalAmount1.BackColor = setColor;
                }
                else
                {
                    
                    btnALLRB.BackColor = System.Drawing.Color.White;
                    btnALLRB1.BackColor = System.Drawing.Color.White;
                    btntotalAmount.BackColor = System.Drawing.Color.White;
                    btntotalAmount1.BackColor = System.Drawing.Color.White;
                    foreach (GridViewRow ROW in GridView1.Rows)
                    {
                        ROW.Cell.Items["ImageButton1"].DefaultValue = ROW.Cell.Items["ImageButton1"].Value;
                        if (ROW.Cell.Items["STATE"].Value== STATE)
                        {
                            ROW.Cell.Items["STATE"].BackColor = setColor;
                            ROW.Cell.Items["AMOUNT"].BackColor = setColor;
                            ROW.Cell.Items["ImageButton1"].BackColor = setColor;
                        }
                        else
                        {
                            ROW.Cell.Items["STATE"].BackColor = System.Drawing.Color.White;
                            ROW.Cell.Items["AMOUNT"].BackColor = System.Drawing.Color.White;
                            ROW.Cell.Items["ImageButton1"].BackColor = System.Drawing.Color.White;
                        }
                    }
                }

              
               
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
                DataTable table = new DataTable();
                table.Columns.Add("RB_STATE", typeof(System.Int32));
                table.Columns.Add("STATENAME", typeof(System.String));
                table.Columns.Add("AMOUNT", typeof(System.Decimal));
                table.Columns.Add("COUNT", typeof(System.String));
                table.Columns.Add("STATENAME1", typeof(System.String));
                table.Columns.Add("AMOUNTFIELD", typeof(System.String));
                table.Columns.Add("STATENAMECOUNT", typeof(System.String));
                table.Rows.Add(0, "Created", 250.00, 1, "已创建(可编辑)");
                table.Rows.Add(1, "Posted", 400.00, 1, "已提交");
                table.Rows.Add(2, "Confirmed", 300.00, 1, "责任人已审核");
                table.Rows.Add(3, "Checked", 1000.00, 1, "行政已审核");
                table.Rows.Add(4, "Accounted", 600.00, 1, "财务已审核");
                table.Rows.Add(-1, "Refused", 100.00, 1, "已拒绝");

                DataTable matTable = new DataTable();
                matTable.Columns.Add("XMember", typeof(string));
                matTable.Columns.Add("YMember", typeof(int));
                foreach (DataRow row in table.Rows)
                {
                    row["STATENAMECOUNT"] = row["STATENAME1"].ToString() + "（" + row["COUNT"].ToString() + "）";
                    totalQty += Convert.ToInt32(row["COUNT"]);
                    totalAmount += Convert.ToDecimal(row["AMOUNT"]);
                    row["AMOUNTFIELD"] = "￥" + row["AMOUNT"].ToString();
                    string XMember = row["STATENAME1"].ToString();
                    decimal YMember = (decimal)(row["AMOUNT"]);
                    matTable.Rows.Add(XMember, YMember);
                }

                this.GridView1.Rows.Clear();
                this.GridView1.DataSource = table;
                this.GridView1.DataBind();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void GridView1_ItemClick(object sender, GridViewCellItemEventArgs e)
        {
            try
            {
                this.ShowResult = Smobiler.Core.ShowResult.Yes;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnALLRB_Click(object sender, EventArgs e)
        {
            try
            {
                STATE = "";
                this.ShowResult = Smobiler.Core.ShowResult.Yes;
                this.Close();
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

