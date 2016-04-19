
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
            this.btn_Logo = new Smobiler.Core.Controls.Button();
            this.LblMsg = new Smobiler.Core.Controls.Label();
            this.Line2 = new Smobiler.Core.Controls.Line();
            this.Line3 = new Smobiler.Core.Controls.Line();
            this.CheckBox1 = new Smobiler.Core.Controls.CheckBox();
            this.Label2 = new Smobiler.Core.Controls.Label();
            this.Label3 = new Smobiler.Core.Controls.Label();
            this.Line1 = new Smobiler.Core.Controls.Line();
            this.Label1 = new Smobiler.Core.Controls.Label();
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.txtName.BorderColor = System.Drawing.Color.White;
            this.txtName.FontSize = 7F;
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new Smobiler.Core.PointS(15F, 80F);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.SizeF(88F, 14F);
            this.txtName.TabIndex = 3;
            this.txtName.WaterMarkText = "用户名";
            // 
            // txtPwd
            // 
            this.txtPwd.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.txtPwd.Border = new Smobiler.Core.Border(0);
            this.txtPwd.BorderColor = System.Drawing.Color.White;
            this.txtPwd.ForeColor = System.Drawing.Color.White;
            this.txtPwd.Location = new Smobiler.Core.PointS(15F, 98F);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.SizeF(74F, 14F);
            this.txtPwd.TabIndex = 4;
            this.txtPwd.WaterMarkText = "密码";
            // 
            // btn_Logo
            // 
            this.btn_Logo.BorderRadius = 5;
            this.btn_Logo.FontSize = 7F;
            this.btn_Logo.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Logo.Location = new Smobiler.Core.PointS(25F, 142F);
            this.btn_Logo.Name = "btn_Logo";
            this.btn_Logo.Size = new System.Drawing.SizeF(70F, 14F);
            this.btn_Logo.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btn_Logo.TabIndex = 5;
            this.btn_Logo.Text = "登录";
            this.btn_Logo.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btn_Logo_Click);
            // 
            // LblMsg
            // 
            this.LblMsg.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.LblMsg.ForeColor = System.Drawing.Color.Red;
            this.LblMsg.Location = new Smobiler.Core.PointS(15F, 112F);
            this.LblMsg.Name = "LblMsg";
            this.LblMsg.Size = new System.Drawing.SizeF(88F, 10F);
            this.LblMsg.TabIndex = 6;
            this.LblMsg.Visible = false;
            // 
            // Line2
            // 
            this.Line2.BackColor = System.Drawing.Color.White;
            this.Line2.LineSize = 0.5F;
            this.Line2.Location = new Smobiler.Core.PointS(13F, 82F);
            this.Line2.Name = "Line2";
            this.Line2.Orientation = Smobiler.Core.OrientationAlignment.Vertical;
            this.Line2.Size = new System.Drawing.SizeF(1F, 10F);
            this.Line2.TabIndex = 10;
            // 
            // Line3
            // 
            this.Line3.BackColor = System.Drawing.Color.White;
            this.Line3.LineSize = 0.5F;
            this.Line3.Location = new Smobiler.Core.PointS(13F, 100F);
            this.Line3.Name = "Line3";
            this.Line3.Orientation = Smobiler.Core.OrientationAlignment.Vertical;
            this.Line3.Size = new System.Drawing.SizeF(1F, 10F);
            this.Line3.TabIndex = 11;
            // 
            // CheckBox1
            // 
            this.CheckBox1.BackColor = System.Drawing.Color.White;
            this.CheckBox1.BorderColor = System.Drawing.Color.White;
            this.CheckBox1.BorderRadius = 4;
            this.CheckBox1.Checked = false;
            this.CheckBox1.CheckedBackColor = System.Drawing.Color.White;
            this.CheckBox1.CheckedColor = System.Drawing.Color.DeepSkyBlue;
            this.CheckBox1.Location = new Smobiler.Core.PointS(15F, 123F);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.SizeF(10F, 10F);
            this.CheckBox1.TabIndex = 12;
            this.CheckBox1.UnCheckedBackColor = System.Drawing.Color.White;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Label2.Bold = true;
            this.Label2.FontSize = 23F;
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.Label2.Location = new Smobiler.Core.PointS(0F, 35F);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.SizeF(120F, 20F);
            this.Label2.TabIndex = 13;
            this.Label2.Text = "COMS";
            this.Label2.VerticalAlignment = Smobiler.Core.VerticalAlignment.Bottom;
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Label3.Bold = true;
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.Label3.Location = new Smobiler.Core.PointS(0F, 55F);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.SizeF(120F, 16F);
            this.Label3.TabIndex = 14;
            this.Label3.Text = "报销管理系统";
            this.Label3.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            // 
            // Line1
            // 
            this.Line1.BackColor = System.Drawing.Color.White;
            this.Line1.Location = new Smobiler.Core.PointS(15F, 112F);
            this.Line1.Name = "Line1";
            this.Line1.Size = new System.Drawing.SizeF(88F, 1F);
            this.Line1.TabIndex = 15;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Label1.FontSize = 7F;
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new Smobiler.Core.PointS(25F, 123F);
            this.Label1.Name = "Label1";
            this.Label1.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label1.Size = new System.Drawing.SizeF(42F, 10F);
            this.Label1.TabIndex = 16;
            this.Label1.Text = "记住密码";
            // 
            // frmLogon
            // 
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.txtName,
            this.txtPwd,
            this.btn_Logo,
            this.LblMsg,
            this.Line2,
            this.Line3,
            this.CheckBox1,
            this.Label2,
            this.Label3,
            this.Line1,
            this.Label1});
            this.TitleBackColor = System.Drawing.Color.DeepSkyBlue;
            this.TitleImage = "formimg";
            this.TitleText = "登录";
            this.Load += new System.EventHandler(this.frmLogon_Load);

        }
        internal Smobiler.Core.Controls.TextBox txtName;
        internal Smobiler.Core.Controls.TextBox txtPwd;
        internal Smobiler.Core.Controls.Button btn_Logo;
        internal Smobiler.Core.Controls.Label LblMsg;
        internal Smobiler.Core.Controls.Line Line2;
        internal Smobiler.Core.Controls.Line Line3;
        internal Smobiler.Core.Controls.CheckBox CheckBox1;
        internal Smobiler.Core.Controls.Label Label2;

        internal Smobiler.Core.Controls.Label Label3;
        #endregion
        internal Line Line1;
        internal Label Label1;

    }
}
