using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
namespace COMSSmobilerDemo
{
    public partial class frmRBMune : Smobiler.Core.MobileForm
    {

        #region "SmobilerForm Designer generated code "

        public frmRBMune()
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
            Smobiler.Core.Controls.MenuViewGroup menuViewGroup1 = new Smobiler.Core.Controls.MenuViewGroup();
            Smobiler.Core.Controls.MenuViewItem menuViewItem1 = new Smobiler.Core.Controls.MenuViewItem();
            Smobiler.Core.Controls.MenuViewItem menuViewItem2 = new Smobiler.Core.Controls.MenuViewItem();
            Smobiler.Core.Controls.MenuViewItem menuViewItem3 = new Smobiler.Core.Controls.MenuViewItem();
            Smobiler.Core.Controls.MenuViewItem menuViewItem4 = new Smobiler.Core.Controls.MenuViewItem();
            Smobiler.Core.Controls.MenuViewItem menuViewItem5 = new Smobiler.Core.Controls.MenuViewItem();
            this.tExit = new Smobiler.Core.Controls.ToolbarItem();
            this.Message = new Smobiler.Core.Controls.ToolbarItem();
            this.RB = new Smobiler.Core.Controls.ToolbarItem();
            this.Other = new Smobiler.Core.Controls.ToolbarItem();
            this.IconMenuView1 = new Smobiler.Core.Controls.IconMenuView();
            // 
            // tExit
            // 
            this.tExit.IconID = "Exit";
            this.tExit.Name = "tExit";
            this.tExit.Text = "返回";
            // 
            // Message
            // 
            this.Message.IconID = "Message";
            this.Message.Name = "Message";
            this.Message.Text = "消息";
            // 
            // RB
            // 
            this.RB.IconID = "COMS1";
            this.RB.Name = "RB";
            this.RB.Text = "报销";
            // 
            // Other
            // 
            this.Other.IconID = "Other";
            this.Other.Name = "Other";
            this.Other.Text = "其他";
            // 
            // IconMenuView1
            // 
            menuViewGroup1.ID = "RB";
            menuViewItem1.Button = new Smobiler.Core.Controls.MenuViewButton("", "");
            menuViewItem1.Icon = "RBMain";
            menuViewItem1.ID = "1";
            menuViewItem1.Text = "报销";
            menuViewItem1.Value = "frmRBMain";
            menuViewItem2.Button = new Smobiler.Core.Controls.MenuViewButton("", "");
            menuViewItem2.Icon = "songshen";
            menuViewItem2.ID = "2";
            menuViewItem2.Text = "送审";
            menuViewItem2.Value = "frmRBPostMain";
            menuViewItem3.Button = new Smobiler.Core.Controls.MenuViewButton("", "");
            menuViewItem3.Icon = "CheckCofirmed";
            menuViewItem3.ID = "3";
            menuViewItem3.Text = "责任人审批";
            menuViewItem3.Value = "frmRBCheck2";
            menuViewItem4.Button = new Smobiler.Core.Controls.MenuViewButton("", "");
            menuViewItem4.Icon = "Checking";
            menuViewItem4.ID = "4";
            menuViewItem4.Text = "行政审批";
            menuViewItem4.Value = "frmRBCheck3";
            menuViewItem5.Button = new Smobiler.Core.Controls.MenuViewButton("", "");
            menuViewItem5.Icon = "CheckAccounted";
            menuViewItem5.ID = "5";
            menuViewItem5.Text = "财务审批";
            menuViewItem5.Value = "frmRBCheck4";
            menuViewGroup1.Items.AddRange(new Smobiler.Core.Controls.MenuViewItem[] {
            menuViewItem1,
            menuViewItem2,
            menuViewItem3,
            menuViewItem4,
            menuViewItem5});
            menuViewGroup1.Title = "报销";
            this.IconMenuView1.Groups.AddRange(new Smobiler.Core.Controls.MenuViewGroup[] {
            menuViewGroup1});
            this.IconMenuView1.IconColumnCount = 2;
            this.IconMenuView1.Name = "IconMenuView1";
            this.IconMenuView1.Size = new System.Drawing.SizeF(120F, 200F);
            this.IconMenuView1.TabIndex = 2;
            this.IconMenuView1.MenuItemClick += new Smobiler.Core.Controls.MenuItemClickHandler(this.IconMenuView1_MenuItemClick);
            // 
            // frmRBMune
            // 
            this.AllowSlip = true;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.IconMenuView1});
            this.LeftFormLayout = "frmMainLeftLayout";
            this.TitleBackColor = System.Drawing.Color.DeepSkyBlue;
            this.TitleImage = "iconfont-menu";
            this.TitleText = "报销";
            this.Toolbar.AddRange(new Smobiler.Core.Controls.ToolbarItem[] {
            this.tExit,
            this.Message,
            this.RB,
            this.Other});
            this.LeftLayoutItemClick += new Smobiler.Core.MobileFormLayoutItemClickEventHandler(this.frmRBMune_LeftLayoutItemClick);
            this.ToolbarItemClick += new Smobiler.Core.ToolbarItemClickEventHandler(this.frmRBMune_ToolbarItemClick);
            this.TitleImageClick += new System.EventHandler(this.frmRBMune_TitleImageClick);

        }

        internal Smobiler.Core.Controls.ToolbarItem tExit;
        internal Smobiler.Core.Controls.ToolbarItem Message;
        internal Smobiler.Core.Controls.ToolbarItem RB;
        internal Smobiler.Core.Controls.ToolbarItem Other;

        internal Smobiler.Core.Controls.IconMenuView IconMenuView1;

        #endregion

    }

}