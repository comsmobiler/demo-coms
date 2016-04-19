
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
public partial class frmConsumptionLayout : Smobiler.Core.MobileForm
{

    #region "SmobilerForm Designer generated code "

    public frmConsumptionLayout()
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
        this.lblMoney = new Smobiler.Core.Controls.Label();
        this.lbldate = new Smobiler.Core.Controls.Label();
        this.Line1 = new Smobiler.Core.Controls.Line();
        this.imgType = new Smobiler.Core.Controls.ImageButton();
        this.Label1 = new Smobiler.Core.Controls.Label();
        this.lblnote = new Smobiler.Core.Controls.Label();
        //
        //lblMoney
        //
        this.lblMoney.DataMember = "RBROW_AMOUNT";
        this.lblMoney.DisplayMember = "RBROW_AMOUNT_FORMAT";
        this.lblMoney.FontSize = 7f;
        this.lblMoney.Location = new Smobiler.Core.PointS(16f, 0f);
        this.lblMoney.Name = "lblMoney";
        this.lblMoney.Size = new System.Drawing.SizeF(30f, 12f);
        this.lblMoney.TabIndex = 3;
        this.lblMoney.VerticalAlignment = Smobiler.Core.VerticalAlignment.Bottom;
        //
        //lbldate
        //
        this.lbldate.DataMember = "ID";
        this.lbldate.DisplayMember = "ROW_DATE";
        this.lbldate.FontSize = 5f;
        this.lbldate.ForeColor = System.Drawing.Color.LightGray;
        this.lbldate.Location = new Smobiler.Core.PointS(16f, 12f);
        this.lbldate.Name = "lbldate";
        this.lbldate.Padding = new Smobiler.Core.Padding(0f, 2f, 0f, 0f);
        this.lbldate.Size = new System.Drawing.SizeF(30f, 8f);
        this.lbldate.TabIndex = 4;
        this.lbldate.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
        //
        //Line1
        //
        this.Line1.BackColor = System.Drawing.Color.Silver;
        this.Line1.Location = new Smobiler.Core.PointS(16f, 20f);
        this.Line1.Name = "Line1";
        this.Line1.Size = new System.Drawing.SizeF(104f, 1f);
        this.Line1.TabIndex = 5;
        //
        //imgType
        //
        this.imgType.DataMember = "RBROW_TYPE";
        this.imgType.DisplayMember = "RBROW_TYPE";
        this.imgType.FontSize = 4f;
        this.imgType.Location = new Smobiler.Core.PointS(1f, 3f);
        this.imgType.Name = "imgType";
        this.imgType.Size = new System.Drawing.SizeF(14f, 14f);
        this.imgType.Style = Smobiler.Core.Controls.ButtonStyle.custom;
        this.imgType.TabIndex = 6;
        this.imgType.TextMember = "RBROW_TYPENAME";
        //
        //Label1
        //
        this.Label1.FontSize = 7f;
        this.Label1.Location = new Smobiler.Core.PointS(46f, 0f);
        this.Label1.Name = "Label1";
        this.Label1.Size = new System.Drawing.SizeF(15f, 20f);
        this.Label1.TabIndex = 7;
        this.Label1.Text = "备注：";
        //
        //lblnote
        //
        this.lblnote.DataMember = "RBROW_NOTE";
        this.lblnote.DisplayMember = "ROW_NOTE";
        this.lblnote.FontSize = 4f;
        this.lblnote.Location = new Smobiler.Core.PointS(61f, 0f);
        this.lblnote.Name = "lblnote";
        this.lblnote.Padding = new Smobiler.Core.Padding(2f, 0f, 0f, 0f);
        this.lblnote.Size = new System.Drawing.SizeF(59f, 20f);
        this.lblnote.TabIndex = 8;
        //
        //frmConsumptionLayout
        //
        this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
			this.lblMoney,
			this.lbldate,
			this.Line1,
			this.imgType,
			this.Label1,
			this.lblnote
		});
        this.Size = new System.Drawing.Size(120, 20);

    }
    internal Smobiler.Core.Controls.Label lblMoney;
    internal Smobiler.Core.Controls.Label lbldate;
    internal Smobiler.Core.Controls.Line Line1;
    internal Smobiler.Core.Controls.ImageButton imgType;
    internal Smobiler.Core.Controls.Label Label1;

    internal Smobiler.Core.Controls.Label lblnote;
    #endregion

}
