using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
namespace COMSSmobilerDemo.Leave
{
    public partial class frmLeaveEdit : Smobiler.Core.MobileForm
    {

        #region "SmobilerForm Designer generated code "

        public frmLeaveEdit()
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
            this.LIMG = new Smobiler.Core.Controls.Image();
            this.Camera1 = new Smobiler.Core.Controls.Camera();
            this.Label7 = new Smobiler.Core.Controls.Label();
            this.btnCUser = new Smobiler.Core.Controls.Button();
            this.BtnCUser2 = new Smobiler.Core.Controls.Button();
            this.save = new Smobiler.Core.Controls.ToolbarItem();
            this.Label8 = new Smobiler.Core.Controls.Label();
            this.btnccuser1 = new Smobiler.Core.Controls.Button();
            this.Btnccuser2 = new Smobiler.Core.Controls.Button();
            this.PopList1 = new Smobiler.Core.Controls.PopList();
            this.Post = new Smobiler.Core.Controls.ToolbarItem();
            this.lblREFUSENOTE1 = new Smobiler.Core.Controls.Label();
            this.lblREFUSENOTE = new Smobiler.Core.Controls.Label();
            this.Label9 = new Smobiler.Core.Controls.Label();
            this.btnupPhoto = new Smobiler.Core.Controls.Button();
            this.btndelPhoto = new Smobiler.Core.Controls.Button();
            this.Label10 = new Smobiler.Core.Controls.Label();
            // 
            // Label1
            // 
            this.Label1.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label1.Name = "Label1";
            this.Label1.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label1.Size = new System.Drawing.Size(88,35);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "请假类型";
            // 
            // btntype
            // 
            this.btntype.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.btntype.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btntype.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btntype.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btntype.Location = new System.Drawing.Point(88,0);
            this.btntype.Name = "btntype";
            this.btntype.Padding = new Smobiler.Core.Padding(0F, 0F, 2F, 0F);
            this.btntype.Size = new System.Drawing.Size(188,35);
            this.btntype.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btntype.TabIndex = 4;
            this.btntype.Text = "选择（必填）";
            this.btntype.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btntype_Click);
            // 
            // btntype2
            // 
            this.btntype2.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.btntype2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btntype2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btntype2.Location = new System.Drawing.Point(275,0);
            this.btntype2.Name = "btntype2";
            this.btntype2.Size = new System.Drawing.Size(25,35);
            this.btntype2.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btntype2.TabIndex = 5;
            this.btntype2.Text = ">";
            this.btntype2.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btntype_Click);
            // 
            // LBDATE
            // 
            this.LBDATE.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.LBDATE.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.LBDATE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.LBDATE.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.LBDATE.Location = new System.Drawing.Point(88,35);
            this.LBDATE.Name = "LBDATE";
            this.LBDATE.Padding = new Smobiler.Core.Padding(0F, 0F, 12F, 0F);
            this.LBDATE.Size = new System.Drawing.Size(213,35);
            this.LBDATE.TabIndex = 6;
            // 
            // Label2
            // 
            this.Label2.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label2.Location = new System.Drawing.Point(0,35);
            this.Label2.Name = "Label2";
            this.Label2.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label2.Size = new System.Drawing.Size(88,35);
            this.Label2.TabIndex = 7;
            this.Label2.Text = "开始时间";
            // 
            // Label3
            // 
            this.Label3.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label3.Location = new System.Drawing.Point(0,70);
            this.Label3.Name = "Label3";
            this.Label3.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label3.Size = new System.Drawing.Size(88,35);
            this.Label3.TabIndex = 8;
            this.Label3.Text = "结束时间";
            // 
            // LEDATE
            // 
            this.LEDATE.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.LEDATE.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.LEDATE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.LEDATE.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.LEDATE.Location = new System.Drawing.Point(88,70);
            this.LEDATE.Name = "LEDATE";
            this.LEDATE.Padding = new Smobiler.Core.Padding(0F, 0F, 12F, 0F);
            this.LEDATE.Size = new System.Drawing.Size(213,35);
            this.LEDATE.TabIndex = 9;
            // 
            // Label4
            // 
            this.Label4.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label4.Location = new System.Drawing.Point(0,113);
            this.Label4.Name = "Label4";
            this.Label4.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label4.Size = new System.Drawing.Size(88,35);
            this.Label4.TabIndex = 10;
            this.Label4.Text = "请假天数";
            // 
            // LDAY
            // 
            this.LDAY.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.LDAY.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.LDAY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.LDAY.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.LDAY.InputType = Smobiler.Core.TextBoxInputType.Number;
            this.LDAY.Location = new System.Drawing.Point(88,113);
            this.LDAY.Name = "LDAY";
            this.LDAY.Padding = new Smobiler.Core.Padding(0F, 0F, 2F, 0F);
            this.LDAY.Size = new System.Drawing.Size(168,35);
            this.LDAY.TabIndex = 11;
            this.LDAY.Text = "1.00";
            this.LDAY.WaterMarkText = "（必填）";
            // 
            // Label5
            // 
            this.Label5.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label5.Location = new System.Drawing.Point(0,148);
            this.Label5.Name = "Label5";
            this.Label5.Padding = new Smobiler.Core.Padding(2F, 5F, 0F, 0F);
            this.Label5.Size = new System.Drawing.Size(88,100);
            this.Label5.TabIndex = 12;
            this.Label5.Text = "请假事由";
            this.Label5.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            // 
            // LREASON
            // 
            this.LREASON.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.LREASON.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.LREASON.Location = new System.Drawing.Point(88,148);
            this.LREASON.Multiline = true;
            this.LREASON.Name = "LREASON";
            this.LREASON.Padding = new Smobiler.Core.Padding(0F, 5F, 12F, 0F);
            this.LREASON.Size = new System.Drawing.Size(213,100);
            this.LREASON.TabIndex = 13;
            this.LREASON.WaterMarkText = "（必填）";
            // 
            // Label6
            // 
            this.Label6.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label6.Location = new System.Drawing.Point(0,255);
            this.Label6.Name = "Label6";
            this.Label6.Padding = new Smobiler.Core.Padding(2F, 5F, 0F, 0F);
            this.Label6.Size = new System.Drawing.Size(88,100);
            this.Label6.TabIndex = 14;
            this.Label6.Text = "图片";
            this.Label6.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            // 
            // LIMG
            // 
            this.LIMG.Border = new Smobiler.Core.Border(0, 1, 0, 0);
            this.LIMG.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.LIMG.Enlarged = true;
            this.LIMG.ID = "";
            this.LIMG.Location = new System.Drawing.Point(88,255);
            this.LIMG.Name = "LIMG";
            this.LIMG.Padding = new Smobiler.Core.Padding(0F, 2F, 0F, 0F);
            this.LIMG.Size = new System.Drawing.Size(213,70);
            this.LIMG.TabIndex = 15;
            // 
            // Camera1
            // 
            this.Camera1.Name = "Camera1";
            this.Camera1.ImageCaptured += new Smobiler.Core.CameraOnlineCallBackHandler(this.Camera1_ImageCaptured);
            // 
            // Label7
            // 
            this.Label7.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label7.Location = new System.Drawing.Point(0,363);
            this.Label7.Name = "Label7";
            this.Label7.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label7.Size = new System.Drawing.Size(88,35);
            this.Label7.TabIndex = 16;
            this.Label7.Text = "审批人";
            // 
            // btnCUser
            // 
            this.btnCUser.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.btnCUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnCUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnCUser.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnCUser.Location = new System.Drawing.Point(88,363);
            this.btnCUser.Name = "btnCUser";
            this.btnCUser.Padding = new Smobiler.Core.Padding(0F, 0F, 2F, 0F);
            this.btnCUser.Size = new System.Drawing.Size(188,35);
            this.btnCUser.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btnCUser.TabIndex = 18;
            this.btnCUser.Text = "（必填）";
            this.btnCUser.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.BtnCUser_Click);
            // 
            // BtnCUser2
            // 
            this.BtnCUser2.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.BtnCUser2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.BtnCUser2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.BtnCUser2.Location = new System.Drawing.Point(275,363);
            this.BtnCUser2.Name = "BtnCUser2";
            this.BtnCUser2.Size = new System.Drawing.Size(25,35);
            this.BtnCUser2.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.BtnCUser2.TabIndex = 19;
            this.BtnCUser2.Text = ">";
            this.BtnCUser2.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.BtnCUser_Click);
            // 
            // save
            // 
            this.save.IconID = "!\\ue161043146223";
            this.save.Name = "save";
            this.save.Text = "保存";
            // 
            // Label8
            // 
            this.Label8.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label8.Location = new System.Drawing.Point(0,398);
            this.Label8.Name = "Label8";
            this.Label8.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label8.Size = new System.Drawing.Size(88,35);
            this.Label8.TabIndex = 20;
            this.Label8.Text = "抄送人";
            // 
            // btnccuser1
            // 
            this.btnccuser1.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.btnccuser1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnccuser1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnccuser1.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnccuser1.Location = new System.Drawing.Point(88,398);
            this.btnccuser1.Name = "btnccuser1";
            this.btnccuser1.Padding = new Smobiler.Core.Padding(0F, 0F, 2F, 0F);
            this.btnccuser1.Size = new System.Drawing.Size(188,35);
            this.btnccuser1.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btnccuser1.TabIndex = 21;
            this.btnccuser1.Text = "（选填）";
            this.btnccuser1.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.BtnCUser_Click);
            // 
            // Btnccuser2
            // 
            this.Btnccuser2.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Btnccuser2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Btnccuser2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.Btnccuser2.Location = new System.Drawing.Point(275,398);
            this.Btnccuser2.Name = "Btnccuser2";
            this.Btnccuser2.Size = new System.Drawing.Size(25,35);
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
            // Post
            // 
            this.Post.IconID = "!\\ue876043146223";
            this.Post.Name = "Post";
            this.Post.Text = "送审";
            // 
            // lblREFUSENOTE1
            // 
            this.lblREFUSENOTE1.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.lblREFUSENOTE1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblREFUSENOTE1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblREFUSENOTE1.Location = new System.Drawing.Point(0,440);
            this.lblREFUSENOTE1.Name = "lblREFUSENOTE1";
            this.lblREFUSENOTE1.Padding = new Smobiler.Core.Padding(2F, 5F, 0F, 0F);
            this.lblREFUSENOTE1.Size = new System.Drawing.Size(88,100);
            this.lblREFUSENOTE1.TabIndex = 27;
            this.lblREFUSENOTE1.Text = "拒绝理由";
            this.lblREFUSENOTE1.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            this.lblREFUSENOTE1.Visible = false;
            // 
            // lblREFUSENOTE
            // 
            this.lblREFUSENOTE.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.lblREFUSENOTE.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblREFUSENOTE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.lblREFUSENOTE.Location = new System.Drawing.Point(88,440);
            this.lblREFUSENOTE.Name = "lblREFUSENOTE";
            this.lblREFUSENOTE.Padding = new Smobiler.Core.Padding(0F, 5F, 12F, 0F);
            this.lblREFUSENOTE.Size = new System.Drawing.Size(213,100);
            this.lblREFUSENOTE.TabIndex = 28;
            this.lblREFUSENOTE.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            this.lblREFUSENOTE.Visible = false;
            // 
            // Label9
            // 
            this.Label9.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label9.Location = new System.Drawing.Point(88,325);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(213,30);
            this.Label9.TabIndex = 29;
            // 
            // btnupPhoto
            // 
            this.btnupPhoto.Border = new Smobiler.Core.Border(1);
            this.btnupPhoto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnupPhoto.BorderRadius = 5;
            this.btnupPhoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnupPhoto.Location = new System.Drawing.Point(123,330);
            this.btnupPhoto.Name = "btnupPhoto";
            this.btnupPhoto.Size = new System.Drawing.Size(65,20);
            this.btnupPhoto.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btnupPhoto.TabIndex = 30;
            this.btnupPhoto.Text = "上传";
            // 
            // btndelPhoto
            // 
            this.btndelPhoto.Border = new Smobiler.Core.Border(1);
            this.btndelPhoto.BorderColor = System.Drawing.Color.Red;
            this.btndelPhoto.BorderRadius = 5;
            this.btndelPhoto.ForeColor = System.Drawing.Color.Red;
            this.btndelPhoto.Location = new System.Drawing.Point(200,330);
            this.btndelPhoto.Name = "btndelPhoto";
            this.btndelPhoto.Size = new System.Drawing.Size(65,20);
            this.btndelPhoto.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btndelPhoto.TabIndex = 31;
            this.btndelPhoto.Text = "删除";
            this.btndelPhoto.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btndelPhoto_Click);
            // 
            // Label10
            // 
            this.Label10.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.Label10.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.Label10.Location = new System.Drawing.Point(255,113);
            this.Label10.Name = "Label10";
            this.Label10.Padding = new Smobiler.Core.Padding(0F, 0F, 12F, 0F);
            this.Label10.Size = new System.Drawing.Size(45,35);
            this.Label10.TabIndex = 32;
            this.Label10.Text = "天";
            // 
            // frmLeaveEdit
            // 
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
            this.btnCUser,
            this.BtnCUser2,
            this.Label8,
            this.btnccuser1,
            this.Btnccuser2,
            this.lblREFUSENOTE1,
            this.lblREFUSENOTE,
            this.Label9,
            this.btnupPhoto,
            this.btndelPhoto,
            this.Label10});
            this.Size = new System.Drawing.Size(300,550);
            this.StatusBarStyle = Smobiler.Core.StatusBarStyle.Default;
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("Exit", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(50))))));
            this.TitleText = "请假编辑";
            this.Toolbar.AddRange(new Smobiler.Core.Controls.ToolbarItem[] {
            this.save,
            this.Post});
            this.ToolbarStyle = new Smobiler.Core.ToolBarSytle(Smobiler.Core.ToolbarSelectStyle.None, System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))), System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))));
            this.Load += new System.EventHandler(this.frmLeaveEdit_Load);
            this.ToolbarItemClick += new Smobiler.Core.ToolbarItemClickEventHandler(this.frmLeaveEdit_ToolbarItemClick);
            this.TitleImageClick += new System.EventHandler(this.MobileForm_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.MobileForm_KeyDown);
            this.Name = "frmLeaveEdit";

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
        internal Smobiler.Core.Controls.Image LIMG;
        internal Smobiler.Core.Controls.Camera Camera1;
        internal Smobiler.Core.Controls.Label Label7;
        internal Smobiler.Core.Controls.Button btnCUser;
        internal Smobiler.Core.Controls.Button BtnCUser2;
        internal Smobiler.Core.Controls.ToolbarItem save;
        internal Smobiler.Core.Controls.Label Label8;
        internal Smobiler.Core.Controls.Button btnccuser1;
        internal Smobiler.Core.Controls.Button Btnccuser2;
        internal Smobiler.Core.Controls.PopList PopList1;
        internal Smobiler.Core.Controls.ToolbarItem Post;
        internal Smobiler.Core.Controls.Label lblREFUSENOTE1;
        internal Smobiler.Core.Controls.Label lblREFUSENOTE;
        internal Smobiler.Core.Controls.Label Label9;
        internal Smobiler.Core.Controls.Button btnupPhoto;
        internal Smobiler.Core.Controls.Button btndelPhoto;
        internal Smobiler.Core.Controls.Label Label10;
        #endregion

    }
}
