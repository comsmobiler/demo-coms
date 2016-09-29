
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
namespace COMSSmobilerDemo.Reimbursement.RB
{
    public partial class frmConsumptionMainRight : Smobiler.Core.MobileForm
    {

        #region "SmobilerForm Designer generated code "

        public frmConsumptionMainRight()
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
            this.btnALLtype = new Smobiler.Core.Controls.Button();
            this.btntotalAmount1 = new Smobiler.Core.Controls.Button();
            this.GridView1 = new Smobiler.Core.Controls.GridView();
            this.btnALLtype1 = new Smobiler.Core.Controls.Button();
            this.btntotalAmount = new Smobiler.Core.Controls.Button();
            // 
            // btnALLtype
            // 
            this.btnALLtype.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnALLtype.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.btnALLtype.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnALLtype.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnALLtype.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Left;
            this.btnALLtype.HoverBackColor = System.Drawing.Color.White;
            this.btnALLtype.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnALLtype.Name = "btnALLtype";
            this.btnALLtype.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.btnALLtype.Size = new System.Drawing.Size(60,28);
            this.btnALLtype.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btnALLtype.TabIndex = 2;
            this.btnALLtype.Text = "所有消费";
            this.btnALLtype.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnALLtype_Click);
            // 
            // btntotalAmount1
            // 
            this.btntotalAmount1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btntotalAmount1.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.btntotalAmount1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btntotalAmount1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btntotalAmount1.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Left;
            this.btntotalAmount1.HoverBackColor = System.Drawing.Color.White;
            this.btntotalAmount1.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btntotalAmount1.Location = new System.Drawing.Point(160,0);
            this.btntotalAmount1.Name = "btntotalAmount1";
            this.btntotalAmount1.Size = new System.Drawing.Size(80,28);
            this.btntotalAmount1.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btntotalAmount1.TabIndex = 6;
            this.btntotalAmount1.Text = "￥0.00";
            this.btntotalAmount1.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnALLtype_Click);
            // 
            // GridView1
            // 
            this.GridView1.Layout = "frmConsumptionRightLayout";
            this.GridView1.Location = new System.Drawing.Point(0,28);
            this.GridView1.Name = "GridView1";
            this.GridView1.ShowGridLines = false;
            this.GridView1.Size = new System.Drawing.Size(240,372);
            this.GridView1.TabIndex = 7;
            this.GridView1.ItemClick += new Smobiler.Core.Controls.GridViewItemClickEventHandler(this.GridView1_ItemClick);
            // 
            // btnALLtype1
            // 
            this.btnALLtype1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnALLtype1.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.btnALLtype1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnALLtype1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnALLtype1.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Left;
            this.btnALLtype1.HoverBackColor = System.Drawing.Color.White;
            this.btnALLtype1.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnALLtype1.Location = new System.Drawing.Point(60,0);
            this.btnALLtype1.Name = "btnALLtype1";
            this.btnALLtype1.Padding = new Smobiler.Core.Padding(0F, 0F, 2F, 0F);
            this.btnALLtype1.Size = new System.Drawing.Size(60,28);
            this.btnALLtype1.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btnALLtype1.TabIndex = 8;
            this.btnALLtype1.Text = "（0）";
            this.btnALLtype1.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnALLtype_Click);
            // 
            // btntotalAmount
            // 
            this.btntotalAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btntotalAmount.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.btntotalAmount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btntotalAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btntotalAmount.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btntotalAmount.HoverBackColor = System.Drawing.Color.White;
            this.btntotalAmount.HoverForeColor = System.Drawing.Color.White;
            this.btntotalAmount.Location = new System.Drawing.Point(120,0);
            this.btntotalAmount.Name = "btntotalAmount";
            this.btntotalAmount.Padding = new Smobiler.Core.Padding(0F, 0F, 2F, 0F);
            this.btntotalAmount.Size = new System.Drawing.Size(40,28);
            this.btntotalAmount.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btntotalAmount.TabIndex = 9;
            this.btntotalAmount.Text = "总计：";
            this.btntotalAmount.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnALLtype_Click);
            // 
            // frmConsumptionMainRight
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnALLtype,
            this.btntotalAmount1,
            this.GridView1,
            this.btnALLtype1,
            this.btntotalAmount});
            this.StatusBarStyle = Smobiler.Core.StatusBarStyle.Default;
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("Exit", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(50))))));
            this.TitleText = "消费筛选";
            this.Load += new System.EventHandler(this.frmRBMainRightLayout_Load);
            this.TitleImageClick += new System.EventHandler(this.MobileForm_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.MobileForm_KeyDown);

        }
        internal Smobiler.Core.Controls.Button btnALLtype;
        internal Smobiler.Core.Controls.Button btntotalAmount1;
        internal Smobiler.Core.Controls.GridView GridView1;
        internal Smobiler.Core.Controls.Button btnALLtype1;
        internal Smobiler.Core.Controls.Button btntotalAmount;
        #endregion

    }
}
