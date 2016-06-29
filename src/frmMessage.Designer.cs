using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
namespace COMSSmobilerDemo
{
    public partial class frmMessage : Smobiler.Core.MobileForm
    {

        #region "SmobilerForm Designer generated code "

        public frmMessage()
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
            this.txtSearchinfo = new Smobiler.Core.Controls.TextBox();
            this.btnSearch = new Smobiler.Core.Controls.ImageButton();
            this.GridView1 = new Smobiler.Core.Controls.GridView();
            this.tExit = new Smobiler.Core.Controls.ToolbarItem();
            this.Gps1 = new Smobiler.Core.Controls.GPS();
            this.Label1 = new Smobiler.Core.Controls.Label();
            // 
            // txtSearchinfo
            // 
            this.txtSearchinfo.Border = new Smobiler.Core.Border(1);
            this.txtSearchinfo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtSearchinfo.BorderRadius = 2;
            this.txtSearchinfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txtSearchinfo.Location = new Smobiler.Core.PointS(1F, 5F);
            this.txtSearchinfo.Name = "txtSearchinfo";
            this.txtSearchinfo.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.txtSearchinfo.Size = new System.Drawing.SizeF(100F, 14F);
            this.txtSearchinfo.TabIndex = 2;
            this.txtSearchinfo.WaterMarkText = "搜索";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Black;
            this.btnSearch.BackColorAlpha = 0;
            this.btnSearch.FontSize = 4F;
            this.btnSearch.Location = new Smobiler.Core.PointS(104F, 5F);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ResourceID = "!\\ue8b6043146223";
            this.btnSearch.Size = new System.Drawing.SizeF(14F, 14F);
            this.btnSearch.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnSearch_Click);
            // 
            // GridView1
            // 
            this.GridView1.AllowSlip = true;
            this.GridView1.Layout = "frmMessageLayout";
            this.GridView1.Location = new Smobiler.Core.PointS(0F, 21F);
            this.GridView1.Name = "GridView1";
            this.GridView1.ShowGridLines = false;
            this.GridView1.Size = new System.Drawing.SizeF(120F, 163F);
            this.GridView1.TabIndex = 4;
            this.GridView1.CellClick += new Smobiler.Core.Controls.GridViewCellClickEventHandler(this.GridView1_CellClick);
            this.GridView1.UpSlippling += new System.EventHandler(this.GridView1_UpSlippling);
            this.GridView1.DownSlippling += new System.EventHandler(this.GridView1_DownSlippling);
            // 
            // tExit
            // 
            this.tExit.IconID = "Exit";
            this.tExit.Name = "tExit";
            this.tExit.Text = "返回";
            this.tExit.Visible = false;
            // 
            // Gps1
            // 
            this.Gps1.Name = "Gps1";
            this.Gps1.GotLocation += new Smobiler.Core.GpsCallBackHandler(this.Gps1_GotLocation);
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Label1.BackColorAlpha = 0;
            this.Label1.FontSize = 9F;
            this.Label1.ForeColor = System.Drawing.Color.Red;
            this.Label1.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.Label1.Location = new Smobiler.Core.PointS(2F, 68F);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.SizeF(120F, 15F);
            this.Label1.TabIndex = 9;
            this.Label1.Text = "目前暂时无任何消息";
            this.Label1.Visible = false;
            // 
            // frmMessage
            // 
            this.ComponentControls.AddRange(new Smobiler.Core.ComponentBase[] {
            this.Gps1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.txtSearchinfo,
            this.btnSearch,
            this.GridView1,
            this.Label1});
            this.ForeColor = System.Drawing.Color.White;
            this.LayoutMode = Smobiler.Core.FormLayoutMode.EFFACT3D;
            this.LeftFormLayout = "frmMenuLayout";
            this.StatusBarStyle = Smobiler.Core.StatusBarStyle.Default;
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("menu", System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(97)))), ((int)(((byte)(164))))), System.Drawing.Color.White);
            this.TitleText = "消息";
            this.Toolbar.AddRange(new Smobiler.Core.Controls.ToolbarItem[] {
            this.tExit});
            this.LeftLayoutItemClick += new Smobiler.Core.MobileFormLayoutItemClickEventHandler(this.frmMessage_LeftLayoutItemClick);
            this.Load += new System.EventHandler(this.frmMessage_Load);
            this.TitleImageClick += new System.EventHandler(this.frmMessage_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.MobileForm_KeyDown);

        }
        internal Smobiler.Core.Controls.TextBox txtSearchinfo;
        internal Smobiler.Core.Controls.ImageButton btnSearch;
        internal Smobiler.Core.Controls.GridView GridView1;
        internal Smobiler.Core.Controls.ToolbarItem tExit;
        internal Smobiler.Core.Controls.GPS Gps1;
        internal Smobiler.Core.Controls.Label Label1;
        #endregion

    }


}