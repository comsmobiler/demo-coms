using System;
using Smobiler.Core;
namespace COMSSmobilerDemo.Reimbursement.RB.Layout
{
    partial class frmRBFootbarLayout : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmRBFootbarLayout()
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
            this.lblAmount = new Smobiler.Core.Controls.Label();
            this.Checkall = new Smobiler.Core.Controls.CheckBox();
            this.lblCheckall = new Smobiler.Core.Controls.Label();
            this.Label3 = new Smobiler.Core.Controls.Label();
            this.Line1 = new Smobiler.Core.Controls.Line();
            // 
            // lblAmount
            // 
            this.lblAmount.Bold = true;
            this.lblAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.lblAmount.Location = new Smobiler.Core.PointS(64F, 0F);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.lblAmount.Size = new System.Drawing.SizeF(56F, 14F);
            this.lblAmount.TabIndex = 2;
            this.lblAmount.Text = "￥0";
            this.lblAmount.ZIndex = 5;
            // 
            // Checkall
            // 
            this.Checkall.BackColor = System.Drawing.Color.White;
            this.Checkall.Border = new Smobiler.Core.Border(1);
            this.Checkall.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Checkall.Checked = false;
            this.Checkall.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.Checkall.Location = new Smobiler.Core.PointS(4F, 4F);
            this.Checkall.Name = "Checkall";
            this.Checkall.Size = new System.Drawing.SizeF(6F, 6F);
            this.Checkall.TabIndex = 3;
            this.Checkall.UnCheckedBackColor = System.Drawing.Color.White;
            this.Checkall.ZIndex = 2;
            // 
            // lblCheckall
            // 
            this.lblCheckall.FontSize = 4.5F;
            this.lblCheckall.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblCheckall.Location = new Smobiler.Core.PointS(17F, 0F);
            this.lblCheckall.Name = "lblCheckall";
            this.lblCheckall.Size = new System.Drawing.SizeF(13F, 14F);
            this.lblCheckall.TabIndex = 4;
            this.lblCheckall.Text = "全选";
            this.lblCheckall.ZIndex = 3;
            // 
            // Label3
            // 
            this.Label3.Bold = true;
            this.Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Label3.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.Label3.Location = new Smobiler.Core.PointS(30F, 0F);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.SizeF(34F, 14F);
            this.Label3.TabIndex = 5;
            this.Label3.Text = "总计：";
            this.Label3.ZIndex = 4;
            // 
            // Line1
            // 
            this.Line1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Line1.Name = "Line1";
            this.Line1.Size = new System.Drawing.SizeF(120F, 1F);
            this.Line1.TabIndex = 6;
            this.Line1.ZIndex = 1;
            // 
            // frmRBFootbarLayout
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblAmount,
            this.Checkall,
            this.lblCheckall,
            this.Label3,
            this.Line1});
            this.Size = new System.Drawing.Size(120, 14);

        }
        internal Smobiler.Core.Controls.Label lblAmount;
        internal Smobiler.Core.Controls.CheckBox Checkall;
        internal Smobiler.Core.Controls.Label lblCheckall;
        internal Smobiler.Core.Controls.Label Label3;
        internal Smobiler.Core.Controls.Line Line1;
        #endregion
    }
}