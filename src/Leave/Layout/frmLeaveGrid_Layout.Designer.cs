using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
namespace COMSSmobilerDemo.Leave.Layout
{
    public partial class frmLeaveGrid_Layout : Smobiler.Core.MobileForm
    {

        #region "SmobilerForm Designer generated code "

        public frmLeaveGrid_Layout()
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
            this.lblLDay = new Smobiler.Core.Controls.Label();
            this.lblNo = new Smobiler.Core.Controls.Label();
            this.imgType = new Smobiler.Core.Controls.ImageButton();
            this.lblState = new Smobiler.Core.Controls.Label();
            this.Line1 = new Smobiler.Core.Controls.Line();
            // 
            // lblLDay
            // 
            this.lblLDay.DataMember = "L_LEAVEDAY";
            this.lblLDay.DisplayMember = "L_LEAVEDAY";
            this.lblLDay.FontSize = 7F;
            this.lblLDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblLDay.Location = new Smobiler.Core.PointS(14F, 0F);
            this.lblLDay.Name = "lblLDay";
            this.lblLDay.Padding = new Smobiler.Core.Padding(2F, 5F, 0F, 0F);
            this.lblLDay.Size = new System.Drawing.SizeF(46F, 12F);
            this.lblLDay.TabIndex = 4;
            this.lblLDay.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            this.lblLDay.ZIndex = 2;
            // 
            // lblNo
            // 
            this.lblNo.DataMember = "L_REASON";
            this.lblNo.DisplayMember = "L_REASON";
            this.lblNo.FontSize = 5F;
            this.lblNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.lblNo.Location = new Smobiler.Core.PointS(14F, 12F);
            this.lblNo.Name = "lblNo";
            this.lblNo.Padding = new Smobiler.Core.Padding(2F, 2F, 0F, 0F);
            this.lblNo.Size = new System.Drawing.SizeF(106F, 8F);
            this.lblNo.TabIndex = 5;
            this.lblNo.ZIndex = 4;
            // 
            // imgType
            // 
            this.imgType.DataMember = "L_TYPEDESC";
            this.imgType.DisplayMember = "L_TYPEDESC";
            this.imgType.FontSize = 4F;
            this.imgType.Location = new Smobiler.Core.PointS(0F, 3F);
            this.imgType.Name = "imgType";
            this.imgType.Size = new System.Drawing.SizeF(14F, 14F);
            this.imgType.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.imgType.TabIndex = 8;
            this.imgType.TextMember = "L_TYPEDESC";
            this.imgType.ZIndex = 1;
            // 
            // lblState
            // 
            this.lblState.DataMember = "L_STATE";
            this.lblState.DisplayMember = "L_STATE_FORMAT";
            this.lblState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.lblState.Location = new Smobiler.Core.PointS(60F, 0F);
            this.lblState.Name = "lblState";
            this.lblState.Padding = new Smobiler.Core.Padding(2F, 5F, 0F, 0F);
            this.lblState.Size = new System.Drawing.SizeF(60F, 12F);
            this.lblState.TabIndex = 9;
            this.lblState.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            this.lblState.ZIndex = 5;
            // 
            // Line1
            // 
            this.Line1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Line1.Location = new Smobiler.Core.PointS(0F, 20F);
            this.Line1.Name = "Line1";
            this.Line1.Size = new System.Drawing.SizeF(120F, 1F);
            this.Line1.TabIndex = 10;
            this.Line1.ZIndex = 6;
            // 
            // frmLeaveGrid_Layout
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.imgType,
            this.lblLDay,
            this.lblNo,
            this.lblState,
            this.Line1});
            this.Size = new System.Drawing.Size(120, 20);

        }
        internal Smobiler.Core.Controls.Label lblLDay;
        internal Smobiler.Core.Controls.Label lblNo;
        internal Smobiler.Core.Controls.ImageButton imgType;
        internal Smobiler.Core.Controls.Label lblState;
        internal Smobiler.Core.Controls.Line Line1;
        #endregion

    }
}