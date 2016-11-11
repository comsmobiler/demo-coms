using System;
using Smobiler.Core;
namespace COMSSmobilerDemo.Operational
{
    partial class frmOperationalRDetail : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmOperationalRDetail()
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
            this.NodeView1 = new Smobiler.Core.Controls.NodeView();
            this.lblQty = new Smobiler.Core.Controls.Label();
            // 
            // NodeView1
            // 
            this.NodeView1.FontSize = 13F;
            this.NodeView1.ItemBackColor = System.Drawing.Color.White;
            this.NodeView1.ItemDefaultIcon = "";
            this.NodeView1.Location = new System.Drawing.Point(0, 35);
            this.NodeView1.Name = "NodeView1";
            this.NodeView1.Size = new System.Drawing.Size(300, 440);
            this.NodeView1.TabIndex = 2;
            this.NodeView1.ItemClicked += new System.EventHandler(this.NodeView1_ItemClicked);
            // 
            // lblQty
            // 
            this.lblQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblQty.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblQty.Name = "lblQty";
            this.lblQty.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.lblQty.Size = new System.Drawing.Size(300, 35);
            this.lblQty.TabIndex = 3;
            this.lblQty.Text = "Label1";
            // 
            // frmOperationalRDetail
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.NodeView1,
            this.lblQty});
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("Exit", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(50))))));
            this.TitleText = "‘ÀŒ¨œÍ«È";
            this.Load += new System.EventHandler(this.frmOperationalRDetail_Load);
            this.TitleImageClick += new System.EventHandler(this.frmOperationalRDetail_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.frmOperationalRDetail_KeyDown);
            this.Name = "frmOperationalRDetail";

        }
        internal Smobiler.Core.Controls.NodeView NodeView1;
        internal Smobiler.Core.Controls.Label lblQty;
        #endregion
    }
}
