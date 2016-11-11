using System;
using Smobiler.Core;
namespace COMSSmobilerDemo.FixedAssets.NootBooks
{
    partial class frmNBRecordCreate : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmNBRecordCreate()
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
            this.txtNB_EQNO = new Smobiler.Core.Controls.TextBox();
            this.btnCODE2 = new Smobiler.Core.Controls.Button();
            this.btnUser = new Smobiler.Core.Controls.Button();
            this.btnUser2 = new Smobiler.Core.Controls.Button();
            this.Label8 = new Smobiler.Core.Controls.Label();
            this.Label2 = new Smobiler.Core.Controls.Label();
            this.btnType = new Smobiler.Core.Controls.Button();
            this.btnType2 = new Smobiler.Core.Controls.Button();
            this.Label3 = new Smobiler.Core.Controls.Label();
            this.dpkNBR_ODATE = new Smobiler.Core.Controls.DatePicker();
            this.Label4 = new Smobiler.Core.Controls.Label();
            this.save = new Smobiler.Core.Controls.ToolbarItem();
            this.PopList1 = new Smobiler.Core.Controls.PopList();
            this.btnNBR_LOCATION = new Smobiler.Core.Controls.Button();
            this.btnNBR_LOCATION2 = new Smobiler.Core.Controls.Button();
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
            this.Label1.Text = "设备编号";
            this.Label1.ZIndex = 1;
            // 
            // txtNB_EQNO
            // 
            this.txtNB_EQNO.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.txtNB_EQNO.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtNB_EQNO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txtNB_EQNO.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.txtNB_EQNO.Location = new System.Drawing.Point(88, 0);
            this.txtNB_EQNO.Name = "txtNB_EQNO";
            this.txtNB_EQNO.Padding = new Smobiler.Core.Padding(0F, 0F, 2F, 0F);
            this.txtNB_EQNO.Size = new System.Drawing.Size(187, 35);
            this.txtNB_EQNO.TabIndex = 3;
            this.txtNB_EQNO.WaterMarkText = "（必填）";
            this.txtNB_EQNO.ZIndex = 2;
            // 
            // btnCODE2
            // 
            this.btnCODE2.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.btnCODE2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnCODE2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnCODE2.Location = new System.Drawing.Point(275, 0);
            this.btnCODE2.Name = "btnCODE2";
            this.btnCODE2.Size = new System.Drawing.Size(25, 35);
            this.btnCODE2.TabIndex = 4;
            this.btnCODE2.Text = ">";
            this.btnCODE2.ZIndex = 29;
            this.btnCODE2.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnpop_Click);
            // 
            // btnUser
            // 
            this.btnUser.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.btnUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnUser.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnUser.Location = new System.Drawing.Point(88, 43);
            this.btnUser.Name = "btnUser";
            this.btnUser.Padding = new Smobiler.Core.Padding(0F, 0F, 5F, 0F);
            this.btnUser.Size = new System.Drawing.Size(188, 35);
            this.btnUser.TabIndex = 6;
            this.btnUser.ZIndex = 18;
            // 
            // btnUser2
            // 
            this.btnUser2.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.btnUser2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnUser2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnUser2.Location = new System.Drawing.Point(275, 43);
            this.btnUser2.Name = "btnUser2";
            this.btnUser2.Size = new System.Drawing.Size(25, 35);
            this.btnUser2.TabIndex = 7;
            this.btnUser2.Text = ">";
            this.btnUser2.ZIndex = 19;
            this.btnUser2.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnpop_Click);
            // 
            // Label8
            // 
            this.Label8.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label8.Location = new System.Drawing.Point(0, 43);
            this.Label8.Name = "Label8";
            this.Label8.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label8.Size = new System.Drawing.Size(88, 35);
            this.Label8.TabIndex = 8;
            this.Label8.Text = "用户";
            this.Label8.ZIndex = 17;
            // 
            // Label2
            // 
            this.Label2.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label2.Location = new System.Drawing.Point(0, 78);
            this.Label2.Name = "Label2";
            this.Label2.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label2.Size = new System.Drawing.Size(88, 35);
            this.Label2.TabIndex = 9;
            this.Label2.Text = "操作类型";
            this.Label2.ZIndex = 17;
            // 
            // btnType
            // 
            this.btnType.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.btnType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnType.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnType.Location = new System.Drawing.Point(88, 78);
            this.btnType.Name = "btnType";
            this.btnType.Padding = new Smobiler.Core.Padding(0F, 0F, 5F, 0F);
            this.btnType.Size = new System.Drawing.Size(188, 35);
            this.btnType.TabIndex = 10;
            this.btnType.Text = "开始使用";
            this.btnType.ZIndex = 18;
            // 
            // btnType2
            // 
            this.btnType2.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.btnType2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnType2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnType2.Location = new System.Drawing.Point(275, 78);
            this.btnType2.Name = "btnType2";
            this.btnType2.Size = new System.Drawing.Size(25, 35);
            this.btnType2.TabIndex = 11;
            this.btnType2.Text = ">";
            this.btnType2.ZIndex = 19;
            this.btnType2.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnpop_Click);
            // 
            // Label3
            // 
            this.Label3.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label3.Location = new System.Drawing.Point(0, 113);
            this.Label3.Name = "Label3";
            this.Label3.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label3.Size = new System.Drawing.Size(88, 35);
            this.Label3.TabIndex = 12;
            this.Label3.Text = "操作时间";
            this.Label3.ZIndex = 17;
            // 
            // dpkNBR_ODATE
            // 
            this.dpkNBR_ODATE.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.dpkNBR_ODATE.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dpkNBR_ODATE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.dpkNBR_ODATE.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.dpkNBR_ODATE.Location = new System.Drawing.Point(88, 113);
            this.dpkNBR_ODATE.Name = "dpkNBR_ODATE";
            this.dpkNBR_ODATE.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.dpkNBR_ODATE.Size = new System.Drawing.Size(213, 35);
            this.dpkNBR_ODATE.TabIndex = 13;
            this.dpkNBR_ODATE.ZIndex = 15;
            // 
            // Label4
            // 
            this.Label4.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label4.Location = new System.Drawing.Point(0, 148);
            this.Label4.Name = "Label4";
            this.Label4.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label4.Size = new System.Drawing.Size(88, 35);
            this.Label4.TabIndex = 14;
            this.Label4.Text = "所在位置";
            this.Label4.ZIndex = 11;
            // 
            // save
            // 
            this.save.IconID = "!\\ue161043146223";
            this.save.Name = "save";
            this.save.Text = "保存";
            // 
            // PopList1
            // 
            this.PopList1.Name = "PopList1";
            this.PopList1.Selected += new System.EventHandler(this.PopList1_Selected);
            // 
            // btnNBR_LOCATION
            // 
            this.btnNBR_LOCATION.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.btnNBR_LOCATION.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnNBR_LOCATION.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnNBR_LOCATION.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnNBR_LOCATION.Location = new System.Drawing.Point(88, 148);
            this.btnNBR_LOCATION.Name = "btnNBR_LOCATION";
            this.btnNBR_LOCATION.Padding = new Smobiler.Core.Padding(0F, 0F, 5F, 0F);
            this.btnNBR_LOCATION.Size = new System.Drawing.Size(188, 35);
            this.btnNBR_LOCATION.TabIndex = 20;
            this.btnNBR_LOCATION.Text = "上海";
            this.btnNBR_LOCATION.ZIndex = 28;
            // 
            // btnNBR_LOCATION2
            // 
            this.btnNBR_LOCATION2.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.btnNBR_LOCATION2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnNBR_LOCATION2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnNBR_LOCATION2.Location = new System.Drawing.Point(275, 148);
            this.btnNBR_LOCATION2.Name = "btnNBR_LOCATION2";
            this.btnNBR_LOCATION2.Size = new System.Drawing.Size(25, 35);
            this.btnNBR_LOCATION2.TabIndex = 21;
            this.btnNBR_LOCATION2.Text = ">";
            this.btnNBR_LOCATION2.ZIndex = 29;
            this.btnNBR_LOCATION2.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnpop_Click);
            // 
            // frmNBRecordCreate
            // 
            this.ComponentControls.AddRange(new Smobiler.Core.ComponentBase[] {
            this.PopList1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label1,
            this.txtNB_EQNO,
            this.Label4,
            this.dpkNBR_ODATE,
            this.Label8,
            this.Label2,
            this.Label3,
            this.btnUser,
            this.btnType,
            this.btnUser2,
            this.btnType2,
            this.btnCODE2,
            this.btnNBR_LOCATION,
            this.btnNBR_LOCATION2});
            this.StatusBarStyle = Smobiler.Core.StatusBarStyle.Default;
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("Exit", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(50))))));
            this.TitleText = "笔记本使用记录创建";
            this.Toolbar.AddRange(new Smobiler.Core.Controls.ToolbarItem[] {
            this.save});
            this.ToolbarStyle = new Smobiler.Core.ToolBarSytle(Smobiler.Core.ToolbarSelectStyle.None, System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))), System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))));
            this.Load += new System.EventHandler(this.frmNoteBooksRecordCreate_Load);
            this.ToolbarItemClick += new Smobiler.Core.ToolbarItemClickEventHandler(this.frmNBRecordCreate_ToolbarItemClick);
            this.TitleImageClick += new System.EventHandler(this.frmNBRecordCreate_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.MobileForm_KeyDown);
            this.Name = "frmNBRecordCreate";

        }
        internal Smobiler.Core.Controls.Label Label1;
        internal Smobiler.Core.Controls.TextBox txtNB_EQNO;
        internal Smobiler.Core.Controls.Button btnCODE2;
        internal Smobiler.Core.Controls.Button btnUser;
        internal Smobiler.Core.Controls.Button btnUser2;
        internal Smobiler.Core.Controls.Label Label8;
        internal Smobiler.Core.Controls.Label Label2;
        internal Smobiler.Core.Controls.Button btnType;
        internal Smobiler.Core.Controls.Button btnType2;
        internal Smobiler.Core.Controls.Label Label3;
        internal Smobiler.Core.Controls.DatePicker dpkNBR_ODATE;
        internal Smobiler.Core.Controls.Label Label4;
        internal Smobiler.Core.Controls.ToolbarItem save;
        internal Smobiler.Core.Controls.PopList PopList1;
        internal Smobiler.Core.Controls.Button btnNBR_LOCATION;
        internal Smobiler.Core.Controls.Button btnNBR_LOCATION2;
        #endregion
    }
}
