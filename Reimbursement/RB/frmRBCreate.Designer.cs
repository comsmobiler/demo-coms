
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
namespace COMSSmobilerDemo.Reimbursement.RB
{
    public partial class frmRBCreate : Smobiler.Core.MobileForm
    {

        #region "SmobilerForm Designer generated code "

        public frmRBCreate()
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
            this.btnRBCC = new Smobiler.Core.Controls.Button();
            this.btnChoice = new Smobiler.Core.Controls.Button();
            this.TxtNote = new Smobiler.Core.Controls.TextBox();
            this.lblAmount = new Smobiler.Core.Controls.Label();
            this.GridView1 = new Smobiler.Core.Controls.GridView();
            this.tExit = new Smobiler.Core.Controls.ToolbarItem();
            this.save = new Smobiler.Core.Controls.ToolbarItem();
            this.btnCheckall = new Smobiler.Core.Controls.Button();
            this.Checkall = new Smobiler.Core.Controls.CheckBox();
            this.lblNote = new Smobiler.Core.Controls.Label();
            // 
            // btnRBCC
            // 
            this.btnRBCC.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.btnRBCC.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRBCC.FontSize = 7F;
            this.btnRBCC.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Left;
            this.btnRBCC.Name = "btnRBCC";
            this.btnRBCC.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.btnRBCC.Size = new System.Drawing.SizeF(107F, 14F);
            this.btnRBCC.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btnRBCC.TabIndex = 2;
            this.btnRBCC.Text = "成本中心选择(必填)";
            this.btnRBCC.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnChioce_Click);
            // 
            // btnChoice
            // 
            this.btnChoice.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.btnChoice.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChoice.FontSize = 8F;
            this.btnChoice.ForeColor = System.Drawing.Color.Gray;
            this.btnChoice.Location = new Smobiler.Core.PointS(107F, 0F);
            this.btnChoice.Name = "btnChoice";
            this.btnChoice.Size = new System.Drawing.SizeF(13F, 14F);
            this.btnChoice.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btnChoice.TabIndex = 3;
            this.btnChoice.Text = ">";
            this.btnChoice.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnChioce_Click);
            // 
            // TxtNote
            // 
            this.TxtNote.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.TxtNote.BorderColor = System.Drawing.Color.Silver;
            this.TxtNote.FontSize = 7F;
            this.TxtNote.Location = new Smobiler.Core.PointS(35F, 17F);
            this.TxtNote.Multiline = true;
            this.TxtNote.Name = "TxtNote";
            this.TxtNote.Size = new System.Drawing.SizeF(85F, 40F);
            this.TxtNote.TabIndex = 4;
            this.TxtNote.WaterMarkText = "请输入备注(选填)";
            // 
            // lblAmount
            // 
            this.lblAmount.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblAmount.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.lblAmount.BorderColor = System.Drawing.Color.White;
            this.lblAmount.FontSize = 9F;
            this.lblAmount.ForeColor = System.Drawing.Color.White;
            this.lblAmount.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.lblAmount.Location = new Smobiler.Core.PointS(0F, 60F);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.SizeF(120F, 14F);
            this.lblAmount.TabIndex = 5;
            this.lblAmount.Text = "￥0.0";
            // 
            // GridView1
            // 
            this.GridView1.Border = new Smobiler.Core.Border(0, 1, 0, 0);
            this.GridView1.BorderColor = System.Drawing.Color.DarkGray;
            this.GridView1.Layout = "frmConsumption1Layout";
            this.GridView1.Location = new Smobiler.Core.PointS(0F, 86F);
            this.GridView1.Name = "GridView1";
            this.GridView1.ShowGridLines = false;
            this.GridView1.Size = new System.Drawing.SizeF(120F, 115F);
            this.GridView1.TabIndex = 7;
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
            // btnCheckall
            // 
            this.btnCheckall.BackColor = System.Drawing.Color.DimGray;
            this.btnCheckall.BackColorAlpha = 0;
            this.btnCheckall.FontSize = 8F;
            this.btnCheckall.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCheckall.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnCheckall.Location = new Smobiler.Core.PointS(0F, 74F);
            this.btnCheckall.Name = "btnCheckall";
            this.btnCheckall.Padding = new Smobiler.Core.Padding(0F, 0F, 16F, 0F);
            this.btnCheckall.Size = new System.Drawing.SizeF(120F, 12F);
            this.btnCheckall.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btnCheckall.TabIndex = 8;
            this.btnCheckall.Text = "全选";
            this.btnCheckall.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnCheckall_Click);
            // 
            // Checkall
            // 
            this.Checkall.BackColor = System.Drawing.Color.White;
            this.Checkall.Border = new Smobiler.Core.Border(1);
            this.Checkall.BorderColor = System.Drawing.Color.DarkGray;
            this.Checkall.BorderRadius = 4;
            this.Checkall.Checked = false;
            this.Checkall.CheckedBackColor = System.Drawing.Color.White;
            this.Checkall.CheckedColor = System.Drawing.Color.DeepSkyBlue;
            this.Checkall.Location = new Smobiler.Core.PointS(108F, 75F);
            this.Checkall.Name = "Checkall";
            this.Checkall.Size = new System.Drawing.SizeF(10F, 10F);
            this.Checkall.TabIndex = 9;
            this.Checkall.UnCheckedBackColor = System.Drawing.Color.White;
            this.Checkall.CheckChanged += new Smobiler.Core.Controls.CheckdControlBase.CheckChangedEventHandler(this.Checkall_CheckChanged);
            // 
            // lblNote
            // 
            this.lblNote.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.lblNote.BorderColor = System.Drawing.Color.DarkGray;
            this.lblNote.ForeColor = System.Drawing.Color.Gray;
            this.lblNote.Location = new Smobiler.Core.PointS(0F, 17F);
            this.lblNote.Name = "lblNote";
            this.lblNote.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.lblNote.Size = new System.Drawing.SizeF(35F, 40F);
            this.lblNote.TabIndex = 11;
            this.lblNote.Text = "报销备注";
            // 
            // frmRBCreate
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnRBCC,
            this.btnChoice,
            this.TxtNote,
            this.lblAmount,
            this.GridView1,
            this.btnCheckall,
            this.Checkall,
            this.lblNote});
            this.ForeColor = System.Drawing.Color.White;
            this.TitleBackColor = System.Drawing.Color.DeepSkyBlue;
            this.TitleImage = "formimg";
            this.TitleText = "报销单创建";
            this.Toolbar.AddRange(new Smobiler.Core.Controls.ToolbarItem[] {
            this.tExit,
            this.save});
            this.Load += new System.EventHandler(this.frmRBCreate_Load);
            this.ToolbarItemClick += new Smobiler.Core.ToolbarItemClickEventHandler(this.frmRBCreate_ToolbarItemClick);

        }
        internal Smobiler.Core.Controls.Button btnRBCC;
        internal Smobiler.Core.Controls.Button btnChoice;
        internal Smobiler.Core.Controls.TextBox TxtNote;
        internal Smobiler.Core.Controls.Label lblAmount;
        internal Smobiler.Core.Controls.GridView GridView1;
        internal Smobiler.Core.Controls.ToolbarItem tExit;
        internal Smobiler.Core.Controls.ToolbarItem save;
        internal Smobiler.Core.Controls.Button btnCheckall;
        internal Smobiler.Core.Controls.CheckBox Checkall;

        internal Smobiler.Core.Controls.Label lblNote;
        #endregion

    }
}