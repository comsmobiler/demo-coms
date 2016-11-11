using System;
using Smobiler.Core;
namespace COMSSmobilerDemo.Layout
{
    partial class frmJoinGUserLayout : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmJoinGUserLayout()
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
            this.Line1 = new Smobiler.Core.Controls.Line();
            this.Image1 = new Smobiler.Core.Controls.Image();
            this.lblUSER_ID = new Smobiler.Core.Controls.Label();
            this.Check = new Smobiler.Core.Controls.CheckBox();
            // 
            // Line1
            // 
            this.Line1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Line1.Location = new System.Drawing.Point(0, 50);
            this.Line1.Name = "Line1";
            this.Line1.Size = new System.Drawing.Size(300, 1);
            this.Line1.TabIndex = 2;
            this.Line1.ZIndex = 5;
            // 
            // Image1
            // 
            this.Image1.Border = new Smobiler.Core.Border(1);
            this.Image1.BorderColor = System.Drawing.Color.Gainsboro;
            this.Image1.BorderRadius = 10;
            this.Image1.DataMember = "PortraitUri";
            this.Image1.DisplayMember = "PortraitUri";
            this.Image1.ID = "";
            this.Image1.Location = new System.Drawing.Point(5, 3);
            this.Image1.Name = "Image1";
            this.Image1.Size = new System.Drawing.Size(44, 45);
            this.Image1.TabIndex = 3;
            this.Image1.ZIndex = 1;
            // 
            // lblUSER_ID
            // 
            this.lblUSER_ID.DataMember = "UserID";
            this.lblUSER_ID.DisplayMember = "UserID";
            this.lblUSER_ID.FontSize = 17F;
            this.lblUSER_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblUSER_ID.Location = new System.Drawing.Point(55, 0);
            this.lblUSER_ID.Name = "lblUSER_ID";
            this.lblUSER_ID.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.lblUSER_ID.Size = new System.Drawing.Size(213, 50);
            this.lblUSER_ID.TabIndex = 4;
            this.lblUSER_ID.ZIndex = 2;
            // 
            // Check
            // 
            this.Check.Border = new Smobiler.Core.Border(1);
            this.Check.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Check.BorderRadius = 4;
            this.Check.Checked = false;
            this.Check.CheckedBackColor = System.Drawing.Color.White;
            this.Check.CheckedColor = System.Drawing.Color.DeepSkyBlue;
            this.Check.Location = new System.Drawing.Point(270, 13);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(25, 25);
            this.Check.TabIndex = 5;
            this.Check.UnCheckedBackColor = System.Drawing.Color.White;
            this.Check.ZIndex = 4;
            // 
            // frmJoinGUserLayout
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Line1,
            this.Image1,
            this.lblUSER_ID,
            this.Check});
            this.Size = new System.Drawing.Size(300, 50);
            this.Name = "frmJoinGUserLayout";

        }
        #endregion

        internal Smobiler.Core.Controls.Line Line1;
        internal Smobiler.Core.Controls.Image Image1;
        internal Smobiler.Core.Controls.Label lblUSER_ID;
        internal Smobiler.Core.Controls.CheckBox Check;
    }
}