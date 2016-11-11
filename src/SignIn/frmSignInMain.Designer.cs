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
            Smobiler.Core.Controls.TextTabBarItem textTabBarItem1 = new Smobiler.Core.Controls.TextTabBarItem();
            Smobiler.Core.Controls.TextTabBarItem textTabBarItem2 = new Smobiler.Core.Controls.TextTabBarItem();
            Smobiler.Core.Controls.TextTabBarItem textTabBarItem3 = new Smobiler.Core.Controls.TextTabBarItem();
            this.GridView1 = new Smobiler.Core.Controls.GridView();
            this.add = new Smobiler.Core.Controls.ToolbarItem();
            this.TextTabBar1 = new Smobiler.Core.Controls.TextTabBar();
            // 
            // GridView1
            // 
            this.GridView1.AllowSlip = true;
            this.GridView1.Layout = "frmSignInLayout";
            this.GridView1.Location = new System.Drawing.Point(0, 58);
            this.GridView1.Name = "GridView1";
            this.GridView1.ShowGridLines = false;
            this.GridView1.Size = new System.Drawing.Size(300, 438);
            this.GridView1.TabIndex = 5;
            this.GridView1.UpSlippling += new System.EventHandler(this.GridView1_UpSlippling);
            this.GridView1.DownSlippling += new System.EventHandler(this.GridView1_DownSlippling);
            // 
            // add
            // 
            this.add.IconID = "!\\ue148043146223";
            this.add.Name = "add";
            this.add.SelectIconID = "!\\ue148043146223";
            this.add.Text = "签到录入";
            // 
            // TextTabBar1
            // 
            this.TextTabBar1.BackColor = System.Drawing.Color.White;
            this.TextTabBar1.Border = new Smobiler.Core.Border(1);
            this.TextTabBar1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.TextTabBar1.BorderRadius = 2;
            this.TextTabBar1.BorderSize = 0.2F;
            this.TextTabBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            textTabBarItem1.Text = "今天";
            textTabBarItem1.Value = "DaySign";
            textTabBarItem2.Text = "最近七天";
            textTabBarItem2.Value = "SDaySign";
            textTabBarItem3.Text = "最近一个月";
            textTabBarItem3.Value = "MDaySign";
            this.TextTabBar1.Items.AddRange(new Smobiler.Core.Controls.TextTabBarItem[] {
            textTabBarItem1,
            textTabBarItem2,
            textTabBarItem3});
            this.TextTabBar1.Location = new System.Drawing.Point(25, 13);
            this.TextTabBar1.Name = "TextTabBar1";
            this.TextTabBar1.SelectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.TextTabBar1.SelectForeColor = System.Drawing.Color.White;
            this.TextTabBar1.Size = new System.Drawing.Size(250, 35);
            this.TextTabBar1.TabIndex = 10;
            this.TextTabBar1.ItemClick += new Smobiler.Core.Controls.TabBarItemClickEventHandler(this.TextTabBar1_ItemClick);
            // 
            // frmSignInMain
            // 
            this.AllowSlip = true;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.GridView1,
            this.TextTabBar1});
            this.StatusBarStyle = Smobiler.Core.StatusBarStyle.Default;
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("Exit", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(50))))));
            this.TitleText = "签到";
            this.Toolbar.AddRange(new Smobiler.Core.Controls.ToolbarItem[] {
            this.add});
            this.ToolbarStyle = new Smobiler.Core.ToolBarSytle(Smobiler.Core.ToolbarSelectStyle.None, System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))), System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))));
            this.Load += new System.EventHandler(this.frmSignIn_Load);
            this.ToolbarItemClick += new Smobiler.Core.ToolbarItemClickEventHandler(this.frmSignIn_ToolbarItemClick);
            this.LeftSlipping += new System.EventHandler(this.frmSignIn_LeftSlipping);
            this.RightSlipping += new System.EventHandler(this.frmSignIn_RightSlipping);
            this.TitleImageClick += new System.EventHandler(this.frmSignInMain_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.MobileForm_KeyDown);
            this.Name = "frmSignInMain";

        }
        internal Smobiler.Core.Controls.GridView GridView1;
        internal Smobiler.Core.Controls.ToolbarItem @add;
        internal Smobiler.Core.Controls.TextTabBar TextTabBar1;

        #endregion

    }
}
