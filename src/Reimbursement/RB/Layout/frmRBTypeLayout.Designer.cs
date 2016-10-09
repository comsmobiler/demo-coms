
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
public partial class frmRBTypeLayout : Smobiler.Core.MobileForm
{

    #region "SmobilerForm Designer generated code "

    public frmRBTypeLayout()
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
            this.lblTypeName = new Smobiler.Core.Controls.Label();
            this.Line1 = new Smobiler.Core.Controls.Line();
            this.Image1 = new Smobiler.Core.Controls.Image();
            // 
            // lblTypeName
            // 
            this.lblTypeName.DataMember = "TYPE";
            this.lblTypeName.DisplayMember = "TYPENAME";
            this.lblTypeName.Location = new System.Drawing.Point(40, 0);
            this.lblTypeName.Name = "lblTypeName";
            this.lblTypeName.Size = new System.Drawing.Size(260, 50);
            this.lblTypeName.TabIndex = 3;
            // 
            // Line1
            // 
            this.Line1.BackColor = System.Drawing.Color.Silver;
            this.Line1.Location = new System.Drawing.Point(40, 50);
            this.Line1.Name = "Line1";
            this.Line1.Size = new System.Drawing.Size(260, 3);
            this.Line1.TabIndex = 4;
            // 
            // Image1
            // 
            this.Image1.DataMember = "TYPE";
            this.Image1.DisplayMember = "TYPE";
            this.Image1.ID = "";
            this.Image1.Location = new System.Drawing.Point(8, 13);
            this.Image1.Name = "Image1";
            this.Image1.Size = new System.Drawing.Size(25, 25);
            this.Image1.TabIndex = 5;
            // 
            // frmRBTypeLayout
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblTypeName,
            this.Line1,
            this.Image1});
            this.Size = new System.Drawing.Size(300, 50);
            this.Name = "frmRBTypeLayout";

    }
    internal Smobiler.Core.Controls.Label lblTypeName;
    internal Smobiler.Core.Controls.Line Line1;

    internal Smobiler.Core.Controls.Image Image1;
    #endregion

}
