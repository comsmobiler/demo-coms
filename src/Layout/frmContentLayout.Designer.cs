using System;
using Smobiler.Core;
namespace COMSSmobilerDemo.Layout
{
    partial class frmContentLayout : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmContentLayout()
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
            this.Image1 = new Smobiler.Core.Controls.Image();
            this.lblUSER_ID = new Smobiler.Core.Controls.Label();
            this.Line1 = new Smobiler.Core.Controls.Line();
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
            this.Image1.TabIndex = 2;
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
            this.lblUSER_ID.Size = new System.Drawing.Size(245, 50);
            this.lblUSER_ID.TabIndex = 3;
            this.lblUSER_ID.ZIndex = 2;
            // 
            // Line1
            // 
            this.Line1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Line1.Location = new System.Drawing.Point(0, 50);
            this.Line1.Name = "Line1";
            this.Line1.Size = new System.Drawing.Size(300, 3);
            this.Line1.TabIndex = 4;
            this.Line1.ZIndex = 5;
            // 
            // frmContentLayout
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Image1,
            this.lblUSER_ID,
            this.Line1});
            this.Size = new System.Drawing.Size(300, 50);
            this.Name = "frmContentLayout";

        }
        #endregion

        internal Smobiler.Core.Controls.Image Image1;
        internal Smobiler.Core.Controls.Label lblUSER_ID;
        internal Smobiler.Core.Controls.Line Line1;
    }
}