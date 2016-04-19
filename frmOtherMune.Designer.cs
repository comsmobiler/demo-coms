
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
namespace COMSSmobilerDemo
{
    public partial class frmOtherMune : Smobiler.Core.MobileForm
    {

        #region "SmobilerForm Designer generated code "

        public frmOtherMune()
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
            Smobiler.Core.Controls.MenuViewGroup menuViewGroup1 = new Smobiler.Core.Controls.MenuViewGroup();
            Smobiler.Core.Controls.MenuViewItem menuViewItem1 = new Smobiler.Core.Controls.MenuViewItem();
            Smobiler.Core.Controls.MenuViewItem menuViewItem2 = new Smobiler.Core.Controls.MenuViewItem();
            Smobiler.Core.Controls.MenuViewItem menuViewItem3 = new Smobiler.Core.Controls.MenuViewItem();
            Smobiler.Core.Controls.MenuViewItem menuViewItem4 = new Smobiler.Core.Controls.MenuViewItem();
            this.tExit = new Smobiler.Core.Controls.ToolbarItem();
            this.RB = new Smobiler.Core.Controls.ToolbarItem();
            this.Message = new Smobiler.Core.Controls.ToolbarItem();
            this.IconMenuView1 = new Smobiler.Core.Controls.IconMenuView();
            this.Other = new Smobiler.Core.Controls.ToolbarItem();
            // 
            // tExit
            // 
            this.tExit.IconID = "Exit";
            this.tExit.Name = "tExit";
            this.tExit.Text = "返回";
            // 
            // RB
            // 
            this.RB.IconID = "COMS";
            this.RB.Name = "RB";
            this.RB.Text = "报销";
            // 
            // Message
            // 
            this.Message.IconID = "Message";
            this.Message.Name = "Message";
            this.Message.Text = "消息";
            // 
            // IconMenuView1
            // 
            menuViewGroup1.ID = "Other";
            menuViewItem1.Button = new Smobiler.Core.Controls.MenuViewButton("", "");
            menuViewItem1.Icon = "WorkDMain";
            menuViewItem1.ID = "1";
            menuViewItem1.Text = "工作单";
            menuViewItem1.Value = "frmWorkDMain";
            menuViewItem2.Button = new Smobiler.Core.Controls.MenuViewButton("", "");
            menuViewItem2.Icon = "LeaveMain";
            menuViewItem2.ID = "2";
            menuViewItem2.Text = "请假";
            menuViewItem2.Value = "frmLeaveGrid";
            menuViewItem3.Button = new Smobiler.Core.Controls.MenuViewButton("", "");
            menuViewItem3.Icon = "SignInMain";
            menuViewItem3.ID = "3";
            menuViewItem3.Text = "签到";
            menuViewItem3.Value = "frmSignInMain";
            menuViewItem4.Button = new Smobiler.Core.Controls.MenuViewButton("", "");
            menuViewItem4.Icon = "OperationalRMain";
            menuViewItem4.ID = "4";
            menuViewItem4.Text = "运维记录";
            menuViewItem4.Value = "frmOperationalRMain";
            menuViewGroup1.Items.AddRange(new Smobiler.Core.Controls.MenuViewItem[] {
            menuViewItem1,
            menuViewItem2,
            menuViewItem3,
            menuViewItem4});
            menuViewGroup1.Title = "其他";
            this.IconMenuView1.Groups.AddRange(new Smobiler.Core.Controls.MenuViewGroup[] {
            menuViewGroup1});
            this.IconMenuView1.IconColumnCount = 3;
            this.IconMenuView1.Name = "IconMenuView1";
            this.IconMenuView1.Size = new System.Drawing.SizeF(120F, 200F);
            this.IconMenuView1.TabIndex = 15;
            this.IconMenuView1.MenuItemClick += new Smobiler.Core.Controls.MenuItemClickHandler(this.IconMenuView1_MenuItemClick);
            // 
            // Other
            // 
            this.Other.IconID = "Other1";
            this.Other.Name = "Other";
            this.Other.Text = "其他";
            // 
            // frmOtherMune
            // 
            this.AllowSlip = true;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.IconMenuView1});
            this.LeftFormLayout = "frmMainLeftLayout";
            this.TitleBackColor = System.Drawing.Color.DeepSkyBlue;
            this.TitleImage = "iconfont-menu";
            this.TitleText = "其他";
            this.Toolbar.AddRange(new Smobiler.Core.Controls.ToolbarItem[] {
            this.tExit,
            this.Message,
            this.RB,
            this.Other});
            this.LeftLayoutItemClick += new Smobiler.Core.MobileFormLayoutItemClickEventHandler(this.frmOtherMune_LeftLayoutItemClick);
            this.ToolbarItemClick += new Smobiler.Core.ToolbarItemClickEventHandler(this.frmOtherMune_ToolbarItemClick);
            this.TitleImageClick += new System.EventHandler(this.frmOtherMune_TitleImageClick);

        }

        internal Smobiler.Core.Controls.ToolbarItem tExit;
        internal Smobiler.Core.Controls.ToolbarItem RB;
        internal Smobiler.Core.Controls.ToolbarItem Message;
        internal Smobiler.Core.Controls.IconMenuView IconMenuView1;

        internal Smobiler.Core.Controls.ToolbarItem Other;
        #endregion

    }
}

