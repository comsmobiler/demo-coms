using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
using Smobiler.Core.Controls;
namespace COMSSmobilerDemo.Reimbursement.CostCenter
{
public partial class frmCostCenter : Smobiler.Core.MobileForm
{

    #region "VTForm Designer generated code "

    public frmCostCenter()
        : base()
    {

        //This call is required by the VTForm Designer.
        InitializeComponent();

        //Add any initialization after the InitializeComponent() call

    }

    //VTForm overrides dispose to clean up the component list.
    protected override void Dispose(bool disposing)
    {
        base.Dispose(disposing);
    }


    //NOTE: The following procedure is required by the VTForm Designer
    //It can be modified using the VTForm Designer.  
    //Do not modify it using the code editor.
    [System.Diagnostics.DebuggerStepThrough()]
    private void InitializeComponent()
    {
            this.GridView1 = new Smobiler.Core.Controls.GridView();
            this.tExit = new Smobiler.Core.Controls.ToolbarItem();
            this.tSearch = new Smobiler.Core.Controls.ToolbarItem();
            this.popList1 = new Smobiler.Core.Controls.PopList();
            // 
            // GridView1
            // 
            this.GridView1.Layout = "frmCCDt";
            this.GridView1.Name = "GridView1";
            this.GridView1.Size = new System.Drawing.SizeF(120F, 200F);
            this.GridView1.TabIndex = 2;
            // 
            // tExit
            // 
            this.tExit.IconID = "Exit";
            this.tExit.Name = "tExit";
            this.tExit.Text = "返回";
            // 
            // tSearch
            // 
            this.tSearch.IconID = "Search";
            this.tSearch.Name = "tSearch";
            this.tSearch.Text = "筛选";
            // 
            // popList1
            // 
            this.popList1.Name = "popList1";
            // 
            // frmCostCenter
            // 
            this.ComponentControls.AddRange(new Smobiler.Core.ComponentBase[] {
            this.popList1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.GridView1});
            this.LeftFormLayout = "frmCCleft";
            this.TitleBackColor = System.Drawing.Color.DeepSkyBlue;
            this.TitleImage = "formimg";
            this.TitleText = "COMS成本中心";
            this.Toolbar.AddRange(new Smobiler.Core.Controls.ToolbarItem[] {
            this.tExit,
            this.tSearch});
            this.Load += new System.EventHandler(this.frmCostCenter_Load);
            this.ToolbarItemClick += new Smobiler.Core.ToolbarItemClickEventHandler(this.frmCostCenter_ToolbarItemClick);

    }
    internal Smobiler.Core.Controls.GridView GridView1;
    internal Smobiler.Core.Controls.ToolbarItem tExit;

    internal Smobiler.Core.Controls.ToolbarItem tSearch;
    #endregion
    private PopList popList1;

}
}