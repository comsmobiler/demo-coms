using System;
using Smobiler.Core;
namespace COMSSmobilerDemo.RecipientsItems.Layout
{
    partial class frmRItemsLayout : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmRItemsLayout()
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
            this.lblID = new Smobiler.Core.Controls.Label();
            this.lblITEM_USER = new Smobiler.Core.Controls.Label();
            this.lblITEM_DATE = new Smobiler.Core.Controls.Label();
            this.Line1 = new Smobiler.Core.Controls.Line();
            // 
            // lblID
            // 
            this.lblID.DataMember = "ITEM_NAME";
            this.lblID.DisplayMember = "ITEM_NAME";
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblID.Name = "lblID";
            this.lblID.Padding = new Smobiler.Core.Padding(2F, 5F, 0F, 0F);
            this.lblID.Size = new System.Drawing.SizeF(120F, 12F);
            this.lblID.TabIndex = 2;
            this.lblID.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            this.lblID.ZIndex = 1;
            // 
            // lblITEM_USER
            // 
            this.lblITEM_USER.DataMember = "ITEM_USER";
            this.lblITEM_USER.DisplayMember = "ITEM_USER";
            this.lblITEM_USER.FontSize = 5F;
            this.lblITEM_USER.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.lblITEM_USER.Location = new Smobiler.Core.PointS(0F, 12F);
            this.lblITEM_USER.Name = "lblITEM_USER";
            this.lblITEM_USER.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.lblITEM_USER.Size = new System.Drawing.SizeF(60F, 8F);
            this.lblITEM_USER.TabIndex = 3;
            this.lblITEM_USER.ZIndex = 2;
            // 
            // lblITEM_DATE
            // 
            this.lblITEM_DATE.DataMember = "ITEM_DATE";
            this.lblITEM_DATE.DisplayMember = "ITEM_DATE";
            this.lblITEM_DATE.FontSize = 5F;
            this.lblITEM_DATE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.lblITEM_DATE.Format = "{0:yyyy/MM/dd}";
            this.lblITEM_DATE.Location = new Smobiler.Core.PointS(60F, 12F);
            this.lblITEM_DATE.Name = "lblITEM_DATE";
            this.lblITEM_DATE.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.lblITEM_DATE.Size = new System.Drawing.SizeF(60F, 8F);
            this.lblITEM_DATE.TabIndex = 4;
            this.lblITEM_DATE.ZIndex = 3;
            // 
            // Line1
            // 
            this.Line1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Line1.Location = new Smobiler.Core.PointS(0F, 20F);
            this.Line1.Name = "Line1";
            this.Line1.Size = new System.Drawing.SizeF(120F, 1F);
            this.Line1.TabIndex = 5;
            this.Line1.ZIndex = 4;
            // 
            // frmRItemsLayout
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblID,
            this.lblITEM_USER,
            this.lblITEM_DATE,
            this.Line1});
            this.Size = new System.Drawing.Size(120, 20);
            this.Name = "frmRItemsLayout";

        }
        internal Smobiler.Core.Controls.Label lblID;
        internal Smobiler.Core.Controls.Label lblITEM_USER;
        internal Smobiler.Core.Controls.Label lblITEM_DATE;
        internal Smobiler.Core.Controls.Line Line1;
        #endregion
    }
}