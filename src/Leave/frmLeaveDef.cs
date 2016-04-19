using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace COMSSmobilerDemo.Leave
{
    partial class frmLeaveDef : Smobiler.Core.MobileForm
    {
        private void frmLeaveDef_Load(object sender, EventArgs e)
        {
            Bind();
        }
        private void Bind()
        {
            lbllNO.Text = "L001";
            lbllType.Text = "事假";
            lblbDate.Text = DateTime.Now.ToShortDateString();
            lbleDate.Text = DateTime.Now.ToShortDateString();
            lbllDay.Text = "1.00";
            lbllReason.Text = "家里有事";
            lblCUser.Text = "A";
            lblCreateDate.Text = DateTime.Now.ToShortDateString();
            lblState.Text = "已送审";
        }

        /// <summary>
        /// toolbar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmLeaveDef_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
        {
            if (e.Name.Equals(tExit.Name))
            {
                this.Close();
            }
        }
    }
}