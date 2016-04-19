using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
namespace COMSSmobilerDemo.SignIn
{
    public partial class frmSignInMain : Smobiler.Core.MobileForm
    {

        #region "SmobilerForm Designer generated code "

        public frmSignInMain()
            : base()
        {

            //This call is required by the SmobilerForm.
            InitializeComponent();

            //Add any initialization after the InitializeComponent() call

        }

        //SmobilerForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm
        //It can be modified using the SmobilerForm.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.btnDaySign = new Smobiler.Core.Controls.Button();
            this.btnSDaySign = new Smobiler.Core.Controls.Button();
            this.btnMonthSign = new Smobiler.Core.Controls.Button();
            this.GridView1 = new Smobiler.Core.Controls.GridView();
            this.add = new Smobiler.Core.Controls.ToolbarItem();
            this.line3 = new Smobiler.Core.Controls.Line();
            this.l_DaySign = new Smobiler.Core.Controls.Line();
            this.L_SDaySign = new Smobiler.Core.Controls.Line();
            this.L_MonthSign = new Smobiler.Core.Controls.Line();
            this.tExit = new Smobiler.Core.Controls.ToolbarItem();
            // 
            // btnDaySign
            // 
            this.btnDaySign.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDaySign.Name = "btnDaySign";
            this.btnDaySign.Size = new System.Drawing.SizeF(40F, 14F);
            this.btnDaySign.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btnDaySign.TabIndex = 2;
            this.btnDaySign.Text = "今天";
            this.btnDaySign.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnDaySign_Click);
            // 
            // btnSDaySign
            // 
            this.btnSDaySign.ForeColor = System.Drawing.Color.Gray;
            this.btnSDaySign.Location = new Smobiler.Core.PointS(40F, 0F);
            this.btnSDaySign.Name = "btnSDaySign";
            this.btnSDaySign.Size = new System.Drawing.SizeF(40F, 14F);
            this.btnSDaySign.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btnSDaySign.TabIndex = 3;
            this.btnSDaySign.Text = "最近7天";
            this.btnSDaySign.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnSDaySign_Click);
            // 
            // btnMonthSign
            // 
            this.btnMonthSign.ForeColor = System.Drawing.Color.Gray;
            this.btnMonthSign.Location = new Smobiler.Core.PointS(80F, 0F);
            this.btnMonthSign.Name = "btnMonthSign";
            this.btnMonthSign.Size = new System.Drawing.SizeF(40F, 14F);
            this.btnMonthSign.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btnMonthSign.TabIndex = 4;
            this.btnMonthSign.Text = "最近一个月";
            this.btnMonthSign.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnMonthSign_Click);
            // 
            // GridView1
            // 
            this.GridView1.AllowSlip = true;
            this.GridView1.Layout = "frmSignInLayout";
            this.GridView1.Location = new Smobiler.Core.PointS(0F, 15F);
            this.GridView1.Name = "GridView1";
            this.GridView1.Size = new System.Drawing.SizeF(120F, 185F);
            this.GridView1.TabIndex = 5;
            this.GridView1.UpSlippling += new System.EventHandler(this.GridView1_UpSlippling);
            this.GridView1.DownSlippling += new System.EventHandler(this.GridView1_DownSlippling);
            // 
            // add
            // 
            this.add.IconID = "add";
            this.add.Name = "add";
            this.add.Text = "签到录入";
            // 
            // line3
            // 
            this.line3.BackColor = System.Drawing.Color.Gray;
            this.line3.LineSize = 0.5F;
            this.line3.Location = new Smobiler.Core.PointS(0F, 14.5F);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.SizeF(120F, 1F);
            this.line3.TabIndex = 6;
            // 
            // l_DaySign
            // 
            this.l_DaySign.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.l_DaySign.LineSize = 0.6F;
            this.l_DaySign.Location = new Smobiler.Core.PointS(0F, 14F);
            this.l_DaySign.Name = "l_DaySign";
            this.l_DaySign.Size = new System.Drawing.SizeF(40F, 1F);
            this.l_DaySign.TabIndex = 7;
            // 
            // L_SDaySign
            // 
            this.L_SDaySign.BackColor = System.Drawing.Color.White;
            this.L_SDaySign.LineSize = 0.6F;
            this.L_SDaySign.Location = new Smobiler.Core.PointS(40F, 14F);
            this.L_SDaySign.Name = "L_SDaySign";
            this.L_SDaySign.Size = new System.Drawing.SizeF(40F, 1F);
            this.L_SDaySign.TabIndex = 8;
            // 
            // L_MonthSign
            // 
            this.L_MonthSign.BackColor = System.Drawing.Color.White;
            this.L_MonthSign.LineSize = 0.6F;
            this.L_MonthSign.Location = new Smobiler.Core.PointS(80F, 14F);
            this.L_MonthSign.Name = "L_MonthSign";
            this.L_MonthSign.Size = new System.Drawing.SizeF(40F, 1F);
            this.L_MonthSign.TabIndex = 9;
            // 
            // tExit
            // 
            this.tExit.IconID = "Exit";
            this.tExit.Name = "tExit";
            this.tExit.Text = "返回";
            // 
            // frmSignInMain
            // 
            this.AllowSlip = true;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnDaySign,
            this.btnSDaySign,
            this.btnMonthSign,
            this.GridView1,
            this.line3,
            this.l_DaySign,
            this.L_SDaySign,
            this.L_MonthSign});
            this.TitleBackColor = System.Drawing.Color.DeepSkyBlue;
            this.TitleText = "签到";
            this.Toolbar.AddRange(new Smobiler.Core.Controls.ToolbarItem[] {
            this.tExit,
            this.add});
            this.Load += new System.EventHandler(this.frmSignIn_Load);
            this.ToolbarItemClick += new Smobiler.Core.ToolbarItemClickEventHandler(this.frmSignIn_ToolbarItemClick);
            this.LeftSlipping += new System.EventHandler(this.frmSignIn_LeftSlipping);
            this.RightSlipping += new System.EventHandler(this.frmSignIn_RightSlipping);

        }
        internal Smobiler.Core.Controls.Button btnDaySign;
        internal Smobiler.Core.Controls.Button btnSDaySign;
        internal Smobiler.Core.Controls.Button btnMonthSign;
        internal Smobiler.Core.Controls.GridView GridView1;
        internal Smobiler.Core.Controls.ToolbarItem @add;
        internal Smobiler.Core.Controls.Line line3;
        internal Smobiler.Core.Controls.Line l_DaySign;
        internal Smobiler.Core.Controls.Line L_SDaySign;
        internal Smobiler.Core.Controls.Line L_MonthSign;

        internal Smobiler.Core.Controls.ToolbarItem tExit;
        #endregion

    }
}