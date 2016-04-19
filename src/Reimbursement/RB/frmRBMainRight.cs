
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
                this.btnALLRB.Text = "所有报销单（" + totalQty.ToString() + "）";
                this.btntotalAmount.Text = "￥" + totalAmount.ToString();
                if (string.IsNullOrWhiteSpace(STATE) == true)
                {
                    this.btnALLRB.BackColor = System.Drawing.Color.Gainsboro;
                    this.btnALLRB.ForeColor = System.Drawing.Color.Gray;
                    this.btntotalAmount.BackColor = System.Drawing.Color.Gainsboro;
                }
                else
                {
                    this.btnALLRB.BackColor = System.Drawing.Color.White;
                    this.btnALLRB.ForeColor = System.Drawing.Color.Silver;
                    this.btntotalAmount.BackColor = System.Drawing.Color.White;
                    foreach (GridViewRow ROW in GridView1.Rows)
                    {
                        ROW.Cell.Items["ImageButton1"].DefaultValue = ROW.Cell.Items["ImageButton1"].Value;
                        if (ROW.Cell.Items["STATE"].Value == STATE)
                        {
                            ROW.Cell.Items["STATE"].BackColor = System.Drawing.Color.Gainsboro;
                            ROW.Cell.Items["STATE"].ForeColor = System.Drawing.Color.Gray;
                            ROW.Cell.Items["AMOUNT"].BackColor = System.Drawing.Color.Gainsboro;
                            ROW.Cell.Items["ImageButton1"].BackColor = System.Drawing.Color.Gainsboro;
                        }
                        else
                        {
                            ROW.Cell.Items["STATE"].BackColor = System.Drawing.Color.White;
                            ROW.Cell.Items["STATE"].ForeColor = System.Drawing.Color.Silver;
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
                List<int> listRBState = new List<int>();
                listRBState.Add(0);
                listRBState.Add(1);
                listRBState.Add(2);
                listRBState.Add(3);
                listRBState.Add(4);
                listRBState.Add(-1);
                table.Columns.Add("RB_STATE", typeof(System.Int32));
                table.Columns.Add("STATENAME", typeof(System.String));
                table.Columns.Add("AMOUNT", typeof(System.Decimal));
                table.Columns.Add("STATENAMECOUNT", typeof(System.String));
                table.Columns.Add("AMOUNTFIELD", typeof(System.String));
                if (listRBState.Count > 0)
                {
                    foreach (int RBState in listRBState)
                    {
                        table.Rows.Add(RBState, "", 0, 0, "");
                    }
                }
                string STATENAME = "";
                string STATENAME1 = "";

                foreach (DataRow row in table.Rows)
                {
                    if (row["RB_STATE"].Equals(0))
                    {
                        STATENAME = "已创建(可编辑)";
                        STATENAME1 = "Created";
                    }
                    else if (row["RB_STATE"].Equals(1))
                    {
                        STATENAME = "已提交";
                        STATENAME1 = "Posted";
                    }
                    else if (row["RB_STATE"].Equals(2))
                    {
                        STATENAME = "已审批(责任人已审核)";
                        STATENAME1 = "Confirmed";
                    }
                    else if (row["RB_STATE"].Equals(3))
                    {
                        STATENAME = "已审批(行政已审核)";
                        STATENAME1 = "Checked";
                    }
                    else if (row["RB_STATE"].Equals(4))
                    {
                        STATENAME = "已完成(财务已审核)";
                        STATENAME1 = "Accounted";
                    }
                    else if (row["RB_STATE"].Equals(-1))
                    {
                        STATENAME = "已拒绝";
                        STATENAME1 = "Refused";
                    }

                    row["STATENAME"] = STATENAME1;
                    row["STATENAMECOUNT"] = STATENAME + "（0）";
                    totalAmount = 0;
                    row["AMOUNTFIELD"] = "￥" + row["AMOUNT"].ToString();
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

        /// <summary>
        /// toolbar按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void frmRBMainRightLayout_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
        {
            try
            {
                if (e.Name.Equals(tExit.Name))
                {
                    this.Close();
                }
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
    }
}

