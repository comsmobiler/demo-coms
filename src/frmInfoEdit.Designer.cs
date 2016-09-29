using System;
using Smobiler.Core;
namespace COMSSmobilerDemo
{
    partial class frmInfoEdit : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmInfoEdit()
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
            this.Label2 = new Smobiler.Core.Controls.Label();
            this.Label3 = new Smobiler.Core.Controls.Label();
            this.Label4 = new Smobiler.Core.Controls.Label();
            this.Label5 = new Smobiler.Core.Controls.Label();
            this.txtEmail = new Smobiler.Core.Controls.TextBox();
            this.txtPhone = new Smobiler.Core.Controls.TextBox();
            this.txtTel = new Smobiler.Core.Controls.TextBox();
            this.txtAddreass = new Smobiler.Core.Controls.TextBox();
            this.imguser = new Smobiler.Core.Controls.ImageButton();
            this.DateBorn = new Smobiler.Core.Controls.DatePicker();
            this.txtUserName = new Smobiler.Core.Controls.TextBox();
            this.btnSex = new Smobiler.Core.Controls.Button();
            this.Camera1 = new Smobiler.Core.Controls.Camera();
            this.PopList1 = new Smobiler.Core.Controls.PopList();
            this.save = new Smobiler.Core.Controls.ToolbarItem();
            this.Label6 = new Smobiler.Core.Controls.Label();
            this.lblUser = new Smobiler.Core.Controls.Label();
            this.Label8 = new Smobiler.Core.Controls.Label();
            this.Button1 = new Smobiler.Core.Controls.Button();
            this.Label9 = new Smobiler.Core.Controls.Label();
            this.Button2 = new Smobiler.Core.Controls.Button();
            this.Label10 = new Smobiler.Core.Controls.Label();
            // 
            // Label1
            // 
            this.Label1.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label1.Location = new System.Drawing.Point(0, 304);
            this.Label1.Name = "Label1";
            this.Label1.Padding = new Smobiler.Core.Padding(2F, 5F, 0F, 0F);
            this.Label1.Size = new System.Drawing.Size(70, 60);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "家庭住址";
            this.Label1.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            // 
            // Label2
            // 
            this.Label2.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label2.Location = new System.Drawing.Point(0, 202);
            this.Label2.Name = "Label2";
            this.Label2.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label2.Size = new System.Drawing.Size(70, 28);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "电话";
            // 
            // Label3
            // 
            this.Label3.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label3.Location = new System.Drawing.Point(0, 236);
            this.Label3.Name = "Label3";
            this.Label3.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label3.Size = new System.Drawing.Size(70, 28);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "邮箱";
            // 
            // Label4
            // 
            this.Label4.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label4.Location = new System.Drawing.Point(0, 270);
            this.Label4.Name = "Label4";
            this.Label4.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label4.Size = new System.Drawing.Size(70, 28);
            this.Label4.TabIndex = 5;
            this.Label4.Text = "手机";
            // 
            // Label5
            // 
            this.Label5.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label5.Location = new System.Drawing.Point(0, 168);
            this.Label5.Name = "Label5";
            this.Label5.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label5.Size = new System.Drawing.Size(70, 28);
            this.Label5.TabIndex = 6;
            this.Label5.Text = "出生日期";
            // 
            // txtEmail
            // 
            this.txtEmail.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.txtEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txtEmail.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.txtEmail.Location = new System.Drawing.Point(70, 236);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new Smobiler.Core.Padding(0F, 0F, 12F, 0F);
            this.txtEmail.Size = new System.Drawing.Size(170, 28);
            this.txtEmail.TabIndex = 16;
            this.txtEmail.WaterMarkText = "输入电子邮件";
            // 
            // txtPhone
            // 
            this.txtPhone.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.txtPhone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txtPhone.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.txtPhone.InputType = Smobiler.Core.TextBoxInputType.Number;
            this.txtPhone.Location = new System.Drawing.Point(70, 202);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Padding = new Smobiler.Core.Padding(0F, 0F, 12F, 0F);
            this.txtPhone.Size = new System.Drawing.Size(170, 28);
            this.txtPhone.TabIndex = 17;
            this.txtPhone.WaterMarkText = "输入电话号码";
            // 
            // txtTel
            // 
            this.txtTel.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.txtTel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtTel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txtTel.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.txtTel.InputType = Smobiler.Core.TextBoxInputType.Number;
            this.txtTel.Location = new System.Drawing.Point(70, 270);
            this.txtTel.Name = "txtTel";
            this.txtTel.Padding = new Smobiler.Core.Padding(0F, 0F, 12F, 0F);
            this.txtTel.Size = new System.Drawing.Size(170, 28);
            this.txtTel.TabIndex = 18;
            this.txtTel.WaterMarkText = "输入手机号码";
            // 
            // txtAddreass
            // 
            this.txtAddreass.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.txtAddreass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtAddreass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txtAddreass.Location = new System.Drawing.Point(70, 304);
            this.txtAddreass.Multiline = true;
            this.txtAddreass.Name = "txtAddreass";
            this.txtAddreass.Padding = new Smobiler.Core.Padding(0F, 5F, 12F, 0F);
            this.txtAddreass.Size = new System.Drawing.Size(170, 60);
            this.txtAddreass.TabIndex = 19;
            this.txtAddreass.WaterMarkText = "输入家庭住址";
            // 
            // imguser
            // 
            this.imguser.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.imguser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.imguser.FontSize = 8F;
            this.imguser.HoverBackColor = System.Drawing.Color.White;
            this.imguser.HoverForeColor = System.Drawing.Color.White;
            this.imguser.Location = new System.Drawing.Point(160, 34);
            this.imguser.Name = "imguser";
            this.imguser.ResourceID = "lincy";
            this.imguser.Size = new System.Drawing.Size(60, 60);
            this.imguser.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.imguser.TabIndex = 20;
            this.imguser.ZIndex = 4;
            this.imguser.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.imguser_Click);
            // 
            // DateBorn
            // 
            this.DateBorn.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.DateBorn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.DateBorn.CurrentDate = new System.DateTime(2015, 11, 6, 0, 0, 0, 0);
            this.DateBorn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.DateBorn.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.DateBorn.Location = new System.Drawing.Point(70, 168);
            this.DateBorn.Name = "DateBorn";
            this.DateBorn.Padding = new Smobiler.Core.Padding(0F, 0F, 12F, 0F);
            this.DateBorn.Size = new System.Drawing.Size(170, 28);
            this.DateBorn.TabIndex = 21;
            // 
            // txtUserName
            // 
            this.txtUserName.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.txtUserName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txtUserName.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.txtUserName.Location = new System.Drawing.Point(70, 100);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Padding = new Smobiler.Core.Padding(0F, 0F, 12F, 0F);
            this.txtUserName.Size = new System.Drawing.Size(170, 28);
            this.txtUserName.TabIndex = 22;
            this.txtUserName.WaterMarkText = "（必填）";
            // 
            // btnSex
            // 
            this.btnSex.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.btnSex.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnSex.FontSize = 14F;
            this.btnSex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnSex.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnSex.Location = new System.Drawing.Point(70, 134);
            this.btnSex.Name = "btnSex";
            this.btnSex.Padding = new Smobiler.Core.Padding(0F, 0F, 12F, 0F);
            this.btnSex.Size = new System.Drawing.Size(150, 28);
            this.btnSex.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btnSex.TabIndex = 23;
            this.btnSex.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnSex_Click);
            // 
            // Camera1
            // 
            this.Camera1.AllowEdit = true;
            this.Camera1.Name = "Camera1";
            this.Camera1.ImageCaptured += new Smobiler.Core.CameraOnlineCallBackHandler(this.Camera1_ImageCaptured);
            // 
            // PopList1
            // 
            this.PopList1.Name = "PopList1";
            this.PopList1.Selected += new System.EventHandler(this.PopList1_Selected);
            // 
            // save
            // 
            this.save.IconID = "!\\ue161043146223";
            this.save.Name = "save";
            this.save.Text = "保存";
            // 
            // Label6
            // 
            this.Label6.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label6.Name = "Label6";
            this.Label6.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label6.Size = new System.Drawing.Size(70, 28);
            this.Label6.TabIndex = 24;
            this.Label6.Text = "用户";
            this.Label6.ZIndex = 1;
            // 
            // lblUser
            // 
            this.lblUser.Bold = true;
            this.lblUser.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.lblUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblUser.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblUser.Location = new System.Drawing.Point(70, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Padding = new Smobiler.Core.Padding(0F, 0F, 12F, 0F);
            this.lblUser.Size = new System.Drawing.Size(170, 28);
            this.lblUser.TabIndex = 25;
            this.lblUser.ZIndex = 2;
            // 
            // Label8
            // 
            this.Label8.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label8.Location = new System.Drawing.Point(0, 34);
            this.Label8.Name = "Label8";
            this.Label8.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label8.Size = new System.Drawing.Size(160, 60);
            this.Label8.TabIndex = 26;
            this.Label8.Text = "头像";
            this.Label8.ZIndex = 3;
            // 
            // Button1
            // 
            this.Button1.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Button1.FontSize = 16F;
            this.Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.Button1.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Left;
            this.Button1.HoverBackColor = System.Drawing.Color.White;
            this.Button1.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Button1.Location = new System.Drawing.Point(220, 34);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(20, 60);
            this.Button1.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.Button1.TabIndex = 27;
            this.Button1.Text = ">";
            this.Button1.ZIndex = 5;
            this.Button1.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.imguser_Click);
            // 
            // Label9
            // 
            this.Label9.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label9.Location = new System.Drawing.Point(0, 100);
            this.Label9.Name = "Label9";
            this.Label9.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label9.Size = new System.Drawing.Size(70, 28);
            this.Label9.TabIndex = 28;
            this.Label9.Text = "姓名";
            this.Label9.ZIndex = 1;
            // 
            // Button2
            // 
            this.Button2.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Button2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Button2.FontSize = 16F;
            this.Button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.Button2.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Left;
            this.Button2.Location = new System.Drawing.Point(220, 134);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(20, 28);
            this.Button2.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.Button2.TabIndex = 29;
            this.Button2.Text = ">";
            this.Button2.ZIndex = 5;
            this.Button2.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnSex_Click);
            // 
            // Label10
            // 
            this.Label10.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label10.Location = new System.Drawing.Point(0, 134);
            this.Label10.Name = "Label10";
            this.Label10.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label10.Size = new System.Drawing.Size(70, 28);
            this.Label10.TabIndex = 30;
            this.Label10.Text = "性别";
            this.Label10.ZIndex = 1;
            // 
            // frmInfoEdit
            // 
            this.ComponentControls.AddRange(new Smobiler.Core.ComponentBase[] {
            this.Camera1,
            this.PopList1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label1,
            this.Label2,
            this.Label3,
            this.Label4,
            this.Label5,
            this.txtEmail,
            this.txtPhone,
            this.txtTel,
            this.txtAddreass,
            this.DateBorn,
            this.txtUserName,
            this.btnSex,
            this.Label6,
            this.Label9,
            this.lblUser,
            this.Label8,
            this.imguser,
            this.Button1,
            this.Button2,
            this.Label10});
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.StatusBarStyle = Smobiler.Core.StatusBarStyle.Default;
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("Exit", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(50))))));
            this.TitleText = "基本信息编辑";
            this.Toolbar.AddRange(new Smobiler.Core.Controls.ToolbarItem[] {
            this.save});
            this.ToolbarStyle = new Smobiler.Core.ToolBarSytle(Smobiler.Core.ToolbarSelectStyle.None, System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))), System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))));
            this.Load += new System.EventHandler(this.frmInfoEdit_Load);
            this.ToolbarItemClick += new Smobiler.Core.ToolbarItemClickEventHandler(this.frmInfoEdit_ToolbarItemClick);
            this.TitleImageClick += new System.EventHandler(this.frmInfoEdit_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.MobileForm_KeyDown);
            this.Name = "frmInfoEdit";

        }
        internal Smobiler.Core.Controls.Label Label1;
        internal Smobiler.Core.Controls.Label Label2;
        internal Smobiler.Core.Controls.Label Label3;
        internal Smobiler.Core.Controls.Label Label4;
        internal Smobiler.Core.Controls.Label Label5;
        internal Smobiler.Core.Controls.TextBox txtEmail;
        internal Smobiler.Core.Controls.TextBox txtPhone;
        internal Smobiler.Core.Controls.TextBox txtTel;
        internal Smobiler.Core.Controls.TextBox txtAddreass;
        internal Smobiler.Core.Controls.ImageButton imguser;
        internal Smobiler.Core.Controls.DatePicker DateBorn;
        internal Smobiler.Core.Controls.TextBox txtUserName;
        internal Smobiler.Core.Controls.Button btnSex;
        internal Smobiler.Core.Controls.Camera Camera1;
        internal Smobiler.Core.Controls.PopList PopList1;
        internal Smobiler.Core.Controls.ToolbarItem save;
        internal Smobiler.Core.Controls.Label Label6;
        internal Smobiler.Core.Controls.Label lblUser;
        internal Smobiler.Core.Controls.Label Label8;
        internal Smobiler.Core.Controls.Button Button1;
        internal Smobiler.Core.Controls.Label Label9;
        internal Smobiler.Core.Controls.Button Button2;
        internal Smobiler.Core.Controls.Label Label10;
        #endregion
    }
}
