
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
            this.save = new Smobiler.Core.Controls.ToolbarItem();
            this.Line3 = new Smobiler.Core.Controls.Line();
            this.Label9 = new Smobiler.Core.Controls.Label();
            // 
            // Label1
            // 
            this.Label1.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label1.Name = "Label1";
            this.Label1.Padding = new Smobiler.Core.Padding(2F, 5F, 0F, 0F);
            this.Label1.Size = new System.Drawing.Size(70,48);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "成本中心";
            this.Label1.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            this.Label1.ZIndex = 1;
            // 
            // lblRB_COSTCENTER
            // 
            this.lblRB_COSTCENTER.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.lblRB_COSTCENTER.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblRB_COSTCENTER.DataMember = "RB_COSTCENTER";
            this.lblRB_COSTCENTER.DisplayMember = "RB_COSTCENTER";
            this.lblRB_COSTCENTER.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblRB_COSTCENTER.Location = new System.Drawing.Point(70,0);
            this.lblRB_COSTCENTER.Name = "lblRB_COSTCENTER";
            this.lblRB_COSTCENTER.Padding = new Smobiler.Core.Padding(0F, 5F, 12F, 0F);
            this.lblRB_COSTCENTER.Size = new System.Drawing.Size(170,48);
            this.lblRB_COSTCENTER.TabIndex = 3;
            this.lblRB_COSTCENTER.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            this.lblRB_COSTCENTER.ZIndex = 2;
            // 
            // Label4
            // 
            this.Label4.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label4.Location = new System.Drawing.Point(0,54);
            this.Label4.Name = "Label4";
            this.Label4.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label4.Size = new System.Drawing.Size(70,28);
            this.Label4.TabIndex = 4;
            this.Label4.Text = "报销金额";
            this.Label4.ZIndex = 3;
            // 
            // lblRB_AMOUNT
            // 
            this.lblRB_AMOUNT.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.lblRB_AMOUNT.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblRB_AMOUNT.DataMember = "RBROW_AMOUNT";
            this.lblRB_AMOUNT.DisplayMember = "RBROW_AMOUNT";
            this.lblRB_AMOUNT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblRB_AMOUNT.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblRB_AMOUNT.Location = new System.Drawing.Point(70,54);
            this.lblRB_AMOUNT.Name = "lblRB_AMOUNT";
            this.lblRB_AMOUNT.Padding = new Smobiler.Core.Padding(0F, 0F, 12F, 0F);
            this.lblRB_AMOUNT.Size = new System.Drawing.Size(170,28);
            this.lblRB_AMOUNT.TabIndex = 5;
            this.lblRB_AMOUNT.Text = "250.00";
            this.lblRB_AMOUNT.ZIndex = 4;
            // 
            // txtRB_REASON
            // 
            this.txtRB_REASON.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtRB_REASON.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.txtRB_REASON.Location = new System.Drawing.Point(0,142);
            this.txtRB_REASON.Multiline = true;
            this.txtRB_REASON.Name = "txtRB_REASON";
            this.txtRB_REASON.Padding = new Smobiler.Core.Padding(2F, 5F, 12F, 0F);
            this.txtRB_REASON.Size = new System.Drawing.Size(240,70);
            this.txtRB_REASON.TabIndex = 9;
            this.txtRB_REASON.Visible = false;
            this.txtRB_REASON.WaterMarkText = "填写理由";
            this.txtRB_REASON.ZIndex = 10;
            // 
            // CheckBox1
            // 
            this.CheckBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(121)))), ((int)(((byte)(252)))));
            this.CheckBox1.Border = new Smobiler.Core.Border(1);
            this.CheckBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.CheckBox1.Location = new System.Drawing.Point(200,92);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(16,16);
            this.CheckBox1.TabIndex = 10;
            this.CheckBox1.UnCheckedBackColor = System.Drawing.Color.White;
            this.CheckBox1.ZIndex = 6;
            this.CheckBox1.CheckChanged += new Smobiler.Core.Controls.CheckdControlBase.CheckChangedEventHandler(this.CheckBox1_CheckChanged);
            // 
            // Label2
            // 
            this.Label2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label2.Location = new System.Drawing.Point(0,86);
            this.Label2.Name = "Label2";
            this.Label2.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label2.Size = new System.Drawing.Size(240,28);
            this.Label2.TabIndex = 11;
            this.Label2.Text = "通过审批";
            this.Label2.ZIndex = 5;
            // 
            // CheckBox2
            // 
            this.CheckBox2.BackColor = System.Drawing.Color.White;
            this.CheckBox2.Border = new Smobiler.Core.Border(1);
            this.CheckBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.CheckBox2.Checked = false;
            this.CheckBox2.Location = new System.Drawing.Point(200,120);
            this.CheckBox2.Name = "CheckBox2";
            this.CheckBox2.Size = new System.Drawing.Size(16,16);
            this.CheckBox2.TabIndex = 12;
            this.CheckBox2.UnCheckedBackColor = System.Drawing.Color.White;
            this.CheckBox2.ZIndex = 9;
            this.CheckBox2.CheckChanged += new Smobiler.Core.Controls.CheckdControlBase.CheckChangedEventHandler(this.CheckBox2_CheckChanged);
            // 
            // Label3
            // 
            this.Label3.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label3.Location = new System.Drawing.Point(0,114);
            this.Label3.Name = "Label3";
            this.Label3.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label3.Size = new System.Drawing.Size(240,28);
            this.Label3.TabIndex = 13;
            this.Label3.Text = "拒绝报销";
            this.Label3.ZIndex = 8;
            // 
            // save
            // 
            this.save.IconID = "!\\ue065043146223";
            this.save.Name = "save";
            this.save.Text = "审核";
            // 
            // Line3
            // 
            this.Line3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Line3.Location = new System.Drawing.Point(0,114);
            this.Line3.Name = "Line3";
            this.Line3.Size = new System.Drawing.Size(240,2);
            this.Line3.TabIndex = 21;
            this.Line3.ZIndex = 7;
            // 
            // Label9
            // 
            this.Label9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Label9.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label9.FontSize = 2;
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(240,10);
            this.Label9.TabIndex = 18;
            // 
            // frmRBConfirm
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label1,
            this.lblRB_COSTCENTER,
            this.Label4,
            this.lblRB_AMOUNT,
            this.Label2,
            this.CheckBox1,
            this.Line3,
            this.Label3,
            this.CheckBox2,
            this.txtRB_REASON});
            this.StatusBarStyle = Smobiler.Core.StatusBarStyle.Default;
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("Exit", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(50))))));
            this.TitleText = "报销审核";
            this.Toolbar.AddRange(new Smobiler.Core.Controls.ToolbarItem[] {
            this.save});
            this.ToolbarStyle = new Smobiler.Core.ToolBarSytle(Smobiler.Core.ToolbarSelectStyle.None, System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))), System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))));
            this.ToolbarItemClick += new Smobiler.Core.ToolbarItemClickEventHandler(this.frmRBConfirm_ToolbarItemClick);
            this.TitleImageClick += new System.EventHandler(this.MobileForm_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.MobileForm_KeyDown);

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
        internal Smobiler.Core.Controls.ToolbarItem save;
        internal Smobiler.Core.Controls.Line Line3;
        internal Smobiler.Core.Controls.Label Label9;
        #endregion

    }
}
