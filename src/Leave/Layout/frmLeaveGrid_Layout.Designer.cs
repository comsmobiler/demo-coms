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
            this.Line1 = new Smobiler.Core.Controls.Line();
            this.lblState = new Smobiler.Core.Controls.Image();
            // 
            // lblLDay
            // 
            this.lblLDay.DataMember = "L_LEAVEDAY";
            this.lblLDay.DisplayMember = "L_LEAVEDAY";
            this.lblLDay.FontSize = 18;
            this.lblLDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblLDay.Location = new System.Drawing.Point(35,0);
            this.lblLDay.Name = "lblLDay";
            this.lblLDay.Padding = new Smobiler.Core.Padding(2F, 5F, 0F, 0F);
            this.lblLDay.Size = new System.Drawing.Size(200,30);
            this.lblLDay.TabIndex = 4;
            this.lblLDay.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            this.lblLDay.ZIndex = 2;
            // 
            // lblNo
            // 
            this.lblNo.DataMember = "L_REASON";
            this.lblNo.DisplayMember = "L_REASON";
            this.lblNo.FontSize = 13;
            this.lblNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.lblNo.Location = new System.Drawing.Point(35,30);
            this.lblNo.Name = "lblNo";
            this.lblNo.Padding = new Smobiler.Core.Padding(2F, 2F, 0F, 0F);
            this.lblNo.Size = new System.Drawing.Size(200,20);
            this.lblNo.TabIndex = 5;
            this.lblNo.ZIndex = 4;
            // 
            // imgType
            // 
            this.imgType.DataMember = "L_TYPE";
            this.imgType.DisplayMember = "L_TYPE";
            this.imgType.FontSize = 10;
            this.imgType.Location = new System.Drawing.Point(0,8);
            this.imgType.Name = "imgType";
            this.imgType.Size = new System.Drawing.Size(35,35);
            this.imgType.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.imgType.TabIndex = 8;
            this.imgType.TextMember = "L_TYPEDESC";
            this.imgType.ZIndex = 1;
            // 
            // Line1
            // 
            this.Line1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Line1.Location = new System.Drawing.Point(0,50);
            this.Line1.Name = "Line1";
            this.Line1.Size = new System.Drawing.Size(300,3);
            this.Line1.TabIndex = 10;
            this.Line1.ZIndex = 6;
            // 
            // lblState
            // 
            this.lblState.DataMember = "L_STATE_FORMAT";
            this.lblState.DisplayMember = "L_STATE_FORMAT";
            this.lblState.ID = "";
            this.lblState.Location = new System.Drawing.Point(233,5);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(40,40);
            this.lblState.TabIndex = 11;
            this.lblState.ZIndex = 5;
            // 
            // frmLeaveGrid_Layout
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.imgType,
            this.lblLDay,
            this.lblNo,
            this.Line1,
            this.lblState});
            this.Size = new System.Drawing.Size(300,50);
            this.Name = "frmLeaveGrid_Layout";

        }
        internal Smobiler.Core.Controls.Label lblLDay;
        internal Smobiler.Core.Controls.Label lblNo;
        internal Smobiler.Core.Controls.ImageButton imgType;
        internal Smobiler.Core.Controls.Line Line1;
        #endregion
        internal Smobiler.Core.Controls.Image lblState;

    }
}
