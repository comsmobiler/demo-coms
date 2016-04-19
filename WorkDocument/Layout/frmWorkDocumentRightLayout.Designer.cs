using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
namespace COMSSmobilerDemo.WorkDocument.Layout
{
    public partial class frmWorkDocumentRightLayout : Smobiler.Core.MobileForm
    {

        #region "SmobilerForm Designer generated code "

        public frmWorkDocumentRightLayout()
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
            this.ImageButton1 = new Smobiler.Core.Controls.ImageButton();
            this.STATE = new Smobiler.Core.Controls.Button();
            this.MENDAYV = new Smobiler.Core.Controls.Button();
            this.Line1 = new Smobiler.Core.Controls.Line();
            // 
            // ImageButton1
            // 
            this.ImageButton1.DataMember = "STATENAME";
            this.ImageButton1.DisplayMember = "STATENAME";
            this.ImageButton1.FontSize = 4F;
            this.ImageButton1.Name = "ImageButton1";
            this.ImageButton1.Size = new System.Drawing.SizeF(12F, 14F);
            this.ImageButton1.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.ImageButton1.TabIndex = 2;
            // 
            // STATE
            // 
            this.STATE.BorderColor = System.Drawing.Color.Silver;
            this.STATE.DataMember = "WDOC_STATE";
            this.STATE.DisplayMember = "WDOC_STATE";
            this.STATE.ForeColor = System.Drawing.Color.Silver;
            this.STATE.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Left;
            this.STATE.HoverBackColor = System.Drawing.Color.LightCyan;
            this.STATE.HoverForeColor = System.Drawing.Color.White;
            this.STATE.Location = new Smobiler.Core.PointS(12F, 0F);
            this.STATE.Name = "STATE";
            this.STATE.Padding = new Smobiler.Core.Padding(3F, 0F, 2F, 0F);
            this.STATE.Size = new System.Drawing.SizeF(78F, 14F);
            this.STATE.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.STATE.TabIndex = 3;
            // 
            // MENDAYV
            // 
            this.MENDAYV.BorderColor = System.Drawing.Color.Silver;
            this.MENDAYV.DataMember = "MENDAYVFIELD";
            this.MENDAYV.DisplayMember = "MENDAYVFIELD";
            this.MENDAYV.FontSize = 7F;
            this.MENDAYV.ForeColor = System.Drawing.Color.Gray;
            this.MENDAYV.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.MENDAYV.HoverBackColor = System.Drawing.Color.LightCyan;
            this.MENDAYV.HoverForeColor = System.Drawing.Color.White;
            this.MENDAYV.Location = new Smobiler.Core.PointS(90F, 0F);
            this.MENDAYV.Name = "MENDAYV";
            this.MENDAYV.Padding = new Smobiler.Core.Padding(0F, 0F, 2F, 0F);
            this.MENDAYV.Size = new System.Drawing.SizeF(30F, 14F);
            this.MENDAYV.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.MENDAYV.TabIndex = 4;
            // 
            // Line1
            // 
            this.Line1.BackColor = System.Drawing.Color.Silver;
            this.Line1.Location = new Smobiler.Core.PointS(0F, 14F);
            this.Line1.Name = "Line1";
            this.Line1.Size = new System.Drawing.SizeF(120F, 1F);
            this.Line1.TabIndex = 5;
            // 
            // frmWorkDocumentRightLayout
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.ImageButton1,
            this.STATE,
            this.MENDAYV,
            this.Line1});
            this.Size = new System.Drawing.Size(120, 14);

        }
        internal Smobiler.Core.Controls.ImageButton ImageButton1;
        internal Smobiler.Core.Controls.Button STATE;
        internal Smobiler.Core.Controls.Button MENDAYV;

        internal Smobiler.Core.Controls.Line Line1;
        #endregion

    }
}