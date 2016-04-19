
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
using Smobiler.Core.Controls;
namespace COMSSmobilerDemo.Reimbursement.RB
{
    public partial class frmRBConfirm : Smobiler.Core.MobileForm
    {
        #region "VTForm Designer generated code "

        public frmRBConfirm()
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
            this.Label1 = new Smobiler.Core.Controls.Label();
            this.lblRB_COSTCENTER = new Smobiler.Core.Controls.Label();
            this.Label4 = new Smobiler.Core.Controls.Label();
            this.lblRB_AMOUNT = new Smobiler.Core.Controls.Label();
            this.txtRB_REASON = new Smobiler.Core.Controls.TextBox();
            this.CheckBox1 = new Smobiler.Core.Controls.CheckBox();
            this.Label2 = new Smobiler.Core.Controls.Label();
            this.CheckBox2 = new Smobiler.Core.Controls.CheckBox();
            this.Label3 = new Smobiler.Core.Controls.Label();
            this.tExit = new Smobiler.Core.Controls.ToolbarItem();
            this.save = new Smobiler.Core.Controls.ToolbarItem();
            this.lblREASON = new Smobiler.Core.Controls.Label();
            this.Label8 = new Smobiler.Core.Controls.Label();
            this.Line3 = new Smobiler.Core.Controls.Line();
            this.Label9 = new Smobiler.Core.Controls.Label();
            // 
            // Label1
            // 
            this.Label1.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label1.BorderColor = System.Drawing.Color.DarkGray;
            this.Label1.ForeColor = System.Drawing.Color.Gray;
            this.Label1.Name = "Label1";
            this.Label1.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label1.Size = new System.Drawing.SizeF(40F, 14F);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "成本中心";
            // 
            // lblRB_COSTCENTER
            // 
            this.lblRB_COSTCENTER.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.lblRB_COSTCENTER.BorderColor = System.Drawing.Color.DarkGray;
            this.lblRB_COSTCENTER.DataMember = "RB_COSTCENTER";
            this.lblRB_COSTCENTER.DisplayMember = "RB_COSTCENTER";
            this.lblRB_COSTCENTER.FontSize = 7F;
            this.lblRB_COSTCENTER.Location = new Smobiler.Core.PointS(40F, 0F);
            this.lblRB_COSTCENTER.Name = "lblRB_COSTCENTER";
            this.lblRB_COSTCENTER.Size = new System.Drawing.SizeF(80F, 14F);
            this.lblRB_COSTCENTER.TabIndex = 3;
            this.lblRB_COSTCENTER.Text = "2015年项目预算";
            // 
            // Label4
            // 
            this.Label4.ForeColor = System.Drawing.Color.Gray;
            this.Label4.Location = new Smobiler.Core.PointS(0F, 14F);
            this.Label4.Name = "Label4";
            this.Label4.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label4.Size = new System.Drawing.SizeF(40F, 14F);
            this.Label4.TabIndex = 4;
            this.Label4.Text = "报销金额";
            // 
            // lblRB_AMOUNT
            // 
            this.lblRB_AMOUNT.DataMember = "RBROW_AMOUNT";
            this.lblRB_AMOUNT.DisplayMember = "RBROW_AMOUNT";
            this.lblRB_AMOUNT.FontSize = 7F;
            this.lblRB_AMOUNT.Location = new Smobiler.Core.PointS(40F, 14F);
            this.lblRB_AMOUNT.Name = "lblRB_AMOUNT";
            this.lblRB_AMOUNT.Size = new System.Drawing.SizeF(80F, 14F);
            this.lblRB_AMOUNT.TabIndex = 5;
            this.lblRB_AMOUNT.Text = "500";
            // 
            // txtRB_REASON
            // 
            this.txtRB_REASON.BorderColor = System.Drawing.Color.DarkGray;
            this.txtRB_REASON.FontSize = 7F;
            this.txtRB_REASON.Location = new Smobiler.Core.PointS(0F, 66F);
            this.txtRB_REASON.Multiline = true;
            this.txtRB_REASON.Name = "txtRB_REASON";
            this.txtRB_REASON.Size = new System.Drawing.SizeF(120F, 35F);
            this.txtRB_REASON.TabIndex = 9;
            this.txtRB_REASON.Visible = false;
            this.txtRB_REASON.WaterMarkText = "点击填写拒绝报销理由";
            // 
            // CheckBox1
            // 
            this.CheckBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(121)))), ((int)(((byte)(252)))));
            this.CheckBox1.Border = new Smobiler.Core.Border(1);
            this.CheckBox1.Location = new Smobiler.Core.PointS(41F, 34F);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.SizeF(8F, 8F);
            this.CheckBox1.TabIndex = 10;
            this.CheckBox1.UnCheckedBackColor = System.Drawing.Color.White;
            // 
            // Label2
            // 
            this.Label2.ForeColor = System.Drawing.Color.Gray;
            this.Label2.Location = new Smobiler.Core.PointS(0F, 31F);
            this.Label2.Name = "Label2";
            this.Label2.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label2.Size = new System.Drawing.SizeF(40F, 14F);
            this.Label2.TabIndex = 11;
            this.Label2.Text = "通过审批";
            // 
            // CheckBox2
            // 
            this.CheckBox2.BackColor = System.Drawing.Color.White;
            this.CheckBox2.Border = new Smobiler.Core.Border(1);
            this.CheckBox2.Checked = false;
            this.CheckBox2.Location = new Smobiler.Core.PointS(41F, 48F);
            this.CheckBox2.Name = "CheckBox2";
            this.CheckBox2.Size = new System.Drawing.SizeF(8F, 8F);
            this.CheckBox2.TabIndex = 12;
            this.CheckBox2.UnCheckedBackColor = System.Drawing.Color.White;
            // 
            // Label3
            // 
            this.Label3.ForeColor = System.Drawing.Color.Gray;
            this.Label3.Location = new Smobiler.Core.PointS(0F, 45F);
            this.Label3.Name = "Label3";
            this.Label3.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label3.Size = new System.Drawing.SizeF(40F, 14F);
            this.Label3.TabIndex = 13;
            this.Label3.Text = "拒绝报销";
            // 
            // tExit
            // 
            this.tExit.IconID = "Exit";
            this.tExit.Name = "tExit";
            this.tExit.Text = "返回";
            // 
            // save
            // 
            this.save.IconID = "shenpi";
            this.save.Name = "save";
            this.save.Text = "审核";
            // 
            // lblREASON
            // 
            this.lblREASON.BackColor = System.Drawing.Color.Gainsboro;
            this.lblREASON.Border = new Smobiler.Core.Border(0, 1, 0, 0);
            this.lblREASON.BorderColor = System.Drawing.Color.DarkGray;
            this.lblREASON.FontSize = 5F;
            this.lblREASON.ForeColor = System.Drawing.Color.Gray;
            this.lblREASON.Location = new Smobiler.Core.PointS(0F, 58F);
            this.lblREASON.Name = "lblREASON";
            this.lblREASON.Padding = new Smobiler.Core.Padding(3F, 0F, 0F, 0F);
            this.lblREASON.Size = new System.Drawing.SizeF(120F, 8F);
            this.lblREASON.TabIndex = 14;
            this.lblREASON.Text = "拒绝理由";
            this.lblREASON.Visible = false;
            // 
            // Label8
            // 
            this.Label8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Label8.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label8.BorderColor = System.Drawing.Color.DarkGray;
            this.Label8.FontSize = 7F;
            this.Label8.ForeColor = System.Drawing.Color.Gray;
            this.Label8.Location = new Smobiler.Core.PointS(0F, 28F);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.SizeF(120F, 3F);
            this.Label8.TabIndex = 17;
            // 
            // Line3
            // 
            this.Line3.BackColor = System.Drawing.Color.DarkGray;
            this.Line3.Location = new Smobiler.Core.PointS(2F, 45F);
            this.Line3.Name = "Line3";
            this.Line3.Size = new System.Drawing.SizeF(118F, 1F);
            this.Line3.TabIndex = 21;
            // 
            // Label9
            // 
            this.Label9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Label9.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label9.BorderColor = System.Drawing.Color.DarkGray;
            this.Label9.FontSize = 1F;
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.SizeF(120F, 5F);
            this.Label9.TabIndex = 18;
            // 
            // frmRBConfirm1
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label1,
            this.lblRB_COSTCENTER,
            this.Label4,
            this.lblRB_AMOUNT,
            this.txtRB_REASON,
            this.CheckBox1,
            this.Label2,
            this.CheckBox2,
            this.Label3,
            this.lblREASON,
            this.Label8,
            this.Line3});
            this.TitleBackColor = System.Drawing.Color.DeepSkyBlue;
            this.TitleImage = "formimg";
            this.TitleText = " 报销审核";
            this.Toolbar.AddRange(new Smobiler.Core.Controls.ToolbarItem[] {
            this.tExit,
            this.save});
            this.ToolbarItemClick += new Smobiler.Core.ToolbarItemClickEventHandler(this.frmRBConfirm_ToolbarItemClick);

        }
        internal Smobiler.Core.Controls.Label Label1;
        internal Smobiler.Core.Controls.Label lblRB_COSTCENTER;
        internal Smobiler.Core.Controls.Label Label4;
        internal Smobiler.Core.Controls.Label lblRB_AMOUNT;
        internal Smobiler.Core.Controls.TextBox txtRB_REASON;
        internal Smobiler.Core.Controls.CheckBox CheckBox1;
        internal Smobiler.Core.Controls.Label Label2;
        internal Smobiler.Core.Controls.CheckBox CheckBox2;
        internal Smobiler.Core.Controls.Label Label3;
        internal Smobiler.Core.Controls.ToolbarItem tExit;
        internal Smobiler.Core.Controls.ToolbarItem save;
        internal Smobiler.Core.Controls.Label lblREASON;
        internal Smobiler.Core.Controls.Label Label8;
        internal Smobiler.Core.Controls.Line Line3;

        internal Smobiler.Core.Controls.Label Label9;
        #endregion

    }
}