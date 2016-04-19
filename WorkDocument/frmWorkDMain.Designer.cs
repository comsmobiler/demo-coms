using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
namespace COMSSmobilerDemo.WorkDocument
{
    public partial class frmWorkDMain : Smobiler.Core.MobileForm
    {

        #region "SmobilerForm Designer generated code "

        public frmWorkDMain()
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
            this.btnWorkDCreate = new Smobiler.Core.Controls.Button();
            this.btnWorkDCheck = new Smobiler.Core.Controls.Button();
            this.GridView1 = new Smobiler.Core.Controls.GridView();
            this.Line1 = new Smobiler.Core.Controls.Line();
            this.add = new Smobiler.Core.Controls.ToolbarItem();
            this.l_WorkR = new Smobiler.Core.Controls.Line();
            this.l_WorkD = new Smobiler.Core.Controls.Line();
            this.tExit = new Smobiler.Core.Controls.ToolbarItem();
            this.add1 = new Smobiler.Core.Controls.ToolbarItem();
            // 
            // btnWorkDCreate
            // 
            this.btnWorkDCreate.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnWorkDCreate.Name = "btnWorkDCreate";
            this.btnWorkDCreate.Size = new System.Drawing.SizeF(60F, 12F);
            this.btnWorkDCreate.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btnWorkDCreate.TabIndex = 7;
            this.btnWorkDCreate.Text = "我创建的";
            this.btnWorkDCreate.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnWorkDCreate_Click);
            // 
            // btnWorkDCheck
            // 
            this.btnWorkDCheck.ForeColor = System.Drawing.Color.Gray;
            this.btnWorkDCheck.Location = new Smobiler.Core.PointS(60F, 0F);
            this.btnWorkDCheck.Name = "btnWorkDCheck";
            this.btnWorkDCheck.Size = new System.Drawing.SizeF(60F, 12F);
            this.btnWorkDCheck.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btnWorkDCheck.TabIndex = 8;
            this.btnWorkDCheck.Text = "我审批的";
            this.btnWorkDCheck.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnWorkDCheck_Click);
            // 
            // GridView1
            // 
            this.GridView1.AllowSlip = true;
            this.GridView1.Layout = "frmWorkDLayout";
            this.GridView1.Location = new Smobiler.Core.PointS(0F, 13F);
            this.GridView1.Name = "GridView1";
            this.GridView1.Size = new System.Drawing.SizeF(120F, 184F);
            this.GridView1.TabIndex = 9;
            this.GridView1.CellClick += new Smobiler.Core.Controls.GridViewCellClickEventHandler(this.GridView1_CellClick);
            this.GridView1.UpSlippling += new System.EventHandler(this.GridView1_UpSlippling);
            this.GridView1.DownSlippling += new System.EventHandler(this.GridView1_DownSlippling);
            // 
            // Line1
            // 
            this.Line1.BackColor = System.Drawing.Color.Gray;
            this.Line1.LineSize = 0.5F;
            this.Line1.Location = new Smobiler.Core.PointS(0F, 12.5F);
            this.Line1.Name = "Line1";
            this.Line1.Size = new System.Drawing.SizeF(120F, 1F);
            this.Line1.TabIndex = 10;
            // 
            // add
            // 
            this.add.IconID = "add";
            this.add.Name = "add";
            this.add.Text = "新增";
            // 
            // l_WorkR
            // 
            this.l_WorkR.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.l_WorkR.LineSize = 0.6F;
            this.l_WorkR.Location = new Smobiler.Core.PointS(0F, 12F);
            this.l_WorkR.Name = "l_WorkR";
            this.l_WorkR.Size = new System.Drawing.SizeF(60F, 1F);
            this.l_WorkR.TabIndex = 11;
            // 
            // l_WorkD
            // 
            this.l_WorkD.BackColor = System.Drawing.Color.White;
            this.l_WorkD.LineSize = 0.6F;
            this.l_WorkD.Location = new Smobiler.Core.PointS(60F, 12F);
            this.l_WorkD.Name = "l_WorkD";
            this.l_WorkD.Size = new System.Drawing.SizeF(60F, 1F);
            this.l_WorkD.TabIndex = 12;
            // 
            // tExit
            // 
            this.tExit.IconID = "Exit";
            this.tExit.Name = "tExit";
            this.tExit.Text = "返回";
            // 
            // add1
            // 
            this.add1.IconID = "add";
            this.add1.Name = "add1";
            this.add1.Text = "日志转工单";
            this.add1.Visible = false;
            // 
            // frmWorkDMain
            // 
            this.AllowSlip = true;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnWorkDCreate,
            this.btnWorkDCheck,
            this.GridView1,
            this.Line1,
            this.l_WorkR,
            this.l_WorkD});
            this.TitleBackColor = System.Drawing.Color.DeepSkyBlue;
            this.TitleImage = "iconfont-filter1";
            this.TitleText = "工作单";
            this.Toolbar.AddRange(new Smobiler.Core.Controls.ToolbarItem[] {
            this.tExit,
            this.add,
            this.add1});
            this.Load += new System.EventHandler(this.frmWorkDocumentMain_Load);
            this.ToolbarItemClick += new Smobiler.Core.ToolbarItemClickEventHandler(this.frmWorkDocumentMain_ToolbarItemClick);
            this.LeftSlipping += new System.EventHandler(this.frmWorkDocumentMain_LeftSlipping);
            this.RightSlipping += new System.EventHandler(this.frmWorkDocumentMain_RightSlipping);
            this.TitleImageClick += new System.EventHandler(this.frmWorkDMain_TitleImageClick);

        }
        internal Smobiler.Core.Controls.Button btnWorkDCreate;
        internal Smobiler.Core.Controls.Button btnWorkDCheck;
        internal Smobiler.Core.Controls.GridView GridView1;
        internal Smobiler.Core.Controls.Line Line1;
        internal Smobiler.Core.Controls.ToolbarItem @add;
        internal Smobiler.Core.Controls.Line l_WorkR;
        internal Smobiler.Core.Controls.Line l_WorkD;
        internal Smobiler.Core.Controls.ToolbarItem tExit;

        internal Smobiler.Core.Controls.ToolbarItem add1;
        #endregion

    }
}