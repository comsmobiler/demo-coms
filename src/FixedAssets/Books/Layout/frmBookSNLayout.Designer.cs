using System;
using Smobiler.Core;
namespace COMSSmobilerDemo.FixedAssets.Books.Layout
{
    partial class frmBookSNLayout : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmBookSNLayout()
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
            this.lblSNID = new Smobiler.Core.Controls.Label();
            this.lblState = new Smobiler.Core.Controls.Label();
            this.Line1 = new Smobiler.Core.Controls.Line();
            // 
            // lblSNID
            // 
            this.lblSNID.DataMember = "BOOKSNID";
            this.lblSNID.DisplayMember = "BOOKSNID";
            this.lblSNID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblSNID.Name = "lblSNID";
            this.lblSNID.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.lblSNID.Size = new System.Drawing.Size(160,28);
            this.lblSNID.TabIndex = 2;
            this.lblSNID.ZIndex = 1;
            // 
            // lblState
            // 
            this.lblState.DataMember = "STATENAME";
            this.lblState.DisplayMember = "STATENAME";
            this.lblState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.lblState.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblState.Location = new System.Drawing.Point(160,0);
            this.lblState.Name = "lblState";
            this.lblState.Padding = new Smobiler.Core.Padding(0F, 0F, 2F, 0F);
            this.lblState.Size = new System.Drawing.Size(40,28);
            this.lblState.TabIndex = 3;
            this.lblState.Text = "Èë¿â";
            this.lblState.ZIndex = 2;
            // 
            // Line1
            // 
            this.Line1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Line1.Location = new System.Drawing.Point(0,28);
            this.Line1.Name = "Line1";
            this.Line1.Size = new System.Drawing.Size(240,2);
            this.Line1.TabIndex = 5;
            this.Line1.ZIndex = 4;
            // 
            // frmBookSNLayout
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblSNID,
            this.lblState,
            this.Line1});
            this.Size = new System.Drawing.Size(240,28);
            this.Name = "frmBookSNLayout";

        }
        internal Smobiler.Core.Controls.Label lblSNID;
        internal Smobiler.Core.Controls.Label lblState;
        internal Smobiler.Core.Controls.Line Line1;
        #endregion
    }
}
