using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
namespace COMSSmobilerDemo.Leave
{
    public partial class frmLeaveDef : Smobiler.Core.MobileForm
    {

        #region "SmobilerForm Designer generated code "

        public frmLeaveDef()
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
            this.Label2 = new Smobiler.Core.Controls.Label();
            this.Label3 = new Smobiler.Core.Controls.Label();
            this.Label4 = new Smobiler.Core.Controls.Label();
            this.Label5 = new Smobiler.Core.Controls.Label();
            this.Label6 = new Smobiler.Core.Controls.Label();
            this.LIMG = new Smobiler.Core.Controls.Image();
            this.tExit = new Smobiler.Core.Controls.ToolbarItem();
            this.Label8 = new Smobiler.Core.Controls.Label();
            this.lbllNO = new Smobiler.Core.Controls.Label();
            this.lbllType = new Smobiler.Core.Controls.Label();
            this.lblbDate = new Smobiler.Core.Controls.Label();
            this.lbleDate = new Smobiler.Core.Controls.Label();
            this.lbllDay = new Smobiler.Core.Controls.Label();
            this.lbllReason = new Smobiler.Core.Controls.Label();
            this.Label7 = new Smobiler.Core.Controls.Label();
            this.Label9 = new Smobiler.Core.Controls.Label();
            this.lblCUser = new Smobiler.Core.Controls.Label();
            this.lblCCUser = new Smobiler.Core.Controls.Label();
            this.Label13 = new Smobiler.Core.Controls.Label();
            this.lblCreateDate = new Smobiler.Core.Controls.Label();
            this.Label10 = new Smobiler.Core.Controls.Label();
            this.lblState = new Smobiler.Core.Controls.Label();
            this.lblREFUSENOTE1 = new Smobiler.Core.Controls.Label();
            this.lblREFUSENOTE = new Smobiler.Core.Controls.Label();
            // 
            // Label1
            // 
            this.Label1.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label1.BorderColor = System.Drawing.Color.DarkGray;
            this.Label1.ForeColor = System.Drawing.Color.Gray;
            this.Label1.Location = new Smobiler.Core.PointS(0F, 14F);
            this.Label1.Name = "Label1";
            this.Label1.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label1.Size = new System.Drawing.SizeF(35F, 14F);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "请假类型";
            // 
            // Label2
            // 
            this.Label2.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label2.BorderColor = System.Drawing.Color.DarkGray;
            this.Label2.ForeColor = System.Drawing.Color.Gray;
            this.Label2.Location = new Smobiler.Core.PointS(0F, 28F);
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
            this.Label3.Location = new Smobiler.Core.PointS(0F, 42F);
            this.Label3.Name = "Label3";
            this.Label3.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label3.Size = new System.Drawing.SizeF(35F, 14F);
            this.Label3.TabIndex = 8;
            this.Label3.Text = "结束时间";
            // 
            // Label4
            // 
            this.Label4.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label4.BorderColor = System.Drawing.Color.DarkGray;
            this.Label4.ForeColor = System.Drawing.Color.Gray;
            this.Label4.Location = new Smobiler.Core.PointS(0F, 59F);
            this.Label4.Name = "Label4";
            this.Label4.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label4.Size = new System.Drawing.SizeF(35F, 14F);
            this.Label4.TabIndex = 10;
            this.Label4.Text = "请假天数";
            // 
            // Label5
            // 
            this.Label5.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label5.BorderColor = System.Drawing.Color.DarkGray;
            this.Label5.ForeColor = System.Drawing.Color.Gray;
            this.Label5.Location = new Smobiler.Core.PointS(0F, 73F);
            this.Label5.Name = "Label5";
            this.Label5.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label5.Size = new System.Drawing.SizeF(35F, 40F);
            this.Label5.TabIndex = 12;
            this.Label5.Text = "请假事由";
            // 
            // Label6
            // 
            this.Label6.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label6.BorderColor = System.Drawing.Color.DarkGray;
            this.Label6.ForeColor = System.Drawing.Color.Gray;
            this.Label6.Location = new Smobiler.Core.PointS(0F, 116F);
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
            this.LIMG.Location = new Smobiler.Core.PointS(35F, 116F);
            this.LIMG.Name = "LIMG";
            this.LIMG.Size = new System.Drawing.SizeF(85F, 40F);
            this.LIMG.TabIndex = 15;
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
            this.Label8.Name = "Label8";
            this.Label8.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label8.Size = new System.Drawing.SizeF(35F, 14F);
            this.Label8.TabIndex = 20;
            this.Label8.Text = "请假编号";
            // 
            // lbllNO
            // 
            this.lbllNO.Bold = true;
            this.lbllNO.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.lbllNO.BorderColor = System.Drawing.Color.DarkGray;
            this.lbllNO.FontSize = 7F;
            this.lbllNO.Location = new Smobiler.Core.PointS(35F, 0F);
            this.lbllNO.Name = "lbllNO";
            this.lbllNO.Size = new System.Drawing.SizeF(85F, 14F);
            this.lbllNO.TabIndex = 21;
            // 
            // lbllType
            // 
            this.lbllType.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.lbllType.BorderColor = System.Drawing.Color.DarkGray;
            this.lbllType.FontSize = 7F;
            this.lbllType.Location = new Smobiler.Core.PointS(35F, 14F);
            this.lbllType.Name = "lbllType";
            this.lbllType.Size = new System.Drawing.SizeF(85F, 14F);
            this.lbllType.TabIndex = 22;
            // 
            // lblbDate
            // 
            this.lblbDate.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.lblbDate.BorderColor = System.Drawing.Color.DarkGray;
            this.lblbDate.FontSize = 7F;
            this.lblbDate.Location = new Smobiler.Core.PointS(35F, 28F);
            this.lblbDate.Name = "lblbDate";
            this.lblbDate.Size = new System.Drawing.SizeF(85F, 14F);
            this.lblbDate.TabIndex = 23;
            // 
            // lbleDate
            // 
            this.lbleDate.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.lbleDate.BorderColor = System.Drawing.Color.DarkGray;
            this.lbleDate.FontSize = 7F;
            this.lbleDate.Location = new Smobiler.Core.PointS(35F, 42F);
            this.lbleDate.Name = "lbleDate";
            this.lbleDate.Size = new System.Drawing.SizeF(85F, 14F);
            this.lbleDate.TabIndex = 24;
            // 
            // lbllDay
            // 
            this.lbllDay.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.lbllDay.BorderColor = System.Drawing.Color.DarkGray;
            this.lbllDay.FontSize = 7F;
            this.lbllDay.Location = new Smobiler.Core.PointS(35F, 59F);
            this.lbllDay.Name = "lbllDay";
            this.lbllDay.Size = new System.Drawing.SizeF(85F, 14F);
            this.lbllDay.TabIndex = 25;
            // 
            // lbllReason
            // 
            this.lbllReason.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.lbllReason.BorderColor = System.Drawing.Color.DarkGray;
            this.lbllReason.FontSize = 7F;
            this.lbllReason.Location = new Smobiler.Core.PointS(35F, 73F);
            this.lbllReason.Name = "lbllReason";
            this.lbllReason.Size = new System.Drawing.SizeF(85F, 40F);
            this.lbllReason.TabIndex = 26;
            // 
            // Label7
            // 
            this.Label7.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label7.BorderColor = System.Drawing.Color.DarkGray;
            this.Label7.ForeColor = System.Drawing.Color.Gray;
            this.Label7.Location = new Smobiler.Core.PointS(0F, 159F);
            this.Label7.Name = "Label7";
            this.Label7.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label7.Size = new System.Drawing.SizeF(35F, 14F);
            this.Label7.TabIndex = 27;
            this.Label7.Text = "审批人";
            // 
            // Label9
            // 
            this.Label9.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label9.BorderColor = System.Drawing.Color.DarkGray;
            this.Label9.ForeColor = System.Drawing.Color.Gray;
            this.Label9.Location = new Smobiler.Core.PointS(0F, 173F);
            this.Label9.Name = "Label9";
            this.Label9.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label9.Size = new System.Drawing.SizeF(35F, 14F);
            this.Label9.TabIndex = 28;
            this.Label9.Text = "抄送人";
            // 
            // lblCUser
            // 
            this.lblCUser.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.lblCUser.BorderColor = System.Drawing.Color.DarkGray;
            this.lblCUser.FontSize = 7F;
            this.lblCUser.Location = new Smobiler.Core.PointS(35F, 159F);
            this.lblCUser.Name = "lblCUser";
            this.lblCUser.Size = new System.Drawing.SizeF(85F, 14F);
            this.lblCUser.TabIndex = 29;
            // 
            // lblCCUser
            // 
            this.lblCCUser.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.lblCCUser.BorderColor = System.Drawing.Color.DarkGray;
            this.lblCCUser.FontSize = 7F;
            this.lblCCUser.Location = new Smobiler.Core.PointS(35F, 173F);
            this.lblCCUser.Name = "lblCCUser";
            this.lblCCUser.Size = new System.Drawing.SizeF(85F, 14F);
            this.lblCCUser.TabIndex = 30;
            // 
            // Label13
            // 
            this.Label13.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label13.BorderColor = System.Drawing.Color.DarkGray;
            this.Label13.ForeColor = System.Drawing.Color.Gray;
            this.Label13.Location = new Smobiler.Core.PointS(0F, 190F);
            this.Label13.Name = "Label13";
            this.Label13.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label13.Size = new System.Drawing.SizeF(35F, 14F);
            this.Label13.TabIndex = 36;
            this.Label13.Text = "创建时间";
            // 
            // lblCreateDate
            // 
            this.lblCreateDate.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.lblCreateDate.BorderColor = System.Drawing.Color.DarkGray;
            this.lblCreateDate.FontSize = 7F;
            this.lblCreateDate.Location = new Smobiler.Core.PointS(35F, 190F);
            this.lblCreateDate.Name = "lblCreateDate";
            this.lblCreateDate.Size = new System.Drawing.SizeF(85F, 14F);
            this.lblCreateDate.TabIndex = 37;
            // 
            // Label10
            // 
            this.Label10.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label10.BorderColor = System.Drawing.Color.DarkGray;
            this.Label10.ForeColor = System.Drawing.Color.Gray;
            this.Label10.Location = new Smobiler.Core.PointS(0F, 207F);
            this.Label10.Name = "Label10";
            this.Label10.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label10.Size = new System.Drawing.SizeF(35F, 14F);
            this.Label10.TabIndex = 38;
            this.Label10.Text = "状态";
            // 
            // lblState
            // 
            this.lblState.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.lblState.BorderColor = System.Drawing.Color.DarkGray;
            this.lblState.FontSize = 7F;
            this.lblState.Location = new Smobiler.Core.PointS(35F, 207F);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.SizeF(85F, 14F);
            this.lblState.TabIndex = 39;
            // 
            // lblREFUSENOTE1
            // 
            this.lblREFUSENOTE1.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.lblREFUSENOTE1.BorderColor = System.Drawing.Color.DarkGray;
            this.lblREFUSENOTE1.ForeColor = System.Drawing.Color.Gray;
            this.lblREFUSENOTE1.Location = new Smobiler.Core.PointS(0F, 224F);
            this.lblREFUSENOTE1.Name = "lblREFUSENOTE1";
            this.lblREFUSENOTE1.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.lblREFUSENOTE1.Size = new System.Drawing.SizeF(35F, 40F);
            this.lblREFUSENOTE1.TabIndex = 40;
            this.lblREFUSENOTE1.Text = "拒绝理由";
            this.lblREFUSENOTE1.Visible = false;
            // 
            // lblREFUSENOTE
            // 
            this.lblREFUSENOTE.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.lblREFUSENOTE.BorderColor = System.Drawing.Color.DarkGray;
            this.lblREFUSENOTE.ForeColor = System.Drawing.Color.Gray;
            this.lblREFUSENOTE.Location = new Smobiler.Core.PointS(35F, 224F);
            this.lblREFUSENOTE.Name = "lblREFUSENOTE";
            this.lblREFUSENOTE.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.lblREFUSENOTE.Size = new System.Drawing.SizeF(85F, 40F);
            this.lblREFUSENOTE.TabIndex = 41;
            this.lblREFUSENOTE.Visible = false;
            // 
            // frmLeaveDef
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label1,
            this.Label2,
            this.Label3,
            this.Label4,
            this.Label5,
            this.Label6,
            this.LIMG,
            this.Label8,
            this.lbllNO,
            this.lbllType,
            this.lblbDate,
            this.lbleDate,
            this.lbllDay,
            this.lbllReason,
            this.Label7,
            this.Label9,
            this.lblCUser,
            this.lblCCUser,
            this.Label13,
            this.lblCreateDate,
            this.Label10,
            this.lblState,
            this.lblREFUSENOTE1,
            this.lblREFUSENOTE});
            this.Size = new System.Drawing.Size(120, 270);
            this.TitleBackColor = System.Drawing.Color.DeepSkyBlue;
            this.TitleText = "请假条详细";
            this.Toolbar.AddRange(new Smobiler.Core.Controls.ToolbarItem[] {
            this.tExit});
            this.Load += new System.EventHandler(this.frmLeaveDef_Load);
            this.ToolbarItemClick += new Smobiler.Core.ToolbarItemClickEventHandler(this.frmLeaveDef_ToolbarItemClick);

        }
        internal Smobiler.Core.Controls.Label Label1;
        internal Smobiler.Core.Controls.Label Label2;
        internal Smobiler.Core.Controls.Label Label3;
        internal Smobiler.Core.Controls.Label Label4;
        internal Smobiler.Core.Controls.Label Label5;
        internal Smobiler.Core.Controls.Label Label6;
        internal Smobiler.Core.Controls.Image LIMG;
        internal Smobiler.Core.Controls.ToolbarItem tExit;
        internal Smobiler.Core.Controls.Label Label8;
        internal Smobiler.Core.Controls.Label lbllNO;
        internal Smobiler.Core.Controls.Label lbllType;
        internal Smobiler.Core.Controls.Label lblbDate;
        internal Smobiler.Core.Controls.Label lbleDate;
        internal Smobiler.Core.Controls.Label lbllDay;
        internal Smobiler.Core.Controls.Label lbllReason;
        internal Smobiler.Core.Controls.Label Label7;
        internal Smobiler.Core.Controls.Label Label9;
        internal Smobiler.Core.Controls.Label lblCUser;
        internal Smobiler.Core.Controls.Label lblCCUser;
        internal Smobiler.Core.Controls.Label Label13;
        internal Smobiler.Core.Controls.Label lblCreateDate;
        internal Smobiler.Core.Controls.Label Label10;
        internal Smobiler.Core.Controls.Label lblState;
        internal Smobiler.Core.Controls.Label lblREFUSENOTE1;

        internal Smobiler.Core.Controls.Label lblREFUSENOTE;
        #endregion

    }
}