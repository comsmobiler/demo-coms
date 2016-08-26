using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;

namespace COMSSmobilerDemo.SignIn
{
    public partial class frmSignInLayout : Smobiler.Core.MobileForm
    {

        #region "SmobilerForm Designer generated code "

        public frmSignInLayout()
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
            this.lblLDay = new Smobiler.Core.Controls.Label();
            this.lblnote = new Smobiler.Core.Controls.Label();
            this.Line1 = new Smobiler.Core.Controls.Line();
            this.Label1 = new Smobiler.Core.Controls.Image();
            // 
            // lblLDay
            // 
            this.lblLDay.DataMember = "SI_DATE";
            this.lblLDay.DisplayMember = "SI_DATE";
            this.lblLDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblLDay.Name = "lblLDay";
            this.lblLDay.Padding = new Smobiler.Core.Padding(2F, 5F, 0F, 0F);
            this.lblLDay.Size = new System.Drawing.SizeF(84F, 12F);
            this.lblLDay.TabIndex = 2;
            this.lblLDay.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            this.lblLDay.ZIndex = 1;
            // 
            // lblnote
            // 
            this.lblnote.DataMember = "SI_ADDRESS";
            this.lblnote.DisplayMember = "SI_ADDRESS";
            this.lblnote.FontSize = 5F;
            this.lblnote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.lblnote.Location = new Smobiler.Core.PointS(0F, 12F);
            this.lblnote.Name = "lblnote";
            this.lblnote.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.lblnote.Size = new System.Drawing.SizeF(84F, 8F);
            this.lblnote.TabIndex = 4;
            this.lblnote.ZIndex = 3;
            // 
            // Line1
            // 
            this.Line1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Line1.Location = new Smobiler.Core.PointS(0F, 20F);
            this.Line1.Name = "Line1";
            this.Line1.Size = new System.Drawing.SizeF(120F, 1F);
            this.Line1.TabIndex = 5;
            this.Line1.ZIndex = 4;
            // 
            // Label1
            // 
            this.Label1.BorderColor = System.Drawing.Color.Gray;
            this.Label1.DataMember = "TYPEDESC";
            this.Label1.DisplayMember = "TYPEDESC";
            this.Label1.ID = "";
            this.Label1.Location = new Smobiler.Core.PointS(84F, 0F);
            this.Label1.Name = "Label1";
            this.Label1.Padding = new Smobiler.Core.Padding(0F, 1F, 0F, 1F);
            this.Label1.Size = new System.Drawing.SizeF(36F, 20F);
            this.Label1.TabIndex = 6;
            this.Label1.ZIndex = 2;
            // 
            // frmSignInLayout
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblLDay,
            this.lblnote,
            this.Line1,
            this.Label1});
            this.Size = new System.Drawing.Size(120, 20);
            this.Name = "frmSignInLayout";

        }
        internal Smobiler.Core.Controls.Label lblLDay;
        internal Smobiler.Core.Controls.Label lblnote;
        internal Smobiler.Core.Controls.Line Line1;
        #endregion
        internal Smobiler.Core.Controls.Image Label1;

    }

}