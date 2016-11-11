using System;
using Smobiler.Core;
namespace COMSSmobilerDemo.Layout
{
    partial class frmGroupLayout : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmGroupLayout()
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
            this.lblGroupID = new Smobiler.Core.Controls.Label();
            this.Line1 = new Smobiler.Core.Controls.Line();
            // 
            // lblGroupID
            // 
            this.lblGroupID.DataMember = "G_ID";
            this.lblGroupID.DisplayMember = "G_NAME";
            this.lblGroupID.FontSize = 17F;
            this.lblGroupID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblGroupID.Name = "lblGroupID";
            this.lblGroupID.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.lblGroupID.Size = new System.Drawing.Size(300, 50);
            this.lblGroupID.TabIndex = 2;
            this.lblGroupID.ZIndex = 2;
            // 
            // Line1
            // 
            this.Line1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Line1.Location = new System.Drawing.Point(0, 50);
            this.Line1.Name = "Line1";
            this.Line1.Size = new System.Drawing.Size(300, 1);
            this.Line1.TabIndex = 3;
            this.Line1.ZIndex = 5;
            // 
            // frmGroupLayout
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblGroupID,
            this.Line1});
            this.Size = new System.Drawing.Size(300, 50);
            this.Name = "frmGroupLayout";

        }
        #endregion

        internal Smobiler.Core.Controls.Label lblGroupID;
        internal Smobiler.Core.Controls.Line Line1;
    }
}