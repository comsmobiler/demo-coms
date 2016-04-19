using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
namespace COMSSmobilerDemo.Leave
{
    public partial class frmLeaveGrid : Smobiler.Core.MobileForm
    {

        #region "SmobilerForm Designer generated code "

        public frmLeaveGrid()
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
            this.btnLME = new Smobiler.Core.Controls.Button();
            this.btnLCHECK = new Smobiler.Core.Controls.Button();
            this.GridView1 = new Smobiler.Core.Controls.GridView();
            this.l_LMe = new Smobiler.Core.Controls.Line();
            this.l_LMeCheck = new Smobiler.Core.Controls.Line();
            this.tExit = new Smobiler.Core.Controls.ToolbarItem();
            this.addnew = new Smobiler.Core.Controls.ToolbarItem();
            this.line3 = new Smobiler.Core.Controls.Line();
            // 
            // btnLME
            // 
            this.btnLME.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLME.Name = "btnLME";
            this.btnLME.Size = new System.Drawing.SizeF(60F, 14F);
            this.btnLME.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btnLME.TabIndex = 2;
            this.btnLME.Text = "我创建的";
            this.btnLME.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnLME_Click);
            // 
            // btnLCHECK
            // 
            this.btnLCHECK.ForeColor = System.Drawing.Color.LightGray;
            this.btnLCHECK.Location = new Smobiler.Core.PointS(60F, 0F);
            this.btnLCHECK.Name = "btnLCHECK";
            this.btnLCHECK.Size = new System.Drawing.SizeF(60F, 14F);
            this.btnLCHECK.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btnLCHECK.TabIndex = 3;
            this.btnLCHECK.Text = "我审批的";
            this.btnLCHECK.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnLCHECK_Click);
            // 
            // GridView1
            // 
            this.GridView1.AllowSlip = true;
            this.GridView1.Layout = "frmLeaveGrid_Layout";
            this.GridView1.Location = new Smobiler.Core.PointS(0F, 15F);
            this.GridView1.Name = "GridView1";
            this.GridView1.Size = new System.Drawing.SizeF(120F, 185F);
            this.GridView1.TabIndex = 4;
            this.GridView1.CellClick += new Smobiler.Core.Controls.GridViewCellClickEventHandler(this.GridView1_CellClick);
            this.GridView1.UpSlippling += new System.EventHandler(this.GridView1_UpSlippling);
            this.GridView1.DownSlippling += new System.EventHandler(this.GridView1_DownSlippling);
            // 
            // l_LMe
            // 
            this.l_LMe.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.l_LMe.LineSize = 0.6F;
            this.l_LMe.Location = new Smobiler.Core.PointS(0F, 14F);
            this.l_LMe.Name = "l_LMe";
            this.l_LMe.Size = new System.Drawing.SizeF(60F, 1F);
            this.l_LMe.TabIndex = 5;
            // 
            // l_LMeCheck
            // 
            this.l_LMeCheck.BackColor = System.Drawing.Color.White;
            this.l_LMeCheck.LineSize = 0.6F;
            this.l_LMeCheck.Location = new Smobiler.Core.PointS(60F, 14F);
            this.l_LMeCheck.Name = "l_LMeCheck";
            this.l_LMeCheck.Size = new System.Drawing.SizeF(60F, 1F);
            this.l_LMeCheck.TabIndex = 6;
            // 
            // tExit
            // 
            this.tExit.IconID = "Exit";
            this.tExit.Name = "tExit";
            this.tExit.Text = "返回";
            // 
            // addnew
            // 
            this.addnew.IconID = "add";
            this.addnew.Name = "addnew";
            this.addnew.Text = "新增";
            // 
            // line3
            // 
            this.line3.BackColor = System.Drawing.Color.Gray;
            this.line3.LineSize = 0.5F;
            this.line3.Location = new Smobiler.Core.PointS(0F, 14.5F);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.SizeF(120F, 1F);
            this.line3.TabIndex = 7;
            // 
            // frmLeaveGrid
            // 
            this.AllowSlip = true;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnLME,
            this.btnLCHECK,
            this.GridView1,
            this.l_LMe,
            this.l_LMeCheck,
            this.line3});
            this.TitleBackColor = System.Drawing.Color.DeepSkyBlue;
            this.TitleText = "请假";
            this.Toolbar.AddRange(new Smobiler.Core.Controls.ToolbarItem[] {
            this.tExit,
            this.addnew});
            this.Load += new System.EventHandler(this.frmLeaveGrid_Load);
            this.ToolbarItemClick += new Smobiler.Core.ToolbarItemClickEventHandler(this.frmLeaveGrid_ToolbarItemClick);
            this.LeftSlipping += new System.EventHandler(this.frmLeaveGrid_LeftSlipping);
            this.RightSlipping += new System.EventHandler(this.frmLeaveGrid_RightSlipping);

        }
        internal Smobiler.Core.Controls.Button btnLME;
        internal Smobiler.Core.Controls.Button btnLCHECK;
        internal Smobiler.Core.Controls.GridView GridView1;
        internal Smobiler.Core.Controls.Line l_LMe;
        internal Smobiler.Core.Controls.Line l_LMeCheck;
        internal Smobiler.Core.Controls.ToolbarItem tExit;
        internal Smobiler.Core.Controls.ToolbarItem addnew;

        internal Smobiler.Core.Controls.Line line3;
        #endregion

    }
}