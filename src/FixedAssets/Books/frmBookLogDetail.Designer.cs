using System;
using Smobiler.Core;
namespace COMSSmobilerDemo.FixedAssets.Books
{
    partial class frmBookLogDetail : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmBookLogDetail()
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
            this.lblBOOKLOGID = new Smobiler.Core.Controls.Label();
            this.Label2 = new Smobiler.Core.Controls.Label();
            this.lblBOOKSNID = new Smobiler.Core.Controls.Label();
            this.Label4 = new Smobiler.Core.Controls.Label();
            this.lblBOOKNAME = new Smobiler.Core.Controls.Label();
            this.Label6 = new Smobiler.Core.Controls.Label();
            this.lblBORROWER = new Smobiler.Core.Controls.Label();
            this.Label8 = new Smobiler.Core.Controls.Label();
            this.lblSTATUS = new Smobiler.Core.Controls.Label();
            this.Label10 = new Smobiler.Core.Controls.Label();
            this.lblENDDATE = new Smobiler.Core.Controls.Label();
            this.Label12 = new Smobiler.Core.Controls.Label();
            this.lblRETURNDATE = new Smobiler.Core.Controls.Label();
            this.Label14 = new Smobiler.Core.Controls.Label();
            this.lblLOSEDATE = new Smobiler.Core.Controls.Label();
            this.back = new Smobiler.Core.Controls.ToolbarItem();
            this.lose = new Smobiler.Core.Controls.ToolbarItem();
            this.Grade = new Smobiler.Core.Controls.ToolbarItem();
            this.Label3 = new Smobiler.Core.Controls.Label();
            this.RatingBar1 = new Smobiler.Core.Controls.RatingBar();
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
            this.Label1.Text = "借阅号";
            this.Label1.ZIndex = 1;
            // 
            // lblBOOKLOGID
            // 
            this.lblBOOKLOGID.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.lblBOOKLOGID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblBOOKLOGID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblBOOKLOGID.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblBOOKLOGID.Location = new System.Drawing.Point(88, 0);
            this.lblBOOKLOGID.Name = "lblBOOKLOGID";
            this.lblBOOKLOGID.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.lblBOOKLOGID.Size = new System.Drawing.Size(213, 35);
            this.lblBOOKLOGID.TabIndex = 3;
            this.lblBOOKLOGID.ZIndex = 2;
            // 
            // Label2
            // 
            this.Label2.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label2.Location = new System.Drawing.Point(0, 43);
            this.Label2.Name = "Label2";
            this.Label2.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label2.Size = new System.Drawing.Size(88, 35);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "图书序号";
            this.Label2.ZIndex = 3;
            // 
            // lblBOOKSNID
            // 
            this.lblBOOKSNID.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.lblBOOKSNID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblBOOKSNID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblBOOKSNID.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblBOOKSNID.Location = new System.Drawing.Point(88, 43);
            this.lblBOOKSNID.Name = "lblBOOKSNID";
            this.lblBOOKSNID.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.lblBOOKSNID.Size = new System.Drawing.Size(213, 35);
            this.lblBOOKSNID.TabIndex = 5;
            this.lblBOOKSNID.ZIndex = 4;
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
            this.Label4.Text = "图书名称";
            this.Label4.ZIndex = 5;
            // 
            // lblBOOKNAME
            // 
            this.lblBOOKNAME.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.lblBOOKNAME.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblBOOKNAME.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblBOOKNAME.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblBOOKNAME.Location = new System.Drawing.Point(88, 78);
            this.lblBOOKNAME.Name = "lblBOOKNAME";
            this.lblBOOKNAME.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.lblBOOKNAME.Size = new System.Drawing.Size(213, 35);
            this.lblBOOKNAME.TabIndex = 7;
            this.lblBOOKNAME.ZIndex = 6;
            // 
            // Label6
            // 
            this.Label6.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label6.Location = new System.Drawing.Point(0, 120);
            this.Label6.Name = "Label6";
            this.Label6.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label6.Size = new System.Drawing.Size(88, 35);
            this.Label6.TabIndex = 8;
            this.Label6.Text = "借阅者";
            this.Label6.ZIndex = 7;
            // 
            // lblBORROWER
            // 
            this.lblBORROWER.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.lblBORROWER.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblBORROWER.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblBORROWER.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblBORROWER.Location = new System.Drawing.Point(88, 120);
            this.lblBORROWER.Name = "lblBORROWER";
            this.lblBORROWER.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.lblBORROWER.Size = new System.Drawing.Size(213, 35);
            this.lblBORROWER.TabIndex = 9;
            this.lblBORROWER.ZIndex = 8;
            // 
            // Label8
            // 
            this.Label8.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label8.Location = new System.Drawing.Point(0, 155);
            this.Label8.Name = "Label8";
            this.Label8.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label8.Size = new System.Drawing.Size(88, 35);
            this.Label8.TabIndex = 10;
            this.Label8.Text = "状态";
            this.Label8.ZIndex = 9;
            // 
            // lblSTATUS
            // 
            this.lblSTATUS.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.lblSTATUS.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblSTATUS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblSTATUS.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblSTATUS.Location = new System.Drawing.Point(88, 155);
            this.lblSTATUS.Name = "lblSTATUS";
            this.lblSTATUS.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.lblSTATUS.Size = new System.Drawing.Size(213, 35);
            this.lblSTATUS.TabIndex = 11;
            this.lblSTATUS.ZIndex = 10;
            // 
            // Label10
            // 
            this.Label10.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label10.Location = new System.Drawing.Point(0, 198);
            this.Label10.Name = "Label10";
            this.Label10.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label10.Size = new System.Drawing.Size(88, 35);
            this.Label10.TabIndex = 12;
            this.Label10.Text = "借出日期";
            this.Label10.ZIndex = 11;
            // 
            // lblENDDATE
            // 
            this.lblENDDATE.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.lblENDDATE.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblENDDATE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblENDDATE.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblENDDATE.Location = new System.Drawing.Point(88, 198);
            this.lblENDDATE.Name = "lblENDDATE";
            this.lblENDDATE.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.lblENDDATE.Size = new System.Drawing.Size(213, 35);
            this.lblENDDATE.TabIndex = 13;
            this.lblENDDATE.ZIndex = 12;
            // 
            // Label12
            // 
            this.Label12.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label12.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label12.Location = new System.Drawing.Point(0, 233);
            this.Label12.Name = "Label12";
            this.Label12.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label12.Size = new System.Drawing.Size(88, 35);
            this.Label12.TabIndex = 14;
            this.Label12.Text = "归还日期";
            this.Label12.ZIndex = 13;
            // 
            // lblRETURNDATE
            // 
            this.lblRETURNDATE.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.lblRETURNDATE.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblRETURNDATE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblRETURNDATE.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblRETURNDATE.Location = new System.Drawing.Point(88, 233);
            this.lblRETURNDATE.Name = "lblRETURNDATE";
            this.lblRETURNDATE.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.lblRETURNDATE.Size = new System.Drawing.Size(213, 35);
            this.lblRETURNDATE.TabIndex = 15;
            this.lblRETURNDATE.ZIndex = 14;
            // 
            // Label14
            // 
            this.Label14.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label14.Location = new System.Drawing.Point(0, 268);
            this.Label14.Name = "Label14";
            this.Label14.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label14.Size = new System.Drawing.Size(88, 35);
            this.Label14.TabIndex = 16;
            this.Label14.Text = "遗失日期";
            this.Label14.ZIndex = 15;
            // 
            // lblLOSEDATE
            // 
            this.lblLOSEDATE.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.lblLOSEDATE.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblLOSEDATE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblLOSEDATE.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblLOSEDATE.Location = new System.Drawing.Point(88, 268);
            this.lblLOSEDATE.Name = "lblLOSEDATE";
            this.lblLOSEDATE.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.lblLOSEDATE.Size = new System.Drawing.Size(213, 35);
            this.lblLOSEDATE.TabIndex = 17;
            this.lblLOSEDATE.ZIndex = 16;
            // 
            // back
            // 
            this.back.Name = "back";
            this.back.Text = "归还";
            this.back.Visible = false;
            // 
            // lose
            // 
            this.lose.Name = "lose";
            this.lose.Text = "遗失";
            this.lose.Visible = false;
            // 
            // Grade
            // 
            this.Grade.Name = "Grade";
            this.Grade.Text = "评分";
            // 
            // Label3
            // 
            this.Label3.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label3.Location = new System.Drawing.Point(0, 310);
            this.Label3.Name = "Label3";
            this.Label3.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label3.Size = new System.Drawing.Size(88, 35);
            this.Label3.TabIndex = 18;
            this.Label3.Text = "书籍评分";
            this.Label3.ZIndex = 7;
            // 
            // RatingBar1
            // 
            this.RatingBar1.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.RatingBar1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.RatingBar1.Location = new System.Drawing.Point(88, 310);
            this.RatingBar1.Name = "RatingBar1";
            this.RatingBar1.Size = new System.Drawing.Size(213, 35);
            this.RatingBar1.TabIndex = 19;
            // 
            // frmBookLogDetail
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label1,
            this.lblBOOKLOGID,
            this.Label2,
            this.lblBOOKSNID,
            this.Label4,
            this.lblBOOKNAME,
            this.Label6,
            this.lblBORROWER,
            this.Label8,
            this.lblSTATUS,
            this.Label10,
            this.lblENDDATE,
            this.Label12,
            this.lblRETURNDATE,
            this.Label14,
            this.lblLOSEDATE,
            this.Label3,
            this.RatingBar1});
            this.StatusBarStyle = Smobiler.Core.StatusBarStyle.Default;
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("Exit", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(50))))));
            this.TitleText = "图书借阅记录详情";
            this.Toolbar.AddRange(new Smobiler.Core.Controls.ToolbarItem[] {
            this.back,
            this.lose,
            this.Grade});
            this.ToolbarStyle = new Smobiler.Core.ToolBarSytle(Smobiler.Core.ToolbarSelectStyle.None, System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))), System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))));
            this.Load += new System.EventHandler(this.frmBookLogDetail_Load);
            this.ToolbarItemClick += new Smobiler.Core.ToolbarItemClickEventHandler(this.frmBookLogDetail_ToolbarItemClick);
            this.TitleImageClick += new System.EventHandler(this.frmBookLogDetail_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.frmBookLogDetail_KeyDown);
            this.Name = "frmBookLogDetail";

        }
        internal Smobiler.Core.Controls.Label Label1;
        internal Smobiler.Core.Controls.Label lblBOOKLOGID;
        internal Smobiler.Core.Controls.Label Label2;
        internal Smobiler.Core.Controls.Label lblBOOKSNID;
        internal Smobiler.Core.Controls.Label Label4;
        internal Smobiler.Core.Controls.Label lblBOOKNAME;
        internal Smobiler.Core.Controls.Label Label6;
        internal Smobiler.Core.Controls.Label lblBORROWER;
        internal Smobiler.Core.Controls.Label Label8;
        internal Smobiler.Core.Controls.Label lblSTATUS;
        internal Smobiler.Core.Controls.Label Label10;
        internal Smobiler.Core.Controls.Label lblENDDATE;
        internal Smobiler.Core.Controls.Label Label12;
        internal Smobiler.Core.Controls.Label lblRETURNDATE;
        internal Smobiler.Core.Controls.Label Label14;
        internal Smobiler.Core.Controls.Label lblLOSEDATE;
        internal Smobiler.Core.Controls.ToolbarItem back;
        internal Smobiler.Core.Controls.ToolbarItem lose;
        internal Smobiler.Core.Controls.ToolbarItem Grade;
        internal Smobiler.Core.Controls.Label Label3;
        internal Smobiler.Core.Controls.RatingBar RatingBar1;

        #endregion
    }
}
