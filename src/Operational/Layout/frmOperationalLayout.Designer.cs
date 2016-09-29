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
            this.Line1 = new Smobiler.Core.Controls.Line();
            // 
            // lblOR_NO
            // 
            this.lblOR_NO.DataMember = "OR_NO";
            this.lblOR_NO.DisplayMember = "OR_NO";
            this.lblOR_NO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblOR_NO.Name = "lblOR_NO";
            this.lblOR_NO.Padding = new Smobiler.Core.Padding(2F, 5F, 0F, 0F);
            this.lblOR_NO.Size = new System.Drawing.Size(240,24);
            this.lblOR_NO.TabIndex = 2;
            this.lblOR_NO.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            this.lblOR_NO.ZIndex = 1;
            // 
            // lblOR_FAULTINFO
            // 
            this.lblOR_FAULTINFO.DataMember = "OR_FAULTINFO";
            this.lblOR_FAULTINFO.DisplayMember = "OR_FAULTINFO";
            this.lblOR_FAULTINFO.FontSize = 10;
            this.lblOR_FAULTINFO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.lblOR_FAULTINFO.Location = new System.Drawing.Point(0,40);
            this.lblOR_FAULTINFO.Name = "lblOR_FAULTINFO";
            this.lblOR_FAULTINFO.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.lblOR_FAULTINFO.Size = new System.Drawing.Size(240,16);
            this.lblOR_FAULTINFO.TabIndex = 3;
            this.lblOR_FAULTINFO.Text = "Label2";
            this.lblOR_FAULTINFO.ZIndex = 3;
            // 
            // lblNote
            // 
            this.lblNote.DataMember = "NOTE";
            this.lblNote.DisplayMember = "NOTE";
            this.lblNote.FontSize = 10;
            this.lblNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.lblNote.Location = new System.Drawing.Point(0,24);
            this.lblNote.Name = "lblNote";
            this.lblNote.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.lblNote.Size = new System.Drawing.Size(240,16);
            this.lblNote.TabIndex = 4;
            this.lblNote.ZIndex = 2;
            // 
            // Line1
            // 
            this.Line1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Line1.Location = new System.Drawing.Point(0,56);
            this.Line1.Name = "Line1";
            this.Line1.Size = new System.Drawing.Size(240,2);
            this.Line1.TabIndex = 5;
            this.Line1.ZIndex = 4;
            // 
            // frmOperationalLayout
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblOR_NO,
            this.lblNote,
            this.lblOR_FAULTINFO,
            this.Line1});
            this.Size = new System.Drawing.Size(240,56);

        }
        internal Smobiler.Core.Controls.Label lblOR_NO;
        internal Smobiler.Core.Controls.Label lblOR_FAULTINFO;
        internal Smobiler.Core.Controls.Label lblNote;
        internal Smobiler.Core.Controls.Line Line1;
        #endregion

    }
}
