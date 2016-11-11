
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
using Smobiler.Core.Controls;
namespace COMSSmobilerDemo
{
    public partial class frmLogon : Smobiler.Core.MobileForm
    {
        #region "VTForm Designer generated code "

        public frmLogon()
            : base()
        {

            //This call is required by the VTForm Designer.
            InitializeComponent();

            //Add any initialization after the InitializeComponent() call

        }

        //VTForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the VTForm Designer
        //It can be modified using the VTForm Designer.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]

        private void InitializeComponent()
        {
            this.txtName = new Smobiler.Core.Controls.TextBox();
            this.txtPwd = new Smobiler.Core.Controls.TextBox();
            this.btnLogon = new Smobiler.Core.Controls.Button();
            this.LblMsg = new Smobiler.Core.Controls.Label();
            this.Label1 = new Smobiler.Core.Controls.Label();
            this.CheckBox1 = new Smobiler.Core.Controls.CheckBox();
            this.labSubTitle = new Smobiler.Core.Controls.Label();
            this.Line1 = new Smobiler.Core.Controls.Line();
            this.Line4 = new Smobiler.Core.Controls.Line();
            this.Image2 = new Smobiler.Core.Controls.Image();
            this.Image3 = new Smobiler.Core.Controls.Image();
            this.btnGestures = new Smobiler.Core.Controls.Button();
            this.Image1 = new Smobiler.Core.Controls.GifView();
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.txtName.BackColorAlpha = 0;
            this.txtName.BorderColor = System.Drawing.Color.White;
            this.txtName.FontSize = 18F;
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(58, 190);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(213, 40);
            this.txtName.TabIndex = 3;
            this.txtName.WaterMarkText = "用户名";
            // 
            // txtPwd
            // 
            this.txtPwd.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.txtPwd.BackColorAlpha = 0;
            this.txtPwd.BorderColor = System.Drawing.Color.White;
            this.txtPwd.FontSize = 18F;
            this.txtPwd.ForeColor = System.Drawing.Color.White;
            this.txtPwd.Location = new System.Drawing.Point(58, 240);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(213, 40);
            this.txtPwd.TabIndex = 4;
            this.txtPwd.WaterMarkText = "密码";
            // 
            // btnLogon
            // 
            this.btnLogon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(125)))), ((int)(((byte)(214)))));
            this.btnLogon.BackColorAlpha = 0;
            this.btnLogon.Border = new Smobiler.Core.Border(1);
            this.btnLogon.BorderColor = System.Drawing.Color.White;
            this.btnLogon.BorderRadius = 2;
            this.btnLogon.FontSize = 18F;
            this.btnLogon.ForeColor = System.Drawing.Color.White;
            this.btnLogon.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(194)))), ((int)(((byte)(240)))));
            this.btnLogon.HoverForeColor = System.Drawing.Color.White;
            this.btnLogon.Location = new System.Drawing.Point(25, 353);
            this.btnLogon.Name = "btnLogon";
            this.btnLogon.Size = new System.Drawing.Size(250, 40);
            this.btnLogon.TabIndex = 5;
            this.btnLogon.Text = "登录";
            this.btnLogon.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btn_Logo_Click);
            // 
            // LblMsg
            // 
            this.LblMsg.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.LblMsg.BackColorAlpha = 0;
            this.LblMsg.FontSize = 13F;
            this.LblMsg.ForeColor = System.Drawing.Color.Red;
            this.LblMsg.Location = new System.Drawing.Point(50, 280);
            this.LblMsg.Name = "LblMsg";
            this.LblMsg.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.LblMsg.Size = new System.Drawing.Size(220, 25);
            this.LblMsg.TabIndex = 6;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Label1.BackColorAlpha = 0;
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(83, 308);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(105, 20);
            this.Label1.TabIndex = 8;
            this.Label1.Text = "记住密码";
            // 
            // CheckBox1
            // 
            this.CheckBox1.Border = new Smobiler.Core.Border(1);
            this.CheckBox1.BorderColor = System.Drawing.Color.Silver;
            this.CheckBox1.BorderRadius = 4;
            this.CheckBox1.Checked = false;
            this.CheckBox1.CheckedBackColor = System.Drawing.Color.White;
            this.CheckBox1.CheckedColor = System.Drawing.Color.DeepSkyBlue;
            this.CheckBox1.Location = new System.Drawing.Point(58, 308);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(20, 20);
            this.CheckBox1.TabIndex = 12;
            this.CheckBox1.UnCheckedBackColor = System.Drawing.Color.White;
            // 
            // labSubTitle
            // 
            this.labSubTitle.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.labSubTitle.BackColorAlpha = 0;
            this.labSubTitle.ForeColor = System.Drawing.Color.White;
            this.labSubTitle.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.labSubTitle.Location = new System.Drawing.Point(0, 143);
            this.labSubTitle.Name = "labSubTitle";
            this.labSubTitle.Size = new System.Drawing.Size(300, 40);
            this.labSubTitle.TabIndex = 14;
            this.labSubTitle.Text = "报销管理系统";
            this.labSubTitle.Visible = false;
            // 
            // Line1
            // 
            this.Line1.BackColor = System.Drawing.Color.White;
            this.Line1.Location = new System.Drawing.Point(58, 280);
            this.Line1.Name = "Line1";
            this.Line1.Size = new System.Drawing.Size(213, 3);
            this.Line1.TabIndex = 15;
            // 
            // Line4
            // 
            this.Line4.BackColor = System.Drawing.Color.White;
            this.Line4.Location = new System.Drawing.Point(58, 230);
            this.Line4.Name = "Line4";
            this.Line4.Size = new System.Drawing.Size(213, 3);
            this.Line4.TabIndex = 16;
            // 
            // Image2
            // 
            this.Image2.BackColorAlpha = 0;
            this.Image2.ID = "!\\ue8a6255255255";
            this.Image2.Location = new System.Drawing.Point(25, 190);
            this.Image2.Name = "Image2";
            this.Image2.Padding = new Smobiler.Core.Padding(0F, 10F, 0F, 5F);
            this.Image2.ResourceID = "!\\ue8a6255255255";
            this.Image2.Size = new System.Drawing.Size(25, 40);
            this.Image2.TabIndex = 19;
            // 
            // Image3
            // 
            this.Image3.BackColorAlpha = 0;
            this.Image3.ID = "!\\ue899255255255";
            this.Image3.Location = new System.Drawing.Point(25, 240);
            this.Image3.Name = "Image3";
            this.Image3.Padding = new Smobiler.Core.Padding(0F, 10F, 0F, 5F);
            this.Image3.ResourceID = "!\\ue899255255255";
            this.Image3.Size = new System.Drawing.Size(25, 40);
            this.Image3.TabIndex = 20;
            // 
            // btnGestures
            // 
            this.btnGestures.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(125)))), ((int)(((byte)(214)))));
            this.btnGestures.BackColorAlpha = 0;
            this.btnGestures.BorderColor = System.Drawing.Color.White;
            this.btnGestures.BorderRadius = 2;
            this.btnGestures.BorderSize = 0.2F;
            this.btnGestures.FontSize = 18F;
            this.btnGestures.ForeColor = System.Drawing.Color.Red;
            this.btnGestures.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(194)))), ((int)(((byte)(240)))));
            this.btnGestures.HoverForeColor = System.Drawing.Color.White;
            this.btnGestures.Location = new System.Drawing.Point(25, 393);
            this.btnGestures.Name = "btnGestures";
            this.btnGestures.Size = new System.Drawing.Size(250, 40);
            this.btnGestures.TabIndex = 21;
            this.btnGestures.Text = "手势登录";
            this.btnGestures.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnGestures_Click);
            // 
            // Image1
            // 
            this.Image1.BackColorAlpha = 0;
            this.Image1.ID = "logo";
            this.Image1.Location = new System.Drawing.Point(107, 50);
            this.Image1.Name = "Image1";
            this.Image1.ResourceID = "logo";
            this.Image1.Size = new System.Drawing.Size(88, 88);
            this.Image1.TabIndex = 22;
            // 
            // frmLogon
            // 
            this.BackColor = System.Drawing.Color.Empty;
            this.BackGroundImage = "frmLogon";
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.txtName,
            this.txtPwd,
            this.btnLogon,
            this.LblMsg,
            this.Label1,
            this.CheckBox1,
            this.labSubTitle,
            this.Line1,
            this.Line4,
            this.Image2,
            this.Image3,
            this.btnGestures,
            this.Image1});
            this.EnableMirrorPattern = false;
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("", System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(195)))), ((int)(((byte)(246))))), System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(50))))));
            this.Load += new System.EventHandler(this.frmLogon_Load);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.frmLogon_KeyDown);
            this.Name = "frmLogon";

        }
        internal Smobiler.Core.Controls.TextBox txtName;
        internal Smobiler.Core.Controls.TextBox txtPwd;
        internal Smobiler.Core.Controls.Button btnLogon;
        internal Smobiler.Core.Controls.Label LblMsg;
        internal Smobiler.Core.Controls.Label Label1;
        internal Smobiler.Core.Controls.CheckBox CheckBox1;
        internal Smobiler.Core.Controls.Label labSubTitle;
        internal Smobiler.Core.Controls.Line Line1;
        internal Smobiler.Core.Controls.Line Line4;
        internal Smobiler.Core.Controls.Image Image2;
        internal Smobiler.Core.Controls.Image Image3;
        #endregion
        internal Button btnGestures;
        internal GifView Image1;
    }
}
