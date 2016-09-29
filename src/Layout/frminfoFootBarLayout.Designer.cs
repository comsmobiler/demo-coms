using System;
using Smobiler.Core;
namespace COMSSmobilerDemo.Layout
{
    partial class frminfoFootBarLayout : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frminfoFootBarLayout()
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
            this.btnEdit = new Smobiler.Core.Controls.Button();
            this.Line1 = new Smobiler.Core.Controls.Line();
            // 
            // btnEdit
            // 
            this.btnEdit.BorderRadius = 5;
            this.btnEdit.FontSize = 16;
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnEdit.HoverBackColor = System.Drawing.Color.White;
            this.btnEdit.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(240,28);
            this.btnEdit.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "±à¼­×ÊÁÏ";
            this.btnEdit.ZIndex = 2;
            this.btnEdit.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnSave_Click);
            // 
            // Line1
            // 
            this.Line1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Line1.Name = "Line1";
            this.Line1.Size = new System.Drawing.Size(240,2);
            this.Line1.TabIndex = 3;
            this.Line1.ZIndex = 1;
            // 
            // frminfoFootBarLayout
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnEdit,
            this.Line1});
            this.Size = new System.Drawing.Size(240,28);

        }
        #endregion

        internal Smobiler.Core.Controls.Button btnEdit;
        internal Smobiler.Core.Controls.Line Line1;
    }
}
