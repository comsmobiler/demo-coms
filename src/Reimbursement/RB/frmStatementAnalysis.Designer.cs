using System;
using Smobiler.Core;
namespace COMSSmobilerDemo.Reimbursement.RB
{
    partial class frmStatementAnalysis : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmStatementAnalysis()
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
            Smobiler.Core.Controls.TextTabBarItem textTabBarItem3 = new Smobiler.Core.Controls.TextTabBarItem();
            Smobiler.Core.Controls.TextTabBarItem textTabBarItem4 = new Smobiler.Core.Controls.TextTabBarItem();
            this.TextTabBar1 = new Smobiler.Core.Controls.TextTabBar();
            this.GridView1 = new Smobiler.Core.Controls.GridView();
            // 
            // TextTabBar1
            // 
            this.TextTabBar1.BackColor = System.Drawing.Color.White;
            this.TextTabBar1.Border = new Smobiler.Core.Border(1);
            this.TextTabBar1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.TextTabBar1.BorderRadius = 2;
            this.TextTabBar1.BorderSize = 0.2F;
            this.TextTabBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            textTabBarItem3.Text = "趋势";
            textTabBarItem3.Value = "qs";
            textTabBarItem4.Text = "分布";
            textTabBarItem4.Value = "fb";
            this.TextTabBar1.Items.AddRange(new Smobiler.Core.Controls.TextTabBarItem[] {
            textTabBarItem3,
            textTabBarItem4});
            this.TextTabBar1.Location = new Smobiler.Core.PointS(10F, 5F);
            this.TextTabBar1.Name = "TextTabBar1";
            this.TextTabBar1.SelectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.TextTabBar1.SelectForeColor = System.Drawing.Color.White;
            this.TextTabBar1.Size = new System.Drawing.SizeF(100F, 14F);
            this.TextTabBar1.TabIndex = 2;
            this.TextTabBar1.ItemClick += new Smobiler.Core.Controls.TabBarItemClickEventHandler(this.TextTabBar1_ItemClick);
            // 
            // GridView1
            // 
            this.GridView1.Layout = "frmRightLayout";
            this.GridView1.Location = new Smobiler.Core.PointS(0F, 127F);
            this.GridView1.Name = "GridView1";
            this.GridView1.ShowGridLines = false;
            this.GridView1.Size = new System.Drawing.SizeF(120F, 73F);
            this.GridView1.TabIndex = 4;
            this.GridView1.ZIndex = 6;
            // 
            // frmStatementAnalysis
            // 
            this.AllowSlip = true;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.TextTabBar1,
            this.GridView1});
            this.StatusBarStyle = Smobiler.Core.StatusBarStyle.Default;
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("Exit", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(50))))));
            this.TitleText = "报表";
            this.Load += new System.EventHandler(this.frmStatementAnalysis_Load);
            this.LeftSlipping += new System.EventHandler(this.frmStatementAnalysis_LeftSlipping);
            this.RightSlipping += new System.EventHandler(this.frmStatementAnalysis_RightSlipping);
            this.TitleImageClick += new System.EventHandler(this.frmStatementAnalysis_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.frmStatementAnalysis_KeyDown);
            this.Name = "frmStatementAnalysis";

        }
        internal Smobiler.Core.Controls.TextTabBar TextTabBar1;
        internal Smobiler.Core.Controls.GridView GridView1;
        #endregion
    }
}