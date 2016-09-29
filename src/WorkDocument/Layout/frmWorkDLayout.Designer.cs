using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
namespace COMSSmobilerDemo.WorkDocument.Layout
{
    public partial class frmWorkDLayout : Smobiler.Core.MobileForm
    {

        #region "SmobilerForm Designer generated code "

        public frmWorkDLayout()
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
            this.lblCC = new Smobiler.Core.Controls.Label();
            this.lblState = new Smobiler.Core.Controls.Label();
            this.lblMENDAYV = new Smobiler.Core.Controls.Label();
            this.Line1 = new Smobiler.Core.Controls.Line();
            // 
            // lblNOTE
            // 
            this.lblNOTE.DataMember = "WDOC_NOTE";
            this.lblNOTE.DisplayMember = "WDOC_NOTE";
            this.lblNOTE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblNOTE.Name = "lblNOTE";
            this.lblNOTE.Padding = new Smobiler.Core.Padding(2F, 5F, 0F, 0F);
            this.lblNOTE.Size = new System.Drawing.Size(200,24);
            this.lblNOTE.TabIndex = 2;
            this.lblNOTE.Text = "lblNOTE";
            this.lblNOTE.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            this.lblNOTE.ZIndex = 1;
            // 
            // lblCC
            // 
            this.lblCC.DataMember = "CC_NAMEUSER";
            this.lblCC.DisplayMember = "CC_NAMEUSER";
            this.lblCC.FontSize = 10;
            this.lblCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.lblCC.Location = new System.Drawing.Point(0,24);
            this.lblCC.Name = "lblCC";
            this.lblCC.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.lblCC.Size = new System.Drawing.Size(200,16);
            this.lblCC.TabIndex = 3;
            this.lblCC.Text = "lblCC";
            this.lblCC.ZIndex = 3;
            // 
            // lblState
            // 
            this.lblState.DataMember = "WDOC_STATE";
            this.lblState.DisplayMember = "STATEDESC";
            this.lblState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.lblState.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblState.Location = new System.Drawing.Point(200,0);
            this.lblState.Name = "lblState";
            this.lblState.Padding = new Smobiler.Core.Padding(0F, 5F, 2F, 0F);
            this.lblState.Size = new System.Drawing.Size(40,24);
            this.lblState.TabIndex = 4;
            this.lblState.Text = "lblState";
            this.lblState.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            this.lblState.ZIndex = 2;
            // 
            // lblMENDAYV
            // 
            this.lblMENDAYV.DataMember = "WDOCMENDAYVFIELD";
            this.lblMENDAYV.DisplayMember = "WDOCMENDAYVFIELD";
            this.lblMENDAYV.FontSize = 10;
            this.lblMENDAYV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.lblMENDAYV.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblMENDAYV.Location = new System.Drawing.Point(200,24);
            this.lblMENDAYV.Name = "lblMENDAYV";
            this.lblMENDAYV.Padding = new Smobiler.Core.Padding(0F, 0F, 2F, 0F);
            this.lblMENDAYV.Size = new System.Drawing.Size(40,20);
            this.lblMENDAYV.TabIndex = 5;
            this.lblMENDAYV.Text = "lblMENDAYV";
            this.lblMENDAYV.ZIndex = 4;
            // 
            // Line1
            // 
            this.Line1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Line1.Location = new System.Drawing.Point(0,40);
            this.Line1.Name = "Line1";
            this.Line1.Size = new System.Drawing.Size(240,2);
            this.Line1.TabIndex = 6;
            this.Line1.ZIndex = 5;
            // 
            // frmWorkDLayout
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblNOTE,
            this.lblState,
            this.lblCC,
            this.lblMENDAYV,
            this.Line1});
            this.Size = new System.Drawing.Size(240,40);

        }
        internal Smobiler.Core.Controls.Label lblNOTE;
        internal Smobiler.Core.Controls.Label lblCC;
        internal Smobiler.Core.Controls.Label lblState;
        internal Smobiler.Core.Controls.Label lblMENDAYV;
        internal Smobiler.Core.Controls.Line Line1;


        #endregion

    }


}
