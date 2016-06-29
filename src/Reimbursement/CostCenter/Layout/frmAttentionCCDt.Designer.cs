
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
        this.Line6 = new Smobiler.Core.Controls.Line();
        //
        //lblCC_ID
        //
        this.lblCC_ID.DataMember = "CC_ID";
        this.lblCC_ID.DisplayMember = "CC_ID";
        this.lblCC_ID.ForeColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(45)), Convert.ToInt32(Convert.ToByte(45)), Convert.ToInt32(Convert.ToByte(45)));
        this.lblCC_ID.Name = "lblCC_ID";
        this.lblCC_ID.Padding = new Smobiler.Core.Padding(2f, 0f, 0f, 0f);
        this.lblCC_ID.Size = new System.Drawing.SizeF(104f, 10f);
        this.lblCC_ID.TabIndex = 2;
        this.lblCC_ID.ZIndex = 1;
        //
        //lblCC_NAME
        //
        this.lblCC_NAME.DataMember = "CC_USER";
        this.lblCC_NAME.DisplayMember = "CC_NAME";
        this.lblCC_NAME.FontSize = 5f;
        this.lblCC_NAME.ForeColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(145)), Convert.ToInt32(Convert.ToByte(145)), Convert.ToInt32(Convert.ToByte(145)));
        this.lblCC_NAME.Location = new Smobiler.Core.PointS(0f, 10f);
        this.lblCC_NAME.Name = "lblCC_NAME";
        this.lblCC_NAME.Padding = new Smobiler.Core.Padding(2f, 0f, 0f, 0f);
        this.lblCC_NAME.Size = new System.Drawing.SizeF(104f, 8f);
        this.lblCC_NAME.TabIndex = 3;
        this.lblCC_NAME.ZIndex = 2;
        //
        //imgUserAttention
        //
        this.imgUserAttention.FontSize = 4f;
        this.imgUserAttention.Location = new Smobiler.Core.PointS(104f, 2f);
        this.imgUserAttention.Name = "imgUserAttention";
        this.imgUserAttention.ResourceID = "unAttention";
        this.imgUserAttention.Size = new System.Drawing.SizeF(14f, 14f);
        this.imgUserAttention.Style = Smobiler.Core.Controls.ButtonStyle.custom;
        this.imgUserAttention.TabIndex = 4;
        this.imgUserAttention.ZIndex = 3;
        //
        //Line6
        //
        this.Line6.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(230)), Convert.ToInt32(Convert.ToByte(230)), Convert.ToInt32(Convert.ToByte(230)));
        this.Line6.Location = new Smobiler.Core.PointS(0f, 18f);
        this.Line6.Name = "Line6";
        this.Line6.Size = new System.Drawing.SizeF(120f, 1f);
        this.Line6.TabIndex = 5;
        this.Line6.ZIndex = 4;
        //
        //frmAttentionCCDt
        //
        this.BackColor = System.Drawing.Color.White;
        this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
		this.lblCC_ID,
		this.lblCC_NAME,
		this.imgUserAttention,
		this.Line6
	});
        this.Size = new System.Drawing.Size(120, 18);

    }
    internal Smobiler.Core.Controls.Label lblCC_ID;
    internal Smobiler.Core.Controls.Label lblCC_NAME;
    internal Smobiler.Core.Controls.ImageButton imgUserAttention;
    internal Smobiler.Core.Controls.Line Line6;

    #endregion

}
}
