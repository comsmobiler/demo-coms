using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
namespace COMSSmobilerDemo.Reimbursement.CostCenter
{
    public partial class frmAttentionCC : Smobiler.Core.MobileForm
    {

        #region "SmobilerForm Designer generated code "

        public frmAttentionCC()
            : base()
        {

            //This call is required by the SmobilerForm Designer.
            InitializeComponent();

            //Add any initialization after the InitializeComponent() call

        }

        //VTForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm Designer
        //It can be modified using the SmobilerForm Designer.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.GridView1 = new Smobiler.Core.Controls.GridView();
            this.save = new Smobiler.Core.Controls.ToolbarItem();
            this.Line6 = new Smobiler.Core.Controls.Line();
            // 
            // GridView1
            // 
            this.GridView1.Layout = "frmAttentionCCDt";
            this.GridView1.Location = new Smobiler.Core.PointS(0F, 1F);
            this.GridView1.Name = "GridView1";
            this.GridView1.Size = new System.Drawing.SizeF(120F, 199F);
            this.GridView1.TabIndex = 3;
            this.GridView1.ItemClick += new Smobiler.Core.Controls.GridViewItemClickEventHandler(this.GridView1_ItemClick);
            // 
            // save
            // 
            this.save.IconID = "save";
            this.save.Name = "save";
            this.save.Text = "保存";
            // 
            // Line6
            // 
            this.Line6.BackColor = System.Drawing.Color.Gray;
            this.Line6.LineSize = 0.5F;
            this.Line6.Name = "Line6";
            this.Line6.Size = new System.Drawing.SizeF(120F, 1F);
            this.Line6.TabIndex = 5;
            // 
            // frmAttentionCC
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.GridView1,
            this.Line6});
            this.LeftFormLayout = "frmMainLeftLayout";
            this.TitleBackColor = System.Drawing.Color.DeepSkyBlue;
            this.TitleImage = "iconfont-menu";
            this.TitleText = " 关注成本中心";
            this.Toolbar.AddRange(new Smobiler.Core.Controls.ToolbarItem[] {
            this.save});
            this.LeftLayoutItemClick += new Smobiler.Core.MobileFormLayoutItemClickEventHandler(this.frmAttentionCC_LeftLayoutItemClick);
            this.Load += new System.EventHandler(this.frmAttentionCC_Load);
            this.ToolbarItemClick += new Smobiler.Core.ToolbarItemClickEventHandler(this.frmAttentionCC_ToolbarItemClick);
            this.TitleImageClick += new System.EventHandler(this.frmAttentionCC_TitleImageClick);

        }
        internal Smobiler.Core.Controls.GridView GridView1;
        internal Smobiler.Core.Controls.ToolbarItem save;
        internal Smobiler.Core.Controls.Line Line6;
        #endregion

    }
}