using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
namespace COMSSmobilerDemo.Operational
{
    public partial class frmOperationalRCreate : Smobiler.Core.MobileForm
    {

        #region "SmobilerForm Designer generated code "

        public frmOperationalRCreate()
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
            this.btnCU = new Smobiler.Core.Controls.Button();
            this.btnCU2 = new Smobiler.Core.Controls.Button();
            this.Label2 = new Smobiler.Core.Controls.Label();
            this.txtOR_DECLARANT = new Smobiler.Core.Controls.TextBox();
            this.Label3 = new Smobiler.Core.Controls.Label();
            this.txtOR_CONTACTTEL = new Smobiler.Core.Controls.TextBox();
            this.Label4 = new Smobiler.Core.Controls.Label();
            this.OR_DECLAREDATE = new Smobiler.Core.Controls.DatePicker();
            this.Label5 = new Smobiler.Core.Controls.Label();
            this.OR_ENDDATE = new Smobiler.Core.Controls.DatePicker();
            this.Label6 = new Smobiler.Core.Controls.Label();
            this.OR_STARTDATE = new Smobiler.Core.Controls.DatePicker();
            this.Label7 = new Smobiler.Core.Controls.Label();
            this.btnOR_PROCESSRESULT = new Smobiler.Core.Controls.Button();
            this.btnOR_PROCESSRESULT2 = new Smobiler.Core.Controls.Button();
            this.Label8 = new Smobiler.Core.Controls.Label();
            this.btnOR_MAINTAINER = new Smobiler.Core.Controls.Button();
            this.btnOR_MAINTAINER2 = new Smobiler.Core.Controls.Button();
            this.Label9 = new Smobiler.Core.Controls.Label();
            this.txtOR_FAULTINFO = new Smobiler.Core.Controls.TextBox();
            this.Label10 = new Smobiler.Core.Controls.Label();
            this.txtOR_REASONANALYSIS = new Smobiler.Core.Controls.TextBox();
            this.Label12 = new Smobiler.Core.Controls.Label();
            this.txtOR_PROCESSMODE = new Smobiler.Core.Controls.TextBox();
            this.Label11 = new Smobiler.Core.Controls.Label();
            this.OR_IMG = new Smobiler.Core.Controls.ImageButton();
            this.Label13 = new Smobiler.Core.Controls.Label();
            this.txtOR_NOTE = new Smobiler.Core.Controls.TextBox();
            this.Camera1 = new Smobiler.Core.Controls.Camera();
            this.PopList1 = new Smobiler.Core.Controls.PopList();
            this.tExit = new Smobiler.Core.Controls.ToolbarItem();
            this.save = new Smobiler.Core.Controls.ToolbarItem();
            // 
            // Label1
            // 
            this.Label1.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label1.BorderColor = System.Drawing.Color.DarkGray;
            this.Label1.ForeColor = System.Drawing.Color.Gray;
            this.Label1.Name = "Label1";
            this.Label1.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label1.Size = new System.Drawing.SizeF(35F, 14F);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "客户名称";
            // 
            // btnCU
            // 
            this.btnCU.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.btnCU.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCU.FontSize = 7F;
            this.btnCU.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Left;
            this.btnCU.Location = new Smobiler.Core.PointS(35F, 0F);
            this.btnCU.Name = "btnCU";
            this.btnCU.Size = new System.Drawing.SizeF(71F, 14F);
            this.btnCU.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btnCU.TabIndex = 3;
            this.btnCU.Text = "客户选择(必填)";
            this.btnCU.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnpop_Click);
            // 
            // btnCU2
            // 
            this.btnCU2.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.btnCU2.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCU2.FontSize = 8F;
            this.btnCU2.ForeColor = System.Drawing.Color.Gray;
            this.btnCU2.Location = new Smobiler.Core.PointS(106F, 0F);
            this.btnCU2.Name = "btnCU2";
            this.btnCU2.Size = new System.Drawing.SizeF(14F, 14F);
            this.btnCU2.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btnCU2.TabIndex = 4;
            this.btnCU2.Text = ">";
            this.btnCU2.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnpop_Click);
            // 
            // Label2
            // 
            this.Label2.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label2.BorderColor = System.Drawing.Color.DarkGray;
            this.Label2.ForeColor = System.Drawing.Color.Gray;
            this.Label2.Location = new Smobiler.Core.PointS(0F, 17F);
            this.Label2.Name = "Label2";
            this.Label2.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label2.Size = new System.Drawing.SizeF(35F, 14F);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "申报人";
            // 
            // txtOR_DECLARANT
            // 
            this.txtOR_DECLARANT.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.txtOR_DECLARANT.BorderColor = System.Drawing.Color.DarkGray;
            this.txtOR_DECLARANT.FontSize = 7F;
            this.txtOR_DECLARANT.Location = new Smobiler.Core.PointS(35F, 17F);
            this.txtOR_DECLARANT.Name = "txtOR_DECLARANT";
            this.txtOR_DECLARANT.Size = new System.Drawing.SizeF(85F, 14F);
            this.txtOR_DECLARANT.TabIndex = 6;
            this.txtOR_DECLARANT.WaterMarkText = "（必填）";
            // 
            // Label3
            // 
            this.Label3.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label3.BorderColor = System.Drawing.Color.DarkGray;
            this.Label3.ForeColor = System.Drawing.Color.Gray;
            this.Label3.Location = new Smobiler.Core.PointS(0F, 31F);
            this.Label3.Name = "Label3";
            this.Label3.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label3.Size = new System.Drawing.SizeF(35F, 14F);
            this.Label3.TabIndex = 7;
            this.Label3.Text = "联系方式";
            // 
            // txtOR_CONTACTTEL
            // 
            this.txtOR_CONTACTTEL.BorderColor = System.Drawing.Color.DarkGray;
            this.txtOR_CONTACTTEL.FontSize = 7F;
            this.txtOR_CONTACTTEL.InputType = Smobiler.Core.TextBoxInputType.Number;
            this.txtOR_CONTACTTEL.Location = new Smobiler.Core.PointS(35F, 31F);
            this.txtOR_CONTACTTEL.Name = "txtOR_CONTACTTEL";
            this.txtOR_CONTACTTEL.Size = new System.Drawing.SizeF(85F, 14F);
            this.txtOR_CONTACTTEL.TabIndex = 8;
            this.txtOR_CONTACTTEL.WaterMarkText = "（选填）";
            // 
            // Label4
            // 
            this.Label4.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label4.BorderColor = System.Drawing.Color.DarkGray;
            this.Label4.ForeColor = System.Drawing.Color.Gray;
            this.Label4.Location = new Smobiler.Core.PointS(0F, 45F);
            this.Label4.Name = "Label4";
            this.Label4.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label4.Size = new System.Drawing.SizeF(35F, 14F);
            this.Label4.TabIndex = 9;
            this.Label4.Text = "申报时间";
            // 
            // OR_DECLAREDATE
            // 
            this.OR_DECLAREDATE.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.OR_DECLAREDATE.BorderColor = System.Drawing.Color.DarkGray;
            this.OR_DECLAREDATE.FontSize = 7F;
            this.OR_DECLAREDATE.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Left;
            this.OR_DECLAREDATE.Location = new Smobiler.Core.PointS(35F, 45F);
            this.OR_DECLAREDATE.Name = "OR_DECLAREDATE";
            this.OR_DECLAREDATE.Size = new System.Drawing.SizeF(85F, 14F);
            this.OR_DECLAREDATE.TabIndex = 10;
            // 
            // Label5
            // 
            this.Label5.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label5.BorderColor = System.Drawing.Color.DarkGray;
            this.Label5.ForeColor = System.Drawing.Color.Gray;
            this.Label5.Location = new Smobiler.Core.PointS(0F, 62F);
            this.Label5.Name = "Label5";
            this.Label5.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label5.Size = new System.Drawing.SizeF(35F, 14F);
            this.Label5.TabIndex = 11;
            this.Label5.Text = "开始时间";
            // 
            // OR_ENDDATE
            // 
            this.OR_ENDDATE.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.OR_ENDDATE.BorderColor = System.Drawing.Color.DarkGray;
            this.OR_ENDDATE.FontSize = 7F;
            this.OR_ENDDATE.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Left;
            this.OR_ENDDATE.Location = new Smobiler.Core.PointS(35F, 76F);
            this.OR_ENDDATE.Name = "OR_ENDDATE";
            this.OR_ENDDATE.Size = new System.Drawing.SizeF(85F, 14F);
            this.OR_ENDDATE.TabIndex = 12;
            // 
            // Label6
            // 
            this.Label6.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label6.BorderColor = System.Drawing.Color.DarkGray;
            this.Label6.ForeColor = System.Drawing.Color.Gray;
            this.Label6.Location = new Smobiler.Core.PointS(0F, 76F);
            this.Label6.Name = "Label6";
            this.Label6.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label6.Size = new System.Drawing.SizeF(35F, 14F);
            this.Label6.TabIndex = 13;
            this.Label6.Text = "结束时间";
            // 
            // OR_STARTDATE
            // 
            this.OR_STARTDATE.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.OR_STARTDATE.BorderColor = System.Drawing.Color.DarkGray;
            this.OR_STARTDATE.FontSize = 7F;
            this.OR_STARTDATE.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Left;
            this.OR_STARTDATE.Location = new Smobiler.Core.PointS(35F, 62F);
            this.OR_STARTDATE.Name = "OR_STARTDATE";
            this.OR_STARTDATE.Size = new System.Drawing.SizeF(85F, 14F);
            this.OR_STARTDATE.TabIndex = 14;
            // 
            // Label7
            // 
            this.Label7.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label7.BorderColor = System.Drawing.Color.DarkGray;
            this.Label7.ForeColor = System.Drawing.Color.Gray;
            this.Label7.Location = new Smobiler.Core.PointS(0F, 90F);
            this.Label7.Name = "Label7";
            this.Label7.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label7.Size = new System.Drawing.SizeF(35F, 14F);
            this.Label7.TabIndex = 15;
            this.Label7.Text = "处理结果";
            // 
            // btnOR_PROCESSRESULT
            // 
            this.btnOR_PROCESSRESULT.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.btnOR_PROCESSRESULT.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOR_PROCESSRESULT.FontSize = 7F;
            this.btnOR_PROCESSRESULT.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Left;
            this.btnOR_PROCESSRESULT.Location = new Smobiler.Core.PointS(35F, 90F);
            this.btnOR_PROCESSRESULT.Name = "btnOR_PROCESSRESULT";
            this.btnOR_PROCESSRESULT.Size = new System.Drawing.SizeF(71F, 14F);
            this.btnOR_PROCESSRESULT.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btnOR_PROCESSRESULT.TabIndex = 16;
            this.btnOR_PROCESSRESULT.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnpop_Click);
            // 
            // btnOR_PROCESSRESULT2
            // 
            this.btnOR_PROCESSRESULT2.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.btnOR_PROCESSRESULT2.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOR_PROCESSRESULT2.FontSize = 8F;
            this.btnOR_PROCESSRESULT2.ForeColor = System.Drawing.Color.Gray;
            this.btnOR_PROCESSRESULT2.Location = new Smobiler.Core.PointS(106F, 90F);
            this.btnOR_PROCESSRESULT2.Name = "btnOR_PROCESSRESULT2";
            this.btnOR_PROCESSRESULT2.Size = new System.Drawing.SizeF(14F, 14F);
            this.btnOR_PROCESSRESULT2.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btnOR_PROCESSRESULT2.TabIndex = 17;
            this.btnOR_PROCESSRESULT2.Text = ">";
            this.btnOR_PROCESSRESULT2.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnpop_Click);
            // 
            // Label8
            // 
            this.Label8.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label8.BorderColor = System.Drawing.Color.DarkGray;
            this.Label8.ForeColor = System.Drawing.Color.Gray;
            this.Label8.Location = new Smobiler.Core.PointS(0F, 104F);
            this.Label8.Name = "Label8";
            this.Label8.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label8.Size = new System.Drawing.SizeF(35F, 14F);
            this.Label8.TabIndex = 18;
            this.Label8.Text = "维护人员";
            // 
            // btnOR_MAINTAINER
            // 
            this.btnOR_MAINTAINER.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.btnOR_MAINTAINER.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOR_MAINTAINER.FontSize = 7F;
            this.btnOR_MAINTAINER.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Left;
            this.btnOR_MAINTAINER.Location = new Smobiler.Core.PointS(35F, 104F);
            this.btnOR_MAINTAINER.Name = "btnOR_MAINTAINER";
            this.btnOR_MAINTAINER.Size = new System.Drawing.SizeF(71F, 14F);
            this.btnOR_MAINTAINER.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btnOR_MAINTAINER.TabIndex = 19;
            this.btnOR_MAINTAINER.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnpop_Click);
            // 
            // btnOR_MAINTAINER2
            // 
            this.btnOR_MAINTAINER2.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.btnOR_MAINTAINER2.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOR_MAINTAINER2.FontSize = 8F;
            this.btnOR_MAINTAINER2.ForeColor = System.Drawing.Color.Gray;
            this.btnOR_MAINTAINER2.Location = new Smobiler.Core.PointS(106F, 104F);
            this.btnOR_MAINTAINER2.Name = "btnOR_MAINTAINER2";
            this.btnOR_MAINTAINER2.Size = new System.Drawing.SizeF(14F, 14F);
            this.btnOR_MAINTAINER2.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btnOR_MAINTAINER2.TabIndex = 20;
            this.btnOR_MAINTAINER2.Text = ">";
            this.btnOR_MAINTAINER2.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnpop_Click);
            // 
            // Label9
            // 
            this.Label9.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label9.BorderColor = System.Drawing.Color.DarkGray;
            this.Label9.ForeColor = System.Drawing.Color.Gray;
            this.Label9.Location = new Smobiler.Core.PointS(0F, 121F);
            this.Label9.Name = "Label9";
            this.Label9.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label9.Size = new System.Drawing.SizeF(35F, 40F);
            this.Label9.TabIndex = 21;
            this.Label9.Text = "故障描述";
            // 
            // txtOR_FAULTINFO
            // 
            this.txtOR_FAULTINFO.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.txtOR_FAULTINFO.BorderColor = System.Drawing.Color.DarkGray;
            this.txtOR_FAULTINFO.FontSize = 7F;
            this.txtOR_FAULTINFO.Location = new Smobiler.Core.PointS(35F, 121F);
            this.txtOR_FAULTINFO.Multiline = true;
            this.txtOR_FAULTINFO.Name = "txtOR_FAULTINFO";
            this.txtOR_FAULTINFO.Size = new System.Drawing.SizeF(85F, 40F);
            this.txtOR_FAULTINFO.TabIndex = 22;
            this.txtOR_FAULTINFO.WaterMarkText = "故障描述（必填）";
            // 
            // Label10
            // 
            this.Label10.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label10.BorderColor = System.Drawing.Color.DarkGray;
            this.Label10.ForeColor = System.Drawing.Color.Gray;
            this.Label10.Location = new Smobiler.Core.PointS(0F, 161F);
            this.Label10.Name = "Label10";
            this.Label10.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label10.Size = new System.Drawing.SizeF(35F, 40F);
            this.Label10.TabIndex = 23;
            this.Label10.Text = "原因分析";
            // 
            // txtOR_REASONANALYSIS
            // 
            this.txtOR_REASONANALYSIS.BorderColor = System.Drawing.Color.DarkGray;
            this.txtOR_REASONANALYSIS.FontSize = 7F;
            this.txtOR_REASONANALYSIS.Location = new Smobiler.Core.PointS(35F, 161F);
            this.txtOR_REASONANALYSIS.Multiline = true;
            this.txtOR_REASONANALYSIS.Name = "txtOR_REASONANALYSIS";
            this.txtOR_REASONANALYSIS.Size = new System.Drawing.SizeF(85F, 40F);
            this.txtOR_REASONANALYSIS.TabIndex = 24;
            this.txtOR_REASONANALYSIS.WaterMarkText = "原因分析（选填）";
            // 
            // Label12
            // 
            this.Label12.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label12.BorderColor = System.Drawing.Color.DarkGray;
            this.Label12.ForeColor = System.Drawing.Color.Gray;
            this.Label12.Location = new Smobiler.Core.PointS(0F, 204F);
            this.Label12.Name = "Label12";
            this.Label12.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label12.Size = new System.Drawing.SizeF(35F, 40F);
            this.Label12.TabIndex = 26;
            this.Label12.Text = "处理方式";
            // 
            // txtOR_PROCESSMODE
            // 
            this.txtOR_PROCESSMODE.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.txtOR_PROCESSMODE.BorderColor = System.Drawing.Color.DarkGray;
            this.txtOR_PROCESSMODE.FontSize = 7F;
            this.txtOR_PROCESSMODE.Location = new Smobiler.Core.PointS(35F, 204F);
            this.txtOR_PROCESSMODE.Multiline = true;
            this.txtOR_PROCESSMODE.Name = "txtOR_PROCESSMODE";
            this.txtOR_PROCESSMODE.Size = new System.Drawing.SizeF(85F, 40F);
            this.txtOR_PROCESSMODE.TabIndex = 27;
            this.txtOR_PROCESSMODE.WaterMarkText = "处理方式（选填）";
            // 
            // Label11
            // 
            this.Label11.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label11.BorderColor = System.Drawing.Color.DarkGray;
            this.Label11.ForeColor = System.Drawing.Color.Gray;
            this.Label11.Location = new Smobiler.Core.PointS(0F, 244F);
            this.Label11.Name = "Label11";
            this.Label11.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label11.Size = new System.Drawing.SizeF(35F, 40F);
            this.Label11.TabIndex = 28;
            this.Label11.Text = "图片";
            // 
            // OR_IMG
            // 
            this.OR_IMG.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.OR_IMG.BorderColor = System.Drawing.Color.DarkGray;
            this.OR_IMG.FontSize = 4F;
            this.OR_IMG.Location = new Smobiler.Core.PointS(35F, 244F);
            this.OR_IMG.Name = "OR_IMG";
            this.OR_IMG.Size = new System.Drawing.SizeF(85F, 40F);
            this.OR_IMG.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.OR_IMG.TabIndex = 29;
            this.OR_IMG.Text = "图片上传";
            this.OR_IMG.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.OR_IMG_Click);
            // 
            // Label13
            // 
            this.Label13.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label13.BorderColor = System.Drawing.Color.DarkGray;
            this.Label13.ForeColor = System.Drawing.Color.Gray;
            this.Label13.Location = new Smobiler.Core.PointS(0F, 284F);
            this.Label13.Name = "Label13";
            this.Label13.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label13.Size = new System.Drawing.SizeF(35F, 40F);
            this.Label13.TabIndex = 30;
            this.Label13.Text = "备注";
            // 
            // txtOR_NOTE
            // 
            this.txtOR_NOTE.BorderColor = System.Drawing.Color.DarkGray;
            this.txtOR_NOTE.FontSize = 7F;
            this.txtOR_NOTE.Location = new Smobiler.Core.PointS(35F, 284F);
            this.txtOR_NOTE.Multiline = true;
            this.txtOR_NOTE.Name = "txtOR_NOTE";
            this.txtOR_NOTE.Size = new System.Drawing.SizeF(85F, 40F);
            this.txtOR_NOTE.TabIndex = 31;
            this.txtOR_NOTE.WaterMarkText = "备注（选填）";
            // 
            // Camera1
            // 
            this.Camera1.Name = "Camera1";
            this.Camera1.ImageCaptured += new Smobiler.Core.CameraOnlineCallBackHandler(this.Camera1_ImageCaptured);
            // 
            // PopList1
            // 
            this.PopList1.Name = "PopList1";
            this.PopList1.Selected += new System.EventHandler(this.PopList1_Selected);
            // 
            // tExit
            // 
            this.tExit.IconID = "Exit";
            this.tExit.Name = "tExit";
            this.tExit.Text = "返回";
            // 
            // save
            // 
            this.save.IconID = "save";
            this.save.Name = "save";
            this.save.Text = "保存";
            // 
            // frmOperationalRCreate
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ComponentControls.AddRange(new Smobiler.Core.ComponentBase[] {
            this.Camera1,
            this.PopList1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label1,
            this.btnCU,
            this.btnCU2,
            this.Label2,
            this.txtOR_DECLARANT,
            this.Label3,
            this.txtOR_CONTACTTEL,
            this.Label4,
            this.OR_DECLAREDATE,
            this.Label5,
            this.OR_ENDDATE,
            this.Label6,
            this.OR_STARTDATE,
            this.Label7,
            this.btnOR_PROCESSRESULT,
            this.btnOR_PROCESSRESULT2,
            this.Label8,
            this.btnOR_MAINTAINER,
            this.btnOR_MAINTAINER2,
            this.Label9,
            this.txtOR_FAULTINFO,
            this.Label10,
            this.txtOR_REASONANALYSIS,
            this.Label12,
            this.txtOR_PROCESSMODE,
            this.Label11,
            this.OR_IMG,
            this.Label13,
            this.txtOR_NOTE});
            this.Size = new System.Drawing.Size(120, 330);
            this.TitleBackColor = System.Drawing.Color.DeepSkyBlue;
            this.TitleText = "运维记录创建";
            this.Toolbar.AddRange(new Smobiler.Core.Controls.ToolbarItem[] {
            this.tExit,
            this.save});
            this.Load += new System.EventHandler(this.frmOperationalRCreate_Load);
            this.ToolbarItemClick += new Smobiler.Core.ToolbarItemClickEventHandler(this.frmOperationalRCreate_ToolbarItemClick);

        }
        internal Smobiler.Core.Controls.Label Label1;
        internal Smobiler.Core.Controls.Button btnCU;
        internal Smobiler.Core.Controls.Button btnCU2;
        internal Smobiler.Core.Controls.Label Label2;
        internal Smobiler.Core.Controls.TextBox txtOR_DECLARANT;
        internal Smobiler.Core.Controls.Label Label3;
        internal Smobiler.Core.Controls.TextBox txtOR_CONTACTTEL;
        internal Smobiler.Core.Controls.Label Label4;
        internal Smobiler.Core.Controls.DatePicker OR_DECLAREDATE;
        internal Smobiler.Core.Controls.Label Label5;
        internal Smobiler.Core.Controls.DatePicker OR_ENDDATE;
        internal Smobiler.Core.Controls.Label Label6;
        internal Smobiler.Core.Controls.DatePicker OR_STARTDATE;
        internal Smobiler.Core.Controls.Label Label7;
        internal Smobiler.Core.Controls.Button btnOR_PROCESSRESULT;
        internal Smobiler.Core.Controls.Button btnOR_PROCESSRESULT2;
        internal Smobiler.Core.Controls.Label Label8;
        internal Smobiler.Core.Controls.Button btnOR_MAINTAINER;
        internal Smobiler.Core.Controls.Button btnOR_MAINTAINER2;
        internal Smobiler.Core.Controls.Label Label9;
        internal Smobiler.Core.Controls.TextBox txtOR_FAULTINFO;
        internal Smobiler.Core.Controls.Label Label10;
        internal Smobiler.Core.Controls.TextBox txtOR_REASONANALYSIS;
        internal Smobiler.Core.Controls.Label Label12;
        internal Smobiler.Core.Controls.TextBox txtOR_PROCESSMODE;
        internal Smobiler.Core.Controls.Label Label11;
        internal Smobiler.Core.Controls.ImageButton OR_IMG;
        internal Smobiler.Core.Controls.Label Label13;
        internal Smobiler.Core.Controls.TextBox txtOR_NOTE;
        internal Smobiler.Core.Controls.Camera Camera1;
        internal Smobiler.Core.Controls.PopList PopList1;
        internal Smobiler.Core.Controls.ToolbarItem tExit;

        internal Smobiler.Core.Controls.ToolbarItem save;
        #endregion

    }

}