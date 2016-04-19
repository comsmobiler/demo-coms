
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
namespace COMSSmobilerDemo.Reimbursement.CostCenter.Layout
{
public partial class frmAttentionCCDt : Smobiler.Core.MobileForm
{

    #region "SmobilerForm Designer generated code "

    public frmAttentionCCDt()
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
            this.lblCC_ID = new Smobiler.Core.Controls.Label();
            this.lblCC_NAME = new Smobiler.Core.Controls.Label();
            this.imgUserAttention = new Smobiler.Core.Controls.ImageButton();
            // 
            // lblCC_ID
            // 
            this.lblCC_ID.DataMember = "CC_ID";
            this.lblCC_ID.DisplayMember = "CC_ID";
            this.lblCC_ID.FontSize = 7F;
            this.lblCC_ID.Name = "lblCC_ID";
            this.lblCC_ID.Padding = new Smobiler.Core.Padding(1F, 0F, 0F, 0F);
            this.lblCC_ID.Size = new System.Drawing.SizeF(35F, 16F);
            this.lblCC_ID.TabIndex = 2;
            // 
            // lblCC_NAME
            // 
            this.lblCC_NAME.DataMember = "CC_USER";
            this.lblCC_NAME.DisplayMember = "CC_NAME";
            this.lblCC_NAME.FontSize = 7F;
            this.lblCC_NAME.Location = new Smobiler.Core.PointS(35F, 0F);
            this.lblCC_NAME.Name = "lblCC_NAME";
            this.lblCC_NAME.Padding = new Smobiler.Core.Padding(1F, 0F, 1F, 0F);
            this.lblCC_NAME.Size = new System.Drawing.SizeF(72F, 16F);
            this.lblCC_NAME.TabIndex = 3;
            // 
            // imgUserAttention
            // 
            this.imgUserAttention.Location = new Smobiler.Core.PointS(107F, 0F);
            this.imgUserAttention.Name = "imgUserAttention";
            this.imgUserAttention.ResourceID = "unAttention";
            this.imgUserAttention.Size = new System.Drawing.SizeF(13F, 16F);
            this.imgUserAttention.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.imgUserAttention.TabIndex = 4;
            // 
            // frmAttentionCCDt
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblCC_ID,
            this.lblCC_NAME,
            this.imgUserAttention});
            this.Size = new System.Drawing.Size(120, 16);

    }
    internal Smobiler.Core.Controls.Label lblCC_ID;
    internal Smobiler.Core.Controls.Label lblCC_NAME;
    internal Smobiler.Core.Controls.ImageButton imgUserAttention;
    #endregion

}
}
