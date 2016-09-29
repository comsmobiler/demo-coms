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
            Smobiler.Core.Controls.IconMenuViewGroup iconMenuViewGroup3 = new Smobiler.Core.Controls.IconMenuViewGroup();
            Smobiler.Core.Controls.IconMenuViewItem iconMenuViewItem17 = new Smobiler.Core.Controls.IconMenuViewItem();
            Smobiler.Core.Controls.IconMenuViewItem iconMenuViewItem18 = new Smobiler.Core.Controls.IconMenuViewItem();
            Smobiler.Core.Controls.IconMenuViewItem iconMenuViewItem19 = new Smobiler.Core.Controls.IconMenuViewItem();
            Smobiler.Core.Controls.IconMenuViewItem iconMenuViewItem20 = new Smobiler.Core.Controls.IconMenuViewItem();
            Smobiler.Core.Controls.IconMenuViewItem iconMenuViewItem21 = new Smobiler.Core.Controls.IconMenuViewItem();
            Smobiler.Core.Controls.IconMenuViewItem iconMenuViewItem22 = new Smobiler.Core.Controls.IconMenuViewItem();
            Smobiler.Core.Controls.IconMenuViewItem iconMenuViewItem23 = new Smobiler.Core.Controls.IconMenuViewItem();
            Smobiler.Core.Controls.IconMenuViewItem iconMenuViewItem24 = new Smobiler.Core.Controls.IconMenuViewItem();
            Smobiler.Core.Controls.SliderViewItem sliderViewItem11 = new Smobiler.Core.Controls.SliderViewItem();
            Smobiler.Core.Controls.SliderViewItem sliderViewItem12 = new Smobiler.Core.Controls.SliderViewItem();
            Smobiler.Core.Controls.SliderViewItem sliderViewItem13 = new Smobiler.Core.Controls.SliderViewItem();
            Smobiler.Core.Controls.SliderViewItem sliderViewItem14 = new Smobiler.Core.Controls.SliderViewItem();
            Smobiler.Core.Controls.SliderViewItem sliderViewItem15 = new Smobiler.Core.Controls.SliderViewItem();
            this.IconMenuView1 = new Smobiler.Core.Controls.IconMenuView();
            this.Gps1 = new Smobiler.Core.Controls.GPS();
            this.SliderView1 = new Smobiler.Core.Controls.SliderView();
            // 
            // IconMenuView1
            // 
            this.IconMenuView1.GridLines = true;
            this.IconMenuView1.GridLinesColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            iconMenuViewItem17.Icon = "MenuRBMain";
            iconMenuViewItem17.ID = "MenuRB";
            iconMenuViewItem17.Text = "报销";
            iconMenuViewItem18.Icon = "MenuWorkD";
            iconMenuViewItem18.ID = "MenuWorkD";
            iconMenuViewItem18.Text = "工单";
            iconMenuViewItem19.Icon = "MenuLeave";
            iconMenuViewItem19.ID = "MenuLeave";
            iconMenuViewItem19.Text = "请假";
            iconMenuViewItem19.Value = "SmobilerFrameworkExample.frmLeaveGrid";
            iconMenuViewItem20.Icon = "MenuUnCCUser";
            iconMenuViewItem20.ID = "MenuUnCCUser";
            iconMenuViewItem20.Text = "关注";
            iconMenuViewItem21.Icon = "MenuSign";
            iconMenuViewItem21.ID = "MenuSign";
            iconMenuViewItem21.Text = "签到";
            iconMenuViewItem22.Icon = "MenuOperational";
            iconMenuViewItem22.ID = "MenuOperational";
            iconMenuViewItem22.Text = "运维";
            iconMenuViewItem23.Icon = "MenuRItems";
            iconMenuViewItem23.ID = "MenuRItems";
            iconMenuViewItem23.Text = "物品领用";
            iconMenuViewItem24.Icon = "MenuFixedAssets";
            iconMenuViewItem24.ID = "MenuFixedAssets";
            iconMenuViewItem24.Text = "固定资产";
            iconMenuViewGroup3.Items.AddRange(new Smobiler.Core.Controls.IconMenuViewItem[] {
            iconMenuViewItem17,
            iconMenuViewItem18,
            iconMenuViewItem19,
            iconMenuViewItem20,
            iconMenuViewItem21,
            iconMenuViewItem22,
            iconMenuViewItem23,
            iconMenuViewItem24});
            this.IconMenuView1.Groups.AddRange(new Smobiler.Core.Controls.IconMenuViewGroup[] {
            iconMenuViewGroup3});
            this.IconMenuView1.Location = new System.Drawing.Point(0, 100);
            this.IconMenuView1.MenuItemHeight = 70F;
            this.IconMenuView1.Name = "IconMenuView1";
            this.IconMenuView1.Size = new System.Drawing.Size(240, 300);
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
            sliderViewItem11.ResourceID = "slider1";
            sliderViewItem11.Value = "1";
            sliderViewItem12.ResourceID = "slider2";
            sliderViewItem12.Value = "2";
            sliderViewItem13.ResourceID = "slider3";
            sliderViewItem13.Value = "3";
            sliderViewItem14.ResourceID = "slider4";
            sliderViewItem14.Value = "4";
            sliderViewItem15.ResourceID = "slider5";
            this.SliderView1.Items.AddRange(new Smobiler.Core.Controls.SliderViewItem[] {
            sliderViewItem11,
            sliderViewItem12,
            sliderViewItem13,
            sliderViewItem14,
            sliderViewItem15});
            this.SliderView1.Name = "SliderView1";
            this.SliderView1.Size = new System.Drawing.Size(240, 100);
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
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("!\\ue5d2255255255", System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(97)))), ((int)(((byte)(164))))), System.Drawing.Color.White);
            this.TitleText = "菜单";
            this.LeftLayoutItemClick += new Smobiler.Core.MobileFormLayoutItemClickEventHandler(this.frmMune_LeftLayoutItemClick);
            this.Load += new System.EventHandler(this.frmMune_Load);
            this.TitleImageClick += new System.EventHandler(this.frmMune_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.MobileForm_KeyDown);
            this.Name = "frmMune";

        }
        internal Smobiler.Core.Controls.IconMenuView IconMenuView1;
        internal Smobiler.Core.Controls.GPS Gps1;
        internal Smobiler.Core.Controls.SliderView SliderView1;
        #endregion

    }

}
