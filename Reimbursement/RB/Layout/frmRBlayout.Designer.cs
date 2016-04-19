
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
        this.lblState = new Smobiler.Core.Controls.Label();
        this.Line1 = new Smobiler.Core.Controls.Line();
        this.lblnote = new Smobiler.Core.Controls.Label();
        //
        //lblCC
        //
        this.lblCC.DataMember = "RB_NO";
        this.lblCC.DisplayMember = "RB_COSTCENTERNAME";
        this.lblCC.Name = "lblCC";
        this.lblCC.Padding = new Smobiler.Core.Padding(2f, 0f, 2f, 0f);
        this.lblCC.Size = new System.Drawing.SizeF(95f, 12f);
        this.lblCC.TabIndex = 2;
        this.lblCC.VerticalAlignment = Smobiler.Core.VerticalAlignment.Bottom;
        //
        //lblDate
        //
        this.lblDate.DataMember = "RB_USER";
        this.lblDate.DisplayMember = "RBUSERDATE";
        this.lblDate.FontSize = 5f;
        this.lblDate.ForeColor = System.Drawing.Color.LightGray;
        this.lblDate.Location = new Smobiler.Core.PointS(40f, 12f);
        this.lblDate.Name = "lblDate";
        this.lblDate.Padding = new Smobiler.Core.Padding(2f, 2f, 2f, 0f);
        this.lblDate.Size = new System.Drawing.SizeF(37f, 8f);
        this.lblDate.TabIndex = 3;
        this.lblDate.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
        //
        //lblMoney
        //
        this.lblMoney.DataMember = "RBROW_AMOUNT";
        this.lblMoney.DisplayMember = "RBROW_AMOUNT_FORMAT";
        this.lblMoney.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
        this.lblMoney.Location = new Smobiler.Core.PointS(95f, 0f);
        this.lblMoney.Name = "lblMoney";
        this.lblMoney.Padding = new Smobiler.Core.Padding(0f, 0f, 2f, 0f);
        this.lblMoney.Size = new System.Drawing.SizeF(25f, 12f);
        this.lblMoney.TabIndex = 4;
        this.lblMoney.VerticalAlignment = Smobiler.Core.VerticalAlignment.Bottom;
        //
        //lblState
        //
        this.lblState.DataMember = "RB_STATE";
        this.lblState.DisplayMember = "RB_STATE_FORMAT";
        this.lblState.FontSize = 5f;
        this.lblState.ForeColor = System.Drawing.Color.DeepSkyBlue;
        this.lblState.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
        this.lblState.Location = new Smobiler.Core.PointS(77f, 12f);
        this.lblState.Name = "lblState";
        this.lblState.Padding = new Smobiler.Core.Padding(0f, 2f, 2f, 0f);
        this.lblState.Size = new System.Drawing.SizeF(42f, 8f);
        this.lblState.TabIndex = 5;
        this.lblState.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
        //
        //Line1
        //
        this.Line1.BackColor = System.Drawing.Color.Silver;
        this.Line1.Location = new Smobiler.Core.PointS(0f, 20f);
        this.Line1.Name = "Line1";
        this.Line1.Size = new System.Drawing.SizeF(120f, 1f);
        this.Line1.TabIndex = 6;
        //
        //lblnote
        //
        this.lblnote.DataMember = "RB_NOTE";
        this.lblnote.DisplayMember = "NOTE";
        this.lblnote.FontSize = 5f;
        this.lblnote.ForeColor = System.Drawing.Color.LightGray;
        this.lblnote.Location = new Smobiler.Core.PointS(0f, 12f);
        this.lblnote.Name = "lblnote";
        this.lblnote.Padding = new Smobiler.Core.Padding(2f, 2f, 2f, 0f);
        this.lblnote.Size = new System.Drawing.SizeF(40f, 8f);
        this.lblnote.TabIndex = 7;
        this.lblnote.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
        //
        //frmRBlayout
        //
        this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
			this.lblCC,
			this.lblDate,
			this.lblMoney,
			this.lblState,
			this.Line1,
			this.lblnote
		});
        this.Size = new System.Drawing.Size(120, 20);

    }
    internal Smobiler.Core.Controls.Label lblCC;
    internal Smobiler.Core.Controls.Label lblDate;
    internal Smobiler.Core.Controls.Label lblMoney;
    internal Smobiler.Core.Controls.Label lblState;
    internal Smobiler.Core.Controls.Line Line1;

    internal Smobiler.Core.Controls.Label lblnote;
    #endregion

}