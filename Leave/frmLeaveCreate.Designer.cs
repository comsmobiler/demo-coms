using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
namespace COMSSmobilerDemo.Leave
{
    public partial class frmLeaveCreate : Smobiler.Core.MobileForm
    {

        #region "SmobilerForm Designer generated code "

        public frmLeaveCreate()
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
            this.Label1 = new Smobiler.Core.Controls.Label();
            this.btntype = new Smobiler.Core.Controls.Button();
            this.btntype2 = new Smobiler.Core.Controls.Button();
            this.LBDATE = new Smobiler.Core.Controls.DatePicker();
            this.Label2 = new Smobiler.Core.Controls.Label();
            this.Label3 = new Smobiler.Core.Controls.Label();
            this.LEDATE = new Smobiler.Core.Controls.DatePicker();
            this.Label4 = new Smobiler.Core.Controls.Label();
            this.LDAY = new Smobiler.Core.Controls.TextBox();
            this.Label5 = new Smobiler.Core.Controls.Label();
            this.LREASON = new Smobiler.Core.Controls.TextBox();
            this.Label6 = new Smobiler.Core.Controls.Label();
            this.LIMG = new Smobiler.Core.Controls.ImageButton();
            this.Camera1 = new Smobiler.Core.Controls.Camera();
            this.Label7 = new Smobiler.Core.Controls.Label();
            this.BtnCUser = new Smobiler.Core.Controls.Button();
            this.BtnCUser2 = new Smobiler.Core.Controls.Button();
            this.save = new Smobiler.Core.Controls.ToolbarItem();
            this.tExit = new Smobiler.Core.Controls.ToolbarItem();
            this.Label8 = new Smobiler.Core.Controls.Label();
            this.Btnccuser1 = new Smobiler.Core.Controls.Button();
            this.Btnccuser2 = new Smobiler.Core.Controls.Button();
            this.PopList1 = new Smobiler.Core.Controls.PopList();
            // 
            // Label1
            // 
            this.Label1.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label1.BorderColor = System.Drawing.Color.DarkGray;
            this.Label1.ForeColor = System.Drawing.Color.Gray;
            this.Label1.Name = "Label1";
            this.Label1.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label1.Size = new System.Drawing.SizeF(35F, 14F);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "请假类型";
            // 
            // btntype
            // 
            this.btntype.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.btntype.BorderColor = System.Drawing.Color.DarkGray;
            this.btntype.FontSize = 7F;
            this.btntype.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Left;
            this.btntype.Location = new Smobiler.Core.PointS(35F, 0F);
            this.btntype.Name = "btntype";
            this.btntype.Size = new System.Drawing.SizeF(71F, 14F);
            this.btntype.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btntype.TabIndex = 4;
            this.btntype.Text = "类型选择(必填)";
            this.btntype.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btntype_Click);
            // 
            // btntype2
            // 
            this.btntype2.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.btntype2.BorderColor = System.Drawing.Color.DarkGray;
            this.btntype2.FontSize = 8F;
            this.btntype2.ForeColor = System.Drawing.Color.Gray;
            this.btntype2.Location = new Smobiler.Core.PointS(106F, 0F);
            this.btntype2.Name = "btntype2";
            this.btntype2.Size = new System.Drawing.SizeF(14F, 14F);
            this.btntype2.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btntype2.TabIndex = 5;
            this.btntype2.Text = ">";
            this.btntype2.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btntype_Click);
            // 
            // LBDATE
            // 
            this.LBDATE.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.LBDATE.BorderColor = System.Drawing.Color.DarkGray;
            this.LBDATE.FontSize = 7F;
            this.LBDATE.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Left;
            this.LBDATE.Location = new Smobiler.Core.PointS(35F, 14F);
            this.LBDATE.Name = "LBDATE";
            this.LBDATE.Size = new System.Drawing.SizeF(85F, 14F);
            this.LBDATE.TabIndex = 6;
            // 
            // Label2
            // 
            this.Label2.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label2.BorderColor = System.Drawing.Color.DarkGray;
            this.Label2.ForeColor = System.Drawing.Color.Gray;
            this.Label2.Location = new Smobiler.Core.PointS(0F, 14F);
            this.Label2.Name = "Label2";
            this.Label2.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label2.Size = new System.Drawing.SizeF(35F, 14F);
            this.Label2.TabIndex = 7;
            this.Label2.Text = "开始时间";
            // 
            // Label3
            // 
            this.Label3.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label3.BorderColor = System.Drawing.Color.DarkGray;
            this.Label3.ForeColor = System.Drawing.Color.Gray;
            this.Label3.Location = new Smobiler.Core.PointS(0F, 28F);
            this.Label3.Name = "Label3";
            this.Label3.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label3.Size = new System.Drawing.SizeF(35F, 14F);
            this.Label3.TabIndex = 8;
            this.Label3.Text = "结束时间";
            // 
            // LEDATE
            // 
            this.LEDATE.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.LEDATE.BorderColor = System.Drawing.Color.DarkGray;
            this.LEDATE.FontSize = 7F;
            this.LEDATE.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Left;
            this.LEDATE.Location = new Smobiler.Core.PointS(35F, 28F);
            this.LEDATE.Name = "LEDATE";
            this.LEDATE.Size = new System.Drawing.SizeF(85F, 14F);
            this.LEDATE.TabIndex = 9;
            // 
            // Label4
            // 
            this.Label4.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label4.BorderColor = System.Drawing.Color.DarkGray;
            this.Label4.ForeColor = System.Drawing.Color.Gray;
            this.Label4.Location = new Smobiler.Core.PointS(0F, 45F);
            this.Label4.Name = "Label4";
            this.Label4.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label4.Size = new System.Drawing.SizeF(35F, 14F);
            this.Label4.TabIndex = 10;
            this.Label4.Text = "请假天数";
            // 
            // LDAY
            // 
            this.LDAY.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.LDAY.BorderColor = System.Drawing.Color.DarkGray;
            this.LDAY.FontSize = 7F;
            this.LDAY.InputType = Smobiler.Core.TextBoxInputType.Number;
            this.LDAY.Location = new Smobiler.Core.PointS(35F, 45F);
            this.LDAY.Name = "LDAY";
            this.LDAY.Size = new System.Drawing.SizeF(85F, 14F);
            this.LDAY.TabIndex = 11;
            this.LDAY.WaterMarkText = "请假天数（必填）";
            // 
            // Label5
            // 
            this.Label5.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label5.BorderColor = System.Drawing.Color.DarkGray;
            this.Label5.ForeColor = System.Drawing.Color.Gray;
            this.Label5.Location = new Smobiler.Core.PointS(0F, 59F);
            this.Label5.Name = "Label5";
            this.Label5.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label5.Size = new System.Drawing.SizeF(35F, 40F);
            this.Label5.TabIndex = 12;
            this.Label5.Text = "请假事由";
            // 
            // LREASON
            // 
            this.LREASON.BorderColor = System.Drawing.Color.DarkGray;
            this.LREASON.FontSize = 7F;
            this.LREASON.Location = new Smobiler.Core.PointS(35F, 59F);
            this.LREASON.Multiline = true;
            this.LREASON.Name = "LREASON";
            this.LREASON.Size = new System.Drawing.SizeF(85F, 40F);
            this.LREASON.TabIndex = 13;
            this.LREASON.WaterMarkText = "请假事由（必填）";
            // 
            // Label6
            // 
            this.Label6.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label6.BorderColor = System.Drawing.Color.DarkGray;
            this.Label6.ForeColor = System.Drawing.Color.Gray;
            this.Label6.Location = new Smobiler.Core.PointS(0F, 102F);
            this.Label6.Name = "Label6";
            this.Label6.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label6.Size = new System.Drawing.SizeF(35F, 40F);
            this.Label6.TabIndex = 14;
            this.Label6.Text = "图片";
            // 
            // LIMG
            // 
            this.LIMG.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.LIMG.BorderColor = System.Drawing.Color.DarkGray;
            this.LIMG.FontSize = 7F;
            this.LIMG.Location = new Smobiler.Core.PointS(35F, 102F);
            this.LIMG.Name = "LIMG";
            this.LIMG.Size = new System.Drawing.SizeF(85F, 40F);
            this.LIMG.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.LIMG.TabIndex = 15;
            this.LIMG.Text = "点击上传图片";
            this.LIMG.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.LIMG_Click);
            // 
            // Camera1
            // 
            this.Camera1.Mode = Smobiler.Core.Controls.CameraMode.Camera;
            this.Camera1.Name = "Camera1";
            this.Camera1.ImageCaptured += new Smobiler.Core.CameraOnlineCallBackHandler(this.Camera1_ImageCaptured);
            // 
            // Label7
            // 
            this.Label7.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label7.BorderColor = System.Drawing.Color.DarkGray;
            this.Label7.ForeColor = System.Drawing.Color.Gray;
            this.Label7.Location = new Smobiler.Core.PointS(0F, 145F);
            this.Label7.Name = "Label7";
            this.Label7.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label7.Size = new System.Drawing.SizeF(35F, 14F);
            this.Label7.TabIndex = 16;
            this.Label7.Text = "审批人";
            // 
            // BtnCUser
            // 
            this.BtnCUser.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.BtnCUser.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnCUser.FontSize = 7F;
            this.BtnCUser.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Left;
            this.BtnCUser.Location = new Smobiler.Core.PointS(35F, 145F);
            this.BtnCUser.Name = "BtnCUser";
            this.BtnCUser.Size = new System.Drawing.SizeF(71F, 14F);
            this.BtnCUser.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.BtnCUser.TabIndex = 18;
            this.BtnCUser.Text = "审批人(必填)";
            this.BtnCUser.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.BtnCUser_Click);
            // 
            // BtnCUser2
            // 
            this.BtnCUser2.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.BtnCUser2.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnCUser2.FontSize = 8F;
            this.BtnCUser2.ForeColor = System.Drawing.Color.Gray;
            this.BtnCUser2.Location = new Smobiler.Core.PointS(106F, 145F);
            this.BtnCUser2.Name = "BtnCUser2";
            this.BtnCUser2.Size = new System.Drawing.SizeF(14F, 14F);
            this.BtnCUser2.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.BtnCUser2.TabIndex = 19;
            this.BtnCUser2.Text = ">";
            this.BtnCUser2.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.BtnCUser_Click);
            // 
            // save
            // 
            this.save.IconID = "save";
            this.save.Name = "save";
            this.save.Text = "保存";
            // 
            // tExit
            // 
            this.tExit.IconID = "Exit";
            this.tExit.Name = "tExit";
            this.tExit.Text = "返回";
            // 
            // Label8
            // 
            this.Label8.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label8.BorderColor = System.Drawing.Color.DarkGray;
            this.Label8.ForeColor = System.Drawing.Color.Gray;
            this.Label8.Location = new Smobiler.Core.PointS(0F, 159F);
            this.Label8.Name = "Label8";
            this.Label8.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label8.Size = new System.Drawing.SizeF(35F, 14F);
            this.Label8.TabIndex = 20;
            this.Label8.Text = "抄送人";
            // 
            // Btnccuser1
            // 
            this.Btnccuser1.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Btnccuser1.BorderColor = System.Drawing.Color.DarkGray;
            this.Btnccuser1.FontSize = 7F;
            this.Btnccuser1.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Left;
            this.Btnccuser1.Location = new Smobiler.Core.PointS(35F, 159F);
            this.Btnccuser1.Name = "Btnccuser1";
            this.Btnccuser1.Size = new System.Drawing.SizeF(71F, 14F);
            this.Btnccuser1.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.Btnccuser1.TabIndex = 21;
            this.Btnccuser1.Text = "抄送人(选填)";
            this.Btnccuser1.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.BtnCUser_Click);
            // 
            // Btnccuser2
            // 
            this.Btnccuser2.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Btnccuser2.BorderColor = System.Drawing.Color.DarkGray;
            this.Btnccuser2.FontSize = 8F;
            this.Btnccuser2.ForeColor = System.Drawing.Color.Gray;
            this.Btnccuser2.Location = new Smobiler.Core.PointS(106F, 159F);
            this.Btnccuser2.Name = "Btnccuser2";
            this.Btnccuser2.Size = new System.Drawing.SizeF(14F, 14F);
            this.Btnccuser2.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.Btnccuser2.TabIndex = 22;
            this.Btnccuser2.Text = ">";
            this.Btnccuser2.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.BtnCUser_Click);
            // 
            // PopList1
            // 
            this.PopList1.Name = "PopList1";
            this.PopList1.Selected += new System.EventHandler(this.PopList1_Selected);
            // 
            // frmLeaveCreate
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ComponentControls.AddRange(new Smobiler.Core.ComponentBase[] {
            this.Camera1,
            this.PopList1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label1,
            this.btntype,
            this.btntype2,
            this.LBDATE,
            this.Label2,
            this.Label3,
            this.LEDATE,
            this.Label4,
            this.LDAY,
            this.Label5,
            this.LREASON,
            this.Label6,
            this.LIMG,
            this.Label7,
            this.BtnCUser,
            this.BtnCUser2,
            this.Label8,
            this.Btnccuser1,
            this.Btnccuser2});
            this.TitleBackColor = System.Drawing.Color.DeepSkyBlue;
            this.TitleText = "请假条创建";
            this.Toolbar.AddRange(new Smobiler.Core.Controls.ToolbarItem[] {
            this.tExit,
            this.save});
            this.ToolbarItemClick += new Smobiler.Core.ToolbarItemClickEventHandler(this.frmLeaveCreate_ToolbarItemClick);

        }
        internal Smobiler.Core.Controls.Label Label1;
        internal Smobiler.Core.Controls.Button btntype;
        internal Smobiler.Core.Controls.Button btntype2;
        internal Smobiler.Core.Controls.DatePicker LBDATE;
        internal Smobiler.Core.Controls.Label Label2;
        internal Smobiler.Core.Controls.Label Label3;
        internal Smobiler.Core.Controls.DatePicker LEDATE;
        internal Smobiler.Core.Controls.Label Label4;
        internal Smobiler.Core.Controls.TextBox LDAY;
        internal Smobiler.Core.Controls.Label Label5;
        internal Smobiler.Core.Controls.TextBox LREASON;
        internal Smobiler.Core.Controls.Label Label6;
        internal Smobiler.Core.Controls.ImageButton LIMG;
        internal Smobiler.Core.Controls.Camera Camera1;
        internal Smobiler.Core.Controls.Label Label7;
        internal Smobiler.Core.Controls.Button BtnCUser;
        internal Smobiler.Core.Controls.Button BtnCUser2;
        internal Smobiler.Core.Controls.ToolbarItem save;
        internal Smobiler.Core.Controls.ToolbarItem tExit;
        internal Smobiler.Core.Controls.Label Label8;
        internal Smobiler.Core.Controls.Button Btnccuser1;
        internal Smobiler.Core.Controls.Button Btnccuser2;

        internal Smobiler.Core.Controls.PopList PopList1;
        #endregion

    }
}