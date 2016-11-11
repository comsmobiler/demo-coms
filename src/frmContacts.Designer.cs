using System;
using Smobiler.Core;
namespace COMSSmobilerDemo
{
    partial class frmContacts : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmContacts()
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
            Smobiler.Core.Controls.ImageTabBarItem imageTabBarItem5 = new Smobiler.Core.Controls.ImageTabBarItem();
            Smobiler.Core.Controls.ImageTabBarItem imageTabBarItem6 = new Smobiler.Core.Controls.ImageTabBarItem();
            Smobiler.Core.Controls.ImageTabBarItem imageTabBarItem7 = new Smobiler.Core.Controls.ImageTabBarItem();
            Smobiler.Core.Controls.ImageTabBarItem imageTabBarItem8 = new Smobiler.Core.Controls.ImageTabBarItem();
            this.imageTabBar1 = new Smobiler.Core.Controls.ImageTabBar();
            this.GridView1 = new Smobiler.Core.Controls.GridView();
            this.Work = new Smobiler.Core.Controls.ToolbarItem();
            this.Content = new Smobiler.Core.Controls.ToolbarItem();
            this.Mes = new Smobiler.Core.Controls.ToolbarItem();
            // 
            // imageTabBar1
            // 
            this.imageTabBar1.BackColor = System.Drawing.Color.White;
            this.imageTabBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            imageTabBarItem5.ImageResourceID = "!\\ue7fd213213213";
            imageTabBarItem5.SelectImageResourceID = "!\\ue7fd022137217";
            imageTabBarItem5.Text = "我的联系人";
            imageTabBarItem6.ImageResourceID = "!\\ue8d3213213213";
            imageTabBarItem6.SelectImageResourceID = "!\\ue8d3022137217";
            imageTabBarItem6.Text = "我的群组";
            imageTabBarItem7.ImageResourceID = "!\\ue7fe213213213";
            imageTabBarItem7.SelectImageResourceID = "!\\ue7fe022137217";
            imageTabBarItem7.Text = "新加用户";
            imageTabBarItem8.ImageResourceID = "!\\ue7f0213213213";
            imageTabBarItem8.SelectImageResourceID = "!\\ue7f0022137217";
            imageTabBarItem8.Text = "创建群组";
            this.imageTabBar1.Items.AddRange(new Smobiler.Core.Controls.ImageTabBarItem[] {
            imageTabBarItem5,
            imageTabBarItem6,
            imageTabBarItem7,
            imageTabBarItem8});
            this.imageTabBar1.Name = "imageTabBar1";
            this.imageTabBar1.SelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.imageTabBar1.Size = new System.Drawing.Size(300, 66);
            this.imageTabBar1.TabIndex = 2;
            this.imageTabBar1.ItemClick += new Smobiler.Core.Controls.TabBarItemClickEventHandler(this.imageTabBar1_ItemClick);
            // 
            // GridView1
            // 
            this.GridView1.Layout = "frmContentLayout";
            this.GridView1.Location = new System.Drawing.Point(0, 66);
            this.GridView1.Name = "GridView1";
            this.GridView1.Size = new System.Drawing.Size(300, 434);
            this.GridView1.TabIndex = 3;
            this.GridView1.CellClick += new Smobiler.Core.Controls.GridViewCellClickEventHandler(this.GridView1_CellClick);
            // 
            // Work
            // 
            this.Work.IconID = "!\\ue8f9022137217";
            this.Work.Name = "Work";
            this.Work.SelectIconID = "!\\ue8f9022137217";
            this.Work.Text = "工作";
            // 
            // Content
            // 
            this.Content.IconID = "!\\ue7fd022137217";
            this.Content.Name = "Content";
            this.Content.SelectIconID = "!\\ue7fd022137217";
            this.Content.Text = "联系人";
            // 
            // Mes
            // 
            this.Mes.IconID = "!\\ue0bf022137217";
            this.Mes.Name = "Mes";
            this.Mes.SelectIconID = "!\\ue0bf022137217";
            this.Mes.Text = "消息";
            // 
            // frmContacts
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.imageTabBar1,
            this.GridView1});
            this.LayoutMode = Smobiler.Core.FormLayoutMode.EFFACT3D;
            this.LeftFormLayout = "frmMenuLayout";
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("!\\ue5d2255255255", System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(97)))), ((int)(((byte)(164))))), System.Drawing.Color.White);
            this.TitleText = "联系人";
            this.Toolbar.AddRange(new Smobiler.Core.Controls.ToolbarItem[] {
            this.Work,
            this.Content,
            this.Mes});
            this.ToolbarStyle = new Smobiler.Core.ToolBarSytle(Smobiler.Core.ToolbarSelectStyle.Select, System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145))))), System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145))))));
            this.LeftLayoutItemClick += new Smobiler.Core.MobileFormLayoutItemClickEventHandler(this.frmContacts_LeftLayoutItemClick);
            this.Load += new System.EventHandler(this.frmContacts_Load);
            this.ToolbarItemClick += new Smobiler.Core.ToolbarItemClickEventHandler(this.frmContacts_ToolbarItemClick);
            this.TitleImageClick += new System.EventHandler(this.frmContacts_TitleImageClick);
            this.Name = "frmContacts";

        }
        #endregion

        private Smobiler.Core.Controls.ImageTabBar imageTabBar1;
        internal Smobiler.Core.Controls.GridView GridView1;
        internal Smobiler.Core.Controls.ToolbarItem Work;
        internal Smobiler.Core.Controls.ToolbarItem Content;
        internal Smobiler.Core.Controls.ToolbarItem Mes;
    }
}