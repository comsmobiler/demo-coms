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
            this.save = new Smobiler.Core.Controls.ToolbarItem();
            this.Label8 = new Smobiler.Core.Controls.Label();
            this.lbllNO = new Smobiler.Core.Controls.Label();
            this.lblNote1 = new Smobiler.Core.Controls.Label();
            this.lblNote = new Smobiler.Core.Controls.Label();
            this.lblMenDay1 = new Smobiler.Core.Controls.Label();
            this.lblMenDay = new Smobiler.Core.Controls.Label();
            this.lblState1 = new Smobiler.Core.Controls.Label();
            this.lblState = new Smobiler.Core.Controls.Label();
            // 
            // Label1
            // 
            this.Label1.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
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
            this.lbltype.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lbltype.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lbltype.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lbltype.Location = new Smobiler.Core.PointS(35F, 14F);
            this.lbltype.Name = "lbltype";
            this.lbltype.Padding = new Smobiler.Core.Padding(0F, 0F, 12F, 0F);
            this.lbltype.Size = new System.Drawing.SizeF(85F, 14F);
            this.lbltype.TabIndex = 4;
            // 
            // Label2
            // 
            this.Label2.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label2.Location = new Smobiler.Core.PointS(0F, 28F);
            this.Label2.Name = "Label2";
            this.Label2.Padding = new Smobiler.Core.Padding(2F, 5F, 0F, 0F);
            this.Label2.Size = new System.Drawing.SizeF(35F, 24F);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "成本中心";
            this.Label2.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            // 
            // lblCC
            // 
            this.lblCC.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.lblCC.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblCC.Location = new Smobiler.Core.PointS(35F, 28F);
            this.lblCC.Name = "lblCC";
            this.lblCC.Padding = new Smobiler.Core.Padding(0F, 5F, 12F, 0F);
            this.lblCC.Size = new System.Drawing.SizeF(85F, 24F);
            this.lblCC.TabIndex = 6;
            this.lblCC.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            // 
            // lblworkday1
            // 
            this.lblworkday1.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.lblworkday1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblworkday1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblworkday1.Location = new Smobiler.Core.PointS(0F, 55F);
            this.lblworkday1.Name = "lblworkday1";
            this.lblworkday1.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.lblworkday1.Size = new System.Drawing.SizeF(35F, 14F);
            this.lblworkday1.TabIndex = 7;
            this.lblworkday1.Text = "工单业务人天";
            // 
            // lblworkday
            // 
            this.lblworkday.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.lblworkday.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblworkday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblworkday.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblworkday.Location = new Smobiler.Core.PointS(35F, 55F);
            this.lblworkday.Name = "lblworkday";
            this.lblworkday.Padding = new Smobiler.Core.Padding(0F, 0F, 12F, 0F);
            this.lblworkday.Size = new System.Drawing.SizeF(85F, 14F);
            this.lblworkday.TabIndex = 8;
            // 
            // lblCDNO1
            // 
            this.lblCDNO1.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.lblCDNO1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblCDNO1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblCDNO1.Location = new Smobiler.Core.PointS(0F, 69F);
            this.lblCDNO1.Name = "lblCDNO1";
            this.lblCDNO1.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.lblCDNO1.Size = new System.Drawing.SizeF(35F, 14F);
            this.lblCDNO1.TabIndex = 9;
            this.lblCDNO1.Text = "协同单编号";
            // 
            // lblCDNO
            // 
            this.lblCDNO.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.lblCDNO.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblCDNO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblCDNO.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblCDNO.Location = new Smobiler.Core.PointS(35F, 69F);
            this.lblCDNO.Name = "lblCDNO";
            this.lblCDNO.Padding = new Smobiler.Core.Padding(0F, 0F, 12F, 0F);
            this.lblCDNO.Size = new System.Drawing.SizeF(85F, 14F);
            this.lblCDNO.TabIndex = 10;
            // 
            // save
            // 
            this.save.IconID = "!\\ue065043146223";
            this.save.Name = "save";
            this.save.Text = "审批";
            // 
            // Label8
            // 
            this.Label8.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
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
            this.lbllNO.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lbllNO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lbllNO.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lbllNO.Location = new Smobiler.Core.PointS(35F, 0F);
            this.lbllNO.Name = "lbllNO";
            this.lbllNO.Padding = new Smobiler.Core.Padding(0F, 0F, 12F, 0F);
            this.lbllNO.Size = new System.Drawing.SizeF(85F, 14F);
            this.lbllNO.TabIndex = 16;
            // 
            // lblNote1
            // 
            this.lblNote1.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.lblNote1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblNote1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblNote1.Location = new Smobiler.Core.PointS(0F, 86F);
            this.lblNote1.Name = "lblNote1";
            this.lblNote1.Padding = new Smobiler.Core.Padding(2F, 5F, 0F, 0F);
            this.lblNote1.Size = new System.Drawing.SizeF(35F, 40F);
            this.lblNote1.TabIndex = 17;
            this.lblNote1.Text = "工单内容";
            this.lblNote1.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            // 
            // lblNote
            // 
            this.lblNote.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.lblNote.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblNote.Location = new Smobiler.Core.PointS(35F, 86F);
            this.lblNote.Name = "lblNote";
            this.lblNote.Padding = new Smobiler.Core.Padding(0F, 5F, 12F, 0F);
            this.lblNote.Size = new System.Drawing.SizeF(85F, 40F);
            this.lblNote.TabIndex = 18;
            this.lblNote.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            // 
            // lblMenDay1
            // 
            this.lblMenDay1.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.lblMenDay1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblMenDay1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblMenDay1.Location = new Smobiler.Core.PointS(0F, 129F);
            this.lblMenDay1.Name = "lblMenDay1";
            this.lblMenDay1.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.lblMenDay1.Size = new System.Drawing.SizeF(35F, 14F);
            this.lblMenDay1.TabIndex = 19;
            this.lblMenDay1.Text = "人天值";
            // 
            // lblMenDay
            // 
            this.lblMenDay.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.lblMenDay.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblMenDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblMenDay.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblMenDay.Location = new Smobiler.Core.PointS(35F, 129F);
            this.lblMenDay.Name = "lblMenDay";
            this.lblMenDay.Padding = new Smobiler.Core.Padding(0F, 0F, 12F, 0F);
            this.lblMenDay.Size = new System.Drawing.SizeF(85F, 14F);
            this.lblMenDay.TabIndex = 20;
            // 
            // lblState1
            // 
            this.lblState1.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.lblState1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblState1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblState1.Location = new Smobiler.Core.PointS(0F, 143F);
            this.lblState1.Name = "lblState1";
            this.lblState1.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.lblState1.Size = new System.Drawing.SizeF(35F, 14F);
            this.lblState1.TabIndex = 21;
            this.lblState1.Text = "状态";
            // 
            // lblState
            // 
            this.lblState.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.lblState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblState.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblState.Location = new Smobiler.Core.PointS(35F, 143F);
            this.lblState.Name = "lblState";
            this.lblState.Padding = new Smobiler.Core.Padding(0F, 0F, 12F, 0F);
            this.lblState.Size = new System.Drawing.SizeF(85F, 14F);
            this.lblState.TabIndex = 22;
            // 
            // frmWorkDocumentDetail1
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label1,
            this.lbltype,
            this.Label2,
            this.lblCC,
            this.lblworkday1,
            this.lblworkday,
            this.lblCDNO1,
            this.lblCDNO,
            this.Label8,
            this.lbllNO,
            this.lblNote1,
            this.lblNote,
            this.lblMenDay1,
            this.lblMenDay,
            this.lblState1,
            this.lblState});
            this.StatusBarStyle = Smobiler.Core.StatusBarStyle.Default;
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("Exit", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(50))))));
            this.TitleText = "工单详情";
            this.Toolbar.AddRange(new Smobiler.Core.Controls.ToolbarItem[] {
            this.save});
            this.ToolbarStyle = new Smobiler.Core.ToolBarSytle(Smobiler.Core.ToolbarSelectStyle.None, System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))), System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))));
            this.Load += new System.EventHandler(this.frmWorkDocumentDetail1_Load);
            this.TitleImageClick += new System.EventHandler(this.MobileForm_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.MobileForm_KeyDown);

        }
        internal Smobiler.Core.Controls.Label Label1;
        internal Smobiler.Core.Controls.Label lbltype;
        internal Smobiler.Core.Controls.Label Label2;
        internal Smobiler.Core.Controls.Label lblCC;
        internal Smobiler.Core.Controls.Label lblworkday1;
        internal Smobiler.Core.Controls.Label lblworkday;
        internal Smobiler.Core.Controls.Label lblCDNO1;
        internal Smobiler.Core.Controls.Label lblCDNO;
        internal Smobiler.Core.Controls.ToolbarItem save;
        internal Smobiler.Core.Controls.Label Label8;
        internal Smobiler.Core.Controls.Label lbllNO;
        internal Smobiler.Core.Controls.Label lblNote1;
        internal Smobiler.Core.Controls.Label lblNote;
        internal Smobiler.Core.Controls.Label lblMenDay1;
        internal Smobiler.Core.Controls.Label lblMenDay;
        internal Smobiler.Core.Controls.Label lblState1;
        internal Smobiler.Core.Controls.Label lblState;
        #endregion

    }


}