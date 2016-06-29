
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
public partial class frmRBRightLayout : Smobiler.Core.MobileForm
{

    #region "SmobilerForm Designer generated code "

    public frmRBRightLayout()
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
        this.STATE = new Smobiler.Core.Controls.Button();
        this.AMOUNT = new Smobiler.Core.Controls.Button();
        this.Line1 = new Smobiler.Core.Controls.Line();
        this.ImageButton1 = new Smobiler.Core.Controls.ImageButton();
        //
        //STATE
        //
        this.STATE.BorderColor = System.Drawing.Color.Silver;
        this.STATE.DataMember = "RB_STATE";
        this.STATE.DisplayMember = "STATENAMECOUNT";
        this.STATE.ForeColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(45)), Convert.ToInt32(Convert.ToByte(45)), Convert.ToInt32(Convert.ToByte(45)));
        this.STATE.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Left;
        this.STATE.HoverBackColor = System.Drawing.Color.LightCyan;
        this.STATE.HoverForeColor = System.Drawing.Color.White;
        this.STATE.Location = new Smobiler.Core.PointS(12f, 0f);
        this.STATE.Name = "STATE";
        this.STATE.Padding = new Smobiler.Core.Padding(3f, 0f, 2f, 0f);
        this.STATE.Size = new System.Drawing.SizeF(68f, 14f);
        this.STATE.Style = Smobiler.Core.Controls.ButtonStyle.custom;
        this.STATE.TabIndex = 5;
        this.STATE.ZIndex = 2;
        //
        //AMOUNT
        //
        this.AMOUNT.BorderColor = System.Drawing.Color.Silver;
        this.AMOUNT.DataMember = "AMOUNT";
        this.AMOUNT.DisplayMember = "AMOUNTFIELD";
        this.AMOUNT.ForeColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(45)), Convert.ToInt32(Convert.ToByte(45)), Convert.ToInt32(Convert.ToByte(45)));
        this.AMOUNT.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Left;
        this.AMOUNT.HoverBackColor = System.Drawing.Color.LightCyan;
        this.AMOUNT.HoverForeColor = System.Drawing.Color.White;
        this.AMOUNT.Location = new Smobiler.Core.PointS(80f, 0f);
        this.AMOUNT.Name = "AMOUNT";
        this.AMOUNT.Size = new System.Drawing.SizeF(40f, 14f);
        this.AMOUNT.Style = Smobiler.Core.Controls.ButtonStyle.custom;
        this.AMOUNT.TabIndex = 7;
        this.AMOUNT.Text = "￥12.5";
        this.AMOUNT.ZIndex = 3;
        //
        //Line1
        //
        this.Line1.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(230)), Convert.ToInt32(Convert.ToByte(230)), Convert.ToInt32(Convert.ToByte(230)));
        this.Line1.Location = new Smobiler.Core.PointS(0f, 14f);
        this.Line1.Name = "Line1";
        this.Line1.Size = new System.Drawing.SizeF(120f, 1f);
        this.Line1.TabIndex = 8;
        this.Line1.ZIndex = 4;
        //
        //ImageButton1
        //
        this.ImageButton1.DataMember = "STATENAME";
        this.ImageButton1.DisplayMember = "STATENAME";
        this.ImageButton1.FontSize = 4f;
        this.ImageButton1.Name = "ImageButton1";
        this.ImageButton1.Size = new System.Drawing.SizeF(12f, 14f);
        this.ImageButton1.Style = Smobiler.Core.Controls.ButtonStyle.custom;
        this.ImageButton1.TabIndex = 9;
        this.ImageButton1.ZIndex = 1;
        //
        //frmRBRightLayout
        //
        this.BackColor = System.Drawing.Color.White;
        this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
		this.ImageButton1,
		this.STATE,
		this.AMOUNT,
		this.Line1
	});
        this.Size = new System.Drawing.Size(120, 14);

    }
    internal Smobiler.Core.Controls.Button STATE;
    internal Smobiler.Core.Controls.Button AMOUNT;
    internal Smobiler.Core.Controls.Line Line1;
    internal Smobiler.Core.Controls.ImageButton ImageButton1;
    #endregion

}
