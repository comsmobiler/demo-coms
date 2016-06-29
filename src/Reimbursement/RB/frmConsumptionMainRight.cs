using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
using Smobiler.Core.Controls;
using COMSSmobilerDemo.common;
namespace COMSSmobilerDemo.Reimbursement.RB
{
    public partial class frmConsumptionMainRight : Smobiler.Core.MobileForm
    {

        #region "Properties"
        private int totalQty = 0;
        private Decimal totalAmount = 0;
        internal string ROWTYPE;
        public string GetROWTYPE
        {
            get { return ROWTYPE; }
            set { ROWTYPE = value; }
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
                this.btnALLtype1.Text = "（" + totalQty.ToString() + "）";
                this.btntotalAmount1.Text = "￥" + totalAmount.ToString();
                dynamic setColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(230)), Convert.ToInt32(Convert.ToByte(230)), Convert.ToInt32(Convert.ToByte(230))); 
                if (string.IsNullOrWhiteSpace(ROWTYPE) == true)
                {
                    btnALLtype.BackColor = setColor;
                btnALLtype1.BackColor = setColor;
                btntotalAmount.BackColor = setColor;
                btntotalAmount1.BackColor = setColor;
                }
                else
                {
                     btnALLtype.BackColor = System.Drawing.Color.White;
                btnALLtype1.BackColor = System.Drawing.Color.White;
                btntotalAmount.BackColor = System.Drawing.Color.White;
                btntotalAmount1.BackColor = System.Drawing.Color.White;
                    foreach (GridViewRow ROW in GridView1.Rows)
                    {
                        ROW.Cell.Items["ImageButton1"].DefaultValue = ROW.Cell.Items["ImageButton1"].Value;
                        string type = ROW.Cell.Items["RBROW_TYPE"].Value.ToString();
                        if (type.ToString() == ROWTYPE)
                        {
                            ROW.Cell.Items["RBROW_TYPE"].BackColor = setColor;
                            ROW.Cell.Items["AMOUNT"].BackColor = setColor;
                            ROW.Cell.Items["ImageButton1"].BackColor = setColor;
                        }
                        else
                        {
                            ROW.Cell.Items["RBROW_TYPE"].BackColor = System.Drawing.Color.White;
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
                TypeInfo typeinfo = new TypeInfo();
                DataTable table = typeinfo.Gettypeofinfo1();
                if (table.Rows.Count > 0)
                {
                    table.Columns.Add("TYPENAMECOUNT", typeof(System.String));
                    table.Columns.Add("AMOUNTFIELD", typeof(System.String));
                    foreach (DataRow row in table.Rows)
                    {
                        row["TYPENAMECOUNT"] = row["TYPENAME"] + "（" + row["TYPECOUNT"] + "）";
                        row["AMOUNTFIELD"] = "￥" + row["AMOUNT"];
                    }
                    this.GridView1.Rows.Clear();
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
        /// GridView1点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="cell"></param>
        /// <param name="cellItem"></param>
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
        /// <summary>
        /// 所有消费类型按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnALLtype_Click(object sender, EventArgs e)
        {
            try
            {
                ROWTYPE = "";
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
