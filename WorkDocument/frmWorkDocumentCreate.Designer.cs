using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
namespace COMSSmobilerDemo.WorkDocument
{
    public partial class frmWorkDocumentCreate : Smobiler.Core.MobileForm
    {

        #region "SmobilerForm Designer generated code "

        public frmWorkDocumentCreate()
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
            this.btnCC = new Smobiler.Core.Controls.Button();
            this.btnChoice = new Smobiler.Core.Controls.Button();
            this.Label1 = new Smobiler.Core.Controls.Label();
            this.btntype = new Smobiler.Core.Controls.Button();
            this.btntype2 = new Smobiler.Core.Controls.Button();
            this.lblworkday = new Smobiler.Core.Controls.Label();
            this.txtworkday1 = new Smobiler.Core.Controls.TextBox();
            this.txtworkday2 = new Smobiler.Core.Controls.TextBox();
            this.lblCDNO = new Smobiler.Core.Controls.Label();
            this.txtCDNO = new Smobiler.Core.Controls.TextBox();
            this.TxtNote = new Smobiler.Core.Controls.TextBox();
            this.tExit = new Smobiler.Core.Controls.ToolbarItem();
            this.save = new Smobiler.Core.Controls.ToolbarItem();
            this.PopList1 = new Smobiler.Core.Controls.PopList();
            this.lblNote = new Smobiler.Core.Controls.Label();
            // 
            // btnCC
            // 
            this.btnCC.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.btnCC.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCC.FontSize = 7F;
            this.btnCC.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Left;
            this.btnCC.Location = new Smobiler.Core.PointS(0F, 17F);
            this.btnCC.Name = "btnCC";
            this.btnCC.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.btnCC.Size = new System.Drawing.SizeF(107F, 14F);
            this.btnCC.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btnCC.TabIndex = 3;
            this.btnCC.Text = "成本中心选择(必填)";
            this.btnCC.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnChoice_Click);
            // 
            // btnChoice
            // 
            this.btnChoice.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.btnChoice.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChoice.FontSize = 8F;
            this.btnChoice.ForeColor = System.Drawing.Color.Gray;
            this.btnChoice.Location = new Smobiler.Core.PointS(107F, 17F);
            this.btnChoice.Name = "btnChoice";
            this.btnChoice.Size = new System.Drawing.SizeF(13F, 14F);
            this.btnChoice.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btnChoice.TabIndex = 4;
            this.btnChoice.Text = ">";
            this.btnChoice.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnChoice_Click);
            // 
            // Label1
            // 
            this.Label1.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label1.BorderColor = System.Drawing.Color.DarkGray;
            this.Label1.ForeColor = System.Drawing.Color.Gray;
            this.Label1.Name = "Label1";
            this.Label1.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label1.Size = new System.Drawing.SizeF(35F, 14F);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "工作单类型";
            // 
            // btntype
            // 
            this.btntype.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.btntype.BorderColor = System.Drawing.Color.DarkGray;
            this.btntype.FontSize = 7F;
            this.btntype.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Left;
            this.btntype.Location = new Smobiler.Core.PointS(35F, 0F);
            this.btntype.Name = "btntype";
            this.btntype.Size = new System.Drawing.SizeF(72F, 14F);
            this.btntype.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btntype.TabIndex = 6;
            this.btntype.Text = "类型选择(必填)";
            this.btntype.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btntype_Click);
            // 
            // btntype2
            // 
            this.btntype2.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.btntype2.BorderColor = System.Drawing.Color.DarkGray;
            this.btntype2.FontSize = 8F;
            this.btntype2.ForeColor = System.Drawing.Color.Gray;
            this.btntype2.Location = new Smobiler.Core.PointS(107F, 0F);
            this.btntype2.Name = "btntype2";
            this.btntype2.Size = new System.Drawing.SizeF(13F, 14F);
            this.btntype2.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btntype2.TabIndex = 7;
            this.btntype2.Text = ">";
            this.btntype2.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btntype_Click);
            // 
            // lblworkday
            // 
            this.lblworkday.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.lblworkday.BorderColor = System.Drawing.Color.DarkGray;
            this.lblworkday.ForeColor = System.Drawing.Color.Gray;
            this.lblworkday.Location = new Smobiler.Core.PointS(0F, 34F);
            this.lblworkday.Name = "lblworkday";
            this.lblworkday.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.lblworkday.Size = new System.Drawing.SizeF(35F, 14F);
            this.lblworkday.TabIndex = 8;
            this.lblworkday.Text = "工单业务人天";
            // 
            // txtworkday1
            // 
            this.txtworkday1.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.txtworkday1.BorderColor = System.Drawing.Color.DarkGray;
            this.txtworkday1.FontSize = 7F;
            this.txtworkday1.ForeColor = System.Drawing.Color.Silver;
            this.txtworkday1.InputType = Smobiler.Core.TextBoxInputType.Number;
            this.txtworkday1.Location = new Smobiler.Core.PointS(35F, 34F);
            this.txtworkday1.Name = "txtworkday1";
            this.txtworkday1.Size = new System.Drawing.SizeF(85F, 14F);
            this.txtworkday1.TabIndex = 9;
            this.txtworkday1.WaterMarkText = "0.00";
            // 
            // txtworkday2
            // 
            this.txtworkday2.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.txtworkday2.BorderColor = System.Drawing.Color.DarkGray;
            this.txtworkday2.FontSize = 7F;
            this.txtworkday2.InputType = Smobiler.Core.TextBoxInputType.Number;
            this.txtworkday2.Location = new Smobiler.Core.PointS(35F, 34F);
            this.txtworkday2.Name = "txtworkday2";
            this.txtworkday2.Size = new System.Drawing.SizeF(85F, 14F);
            this.txtworkday2.TabIndex = 10;
            this.txtworkday2.Visible = false;
            this.txtworkday2.WaterMarkText = "0.00";
            // 
            // lblCDNO
            // 
            this.lblCDNO.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.lblCDNO.BorderColor = System.Drawing.Color.DarkGray;
            this.lblCDNO.ForeColor = System.Drawing.Color.Gray;
            this.lblCDNO.Location = new Smobiler.Core.PointS(0F, 48F);
            this.lblCDNO.Name = "lblCDNO";
            this.lblCDNO.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.lblCDNO.Size = new System.Drawing.SizeF(35F, 14F);
            this.lblCDNO.TabIndex = 11;
            this.lblCDNO.Text = "协同单编号";
            // 
            // txtCDNO
            // 
            this.txtCDNO.BorderColor = System.Drawing.Color.DarkGray;
            this.txtCDNO.FontSize = 7F;
            this.txtCDNO.Location = new Smobiler.Core.PointS(35F, 48F);
            this.txtCDNO.Name = "txtCDNO";
            this.txtCDNO.Size = new System.Drawing.SizeF(85F, 14F);
            this.txtCDNO.TabIndex = 12;
            this.txtCDNO.Visible = false;
            this.txtCDNO.WaterMarkText = "选填";
            // 
            // TxtNote
            // 
            this.TxtNote.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.TxtNote.BorderColor = System.Drawing.Color.DarkGray;
            this.TxtNote.FontSize = 7F;
            this.TxtNote.Location = new Smobiler.Core.PointS(35F, 65F);
            this.TxtNote.Multiline = true;
            this.TxtNote.Name = "TxtNote";
            this.TxtNote.Size = new System.Drawing.SizeF(85F, 40F);
            this.TxtNote.TabIndex = 13;
            this.TxtNote.WaterMarkText = "备注(选填)";
            // 
            // tExit
            // 
            this.tExit.IconID = "Exit";
            this.tExit.Name = "tExit";
            this.tExit.Text = "返回";
            // 
            // save
            // 
            this.save.IconID = "save";
            this.save.Name = "save";
            this.save.Text = "保存";
            // 
            // PopList1
            // 
            this.PopList1.Name = "PopList1";
            this.PopList1.Selected += new System.EventHandler(this.PopList1_Selected);
            // 
            // lblNote
            // 
            this.lblNote.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.lblNote.BorderColor = System.Drawing.Color.DarkGray;
            this.lblNote.ForeColor = System.Drawing.Color.Gray;
            this.lblNote.Location = new Smobiler.Core.PointS(0F, 65F);
            this.lblNote.Name = "lblNote";
            this.lblNote.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.lblNote.Size = new System.Drawing.SizeF(35F, 40F);
            this.lblNote.TabIndex = 15;
            this.lblNote.Text = "工单内容";
            // 
            // frmWorkDocumentCreate
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ComponentControls.AddRange(new Smobiler.Core.ComponentBase[] {
            this.PopList1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnCC,
            this.btnChoice,
            this.Label1,
            this.btntype,
            this.btntype2,
            this.lblworkday,
            this.txtworkday1,
            this.txtworkday2,
            this.lblCDNO,
            this.txtCDNO,
            this.TxtNote,
            this.lblNote});
            this.TitleBackColor = System.Drawing.Color.DeepSkyBlue;
            this.TitleText = "工作单创建";
            this.Toolbar.AddRange(new Smobiler.Core.Controls.ToolbarItem[] {
            this.tExit,
            this.save});
            this.Load += new System.EventHandler(this.frmWorkDocumentCreate_Load);
            this.ToolbarItemClick += new Smobiler.Core.ToolbarItemClickEventHandler(this.frmWorkDocumentCreate_ToolbarItemClick);

        }
        internal Smobiler.Core.Controls.Button btnCC;
        internal Smobiler.Core.Controls.Button btnChoice;
        internal Smobiler.Core.Controls.Label Label1;
        internal Smobiler.Core.Controls.Button btntype;
        internal Smobiler.Core.Controls.Button btntype2;
        internal Smobiler.Core.Controls.Label lblworkday;
        internal Smobiler.Core.Controls.TextBox txtworkday1;
        internal Smobiler.Core.Controls.TextBox txtworkday2;
        internal Smobiler.Core.Controls.Label lblCDNO;
        internal Smobiler.Core.Controls.TextBox txtCDNO;
        internal Smobiler.Core.Controls.TextBox TxtNote;
        internal Smobiler.Core.Controls.ToolbarItem tExit;
        internal Smobiler.Core.Controls.ToolbarItem save;
        internal Smobiler.Core.Controls.PopList PopList1;

        internal Smobiler.Core.Controls.Label lblNote;
        #endregion

    }
}