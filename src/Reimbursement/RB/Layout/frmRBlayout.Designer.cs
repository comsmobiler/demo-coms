
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
public partial class frmRBlayout : Smobiler.Core.MobileForm
{

    #region "SmobilerForm Designer generated code "

    public frmRBlayout()
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
            this.lblCC = new Smobiler.Core.Controls.Label();
            this.lblDate = new Smobiler.Core.Controls.Label();
            this.lblMoney = new Smobiler.Core.Controls.Label();
            this.Line1 = new Smobiler.Core.Controls.Line();
            this.lblnote = new Smobiler.Core.Controls.Label();
            this.lblState = new Smobiler.Core.Controls.Image();
            // 
            // lblCC
            // 
            this.lblCC.DataMember = "RB_NO";
            this.lblCC.DisplayMember = "RB_COSTCENTERNAME";
            this.lblCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblCC.Name = "lblCC";
            this.lblCC.Padding = new Smobiler.Core.Padding(2F, 5F, 0F, 0F);
            this.lblCC.Size = new System.Drawing.Size(240,24);
            this.lblCC.TabIndex = 2;
            this.lblCC.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            this.lblCC.ZIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.DataMember = "RB_USER";
            this.lblDate.DisplayMember = "RBUSERDATE";
            this.lblDate.FontSize = 10;
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.lblDate.Location = new System.Drawing.Point(80,24);
            this.lblDate.Name = "lblDate";
            this.lblDate.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.lblDate.Size = new System.Drawing.Size(80,16);
            this.lblDate.TabIndex = 3;
            this.lblDate.ZIndex = 4;
            // 
            // lblMoney
            // 
            this.lblMoney.DataMember = "RBROW_AMOUNT";
            this.lblMoney.DisplayMember = "RBROW_AMOUNT_FORMAT";
            this.lblMoney.FontSize = 10;
            this.lblMoney.ForeColor = System.Drawing.Color.Red;
            this.lblMoney.Location = new System.Drawing.Point(0,24);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.lblMoney.Size = new System.Drawing.Size(80,16);
            this.lblMoney.TabIndex = 4;
            this.lblMoney.Text = "£¤0.00";
            this.lblMoney.ZIndex = 2;
            // 
            // Line1
            // 
            this.Line1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Line1.Location = new System.Drawing.Point(0,56);
            this.Line1.Name = "Line1";
            this.Line1.Size = new System.Drawing.Size(240,2);
            this.Line1.TabIndex = 6;
            this.Line1.ZIndex = 6;
            // 
            // lblnote
            // 
            this.lblnote.DataMember = "RB_NOTE";
            this.lblnote.DisplayMember = "NOTE";
            this.lblnote.FontSize = 10;
            this.lblnote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.lblnote.Location = new System.Drawing.Point(0,40);
            this.lblnote.Name = "lblnote";
            this.lblnote.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.lblnote.Size = new System.Drawing.Size(160,16);
            this.lblnote.TabIndex = 7;
            this.lblnote.Text = "±¸×¢£º";
            this.lblnote.ZIndex = 3;
            // 
            // lblState
            // 
            this.lblState.DataMember = "RB_STATE";
            this.lblState.DisplayMember = "RB_STATE_FORMAT";
            this.lblState.ID = "";
            this.lblState.Location = new System.Drawing.Point(160,24);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(80,32);
            this.lblState.TabIndex = 8;
            this.lblState.ZIndex = 5;
            // 
            // frmRBlayout
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblCC,
            this.lblMoney,
            this.lblnote,
            this.lblDate,
            this.Line1,
            this.lblState});
            this.Size = new System.Drawing.Size(240,56);
            this.Name = "frmRBlayout";

    }
    internal Smobiler.Core.Controls.Label lblCC;
    internal Smobiler.Core.Controls.Label lblDate;
    internal Smobiler.Core.Controls.Label lblMoney;
    internal Smobiler.Core.Controls.Line Line1;
    internal Smobiler.Core.Controls.Label lblnote;
    #endregion
    internal Smobiler.Core.Controls.Image lblState;

}
