
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
namespace COMSSmobilerDemo.Reimbursement.RB
{
    public partial class frmRBMain : Smobiler.Core.MobileForm
    {

        #region "SmobilerForm Designer generated code "

        public frmRBMain()
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
            this.btnRBConsumption = new Smobiler.Core.Controls.Button();
            this.btnRB = new Smobiler.Core.Controls.Button();
            this.Line6 = new Smobiler.Core.Controls.Line();
            this.tExit = new Smobiler.Core.Controls.ToolbarItem();
            this.xfadd = new Smobiler.Core.Controls.ToolbarItem();
            this.ImageButton1 = new Smobiler.Core.Controls.ImageButton();
            this.ImageButton2 = new Smobiler.Core.Controls.ImageButton();
            this.Label1 = new Smobiler.Core.Controls.Label();
            this.lbldatetime = new Smobiler.Core.Controls.Label();
            this.GridView1 = new Smobiler.Core.Controls.GridView();
            this.l_RBConsumption = new Smobiler.Core.Controls.Line();
            this.l_RB = new Smobiler.Core.Controls.Line();
            this.ImageButton3 = new Smobiler.Core.Controls.ImageButton();
            this.Label2 = new Smobiler.Core.Controls.Label();
            this.RBadd = new Smobiler.Core.Controls.ToolbarItem();
            // 
            // btnRBConsumption
            // 
            this.btnRBConsumption.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRBConsumption.Location = new Smobiler.Core.PointS(0F, 12F);
            this.btnRBConsumption.Name = "btnRBConsumption";
            this.btnRBConsumption.Size = new System.Drawing.SizeF(60F, 12F);
            this.btnRBConsumption.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btnRBConsumption.TabIndex = 2;
            this.btnRBConsumption.Text = "消费记录";
            this.btnRBConsumption.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnRBConsumption_Click);
            // 
            // btnRB
            // 
            this.btnRB.ForeColor = System.Drawing.Color.Gray;
            this.btnRB.Location = new Smobiler.Core.PointS(60F, 12F);
            this.btnRB.Name = "btnRB";
            this.btnRB.Size = new System.Drawing.SizeF(60F, 12F);
            this.btnRB.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btnRB.TabIndex = 3;
            this.btnRB.Text = "报销单";
            this.btnRB.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnRB_Click);
            // 
            // Line6
            // 
            this.Line6.BackColor = System.Drawing.Color.Gray;
            this.Line6.LineSize = 0.5F;
            this.Line6.Location = new Smobiler.Core.PointS(0F, 24.5F);
            this.Line6.Name = "Line6";
            this.Line6.Size = new System.Drawing.SizeF(120F, 1F);
            this.Line6.TabIndex = 6;
            // 
            // tExit
            // 
            this.tExit.IconID = "Exit";
            this.tExit.Name = "tExit";
            this.tExit.Text = "返回";
            // 
            // xfadd
            // 
            this.xfadd.IconID = "add";
            this.xfadd.Name = "xfadd";
            this.xfadd.Text = "消费记录";
            // 
            // ImageButton1
            // 
            this.ImageButton1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ImageButton1.FontSize = 9F;
            this.ImageButton1.ForeColor = System.Drawing.Color.White;
            this.ImageButton1.HoverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.ImageButton1.Name = "ImageButton1";
            this.ImageButton1.Size = new System.Drawing.SizeF(10F, 12F);
            this.ImageButton1.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.ImageButton1.TabIndex = 8;
            // 
            // ImageButton2
            // 
            this.ImageButton2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ImageButton2.FontSize = 9F;
            this.ImageButton2.ForeColor = System.Drawing.Color.White;
            this.ImageButton2.HoverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.ImageButton2.Location = new Smobiler.Core.PointS(110F, 0F);
            this.ImageButton2.Name = "ImageButton2";
            this.ImageButton2.ResourceID = "iconfont-filter1";
            this.ImageButton2.Size = new System.Drawing.SizeF(10F, 12F);
            this.ImageButton2.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.ImageButton2.TabIndex = 9;
            this.ImageButton2.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.ImageButton2_Click);
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Label1.FontSize = 8F;
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.Label1.Location = new Smobiler.Core.PointS(20F, 0F);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.SizeF(80F, 10F);
            this.Label1.TabIndex = 10;
            // 
            // lbldatetime
            // 
            this.lbldatetime.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lbldatetime.ForeColor = System.Drawing.Color.White;
            this.lbldatetime.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.lbldatetime.Location = new Smobiler.Core.PointS(20F, 0F);
            this.lbldatetime.Name = "lbldatetime";
            this.lbldatetime.Size = new System.Drawing.SizeF(80F, 12F);
            this.lbldatetime.TabIndex = 11;
            // 
            // GridView1
            // 
            this.GridView1.AllowSlip = true;
            this.GridView1.Layout = "frmConsumptionLayout";
            this.GridView1.Location = new Smobiler.Core.PointS(0F, 25F);
            this.GridView1.Name = "GridView1";
            this.GridView1.ShowGridLines = false;
            this.GridView1.Size = new System.Drawing.SizeF(120F, 171F);
            this.GridView1.TabIndex = 15;
            this.GridView1.CellClick += new Smobiler.Core.Controls.GridViewCellClickEventHandler(this.GridView1_CellClick);
            // 
            // l_RBConsumption
            // 
            this.l_RBConsumption.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.l_RBConsumption.LineSize = 0.6F;
            this.l_RBConsumption.Location = new Smobiler.Core.PointS(0F, 24F);
            this.l_RBConsumption.Name = "l_RBConsumption";
            this.l_RBConsumption.Size = new System.Drawing.SizeF(60F, 1F);
            this.l_RBConsumption.TabIndex = 16;
            // 
            // l_RB
            // 
            this.l_RB.BackColor = System.Drawing.Color.White;
            this.l_RB.LineSize = 0.6F;
            this.l_RB.Location = new Smobiler.Core.PointS(60F, 24F);
            this.l_RB.Name = "l_RB";
            this.l_RB.Size = new System.Drawing.SizeF(60F, 1F);
            this.l_RB.TabIndex = 17;
            // 
            // ImageButton3
            // 
            this.ImageButton3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ImageButton3.FontSize = 9F;
            this.ImageButton3.ForeColor = System.Drawing.Color.White;
            this.ImageButton3.HoverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.ImageButton3.Location = new Smobiler.Core.PointS(100F, 0F);
            this.ImageButton3.Name = "ImageButton3";
            this.ImageButton3.ResourceID = "checktx";
            this.ImageButton3.Size = new System.Drawing.SizeF(10F, 12F);
            this.ImageButton3.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.ImageButton3.TabIndex = 18;
            this.ImageButton3.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.ImageButton3_Click);
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new Smobiler.Core.PointS(10F, 0F);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.SizeF(10F, 12F);
            this.Label2.TabIndex = 19;
            // 
            // RBadd
            // 
            this.RBadd.IconID = "add";
            this.RBadd.Name = "RBadd";
            this.RBadd.Text = "报销单";
            // 
            // frmRBMain
            // 
            this.AllowSlip = true;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnRBConsumption,
            this.btnRB,
            this.Line6,
            this.ImageButton1,
            this.ImageButton2,
            this.Label1,
            this.lbldatetime,
            this.GridView1,
            this.l_RBConsumption,
            this.l_RB,
            this.ImageButton3,
            this.Label2});
            this.TitleBackColor = System.Drawing.Color.DeepSkyBlue;
            this.TitleImage = "formimg";
            this.TitleText = "报销";
            this.Toolbar.AddRange(new Smobiler.Core.Controls.ToolbarItem[] {
            this.tExit,
            this.xfadd,
            this.RBadd});
            this.Load += new System.EventHandler(this.frmRBMain_Load);
            this.ToolbarItemClick += new Smobiler.Core.ToolbarItemClickEventHandler(this.frmRBMain_ToolbarItemClick);
            this.LeftSlipping += new System.EventHandler(this.frmRBMain_LeftSlipping);
            this.RightSlipping += new System.EventHandler(this.frmRBMain_RightSlipping);

        }
        internal Smobiler.Core.Controls.Button btnRBConsumption;
        internal Smobiler.Core.Controls.Button btnRB;

        internal Smobiler.Core.Controls.Line Line6;
        internal Smobiler.Core.Controls.ToolbarItem tExit;
        internal Smobiler.Core.Controls.ToolbarItem xfadd;
        internal Smobiler.Core.Controls.ImageButton ImageButton1;
        internal Smobiler.Core.Controls.ImageButton ImageButton2;
        internal Smobiler.Core.Controls.Label Label1;
        internal Smobiler.Core.Controls.Label lbldatetime;
        internal Smobiler.Core.Controls.GridView GridView1;
        internal Smobiler.Core.Controls.Line l_RBConsumption;
        internal Smobiler.Core.Controls.Line l_RB;
        internal Smobiler.Core.Controls.ImageButton ImageButton3;
        internal Smobiler.Core.Controls.Label Label2;

        internal Smobiler.Core.Controls.ToolbarItem RBadd;
        #endregion

    }
}