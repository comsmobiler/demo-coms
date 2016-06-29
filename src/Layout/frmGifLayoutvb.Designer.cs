using System;
using Smobiler.Core;
namespace COMSSmobilerDemo.Layout
{
    partial class frmGifLayoutvb : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmGifLayoutvb()
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
            this.btnLogon = new Smobiler.Core.Controls.Button();
            // 
            // btnLogon
            // 
            this.btnLogon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(125)))), ((int)(((byte)(214)))));
            this.btnLogon.BorderColor = System.Drawing.Color.White;
            this.btnLogon.FontSize = 7F;
            this.btnLogon.ForeColor = System.Drawing.Color.White;
            this.btnLogon.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(194)))), ((int)(((byte)(240)))));
            this.btnLogon.HoverForeColor = System.Drawing.Color.White;
            this.btnLogon.Name = "btnLogon";
            this.btnLogon.Size = new System.Drawing.SizeF(120F, 16F);
            this.btnLogon.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btnLogon.TabIndex = 2;
            this.btnLogon.Text = "µÇÂ¼";
            // 
            // frmGifLayoutvb
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnLogon});
            this.Size = new System.Drawing.Size(120, 16);

        }
        #endregion

        internal Smobiler.Core.Controls.Button btnLogon;
    }
}