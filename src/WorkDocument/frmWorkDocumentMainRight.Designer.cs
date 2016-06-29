using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
namespace COMSSmobilerDemo.WorkDocument
{
    public partial class frmWorkDocumentMainRight : Smobiler.Core.MobileForm
    {

        #region "SmobilerForm Designer generated code "

        public frmWorkDocumentMainRight()
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
            this.btnAllWorkD = new Smobiler.Core.Controls.Button();
            this.btntotalDay1 = new Smobiler.Core.Controls.Button();
            this.GridView1 = new Smobiler.Core.Controls.GridView();
            this.btnAllWorkD1 = new Smobiler.Core.Controls.Button();
            this.btntotalDay = new Smobiler.Core.Controls.Button();
            // 
            // btnAllWorkD
            // 
            this.btnAllWorkD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnAllWorkD.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.btnAllWorkD.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnAllWorkD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnAllWorkD.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Left;
            this.btnAllWorkD.HoverBackColor = System.Drawing.Color.White;
            this.btnAllWorkD.HoverForeColor = System.Drawing.Color.White;
            this.btnAllWorkD.Name = "btnAllWorkD";
            this.btnAllWorkD.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.btnAllWorkD.Size = new System.Drawing.SizeF(30F, 14F);
            this.btnAllWorkD.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btnAllWorkD.TabIndex = 3;
            this.btnAllWorkD.Text = "所有工单";
            this.btnAllWorkD.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btntotalDay_Click);
            // 
            // btntotalDay1
            // 
            this.btntotalDay1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btntotalDay1.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.btntotalDay1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btntotalDay1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btntotalDay1.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Left;
            this.btntotalDay1.HoverBackColor = System.Drawing.Color.White;
            this.btntotalDay1.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btntotalDay1.Location = new Smobiler.Core.PointS(80F, 0F);
            this.btntotalDay1.Name = "btntotalDay1";
            this.btntotalDay1.Size = new System.Drawing.SizeF(40F, 14F);
            this.btntotalDay1.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btntotalDay1.TabIndex = 4;
            this.btntotalDay1.Text = "0";
            this.btntotalDay1.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btntotalDay_Click);
            // 
            // GridView1
            // 
            this.GridView1.Layout = "frmWorkDocumentRightLayout";
            this.GridView1.Location = new Smobiler.Core.PointS(0F, 14F);
            this.GridView1.Name = "GridView1";
            this.GridView1.ShowGridLines = false;
            this.GridView1.Size = new System.Drawing.SizeF(120F, 186F);
            this.GridView1.TabIndex = 5;
            this.GridView1.ItemClick += new Smobiler.Core.Controls.GridViewItemClickEventHandler(this.GridView1_ItemClick);
            // 
            // btnAllWorkD1
            // 
            this.btnAllWorkD1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnAllWorkD1.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.btnAllWorkD1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnAllWorkD1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnAllWorkD1.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Left;
            this.btnAllWorkD1.HoverBackColor = System.Drawing.Color.White;
            this.btnAllWorkD1.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnAllWorkD1.Location = new Smobiler.Core.PointS(30F, 0F);
            this.btnAllWorkD1.Name = "btnAllWorkD1";
            this.btnAllWorkD1.Padding = new Smobiler.Core.Padding(0F, 0F, 2F, 0F);
            this.btnAllWorkD1.Size = new System.Drawing.SizeF(30F, 14F);
            this.btnAllWorkD1.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btnAllWorkD1.TabIndex = 6;
            this.btnAllWorkD1.Text = "（0）";
            this.btnAllWorkD1.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btntotalDay_Click);
            // 
            // btntotalDay
            // 
            this.btntotalDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btntotalDay.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.btntotalDay.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btntotalDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btntotalDay.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btntotalDay.HoverBackColor = System.Drawing.Color.White;
            this.btntotalDay.HoverForeColor = System.Drawing.Color.White;
            this.btntotalDay.Location = new Smobiler.Core.PointS(60F, 0F);
            this.btntotalDay.Name = "btntotalDay";
            this.btntotalDay.Padding = new Smobiler.Core.Padding(0F, 0F, 2F, 0F);
            this.btntotalDay.Size = new System.Drawing.SizeF(20F, 14F);
            this.btntotalDay.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btntotalDay.TabIndex = 7;
            this.btntotalDay.Text = "总计：";
            this.btntotalDay.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btntotalDay_Click);
            // 
            // frmWorkDocumentMainRight
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnAllWorkD,
            this.btntotalDay1,
            this.GridView1,
            this.btnAllWorkD1,
            this.btntotalDay});
            this.StatusBarStyle = Smobiler.Core.StatusBarStyle.Default;
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("Exit", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(50))))));
            this.TitleText = "工单筛选";
            this.ToolbarStyle = new Smobiler.Core.ToolBarSytle(Smobiler.Core.ToolbarSelectStyle.None, System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))), System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))));
            this.Load += new System.EventHandler(this.frmWorkDocumentMainRight_Load);
            this.TitleImageClick += new System.EventHandler(this.MobileForm_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.MobileForm_KeyDown);

        }
        internal Smobiler.Core.Controls.Button btnAllWorkD;
        internal Smobiler.Core.Controls.Button btntotalDay1;
        internal Smobiler.Core.Controls.GridView GridView1;
        internal Smobiler.Core.Controls.Button btnAllWorkD1;
        internal Smobiler.Core.Controls.Button btntotalDay;

        #endregion

    }
}