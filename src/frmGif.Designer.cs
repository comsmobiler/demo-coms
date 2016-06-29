using System;
using Smobiler.Core;
namespace COMSSmobilerDemo
{
    partial class frmGif : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmGif()
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
            this.GifView1 = new Smobiler.Core.Controls.GifView();
            // 
            // GifView1
            // 
            this.GifView1.AutoRepeat = true;
            this.GifView1.Name = "GifView1";
            this.GifView1.ResourceID = "welG";
            this.GifView1.Size = new System.Drawing.SizeF(120F, 180F);
            this.GifView1.TabIndex = 2;
            // 
            // frmGif
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.GifView1});
            this.FooterBarLayout = "frmGifLayoutvb";
            this.Size = new System.Drawing.Size(120, 180);
            this.FooterBarLayoutItemClick += new Smobiler.Core.MobileFormLayoutItemClickEventHandler(this.frmGif_FooterBarLayoutItemClick);

        }
        #endregion

        internal Smobiler.Core.Controls.GifView GifView1;
    }
}