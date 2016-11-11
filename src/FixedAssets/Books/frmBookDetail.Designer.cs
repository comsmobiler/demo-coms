using System;
using Smobiler.Core;
namespace COMSSmobilerDemo.FixedAssets.Books
{
    partial class frmBookDetail : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmBookDetail()
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
            this.Label1 = new Smobiler.Core.Controls.Label();
            this.lblBOOKNAME = new Smobiler.Core.Controls.Label();
            this.Label2 = new Smobiler.Core.Controls.Label();
            this.lblBOOKQUANTITY = new Smobiler.Core.Controls.Label();
            this.Label4 = new Smobiler.Core.Controls.Label();
            this.lblBOOKUNITPRICE = new Smobiler.Core.Controls.Label();
            this.Label6 = new Smobiler.Core.Controls.Label();
            this.lblBOOKLOADSTOCK = new Smobiler.Core.Controls.Label();
            this.Label8 = new Smobiler.Core.Controls.Label();
            this.lblBOOKLOSEQTY = new Smobiler.Core.Controls.Label();
            this.Label10 = new Smobiler.Core.Controls.Label();
            this.Label11 = new Smobiler.Core.Controls.Label();
            this.lblAmount = new Smobiler.Core.Controls.Label();
            this.lblBOOKPUBLIDATE = new Smobiler.Core.Controls.Label();
            this.lblBOOKBORROWQTY = new Smobiler.Core.Controls.Label();
            this.Label15 = new Smobiler.Core.Controls.Label();
            this.Label16 = new Smobiler.Core.Controls.Label();
            this.GridView1 = new Smobiler.Core.Controls.GridView();
            this.Edit = new Smobiler.Core.Controls.ToolbarItem();
            this.Record = new Smobiler.Core.Controls.ToolbarItem();
            // 
            // Label1
            // 
            this.Label1.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label1.Name = "Label1";
            this.Label1.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label1.Size = new System.Drawing.Size(88, 35);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "图书名称";
            this.Label1.ZIndex = 1;
            // 
            // lblBOOKNAME
            // 
            this.lblBOOKNAME.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.lblBOOKNAME.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblBOOKNAME.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblBOOKNAME.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblBOOKNAME.Location = new System.Drawing.Point(88, 0);
            this.lblBOOKNAME.Name = "lblBOOKNAME";
            this.lblBOOKNAME.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.lblBOOKNAME.Size = new System.Drawing.Size(213, 35);
            this.lblBOOKNAME.TabIndex = 3;
            this.lblBOOKNAME.ZIndex = 2;
            // 
            // Label2
            // 
            this.Label2.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label2.Location = new System.Drawing.Point(0, 43);
            this.Label2.Name = "Label2";
            this.Label2.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label2.Size = new System.Drawing.Size(88, 35);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "库存数量";
            this.Label2.ZIndex = 1;
            // 
            // lblBOOKQUANTITY
            // 
            this.lblBOOKQUANTITY.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.lblBOOKQUANTITY.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblBOOKQUANTITY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblBOOKQUANTITY.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblBOOKQUANTITY.Location = new System.Drawing.Point(88, 43);
            this.lblBOOKQUANTITY.Name = "lblBOOKQUANTITY";
            this.lblBOOKQUANTITY.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.lblBOOKQUANTITY.Size = new System.Drawing.Size(213, 35);
            this.lblBOOKQUANTITY.TabIndex = 5;
            this.lblBOOKQUANTITY.ZIndex = 2;
            // 
            // Label4
            // 
            this.Label4.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label4.Location = new System.Drawing.Point(0, 78);
            this.Label4.Name = "Label4";
            this.Label4.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label4.Size = new System.Drawing.Size(88, 35);
            this.Label4.TabIndex = 6;
            this.Label4.Text = "单价";
            this.Label4.ZIndex = 1;
            // 
            // lblBOOKUNITPRICE
            // 
            this.lblBOOKUNITPRICE.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.lblBOOKUNITPRICE.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblBOOKUNITPRICE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblBOOKUNITPRICE.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblBOOKUNITPRICE.Location = new System.Drawing.Point(88, 78);
            this.lblBOOKUNITPRICE.Name = "lblBOOKUNITPRICE";
            this.lblBOOKUNITPRICE.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.lblBOOKUNITPRICE.Size = new System.Drawing.Size(213, 35);
            this.lblBOOKUNITPRICE.TabIndex = 7;
            this.lblBOOKUNITPRICE.ZIndex = 2;
            // 
            // Label6
            // 
            this.Label6.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label6.Location = new System.Drawing.Point(0, 113);
            this.Label6.Name = "Label6";
            this.Label6.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label6.Size = new System.Drawing.Size(88, 35);
            this.Label6.TabIndex = 8;
            this.Label6.Text = "借出数量";
            this.Label6.ZIndex = 1;
            // 
            // lblBOOKLOADSTOCK
            // 
            this.lblBOOKLOADSTOCK.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.lblBOOKLOADSTOCK.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblBOOKLOADSTOCK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblBOOKLOADSTOCK.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblBOOKLOADSTOCK.Location = new System.Drawing.Point(88, 113);
            this.lblBOOKLOADSTOCK.Name = "lblBOOKLOADSTOCK";
            this.lblBOOKLOADSTOCK.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.lblBOOKLOADSTOCK.Size = new System.Drawing.Size(213, 35);
            this.lblBOOKLOADSTOCK.TabIndex = 9;
            this.lblBOOKLOADSTOCK.ZIndex = 2;
            // 
            // Label8
            // 
            this.Label8.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label8.Location = new System.Drawing.Point(0, 148);
            this.Label8.Name = "Label8";
            this.Label8.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label8.Size = new System.Drawing.Size(88, 35);
            this.Label8.TabIndex = 10;
            this.Label8.Text = "遗失数量";
            this.Label8.ZIndex = 1;
            // 
            // lblBOOKLOSEQTY
            // 
            this.lblBOOKLOSEQTY.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.lblBOOKLOSEQTY.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblBOOKLOSEQTY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblBOOKLOSEQTY.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblBOOKLOSEQTY.Location = new System.Drawing.Point(88, 148);
            this.lblBOOKLOSEQTY.Name = "lblBOOKLOSEQTY";
            this.lblBOOKLOSEQTY.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.lblBOOKLOSEQTY.Size = new System.Drawing.Size(213, 35);
            this.lblBOOKLOSEQTY.TabIndex = 11;
            this.lblBOOKLOSEQTY.ZIndex = 2;
            // 
            // Label10
            // 
            this.Label10.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label10.Location = new System.Drawing.Point(0, 230);
            this.Label10.Name = "Label10";
            this.Label10.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label10.Size = new System.Drawing.Size(88, 35);
            this.Label10.TabIndex = 12;
            this.Label10.Text = "购买时间";
            this.Label10.ZIndex = 16;
            // 
            // Label11
            // 
            this.Label11.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label11.Location = new System.Drawing.Point(0, 183);
            this.Label11.Name = "Label11";
            this.Label11.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label11.Size = new System.Drawing.Size(88, 35);
            this.Label11.TabIndex = 13;
            this.Label11.Text = "总金额";
            this.Label11.ZIndex = 1;
            // 
            // lblAmount
            // 
            this.lblAmount.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.lblAmount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblAmount.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblAmount.Location = new System.Drawing.Point(88, 183);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.lblAmount.Size = new System.Drawing.Size(213, 35);
            this.lblAmount.TabIndex = 14;
            this.lblAmount.ZIndex = 2;
            // 
            // lblBOOKPUBLIDATE
            // 
            this.lblBOOKPUBLIDATE.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.lblBOOKPUBLIDATE.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblBOOKPUBLIDATE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblBOOKPUBLIDATE.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblBOOKPUBLIDATE.Location = new System.Drawing.Point(88, 230);
            this.lblBOOKPUBLIDATE.Name = "lblBOOKPUBLIDATE";
            this.lblBOOKPUBLIDATE.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.lblBOOKPUBLIDATE.Size = new System.Drawing.Size(213, 35);
            this.lblBOOKPUBLIDATE.TabIndex = 15;
            this.lblBOOKPUBLIDATE.ZIndex = 2;
            // 
            // lblBOOKBORROWQTY
            // 
            this.lblBOOKBORROWQTY.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.lblBOOKBORROWQTY.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblBOOKBORROWQTY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblBOOKBORROWQTY.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblBOOKBORROWQTY.Location = new System.Drawing.Point(88, 265);
            this.lblBOOKBORROWQTY.Name = "lblBOOKBORROWQTY";
            this.lblBOOKBORROWQTY.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.lblBOOKBORROWQTY.Size = new System.Drawing.Size(213, 35);
            this.lblBOOKBORROWQTY.TabIndex = 16;
            this.lblBOOKBORROWQTY.ZIndex = 2;
            // 
            // Label15
            // 
            this.Label15.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label15.Location = new System.Drawing.Point(0, 265);
            this.Label15.Name = "Label15";
            this.Label15.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label15.Size = new System.Drawing.Size(88, 35);
            this.Label15.TabIndex = 17;
            this.Label15.Text = "借阅数";
            this.Label15.ZIndex = 1;
            // 
            // Label16
            // 
            this.Label16.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label16.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label16.Location = new System.Drawing.Point(0, 300);
            this.Label16.Name = "Label16";
            this.Label16.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label16.Size = new System.Drawing.Size(300, 35);
            this.Label16.TabIndex = 18;
            this.Label16.Text = "图片";
            this.Label16.ZIndex = 20;
            // 
            // GridView1
            // 
            this.GridView1.AllowSlip = true;
            this.GridView1.AutoHeight = false;
            this.GridView1.Layout = "frmBookSNLayout";
            this.GridView1.Location = new System.Drawing.Point(0, 335);
            this.GridView1.Name = "GridView1";
            this.GridView1.PageSize = 5;
            this.GridView1.ShowGridLines = false;
            this.GridView1.Size = new System.Drawing.Size(300, 285);
            this.GridView1.TabIndex = 19;
            // 
            // Edit
            // 
            this.Edit.IconID = "!\\ue22b043146223";
            this.Edit.Name = "Edit";
            this.Edit.SelectIconID = "!\\ue22b043146223";
            this.Edit.Text = "编辑";
            // 
            // Record
            // 
            this.Record.Name = "Record";
            this.Record.Text = "借阅";
            // 
            // frmBookDetail
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label1,
            this.Label2,
            this.Label4,
            this.Label6,
            this.Label8,
            this.Label11,
            this.Label15,
            this.lblBOOKNAME,
            this.lblBOOKQUANTITY,
            this.lblBOOKUNITPRICE,
            this.lblBOOKLOADSTOCK,
            this.lblBOOKLOSEQTY,
            this.lblAmount,
            this.lblBOOKPUBLIDATE,
            this.lblBOOKBORROWQTY,
            this.Label10,
            this.Label16,
            this.GridView1});
            this.Size = new System.Drawing.Size(300, 625);
            this.StatusBarStyle = Smobiler.Core.StatusBarStyle.Default;
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("Exit", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(50))))));
            this.TitleText = "图书详情";
            this.Toolbar.AddRange(new Smobiler.Core.Controls.ToolbarItem[] {
            this.Edit,
            this.Record});
            this.ToolbarStyle = new Smobiler.Core.ToolBarSytle(Smobiler.Core.ToolbarSelectStyle.None, System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))), System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))));
            this.Load += new System.EventHandler(this.frmBookDetail_Load);
            this.ToolbarItemClick += new Smobiler.Core.ToolbarItemClickEventHandler(this.frmBookDetail_ToolbarItemClick);
            this.TitleImageClick += new System.EventHandler(this.frmBookDetail_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.frmBookDetail_KeyDown);
            this.Name = "frmBookDetail";

        }
        internal Smobiler.Core.Controls.Label Label1;
        internal Smobiler.Core.Controls.Label lblBOOKNAME;
        internal Smobiler.Core.Controls.Label Label2;
        internal Smobiler.Core.Controls.Label lblBOOKQUANTITY;
        internal Smobiler.Core.Controls.Label Label4;
        internal Smobiler.Core.Controls.Label lblBOOKUNITPRICE;
        internal Smobiler.Core.Controls.Label Label6;
        internal Smobiler.Core.Controls.Label lblBOOKLOADSTOCK;
        internal Smobiler.Core.Controls.Label Label8;
        internal Smobiler.Core.Controls.Label lblBOOKLOSEQTY;
        internal Smobiler.Core.Controls.Label Label10;
        internal Smobiler.Core.Controls.Label Label11;
        internal Smobiler.Core.Controls.Label lblAmount;
        internal Smobiler.Core.Controls.Label lblBOOKPUBLIDATE;
        internal Smobiler.Core.Controls.Label lblBOOKBORROWQTY;
        internal Smobiler.Core.Controls.Label Label15;
        internal Smobiler.Core.Controls.Label Label16;
        internal Smobiler.Core.Controls.GridView GridView1;
        internal Smobiler.Core.Controls.ToolbarItem Edit;
        internal Smobiler.Core.Controls.ToolbarItem Record;

        #endregion
    }
}
