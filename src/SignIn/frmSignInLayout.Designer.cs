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
            this.Label1 = new Smobiler.Core.Controls.Label();
            this.lblnote = new Smobiler.Core.Controls.TextBox();
            // 
            // lblLDay
            // 
            this.lblLDay.DataMember = "SI_DATE";
            this.lblLDay.DisplayMember = "SI_DATE";
            this.lblLDay.FontSize = 7F;
            this.lblLDay.Name = "lblLDay";
            this.lblLDay.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.lblLDay.Size = new System.Drawing.SizeF(60F, 12F);
            this.lblLDay.TabIndex = 2;
            // 
            // Label1
            // 
            this.Label1.BorderColor = System.Drawing.Color.Gray;
            this.Label1.DataMember = "TYPEDESC";
            this.Label1.DisplayMember = "TYPEDESC";
            this.Label1.FontSize = 5F;
            this.Label1.ForeColor = System.Drawing.Color.Gray;
            this.Label1.Location = new Smobiler.Core.PointS(0F, 12F);
            this.Label1.Name = "Label1";
            this.Label1.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label1.Size = new System.Drawing.SizeF(60F, 8F);
            this.Label1.TabIndex = 3;
            // 
            // lblnote
            // 
            this.lblnote.Border = new Smobiler.Core.Border(0);
            this.lblnote.DataMember = "SI_ADDRESS";
            this.lblnote.DisplayMember = "SI_ADDRESS";
            this.lblnote.FontSize = 5F;
            this.lblnote.Location = new Smobiler.Core.PointS(60F, 0F);
            this.lblnote.Multiline = true;
            this.lblnote.Name = "lblnote";
            this.lblnote.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.lblnote.ReadOnly = true;
            this.lblnote.Size = new System.Drawing.SizeF(60F, 20F);
            this.lblnote.TabIndex = 4;
            // 
            // frmSignInLayout
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblLDay,
            this.Label1,
            this.lblnote});
            this.Size = new System.Drawing.Size(120, 20);

        }
        internal Smobiler.Core.Controls.Label lblLDay;
        internal Smobiler.Core.Controls.Label Label1;

        internal Smobiler.Core.Controls.TextBox lblnote;
        #endregion

    }

}