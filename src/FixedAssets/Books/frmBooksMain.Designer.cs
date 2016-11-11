using System;
using Smobiler.Core;
namespace COMSSmobilerDemo.FixedAssets.Books
{
    partial class frmBooksMain : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmBooksMain()
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
            this.GridView1 = new Smobiler.Core.Controls.GridView();
            this.add = new Smobiler.Core.Controls.ToolbarItem();
            // 
            // GridView1
            // 
            this.GridView1.AllowSlip = true;
            this.GridView1.Layout = "frmBooksLayout";
            this.GridView1.Name = "GridView1";
            this.GridView1.ShowGridLines = false;
            this.GridView1.Size = new System.Drawing.Size(300, 500);
            this.GridView1.TabIndex = 2;
            this.GridView1.CellClick += new Smobiler.Core.Controls.GridViewCellClickEventHandler(this.GridView1_CellClick);
            this.GridView1.UpSlippling += new System.EventHandler(this.GridView1_UpSlippling);
            this.GridView1.DownSlippling += new System.EventHandler(this.GridView1_DownSlippling);
            // 
            // add
            // 
            this.add.IconID = "!\\ue148043146223";
            this.add.Name = "add";
            this.add.SelectIconID = "!\\ue148043146223";
            this.add.Text = "»Îø‚";
            // 
            // frmBooksMain
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.GridView1});
            this.StatusBarStyle = Smobiler.Core.StatusBarStyle.Default;
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("Exit", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(50))))));
            this.TitleText = "Õº È";
            this.Toolbar.AddRange(new Smobiler.Core.Controls.ToolbarItem[] {
            this.add});
            this.ToolbarStyle = new Smobiler.Core.ToolBarSytle(Smobiler.Core.ToolbarSelectStyle.None, System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))), System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))));
            this.Load += new System.EventHandler(this.frmBooksMain_Load);
            this.ToolbarItemClick += new Smobiler.Core.ToolbarItemClickEventHandler(this.frmBooksMain_ToolbarItemClick);
            this.TitleImageClick += new System.EventHandler(this.frmBooksMain_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.frmBooksMain_KeyDown);
            this.Name = "frmBooksMain";

        }
        internal Smobiler.Core.Controls.GridView GridView1;
        internal Smobiler.Core.Controls.ToolbarItem @add;

        #endregion
    }
}
