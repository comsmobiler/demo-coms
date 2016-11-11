using System;
using Smobiler.Core;
namespace COMSSmobilerDemo.Layout
{
    partial class frmJoinGUserFootbarLayout : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmJoinGUserFootbarLayout()
            : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();

            //Add any initialization after the InitializeComponent() call
        }

        //SmobilerForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm
        //It can be modified using the SmobilerForm.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.lblCheckall = new Smobiler.Core.Controls.Label();
            this.lblUserCount = new Smobiler.Core.Controls.Label();
            this.btnAddGroup = new Smobiler.Core.Controls.Button();
            this.Line1 = new Smobiler.Core.Controls.Line();
            // 
            // lblCheckall
            // 
            this.lblCheckall.FontSize = 12F;
            this.lblCheckall.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblCheckall.Location = new System.Drawing.Point(10, 0);
            this.lblCheckall.Name = "lblCheckall";
            this.lblCheckall.Size = new System.Drawing.Size(44, 35);
            this.lblCheckall.TabIndex = 2;
            this.lblCheckall.Text = "已选择";
            this.lblCheckall.ZIndex = 3;
            // 
            // lblUserCount
            // 
            this.lblUserCount.FontSize = 12F;
            this.lblUserCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.lblUserCount.Location = new System.Drawing.Point(54, 0);
            this.lblUserCount.Name = "lblUserCount";
            this.lblUserCount.Size = new System.Drawing.Size(44, 35);
            this.lblUserCount.TabIndex = 3;
            this.lblUserCount.Text = "0人";
            this.lblUserCount.ZIndex = 3;
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnAddGroup.BorderColor = System.Drawing.Color.White;
            this.btnAddGroup.BorderRadius = 2;
            this.btnAddGroup.ForeColor = System.Drawing.Color.White;
            this.btnAddGroup.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnAddGroup.HoverForeColor = System.Drawing.Color.White;
            this.btnAddGroup.Location = new System.Drawing.Point(232, 5);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Size = new System.Drawing.Size(55, 25);
            this.btnAddGroup.TabIndex = 4;
            this.btnAddGroup.Text = "确定";
            // 
            // Line1
            // 
            this.Line1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Line1.Location = new System.Drawing.Point(0, 35);
            this.Line1.Name = "Line1";
            this.Line1.Size = new System.Drawing.Size(300, 3);
            this.Line1.TabIndex = 5;
            this.Line1.ZIndex = 1;
            // 
            // frmJoinGUserFootbarLayout
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnAddGroup,
            this.lblCheckall,
            this.lblUserCount,
            this.Line1});
            this.Size = new System.Drawing.Size(300, 35);
            this.Name = "frmJoinGUserFootbarLayout";

        }
        #endregion

        internal Smobiler.Core.Controls.Label lblCheckall;
        internal Smobiler.Core.Controls.Label lblUserCount;
        internal Smobiler.Core.Controls.Button btnAddGroup;
        internal Smobiler.Core.Controls.Line Line1;
    }
}