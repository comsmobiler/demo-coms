
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
namespace COMSSmobilerDemo.Reimbursement.RB
{
    public partial class frmRBDetail1 : Smobiler.Core.MobileForm
    {

        #region "SmobilerForm Designer generated code "

        public frmRBDetail1()
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
            this.lblnote = new Smobiler.Core.Controls.TextBox();
            this.lblRBAmount = new Smobiler.Core.Controls.Label();
            this.GridView1 = new Smobiler.Core.Controls.GridView();
            this.lblRBNO = new Smobiler.Core.Controls.Label();
            this.lblRBCC = new Smobiler.Core.Controls.Label();
            this.lblRBState = new Smobiler.Core.Controls.Label();
            this.tExit = new Smobiler.Core.Controls.ToolbarItem();
            this.lblRBUser = new Smobiler.Core.Controls.Label();
            this.save = new Smobiler.Core.Controls.ToolbarItem();
            this.txtRB_REASON = new Smobiler.Core.Controls.TextBox();
            this.Label8 = new Smobiler.Core.Controls.Label();
            this.Label1 = new Smobiler.Core.Controls.Label();
            this.Label2 = new Smobiler.Core.Controls.Label();
            this.lblnote1 = new Smobiler.Core.Controls.Label();
            this.lblRB_REASON1 = new Smobiler.Core.Controls.Label();
            // 
            // lblnote
            // 
            this.lblnote.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.lblnote.BorderColor = System.Drawing.Color.DarkGray;
            this.lblnote.FontSize = 7F;
            this.lblnote.Location = new Smobiler.Core.PointS(35F, 45F);
            this.lblnote.Multiline = true;
            this.lblnote.Name = "lblnote";
            this.lblnote.ReadOnly = true;
            this.lblnote.Size = new System.Drawing.SizeF(85F, 40F);
            this.lblnote.TabIndex = 4;
            // 
            // lblRBAmount
            // 
            this.lblRBAmount.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblRBAmount.BorderColor = System.Drawing.Color.DarkTurquoise;
            this.lblRBAmount.FontSize = 9F;
            this.lblRBAmount.ForeColor = System.Drawing.Color.White;
            this.lblRBAmount.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.lblRBAmount.Location = new Smobiler.Core.PointS(0F, 128F);
            this.lblRBAmount.Name = "lblRBAmount";
            this.lblRBAmount.Size = new System.Drawing.SizeF(120F, 8F);
            this.lblRBAmount.TabIndex = 5;
            // 
            // GridView1
            // 
            this.GridView1.Layout = "frmRBROWLayout";
            this.GridView1.Location = new Smobiler.Core.PointS(0F, 146F);
            this.GridView1.Name = "GridView1";
            this.GridView1.ShowGridLines = false;
            this.GridView1.Size = new System.Drawing.SizeF(120F, 89F);
            this.GridView1.TabIndex = 7;
            // 
            // lblRBNO
            // 
            this.lblRBNO.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.lblRBNO.BorderColor = System.Drawing.Color.Silver;
            this.lblRBNO.FontSize = 7F;
            this.lblRBNO.Location = new Smobiler.Core.PointS(35F, 0F);
            this.lblRBNO.Name = "lblRBNO";
            this.lblRBNO.Size = new System.Drawing.SizeF(85F, 14F);
            this.lblRBNO.TabIndex = 8;
            // 
            // lblRBCC
            // 
            this.lblRBCC.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.lblRBCC.BorderColor = System.Drawing.Color.Silver;
            this.lblRBCC.FontSize = 7F;
            this.lblRBCC.Location = new Smobiler.Core.PointS(35F, 14F);
            this.lblRBCC.Name = "lblRBCC";
            this.lblRBCC.Size = new System.Drawing.SizeF(85F, 14F);
            this.lblRBCC.TabIndex = 9;
            // 
            // lblRBState
            // 
            this.lblRBState.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblRBState.BorderColor = System.Drawing.Color.DarkTurquoise;
            this.lblRBState.FontSize = 7F;
            this.lblRBState.ForeColor = System.Drawing.Color.White;
            this.lblRBState.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.lblRBState.Location = new Smobiler.Core.PointS(0F, 136F);
            this.lblRBState.Name = "lblRBState";
            this.lblRBState.Size = new System.Drawing.SizeF(120F, 10F);
            this.lblRBState.TabIndex = 10;
            // 
            // tExit
            // 
            this.tExit.IconID = "Exit";
            this.tExit.Name = "tExit";
            this.tExit.Text = "返回";
            // 
            // lblRBUser
            // 
            this.lblRBUser.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.lblRBUser.BorderColor = System.Drawing.Color.Silver;
            this.lblRBUser.FontSize = 7F;
            this.lblRBUser.Location = new Smobiler.Core.PointS(35F, 28F);
            this.lblRBUser.Name = "lblRBUser";
            this.lblRBUser.Size = new System.Drawing.SizeF(85F, 14F);
            this.lblRBUser.TabIndex = 11;
            // 
            // save
            // 
            this.save.IconID = "shenpi";
            this.save.Name = "save";
            this.save.Text = "审批";
            // 
            // txtRB_REASON
            // 
            this.txtRB_REASON.BorderColor = System.Drawing.Color.Silver;
            this.txtRB_REASON.FontSize = 7F;
            this.txtRB_REASON.Location = new Smobiler.Core.PointS(35F, 85F);
            this.txtRB_REASON.Multiline = true;
            this.txtRB_REASON.Name = "txtRB_REASON";
            this.txtRB_REASON.ReadOnly = true;
            this.txtRB_REASON.Size = new System.Drawing.SizeF(85F, 40F);
            this.txtRB_REASON.TabIndex = 12;
            // 
            // Label8
            // 
            this.Label8.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label8.BorderColor = System.Drawing.Color.DarkGray;
            this.Label8.ForeColor = System.Drawing.Color.Gray;
            this.Label8.Name = "Label8";
            this.Label8.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label8.Size = new System.Drawing.SizeF(35F, 14F);
            this.Label8.TabIndex = 13;
            this.Label8.Text = "报销编号";
            // 
            // Label1
            // 
            this.Label1.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label1.BorderColor = System.Drawing.Color.DarkGray;
            this.Label1.ForeColor = System.Drawing.Color.Gray;
            this.Label1.Location = new Smobiler.Core.PointS(0F, 14F);
            this.Label1.Name = "Label1";
            this.Label1.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label1.Size = new System.Drawing.SizeF(35F, 14F);
            this.Label1.TabIndex = 14;
            this.Label1.Text = "成本中心";
            // 
            // Label2
            // 
            this.Label2.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label2.BorderColor = System.Drawing.Color.DarkGray;
            this.Label2.ForeColor = System.Drawing.Color.Gray;
            this.Label2.Location = new Smobiler.Core.PointS(0F, 28F);
            this.Label2.Name = "Label2";
            this.Label2.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label2.Size = new System.Drawing.SizeF(35F, 14F);
            this.Label2.TabIndex = 15;
            this.Label2.Text = "报销用户";
            // 
            // lblnote1
            // 
            this.lblnote1.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.lblnote1.BorderColor = System.Drawing.Color.DarkGray;
            this.lblnote1.ForeColor = System.Drawing.Color.Gray;
            this.lblnote1.Location = new Smobiler.Core.PointS(0F, 45F);
            this.lblnote1.Name = "lblnote1";
            this.lblnote1.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.lblnote1.Size = new System.Drawing.SizeF(35F, 40F);
            this.lblnote1.TabIndex = 16;
            this.lblnote1.Text = "报销备注";
            // 
            // lblRB_REASON1
            // 
            this.lblRB_REASON1.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.lblRB_REASON1.BorderColor = System.Drawing.Color.DarkGray;
            this.lblRB_REASON1.ForeColor = System.Drawing.Color.Gray;
            this.lblRB_REASON1.Location = new Smobiler.Core.PointS(0F, 85F);
            this.lblRB_REASON1.Name = "lblRB_REASON1";
            this.lblRB_REASON1.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.lblRB_REASON1.Size = new System.Drawing.SizeF(35F, 40F);
            this.lblRB_REASON1.TabIndex = 17;
            this.lblRB_REASON1.Text = "拒绝理由";
            // 
            // frmRBDetail1
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblnote,
            this.lblRBAmount,
            this.GridView1,
            this.lblRBNO,
            this.lblRBCC,
            this.lblRBState,
            this.lblRBUser,
            this.txtRB_REASON,
            this.Label8,
            this.Label1,
            this.Label2,
            this.lblnote1,
            this.lblRB_REASON1});
            this.ForeColor = System.Drawing.Color.White;
            this.Size = new System.Drawing.Size(120, 235);
            this.TitleBackColor = System.Drawing.Color.DeepSkyBlue;
            this.TitleImage = "formimg";
            this.TitleText = "报销单详情";
            this.Toolbar.AddRange(new Smobiler.Core.Controls.ToolbarItem[] {
            this.tExit,
            this.save});
            this.Load += new System.EventHandler(this.frmRBDetail1_Load);
            this.ToolbarItemClick += new Smobiler.Core.ToolbarItemClickEventHandler(this.frmRBDetail1_ToolbarItemClick);

        }
        internal Smobiler.Core.Controls.TextBox lblnote;
        internal Smobiler.Core.Controls.Label lblRBAmount;
        internal Smobiler.Core.Controls.GridView GridView1;
        internal Smobiler.Core.Controls.Label lblRBNO;
        internal Smobiler.Core.Controls.Label lblRBCC;
        internal Smobiler.Core.Controls.Label lblRBState;
        internal Smobiler.Core.Controls.ToolbarItem tExit;
        internal Smobiler.Core.Controls.Label lblRBUser;
        internal Smobiler.Core.Controls.ToolbarItem save;
        internal Smobiler.Core.Controls.TextBox txtRB_REASON;
        internal Smobiler.Core.Controls.Label Label8;
        internal Smobiler.Core.Controls.Label Label1;
        internal Smobiler.Core.Controls.Label Label2;
        internal Smobiler.Core.Controls.Label lblnote1;

        internal Smobiler.Core.Controls.Label lblRB_REASON1;
        #endregion

    }
}