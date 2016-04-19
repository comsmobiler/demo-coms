using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
namespace COMSSmobilerDemo.Operational
{
    public partial class frmOperationalRMain : Smobiler.Core.MobileForm
    {

        #region "SmobilerForm Designer generated code "

        public frmOperationalRMain()
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
            this.tExit = new Smobiler.Core.Controls.ToolbarItem();
            this.add = new Smobiler.Core.Controls.ToolbarItem();
            this.GridView1 = new Smobiler.Core.Controls.GridView();
            // 
            // tExit
            // 
            this.tExit.IconID = "Exit";
            this.tExit.Name = "tExit";
            this.tExit.Text = "返回";
            // 
            // add
            // 
            this.add.IconID = "add";
            this.add.Name = "add";
            this.add.Text = "新增";
            // 
            // GridView1
            // 
            this.GridView1.AllowSlip = true;
            this.GridView1.Layout = "frmOperationalLayout";
            this.GridView1.Name = "GridView1";
            this.GridView1.Size = new System.Drawing.SizeF(120F, 200F);
            this.GridView1.TabIndex = 2;
            this.GridView1.CellClick += new Smobiler.Core.Controls.GridViewCellClickEventHandler(this.GridView1_CellClick);
            this.GridView1.UpSlippling += new System.EventHandler(this.GridView1_UpSlippling);
            this.GridView1.DownSlippling += new System.EventHandler(this.GridView1_DownSlippling);
            // 
            // frmOperationalRMain
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.GridView1});
            this.TitleBackColor = System.Drawing.Color.DeepSkyBlue;
            this.TitleText = "运维记录";
            this.Toolbar.AddRange(new Smobiler.Core.Controls.ToolbarItem[] {
            this.tExit,
            this.add});
            this.Load += new System.EventHandler(this.frmOperationalRMain_Load);
            this.ToolbarItemClick += new Smobiler.Core.ToolbarItemClickEventHandler(this.frmOperationalRMain_ToolbarItemClick);

        }
        internal Smobiler.Core.Controls.ToolbarItem tExit;
        internal Smobiler.Core.Controls.ToolbarItem @add;

        internal Smobiler.Core.Controls.GridView GridView1;
        #endregion

    }


}