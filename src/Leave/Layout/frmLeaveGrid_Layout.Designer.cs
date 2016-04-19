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
            this.lbldate = new Smobiler.Core.Controls.Label();
            this.lblNo = new Smobiler.Core.Controls.Label();
            this.lblnote = new Smobiler.Core.Controls.Label();
            this.imgType = new Smobiler.Core.Controls.ImageButton();
            this.lblState = new Smobiler.Core.Controls.Label();
            // 
            // lblLDay
            // 
            this.lblLDay.DataMember = "L_LEAVEDAY";
            this.lblLDay.DisplayMember = "L_LEAVEDAY";
            this.lblLDay.FontSize = 7F;
            this.lblLDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblLDay.Location = new Smobiler.Core.PointS(14F, 0F);
            this.lblLDay.Name = "lblLDay";
            this.lblLDay.Size = new System.Drawing.SizeF(20F, 12F);
            this.lblLDay.TabIndex = 4;
            // 
            // lbldate
            // 
            this.lbldate.DataMember = "LUSERDATE";
            this.lbldate.DisplayMember = "LUSERDATE";
            this.lbldate.FontSize = 5F;
            this.lbldate.ForeColor = System.Drawing.Color.LightGray;
            this.lbldate.Location = new Smobiler.Core.PointS(14F, 12F);
            this.lbldate.Name = "lbldate";
            this.lbldate.Padding = new Smobiler.Core.Padding(0F, 2F, 0F, 0F);
            this.lbldate.Size = new System.Drawing.SizeF(66F, 8F);
            this.lbldate.TabIndex = 5;
            // 
            // lblNo
            // 
            this.lblNo.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.lblNo.Location = new Smobiler.Core.PointS(34F, 0F);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.SizeF(20F, 12F);
            this.lblNo.TabIndex = 6;
            this.lblNo.Text = "事由：";
            // 
            // lblnote
            // 
            this.lblnote.DataMember = "L_REASON";
            this.lblnote.DisplayMember = "L_REASON";
            this.lblnote.FontSize = 4F;
            this.lblnote.Location = new Smobiler.Core.PointS(54F, 0F);
            this.lblnote.Name = "lblnote";
            this.lblnote.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.lblnote.Size = new System.Drawing.SizeF(66F, 12F);
            this.lblnote.TabIndex = 7;
            // 
            // imgType
            // 
            this.imgType.DataMember = "L_TYPEDESC";
            this.imgType.DisplayMember = "L_TYPEDESC";
            this.imgType.FontSize = 4F;
            this.imgType.Location = new Smobiler.Core.PointS(0F, 2F);
            this.imgType.Name = "imgType";
            this.imgType.Size = new System.Drawing.SizeF(14F, 14F);
            this.imgType.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.imgType.TabIndex = 8;
            this.imgType.TextMember = "L_TYPEDESC";
            // 
            // lblState
            // 
            this.lblState.DataMember = "L_STATE";
            this.lblState.DisplayMember = "L_STATE_FORMAT";
            this.lblState.FontSize = 5F;
            this.lblState.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblState.Location = new Smobiler.Core.PointS(80F, 12F);
            this.lblState.Name = "lblState";
            this.lblState.Padding = new Smobiler.Core.Padding(2F, 2F, 0F, 0F);
            this.lblState.Size = new System.Drawing.SizeF(40F, 8F);
            this.lblState.TabIndex = 9;
            // 
            // frmLeaveGrid_Layout
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblLDay,
            this.lbldate,
            this.lblNo,
            this.lblnote,
            this.imgType,
            this.lblState});
            this.Size = new System.Drawing.Size(120, 20);

        }
        internal Smobiler.Core.Controls.Label lblLDay;
        internal Smobiler.Core.Controls.Label lbldate;
        internal Smobiler.Core.Controls.Label lblNo;
        internal Smobiler.Core.Controls.Label lblnote;
        internal Smobiler.Core.Controls.ImageButton imgType;

        internal Smobiler.Core.Controls.Label lblState;
        #endregion

    }
}