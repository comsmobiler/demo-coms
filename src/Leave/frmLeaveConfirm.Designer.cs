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
            this.Label2 = new Smobiler.Core.Controls.Label();
            this.CheckBox2 = new Smobiler.Core.Controls.CheckBox();
            this.Label3 = new Smobiler.Core.Controls.Label();
            this.CheckBox1 = new Smobiler.Core.Controls.CheckBox();
            this.Confirm = new Smobiler.Core.Controls.ToolbarItem();
            this.Line1 = new Smobiler.Core.Controls.Line();
            // 
            // txtL_REASON
            // 
            this.txtL_REASON.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtL_REASON.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.txtL_REASON.Location = new Smobiler.Core.PointS(0F, 28F);
            this.txtL_REASON.Multiline = true;
            this.txtL_REASON.Name = "txtL_REASON";
            this.txtL_REASON.Padding = new Smobiler.Core.Padding(2F, 5F, 12F, 0F);
            this.txtL_REASON.Size = new System.Drawing.SizeF(120F, 40F);
            this.txtL_REASON.TabIndex = 2;
            this.txtL_REASON.Visible = false;
            this.txtL_REASON.WaterMarkText = "填写理由";
            // 
            // Label2
            // 
            this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label2.Name = "Label2";
            this.Label2.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label2.Size = new System.Drawing.SizeF(120F, 14F);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "通过审批";
            this.Label2.ZIndex = 1;
            // 
            // CheckBox2
            // 
            this.CheckBox2.BackColor = System.Drawing.Color.White;
            this.CheckBox2.Border = new Smobiler.Core.Border(1);
            this.CheckBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.CheckBox2.Checked = false;
            this.CheckBox2.Location = new Smobiler.Core.PointS(100F, 17F);
            this.CheckBox2.Name = "CheckBox2";
            this.CheckBox2.Size = new System.Drawing.SizeF(8F, 8F);
            this.CheckBox2.TabIndex = 6;
            this.CheckBox2.UnCheckedBackColor = System.Drawing.Color.White;
            this.CheckBox2.ZIndex = 5;
            this.CheckBox2.CheckChanged += new Smobiler.Core.Controls.CheckdControlBase.CheckChangedEventHandler(this.CheckBox2_CheckChanged);
            // 
            // Label3
            // 
            this.Label3.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label3.Location = new Smobiler.Core.PointS(0F, 14F);
            this.Label3.Name = "Label3";
            this.Label3.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label3.Size = new System.Drawing.SizeF(120F, 14F);
            this.Label3.TabIndex = 7;
            this.Label3.Text = "拒绝审批";
            this.Label3.ZIndex = 4;
            // 
            // CheckBox1
            // 
            this.CheckBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(121)))), ((int)(((byte)(252)))));
            this.CheckBox1.Border = new Smobiler.Core.Border(1);
            this.CheckBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.CheckBox1.Location = new Smobiler.Core.PointS(100F, 3F);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.SizeF(8F, 8F);
            this.CheckBox1.TabIndex = 8;
            this.CheckBox1.UnCheckedBackColor = System.Drawing.Color.White;
            this.CheckBox1.ZIndex = 2;
            this.CheckBox1.CheckChanged += new Smobiler.Core.Controls.CheckdControlBase.CheckChangedEventHandler(this.CheckBox3_CheckChanged);
            // 
            // Confirm
            // 
            this.Confirm.IconID = "!\\ue065043146223";
            this.Confirm.Name = "Confirm";
            this.Confirm.Text = "审批";
            // 
            // Line1
            // 
            this.Line1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Line1.Location = new Smobiler.Core.PointS(0F, 14F);
            this.Line1.Name = "Line1";
            this.Line1.Size = new System.Drawing.SizeF(120F, 1F);
            this.Line1.TabIndex = 9;
            this.Line1.ZIndex = 3;
            // 
            // frmLeaveConfirm
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.txtL_REASON,
            this.Label2,
            this.CheckBox1,
            this.Line1,
            this.Label3,
            this.CheckBox2});
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.StatusBarStyle = Smobiler.Core.StatusBarStyle.Default;
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("Exit", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(50))))));
            this.TitleText = "请假审批";
            this.Toolbar.AddRange(new Smobiler.Core.Controls.ToolbarItem[] {
            this.Confirm});
            this.ToolbarStyle = new Smobiler.Core.ToolBarSytle(Smobiler.Core.ToolbarSelectStyle.None, System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))), System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))));
            this.ToolbarItemClick += new Smobiler.Core.ToolbarItemClickEventHandler(this.frmLeaveConfirm_ToolbarItemClick);
            this.TitleImageClick += new System.EventHandler(this.MobileForm_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.MobileForm_KeyDown);

        }
        internal Smobiler.Core.Controls.TextBox txtL_REASON;
        internal Smobiler.Core.Controls.Label Label2;
        internal Smobiler.Core.Controls.CheckBox CheckBox2;
        internal Smobiler.Core.Controls.Label Label3;
        internal Smobiler.Core.Controls.CheckBox CheckBox1;
        internal Smobiler.Core.Controls.ToolbarItem Confirm;
        internal Smobiler.Core.Controls.Line Line1;
        #endregion

    }
}