using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
namespace COMSSmobilerDemo.WorkDocument
{
    public partial class frmWorkDocumentMainRight : Smobiler.Core.MobileForm
    {

        #region "SmobilerForm Designer generated code "

        public frmWorkDocumentMainRight()
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
            this.btnAllWorkD = new Smobiler.Core.Controls.Button();
            this.btntotalDay = new Smobiler.Core.Controls.Button();
            this.GridView1 = new Smobiler.Core.Controls.GridView();
            this.tExit = new Smobiler.Core.Controls.ToolbarItem();
            // 
            // btnAllWorkD
            // 
            this.btnAllWorkD.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAllWorkD.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.btnAllWorkD.BorderColor = System.Drawing.Color.Silver;
            this.btnAllWorkD.FontSize = 7F;
            this.btnAllWorkD.ForeColor = System.Drawing.Color.Gray;
            this.btnAllWorkD.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Left;
            this.btnAllWorkD.HoverBackColor = System.Drawing.Color.LightCyan;
            this.btnAllWorkD.HoverForeColor = System.Drawing.Color.White;
            this.btnAllWorkD.Name = "btnAllWorkD";
            this.btnAllWorkD.Padding = new Smobiler.Core.Padding(4F, 0F, 2F, 0F);
            this.btnAllWorkD.Size = new System.Drawing.SizeF(90F, 14F);
            this.btnAllWorkD.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btnAllWorkD.TabIndex = 3;
            this.btnAllWorkD.Text = "所有工作单";
            this.btnAllWorkD.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btntotalDay_Click);
            // 
            // btntotalDay
            // 
            this.btntotalDay.BackColor = System.Drawing.Color.Gainsboro;
            this.btntotalDay.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.btntotalDay.BorderColor = System.Drawing.Color.Silver;
            this.btntotalDay.FontSize = 7F;
            this.btntotalDay.ForeColor = System.Drawing.Color.Gray;
            this.btntotalDay.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btntotalDay.HoverBackColor = System.Drawing.Color.LightCyan;
            this.btntotalDay.HoverForeColor = System.Drawing.Color.White;
            this.btntotalDay.Location = new Smobiler.Core.PointS(90F, 0F);
            this.btntotalDay.Name = "btntotalDay";
            this.btntotalDay.Padding = new Smobiler.Core.Padding(0F, 0F, 2F, 0F);
            this.btntotalDay.Size = new System.Drawing.SizeF(30F, 14F);
            this.btntotalDay.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btntotalDay.TabIndex = 4;
            this.btntotalDay.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btntotalDay_Click);
            // 
            // GridView1
            // 
            this.GridView1.Layout = "frmWorkDocumentRightLayout";
            this.GridView1.Location = new Smobiler.Core.PointS(0F, 14F);
            this.GridView1.Name = "GridView1";
            this.GridView1.ShowGridLines = false;
            this.GridView1.Size = new System.Drawing.SizeF(120F, 186F);
            this.GridView1.TabIndex = 5;
            this.GridView1.ItemClick += new Smobiler.Core.Controls.GridViewItemClickEventHandler(this.GridView1_ItemClick);
            // 
            // tExit
            // 
            this.tExit.IconID = "Exit";
            this.tExit.Name = "tExit";
            this.tExit.Text = "返回";
            // 
            // frmWorkDocumentMainRight
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnAllWorkD,
            this.btntotalDay,
            this.GridView1});
            this.TitleBackColor = System.Drawing.Color.DeepSkyBlue;
            this.TitleText = "工作单筛选";
            this.Toolbar.AddRange(new Smobiler.Core.Controls.ToolbarItem[] {
            this.tExit});
            this.Load += new System.EventHandler(this.frmWorkDocumentMainRight_Load);
            this.ToolbarItemClick += new Smobiler.Core.ToolbarItemClickEventHandler(this.frmWorkDocumentMainRight_ToolbarItemClick);

        }
        internal Smobiler.Core.Controls.Button btnAllWorkD;
        internal Smobiler.Core.Controls.Button btntotalDay;
        internal Smobiler.Core.Controls.GridView GridView1;

        internal Smobiler.Core.Controls.ToolbarItem tExit;
        #endregion

    }
}