using System;
using Smobiler.Core;
namespace COMSSmobilerDemo.FixedAssets.Books.Layout
{
    partial class frmBookLogLayout : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmBookLogLayout()
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
            this.lblState = new Smobiler.Core.Controls.Label();
            this.Label1 = new Smobiler.Core.Controls.Label();
            this.Line1 = new Smobiler.Core.Controls.Line();
            this.Label2 = new Smobiler.Core.Controls.Label();
            // 
            // lblID
            // 
            this.lblID.DataMember = "BOOKLOGID";
            this.lblID.DisplayMember = "BOOKNAME";
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblID.Name = "lblID";
            this.lblID.Padding = new Smobiler.Core.Padding(2F, 5F, 0F, 0F);
            this.lblID.Size = new System.Drawing.Size(200,24);
            this.lblID.TabIndex = 2;
            this.lblID.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            this.lblID.ZIndex = 1;
            // 
            // lblState
            // 
            this.lblState.DataMember = "STATENAME";
            this.lblState.DisplayMember = "STATENAME";
            this.lblState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.lblState.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblState.Location = new System.Drawing.Point(200,0);
            this.lblState.Name = "lblState";
            this.lblState.Padding = new Smobiler.Core.Padding(0F, 5F, 2F, 0F);
            this.lblState.Size = new System.Drawing.Size(40,24);
            this.lblState.TabIndex = 3;
            this.lblState.Text = "½è³ö";
            this.lblState.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            this.lblState.ZIndex = 2;
            // 
            // Label1
            // 
            this.Label1.DataMember = "BOOKSN";
            this.Label1.DisplayMember = "BOOKSN";
            this.Label1.FontSize = 10;
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.Label1.Location = new System.Drawing.Point(0,24);
            this.Label1.Name = "Label1";
            this.Label1.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label1.Size = new System.Drawing.Size(140,16);
            this.Label1.TabIndex = 4;
            this.Label1.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            this.Label1.ZIndex = 3;
            // 
            // Line1
            // 
            this.Line1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Line1.Location = new System.Drawing.Point(0,40);
            this.Line1.Name = "Line1";
            this.Line1.Size = new System.Drawing.Size(240,2);
            this.Line1.TabIndex = 5;
            this.Line1.ZIndex = 5;
            // 
            // Label2
            // 
            this.Label2.DataMember = "BOOKDATE";
            this.Label2.DisplayMember = "BOOKDATE";
            this.Label2.FontSize = 10;
            this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.Label2.Format = "{0:yyyy/MM/dd}";
            this.Label2.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.Label2.Location = new System.Drawing.Point(140,24);
            this.Label2.Name = "Label2";
            this.Label2.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label2.Size = new System.Drawing.Size(100,16);
            this.Label2.TabIndex = 6;
            this.Label2.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            this.Label2.ZIndex = 4;
            // 
            // frmBookLogLayout
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblID,
            this.lblState,
            this.Label1,
            this.Label2,
            this.Line1});
            this.Size = new System.Drawing.Size(240,40);
            this.Name = "frmBookLogLayout";

        }
        internal Smobiler.Core.Controls.Label lblID;
        internal Smobiler.Core.Controls.Label lblState;
        internal Smobiler.Core.Controls.Label Label1;
        internal Smobiler.Core.Controls.Line Line1;
        internal Smobiler.Core.Controls.Label Label2;
        #endregion
    }
}
