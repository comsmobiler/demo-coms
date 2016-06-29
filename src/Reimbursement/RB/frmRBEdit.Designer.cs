
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
namespace COMSSmobilerDemo.Reimbursement.RB
{
    public partial class frmRBEdit : Smobiler.Core.MobileForm
    {

        #region "SmobilerForm Designer generated code "

        public frmRBEdit()
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
            this.GridView1 = new Smobiler.Core.Controls.GridView();
            this.save = new Smobiler.Core.Controls.ToolbarItem();
            this.lblRBNO = new Smobiler.Core.Controls.Label();
            this.post = new Smobiler.Core.Controls.ToolbarItem();
            this.delete = new Smobiler.Core.Controls.ToolbarItem();
            this.Label1 = new Smobiler.Core.Controls.Label();
            this.lblNote = new Smobiler.Core.Controls.Label();
            this.Label4 = new Smobiler.Core.Controls.Label();
            this.lblRB_REASON1 = new Smobiler.Core.Controls.Label();
            this.txtRB_REASON = new Smobiler.Core.Controls.Label();
            // 
            // btnRBCC
            // 
            this.btnRBCC.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.btnRBCC.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnRBCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnRBCC.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnRBCC.Location = new Smobiler.Core.PointS(35F, 17F);
            this.btnRBCC.Name = "btnRBCC";
            this.btnRBCC.Padding = new Smobiler.Core.Padding(0F, 0F, 2F, 0F);
            this.btnRBCC.Size = new System.Drawing.SizeF(75F, 14F);
            this.btnRBCC.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btnRBCC.TabIndex = 2;
            this.btnRBCC.Text = "选择（必填）";
            this.btnRBCC.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnChioce_Click);
            // 
            // btnChoice
            // 
            this.btnChoice.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.btnChoice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnChoice.FontSize = 8F;
            this.btnChoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnChoice.HoverBackColor = System.Drawing.Color.White;
            this.btnChoice.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnChoice.Location = new Smobiler.Core.PointS(110F, 17F);
            this.btnChoice.Name = "btnChoice";
            this.btnChoice.Size = new System.Drawing.SizeF(10F, 14F);
            this.btnChoice.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btnChoice.TabIndex = 3;
            this.btnChoice.Text = ">";
            this.btnChoice.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnChioce_Click);
            // 
            // TxtNote
            // 
            this.TxtNote.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.TxtNote.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.TxtNote.FontSize = 7F;
            this.TxtNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.TxtNote.Location = new Smobiler.Core.PointS(35F, 34F);
            this.TxtNote.Multiline = true;
            this.TxtNote.Name = "TxtNote";
            this.TxtNote.Padding = new Smobiler.Core.Padding(0F, 5F, 12F, 0F);
            this.TxtNote.Size = new System.Drawing.SizeF(85F, 40F);
            this.TxtNote.TabIndex = 4;
            this.TxtNote.WaterMarkText = "（选填）";
            // 
            // GridView1
            // 
            this.GridView1.Border = new Smobiler.Core.Border(0, 1, 0, 0);
            this.GridView1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.GridView1.Layout = "frmConsumption1Layout";
            this.GridView1.Location = new Smobiler.Core.PointS(0F, 120F);
            this.GridView1.Name = "GridView1";
            this.GridView1.ShowGridLines = false;
            this.GridView1.Size = new System.Drawing.SizeF(120F, 80F);
            this.GridView1.TabIndex = 7;
            this.GridView1.ItemClick += new Smobiler.Core.Controls.GridViewItemClickEventHandler(this.GridView1_ItemClick);
            // 
            // save
            // 
            this.save.IconID = "!\\ue161043146223";
            this.save.Name = "save";
            this.save.Text = "保存";
            // 
            // lblRBNO
            // 
            this.lblRBNO.Bold = true;
            this.lblRBNO.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.lblRBNO.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblRBNO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.lblRBNO.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblRBNO.Location = new Smobiler.Core.PointS(35F, 0F);
            this.lblRBNO.Name = "lblRBNO";
            this.lblRBNO.Padding = new Smobiler.Core.Padding(0F, 0F, 12F, 0F);
            this.lblRBNO.Size = new System.Drawing.SizeF(85F, 14F);
            this.lblRBNO.TabIndex = 8;
            // 
            // post
            // 
            this.post.IconID = "!\\ue876043146223";
            this.post.Name = "post";
            this.post.Text = "送审";
            // 
            // delete
            // 
            this.delete.IconID = "!\\ue888043146223";
            this.delete.Name = "delete";
            this.delete.Text = "删除";
            // 
            // Label1
            // 
            this.Label1.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label1.Name = "Label1";
            this.Label1.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label1.Size = new System.Drawing.SizeF(35F, 14F);
            this.Label1.TabIndex = 12;
            this.Label1.Text = "报销编号";
            // 
            // lblNote
            // 
            this.lblNote.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.lblNote.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblNote.Location = new Smobiler.Core.PointS(0F, 34F);
            this.lblNote.Name = "lblNote";
            this.lblNote.Padding = new Smobiler.Core.Padding(2F, 5F, 0F, 0F);
            this.lblNote.Size = new System.Drawing.SizeF(35F, 40F);
            this.lblNote.TabIndex = 13;
            this.lblNote.Text = "报销备注";
            this.lblNote.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            // 
            // Label4
            // 
            this.Label4.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label4.Location = new Smobiler.Core.PointS(0F, 17F);
            this.Label4.Name = "Label4";
            this.Label4.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label4.Size = new System.Drawing.SizeF(35F, 14F);
            this.Label4.TabIndex = 14;
            this.Label4.Text = "成本中心";
            // 
            // lblRB_REASON1
            // 
            this.lblRB_REASON1.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.lblRB_REASON1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblRB_REASON1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblRB_REASON1.Location = new Smobiler.Core.PointS(0F, 77F);
            this.lblRB_REASON1.Name = "lblRB_REASON1";
            this.lblRB_REASON1.Padding = new Smobiler.Core.Padding(2F, 5F, 0F, 0F);
            this.lblRB_REASON1.Size = new System.Drawing.SizeF(35F, 40F);
            this.lblRB_REASON1.TabIndex = 15;
            this.lblRB_REASON1.Text = "拒绝理由";
            this.lblRB_REASON1.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            // 
            // txtRB_REASON
            // 
            this.txtRB_REASON.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.txtRB_REASON.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtRB_REASON.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.txtRB_REASON.Location = new Smobiler.Core.PointS(35F, 77F);
            this.txtRB_REASON.Name = "txtRB_REASON";
            this.txtRB_REASON.Padding = new Smobiler.Core.Padding(0F, 5F, 12F, 0F);
            this.txtRB_REASON.Size = new System.Drawing.SizeF(85F, 40F);
            this.txtRB_REASON.TabIndex = 16;
            // 
            // frmRBEdit
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnRBCC,
            this.btnChoice,
            this.TxtNote,
            this.GridView1,
            this.lblRBNO,
            this.Label1,
            this.lblNote,
            this.Label4,
            this.lblRB_REASON1,
            this.txtRB_REASON});
            this.FooterBarLayout = "frmRBFootbarLayout";
            this.ForeColor = System.Drawing.Color.White;
            this.StatusBarStyle = Smobiler.Core.StatusBarStyle.Default;
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("Exit", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(50))))));
            this.TitleText = "报销编辑";
            this.Toolbar.AddRange(new Smobiler.Core.Controls.ToolbarItem[] {
            this.save,
            this.post,
            this.delete});
            this.ToolbarStyle = new Smobiler.Core.ToolBarSytle(Smobiler.Core.ToolbarSelectStyle.None, System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))), System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))));
            this.FooterBarLayoutItemClick += new Smobiler.Core.MobileFormLayoutItemClickEventHandler(this.frmRBEdit_FooterBarLayoutItemClick);
            this.Load += new System.EventHandler(this.frmRBEdit_Load);
            this.ToolbarItemClick += new Smobiler.Core.ToolbarItemClickEventHandler(this.frmRBEdit_ToolbarItemClick);
            this.TitleImageClick += new System.EventHandler(this.MobileForm_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.MobileForm_KeyDown);

        }
        internal Smobiler.Core.Controls.Button btnRBCC;
        internal Smobiler.Core.Controls.Button btnChoice;
        internal Smobiler.Core.Controls.TextBox TxtNote;
        internal Smobiler.Core.Controls.GridView GridView1;
        internal Smobiler.Core.Controls.ToolbarItem save;
        internal Smobiler.Core.Controls.Label lblRBNO;
        internal Smobiler.Core.Controls.ToolbarItem post;
        internal Smobiler.Core.Controls.ToolbarItem delete;
        internal Smobiler.Core.Controls.Label Label1;
        internal Smobiler.Core.Controls.Label lblNote;
        internal Smobiler.Core.Controls.Label Label4;
        internal Smobiler.Core.Controls.Label lblRB_REASON1;
        internal Smobiler.Core.Controls.Label txtRB_REASON;
        #endregion

    }
}