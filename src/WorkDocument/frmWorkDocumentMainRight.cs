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
                this.btnAllWorkD.Text = "所有工作单（6）";
                this.btntotalDay.Text =  "30天";
                if (string.IsNullOrWhiteSpace(STATE) == true)
                {
                    this.btnAllWorkD.BackColor = System.Drawing.Color.Gainsboro;
                    this.btnAllWorkD.ForeColor = System.Drawing.Color.Gray;
                    this.btntotalDay.BackColor = System.Drawing.Color.Gainsboro;
                }
                else
                {
                    this.btnAllWorkD.BackColor = System.Drawing.Color.White;
                    this.btnAllWorkD.ForeColor = System.Drawing.Color.Silver;
                    this.btntotalDay.BackColor = System.Drawing.Color.White;

                    foreach (GridViewRow ROW in GridView1.Rows)
                    {
                        ROW.Cell.Items["ImageButton1"].DefaultValue = ROW.Cell.Items["ImageButton1"].Value;
                        if (ROW.Cell.Items["STATE"].Value == STATE)
                        {
                            ROW.Cell.Items["STATE"].BackColor = System.Drawing.Color.Gainsboro;
                            ROW.Cell.Items["STATE"].ForeColor = System.Drawing.Color.Gray;
                            ROW.Cell.Items["MENDAYV"].BackColor = System.Drawing.Color.Gainsboro;
                            ROW.Cell.Items["ImageButton1"].BackColor = System.Drawing.Color.Gainsboro;
                        }
                        else
                        {
                            ROW.Cell.Items["STATE"].BackColor = System.Drawing.Color.White;
                            ROW.Cell.Items["STATE"].ForeColor = System.Drawing.Color.Silver;
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

    }
}