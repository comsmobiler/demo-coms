using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
namespace COMSSmobilerDemo.Leave
{
    public partial class frmLeaveConfirm : Smobiler.Core.MobileForm
    {

        #region "SmobilerForm Designer generated code "

        public frmLeaveConfirm()
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
            this.txtL_REASON = new Smobiler.Core.Controls.TextBox();
            this.lblREASON = new Smobiler.Core.Controls.Label();
            this.Label2 = new Smobiler.Core.Controls.Label();
            this.CheckBox2 = new Smobiler.Core.Controls.CheckBox();
            this.Label3 = new Smobiler.Core.Controls.Label();
            this.CheckBox3 = new Smobiler.Core.Controls.CheckBox();
            this.Confirm = new Smobiler.Core.Controls.ToolbarItem();
            this.tExit = new Smobiler.Core.Controls.ToolbarItem();
            this.Line1 = new Smobiler.Core.Controls.Line();
            // 
            // txtL_REASON
            // 
            this.txtL_REASON.BorderColor = System.Drawing.Color.DarkGray;
            this.txtL_REASON.FontSize = 7F;
            this.txtL_REASON.Location = new Smobiler.Core.PointS(0F, 36.5F);
            this.txtL_REASON.Multiline = true;
            this.txtL_REASON.Name = "txtL_REASON";
            this.txtL_REASON.Size = new System.Drawing.SizeF(120F, 40F);
            this.txtL_REASON.TabIndex = 2;
            this.txtL_REASON.Visible = false;
            this.txtL_REASON.WaterMarkText = "点击填写拒绝报销理由";
            // 
            // lblREASON
            // 
            this.lblREASON.BackColor = System.Drawing.Color.Gainsboro;
            this.lblREASON.Border = new Smobiler.Core.Border(0, 1, 0, 0);
            this.lblREASON.BorderColor = System.Drawing.Color.DarkGray;
            this.lblREASON.FontSize = 5F;
            this.lblREASON.ForeColor = System.Drawing.Color.Gray;
            this.lblREASON.Location = new Smobiler.Core.PointS(0F, 28.5F);
            this.lblREASON.Name = "lblREASON";
            this.lblREASON.Padding = new Smobiler.Core.Padding(3F, 0F, 0F, 0F);
            this.lblREASON.Size = new System.Drawing.SizeF(120F, 8F);
            this.lblREASON.TabIndex = 3;
            this.lblREASON.Text = "拒绝理由";
            this.lblREASON.Visible = false;
            // 
            // Label2
            // 
            this.Label2.ForeColor = System.Drawing.Color.Gray;
            this.Label2.Name = "Label2";
            this.Label2.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label2.Size = new System.Drawing.SizeF(40F, 14F);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "通过审批";
            // 
            // CheckBox2
            // 
            this.CheckBox2.BackColor = System.Drawing.Color.Gray;
            this.CheckBox2.Checked = false;
            this.CheckBox2.Location = new Smobiler.Core.PointS(41F, 17F);
            this.CheckBox2.Name = "CheckBox2";
            this.CheckBox2.Size = new System.Drawing.SizeF(8F, 8F);
            this.CheckBox2.TabIndex = 6;
            this.CheckBox2.CheckChanged += new Smobiler.Core.Controls.CheckdControlBase.CheckChangedEventHandler(this.CheckBox2_CheckChanged);
            // 
            // Label3
            // 
            this.Label3.ForeColor = System.Drawing.Color.Gray;
            this.Label3.Location = new Smobiler.Core.PointS(0F, 14F);
            this.Label3.Name = "Label3";
            this.Label3.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label3.Size = new System.Drawing.SizeF(40F, 14F);
            this.Label3.TabIndex = 7;
            this.Label3.Text = "拒绝审批";
            // 
            // CheckBox3
            // 
            this.CheckBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(121)))), ((int)(((byte)(252)))));
            this.CheckBox3.Location = new Smobiler.Core.PointS(41F, 3F);
            this.CheckBox3.Name = "CheckBox3";
            this.CheckBox3.Size = new System.Drawing.SizeF(8F, 8F);
            this.CheckBox3.TabIndex = 8;
            this.CheckBox3.CheckChanged += new Smobiler.Core.Controls.CheckdControlBase.CheckChangedEventHandler(this.CheckBox3_CheckChanged);
            // 
            // Confirm
            // 
            this.Confirm.IconID = "shenpi";
            this.Confirm.Name = "Confirm";
            this.Confirm.Text = "审批";
            // 
            // tExit
            // 
            this.tExit.IconID = "Exit";
            this.tExit.Name = "tExit";
            this.tExit.Text = "返回";
            // 
            // Line1
            // 
            this.Line1.BackColor = System.Drawing.Color.DarkGray;
            this.Line1.Location = new Smobiler.Core.PointS(3F, 14F);
            this.Line1.Name = "Line1";
            this.Line1.Size = new System.Drawing.SizeF(116F, 1F);
            this.Line1.TabIndex = 9;
            // 
            // frmLeaveConfirm
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.txtL_REASON,
            this.lblREASON,
            this.Label2,
            this.CheckBox2,
            this.Label3,
            this.CheckBox3,
            this.Line1});
            this.TitleBackColor = System.Drawing.Color.DeepSkyBlue;
            this.TitleText = "请假审批";
            this.Toolbar.AddRange(new Smobiler.Core.Controls.ToolbarItem[] {
            this.tExit,
            this.Confirm});
            this.ToolbarItemClick += new Smobiler.Core.ToolbarItemClickEventHandler(this.frmLeaveConfirm_ToolbarItemClick);

        }
        internal Smobiler.Core.Controls.TextBox txtL_REASON;
        internal Smobiler.Core.Controls.Label lblREASON;
        internal Smobiler.Core.Controls.Label Label2;
        internal Smobiler.Core.Controls.CheckBox CheckBox2;
        internal Smobiler.Core.Controls.Label Label3;
        internal Smobiler.Core.Controls.CheckBox CheckBox3;
        internal Smobiler.Core.Controls.ToolbarItem Confirm;
        internal Smobiler.Core.Controls.ToolbarItem tExit;

        internal Smobiler.Core.Controls.Line Line1;
        #endregion

    }
}