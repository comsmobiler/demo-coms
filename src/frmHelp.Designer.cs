using System;
using Smobiler.Core;
namespace COMSSmobilerDemo
{
    partial class frmHelp : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmHelp()
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
            this.WebView1 = new Smobiler.Core.Controls.WebView();
            this.Gps1 = new Smobiler.Core.Controls.GPS();
            // 
            // WebView1
            // 
            this.WebView1.AutoHeight = true;
            this.WebView1.Name = "WebView1";
            this.WebView1.Size = new System.Drawing.SizeF(120F, 200F);
            this.WebView1.TabIndex = 2;
            this.WebView1.Url = "http://www.searching-info.com/coms/ComsSmobiler.html";
            // 
            // Gps1
            // 
            this.Gps1.Name = "Gps1";
            // 
            // frmHelp
            // 
            this.ComponentControls.AddRange(new Smobiler.Core.ComponentBase[] {
            this.Gps1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.WebView1});
            this.LayoutMode = Smobiler.Core.FormLayoutMode.EFFACT3D;
            this.LeftFormLayout = "frmMenuLayout";
            this.StatusBarStyle = Smobiler.Core.StatusBarStyle.Default;
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("menu", System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(97)))), ((int)(((byte)(164))))), System.Drawing.Color.White);
            this.TitleText = "°ïÖú";
            this.LeftLayoutItemClick += new Smobiler.Core.MobileFormLayoutItemClickEventHandler(this.frmHelp_LeftLayoutItemClick);
            this.Load += new System.EventHandler(this.frmHelp_Load);
            this.TitleImageClick += new System.EventHandler(this.frmHelp_TitleImageClick);

        }
        internal Smobiler.Core.Controls.WebView WebView1;
        internal Smobiler.Core.Controls.GPS Gps1;
        #endregion
    }
}