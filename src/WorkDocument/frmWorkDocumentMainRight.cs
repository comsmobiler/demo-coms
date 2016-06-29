using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;

namespace COMSSmobilerDemo.WorkDocument
{
    partial class frmWorkDocumentMainRight : Smobiler.Core.MobileForm
    {

        #region "Properties"
        public int btnMode;
        private int totalQty = 0;
        private double totalDay = 0.0;
        internal string STATE;
        public string GetSTATE
        {
            get { return STATE; }
            set { STATE = value; }
        }
        #endregion


        private void frmWorkDocumentMainRight_Load(object sender, EventArgs e)
        {
            try
            {
                Bind();
                this.btnAllWorkD1.Text = "（6）";
                this.btntotalDay1.Text =  "30天";
                dynamic setColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(230)), Convert.ToInt32(Convert.ToByte(230)), Convert.ToInt32(Convert.ToByte(230))); 
                if (string.IsNullOrWhiteSpace(STATE) == true)
                {
                    btnAllWorkD.BackColor = setColor;
                    btnAllWorkD1.BackColor = setColor;
                    btntotalDay.BackColor = setColor;
                    btntotalDay1.BackColor = setColor;
                }
                else
                {
                    this.btnAllWorkD.BackColor = System.Drawing.Color.White;
                    this.btnAllWorkD1.BackColor = System.Drawing.Color.White;
                    this.btntotalDay.BackColor = System.Drawing.Color.White;
                    this.btntotalDay1.BackColor = System.Drawing.Color.White;
                    foreach (GridViewRow ROW in GridView1.Rows)
                    {
                        ROW.Cell.Items["ImageButton1"].DefaultValue = ROW.Cell.Items["ImageButton1"].Value;
                        if (ROW.Cell.Items["STATE"].Value == STATE)
                        {
                            ROW.Cell.Items["STATE"].BackColor = setColor;
                            ROW.Cell.Items["MENDAYV"].BackColor = setColor;
                            ROW.Cell.Items["ImageButton1"].BackColor = setColor;
                        }
                        else
                        {
                            ROW.Cell.Items["STATE"].BackColor = System.Drawing.Color.White;
                            ROW.Cell.Items["MENDAYV"].BackColor = System.Drawing.Color.White;
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
                DataTable table = new DataTable ();
               table.Columns.Add("STATENAME", typeof(System.String));
               table.Columns.Add("WDOC_STATE", typeof(System.String));
                table.Columns.Add("MENDAYVFIELD", typeof(System.String));
                table.Rows.Add("Created", "已创建(2)", "10天");
                table.Rows.Add("Posted", "已提交(2)", "10天");
                table.Rows.Add("Confirmed", "已审批(2)", "10天");
                this.GridView1.DataSource = table;
                this.GridView1.DataBind();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmWorkDocumentMainRight_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
        {
            switch (e.Name)
            {
                case "tExit":
                    this.Close();
                    break;
            }
        }

        private void GridView1_ItemClick(object sender, GridViewCellItemEventArgs e)
        {
            STATE = e.Cell.Items["STATE"].Value.ToString ();
            this.ShowResult = Smobiler.Core.ShowResult.Yes;
            this.Close();
        }

        private void btntotalDay_Click(object sender, EventArgs e)
        {
            STATE = "";
            this.ShowResult = Smobiler.Core.ShowResult.Yes;
            this.Close();
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