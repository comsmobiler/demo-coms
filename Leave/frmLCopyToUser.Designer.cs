using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
namespace COMSSmobilerDemo.Leave
{
    public partial class frmLCopyToUser : Smobiler.Core.MobileForm
    {

        #region "SmobilerForm Designer generated code "

        public frmLCopyToUser()
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
            this.GridView1 = new Smobiler.Core.Controls.GridView();
            this.tExit = new Smobiler.Core.Controls.ToolbarItem();
            this.CopyTo = new Smobiler.Core.Controls.ToolbarItem();
            // 
            // GridView1
            // 
            this.GridView1.Layout = "frmLCopyToUserLayout";
            this.GridView1.Name = "GridView1";
            this.GridView1.ShowGridLines = false;
            this.GridView1.Size = new System.Drawing.SizeF(120F, 186F);
            this.GridView1.TabIndex = 2;
            // 
            // tExit
            // 
            this.tExit.IconID = "Exit";
            this.tExit.Name = "tExit";
            this.tExit.Text = "返回";
            // 
            // CopyTo
            // 
            this.CopyTo.IconID = "CopyTo";
            this.CopyTo.Name = "CopyTo";
            this.CopyTo.Text = "抄送";
            // 
            // frmLCopyToUser
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.GridView1});
            this.TitleBackColor = System.Drawing.Color.DeepSkyBlue;
            this.TitleImage = "formimg";
            this.TitleText = "抄送人员";
            this.Toolbar.AddRange(new Smobiler.Core.Controls.ToolbarItem[] {
            this.tExit,
            this.CopyTo});
            this.Load += new System.EventHandler(this.frmLCopyToUser_Load);
            this.ToolbarItemClick += new Smobiler.Core.ToolbarItemClickEventHandler(this.frmLCopyToUser_ToolbarItemClick);

        }
        internal Smobiler.Core.Controls.GridView GridView1;
        internal Smobiler.Core.Controls.ToolbarItem tExit;

        internal Smobiler.Core.Controls.ToolbarItem CopyTo;
        #endregion

    }
}