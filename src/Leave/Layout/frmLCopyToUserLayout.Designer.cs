using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
namespace COMSSmobilerDemo.Leave.Layout
{
    public partial class frmLCopyToUserLayout : Smobiler.Core.MobileForm
    {

        #region "SmobilerForm Designer generated code "

        public frmLCopyToUserLayout()
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
            this.lblUSER_ID = new Smobiler.Core.Controls.Label();
            this.Image1 = new Smobiler.Core.Controls.Image();
            this.checkUser = new Smobiler.Core.Controls.CheckBox();
            this.lblUSER_NAME = new Smobiler.Core.Controls.Label();
            //
            //lblUSER_ID
            //
            this.lblUSER_ID.DataMember = "USER_ID";
            this.lblUSER_ID.DisplayMember = "USER_ID";
            this.lblUSER_ID.FontSize = 9f;
            this.lblUSER_ID.Location = new Smobiler.Core.PointS(22f, 0f);
            this.lblUSER_ID.Name = "lblUSER_ID";
            this.lblUSER_ID.Padding = new Smobiler.Core.Padding(2f, 0f, 0f, 0f);
            this.lblUSER_ID.Size = new System.Drawing.SizeF(85f, 12f);
            this.lblUSER_ID.TabIndex = 3;
            this.lblUSER_ID.VerticalAlignment = Smobiler.Core.VerticalAlignment.Bottom;
            //
            //Image1
            //
            this.Image1.Border = new Smobiler.Core.Border(1);
            this.Image1.BorderColor = System.Drawing.Color.Gainsboro;
            this.Image1.BorderRadius = 10;
            this.Image1.DataMember = "USER_ID";
            this.Image1.DisplayMember = "USER_ID";
            this.Image1.Location = new Smobiler.Core.PointS(2f, 1f);
            this.Image1.Name = "Image1";
            this.Image1.Size = new System.Drawing.SizeF(17.5f, 18f);
            this.Image1.TabIndex = 5;
            //
            //checkUser
            //
            this.checkUser.BackColor = System.Drawing.Color.White;
            this.checkUser.Border = new Smobiler.Core.Border(1);
            this.checkUser.BorderColor = System.Drawing.Color.DarkGray;
            this.checkUser.BorderRadius = 4;
            this.checkUser.Checked = false;
            this.checkUser.CheckedBackColor = System.Drawing.Color.White;
            this.checkUser.CheckedColor = System.Drawing.Color.DeepSkyBlue;
            this.checkUser.ForeColor = System.Drawing.Color.White;
            this.checkUser.Location = new Smobiler.Core.PointS(108f, 5f);
            this.checkUser.Name = "checkUser";
            this.checkUser.Size = new System.Drawing.SizeF(10f, 10f);
            this.checkUser.TabIndex = 6;
            this.checkUser.UnCheckedBackColor = System.Drawing.Color.White;
            //
            //lblUSER_NAME
            //
            this.lblUSER_NAME.DataMember = "USER_NAME";
            this.lblUSER_NAME.DisplayMember = "USER_NAME";
            this.lblUSER_NAME.FontSize = 5f;
            this.lblUSER_NAME.ForeColor = System.Drawing.Color.DarkGray;
            this.lblUSER_NAME.Location = new Smobiler.Core.PointS(22f, 12f);
            this.lblUSER_NAME.Name = "lblUSER_NAME";
            this.lblUSER_NAME.Padding = new Smobiler.Core.Padding(2f, 0f, 0f, 0f);
            this.lblUSER_NAME.Size = new System.Drawing.SizeF(85f, 8f);
            this.lblUSER_NAME.TabIndex = 7;
            //
            //frmLCopyToUserLayout
            //
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
			this.lblUSER_ID,
			this.Image1,
			this.checkUser,
			this.lblUSER_NAME
		});
            this.Size = new System.Drawing.Size(120, 20);

        }
        internal Smobiler.Core.Controls.Label lblUSER_ID;
        internal Smobiler.Core.Controls.Image Image1;
        internal Smobiler.Core.Controls.CheckBox checkUser;

        internal Smobiler.Core.Controls.Label lblUSER_NAME;
        #endregion

    }
}