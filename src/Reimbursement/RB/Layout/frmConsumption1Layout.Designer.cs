
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
        this.lblnote = new Smobiler.Core.Controls.Label();
        //
        //lblMoney
        //
        this.lblMoney.DataMember = "RBROW_AMOUNT";
        this.lblMoney.DisplayMember = "RBROW_AMOUNT_FORMAT";
        this.lblMoney.ForeColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(45)), Convert.ToInt32(Convert.ToByte(45)), Convert.ToInt32(Convert.ToByte(45)));
        this.lblMoney.Location = new Smobiler.Core.PointS(28f, 0f);
        this.lblMoney.Name = "lblMoney";
        this.lblMoney.Size = new System.Drawing.SizeF(30f, 12f);
        this.lblMoney.TabIndex = 3;
        this.lblMoney.Text = "￥15";
        this.lblMoney.VerticalAlignment = Smobiler.Core.VerticalAlignment.Bottom;
        this.lblMoney.ZIndex = 3;
        //
        //lbldate
        //
        this.lbldate.DataMember = "RBROW_DATE";
        this.lbldate.DisplayMember = "ROW_DATE";
        this.lbldate.FontSize = 5f;
        this.lbldate.ForeColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(145)), Convert.ToInt32(Convert.ToByte(145)), Convert.ToInt32(Convert.ToByte(145)));
        this.lbldate.Location = new Smobiler.Core.PointS(28f, 12f);
        this.lbldate.Name = "lbldate";
        this.lbldate.Padding = new Smobiler.Core.Padding(0f, 2f, 0f, 0f);
        this.lbldate.Size = new System.Drawing.SizeF(30f, 8f);
        this.lbldate.TabIndex = 4;
        this.lbldate.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
        this.lbldate.ZIndex = 4;
        //
        //Line1
        //
        this.Line1.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(230)), Convert.ToInt32(Convert.ToByte(230)), Convert.ToInt32(Convert.ToByte(230)));
        this.Line1.Location = new Smobiler.Core.PointS(0f, 20f);
        this.Line1.Name = "Line1";
        this.Line1.Size = new System.Drawing.SizeF(120f, 1f);
        this.Line1.TabIndex = 5;
        this.Line1.ZIndex = 6;
        //
        //Check
        //
        this.Check.BackColor = System.Drawing.Color.White;
        this.Check.Border = new Smobiler.Core.Border(1);
        this.Check.BorderColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(230)), Convert.ToInt32(Convert.ToByte(230)), Convert.ToInt32(Convert.ToByte(230)));
        this.Check.Checked = false;
        this.Check.CheckedBackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(43)), Convert.ToInt32(Convert.ToByte(146)), Convert.ToInt32(Convert.ToByte(223)));
        this.Check.DataMember = "RBCHECKED";
        this.Check.DisplayMember = "RBCHECKED";
        this.Check.Location = new Smobiler.Core.PointS(4f, 7f);
        this.Check.Name = "Check";
        this.Check.Size = new System.Drawing.SizeF(6f, 6f);
        this.Check.TabIndex = 7;
        this.Check.UnCheckedBackColor = System.Drawing.Color.White;
        this.Check.ZIndex = 1;
        //
        //imgType
        //
        this.imgType.DataMember = "RBROW_TYPE";
        this.imgType.DisplayMember = "RBROW_TYPE";
        this.imgType.FontSize = 4f;
        this.imgType.ForeColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(45)), Convert.ToInt32(Convert.ToByte(45)), Convert.ToInt32(Convert.ToByte(45)));
        this.imgType.HoverBackColor = System.Drawing.Color.White;
        this.imgType.HoverForeColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(45)), Convert.ToInt32(Convert.ToByte(45)), Convert.ToInt32(Convert.ToByte(45)));
        this.imgType.Location = new Smobiler.Core.PointS(14f, 3f);
        this.imgType.Name = "imgType";
        this.imgType.Size = new System.Drawing.SizeF(14f, 14f);
        this.imgType.Style = Smobiler.Core.Controls.ButtonStyle.custom;
        this.imgType.TabIndex = 8;
        this.imgType.TextMember = "RBROW_TYPENAME";
        this.imgType.ZIndex = 2;
        //
        //lblnote
        //
        this.lblnote.DataMember = "ID";
        this.lblnote.DisplayMember = "ROW_NOTE";
        this.lblnote.FontSize = 3f;
        this.lblnote.ForeColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(170)), Convert.ToInt32(Convert.ToByte(170)), Convert.ToInt32(Convert.ToByte(170)));
        this.lblnote.Location = new Smobiler.Core.PointS(58f, 0f);
        this.lblnote.Name = "lblnote";
        this.lblnote.Padding = new Smobiler.Core.Padding(2f, 0f, 0f, 0f);
        this.lblnote.Size = new System.Drawing.SizeF(62f, 20f);
        this.lblnote.TabIndex = 12;
        this.lblnote.ZIndex = 5;
        //
        //frmConsumption1Layout
        //
        this.BackColor = System.Drawing.Color.White;
        this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
		this.Check,
		this.imgType,
		this.lblMoney,
		this.lbldate,
		this.lblnote,
		this.Line1
	});
        this.Size = new System.Drawing.Size(120, 20);

    }
    internal Smobiler.Core.Controls.Label lblMoney;
    internal Smobiler.Core.Controls.Label lbldate;
    internal Smobiler.Core.Controls.Line Line1;
    internal Smobiler.Core.Controls.CheckBox Check;
    internal Smobiler.Core.Controls.ImageButton imgType;
    internal Smobiler.Core.Controls.Label lblnote;

    #endregion

}
