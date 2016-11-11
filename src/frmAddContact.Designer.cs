using System;
using Smobiler.Core;
namespace COMSSmobilerDemo
{
    partial class frmAddContact : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmAddContact()
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
            this.lblGroup = new Smobiler.Core.Controls.Label();
            this.txtGroup = new Smobiler.Core.Controls.TextBox();
            this.GridView1 = new Smobiler.Core.Controls.GridView();
            // 
            // lblGroup
            // 
            this.lblGroup.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.lblGroup.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.lblGroup.Size = new System.Drawing.Size(75, 35);
            this.lblGroup.TabIndex = 2;
            this.lblGroup.Text = "群组名称";
            // 
            // txtGroup
            // 
            this.txtGroup.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.txtGroup.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txtGroup.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.txtGroup.Location = new System.Drawing.Point(75, 0);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Padding = new Smobiler.Core.Padding(0F, 0F, 12F, 0F);
            this.txtGroup.Size = new System.Drawing.Size(225, 35);
            this.txtGroup.TabIndex = 3;
            this.txtGroup.WaterMarkText = "输入群组名称";
            // 
            // GridView1
            // 
            this.GridView1.Layout = "";
            this.GridView1.Location = new System.Drawing.Point(0, 35);
            this.GridView1.Name = "GridView1";
            this.GridView1.ShowGridLines = false;
            this.GridView1.Size = new System.Drawing.Size(300, 429);
            this.GridView1.TabIndex = 4;
            this.GridView1.ItemClick += new Smobiler.Core.Controls.GridViewItemClickEventHandler(this.GridView1_ItemClick);
            // 
            // frmAddContact
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblGroup,
            this.txtGroup,
            this.GridView1});
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("Exit", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(50))))));
            this.Load += new System.EventHandler(this.frmAddContact_Load);
            this.TitleImageClick += new System.EventHandler(this.frmAddContact_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.frmAddContact_KeyDown);
            this.Name = "frmAddContact";

        }
        #endregion

        internal Smobiler.Core.Controls.Label lblGroup;
        internal Smobiler.Core.Controls.TextBox txtGroup;
        internal Smobiler.Core.Controls.GridView GridView1;
    }
}