
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
using Smobiler.Core.Controls;
namespace COMSSmobilerDemo.Reimbursement.CostCenter.Layout
{
public partial class frmCCDt : Smobiler.Core.MobileForm
{

    #region "VTForm Designer generated code "

    public frmCCDt()
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
        this.lblRB_COSTCENTER = new Smobiler.Core.Controls.Label();
        //
        //lblRB_COSTCENTER
        //
        this.lblRB_COSTCENTER.DataMember = "CC_ID";
        this.lblRB_COSTCENTER.DisplayMember = "CC_NAME";
        this.lblRB_COSTCENTER.FontSize = 7f;
        this.lblRB_COSTCENTER.Name = "lblRB_COSTCENTER";
        this.lblRB_COSTCENTER.Padding = new Smobiler.Core.Padding(3f, 0f, 0f, 0f);
        this.lblRB_COSTCENTER.Size = new System.Drawing.SizeF(120f, 16f);
        this.lblRB_COSTCENTER.TabIndex = 6;
        //
        //frmCCDt
        //
        this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] { this.lblRB_COSTCENTER });
        this.Size = new System.Drawing.Size(120, 16);
        this.TitleText = "报销显示";

    }

    internal Smobiler.Core.Controls.Label lblRB_COSTCENTER;
    #endregion

}
}
