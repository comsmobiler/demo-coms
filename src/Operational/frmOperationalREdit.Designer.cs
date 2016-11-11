using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
namespace COMSSmobilerDemo.Operational
{
    public partial class frmOperationalREdit : Smobiler.Core.MobileForm
    {

        #region "SmobilerForm Designer generated code "

        public frmOperationalREdit()
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
            this.OR_IMG = new Smobiler.Core.Controls.Image();
            this.Label13 = new Smobiler.Core.Controls.Label();
            this.txtOR_NOTE = new Smobiler.Core.Controls.TextBox();
            this.Camera1 = new Smobiler.Core.Controls.Camera();
            this.PopList1 = new Smobiler.Core.Controls.PopList();
            this.save = new Smobiler.Core.Controls.ToolbarItem();
            this.Label14 = new Smobiler.Core.Controls.Label();
            this.lblOR_NO = new Smobiler.Core.Controls.Label();
            this.Label15 = new Smobiler.Core.Controls.Label();
            this.btnupPhoto = new Smobiler.Core.Controls.Button();
            this.btndelPhoto = new Smobiler.Core.Controls.Button();
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
            this.Label1.Text = "运维编号";
            this.Label1.ZIndex = 1;
            // 
            // btnCU
            // 
            this.btnCU.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.btnCU.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnCU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnCU.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnCU.Location = new System.Drawing.Point(88, 35);
            this.btnCU.Name = "btnCU";
            this.btnCU.Padding = new Smobiler.Core.Padding(0F, 0F, 5F, 0F);
            this.btnCU.Size = new System.Drawing.Size(188, 35);
            this.btnCU.TabIndex = 3;
            this.btnCU.Text = "选择（必填）";
            this.btnCU.ZIndex = 4;
            this.btnCU.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnpop_Click);
            // 
            // btnCU2
            // 
            this.btnCU2.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.btnCU2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnCU2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnCU2.Location = new System.Drawing.Point(275, 35);
            this.btnCU2.Name = "btnCU2";
            this.btnCU2.Size = new System.Drawing.Size(25, 35);
            this.btnCU2.TabIndex = 4;
            this.btnCU2.Text = ">";
            this.btnCU2.ZIndex = 5;
            this.btnCU2.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnpop_Click);
            // 
            // Label2
            // 
            this.Label2.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label2.Location = new System.Drawing.Point(0, 78);
            this.Label2.Name = "Label2";
            this.Label2.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label2.Size = new System.Drawing.Size(88, 35);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "申报人";
            this.Label2.ZIndex = 6;
            // 
            // txtOR_DECLARANT
            // 
            this.txtOR_DECLARANT.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.txtOR_DECLARANT.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtOR_DECLARANT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txtOR_DECLARANT.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.txtOR_DECLARANT.Location = new System.Drawing.Point(88, 78);
            this.txtOR_DECLARANT.Name = "txtOR_DECLARANT";
            this.txtOR_DECLARANT.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.txtOR_DECLARANT.Size = new System.Drawing.Size(213, 35);
            this.txtOR_DECLARANT.TabIndex = 6;
            this.txtOR_DECLARANT.WaterMarkText = "（必填）";
            this.txtOR_DECLARANT.ZIndex = 7;
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
            this.Label3.TabIndex = 7;
            this.Label3.Text = "联系方式";
            this.Label3.ZIndex = 8;
            // 
            // txtOR_CONTACTTEL
            // 
            this.txtOR_CONTACTTEL.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.txtOR_CONTACTTEL.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtOR_CONTACTTEL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txtOR_CONTACTTEL.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.txtOR_CONTACTTEL.InputType = Smobiler.Core.TextBoxInputType.Number;
            this.txtOR_CONTACTTEL.Location = new System.Drawing.Point(88, 113);
            this.txtOR_CONTACTTEL.Name = "txtOR_CONTACTTEL";
            this.txtOR_CONTACTTEL.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.txtOR_CONTACTTEL.Size = new System.Drawing.Size(213, 35);
            this.txtOR_CONTACTTEL.TabIndex = 8;
            this.txtOR_CONTACTTEL.WaterMarkText = "（选填）";
            this.txtOR_CONTACTTEL.ZIndex = 9;
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
            this.Label4.TabIndex = 9;
            this.Label4.Text = "申报时间";
            this.Label4.ZIndex = 10;
            // 
            // OR_DECLAREDATE
            // 
            this.OR_DECLAREDATE.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.OR_DECLAREDATE.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.OR_DECLAREDATE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.OR_DECLAREDATE.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.OR_DECLAREDATE.Location = new System.Drawing.Point(88, 148);
            this.OR_DECLAREDATE.Name = "OR_DECLAREDATE";
            this.OR_DECLAREDATE.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.OR_DECLAREDATE.Size = new System.Drawing.Size(213, 35);
            this.OR_DECLAREDATE.TabIndex = 10;
            this.OR_DECLAREDATE.ZIndex = 11;
            // 
            // Label5
            // 
            this.Label5.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label5.Location = new System.Drawing.Point(0, 190);
            this.Label5.Name = "Label5";
            this.Label5.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label5.Size = new System.Drawing.Size(88, 35);
            this.Label5.TabIndex = 11;
            this.Label5.Text = "开始时间";
            this.Label5.ZIndex = 12;
            // 
            // OR_ENDDATE
            // 
            this.OR_ENDDATE.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.OR_ENDDATE.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.OR_ENDDATE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.OR_ENDDATE.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.OR_ENDDATE.Location = new System.Drawing.Point(88, 225);
            this.OR_ENDDATE.Name = "OR_ENDDATE";
            this.OR_ENDDATE.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.OR_ENDDATE.Size = new System.Drawing.Size(213, 35);
            this.OR_ENDDATE.TabIndex = 12;
            this.OR_ENDDATE.ZIndex = 15;
            // 
            // Label6
            // 
            this.Label6.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label6.Location = new System.Drawing.Point(0, 225);
            this.Label6.Name = "Label6";
            this.Label6.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label6.Size = new System.Drawing.Size(88, 35);
            this.Label6.TabIndex = 13;
            this.Label6.Text = "结束时间";
            this.Label6.ZIndex = 14;
            // 
            // OR_STARTDATE
            // 
            this.OR_STARTDATE.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.OR_STARTDATE.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.OR_STARTDATE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.OR_STARTDATE.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.OR_STARTDATE.Location = new System.Drawing.Point(88, 190);
            this.OR_STARTDATE.Name = "OR_STARTDATE";
            this.OR_STARTDATE.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.OR_STARTDATE.Size = new System.Drawing.Size(213, 35);
            this.OR_STARTDATE.TabIndex = 14;
            this.OR_STARTDATE.ZIndex = 13;
            // 
            // Label7
            // 
            this.Label7.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label7.Location = new System.Drawing.Point(0, 260);
            this.Label7.Name = "Label7";
            this.Label7.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label7.Size = new System.Drawing.Size(88, 35);
            this.Label7.TabIndex = 15;
            this.Label7.Text = "处理结果";
            this.Label7.ZIndex = 16;
            // 
            // btnOR_PROCESSRESULT
            // 
            this.btnOR_PROCESSRESULT.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.btnOR_PROCESSRESULT.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnOR_PROCESSRESULT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnOR_PROCESSRESULT.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnOR_PROCESSRESULT.Location = new System.Drawing.Point(87, 260);
            this.btnOR_PROCESSRESULT.Name = "btnOR_PROCESSRESULT";
            this.btnOR_PROCESSRESULT.Padding = new Smobiler.Core.Padding(0F, 0F, 5F, 0F);
            this.btnOR_PROCESSRESULT.Size = new System.Drawing.Size(188, 35);
            this.btnOR_PROCESSRESULT.TabIndex = 16;
            this.btnOR_PROCESSRESULT.ZIndex = 17;
            this.btnOR_PROCESSRESULT.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnpop_Click);
            // 
            // btnOR_PROCESSRESULT2
            // 
            this.btnOR_PROCESSRESULT2.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.btnOR_PROCESSRESULT2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnOR_PROCESSRESULT2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnOR_PROCESSRESULT2.Location = new System.Drawing.Point(275, 260);
            this.btnOR_PROCESSRESULT2.Name = "btnOR_PROCESSRESULT2";
            this.btnOR_PROCESSRESULT2.Size = new System.Drawing.Size(25, 35);
            this.btnOR_PROCESSRESULT2.TabIndex = 17;
            this.btnOR_PROCESSRESULT2.Text = ">";
            this.btnOR_PROCESSRESULT2.ZIndex = 18;
            this.btnOR_PROCESSRESULT2.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnpop_Click);
            // 
            // Label8
            // 
            this.Label8.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label8.Location = new System.Drawing.Point(0, 295);
            this.Label8.Name = "Label8";
            this.Label8.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label8.Size = new System.Drawing.Size(88, 35);
            this.Label8.TabIndex = 18;
            this.Label8.Text = "维护人员";
            this.Label8.ZIndex = 19;
            // 
            // btnOR_MAINTAINER
            // 
            this.btnOR_MAINTAINER.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.btnOR_MAINTAINER.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnOR_MAINTAINER.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnOR_MAINTAINER.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnOR_MAINTAINER.Location = new System.Drawing.Point(87, 295);
            this.btnOR_MAINTAINER.Name = "btnOR_MAINTAINER";
            this.btnOR_MAINTAINER.Padding = new Smobiler.Core.Padding(0F, 0F, 5F, 0F);
            this.btnOR_MAINTAINER.Size = new System.Drawing.Size(188, 35);
            this.btnOR_MAINTAINER.TabIndex = 19;
            this.btnOR_MAINTAINER.ZIndex = 20;
            this.btnOR_MAINTAINER.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnpop_Click);
            // 
            // btnOR_MAINTAINER2
            // 
            this.btnOR_MAINTAINER2.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.btnOR_MAINTAINER2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnOR_MAINTAINER2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnOR_MAINTAINER2.Location = new System.Drawing.Point(275, 295);
            this.btnOR_MAINTAINER2.Name = "btnOR_MAINTAINER2";
            this.btnOR_MAINTAINER2.Size = new System.Drawing.Size(25, 35);
            this.btnOR_MAINTAINER2.TabIndex = 20;
            this.btnOR_MAINTAINER2.Text = ">";
            this.btnOR_MAINTAINER2.ZIndex = 21;
            this.btnOR_MAINTAINER2.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnpop_Click);
            // 
            // Label9
            // 
            this.Label9.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label9.Location = new System.Drawing.Point(0, 338);
            this.Label9.Name = "Label9";
            this.Label9.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label9.Size = new System.Drawing.Size(88, 100);
            this.Label9.TabIndex = 21;
            this.Label9.Text = "故障描述";
            this.Label9.ZIndex = 22;
            // 
            // txtOR_FAULTINFO
            // 
            this.txtOR_FAULTINFO.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.txtOR_FAULTINFO.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtOR_FAULTINFO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txtOR_FAULTINFO.Location = new System.Drawing.Point(88, 338);
            this.txtOR_FAULTINFO.Multiline = true;
            this.txtOR_FAULTINFO.Name = "txtOR_FAULTINFO";
            this.txtOR_FAULTINFO.Padding = new Smobiler.Core.Padding(0F, 5F, 30F, 0F);
            this.txtOR_FAULTINFO.Size = new System.Drawing.Size(213, 100);
            this.txtOR_FAULTINFO.TabIndex = 22;
            this.txtOR_FAULTINFO.WaterMarkText = "（必填）";
            this.txtOR_FAULTINFO.ZIndex = 23;
            // 
            // Label10
            // 
            this.Label10.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label10.Location = new System.Drawing.Point(0, 438);
            this.Label10.Name = "Label10";
            this.Label10.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label10.Size = new System.Drawing.Size(88, 100);
            this.Label10.TabIndex = 23;
            this.Label10.Text = "原因分析";
            this.Label10.ZIndex = 24;
            // 
            // txtOR_REASONANALYSIS
            // 
            this.txtOR_REASONANALYSIS.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtOR_REASONANALYSIS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txtOR_REASONANALYSIS.Location = new System.Drawing.Point(88, 438);
            this.txtOR_REASONANALYSIS.Multiline = true;
            this.txtOR_REASONANALYSIS.Name = "txtOR_REASONANALYSIS";
            this.txtOR_REASONANALYSIS.Padding = new Smobiler.Core.Padding(0F, 5F, 30F, 0F);
            this.txtOR_REASONANALYSIS.Size = new System.Drawing.Size(213, 100);
            this.txtOR_REASONANALYSIS.TabIndex = 24;
            this.txtOR_REASONANALYSIS.WaterMarkText = "（选填）";
            this.txtOR_REASONANALYSIS.ZIndex = 25;
            // 
            // Label12
            // 
            this.Label12.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label12.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label12.Location = new System.Drawing.Point(0, 545);
            this.Label12.Name = "Label12";
            this.Label12.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label12.Size = new System.Drawing.Size(88, 100);
            this.Label12.TabIndex = 26;
            this.Label12.Text = "处理方式";
            this.Label12.ZIndex = 26;
            // 
            // txtOR_PROCESSMODE
            // 
            this.txtOR_PROCESSMODE.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.txtOR_PROCESSMODE.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtOR_PROCESSMODE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txtOR_PROCESSMODE.Location = new System.Drawing.Point(88, 545);
            this.txtOR_PROCESSMODE.Multiline = true;
            this.txtOR_PROCESSMODE.Name = "txtOR_PROCESSMODE";
            this.txtOR_PROCESSMODE.Padding = new Smobiler.Core.Padding(0F, 5F, 30F, 0F);
            this.txtOR_PROCESSMODE.Size = new System.Drawing.Size(213, 100);
            this.txtOR_PROCESSMODE.TabIndex = 27;
            this.txtOR_PROCESSMODE.WaterMarkText = "（选填）";
            this.txtOR_PROCESSMODE.ZIndex = 27;
            // 
            // Label11
            // 
            this.Label11.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label11.Location = new System.Drawing.Point(0, 645);
            this.Label11.Name = "Label11";
            this.Label11.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label11.Size = new System.Drawing.Size(88, 100);
            this.Label11.TabIndex = 28;
            this.Label11.Text = "图片";
            this.Label11.ZIndex = 28;
            // 
            // OR_IMG
            // 
            this.OR_IMG.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.OR_IMG.ID = "";
            this.OR_IMG.Location = new System.Drawing.Point(88, 645);
            this.OR_IMG.Name = "OR_IMG";
            this.OR_IMG.Padding = new Smobiler.Core.Padding(0F, 2F, 0F, 0F);
            this.OR_IMG.Size = new System.Drawing.Size(213, 70);
            this.OR_IMG.TabIndex = 29;
            this.OR_IMG.ZIndex = 29;
            // 
            // Label13
            // 
            this.Label13.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label13.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label13.Location = new System.Drawing.Point(0, 745);
            this.Label13.Name = "Label13";
            this.Label13.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label13.Size = new System.Drawing.Size(88, 100);
            this.Label13.TabIndex = 30;
            this.Label13.Text = "备注";
            this.Label13.ZIndex = 33;
            // 
            // txtOR_NOTE
            // 
            this.txtOR_NOTE.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtOR_NOTE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txtOR_NOTE.Location = new System.Drawing.Point(88, 745);
            this.txtOR_NOTE.Multiline = true;
            this.txtOR_NOTE.Name = "txtOR_NOTE";
            this.txtOR_NOTE.Padding = new Smobiler.Core.Padding(0F, 5F, 30F, 0F);
            this.txtOR_NOTE.Size = new System.Drawing.Size(213, 100);
            this.txtOR_NOTE.TabIndex = 31;
            this.txtOR_NOTE.WaterMarkText = "（选填）";
            this.txtOR_NOTE.ZIndex = 34;
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
            // save
            // 
            this.save.IconID = "!\\ue161043146223";
            this.save.Name = "save";
            this.save.SelectIconID = "!\\ue161043146223";
            this.save.Text = "保存";
            // 
            // Label14
            // 
            this.Label14.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label14.Location = new System.Drawing.Point(0, 35);
            this.Label14.Name = "Label14";
            this.Label14.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label14.Size = new System.Drawing.Size(88, 35);
            this.Label14.TabIndex = 32;
            this.Label14.Text = "客户名称";
            this.Label14.ZIndex = 3;
            // 
            // lblOR_NO
            // 
            this.lblOR_NO.Bold = true;
            this.lblOR_NO.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.lblOR_NO.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblOR_NO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.lblOR_NO.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblOR_NO.Location = new System.Drawing.Point(88, 0);
            this.lblOR_NO.Name = "lblOR_NO";
            this.lblOR_NO.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.lblOR_NO.Size = new System.Drawing.Size(213, 35);
            this.lblOR_NO.TabIndex = 33;
            this.lblOR_NO.ZIndex = 2;
            // 
            // Label15
            // 
            this.Label15.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label15.Location = new System.Drawing.Point(88, 715);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(213, 30);
            this.Label15.TabIndex = 34;
            this.Label15.ZIndex = 30;
            // 
            // btnupPhoto
            // 
            this.btnupPhoto.Border = new Smobiler.Core.Border(1);
            this.btnupPhoto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnupPhoto.BorderRadius = 5;
            this.btnupPhoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnupPhoto.Location = new System.Drawing.Point(123, 720);
            this.btnupPhoto.Name = "btnupPhoto";
            this.btnupPhoto.Size = new System.Drawing.Size(65, 20);
            this.btnupPhoto.TabIndex = 35;
            this.btnupPhoto.Text = "上传";
            this.btnupPhoto.ZIndex = 31;
            this.btnupPhoto.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnupPhoto_Click);
            // 
            // btndelPhoto
            // 
            this.btndelPhoto.Border = new Smobiler.Core.Border(1);
            this.btndelPhoto.BorderColor = System.Drawing.Color.Red;
            this.btndelPhoto.BorderRadius = 5;
            this.btndelPhoto.ForeColor = System.Drawing.Color.Red;
            this.btndelPhoto.Location = new System.Drawing.Point(200, 720);
            this.btndelPhoto.Name = "btndelPhoto";
            this.btndelPhoto.Size = new System.Drawing.Size(65, 20);
            this.btndelPhoto.TabIndex = 36;
            this.btndelPhoto.Text = "删除";
            this.btndelPhoto.ZIndex = 32;
            this.btndelPhoto.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btndelPhoto_Click);
            // 
            // frmOperationalREdit
            // 
            this.ComponentControls.AddRange(new Smobiler.Core.ComponentBase[] {
            this.Camera1,
            this.PopList1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label1,
            this.lblOR_NO,
            this.Label14,
            this.btnCU,
            this.btnCU2,
            this.Label2,
            this.txtOR_DECLARANT,
            this.Label3,
            this.txtOR_CONTACTTEL,
            this.Label4,
            this.OR_DECLAREDATE,
            this.Label5,
            this.OR_STARTDATE,
            this.Label6,
            this.OR_ENDDATE,
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
            this.Label15,
            this.btnupPhoto,
            this.btndelPhoto,
            this.Label13,
            this.txtOR_NOTE});
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.Size = new System.Drawing.Size(300, 860);
            this.StatusBarStyle = Smobiler.Core.StatusBarStyle.Default;
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("Exit", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(50))))));
            this.TitleText = "运维记录编辑";
            this.Toolbar.AddRange(new Smobiler.Core.Controls.ToolbarItem[] {
            this.save});
            this.ToolbarStyle = new Smobiler.Core.ToolBarSytle(Smobiler.Core.ToolbarSelectStyle.None, System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))), System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))));
            this.Load += new System.EventHandler(this.frmOperationalREdit_Load);
            this.TitleImageClick += new System.EventHandler(this.MobileForm_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.MobileForm_KeyDown);
            this.Name = "frmOperationalREdit";

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
        internal Smobiler.Core.Controls.Image OR_IMG;
        internal Smobiler.Core.Controls.Label Label13;
        internal Smobiler.Core.Controls.TextBox txtOR_NOTE;
        internal Smobiler.Core.Controls.Camera Camera1;
        internal Smobiler.Core.Controls.PopList PopList1;
        internal Smobiler.Core.Controls.ToolbarItem save;
        internal Smobiler.Core.Controls.Label Label14;
        internal Smobiler.Core.Controls.Label lblOR_NO;
        internal Smobiler.Core.Controls.Label Label15;
        internal Smobiler.Core.Controls.Button btnupPhoto;
        internal Smobiler.Core.Controls.Button btndelPhoto;
        #endregion

    }

}
