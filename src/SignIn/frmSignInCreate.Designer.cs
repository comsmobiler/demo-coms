using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
namespace COMSSmobilerDemo.SignIn
{
    public partial class frmSignInCreate : Smobiler.Core.MobileForm
    {

        #region "SmobilerForm Designer generated code "

        public frmSignInCreate()
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
            this.btntype = new Smobiler.Core.Controls.Button();
            this.btntype2 = new Smobiler.Core.Controls.Button();
            this.Label2 = new Smobiler.Core.Controls.Label();
            this.Label3 = new Smobiler.Core.Controls.Label();
            this.Label4 = new Smobiler.Core.Controls.Label();
            this.btnPunchCardType = new Smobiler.Core.Controls.Button();
            this.btnPunchCardType2 = new Smobiler.Core.Controls.Button();
            this.lblDate = new Smobiler.Core.Controls.Label();
            this.txtAddress = new Smobiler.Core.Controls.TextBox();
            this.SignIn = new Smobiler.Core.Controls.ToolbarItem();
            this.tExit = new Smobiler.Core.Controls.ToolbarItem();
            this.Gps1 = new Smobiler.Core.Controls.GPS();
            this.PopList1 = new Smobiler.Core.Controls.PopList();
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
            this.Label1.Text = "类型";
            // 
            // btntype
            // 
            this.btntype.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.btntype.BorderColor = System.Drawing.Color.DarkGray;
            this.btntype.FontSize = 7F;
            this.btntype.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Left;
            this.btntype.Location = new Smobiler.Core.PointS(35F, 0F);
            this.btntype.Name = "btntype";
            this.btntype.Size = new System.Drawing.SizeF(72F, 14F);
            this.btntype.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btntype.TabIndex = 3;
            this.btntype.Text = "类型选择(必填)";
            this.btntype.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btntype2_Click);
            // 
            // btntype2
            // 
            this.btntype2.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.btntype2.BorderColor = System.Drawing.Color.DarkGray;
            this.btntype2.FontSize = 8F;
            this.btntype2.ForeColor = System.Drawing.Color.Gray;
            this.btntype2.Location = new Smobiler.Core.PointS(107F, 0F);
            this.btntype2.Name = "btntype2";
            this.btntype2.Size = new System.Drawing.SizeF(13F, 14F);
            this.btntype2.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btntype2.TabIndex = 4;
            this.btntype2.Text = ">";
            this.btntype2.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btntype2_Click);
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
            this.Label2.Text = "时间";
            // 
            // Label3
            // 
            this.Label3.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label3.BorderColor = System.Drawing.Color.DarkGray;
            this.Label3.ForeColor = System.Drawing.Color.Gray;
            this.Label3.Location = new Smobiler.Core.PointS(0F, 31F);
            this.Label3.Name = "Label3";
            this.Label3.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label3.Size = new System.Drawing.SizeF(35F, 24F);
            this.Label3.TabIndex = 6;
            this.Label3.Text = "地点";
            // 
            // Label4
            // 
            this.Label4.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label4.BorderColor = System.Drawing.Color.DarkGray;
            this.Label4.ForeColor = System.Drawing.Color.Gray;
            this.Label4.Location = new Smobiler.Core.PointS(0F, 58F);
            this.Label4.Name = "Label4";
            this.Label4.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label4.Size = new System.Drawing.SizeF(35F, 14F);
            this.Label4.TabIndex = 7;
            this.Label4.Text = "打卡类型";
            // 
            // btnPunchCardType
            // 
            this.btnPunchCardType.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.btnPunchCardType.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPunchCardType.FontSize = 7F;
            this.btnPunchCardType.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Left;
            this.btnPunchCardType.Location = new Smobiler.Core.PointS(35F, 58F);
            this.btnPunchCardType.Name = "btnPunchCardType";
            this.btnPunchCardType.Size = new System.Drawing.SizeF(72F, 14F);
            this.btnPunchCardType.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btnPunchCardType.TabIndex = 8;
            this.btnPunchCardType.Text = "打卡类型选择(必填)";
            this.btnPunchCardType.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btntype2_Click);
            // 
            // btnPunchCardType2
            // 
            this.btnPunchCardType2.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.btnPunchCardType2.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPunchCardType2.FontSize = 8F;
            this.btnPunchCardType2.ForeColor = System.Drawing.Color.Gray;
            this.btnPunchCardType2.Location = new Smobiler.Core.PointS(107F, 58F);
            this.btnPunchCardType2.Name = "btnPunchCardType2";
            this.btnPunchCardType2.Size = new System.Drawing.SizeF(13F, 14F);
            this.btnPunchCardType2.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btnPunchCardType2.TabIndex = 9;
            this.btnPunchCardType2.Text = ">";
            this.btnPunchCardType2.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btntype2_Click);
            // 
            // lblDate
            // 
            this.lblDate.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.lblDate.BorderColor = System.Drawing.Color.DarkGray;
            this.lblDate.FontSize = 7F;
            this.lblDate.Location = new Smobiler.Core.PointS(35F, 17F);
            this.lblDate.Name = "lblDate";
            this.lblDate.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.lblDate.Size = new System.Drawing.SizeF(85F, 14F);
            this.lblDate.TabIndex = 10;
            // 
            // txtAddress
            // 
            this.txtAddress.BorderColor = System.Drawing.Color.DarkGray;
            this.txtAddress.FontSize = 7F;
            this.txtAddress.Location = new Smobiler.Core.PointS(35F, 31F);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.SizeF(85F, 24F);
            this.txtAddress.TabIndex = 11;
            // 
            // SignIn
            // 
            this.SignIn.IconID = "save";
            this.SignIn.Name = "SignIn";
            this.SignIn.Text = "签到";
            // 
            // tExit
            // 
            this.tExit.IconID = "Exit";
            this.tExit.Name = "tExit";
            this.tExit.Text = "返回";
            // 
            // Gps1
            // 
            this.Gps1.Name = "Gps1";
            // 
            // PopList1
            // 
            this.PopList1.Name = "PopList1";
            this.PopList1.Selected += new System.EventHandler(this.PopList1_Selected);
            // 
            // frmSignInCreate
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ComponentControls.AddRange(new Smobiler.Core.ComponentBase[] {
            this.Gps1,
            this.PopList1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label1,
            this.btntype,
            this.btntype2,
            this.Label2,
            this.Label3,
            this.Label4,
            this.btnPunchCardType,
            this.btnPunchCardType2,
            this.lblDate,
            this.txtAddress});
            this.TitleBackColor = System.Drawing.Color.DeepSkyBlue;
            this.TitleText = "签到录入";
            this.Toolbar.AddRange(new Smobiler.Core.Controls.ToolbarItem[] {
            this.tExit,
            this.SignIn});
            this.Load += new System.EventHandler(this.frmSignInCreate_Load);
            this.ToolbarItemClick += new Smobiler.Core.ToolbarItemClickEventHandler(this.frmSignInCreate_ToolbarItemClick);

        }
        internal Smobiler.Core.Controls.Label Label1;
        internal Smobiler.Core.Controls.Button btntype;
        internal Smobiler.Core.Controls.Button btntype2;
        internal Smobiler.Core.Controls.Label Label2;
        internal Smobiler.Core.Controls.Label Label3;
        internal Smobiler.Core.Controls.Label Label4;
        internal Smobiler.Core.Controls.Button btnPunchCardType;
        internal Smobiler.Core.Controls.Button btnPunchCardType2;
        internal Smobiler.Core.Controls.Label lblDate;
        internal Smobiler.Core.Controls.TextBox txtAddress;
        internal Smobiler.Core.Controls.ToolbarItem SignIn;
        internal Smobiler.Core.Controls.ToolbarItem tExit;
        internal Smobiler.Core.Controls.GPS Gps1;

        internal Smobiler.Core.Controls.PopList PopList1;
        #endregion

    }


}