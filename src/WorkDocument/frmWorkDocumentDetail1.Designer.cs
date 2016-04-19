using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
namespace COMSSmobilerDemo.WorkDocument
{
    public partial class frmWorkDocumentDetail1 : Smobiler.Core.MobileForm
    {

        #region "SmobilerForm Designer generated code "

        public frmWorkDocumentDetail1()
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
            this.Label1 = new Smobiler.Core.Controls.Label();
            this.lbltype = new Smobiler.Core.Controls.Label();
            this.Label2 = new Smobiler.Core.Controls.Label();
            this.lblCC = new Smobiler.Core.Controls.Label();
            this.lblworkday1 = new Smobiler.Core.Controls.Label();
            this.lblworkday = new Smobiler.Core.Controls.Label();
            this.lblCDNO1 = new Smobiler.Core.Controls.Label();
            this.lblCDNO = new Smobiler.Core.Controls.Label();
            this.lblMenDay = new Smobiler.Core.Controls.Label();
            this.tExit = new Smobiler.Core.Controls.ToolbarItem();
            this.save = new Smobiler.Core.Controls.ToolbarItem();
            this.lblState = new Smobiler.Core.Controls.Label();
            this.Label8 = new Smobiler.Core.Controls.Label();
            this.lbllNO = new Smobiler.Core.Controls.Label();
            this.lblNote1 = new Smobiler.Core.Controls.Label();
            this.lblNote = new Smobiler.Core.Controls.TextBox();
            // 
            // Label1
            // 
            this.Label1.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label1.BorderColor = System.Drawing.Color.DarkGray;
            this.Label1.ForeColor = System.Drawing.Color.Gray;
            this.Label1.Location = new Smobiler.Core.PointS(0F, 14F);
            this.Label1.Name = "Label1";
            this.Label1.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label1.Size = new System.Drawing.SizeF(35F, 14F);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "类型";
            // 
            // lbltype
            // 
            this.lbltype.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.lbltype.BorderColor = System.Drawing.Color.DarkGray;
            this.lbltype.Location = new Smobiler.Core.PointS(35F, 14F);
            this.lbltype.Name = "lbltype";
            this.lbltype.Padding = new Smobiler.Core.Padding(0F, 0F, 2F, 0F);
            this.lbltype.Size = new System.Drawing.SizeF(85F, 14F);
            this.lbltype.TabIndex = 4;
            // 
            // Label2
            // 
            this.Label2.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label2.BorderColor = System.Drawing.Color.DarkGray;
            this.Label2.ForeColor = System.Drawing.Color.Gray;
            this.Label2.Location = new Smobiler.Core.PointS(0F, 28F);
            this.Label2.Name = "Label2";
            this.Label2.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label2.Size = new System.Drawing.SizeF(35F, 14F);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "成本中心";
            // 
            // lblCC
            // 
            this.lblCC.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.lblCC.BorderColor = System.Drawing.Color.DarkGray;
            this.lblCC.Location = new Smobiler.Core.PointS(35F, 28F);
            this.lblCC.Name = "lblCC";
            this.lblCC.Padding = new Smobiler.Core.Padding(0F, 0F, 2F, 0F);
            this.lblCC.Size = new System.Drawing.SizeF(85F, 14F);
            this.lblCC.TabIndex = 6;
            // 
            // lblworkday1
            // 
            this.lblworkday1.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.lblworkday1.BorderColor = System.Drawing.Color.DarkGray;
            this.lblworkday1.ForeColor = System.Drawing.Color.Gray;
            this.lblworkday1.Location = new Smobiler.Core.PointS(0F, 45F);
            this.lblworkday1.Name = "lblworkday1";
            this.lblworkday1.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.lblworkday1.Size = new System.Drawing.SizeF(35F, 14F);
            this.lblworkday1.TabIndex = 7;
            this.lblworkday1.Text = "工单业务人天";
            // 
            // lblworkday
            // 
            this.lblworkday.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.lblworkday.BorderColor = System.Drawing.Color.DarkGray;
            this.lblworkday.Location = new Smobiler.Core.PointS(35F, 45F);
            this.lblworkday.Name = "lblworkday";
            this.lblworkday.Padding = new Smobiler.Core.Padding(0F, 0F, 2F, 0F);
            this.lblworkday.Size = new System.Drawing.SizeF(85F, 14F);
            this.lblworkday.TabIndex = 8;
            // 
            // lblCDNO1
            // 
            this.lblCDNO1.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.lblCDNO1.BorderColor = System.Drawing.Color.DarkGray;
            this.lblCDNO1.ForeColor = System.Drawing.Color.Gray;
            this.lblCDNO1.Location = new Smobiler.Core.PointS(0F, 59F);
            this.lblCDNO1.Name = "lblCDNO1";
            this.lblCDNO1.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.lblCDNO1.Size = new System.Drawing.SizeF(35F, 14F);
            this.lblCDNO1.TabIndex = 9;
            this.lblCDNO1.Text = "协同单编号";
            // 
            // lblCDNO
            // 
            this.lblCDNO.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.lblCDNO.BorderColor = System.Drawing.Color.DarkGray;
            this.lblCDNO.Location = new Smobiler.Core.PointS(35F, 59F);
            this.lblCDNO.Name = "lblCDNO";
            this.lblCDNO.Padding = new Smobiler.Core.Padding(0F, 0F, 2F, 0F);
            this.lblCDNO.Size = new System.Drawing.SizeF(85F, 14F);
            this.lblCDNO.TabIndex = 10;
            // 
            // lblMenDay
            // 
            this.lblMenDay.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblMenDay.BorderColor = System.Drawing.Color.White;
            this.lblMenDay.FontSize = 8F;
            this.lblMenDay.ForeColor = System.Drawing.Color.White;
            this.lblMenDay.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.lblMenDay.Location = new Smobiler.Core.PointS(0F, 119F);
            this.lblMenDay.Name = "lblMenDay";
            this.lblMenDay.Size = new System.Drawing.SizeF(120F, 8F);
            this.lblMenDay.TabIndex = 12;
            this.lblMenDay.Text = "人天值";
            // 
            // tExit
            // 
            this.tExit.IconID = "Exit";
            this.tExit.Name = "tExit";
            this.tExit.Text = "返回";
            // 
            // save
            // 
            this.save.IconID = "shenpi";
            this.save.Name = "save";
            this.save.Text = "审批";
            // 
            // lblState
            // 
            this.lblState.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblState.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.lblState.BorderColor = System.Drawing.Color.White;
            this.lblState.FontSize = 8F;
            this.lblState.ForeColor = System.Drawing.Color.White;
            this.lblState.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.lblState.Location = new Smobiler.Core.PointS(0F, 127F);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.SizeF(120F, 10F);
            this.lblState.TabIndex = 14;
            // 
            // Label8
            // 
            this.Label8.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label8.BorderColor = System.Drawing.Color.DarkGray;
            this.Label8.ForeColor = System.Drawing.Color.Gray;
            this.Label8.Name = "Label8";
            this.Label8.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label8.Size = new System.Drawing.SizeF(35F, 14F);
            this.Label8.TabIndex = 15;
            this.Label8.Text = "工单编号";
            // 
            // lbllNO
            // 
            this.lbllNO.Bold = true;
            this.lbllNO.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.lbllNO.BorderColor = System.Drawing.Color.DarkGray;
            this.lbllNO.FontSize = 7F;
            this.lbllNO.Location = new Smobiler.Core.PointS(35F, 0F);
            this.lbllNO.Name = "lbllNO";
            this.lbllNO.Size = new System.Drawing.SizeF(90F, 14F);
            this.lbllNO.TabIndex = 16;
            // 
            // lblNote1
            // 
            this.lblNote1.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.lblNote1.BorderColor = System.Drawing.Color.DarkGray;
            this.lblNote1.ForeColor = System.Drawing.Color.Gray;
            this.lblNote1.Location = new Smobiler.Core.PointS(0F, 76F);
            this.lblNote1.Name = "lblNote1";
            this.lblNote1.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.lblNote1.Size = new System.Drawing.SizeF(35F, 40F);
            this.lblNote1.TabIndex = 17;
            this.lblNote1.Text = "工单内容";
            // 
            // lblNote
            // 
            this.lblNote.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.lblNote.BorderColor = System.Drawing.Color.DarkGray;
            this.lblNote.FontSize = 7F;
            this.lblNote.Location = new Smobiler.Core.PointS(35F, 76F);
            this.lblNote.Multiline = true;
            this.lblNote.Name = "lblNote";
            this.lblNote.ReadOnly = true;
            this.lblNote.Size = new System.Drawing.SizeF(85F, 40F);
            this.lblNote.TabIndex = 18;
            // 
            // frmWorkDocumentDetail1
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label1,
            this.lbltype,
            this.Label2,
            this.lblCC,
            this.lblworkday1,
            this.lblworkday,
            this.lblCDNO1,
            this.lblCDNO,
            this.lblMenDay,
            this.lblState,
            this.Label8,
            this.lbllNO,
            this.lblNote1,
            this.lblNote});
            this.TitleBackColor = System.Drawing.Color.DeepSkyBlue;
            this.TitleText = "工作单详细";
            this.Toolbar.AddRange(new Smobiler.Core.Controls.ToolbarItem[] {
            this.tExit,
            this.save});
            this.Load += new System.EventHandler(this.frmWorkDocumentDetail1_Load);
            this.ToolbarItemClick += new Smobiler.Core.ToolbarItemClickEventHandler(this.frmWorkDocumentDetail1_ToolbarItemClick);

        }
        internal Smobiler.Core.Controls.Label Label1;
        internal Smobiler.Core.Controls.Label lbltype;
        internal Smobiler.Core.Controls.Label Label2;
        internal Smobiler.Core.Controls.Label lblCC;
        internal Smobiler.Core.Controls.Label lblworkday1;
        internal Smobiler.Core.Controls.Label lblworkday;
        internal Smobiler.Core.Controls.Label lblCDNO1;
        internal Smobiler.Core.Controls.Label lblCDNO;
        internal Smobiler.Core.Controls.Label lblMenDay;
        internal Smobiler.Core.Controls.ToolbarItem tExit;
        internal Smobiler.Core.Controls.ToolbarItem save;
        internal Smobiler.Core.Controls.Label lblState;
        internal Smobiler.Core.Controls.Label Label8;
        internal Smobiler.Core.Controls.Label lbllNO;
        internal Smobiler.Core.Controls.Label lblNote1;

        internal Smobiler.Core.Controls.TextBox lblNote;
        #endregion

    }


}