using System;
using Smobiler.Core;
namespace COMSSmobilerDemo.Reimbursement.RB.Layout
{
    partial class frmRightLayout : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmRightLayout()
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
            this.lblName = new Smobiler.Core.Controls.Label();
            this.lblAmount = new Smobiler.Core.Controls.Label();
            this.Line1 = new Smobiler.Core.Controls.Line();
            // 
            // lblName
            // 
            this.lblName.BorderColor = System.Drawing.Color.Silver;
            this.lblName.DataMember = "NAME";
            this.lblName.DisplayMember = "NAMECOUNT";
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblName.Name = "lblName";
            this.lblName.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.lblName.Size = new System.Drawing.Size(160,28);
            this.lblName.TabIndex = 2;
            this.lblName.ZIndex = 2;
            // 
            // lblAmount
            // 
            this.lblAmount.BorderColor = System.Drawing.Color.Silver;
            this.lblAmount.DataMember = "AMOUNT";
            this.lblAmount.DisplayMember = "AMOUNT";
            this.lblAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblAmount.Location = new System.Drawing.Point(160,0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(80,28);
            this.lblAmount.TabIndex = 3;
            this.lblAmount.Text = "гд12.5";
            this.lblAmount.ZIndex = 3;
            // 
            // Line1
            // 
            this.Line1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Line1.Location = new System.Drawing.Point(2,28);
            this.Line1.Name = "Line1";
            this.Line1.Size = new System.Drawing.Size(240,2);
            this.Line1.TabIndex = 4;
            this.Line1.ZIndex = 4;
            // 
            // frmRightLayout
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblName,
            this.lblAmount,
            this.Line1});
            this.Size = new System.Drawing.Size(240,28);
            this.Name = "frmRightLayout";

        }
        #endregion

        internal Smobiler.Core.Controls.Label lblName;
        internal Smobiler.Core.Controls.Label lblAmount;
        internal Smobiler.Core.Controls.Line Line1;

    }
}
