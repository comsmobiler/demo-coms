using System;
using Smobiler.Core;
namespace COMSSmobilerDemo.Operational.Layout
{
    partial class frmOperationalCULayout : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmOperationalCULayout()
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
            this.lblCUST_ID = new Smobiler.Core.Controls.Label();
            this.lblFinishedQTY = new Smobiler.Core.Controls.Label();
            this.lblTrackedQty = new Smobiler.Core.Controls.Label();
            this.lblTotalQTY = new Smobiler.Core.Controls.Label();
            this.Label3 = new Smobiler.Core.Controls.Label();
            // 
            // lblCUST_ID
            // 
            this.lblCUST_ID.DataMember = "CUST_NAME";
            this.lblCUST_ID.DisplayMember = "CUST_NAME";
            this.lblCUST_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblCUST_ID.Location = new System.Drawing.Point(8,4);
            this.lblCUST_ID.Name = "lblCUST_ID";
            this.lblCUST_ID.Padding = new Smobiler.Core.Padding(2F, 5F, 0F, 0F);
            this.lblCUST_ID.Size = new System.Drawing.Size(224,24);
            this.lblCUST_ID.TabIndex = 2;
            this.lblCUST_ID.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            this.lblCUST_ID.ZIndex = 2;
            // 
            // lblFinishedQTY
            // 
            this.lblFinishedQTY.DataMember = "FinishedQTYNote";
            this.lblFinishedQTY.DisplayMember = "FinishedQTYNote";
            this.lblFinishedQTY.FontSize = 10;
            this.lblFinishedQTY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.lblFinishedQTY.Location = new System.Drawing.Point(8,28);
            this.lblFinishedQTY.Name = "lblFinishedQTY";
            this.lblFinishedQTY.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.lblFinishedQTY.Size = new System.Drawing.Size(112,16);
            this.lblFinishedQTY.TabIndex = 3;
            this.lblFinishedQTY.Text = "Label2";
            this.lblFinishedQTY.ZIndex = 3;
            // 
            // lblTrackedQty
            // 
            this.lblTrackedQty.DataMember = "TrackedQtyNote";
            this.lblTrackedQty.DisplayMember = "TrackedQtyNote";
            this.lblTrackedQty.FontSize = 10;
            this.lblTrackedQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.lblTrackedQty.Location = new System.Drawing.Point(120,28);
            this.lblTrackedQty.Name = "lblTrackedQty";
            this.lblTrackedQty.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.lblTrackedQty.Size = new System.Drawing.Size(112,16);
            this.lblTrackedQty.TabIndex = 4;
            this.lblTrackedQty.Text = "Label2";
            this.lblTrackedQty.ZIndex = 4;
            // 
            // lblTotalQTY
            // 
            this.lblTotalQTY.Border = new Smobiler.Core.Border(1);
            this.lblTotalQTY.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.lblTotalQTY.BorderRadius = 10;
            this.lblTotalQTY.BorderSize = 1F;
            this.lblTotalQTY.DataMember = "TotalQTY";
            this.lblTotalQTY.DisplayMember = "TotalQTY";
            this.lblTotalQTY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.lblTotalQTY.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.lblTotalQTY.Location = new System.Drawing.Point(190,16);
            this.lblTotalQTY.Name = "lblTotalQTY";
            this.lblTotalQTY.Size = new System.Drawing.Size(20,20);
            this.lblTotalQTY.TabIndex = 5;
            this.lblTotalQTY.Text = "Label2";
            this.lblTotalQTY.ZIndex = 5;
            // 
            // Label3
            // 
            this.Label3.BorderRadius = 2;
            this.Label3.Location = new System.Drawing.Point(4,3);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(232,44);
            this.Label3.TabIndex = 6;
            this.Label3.ZIndex = 1;
            // 
            // frmOperationalCULayout
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label3,
            this.lblCUST_ID,
            this.lblFinishedQTY,
            this.lblTrackedQty,
            this.lblTotalQTY});
            this.Size = new System.Drawing.Size(240,50);
            this.Name = "frmOperationalCULayout";

        }
        internal Smobiler.Core.Controls.Label lblCUST_ID;
        internal Smobiler.Core.Controls.Label lblFinishedQTY;
        internal Smobiler.Core.Controls.Label lblTrackedQty;
        internal Smobiler.Core.Controls.Label lblTotalQTY;
        internal Smobiler.Core.Controls.Label Label3;
        #endregion
    }
}
