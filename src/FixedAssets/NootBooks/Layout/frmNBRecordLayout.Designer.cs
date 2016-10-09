using System;
using Smobiler.Core;
namespace COMSSmobilerDemo.FixedAssets.NootBooks.Layout
{
    partial class frmNBRecordLayout : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmNBRecordLayout()
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
            this.lblNBR_ODATE = new Smobiler.Core.Controls.Label();
            this.Line1 = new Smobiler.Core.Controls.Line();
            this.Label1 = new Smobiler.Core.Controls.Label();
            // 
            // lblID
            // 
            this.lblID.DataMember = "ID";
            this.lblID.DisplayMember = "ID";
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblID.Name = "lblID";
            this.lblID.Padding = new Smobiler.Core.Padding(2F, 5F, 0F, 0F);
            this.lblID.Size = new System.Drawing.Size(225,30);
            this.lblID.TabIndex = 2;
            this.lblID.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            this.lblID.ZIndex = 1;
            // 
            // lblState
            // 
            this.lblState.DataMember = "NBR_OTYPENAME";
            this.lblState.DisplayMember = "NBR_OTYPENAME";
            this.lblState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.lblState.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblState.Location = new System.Drawing.Point(225,0);
            this.lblState.Name = "lblState";
            this.lblState.Padding = new Smobiler.Core.Padding(0F, 5F, 2F, 0F);
            this.lblState.Size = new System.Drawing.Size(75,30);
            this.lblState.TabIndex = 3;
            this.lblState.Text = "开始使用";
            this.lblState.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            this.lblState.ZIndex = 2;
            // 
            // lblNBR_ODATE
            // 
            this.lblNBR_ODATE.DataMember = "NBR_ODATE";
            this.lblNBR_ODATE.DisplayMember = "NBR_ODATE";
            this.lblNBR_ODATE.FontSize = 13;
            this.lblNBR_ODATE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.lblNBR_ODATE.Format = "{0:yyyy/MM/dd}";
            this.lblNBR_ODATE.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblNBR_ODATE.Location = new System.Drawing.Point(115,30);
            this.lblNBR_ODATE.Name = "lblNBR_ODATE";
            this.lblNBR_ODATE.Padding = new Smobiler.Core.Padding(0F, 0F, 2F, 0F);
            this.lblNBR_ODATE.Size = new System.Drawing.Size(185,20);
            this.lblNBR_ODATE.TabIndex = 4;
            this.lblNBR_ODATE.ZIndex = 4;
            // 
            // Line1
            // 
            this.Line1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Line1.Location = new System.Drawing.Point(0,50);
            this.Line1.Name = "Line1";
            this.Line1.Size = new System.Drawing.Size(300,3);
            this.Line1.TabIndex = 5;
            this.Line1.ZIndex = 5;
            // 
            // Label1
            // 
            this.Label1.DataMember = "USER";
            this.Label1.DisplayMember = "USER";
            this.Label1.FontSize = 13;
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.Label1.Location = new System.Drawing.Point(0,30);
            this.Label1.Name = "Label1";
            this.Label1.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label1.Size = new System.Drawing.Size(115,20);
            this.Label1.TabIndex = 6;
            this.Label1.ZIndex = 3;
            // 
            // frmNBRecordLayout
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblID,
            this.lblState,
            this.Label1,
            this.lblNBR_ODATE,
            this.Line1});
            this.Size = new System.Drawing.Size(300,50);
            this.Name = "frmNBRecordLayout";

        }
        internal Smobiler.Core.Controls.Label lblID;
        internal Smobiler.Core.Controls.Label lblState;
        internal Smobiler.Core.Controls.Label lblNBR_ODATE;
        internal Smobiler.Core.Controls.Line Line1;
        internal Smobiler.Core.Controls.Label Label1;
        #endregion
    }
}
