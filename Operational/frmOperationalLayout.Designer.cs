using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
namespace COMSSmobilerDemo.Operational
{
    public partial class frmOperationalLayout : Smobiler.Core.MobileForm
    {

        #region "SmobilerForm Designer generated code "

        public frmOperationalLayout()
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
            this.lblOR_NO = new Smobiler.Core.Controls.Label();
            this.lblOR_FAULTINFO = new Smobiler.Core.Controls.Label();
            this.lblNote = new Smobiler.Core.Controls.Label();
            this.Label1 = new Smobiler.Core.Controls.Label();
            //
            //lblOR_NO
            //
            this.lblOR_NO.DataMember = "OR_NO";
            this.lblOR_NO.DisplayMember = "OR_NO";
            this.lblOR_NO.FontSize = 7f;
            this.lblOR_NO.Name = "lblOR_NO";
            this.lblOR_NO.Padding = new Smobiler.Core.Padding(2f, 0f, 0f, 0f);
            this.lblOR_NO.Size = new System.Drawing.SizeF(40f, 12f);
            this.lblOR_NO.TabIndex = 2;
            //
            //lblOR_FAULTINFO
            //
            this.lblOR_FAULTINFO.DataMember = "OR_FAULTINFO";
            this.lblOR_FAULTINFO.DisplayMember = "OR_FAULTINFO";
            this.lblOR_FAULTINFO.FontSize = 5f;
            this.lblOR_FAULTINFO.Location = new Smobiler.Core.PointS(60f, 0f);
            this.lblOR_FAULTINFO.Name = "lblOR_FAULTINFO";
            this.lblOR_FAULTINFO.Size = new System.Drawing.SizeF(60f, 20f);
            this.lblOR_FAULTINFO.TabIndex = 3;
            this.lblOR_FAULTINFO.Text = "Label2";
            //
            //lblNote
            //
            this.lblNote.DataMember = "NOTE";
            this.lblNote.DisplayMember = "NOTE";
            this.lblNote.FontSize = 5f;
            this.lblNote.ForeColor = System.Drawing.Color.LightGray;
            this.lblNote.Location = new Smobiler.Core.PointS(0f, 12f);
            this.lblNote.Name = "lblNote";
            this.lblNote.Padding = new Smobiler.Core.Padding(2f, 0f, 0f, 0f);
            this.lblNote.Size = new System.Drawing.SizeF(60f, 8f);
            this.lblNote.TabIndex = 4;
            //
            //Label1
            //
            this.Label1.FontSize = 5f;
            this.Label1.Location = new Smobiler.Core.PointS(40f, 0f);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.SizeF(20f, 12f);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "故障描述";
            //
            //frmOperationalLayout
            //
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
			this.lblOR_NO,
			this.lblOR_FAULTINFO,
			this.lblNote,
			this.Label1
		});
            this.Size = new System.Drawing.Size(120, 20);

        }
        internal Smobiler.Core.Controls.Label lblOR_NO;
        internal Smobiler.Core.Controls.Label lblOR_FAULTINFO;
        internal Smobiler.Core.Controls.Label lblNote;

        internal Smobiler.Core.Controls.Label Label1;
        #endregion

    }
}