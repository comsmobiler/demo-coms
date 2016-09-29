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
            this.PopList1 = new Smobiler.Core.Controls.PopList();
            // 
            // GridView1
            // 
            this.GridView1.AllowSlip = true;
            this.GridView1.Layout = "frmCCDt";
            this.GridView1.Name = "GridView1";
            this.GridView1.PageSize = 10;
            this.GridView1.ShowGridLines = false;
            this.GridView1.Size = new System.Drawing.Size(240,400);
            this.GridView1.TabIndex = 2;
            this.GridView1.CellClick += new Smobiler.Core.Controls.GridViewCellClickEventHandler(this.GridView1_CellClick);
            // 
            // tExit
            // 
            this.tExit.IconID = "Exit";
            this.tExit.Name = "tExit";
            this.tExit.Text = "返回";
            this.tExit.Visible = false;
            // 
            // tSearch
            // 
            this.tSearch.IconID = "!\\ue88b043146223";
            this.tSearch.Name = "tSearch";
            this.tSearch.SelectIconID = "!\\ue88b255255255";
            this.tSearch.Text = "筛选";
            this.tSearch.Visible = false;
            // 
            // PopList1
            // 
            this.PopList1.Name = "PopList1";
            this.PopList1.Selected += new System.EventHandler(this.HandlerCostCenterPopList);
            // 
            // frmCostCenter
            // 
            this.ComponentControls.AddRange(new Smobiler.Core.ComponentBase[] {
            this.PopList1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.GridView1});
            this.StatusBarStyle = Smobiler.Core.StatusBarStyle.Default;
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("Exit", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(50))))));
            this.TitleText = "成本中心选择";
            this.Toolbar.AddRange(new Smobiler.Core.Controls.ToolbarItem[] {
            this.tExit,
            this.tSearch});
            this.ToolbarStyle = new Smobiler.Core.ToolBarSytle(Smobiler.Core.ToolbarSelectStyle.None, System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))), System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))), System.Drawing.Color.White);
            this.FooterBarDialogLayoutItemClick += new Smobiler.Core.MobileFormLayoutItemClickEventHandler(this.frmCostCenter_FooterBarDialogLayoutItemClick);
            this.Load += new System.EventHandler(this.frmCostCenter_Load);
            this.ToolbarItemClick += new Smobiler.Core.ToolbarItemClickEventHandler(this.frmCostCenter_ToolbarItemClick);
            this.TitleImageClick += new System.EventHandler(this.MobileForm_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.MobileForm_KeyDown);
            this.Name = "frmCostCenter";

    }
    internal Smobiler.Core.Controls.GridView GridView1;
    internal Smobiler.Core.Controls.ToolbarItem tExit;
    internal Smobiler.Core.Controls.ToolbarItem tSearch;
    internal Smobiler.Core.Controls.PopList PopList1;
    #endregion
   

}
}
