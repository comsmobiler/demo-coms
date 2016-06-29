using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;
using COMSSmobilerDemo.common;

namespace COMSSmobilerDemo.Leave
{
    partial class frmLeaveType : Smobiler.Core.MobileForm
    {
        internal string TYPEID;

        /// <summary>
        /// 初始化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void frmRBRowType_Load(object sender, EventArgs e)
        {
            try
            {
                LeaveInfo Leave = new LeaveInfo();
                DataTable typetable = Leave.GetLeaveType();
                if (typetable.Rows.Count > 0)
                {
                    this.GridView1.DataSource = typetable;
                    this.GridView1.DataBind();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
        private void GridView1_CellClick(object sender, GridViewCellEventArgs e)
        {
            try
            {
                TYPEID = e.Cell.Items["lblTypeName"].Value + "/" + e.Cell.Items["lblTypeName"].Text;
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