using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
namespace COMSSmobilerDemo
{
    public partial class frmMune : Smobiler.Core.MobileForm
    {

        #region "SmobilerForm Designer generated code "

        public frmMune()
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
            Smobiler.Core.Controls.IconMenuViewGroup iconMenuViewGroup1 = new Smobiler.Core.Controls.IconMenuViewGroup();
            Smobiler.Core.Controls.IconMenuViewItem iconMenuViewItem1 = new Smobiler.Core.Controls.IconMenuViewItem();
            Smobiler.Core.Controls.IconMenuViewItem iconMenuViewItem2 = new Smobiler.Core.Controls.IconMenuViewItem();
            Smobiler.Core.Controls.IconMenuViewItem iconMenuViewItem3 = new Smobiler.Core.Controls.IconMenuViewItem();
            Smobiler.Core.Controls.IconMenuViewItem iconMenuViewItem4 = new Smobiler.Core.Controls.IconMenuViewItem();
            Smobiler.Core.Controls.IconMenuViewItem iconMenuViewItem5 = new Smobiler.Core.Controls.IconMenuViewItem();
            Smobiler.Core.Controls.IconMenuViewItem iconMenuViewItem6 = new Smobiler.Core.Controls.IconMenuViewItem();
            Smobiler.Core.Controls.SliderViewItem sliderViewItem1 = new Smobiler.Core.Controls.SliderViewItem();
            Smobiler.Core.Controls.SliderViewItem sliderViewItem2 = new Smobiler.Core.Controls.SliderViewItem();
            Smobiler.Core.Controls.SliderViewItem sliderViewItem3 = new Smobiler.Core.Controls.SliderViewItem();
            Smobiler.Core.Controls.SliderViewItem sliderViewItem4 = new Smobiler.Core.Controls.SliderViewItem();
            Smobiler.Core.Controls.SliderViewItem sliderViewItem5 = new Smobiler.Core.Controls.SliderViewItem();
            this.IconMenuView1 = new Smobiler.Core.Controls.IconMenuView();
            this.Gps1 = new Smobiler.Core.Controls.GPS();
            this.SliderView1 = new Smobiler.Core.Controls.SliderView();
            // 
            // IconMenuView1
            // 
            this.IconMenuView1.GridLines = true;
            this.IconMenuView1.GridLinesColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            iconMenuViewItem1.Icon = "MenuRBMain";
            iconMenuViewItem1.ID = "MenuRB";
            iconMenuViewItem1.Text = "报销";
            iconMenuViewItem2.Icon = "MenuWorkD";
            iconMenuViewItem2.ID = "MenuWorkD";
            iconMenuViewItem2.Text = "工单";
            iconMenuViewItem3.Icon = "MenuLeave";
            iconMenuViewItem3.ID = "MenuLeave";
            iconMenuViewItem3.Text = "请假";
            iconMenuViewItem3.Value = "SmobilerFrameworkExample.frmLeaveGrid";
            iconMenuViewItem4.Icon = "MenuUnCCUser";
            iconMenuViewItem4.ID = "MenuUnCCUser";
            iconMenuViewItem4.Text = "关注";
            iconMenuViewItem5.Icon = "MenuSign";
            iconMenuViewItem5.ID = "MenuSign";
            iconMenuViewItem5.Text = "签到";
            iconMenuViewItem6.Icon = "MenuOperational";
            iconMenuViewItem6.ID = "MenuOperational";
            iconMenuViewItem6.Text = "运维";
            iconMenuViewGroup1.Items.AddRange(new Smobiler.Core.Controls.IconMenuViewItem[] {
            iconMenuViewItem1,
            iconMenuViewItem2,
            iconMenuViewItem3,
            iconMenuViewItem4,
            iconMenuViewItem5,
            iconMenuViewItem6});
            this.IconMenuView1.Groups.AddRange(new Smobiler.Core.Controls.IconMenuViewGroup[] {
            iconMenuViewGroup1});
            this.IconMenuView1.Location = new Smobiler.Core.PointS(0F, 50F);
            this.IconMenuView1.MenuItemHeight = 35F;
            this.IconMenuView1.Name = "IconMenuView1";
            this.IconMenuView1.Size = new System.Drawing.SizeF(120F, 150F);
            this.IconMenuView1.TabIndex = 15;
            this.IconMenuView1.ZIndex = 2;
            this.IconMenuView1.MenuItemClick += new Smobiler.Core.Controls.IconMenuItemClickHandler(this.MenuView1_MenuItemClick);
            // 
            // Gps1
            // 
            this.Gps1.Name = "Gps1";
            // 
            // SliderView1
            // 
            sliderViewItem1.ResourceID = "slider1";
            sliderViewItem1.Value = "1";
            sliderViewItem2.ResourceID = "slider2";
            sliderViewItem2.Value = "2";
            sliderViewItem3.ResourceID = "slider3";
            sliderViewItem3.Value = "3";
            sliderViewItem4.ResourceID = "slider4";
            sliderViewItem4.Value = "4";
            sliderViewItem5.ResourceID = "slider5";
            this.SliderView1.Items.AddRange(new Smobiler.Core.Controls.SliderViewItem[] {
            sliderViewItem1,
            sliderViewItem2,
            sliderViewItem3,
            sliderViewItem4,
            sliderViewItem5});
            this.SliderView1.Name = "SliderView1";
            this.SliderView1.Size = new System.Drawing.SizeF(120F, 50F);
            this.SliderView1.SizeMode = Smobiler.Core.ImageSizeMode.StretchImage;
            this.SliderView1.TabIndex = 16;
            this.SliderView1.ZIndex = 1;
            // 
            // frmMune
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ComponentControls.AddRange(new Smobiler.Core.ComponentBase[] {
            this.Gps1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.SliderView1,
            this.IconMenuView1});
            this.LayoutMode = Smobiler.Core.FormLayoutMode.EFFACT3D;
            this.LeftFormLayout = "frmMenuLayout";
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("menu", System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(97)))), ((int)(((byte)(164))))), System.Drawing.Color.White);
            this.TitleText = "菜单";
            this.LeftLayoutItemClick += new Smobiler.Core.MobileFormLayoutItemClickEventHandler(this.frmMune_LeftLayoutItemClick);
            this.Load += new System.EventHandler(this.frmMune_Load);
            this.TitleImageClick += new System.EventHandler(this.frmMune_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.MobileForm_KeyDown);

        }
        internal Smobiler.Core.Controls.IconMenuView IconMenuView1;
        internal Smobiler.Core.Controls.GPS Gps1;
        internal Smobiler.Core.Controls.SliderView SliderView1;
        #endregion

    }

}