using System;
using Smobiler.Core;
namespace COMSSmobilerDemo.FixedAssets.Books
{
    partial class frmBookLogCheckMain : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmBookLogCheckMain()
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
            Smobiler.Core.Controls.TextTabBarItem textTabBarItem5 = new Smobiler.Core.Controls.TextTabBarItem();
            Smobiler.Core.Controls.TextTabBarItem textTabBarItem6 = new Smobiler.Core.Controls.TextTabBarItem();
            this.GridView1 = new Smobiler.Core.Controls.GridView();
            this.add = new Smobiler.Core.Controls.ToolbarItem();
            this.TextTabBar1 = new Smobiler.Core.Controls.TextTabBar();
            // 
            // GridView1
            // 
            this.GridView1.AllowSlip = true;
            this.GridView1.Layout = "frmBookLogLayout";
            this.GridView1.Location = new System.Drawing.Point(0,46);
            this.GridView1.Name = "GridView1";
            this.GridView1.ShowGridLines = false;
            this.GridView1.Size = new System.Drawing.Size(240,400);
            this.GridView1.TabIndex = 2;
            this.GridView1.CellClick += new Smobiler.Core.Controls.GridViewCellClickEventHandler(this.GridView1_CellClick);
            this.GridView1.UpSlippling += new System.EventHandler(this.GridView1_UpSlippling);
            this.GridView1.DownSlippling += new System.EventHandler(this.GridView1_DownSlippling);
            // 
            // add
            // 
            this.add.IconID = "!\\ue148043146223";
            this.add.Name = "add";
            this.add.Text = "新增";
            // 
            // TextTabBar1
            // 
            this.TextTabBar1.BackColor = System.Drawing.Color.White;
            this.TextTabBar1.Border = new Smobiler.Core.Border(1);
            this.TextTabBar1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.TextTabBar1.BorderRadius = 2;
            this.TextTabBar1.BorderSize = 0.2F;
            this.TextTabBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            textTabBarItem5.Text = "我借阅的";
            textTabBarItem5.Value = "BookL";
            textTabBarItem6.Text = "所有的";
            textTabBarItem6.Value = "AllBookL";
            this.TextTabBar1.Items.AddRange(new Smobiler.Core.Controls.TextTabBarItem[] {
            textTabBarItem5,
            textTabBarItem6});
            this.TextTabBar1.Location = new System.Drawing.Point(20,10);
            this.TextTabBar1.Name = "TextTabBar1";
            this.TextTabBar1.SelectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.TextTabBar1.SelectForeColor = System.Drawing.Color.White;
            this.TextTabBar1.Size = new System.Drawing.Size(200,28);
            this.TextTabBar1.TabIndex = 3;
            this.TextTabBar1.ItemClick += new Smobiler.Core.Controls.TabBarItemClickEventHandler(this.TextTabBar1_ItemClick);
            // 
            // frmBookLogCheckMain
            // 
            this.AllowSlip = true;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.GridView1,
            this.TextTabBar1});
            this.StatusBarStyle = Smobiler.Core.StatusBarStyle.Default;
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("Exit", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(50))))));
            this.TitleText = "图书借阅记录";
            this.Toolbar.AddRange(new Smobiler.Core.Controls.ToolbarItem[] {
            this.add});
            this.ToolbarStyle = new Smobiler.Core.ToolBarSytle(Smobiler.Core.ToolbarSelectStyle.None, System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))), System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))));
            this.Load += new System.EventHandler(this.frmBookLog_Load);
            this.ToolbarItemClick += new Smobiler.Core.ToolbarItemClickEventHandler(this.frmBookLog_ToolbarItemClick);
            this.LeftSlipping += new System.EventHandler(this.frmBookLogCheckMain_LeftSlipping);
            this.RightSlipping += new System.EventHandler(this.frmBookLogCheckMain_RightSlipping);
            this.TitleImageClick += new System.EventHandler(this.frmBookLog_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.frmBookLog_KeyDown);
            this.Name = "frmBookLogCheckMain";

        }
        internal Smobiler.Core.Controls.GridView GridView1;
        internal Smobiler.Core.Controls.ToolbarItem @add;
        internal Smobiler.Core.Controls.TextTabBar TextTabBar1;
        #endregion
    }
}
