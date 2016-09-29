
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
namespace COMSSmobilerDemo
{
    public partial class frmInfo : Smobiler.Core.MobileForm
    {

        #region "SmobilerForm Designer generated code "

        public frmInfo()
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
            this.lblUserName = new Smobiler.Core.Controls.Label();
            this.lblSex = new Smobiler.Core.Controls.Label();
            this.lblAddreass = new Smobiler.Core.Controls.Label();
            this.lblTel = new Smobiler.Core.Controls.Label();
            this.lblEmail = new Smobiler.Core.Controls.Label();
            this.lblBorn = new Smobiler.Core.Controls.Label();
            this.Gps1 = new Smobiler.Core.Controls.GPS();
            this.imguser = new Smobiler.Core.Controls.Image();
            this.Label6 = new Smobiler.Core.Controls.Label();
            this.lblPhone = new Smobiler.Core.Controls.Label();
            this.imgbtnPhone = new Smobiler.Core.Controls.ImageButton();
            this.imgbtnAddTel = new Smobiler.Core.Controls.ImageButton();
            this.imgbtnSedM = new Smobiler.Core.Controls.ImageButton();
            this.imgbtnSedEmail = new Smobiler.Core.Controls.ImageButton();
            // 
            // Label1
            // 
            this.Label1.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label1.Location = new System.Drawing.Point(0, 114);
            this.Label1.Name = "Label1";
            this.Label1.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label1.Size = new System.Drawing.Size(60, 28);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "家庭住址";
            // 
            // Label2
            // 
            this.Label2.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label2.Location = new System.Drawing.Point(0, 182);
            this.Label2.Name = "Label2";
            this.Label2.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label2.Size = new System.Drawing.Size(240, 12);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "电话";
            // 
            // Label3
            // 
            this.Label3.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label3.Location = new System.Drawing.Point(0, 228);
            this.Label3.Name = "Label3";
            this.Label3.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label3.Size = new System.Drawing.Size(60, 28);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "邮箱";
            // 
            // Label4
            // 
            this.Label4.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label4.Location = new System.Drawing.Point(0, 148);
            this.Label4.Name = "Label4";
            this.Label4.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label4.Size = new System.Drawing.Size(60, 28);
            this.Label4.TabIndex = 5;
            this.Label4.Text = "手机";
            // 
            // Label5
            // 
            this.Label5.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label5.Location = new System.Drawing.Point(0, 262);
            this.Label5.Name = "Label5";
            this.Label5.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label5.Size = new System.Drawing.Size(60, 28);
            this.Label5.TabIndex = 6;
            this.Label5.Text = "出生日期";
            // 
            // lblUserName
            // 
            this.lblUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(97)))), ((int)(((byte)(164)))));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.lblUserName.Location = new System.Drawing.Point(0, 60);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(240, 24);
            this.lblUserName.TabIndex = 8;
            this.lblUserName.VerticalAlignment = Smobiler.Core.VerticalAlignment.Bottom;
            // 
            // lblSex
            // 
            this.lblSex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(97)))), ((int)(((byte)(164)))));
            this.lblSex.ForeColor = System.Drawing.Color.White;
            this.lblSex.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.lblSex.Location = new System.Drawing.Point(0, 84);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(240, 24);
            this.lblSex.TabIndex = 9;
            // 
            // lblAddreass
            // 
            this.lblAddreass.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.lblAddreass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblAddreass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblAddreass.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblAddreass.Location = new System.Drawing.Point(60, 114);
            this.lblAddreass.Name = "lblAddreass";
            this.lblAddreass.Padding = new Smobiler.Core.Padding(0F, 0F, 12F, 0F);
            this.lblAddreass.Size = new System.Drawing.Size(180, 28);
            this.lblAddreass.TabIndex = 10;
            // 
            // lblTel
            // 
            this.lblTel.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.lblTel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblTel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblTel.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblTel.Location = new System.Drawing.Point(60, 148);
            this.lblTel.Name = "lblTel";
            this.lblTel.Padding = new Smobiler.Core.Padding(0F, 0F, 12F, 0F);
            this.lblTel.Size = new System.Drawing.Size(180, 28);
            this.lblTel.TabIndex = 11;
            // 
            // lblEmail
            // 
            this.lblEmail.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.lblEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblEmail.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblEmail.Location = new System.Drawing.Point(60, 228);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Padding = new Smobiler.Core.Padding(0F, 0F, 12F, 0F);
            this.lblEmail.Size = new System.Drawing.Size(160, 28);
            this.lblEmail.TabIndex = 13;
            // 
            // lblBorn
            // 
            this.lblBorn.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.lblBorn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblBorn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblBorn.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblBorn.Location = new System.Drawing.Point(60, 262);
            this.lblBorn.Name = "lblBorn";
            this.lblBorn.Padding = new Smobiler.Core.Padding(0F, 0F, 12F, 0F);
            this.lblBorn.Size = new System.Drawing.Size(180, 28);
            this.lblBorn.TabIndex = 14;
            // 
            // Gps1
            // 
            this.Gps1.Name = "Gps1";
            this.Gps1.GotLocation += new Smobiler.Core.GpsCallBackHandler(this.Gps1_GotLocation);
            // 
            // imguser
            // 
            this.imguser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.imguser.BackColorAlpha = 0;
            this.imguser.BorderColor = System.Drawing.Color.White;
            this.imguser.BorderRadius = 10;
            this.imguser.Enlarged = true;
            this.imguser.ID = "lincy";
            this.imguser.Location = new System.Drawing.Point(90, 0);
            this.imguser.Name = "imguser";
            this.imguser.Padding = new Smobiler.Core.Padding(0F, 0F, 1F, 0F);
            this.imguser.ResourceID = "lincy";
            this.imguser.Size = new System.Drawing.Size(60, 60);
            this.imguser.SizeMode = Smobiler.Core.ImageSizeMode.StretchImage;
            this.imguser.TabIndex = 15;
            this.imguser.ZIndex = 2;
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(97)))), ((int)(((byte)(164)))));
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(240, 60);
            this.Label6.TabIndex = 17;
            this.Label6.ZIndex = 1;
            // 
            // lblPhone
            // 
            this.lblPhone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblPhone.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblPhone.Location = new System.Drawing.Point(0, 194);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Padding = new Smobiler.Core.Padding(0F, 0F, 12F, 0F);
            this.lblPhone.Size = new System.Drawing.Size(180, 28);
            this.lblPhone.TabIndex = 18;
            // 
            // imgbtnPhone
            // 
            this.imgbtnPhone.FontSize = 8F;
            this.imgbtnPhone.Location = new System.Drawing.Point(180, 194);
            this.imgbtnPhone.Name = "imgbtnPhone";
            this.imgbtnPhone.ResourceID = "!\\ue551004097164";
            this.imgbtnPhone.Size = new System.Drawing.Size(20, 28);
            this.imgbtnPhone.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.imgbtnPhone.TabIndex = 19;
            this.imgbtnPhone.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.imgbtnPhone_Click);
            // 
            // imgbtnAddTel
            // 
            this.imgbtnAddTel.FontSize = 8F;
            this.imgbtnAddTel.Location = new System.Drawing.Point(200, 194);
            this.imgbtnAddTel.Name = "imgbtnAddTel";
            this.imgbtnAddTel.ResourceID = "!\\ue145004097164";
            this.imgbtnAddTel.Size = new System.Drawing.Size(20, 28);
            this.imgbtnAddTel.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.imgbtnAddTel.TabIndex = 20;
            this.imgbtnAddTel.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.imgbtnAddTel_Click);
            // 
            // imgbtnSedM
            // 
            this.imgbtnSedM.FontSize = 8F;
            this.imgbtnSedM.Location = new System.Drawing.Point(220, 194);
            this.imgbtnSedM.Name = "imgbtnSedM";
            this.imgbtnSedM.ResourceID = "!\\ue0c9004097164";
            this.imgbtnSedM.Size = new System.Drawing.Size(20, 28);
            this.imgbtnSedM.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.imgbtnSedM.TabIndex = 21;
            this.imgbtnSedM.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.imgbtnSedM_Click);
            // 
            // imgbtnSedEmail
            // 
            this.imgbtnSedEmail.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.imgbtnSedEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.imgbtnSedEmail.FontSize = 8F;
            this.imgbtnSedEmail.Location = new System.Drawing.Point(220, 228);
            this.imgbtnSedEmail.Name = "imgbtnSedEmail";
            this.imgbtnSedEmail.ResourceID = "!\\ue0be004097164";
            this.imgbtnSedEmail.Size = new System.Drawing.Size(20, 28);
            this.imgbtnSedEmail.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.imgbtnSedEmail.TabIndex = 22;
            this.imgbtnSedEmail.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.imgbtnSedEmail_Click);
            // 
            // frmInfo
            // 
            this.ComponentControls.AddRange(new Smobiler.Core.ComponentBase[] {
            this.Gps1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label1,
            this.Label2,
            this.Label3,
            this.Label4,
            this.Label5,
            this.lblUserName,
            this.lblSex,
            this.lblAddreass,
            this.lblTel,
            this.lblEmail,
            this.lblBorn,
            this.Label6,
            this.imguser,
            this.lblPhone,
            this.imgbtnPhone,
            this.imgbtnAddTel,
            this.imgbtnSedM,
            this.imgbtnSedEmail});
            this.FooterBarLayout = "frminfoFootBarLayout";
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LayoutMode = Smobiler.Core.FormLayoutMode.EFFACT3D;
            this.LeftFormLayout = "frmMenuLayout";
            this.StatusBarStyle = Smobiler.Core.StatusBarStyle.Default;
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("menu", System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(97)))), ((int)(((byte)(164))))), System.Drawing.Color.White);
            this.TitleText = "基本信息";
            this.ToolbarStyle = new Smobiler.Core.ToolBarSytle(Smobiler.Core.ToolbarSelectStyle.None, System.Drawing.Color.AliceBlue, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))), System.Drawing.Color.White, System.Drawing.Color.AliceBlue);
            this.LeftLayoutItemClick += new Smobiler.Core.MobileFormLayoutItemClickEventHandler(this.frminfo_LeftLayoutItemClick);
            this.FooterBarLayoutItemClick += new Smobiler.Core.MobileFormLayoutItemClickEventHandler(this.frmInfo_FooterBarLayoutItemClick);
            this.Load += new System.EventHandler(this.frminfo_Load);
            this.TitleImageClick += new System.EventHandler(this.frminfo_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.MobileForm_KeyDown);
            this.Name = "frmInfo";

        }
        internal Smobiler.Core.Controls.Label Label1;
        internal Smobiler.Core.Controls.Label Label2;
        internal Smobiler.Core.Controls.Label Label3;
        internal Smobiler.Core.Controls.Label Label4;
        internal Smobiler.Core.Controls.Label Label5;
        internal Smobiler.Core.Controls.Label lblUserName;
        internal Smobiler.Core.Controls.Label lblSex;
        internal Smobiler.Core.Controls.Label lblAddreass;
        internal Smobiler.Core.Controls.Label lblTel;
        internal Smobiler.Core.Controls.Label lblEmail;
        internal Smobiler.Core.Controls.Label lblBorn;
        internal Smobiler.Core.Controls.GPS Gps1;
        internal Smobiler.Core.Controls.Image imguser;
        internal Smobiler.Core.Controls.Label Label6;
        #endregion
        internal Smobiler.Core.Controls.Label lblPhone;
        internal Smobiler.Core.Controls.ImageButton imgbtnPhone;
        internal Smobiler.Core.Controls.ImageButton imgbtnAddTel;
        internal Smobiler.Core.Controls.ImageButton imgbtnSedM;
        internal Smobiler.Core.Controls.ImageButton imgbtnSedEmail;

    }
}
