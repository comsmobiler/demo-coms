
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
            this.Image1 = new Smobiler.Core.Controls.Image();
            this.Image2 = new Smobiler.Core.Controls.Image();
            this.Image3 = new Smobiler.Core.Controls.Image();
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.txtName.BackColorAlpha = 0;
            this.txtName.Border = new Smobiler.Core.Border(0);
            this.txtName.BorderColor = System.Drawing.Color.White;
            this.txtName.FontSize = 7F;
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new Smobiler.Core.PointS(23F, 76F);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.SizeF(85F, 16F);
            this.txtName.TabIndex = 3;
            this.txtName.WaterMarkText = "用户名";
            // 
            // txtPwd
            // 
            this.txtPwd.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.txtPwd.BackColorAlpha = 0;
            this.txtPwd.Border = new Smobiler.Core.Border(0);
            this.txtPwd.BorderColor = System.Drawing.Color.White;
            this.txtPwd.FontSize = 7F;
            this.txtPwd.ForeColor = System.Drawing.Color.White;
            this.txtPwd.Location = new Smobiler.Core.PointS(23F, 96F);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.SizeF(85F, 16F);
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
            this.btnLogon.FontSize = 7F;
            this.btnLogon.ForeColor = System.Drawing.Color.White;
            this.btnLogon.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(194)))), ((int)(((byte)(240)))));
            this.btnLogon.HoverForeColor = System.Drawing.Color.White;
            this.btnLogon.Location = new Smobiler.Core.PointS(10F, 141F);
            this.btnLogon.Name = "btnLogon";
            this.btnLogon.Size = new System.Drawing.SizeF(100F, 16F);
            this.btnLogon.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btnLogon.TabIndex = 5;
            this.btnLogon.Text = "登录";
            this.btnLogon.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btn_Logo_Click);
            // 
            // LblMsg
            // 
            this.LblMsg.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.LblMsg.BackColorAlpha = 0;
            this.LblMsg.FontSize = 5F;
            this.LblMsg.ForeColor = System.Drawing.Color.Red;
            this.LblMsg.Location = new Smobiler.Core.PointS(20F, 112F);
            this.LblMsg.Name = "LblMsg";
            this.LblMsg.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.LblMsg.Size = new System.Drawing.SizeF(88F, 10F);
            this.LblMsg.TabIndex = 6;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Label1.BackColorAlpha = 0;
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new Smobiler.Core.PointS(33F, 123F);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.SizeF(42F, 8F);
            this.Label1.TabIndex = 8;
            this.Label1.Text = "记住密码";
            // 
            // CheckBox1
            // 
            this.CheckBox1.BackColor = System.Drawing.Color.White;
            this.CheckBox1.Border = new Smobiler.Core.Border(1);
            this.CheckBox1.BorderColor = System.Drawing.Color.Silver;
            this.CheckBox1.BorderRadius = 4;
            this.CheckBox1.Checked = false;
            this.CheckBox1.CheckedBackColor = System.Drawing.Color.White;
            this.CheckBox1.CheckedColor = System.Drawing.Color.DeepSkyBlue;
            this.CheckBox1.Location = new Smobiler.Core.PointS(23F, 123F);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.SizeF(8F, 8F);
            this.CheckBox1.TabIndex = 12;
            this.CheckBox1.UnCheckedBackColor = System.Drawing.Color.White;
            // 
            // labSubTitle
            // 
            this.labSubTitle.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.labSubTitle.BackColorAlpha = 0;
            this.labSubTitle.ForeColor = System.Drawing.Color.White;
            this.labSubTitle.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.labSubTitle.Location = new Smobiler.Core.PointS(0F, 57F);
            this.labSubTitle.Name = "labSubTitle";
            this.labSubTitle.Size = new System.Drawing.SizeF(120F, 16F);
            this.labSubTitle.TabIndex = 14;
            this.labSubTitle.Text = "报销管理系统";
            this.labSubTitle.Visible = false;
            // 
            // Line1
            // 
            this.Line1.BackColor = System.Drawing.Color.White;
            this.Line1.Location = new Smobiler.Core.PointS(23F, 112F);
            this.Line1.Name = "Line1";
            this.Line1.Size = new System.Drawing.SizeF(85F, 1F);
            this.Line1.TabIndex = 15;
            // 
            // Line4
            // 
            this.Line4.BackColor = System.Drawing.Color.White;
            this.Line4.Location = new Smobiler.Core.PointS(23F, 92F);
            this.Line4.Name = "Line4";
            this.Line4.Size = new System.Drawing.SizeF(85F, 1F);
            this.Line4.TabIndex = 16;
            // 
            // Image1
            // 
            this.Image1.BackColorAlpha = 0;
            this.Image1.Location = new Smobiler.Core.PointS(42.5F, 20F);
            this.Image1.Name = "Image1";
            this.Image1.ResourceID = "logo";
            this.Image1.Size = new System.Drawing.SizeF(35F, 35F);
            this.Image1.TabIndex = 18;
            // 
            // Image2
            // 
            this.Image2.BackColorAlpha = 0;
            this.Image2.Location = new Smobiler.Core.PointS(10F, 76F);
            this.Image2.Name = "Image2";
            this.Image2.Padding = new Smobiler.Core.Padding(0F, 4F, 0F, 2F);
            this.Image2.ResourceID = "!\\ue8a6255255255";
            this.Image2.Size = new System.Drawing.SizeF(10F, 16F);
            this.Image2.TabIndex = 19;
            // 
            // Image3
            // 
            this.Image3.BackColorAlpha = 0;
            this.Image3.Location = new Smobiler.Core.PointS(10F, 96F);
            this.Image3.Name = "Image3";
            this.Image3.Padding = new Smobiler.Core.Padding(0F, 4F, 0F, 2F);
            this.Image3.ResourceID = "!\\ue899255255255";
            this.Image3.Size = new System.Drawing.SizeF(10F, 16F);
            this.Image3.TabIndex = 20;
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
            this.Image1,
            this.Image2,
            this.Image3});
            this.Scrollable = false;
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("", System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(195)))), ((int)(((byte)(246))))), System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(50))))));

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
        internal Smobiler.Core.Controls.Image Image1;
        internal Smobiler.Core.Controls.Image Image2;
        internal Smobiler.Core.Controls.Image Image3;
        #endregion
    }
}
