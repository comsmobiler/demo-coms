
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
namespace COMSSmobilerDemo.Reimbursement.RB
{
    public partial class frmConsumptionMainRight : Smobiler.Core.MobileForm
    {

        #region "SmobilerForm Designer generated code "

        public frmConsumptionMainRight()
            : base()
        {

            //This call is required by the SmobilerForm Designer.
            InitializeComponent();

            //Add any initialization after the InitializeComponent() call

        }

        //VTForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm Designer
        //It can be modified using the SmobilerForm Designer.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.btnALLtype = new Smobiler.Core.Controls.Button();
            this.btntotalAmount = new Smobiler.Core.Controls.Button();
            this.GridView1 = new Smobiler.Core.Controls.GridView();
            this.tExit = new Smobiler.Core.Controls.ToolbarItem();
            // 
            // btnALLtype
            // 
            this.btnALLtype.BackColor = System.Drawing.Color.Gainsboro;
            this.btnALLtype.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.btnALLtype.BorderColor = System.Drawing.Color.Silver;
            this.btnALLtype.FontSize = 7F;
            this.btnALLtype.ForeColor = System.Drawing.Color.Gray;
            this.btnALLtype.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Left;
            this.btnALLtype.HoverBackColor = System.Drawing.Color.LightCyan;
            this.btnALLtype.HoverForeColor = System.Drawing.Color.White;
            this.btnALLtype.Name = "btnALLtype";
            this.btnALLtype.Padding = new Smobiler.Core.Padding(4F, 0F, 2F, 0F);
            this.btnALLtype.Size = new System.Drawing.SizeF(90F, 14F);
            this.btnALLtype.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btnALLtype.TabIndex = 2;
            this.btnALLtype.Text = "所有消费";
            this.btnALLtype.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnALLtype_Click);
            // 
            // btntotalAmount
            // 
            this.btntotalAmount.BackColor = System.Drawing.Color.Gainsboro;
            this.btntotalAmount.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.btntotalAmount.BorderColor = System.Drawing.Color.Silver;
            this.btntotalAmount.FontSize = 7F;
            this.btntotalAmount.ForeColor = System.Drawing.Color.Gray;
            this.btntotalAmount.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btntotalAmount.HoverBackColor = System.Drawing.Color.LightCyan;
            this.btntotalAmount.HoverForeColor = System.Drawing.Color.White;
            this.btntotalAmount.Location = new Smobiler.Core.PointS(90F, 0F);
            this.btntotalAmount.Name = "btntotalAmount";
            this.btntotalAmount.Padding = new Smobiler.Core.Padding(0F, 0F, 2F, 0F);
            this.btntotalAmount.Size = new System.Drawing.SizeF(30F, 14F);
            this.btntotalAmount.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btntotalAmount.TabIndex = 6;
            this.btntotalAmount.Text = "￥15.5";
            this.btntotalAmount.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnALLtype_Click);
            // 
            // GridView1
            // 
            this.GridView1.Layout = "frmConsumptionRightLayout";
            this.GridView1.Location = new Smobiler.Core.PointS(0F, 14F);
            this.GridView1.Name = "GridView1";
            this.GridView1.ShowGridLines = false;
            this.GridView1.Size = new System.Drawing.SizeF(120F, 186F);
            this.GridView1.TabIndex = 7;
            // 
            // tExit
            // 
            this.tExit.IconID = "Exit";
            this.tExit.Name = "tExit";
            this.tExit.Text = "返回";
            // 
            // frmConsumptionMainRight
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnALLtype,
            this.btntotalAmount,
            this.GridView1});
            this.TitleBackColor = System.Drawing.Color.DeepSkyBlue;
            this.TitleImage = "formimg";
            this.TitleText = "消费记录";
            this.Toolbar.AddRange(new Smobiler.Core.Controls.ToolbarItem[] {
            this.tExit});
            this.Load += new System.EventHandler(this.frmRBMainRightLayout_Load);
            this.ToolbarItemClick += new Smobiler.Core.ToolbarItemClickEventHandler(this.frmRBMainRightLayout_ToolbarItemClick);

        }
        internal Smobiler.Core.Controls.Button btnALLtype;
        internal Smobiler.Core.Controls.Button btntotalAmount;
        internal Smobiler.Core.Controls.GridView GridView1;

        internal Smobiler.Core.Controls.ToolbarItem tExit;
        #endregion

    }
}