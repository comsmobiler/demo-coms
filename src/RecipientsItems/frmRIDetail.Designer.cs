using System;
using Smobiler.Core;
namespace COMSSmobilerDemo.RecipientsItems
{
    partial class frmRIDetail : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmRIDetail()
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
            this.lblITEM_NAME = new Smobiler.Core.Controls.Label();
            this.Label2 = new Smobiler.Core.Controls.Label();
            this.lblITEM_QTY = new Smobiler.Core.Controls.Label();
            this.Label3 = new Smobiler.Core.Controls.Label();
            this.lblITEM_DATE = new Smobiler.Core.Controls.Label();
            this.Label4 = new Smobiler.Core.Controls.Label();
            this.lblITEM_USER = new Smobiler.Core.Controls.Label();
            this.Label5 = new Smobiler.Core.Controls.Label();
            this.lblITEM_NOTE = new Smobiler.Core.Controls.Label();
            this.Label6 = new Smobiler.Core.Controls.Label();
            this.imgITEM_SIGNATURE = new Smobiler.Core.Controls.Image();
            // 
            // Label1
            // 
            this.Label1.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label1.Name = "Label1";
            this.Label1.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label1.Size = new System.Drawing.Size(70,28);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "物品名称";
            this.Label1.ZIndex = 1;
            // 
            // lblITEM_NAME
            // 
            this.lblITEM_NAME.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.lblITEM_NAME.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblITEM_NAME.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.lblITEM_NAME.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblITEM_NAME.Location = new System.Drawing.Point(70,0);
            this.lblITEM_NAME.Name = "lblITEM_NAME";
            this.lblITEM_NAME.Padding = new Smobiler.Core.Padding(0F, 0F, 12F, 0F);
            this.lblITEM_NAME.Size = new System.Drawing.Size(170,28);
            this.lblITEM_NAME.TabIndex = 3;
            this.lblITEM_NAME.ZIndex = 2;
            // 
            // Label2
            // 
            this.Label2.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label2.Location = new System.Drawing.Point(0,28);
            this.Label2.Name = "Label2";
            this.Label2.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label2.Size = new System.Drawing.Size(70,28);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "物品数量";
            this.Label2.ZIndex = 3;
            // 
            // lblITEM_QTY
            // 
            this.lblITEM_QTY.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.lblITEM_QTY.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblITEM_QTY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.lblITEM_QTY.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblITEM_QTY.Location = new System.Drawing.Point(70,28);
            this.lblITEM_QTY.Name = "lblITEM_QTY";
            this.lblITEM_QTY.Padding = new Smobiler.Core.Padding(0F, 0F, 12F, 0F);
            this.lblITEM_QTY.Size = new System.Drawing.Size(170,28);
            this.lblITEM_QTY.TabIndex = 5;
            this.lblITEM_QTY.ZIndex = 4;
            // 
            // Label3
            // 
            this.Label3.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label3.Location = new System.Drawing.Point(0,62);
            this.Label3.Name = "Label3";
            this.Label3.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label3.Size = new System.Drawing.Size(70,28);
            this.Label3.TabIndex = 6;
            this.Label3.Text = "领用时间";
            this.Label3.ZIndex = 5;
            // 
            // lblITEM_DATE
            // 
            this.lblITEM_DATE.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.lblITEM_DATE.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblITEM_DATE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.lblITEM_DATE.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblITEM_DATE.Location = new System.Drawing.Point(70,62);
            this.lblITEM_DATE.Name = "lblITEM_DATE";
            this.lblITEM_DATE.Padding = new Smobiler.Core.Padding(0F, 0F, 12F, 0F);
            this.lblITEM_DATE.Size = new System.Drawing.Size(170,28);
            this.lblITEM_DATE.TabIndex = 7;
            this.lblITEM_DATE.ZIndex = 6;
            // 
            // Label4
            // 
            this.Label4.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label4.Location = new System.Drawing.Point(0,90);
            this.Label4.Name = "Label4";
            this.Label4.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label4.Size = new System.Drawing.Size(70,28);
            this.Label4.TabIndex = 8;
            this.Label4.Text = "领用人";
            this.Label4.ZIndex = 7;
            // 
            // lblITEM_USER
            // 
            this.lblITEM_USER.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.lblITEM_USER.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblITEM_USER.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.lblITEM_USER.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblITEM_USER.Location = new System.Drawing.Point(70,90);
            this.lblITEM_USER.Name = "lblITEM_USER";
            this.lblITEM_USER.Padding = new Smobiler.Core.Padding(0F, 0F, 12F, 0F);
            this.lblITEM_USER.Size = new System.Drawing.Size(170,28);
            this.lblITEM_USER.TabIndex = 9;
            this.lblITEM_USER.ZIndex = 8;
            // 
            // Label5
            // 
            this.Label5.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label5.Location = new System.Drawing.Point(0,124);
            this.Label5.Name = "Label5";
            this.Label5.Padding = new Smobiler.Core.Padding(2F, 5F, 0F, 0F);
            this.Label5.Size = new System.Drawing.Size(70,80);
            this.Label5.TabIndex = 10;
            this.Label5.Text = "备注";
            this.Label5.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            // 
            // lblITEM_NOTE
            // 
            this.lblITEM_NOTE.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.lblITEM_NOTE.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblITEM_NOTE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.lblITEM_NOTE.Location = new System.Drawing.Point(70,124);
            this.lblITEM_NOTE.Name = "lblITEM_NOTE";
            this.lblITEM_NOTE.Padding = new Smobiler.Core.Padding(0F, 5F, 12F, 0F);
            this.lblITEM_NOTE.Size = new System.Drawing.Size(170,80);
            this.lblITEM_NOTE.TabIndex = 11;
            // 
            // Label6
            // 
            this.Label6.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label6.Location = new System.Drawing.Point(0,210);
            this.Label6.Name = "Label6";
            this.Label6.Padding = new Smobiler.Core.Padding(2F, 5F, 0F, 0F);
            this.Label6.Size = new System.Drawing.Size(70,80);
            this.Label6.TabIndex = 12;
            this.Label6.Text = "领用人签名";
            this.Label6.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            // 
            // imgITEM_SIGNATURE
            // 
            this.imgITEM_SIGNATURE.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.imgITEM_SIGNATURE.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.imgITEM_SIGNATURE.ID = "";
            this.imgITEM_SIGNATURE.Location = new System.Drawing.Point(70,210);
            this.imgITEM_SIGNATURE.Name = "imgITEM_SIGNATURE";
            this.imgITEM_SIGNATURE.Padding = new Smobiler.Core.Padding(0F, 0F, 12F, 0F);
            this.imgITEM_SIGNATURE.Size = new System.Drawing.Size(170,80);
            this.imgITEM_SIGNATURE.TabIndex = 13;
            // 
            // frmRIDetail
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label1,
            this.lblITEM_NAME,
            this.Label2,
            this.lblITEM_QTY,
            this.Label3,
            this.lblITEM_DATE,
            this.Label4,
            this.lblITEM_USER,
            this.Label5,
            this.lblITEM_NOTE,
            this.Label6,
            this.imgITEM_SIGNATURE});
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("Exit", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(50))))));
            this.TitleText = "物品领用详情";
            this.ToolbarStyle = new Smobiler.Core.ToolBarSytle(Smobiler.Core.ToolbarSelectStyle.None, System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))), System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))));
            this.Load += new System.EventHandler(this.frmRIDetail_Load);
            this.TitleImageClick += new System.EventHandler(this.frmRIDetail_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.frmRIDetail_KeyDown);
            this.Name = "frmRIDetail";

        }
        internal Smobiler.Core.Controls.Label Label1;
        internal Smobiler.Core.Controls.Label lblITEM_NAME;
        internal Smobiler.Core.Controls.Label Label2;
        internal Smobiler.Core.Controls.Label lblITEM_QTY;
        internal Smobiler.Core.Controls.Label Label3;
        internal Smobiler.Core.Controls.Label lblITEM_DATE;
        internal Smobiler.Core.Controls.Label Label4;
        internal Smobiler.Core.Controls.Label lblITEM_USER;
        internal Smobiler.Core.Controls.Label Label5;
        internal Smobiler.Core.Controls.Label lblITEM_NOTE;
        internal Smobiler.Core.Controls.Label Label6;
        internal Smobiler.Core.Controls.Image imgITEM_SIGNATURE;
        #endregion
    }
}
