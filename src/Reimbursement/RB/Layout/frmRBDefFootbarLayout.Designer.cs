using System;
using Smobiler.Core;
namespace COMSSmobilerDemo.Reimbursement.RB.Layout
{
    partial class frmRBDefFootbarLayout : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmRBDefFootbarLayout()
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
            this.Label3 = new Smobiler.Core.Controls.Label();
            this.lblAmount = new Smobiler.Core.Controls.Label();
            // 
            // Line1
            // 
            this.Line1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Line1.Name = "Line1";
            this.Line1.Size = new System.Drawing.Size(240,2);
            this.Line1.TabIndex = 2;
            this.Line1.ZIndex = 1;
            // 
            // Label3
            // 
            this.Label3.Bold = true;
            this.Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Label3.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.Label3.Name = "Label3";
            this.Label3.Padding = new Smobiler.Core.Padding(0F, 0F, 2F, 0F);
            this.Label3.Size = new System.Drawing.Size(32,28);
            this.Label3.TabIndex = 3;
            this.Label3.Text = "×Ü¼Æ£º";
            this.Label3.ZIndex = 2;
            // 
            // lblAmount
            // 
            this.lblAmount.Bold = true;
            this.lblAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.lblAmount.Location = new System.Drawing.Point(32,0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.lblAmount.Size = new System.Drawing.Size(208,28);
            this.lblAmount.TabIndex = 4;
            this.lblAmount.Text = "£¤0";
            this.lblAmount.ZIndex = 3;
            // 
            // frmRBDefFootbarLayout
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Line1,
            this.Label3,
            this.lblAmount});
            this.Size = new System.Drawing.Size(240,28);

        }
        internal Smobiler.Core.Controls.Line Line1;
        internal Smobiler.Core.Controls.Label Label3;
        internal Smobiler.Core.Controls.Label lblAmount;
        #endregion
    }
}
