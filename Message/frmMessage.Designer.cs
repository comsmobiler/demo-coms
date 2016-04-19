using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
namespace COMSSmobilerDemo.Message
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
            this.RB = new Smobiler.Core.Controls.ToolbarItem();
            this.Message = new Smobiler.Core.Controls.ToolbarItem();
            this.tExit = new Smobiler.Core.Controls.ToolbarItem();
            this.Other = new Smobiler.Core.Controls.ToolbarItem();
            this.lbldatetime = new Smobiler.Core.Controls.Label();
            this.Image3 = new Smobiler.Core.Controls.Image();
            this.LblGps = new Smobiler.Core.Controls.Label();
            this.lblweather = new Smobiler.Core.Controls.Label();
            this.Gps1 = new Smobiler.Core.Controls.GPS();
            // 
            // txtSearchinfo
            // 
            this.txtSearchinfo.Border = new Smobiler.Core.Border(1);
            this.txtSearchinfo.BorderColor = System.Drawing.Color.DarkGray;
            this.txtSearchinfo.BorderRadius = 2;
            this.txtSearchinfo.Location = new Smobiler.Core.PointS(1F, 14F);
            this.txtSearchinfo.Name = "txtSearchinfo";
            this.txtSearchinfo.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.txtSearchinfo.Size = new System.Drawing.SizeF(100F, 10F);
            this.txtSearchinfo.TabIndex = 2;
            this.txtSearchinfo.WaterMarkText = "消息搜索";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Black;
            this.btnSearch.BackColorAlpha = 0;
            this.btnSearch.FontSize = 4F;
            this.btnSearch.Location = new Smobiler.Core.PointS(104F, 14F);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ResourceID = "Search1";
            this.btnSearch.Size = new System.Drawing.SizeF(10F, 10F);
            this.btnSearch.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnSearch_Click);
            // 
            // GridView1
            // 
            this.GridView1.AllowSlip = true;
            this.GridView1.Layout = "frmMessageLayout";
            this.GridView1.Location = new Smobiler.Core.PointS(0F, 26F);
            this.GridView1.Name = "GridView1";
            this.GridView1.Size = new System.Drawing.SizeF(120F, 163F);
            this.GridView1.TabIndex = 4;
            this.GridView1.CellClick += new Smobiler.Core.Controls.GridViewCellClickEventHandler(this.GridView1_CellClick);
            this.GridView1.UpSlippling += new System.EventHandler(this.GridView1_UpSlippling);
            this.GridView1.DownSlippling += new System.EventHandler(this.GridView1_DownSlippling);
            // 
            // RB
            // 
            this.RB.IconID = "COMS";
            this.RB.Name = "RB";
            this.RB.Text = "报销";
            // 
            // Message
            // 
            this.Message.IconID = "Message1";
            this.Message.Name = "Message";
            this.Message.Text = "消息";
            // 
            // tExit
            // 
            this.tExit.IconID = "Exit";
            this.tExit.Name = "tExit";
            this.tExit.Text = "返回";
            // 
            // Other
            // 
            this.Other.IconID = "Other";
            this.Other.Name = "Other";
            this.Other.Text = "其他";
            // 
            // lbldatetime
            // 
            this.lbldatetime.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lbldatetime.FontSize = 4F;
            this.lbldatetime.ForeColor = System.Drawing.Color.White;
            this.lbldatetime.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.lbldatetime.Name = "lbldatetime";
            this.lbldatetime.Size = new System.Drawing.SizeF(120F, 6F);
            this.lbldatetime.TabIndex = 5;
            // 
            // Image3
            // 
            this.Image3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Image3.Location = new Smobiler.Core.PointS(0F, 6F);
            this.Image3.Name = "Image3";
            this.Image3.ResourceID = "GPSD";
            this.Image3.Size = new System.Drawing.SizeF(10F, 6F);
            this.Image3.TabIndex = 6;
            // 
            // LblGps
            // 
            this.LblGps.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.LblGps.FontSize = 4F;
            this.LblGps.ForeColor = System.Drawing.Color.White;
            this.LblGps.Location = new Smobiler.Core.PointS(10F, 6F);
            this.LblGps.Name = "LblGps";
            this.LblGps.Size = new System.Drawing.SizeF(62F, 6F);
            this.LblGps.TabIndex = 7;
            // 
            // lblweather
            // 
            this.lblweather.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblweather.FontSize = 4F;
            this.lblweather.ForeColor = System.Drawing.Color.White;
            this.lblweather.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblweather.Location = new Smobiler.Core.PointS(72F, 6F);
            this.lblweather.Name = "lblweather";
            this.lblweather.Size = new System.Drawing.SizeF(48F, 6F);
            this.lblweather.TabIndex = 8;
            // 
            // Gps1
            // 
            this.Gps1.Name = "Gps1";
            this.Gps1.GotLocation += new Smobiler.Core.GpsCallBackHandler(this.Gps1_GotLocation);
            // 
            // frmMessage
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ComponentControls.AddRange(new Smobiler.Core.ComponentBase[] {
            this.Gps1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.txtSearchinfo,
            this.btnSearch,
            this.GridView1,
            this.lbldatetime,
            this.Image3,
            this.LblGps,
            this.lblweather});
            this.ForeColor = System.Drawing.Color.White;
            this.LeftFormLayout = "frmMainLeftLayout";
            this.TitleBackColor = System.Drawing.Color.DeepSkyBlue;
            this.TitleImage = "iconfont-menu";
            this.TitleText = "消息";
            this.Toolbar.AddRange(new Smobiler.Core.Controls.ToolbarItem[] {
            this.tExit,
            this.Message,
            this.RB,
            this.Other});
            this.LeftLayoutItemClick += new Smobiler.Core.MobileFormLayoutItemClickEventHandler(this.frmMessage_LeftLayoutItemClick);
            this.Load += new System.EventHandler(this.frmMessage_Load);
            this.ToolbarItemClick += new Smobiler.Core.ToolbarItemClickEventHandler(this.frmMessage_ToolbarItemClick);

        }
        internal Smobiler.Core.Controls.TextBox txtSearchinfo;
        internal Smobiler.Core.Controls.ImageButton btnSearch;
        internal Smobiler.Core.Controls.GridView GridView1;
        internal Smobiler.Core.Controls.ToolbarItem RB;
        internal Smobiler.Core.Controls.ToolbarItem Message;
        internal Smobiler.Core.Controls.ToolbarItem tExit;
        internal Smobiler.Core.Controls.ToolbarItem Other;
        internal Smobiler.Core.Controls.Label lbldatetime;
        internal Smobiler.Core.Controls.Image Image3;
        internal Smobiler.Core.Controls.Label LblGps;
        internal Smobiler.Core.Controls.Label lblweather;

        internal Smobiler.Core.Controls.GPS Gps1;
        #endregion

    }


}