using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
namespace COMSSmobilerDemo.WorkDocument
{
    public partial class frmWorkDMain : Smobiler.Core.MobileForm
    {

        #region "SmobilerForm Designer generated code "

        public frmWorkDMain()
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
            Smobiler.Core.Controls.TextTabBarItem textTabBarItem1 = new Smobiler.Core.Controls.TextTabBarItem();
            Smobiler.Core.Controls.TextTabBarItem textTabBarItem2 = new Smobiler.Core.Controls.TextTabBarItem();
            this.GridView1 = new Smobiler.Core.Controls.GridView();
            this.add = new Smobiler.Core.Controls.ToolbarItem();
            this.SX = new Smobiler.Core.Controls.ToolbarItem();
            this.TextTabBar1 = new Smobiler.Core.Controls.TextTabBar();
            this.KPI = new Smobiler.Core.Controls.ToolbarItem();
            // 
            // GridView1
            // 
            this.GridView1.AllowSlip = true;
            this.GridView1.Layout = "frmWorkDLayout";
            this.GridView1.Location = new System.Drawing.Point(0, 58);
            this.GridView1.Name = "GridView1";
            this.GridView1.ShowGridLines = false;
            this.GridView1.Size = new System.Drawing.Size(300, 438);
            this.GridView1.TabIndex = 9;
            this.GridView1.CellClick += new Smobiler.Core.Controls.GridViewCellClickEventHandler(this.GridView1_CellClick);
            this.GridView1.UpSlippling += new System.EventHandler(this.GridView1_UpSlippling);
            this.GridView1.DownSlippling += new System.EventHandler(this.GridView1_DownSlippling);
            // 
            // add
            // 
            this.add.IconID = "!\\ue148043146223";
            this.add.Name = "add";
            this.add.SelectIconID = "!\\ue148043146223";
            this.add.Text = "新增";
            // 
            // SX
            // 
            this.SX.IconID = "!\\ue88b043146223";
            this.SX.Name = "SX";
            this.SX.SelectIconID = "!\\ue88b043146223";
            this.SX.Text = "筛选";
            // 
            // TextTabBar1
            // 
            this.TextTabBar1.BackColor = System.Drawing.Color.White;
            this.TextTabBar1.Border = new Smobiler.Core.Border(1);
            this.TextTabBar1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.TextTabBar1.BorderRadius = 2;
            this.TextTabBar1.BorderSize = 0.2F;
            this.TextTabBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            textTabBarItem1.Text = "我创建的";
            textTabBarItem1.Value = "WDCreate";
            textTabBarItem2.Text = "我审批的";
            textTabBarItem2.Value = "WDCheck";
            this.TextTabBar1.Items.AddRange(new Smobiler.Core.Controls.TextTabBarItem[] {
            textTabBarItem1,
            textTabBarItem2});
            this.TextTabBar1.Location = new System.Drawing.Point(25, 13);
            this.TextTabBar1.Name = "TextTabBar1";
            this.TextTabBar1.SelectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.TextTabBar1.SelectForeColor = System.Drawing.Color.White;
            this.TextTabBar1.Size = new System.Drawing.Size(250, 35);
            this.TextTabBar1.TabIndex = 13;
            this.TextTabBar1.ItemClick += new Smobiler.Core.Controls.TabBarItemClickEventHandler(this.TextTabBar1_ItemClick);
            // 
            // KPI
            // 
            this.KPI.IconID = "!\\ue640043146223";
            this.KPI.Name = "KPI";
            this.KPI.SelectIconID = "!\\ue640043146223";
            this.KPI.Text = "绩效";
            // 
            // frmWorkDMain
            // 
            this.AllowSlip = true;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.GridView1,
            this.TextTabBar1});
            this.StatusBarStyle = Smobiler.Core.StatusBarStyle.Default;
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("Exit", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(50))))));
            this.TitleText = "工单";
            this.Toolbar.AddRange(new Smobiler.Core.Controls.ToolbarItem[] {
            this.add,
            this.SX,
            this.KPI});
            this.ToolbarStyle = new Smobiler.Core.ToolBarSytle(Smobiler.Core.ToolbarSelectStyle.None, System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))), System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))));
            this.Load += new System.EventHandler(this.frmWorkDocumentMain_Load);
            this.ToolbarItemClick += new Smobiler.Core.ToolbarItemClickEventHandler(this.frmWorkDocumentMain_ToolbarItemClick);
            this.LeftSlipping += new System.EventHandler(this.frmWorkDocumentMain_LeftSlipping);
            this.RightSlipping += new System.EventHandler(this.frmWorkDocumentMain_RightSlipping);
            this.TitleImageClick += new System.EventHandler(this.MobileForm_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.MobileForm_KeyDown);
            this.Name = "frmWorkDMain";

        }
        internal Smobiler.Core.Controls.GridView GridView1;
        internal Smobiler.Core.Controls.ToolbarItem @add;
        internal Smobiler.Core.Controls.ToolbarItem SX;
        internal Smobiler.Core.Controls.TextTabBar TextTabBar1;
        #endregion
        private Smobiler.Core.Controls.ToolbarItem KPI;

    }
}
