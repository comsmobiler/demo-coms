using System;
using Smobiler.Core;
namespace COMSSmobilerDemo.FixedAssets.NootBooks
{
    partial class frmNBCreate : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmNBCreate()
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
            this.txtNB_SN = new Smobiler.Core.Controls.TextBox();
            this.Label2 = new Smobiler.Core.Controls.Label();
            this.txtNB_CHECK = new Smobiler.Core.Controls.TextBox();
            this.Label3 = new Smobiler.Core.Controls.Label();
            this.txtNB_MODEL = new Smobiler.Core.Controls.TextBox();
            this.Label4 = new Smobiler.Core.Controls.Label();
            this.txtNB_PRICE = new Smobiler.Core.Controls.TextBox();
            this.Label5 = new Smobiler.Core.Controls.Label();
            this.txtNB_CONFIRMPRICE = new Smobiler.Core.Controls.TextBox();
            this.Label6 = new Smobiler.Core.Controls.Label();
            this.Label7 = new Smobiler.Core.Controls.Label();
            this.Label8 = new Smobiler.Core.Controls.Label();
            this.txtNB_YEAR = new Smobiler.Core.Controls.TextBox();
            this.Label9 = new Smobiler.Core.Controls.Label();
            this.Label11 = new Smobiler.Core.Controls.Label();
            this.dpkNB_BUYDATE = new Smobiler.Core.Controls.DatePicker();
            this.Label10 = new Smobiler.Core.Controls.Label();
            this.txtNB_WARRANTYPERIOD = new Smobiler.Core.Controls.TextBox();
            this.save = new Smobiler.Core.Controls.ToolbarItem();
            this.Label12 = new Smobiler.Core.Controls.Label();
            this.txtNB_CONFIG = new Smobiler.Core.Controls.TextBox();
            this.Label13 = new Smobiler.Core.Controls.Label();
            this.imgNB_INVOCIEIMGID = new Smobiler.Core.Controls.Image();
            this.btnupPhoto = new Smobiler.Core.Controls.Button();
            this.btndelPhoto = new Smobiler.Core.Controls.Button();
            this.Label14 = new Smobiler.Core.Controls.Label();
            this.Label15 = new Smobiler.Core.Controls.Label();
            this.btnNB_OWNER = new Smobiler.Core.Controls.Button();
            this.Label16 = new Smobiler.Core.Controls.Label();
            this.btnState = new Smobiler.Core.Controls.Button();
            this.btnState2 = new Smobiler.Core.Controls.Button();
            this.Label17 = new Smobiler.Core.Controls.Label();
            this.Camera1 = new Smobiler.Core.Controls.Camera();
            this.PopList1 = new Smobiler.Core.Controls.PopList();
            this.btnNB_LOCATION = new Smobiler.Core.Controls.Button();
            this.btnNB_LOCATION2 = new Smobiler.Core.Controls.Button();
            this.btnNB_OWNER2 = new Smobiler.Core.Controls.Button();
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
            this.Label1.Text = "序列号";
            this.Label1.ZIndex = 1;
            // 
            // txtNB_SN
            // 
            this.txtNB_SN.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.txtNB_SN.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtNB_SN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txtNB_SN.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.txtNB_SN.Location = new System.Drawing.Point(70,0);
            this.txtNB_SN.Name = "txtNB_SN";
            this.txtNB_SN.Padding = new Smobiler.Core.Padding(0F, 0F, 12F, 0F);
            this.txtNB_SN.Size = new System.Drawing.Size(170,28);
            this.txtNB_SN.TabIndex = 3;
            this.txtNB_SN.WaterMarkText = "（必填）";
            this.txtNB_SN.ZIndex = 2;
            // 
            // Label2
            // 
            this.Label2.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label2.Location = new System.Drawing.Point(0,90);
            this.Label2.Name = "Label2";
            this.Label2.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label2.Size = new System.Drawing.Size(70,28);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "责任人";
            this.Label2.ZIndex = 3;
            // 
            // txtNB_CHECK
            // 
            this.txtNB_CHECK.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.txtNB_CHECK.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtNB_CHECK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txtNB_CHECK.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.txtNB_CHECK.Location = new System.Drawing.Point(70,90);
            this.txtNB_CHECK.Name = "txtNB_CHECK";
            this.txtNB_CHECK.Padding = new Smobiler.Core.Padding(0F, 0F, 12F, 0F);
            this.txtNB_CHECK.Size = new System.Drawing.Size(170,28);
            this.txtNB_CHECK.TabIndex = 5;
            this.txtNB_CHECK.WaterMarkText = "（必填）";
            this.txtNB_CHECK.ZIndex = 3;
            // 
            // Label3
            // 
            this.Label3.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label3.Location = new System.Drawing.Point(0,28);
            this.Label3.Name = "Label3";
            this.Label3.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label3.Size = new System.Drawing.Size(70,28);
            this.Label3.TabIndex = 6;
            this.Label3.Text = "型号";
            this.Label3.ZIndex = 4;
            // 
            // txtNB_MODEL
            // 
            this.txtNB_MODEL.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.txtNB_MODEL.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtNB_MODEL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txtNB_MODEL.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.txtNB_MODEL.Location = new System.Drawing.Point(70,28);
            this.txtNB_MODEL.Name = "txtNB_MODEL";
            this.txtNB_MODEL.Padding = new Smobiler.Core.Padding(0F, 0F, 12F, 0F);
            this.txtNB_MODEL.Size = new System.Drawing.Size(170,28);
            this.txtNB_MODEL.TabIndex = 7;
            this.txtNB_MODEL.WaterMarkText = "（必填）";
            this.txtNB_MODEL.ZIndex = 4;
            // 
            // Label4
            // 
            this.Label4.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label4.Location = new System.Drawing.Point(0,62);
            this.Label4.Name = "Label4";
            this.Label4.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label4.Size = new System.Drawing.Size(70,28);
            this.Label4.TabIndex = 8;
            this.Label4.Text = "所有者";
            this.Label4.ZIndex = 5;
            // 
            // txtNB_PRICE
            // 
            this.txtNB_PRICE.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.txtNB_PRICE.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtNB_PRICE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txtNB_PRICE.Format = "{\"##.##\"}";
            this.txtNB_PRICE.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.txtNB_PRICE.InputType = Smobiler.Core.TextBoxInputType.Number;
            this.txtNB_PRICE.Location = new System.Drawing.Point(70,328);
            this.txtNB_PRICE.Name = "txtNB_PRICE";
            this.txtNB_PRICE.Padding = new Smobiler.Core.Padding(0F, 0F, 2F, 0F);
            this.txtNB_PRICE.Size = new System.Drawing.Size(134,28);
            this.txtNB_PRICE.TabIndex = 9;
            this.txtNB_PRICE.WaterMarkText = "0.00";
            this.txtNB_PRICE.ZIndex = 6;
            // 
            // Label5
            // 
            this.Label5.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label5.Location = new System.Drawing.Point(0,118);
            this.Label5.Name = "Label5";
            this.Label5.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label5.Size = new System.Drawing.Size(70,28);
            this.Label5.TabIndex = 10;
            this.Label5.Text = "状态";
            this.Label5.ZIndex = 8;
            // 
            // txtNB_CONFIRMPRICE
            // 
            this.txtNB_CONFIRMPRICE.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.txtNB_CONFIRMPRICE.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtNB_CONFIRMPRICE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txtNB_CONFIRMPRICE.Format = "{\"##.##\"}";
            this.txtNB_CONFIRMPRICE.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.txtNB_CONFIRMPRICE.InputType = Smobiler.Core.TextBoxInputType.Number;
            this.txtNB_CONFIRMPRICE.Location = new System.Drawing.Point(70,356);
            this.txtNB_CONFIRMPRICE.Name = "txtNB_CONFIRMPRICE";
            this.txtNB_CONFIRMPRICE.Padding = new Smobiler.Core.Padding(0F, 0F, 2F, 0F);
            this.txtNB_CONFIRMPRICE.Size = new System.Drawing.Size(134,28);
            this.txtNB_CONFIRMPRICE.TabIndex = 11;
            this.txtNB_CONFIRMPRICE.WaterMarkText = "0.00";
            this.txtNB_CONFIRMPRICE.ZIndex = 9;
            // 
            // Label6
            // 
            this.Label6.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.Label6.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.Label6.Location = new System.Drawing.Point(204,328);
            this.Label6.Name = "Label6";
            this.Label6.Padding = new Smobiler.Core.Padding(0F, 0F, 12F, 0F);
            this.Label6.Size = new System.Drawing.Size(36,28);
            this.Label6.TabIndex = 12;
            this.Label6.Text = "元";
            this.Label6.ZIndex = 7;
            // 
            // Label7
            // 
            this.Label7.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.Label7.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.Label7.Location = new System.Drawing.Point(204,356);
            this.Label7.Name = "Label7";
            this.Label7.Padding = new Smobiler.Core.Padding(0F, 0F, 12F, 0F);
            this.Label7.Size = new System.Drawing.Size(36,28);
            this.Label7.TabIndex = 13;
            this.Label7.Text = "元";
            this.Label7.ZIndex = 10;
            // 
            // Label8
            // 
            this.Label8.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label8.Location = new System.Drawing.Point(0,146);
            this.Label8.Name = "Label8";
            this.Label8.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label8.Size = new System.Drawing.Size(70,28);
            this.Label8.TabIndex = 14;
            this.Label8.Text = "所在位置";
            this.Label8.ZIndex = 11;
            // 
            // txtNB_YEAR
            // 
            this.txtNB_YEAR.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.txtNB_YEAR.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtNB_YEAR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txtNB_YEAR.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.txtNB_YEAR.InputType = Smobiler.Core.TextBoxInputType.Number;
            this.txtNB_YEAR.Location = new System.Drawing.Point(70,384);
            this.txtNB_YEAR.Name = "txtNB_YEAR";
            this.txtNB_YEAR.Padding = new Smobiler.Core.Padding(0F, 0F, 2F, 0F);
            this.txtNB_YEAR.Size = new System.Drawing.Size(134,28);
            this.txtNB_YEAR.TabIndex = 15;
            this.txtNB_YEAR.WaterMarkText = "0";
            this.txtNB_YEAR.ZIndex = 12;
            // 
            // Label9
            // 
            this.Label9.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.Label9.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.Label9.Location = new System.Drawing.Point(204,384);
            this.Label9.Name = "Label9";
            this.Label9.Padding = new Smobiler.Core.Padding(0F, 0F, 12F, 0F);
            this.Label9.Size = new System.Drawing.Size(36,28);
            this.Label9.TabIndex = 16;
            this.Label9.Text = "年";
            this.Label9.ZIndex = 13;
            // 
            // Label11
            // 
            this.Label11.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label11.Location = new System.Drawing.Point(0,208);
            this.Label11.Name = "Label11";
            this.Label11.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label11.Size = new System.Drawing.Size(70,28);
            this.Label11.TabIndex = 17;
            this.Label11.Text = "保修期";
            this.Label11.ZIndex = 14;
            // 
            // dpkNB_BUYDATE
            // 
            this.dpkNB_BUYDATE.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.dpkNB_BUYDATE.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dpkNB_BUYDATE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.dpkNB_BUYDATE.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.dpkNB_BUYDATE.Location = new System.Drawing.Point(70,180);
            this.dpkNB_BUYDATE.Name = "dpkNB_BUYDATE";
            this.dpkNB_BUYDATE.Padding = new Smobiler.Core.Padding(0F, 0F, 12F, 0F);
            this.dpkNB_BUYDATE.Size = new System.Drawing.Size(170,28);
            this.dpkNB_BUYDATE.TabIndex = 18;
            this.dpkNB_BUYDATE.ZIndex = 15;
            // 
            // Label10
            // 
            this.Label10.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label10.Location = new System.Drawing.Point(0,180);
            this.Label10.Name = "Label10";
            this.Label10.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label10.Size = new System.Drawing.Size(70,28);
            this.Label10.TabIndex = 19;
            this.Label10.Text = "购买时间";
            this.Label10.ZIndex = 16;
            // 
            // txtNB_WARRANTYPERIOD
            // 
            this.txtNB_WARRANTYPERIOD.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.txtNB_WARRANTYPERIOD.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtNB_WARRANTYPERIOD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txtNB_WARRANTYPERIOD.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.txtNB_WARRANTYPERIOD.Location = new System.Drawing.Point(70,208);
            this.txtNB_WARRANTYPERIOD.Name = "txtNB_WARRANTYPERIOD";
            this.txtNB_WARRANTYPERIOD.Padding = new Smobiler.Core.Padding(0F, 0F, 12F, 0F);
            this.txtNB_WARRANTYPERIOD.Size = new System.Drawing.Size(170,28);
            this.txtNB_WARRANTYPERIOD.TabIndex = 20;
            this.txtNB_WARRANTYPERIOD.WaterMarkText = "（必填）";
            this.txtNB_WARRANTYPERIOD.ZIndex = 17;
            // 
            // save
            // 
            this.save.IconID = "!\\ue161043146223";
            this.save.Name = "save";
            this.save.Text = "保存";
            // 
            // Label12
            // 
            this.Label12.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label12.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label12.Location = new System.Drawing.Point(0,242);
            this.Label12.Name = "Label12";
            this.Label12.Padding = new Smobiler.Core.Padding(2F, 5F, 0F, 0F);
            this.Label12.Size = new System.Drawing.Size(70,80);
            this.Label12.TabIndex = 21;
            this.Label12.Text = "配置清单";
            this.Label12.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            this.Label12.ZIndex = 18;
            // 
            // txtNB_CONFIG
            // 
            this.txtNB_CONFIG.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.txtNB_CONFIG.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtNB_CONFIG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txtNB_CONFIG.Location = new System.Drawing.Point(70,242);
            this.txtNB_CONFIG.Multiline = true;
            this.txtNB_CONFIG.Name = "txtNB_CONFIG";
            this.txtNB_CONFIG.Padding = new Smobiler.Core.Padding(0F, 5F, 12F, 0F);
            this.txtNB_CONFIG.Size = new System.Drawing.Size(170,80);
            this.txtNB_CONFIG.TabIndex = 22;
            this.txtNB_CONFIG.WaterMarkText = "（必填）";
            this.txtNB_CONFIG.ZIndex = 19;
            // 
            // Label13
            // 
            this.Label13.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label13.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label13.Location = new System.Drawing.Point(0,418);
            this.Label13.Name = "Label13";
            this.Label13.Padding = new Smobiler.Core.Padding(2F, 5F, 0F, 0F);
            this.Label13.Size = new System.Drawing.Size(70,80);
            this.Label13.TabIndex = 23;
            this.Label13.Text = "发票";
            this.Label13.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            this.Label13.ZIndex = 20;
            // 
            // imgNB_INVOCIEIMGID
            // 
            this.imgNB_INVOCIEIMGID.Border = new Smobiler.Core.Border(0, 1, 0, 0);
            this.imgNB_INVOCIEIMGID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.imgNB_INVOCIEIMGID.ID = "";
            this.imgNB_INVOCIEIMGID.Location = new System.Drawing.Point(70,418);
            this.imgNB_INVOCIEIMGID.Name = "imgNB_INVOCIEIMGID";
            this.imgNB_INVOCIEIMGID.Padding = new Smobiler.Core.Padding(0F, 2F, 0F, 0F);
            this.imgNB_INVOCIEIMGID.Size = new System.Drawing.Size(170,56);
            this.imgNB_INVOCIEIMGID.TabIndex = 24;
            this.imgNB_INVOCIEIMGID.ZIndex = 21;
            // 
            // btnupPhoto
            // 
            this.btnupPhoto.Border = new Smobiler.Core.Border(1);
            this.btnupPhoto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnupPhoto.BorderRadius = 5;
            this.btnupPhoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnupPhoto.Location = new System.Drawing.Point(98,478);
            this.btnupPhoto.Name = "btnupPhoto";
            this.btnupPhoto.Size = new System.Drawing.Size(52,16);
            this.btnupPhoto.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btnupPhoto.TabIndex = 25;
            this.btnupPhoto.Text = "上传";
            this.btnupPhoto.ZIndex = 23;
            this.btnupPhoto.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnupPhoto_Click);
            // 
            // btndelPhoto
            // 
            this.btndelPhoto.Border = new Smobiler.Core.Border(1);
            this.btndelPhoto.BorderColor = System.Drawing.Color.Red;
            this.btndelPhoto.BorderRadius = 5;
            this.btndelPhoto.ForeColor = System.Drawing.Color.Red;
            this.btndelPhoto.Location = new System.Drawing.Point(160,478);
            this.btndelPhoto.Name = "btndelPhoto";
            this.btndelPhoto.Size = new System.Drawing.Size(52,16);
            this.btndelPhoto.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btndelPhoto.TabIndex = 26;
            this.btndelPhoto.Text = "删除";
            this.btndelPhoto.ZIndex = 24;
            this.btndelPhoto.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btndelPhoto_Click);
            // 
            // Label14
            // 
            this.Label14.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label14.Location = new System.Drawing.Point(70,474);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(170,24);
            this.Label14.TabIndex = 27;
            this.Label14.ZIndex = 22;
            // 
            // Label15
            // 
            this.Label15.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label15.Location = new System.Drawing.Point(0,328);
            this.Label15.Name = "Label15";
            this.Label15.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label15.Size = new System.Drawing.Size(70,28);
            this.Label15.TabIndex = 28;
            this.Label15.Text = "价格";
            this.Label15.ZIndex = 25;
            // 
            // btnNB_OWNER
            // 
            this.btnNB_OWNER.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.btnNB_OWNER.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnNB_OWNER.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnNB_OWNER.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnNB_OWNER.Location = new System.Drawing.Point(70,62);
            this.btnNB_OWNER.Name = "btnNB_OWNER";
            this.btnNB_OWNER.Padding = new Smobiler.Core.Padding(0F, 0F, 2F, 0F);
            this.btnNB_OWNER.Size = new System.Drawing.Size(150,28);
            this.btnNB_OWNER.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btnNB_OWNER.TabIndex = 29;
            this.btnNB_OWNER.ZIndex = 26;
            // 
            // Label16
            // 
            this.Label16.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label16.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label16.Location = new System.Drawing.Point(0,356);
            this.Label16.Name = "Label16";
            this.Label16.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label16.Size = new System.Drawing.Size(70,28);
            this.Label16.TabIndex = 30;
            this.Label16.Text = "确认价格";
            this.Label16.ZIndex = 27;
            // 
            // btnState
            // 
            this.btnState.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.btnState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnState.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnState.Location = new System.Drawing.Point(70,118);
            this.btnState.Name = "btnState";
            this.btnState.Padding = new Smobiler.Core.Padding(0F, 0F, 2F, 0F);
            this.btnState.Size = new System.Drawing.Size(150,28);
            this.btnState.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btnState.TabIndex = 31;
            this.btnState.Text = "正常";
            this.btnState.ZIndex = 28;
            // 
            // btnState2
            // 
            this.btnState2.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.btnState2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnState2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnState2.Location = new System.Drawing.Point(220,118);
            this.btnState2.Name = "btnState2";
            this.btnState2.Size = new System.Drawing.Size(20,28);
            this.btnState2.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btnState2.TabIndex = 32;
            this.btnState2.Text = ">";
            this.btnState2.ZIndex = 29;
            this.btnState2.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnState_Click);
            // 
            // Label17
            // 
            this.Label17.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label17.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label17.Location = new System.Drawing.Point(0,384);
            this.Label17.Name = "Label17";
            this.Label17.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label17.Size = new System.Drawing.Size(70,28);
            this.Label17.TabIndex = 34;
            this.Label17.Text = "折旧年限";
            this.Label17.ZIndex = 27;
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
            // btnNB_LOCATION
            // 
            this.btnNB_LOCATION.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.btnNB_LOCATION.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnNB_LOCATION.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnNB_LOCATION.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnNB_LOCATION.Location = new System.Drawing.Point(70,146);
            this.btnNB_LOCATION.Name = "btnNB_LOCATION";
            this.btnNB_LOCATION.Padding = new Smobiler.Core.Padding(0F, 0F, 2F, 0F);
            this.btnNB_LOCATION.Size = new System.Drawing.Size(150,28);
            this.btnNB_LOCATION.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btnNB_LOCATION.TabIndex = 35;
            this.btnNB_LOCATION.Text = "上海";
            this.btnNB_LOCATION.ZIndex = 28;
            // 
            // btnNB_LOCATION2
            // 
            this.btnNB_LOCATION2.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.btnNB_LOCATION2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnNB_LOCATION2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnNB_LOCATION2.Location = new System.Drawing.Point(220,146);
            this.btnNB_LOCATION2.Name = "btnNB_LOCATION2";
            this.btnNB_LOCATION2.Size = new System.Drawing.Size(20,28);
            this.btnNB_LOCATION2.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btnNB_LOCATION2.TabIndex = 36;
            this.btnNB_LOCATION2.Text = ">";
            this.btnNB_LOCATION2.ZIndex = 29;
            this.btnNB_LOCATION2.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnState_Click);
            // 
            // btnNB_OWNER2
            // 
            this.btnNB_OWNER2.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.btnNB_OWNER2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnNB_OWNER2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnNB_OWNER2.Location = new System.Drawing.Point(220,62);
            this.btnNB_OWNER2.Name = "btnNB_OWNER2";
            this.btnNB_OWNER2.Size = new System.Drawing.Size(20,28);
            this.btnNB_OWNER2.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btnNB_OWNER2.TabIndex = 37;
            this.btnNB_OWNER2.Text = ">";
            this.btnNB_OWNER2.ZIndex = 29;
            this.btnNB_OWNER2.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnState_Click);
            // 
            // frmNBCreate
            // 
            this.ComponentControls.AddRange(new Smobiler.Core.ComponentBase[] {
            this.Camera1,
            this.PopList1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label1,
            this.txtNB_SN,
            this.txtNB_CHECK,
            this.Label2,
            this.txtNB_MODEL,
            this.Label3,
            this.Label4,
            this.txtNB_PRICE,
            this.Label6,
            this.Label5,
            this.txtNB_CONFIRMPRICE,
            this.Label7,
            this.Label8,
            this.txtNB_YEAR,
            this.Label9,
            this.Label11,
            this.dpkNB_BUYDATE,
            this.Label10,
            this.txtNB_WARRANTYPERIOD,
            this.Label12,
            this.txtNB_CONFIG,
            this.Label13,
            this.imgNB_INVOCIEIMGID,
            this.Label14,
            this.btnupPhoto,
            this.btndelPhoto,
            this.Label15,
            this.btnNB_OWNER,
            this.Label16,
            this.Label17,
            this.btnState,
            this.btnNB_LOCATION,
            this.btnState2,
            this.btnNB_LOCATION2,
            this.btnNB_OWNER2});
            this.Size = new System.Drawing.Size(240,580);
            this.StatusBarStyle = Smobiler.Core.StatusBarStyle.Default;
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("Exit", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(50))))));
            this.TitleText = "笔记本入库";
            this.Toolbar.AddRange(new Smobiler.Core.Controls.ToolbarItem[] {
            this.save});
            this.ToolbarStyle = new Smobiler.Core.ToolBarSytle(Smobiler.Core.ToolbarSelectStyle.None, System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))), System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))));
            this.Load += new System.EventHandler(this.frmNBCreate_Load);
            this.ToolbarItemClick += new Smobiler.Core.ToolbarItemClickEventHandler(this.frmNBCreate_ToolbarItemClick);
            this.TitleImageClick += new System.EventHandler(this.frmNBCreate_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.MobileForm_KeyDown);
            this.Name = "frmNBCreate";

        }
        internal Smobiler.Core.Controls.Label Label1;
        internal Smobiler.Core.Controls.TextBox txtNB_SN;
        internal Smobiler.Core.Controls.Label Label2;
        internal Smobiler.Core.Controls.TextBox txtNB_CHECK;
        internal Smobiler.Core.Controls.Label Label3;
        internal Smobiler.Core.Controls.TextBox txtNB_MODEL;
        internal Smobiler.Core.Controls.Label Label4;
        internal Smobiler.Core.Controls.TextBox txtNB_PRICE;
        internal Smobiler.Core.Controls.Label Label5;
        internal Smobiler.Core.Controls.TextBox txtNB_CONFIRMPRICE;
        internal Smobiler.Core.Controls.Label Label6;
        internal Smobiler.Core.Controls.Label Label7;
        internal Smobiler.Core.Controls.Label Label8;
        internal Smobiler.Core.Controls.TextBox txtNB_YEAR;
        internal Smobiler.Core.Controls.Label Label9;
        internal Smobiler.Core.Controls.Label Label11;
        internal Smobiler.Core.Controls.DatePicker dpkNB_BUYDATE;
        internal Smobiler.Core.Controls.Label Label10;
        internal Smobiler.Core.Controls.TextBox txtNB_WARRANTYPERIOD;
        internal Smobiler.Core.Controls.ToolbarItem save;
        internal Smobiler.Core.Controls.Label Label12;
        internal Smobiler.Core.Controls.TextBox txtNB_CONFIG;
        internal Smobiler.Core.Controls.Label Label13;
        internal Smobiler.Core.Controls.Image imgNB_INVOCIEIMGID;
        internal Smobiler.Core.Controls.Button btnupPhoto;
        internal Smobiler.Core.Controls.Button btndelPhoto;
        internal Smobiler.Core.Controls.Label Label14;
        internal Smobiler.Core.Controls.Label Label15;
        internal Smobiler.Core.Controls.Button btnNB_OWNER;
        internal Smobiler.Core.Controls.Label Label16;
        internal Smobiler.Core.Controls.Button btnState;
        internal Smobiler.Core.Controls.Button btnState2;
        internal Smobiler.Core.Controls.Label Label17;
        internal Smobiler.Core.Controls.Camera Camera1;
        internal Smobiler.Core.Controls.PopList PopList1;
        internal Smobiler.Core.Controls.Button btnNB_LOCATION;
        internal Smobiler.Core.Controls.Button btnNB_LOCATION2;
        internal Smobiler.Core.Controls.Button btnNB_OWNER2;
        #endregion
    }
}
