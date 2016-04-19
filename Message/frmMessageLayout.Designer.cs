using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
namespace COMSSmobilerDemo.Message
{
    public partial class frmMessageLayout : Smobiler.Core.MobileForm
    {

        #region "SmobilerForm Designer generated code "

        public frmMessageLayout()
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
            this.lblNOTE = new Smobiler.Core.Controls.Label();
            this.Image1 = new Smobiler.Core.Controls.Image();
            this.lblNOTE1 = new Smobiler.Core.Controls.Label();
            //
            //lblNOTE
            //
            this.lblNOTE.DataMember = "NO";
            this.lblNOTE.DisplayMember = "NOTE";
            this.lblNOTE.FontSize = 7f;
            this.lblNOTE.Location = new Smobiler.Core.PointS(18f, 0f);
            this.lblNOTE.Name = "lblNOTE";
            this.lblNOTE.Size = new System.Drawing.SizeF(102f, 12f);
            this.lblNOTE.TabIndex = 3;
            //
            //Image1
            //
            this.Image1.BorderColor = System.Drawing.Color.Gainsboro;
            this.Image1.BorderRadius = 4;
            this.Image1.DataMember = "STATEDESC";
            this.Image1.DisplayMember = "STATEDESC";
            this.Image1.Location = new Smobiler.Core.PointS(2f, 3f);
            this.Image1.Name = "Image1";
            this.Image1.Size = new System.Drawing.SizeF(14f, 14f);
            this.Image1.TabIndex = 5;
            //
            //lblNOTE1
            //
            this.lblNOTE1.DataMember = "STATE";
            this.lblNOTE1.DisplayMember = "NOTE1";
            this.lblNOTE1.FontSize = 5f;
            this.lblNOTE1.ForeColor = System.Drawing.Color.Gray;
            this.lblNOTE1.Location = new Smobiler.Core.PointS(18f, 12f);
            this.lblNOTE1.Name = "lblNOTE1";
            this.lblNOTE1.Size = new System.Drawing.SizeF(102f, 8f);
            this.lblNOTE1.TabIndex = 6;
            //
            //frmMessageLayout
            //
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
			this.lblNOTE,
			this.Image1,
			this.lblNOTE1
		});
            this.Size = new System.Drawing.Size(120, 20);

        }
        internal Smobiler.Core.Controls.Label lblNOTE;
        internal Smobiler.Core.Controls.Image Image1;

        internal Smobiler.Core.Controls.Label lblNOTE1;
        #endregion

    }


}