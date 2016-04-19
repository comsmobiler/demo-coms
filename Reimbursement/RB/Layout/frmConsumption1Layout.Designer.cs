
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
public partial class frmConsumption1Layout : Smobiler.Core.MobileForm
{

    #region "SmobilerForm Designer generated code "

    public frmConsumption1Layout()
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
        this.Check = new Smobiler.Core.Controls.CheckBox();
        this.imgType = new Smobiler.Core.Controls.ImageButton();
        this.lblNO = new Smobiler.Core.Controls.Label();
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
        this.lblMoney.Text = "￥15";
        this.lblMoney.VerticalAlignment = Smobiler.Core.VerticalAlignment.Bottom;
        //
        //lbldate
        //
        this.lbldate.DataMember = "RBROW_DATE";
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
        //Check
        //
        this.Check.BackColor = System.Drawing.Color.White;
        this.Check.Border = new Smobiler.Core.Border(1);
        this.Check.BorderColor = System.Drawing.Color.Silver;
        this.Check.BorderRadius = 4;
        this.Check.Checked = false;
        this.Check.CheckedBackColor = System.Drawing.Color.White;
        this.Check.CheckedColor = System.Drawing.Color.DeepSkyBlue;
        this.Check.DataMember = "RBCHECKED";
        this.Check.DisplayMember = "RBCHECKED";
        this.Check.Location = new Smobiler.Core.PointS(108f, 6f);
        this.Check.Name = "Check";
        this.Check.Size = new System.Drawing.SizeF(10f, 10f);
        this.Check.TabIndex = 7;
        this.Check.UnCheckedBackColor = System.Drawing.Color.White;
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
        this.imgType.TabIndex = 8;
        this.imgType.TextMember = "RBROW_TYPENAME";
        //
        //lblNO
        //
        this.lblNO.DataMember = "ID";
        this.lblNO.FontSize = 7f;
        this.lblNO.Location = new Smobiler.Core.PointS(46f, 0f);
        this.lblNO.Name = "lblNO";
        this.lblNO.Size = new System.Drawing.SizeF(15f, 20f);
        this.lblNO.TabIndex = 11;
        this.lblNO.Text = "备注：";
        //
        //lblnote
        //
        this.lblnote.DataMember = "RBROW_NOTE";
        this.lblnote.DisplayMember = "ROW_NOTE";
        this.lblnote.FontSize = 4f;
        this.lblnote.Location = new Smobiler.Core.PointS(61f, 0f);
        this.lblnote.Name = "lblnote";
        this.lblnote.Padding = new Smobiler.Core.Padding(2f, 0f, 0f, 0f);
        this.lblnote.Size = new System.Drawing.SizeF(47f, 20f);
        this.lblnote.TabIndex = 12;
        //
        //frmConsumption1Layout
        //
        this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
			this.lblMoney,
			this.lbldate,
			this.Line1,
			this.Check,
			this.imgType,
			this.lblNO,
			this.lblnote
		});
        this.Size = new System.Drawing.Size(120, 20);

    }
    internal Smobiler.Core.Controls.Label lblMoney;
    internal Smobiler.Core.Controls.Label lbldate;
    internal Smobiler.Core.Controls.Line Line1;
    internal Smobiler.Core.Controls.CheckBox Check;
    internal Smobiler.Core.Controls.ImageButton imgType;
    internal Smobiler.Core.Controls.Label lblNO;

    internal Smobiler.Core.Controls.Label lblnote;
    #endregion

}
