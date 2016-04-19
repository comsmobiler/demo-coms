
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
namespace COMSSmobilerDemo
{
    public partial class frmUserDetail : Smobiler.Core.MobileForm
    {

        #region "SmobilerForm Designer generated code "

        public frmUserDetail()
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
            this.lblUser = new Smobiler.Core.Controls.Label();
            this.Label2 = new Smobiler.Core.Controls.Label();
            this.Label3 = new Smobiler.Core.Controls.Label();
            this.lblUSER_EMAIL = new Smobiler.Core.Controls.Label();
            this.Label5 = new Smobiler.Core.Controls.Label();
            this.lblUSER_PHONE = new Smobiler.Core.Controls.Label();
            this.Label7 = new Smobiler.Core.Controls.Label();
            this.lblUSER_MOBILEPHONE = new Smobiler.Core.Controls.Label();
            this.Line1 = new Smobiler.Core.Controls.Line();
            this.Line2 = new Smobiler.Core.Controls.Line();
            this.Line3 = new Smobiler.Core.Controls.Line();
            this.btnUpUserImg = new Smobiler.Core.Controls.ImageButton();
            this.Camera1 = new Smobiler.Core.Controls.Camera();
            // 
            // lblUser
            // 
            this.lblUser.BorderColor = System.Drawing.Color.Silver;
            this.lblUser.FontSize = 9F;
            this.lblUser.Name = "lblUser";
            this.lblUser.Padding = new Smobiler.Core.Padding(4F, 0F, 2F, 0F);
            this.lblUser.Size = new System.Drawing.SizeF(100F, 20F);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "MobilerUser";
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Label2.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label2.BorderColor = System.Drawing.Color.Silver;
            this.Label2.ForeColor = System.Drawing.Color.Gray;
            this.Label2.Location = new Smobiler.Core.PointS(0F, 20F);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.SizeF(120F, 8F);
            this.Label2.TabIndex = 5;
            // 
            // Label3
            // 
            this.Label3.Location = new Smobiler.Core.PointS(0F, 28F);
            this.Label3.Name = "Label3";
            this.Label3.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.Label3.Size = new System.Drawing.SizeF(35F, 12F);
            this.Label3.TabIndex = 6;
            this.Label3.Text = "邮箱";
            // 
            // lblUSER_EMAIL
            // 
            this.lblUSER_EMAIL.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblUSER_EMAIL.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblUSER_EMAIL.Location = new Smobiler.Core.PointS(35F, 28F);
            this.lblUSER_EMAIL.Name = "lblUSER_EMAIL";
            this.lblUSER_EMAIL.Padding = new Smobiler.Core.Padding(2F, 0F, 2F, 0F);
            this.lblUSER_EMAIL.Size = new System.Drawing.SizeF(85F, 12F);
            this.lblUSER_EMAIL.TabIndex = 7;
            this.lblUSER_EMAIL.Text = "无";
            // 
            // Label5
            // 
            this.Label5.Location = new Smobiler.Core.PointS(0F, 40F);
            this.Label5.Name = "Label5";
            this.Label5.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.Label5.Size = new System.Drawing.SizeF(35F, 12F);
            this.Label5.TabIndex = 8;
            this.Label5.Text = "电话";
            // 
            // lblUSER_PHONE
            // 
            this.lblUSER_PHONE.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblUSER_PHONE.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblUSER_PHONE.Location = new Smobiler.Core.PointS(35F, 40F);
            this.lblUSER_PHONE.Name = "lblUSER_PHONE";
            this.lblUSER_PHONE.Padding = new Smobiler.Core.Padding(2F, 0F, 2F, 0F);
            this.lblUSER_PHONE.Size = new System.Drawing.SizeF(85F, 12F);
            this.lblUSER_PHONE.TabIndex = 9;
            this.lblUSER_PHONE.Text = "021-63046141";
            // 
            // Label7
            // 
            this.Label7.Location = new Smobiler.Core.PointS(0F, 52F);
            this.Label7.Name = "Label7";
            this.Label7.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.Label7.Size = new System.Drawing.SizeF(35F, 12F);
            this.Label7.TabIndex = 10;
            this.Label7.Text = "手机";
            // 
            // lblUSER_MOBILEPHONE
            // 
            this.lblUSER_MOBILEPHONE.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblUSER_MOBILEPHONE.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblUSER_MOBILEPHONE.Location = new Smobiler.Core.PointS(35F, 52F);
            this.lblUSER_MOBILEPHONE.Name = "lblUSER_MOBILEPHONE";
            this.lblUSER_MOBILEPHONE.Padding = new Smobiler.Core.Padding(2F, 0F, 2F, 0F);
            this.lblUSER_MOBILEPHONE.Size = new System.Drawing.SizeF(85F, 12F);
            this.lblUSER_MOBILEPHONE.TabIndex = 11;
            this.lblUSER_MOBILEPHONE.Text = "无";
            // 
            // Line1
            // 
            this.Line1.BackColor = System.Drawing.Color.Silver;
            this.Line1.Location = new Smobiler.Core.PointS(2F, 40F);
            this.Line1.Name = "Line1";
            this.Line1.Size = new System.Drawing.SizeF(118F, 1F);
            this.Line1.TabIndex = 12;
            // 
            // Line2
            // 
            this.Line2.BackColor = System.Drawing.Color.Silver;
            this.Line2.Location = new Smobiler.Core.PointS(2F, 52F);
            this.Line2.Name = "Line2";
            this.Line2.Size = new System.Drawing.SizeF(118F, 1F);
            this.Line2.TabIndex = 13;
            // 
            // Line3
            // 
            this.Line3.BackColor = System.Drawing.Color.Silver;
            this.Line3.Location = new Smobiler.Core.PointS(0F, 64F);
            this.Line3.Name = "Line3";
            this.Line3.Size = new System.Drawing.SizeF(120F, 1F);
            this.Line3.TabIndex = 14;
            // 
            // btnUpUserImg
            // 
            this.btnUpUserImg.FontSize = 4F;
            this.btnUpUserImg.Location = new Smobiler.Core.PointS(100F, 0F);
            this.btnUpUserImg.Name = "btnUpUserImg";
            this.btnUpUserImg.ResourceID = "MobilerUser";
            this.btnUpUserImg.Size = new System.Drawing.SizeF(20F, 20F);
            this.btnUpUserImg.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btnUpUserImg.TabIndex = 16;
            this.btnUpUserImg.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnUpUserImg_Click);
            // 
            // Camera1
            // 
            this.Camera1.Name = "Camera1";
            this.Camera1.ImageCaptured += new Smobiler.Core.CameraOnlineCallBackHandler(this.Camera1_ImageCaptured);
            // 
            // frmUserDetail
            // 
            this.ComponentControls.AddRange(new Smobiler.Core.ComponentBase[] {
            this.Camera1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblUser,
            this.Label2,
            this.Label3,
            this.lblUSER_EMAIL,
            this.Label5,
            this.lblUSER_PHONE,
            this.Label7,
            this.lblUSER_MOBILEPHONE,
            this.Line1,
            this.Line2,
            this.Line3,
            this.btnUpUserImg});
            this.LeftFormLayout = "frmMainLeftLayout";
            this.TitleBackColor = System.Drawing.Color.DeepSkyBlue;
            this.TitleImage = "iconfont-menu";
            this.TitleText = "个人信息";
            this.LeftLayoutItemClick += new Smobiler.Core.MobileFormLayoutItemClickEventHandler(this.frmUserDetail_LeftLayoutItemClick);
            this.TitleImageClick += new System.EventHandler(this.ImageButton1_Click);

        }
        internal Smobiler.Core.Controls.Label lblUser;
        internal Smobiler.Core.Controls.Label Label2;
        internal Smobiler.Core.Controls.Label Label3;
        internal Smobiler.Core.Controls.Label lblUSER_EMAIL;
        internal Smobiler.Core.Controls.Label Label5;
        internal Smobiler.Core.Controls.Label lblUSER_PHONE;
        internal Smobiler.Core.Controls.Label Label7;
        internal Smobiler.Core.Controls.Label lblUSER_MOBILEPHONE;
        internal Smobiler.Core.Controls.Line Line1;
        internal Smobiler.Core.Controls.Line Line2;
        internal Smobiler.Core.Controls.Line Line3;
        internal Smobiler.Core.Controls.ImageButton btnUpUserImg;

        internal Smobiler.Core.Controls.Camera Camera1;
        #endregion

    }
}
