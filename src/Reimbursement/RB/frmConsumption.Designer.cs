using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
namespace COMSSmobilerDemo.Reimbursement.RB
{
    public partial class frmConsumption : Smobiler.Core.MobileForm
    {

        #region "SmobilerForm Designer generated code "

        public frmConsumption()
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
            this.txtMoney = new Smobiler.Core.Controls.TextBox();
            this.Label1 = new Smobiler.Core.Controls.Label();
            this.Label2 = new Smobiler.Core.Controls.Label();
            this.DatePicker = new Smobiler.Core.Controls.DatePicker();
            this.Label3 = new Smobiler.Core.Controls.Label();
            this.txtNote = new Smobiler.Core.Controls.TextBox();
            this.tExit = new Smobiler.Core.Controls.ToolbarItem();
            this.save = new Smobiler.Core.Controls.ToolbarItem();
            this.delete = new Smobiler.Core.Controls.ToolbarItem();
            this.Label4 = new Smobiler.Core.Controls.Label();
            this.Label5 = new Smobiler.Core.Controls.Label();
            this.btnRBType = new Smobiler.Core.Controls.Button();
            this.btnRBType1 = new Smobiler.Core.Controls.Button();
            // 
            // txtMoney
            // 
            this.txtMoney.BorderColor = System.Drawing.Color.DarkGray;
            this.txtMoney.FontSize = 7F;
            this.txtMoney.InputType = Smobiler.Core.TextBoxInputType.Number;
            this.txtMoney.Location = new Smobiler.Core.PointS(35F, 0F);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.SizeF(75F, 14F);
            this.txtMoney.TabIndex = 4;
            this.txtMoney.WaterMarkText = "0.00";
            // 
            // Label1
            // 
            this.Label1.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label1.BorderColor = System.Drawing.Color.DarkGray;
            this.Label1.ForeColor = System.Drawing.Color.Gray;
            this.Label1.Location = new Smobiler.Core.PointS(110F, 0F);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.SizeF(10F, 14F);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "（元）";
            // 
            // Label2
            // 
            this.Label2.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label2.BorderColor = System.Drawing.Color.DarkGray;
            this.Label2.ForeColor = System.Drawing.Color.Gray;
            this.Label2.Location = new Smobiler.Core.PointS(0F, 31F);
            this.Label2.Name = "Label2";
            this.Label2.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label2.Size = new System.Drawing.SizeF(35F, 14F);
            this.Label2.TabIndex = 7;
            this.Label2.Text = "消费日期";
            // 
            // DatePicker
            // 
            this.DatePicker.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.DatePicker.BorderColor = System.Drawing.Color.DarkGray;
            this.DatePicker.FontSize = 7F;
            this.DatePicker.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Left;
            this.DatePicker.Location = new Smobiler.Core.PointS(35F, 31F);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.SizeF(85F, 14F);
            this.DatePicker.TabIndex = 8;
            // 
            // Label3
            // 
            this.Label3.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label3.BorderColor = System.Drawing.Color.DarkGray;
            this.Label3.ForeColor = System.Drawing.Color.Gray;
            this.Label3.Location = new Smobiler.Core.PointS(0F, 48F);
            this.Label3.Name = "Label3";
            this.Label3.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label3.Size = new System.Drawing.SizeF(35F, 40F);
            this.Label3.TabIndex = 10;
            this.Label3.Text = "备注";
            // 
            // txtNote
            // 
            this.txtNote.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.txtNote.BorderColor = System.Drawing.Color.DarkGray;
            this.txtNote.FontSize = 7F;
            this.txtNote.Location = new Smobiler.Core.PointS(35F, 48F);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.SizeF(85F, 40F);
            this.txtNote.TabIndex = 12;
            this.txtNote.WaterMarkText = "请输入备注（必填）";
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
            // delete
            // 
            this.delete.IconID = "del";
            this.delete.Name = "delete";
            this.delete.Text = "删除";
            // 
            // Label4
            // 
            this.Label4.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label4.BorderColor = System.Drawing.Color.DarkGray;
            this.Label4.ForeColor = System.Drawing.Color.Gray;
            this.Label4.Name = "Label4";
            this.Label4.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label4.Size = new System.Drawing.SizeF(35F, 14F);
            this.Label4.TabIndex = 13;
            this.Label4.Text = "消费金额";
            // 
            // Label5
            // 
            this.Label5.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label5.BorderColor = System.Drawing.Color.DarkGray;
            this.Label5.ForeColor = System.Drawing.Color.Gray;
            this.Label5.Location = new Smobiler.Core.PointS(0F, 17F);
            this.Label5.Name = "Label5";
            this.Label5.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label5.Size = new System.Drawing.SizeF(35F, 14F);
            this.Label5.TabIndex = 14;
            this.Label5.Text = "消费类别";
            // 
            // btnRBType
            // 
            this.btnRBType.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.btnRBType.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRBType.FontSize = 7F;
            this.btnRBType.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Left;
            this.btnRBType.Location = new Smobiler.Core.PointS(35F, 17F);
            this.btnRBType.Name = "btnRBType";
            this.btnRBType.Size = new System.Drawing.SizeF(71F, 14F);
            this.btnRBType.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btnRBType.TabIndex = 15;
            this.btnRBType.Text = "请选择类别（必填）";
            this.btnRBType.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnRBType_Click);
            // 
            // btnRBType1
            // 
            this.btnRBType1.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.btnRBType1.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRBType1.FontSize = 8F;
            this.btnRBType1.ForeColor = System.Drawing.Color.Gray;
            this.btnRBType1.Location = new Smobiler.Core.PointS(106F, 17F);
            this.btnRBType1.Name = "btnRBType1";
            this.btnRBType1.Size = new System.Drawing.SizeF(14F, 14F);
            this.btnRBType1.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btnRBType1.TabIndex = 16;
            this.btnRBType1.Text = ">";
            this.btnRBType1.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnRBType_Click);
            // 
            // frmConsumption
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.txtMoney,
            this.Label1,
            this.Label2,
            this.DatePicker,
            this.Label3,
            this.txtNote,
            this.Label4,
            this.Label5,
            this.btnRBType,
            this.btnRBType1});
            this.TitleBackColor = System.Drawing.Color.DeepSkyBlue;
            this.TitleImage = "formimg";
            this.TitleText = "添加消费记录";
            this.Toolbar.AddRange(new Smobiler.Core.Controls.ToolbarItem[] {
            this.tExit,
            this.save,
            this.delete});
            this.Load += new System.EventHandler(this.frmConsumption_Load);
            this.ToolbarItemClick += new Smobiler.Core.ToolbarItemClickEventHandler(this.frmConsumption_ToolbarItemClick);

        }
        internal Smobiler.Core.Controls.TextBox txtMoney;
        internal Smobiler.Core.Controls.Label Label1;
        internal Smobiler.Core.Controls.Label Label2;
        internal Smobiler.Core.Controls.DatePicker DatePicker;
        internal Smobiler.Core.Controls.Label Label3;
        internal Smobiler.Core.Controls.TextBox txtNote;
        internal Smobiler.Core.Controls.ToolbarItem tExit;
        internal Smobiler.Core.Controls.ToolbarItem save;
        internal Smobiler.Core.Controls.ToolbarItem delete;
        internal Smobiler.Core.Controls.Label Label4;
        internal Smobiler.Core.Controls.Label Label5;
        internal Smobiler.Core.Controls.Button btnRBType;

        internal Smobiler.Core.Controls.Button btnRBType1;
        #endregion

    }
}