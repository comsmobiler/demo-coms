using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
namespace COMSSmobilerDemo
{  
    public partial class frmMainLeftLayout : Smobiler.Core.MobileForm
    {

        #region "SmobilerForm Designer generated code "

        public frmMainLeftLayout()
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
            this.lblUser = new Smobiler.Core.Controls.Label();
            this.btnMain = new Smobiler.Core.Controls.Button();
            this.imgbtnMain = new Smobiler.Core.Controls.ImageButton();
            this.imgbtnUserCC = new Smobiler.Core.Controls.ImageButton();
            this.btnUserCC = new Smobiler.Core.Controls.Button();
            this.imgUser = new Smobiler.Core.Controls.ImageButton();
            this.Label1 = new Smobiler.Core.Controls.Label();
            this.imgbtnUser = new Smobiler.Core.Controls.ImageButton();
            this.btnUser = new Smobiler.Core.Controls.Button();
            this.btnHelp = new Smobiler.Core.Controls.Button();
            this.imgbtnHelp = new Smobiler.Core.Controls.ImageButton();
            this.btnzb = new Smobiler.Core.Controls.Button();
            // 
            // lblUser
            // 
            this.lblUser.BackColor = System.Drawing.Color.DimGray;
            this.lblUser.BackColorAlpha = 0;
            this.lblUser.BorderColor = System.Drawing.Color.DarkGray;
            this.lblUser.FontSize = 10F;
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new Smobiler.Core.PointS(15F, 0F);
            this.lblUser.Name = "lblUser";
            this.lblUser.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.lblUser.Size = new System.Drawing.SizeF(75F, 17F);
            this.lblUser.TabIndex = 2;
            // 
            // btnMain
            // 
            this.btnMain.BackColorAlpha = 0;
            this.btnMain.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.btnMain.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMain.FontSize = 7F;
            this.btnMain.ForeColor = System.Drawing.Color.White;
            this.btnMain.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Left;
            this.btnMain.Location = new Smobiler.Core.PointS(15F, 22F);
            this.btnMain.Name = "btnMain";
            this.btnMain.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.btnMain.Size = new System.Drawing.SizeF(75F, 16F);
            this.btnMain.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btnMain.TabIndex = 3;
            this.btnMain.Text = "主页";
            // 
            // imgbtnMain
            // 
            this.imgbtnMain.BackColorAlpha = 0;
            this.imgbtnMain.BorderColor = System.Drawing.Color.DarkGray;
            this.imgbtnMain.FontSize = 4F;
            this.imgbtnMain.Location = new Smobiler.Core.PointS(2.5F, 25F);
            this.imgbtnMain.Name = "imgbtnMain";
            this.imgbtnMain.ResourceID = "index";
            this.imgbtnMain.Size = new System.Drawing.SizeF(10F, 10F);
            this.imgbtnMain.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.imgbtnMain.TabIndex = 4;
            // 
            // imgbtnUserCC
            // 
            this.imgbtnUserCC.BackColorAlpha = 0;
            this.imgbtnUserCC.BorderColor = System.Drawing.Color.DarkGray;
            this.imgbtnUserCC.FontSize = 4F;
            this.imgbtnUserCC.Location = new Smobiler.Core.PointS(2.5F, 41F);
            this.imgbtnUserCC.Name = "imgbtnUserCC";
            this.imgbtnUserCC.ResourceID = "gz";
            this.imgbtnUserCC.Size = new System.Drawing.SizeF(10F, 10F);
            this.imgbtnUserCC.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.imgbtnUserCC.TabIndex = 5;
            // 
            // btnUserCC
            // 
            this.btnUserCC.BackColorAlpha = 0;
            this.btnUserCC.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.btnUserCC.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUserCC.FontSize = 7F;
            this.btnUserCC.ForeColor = System.Drawing.Color.White;
            this.btnUserCC.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Left;
            this.btnUserCC.Location = new Smobiler.Core.PointS(15F, 38F);
            this.btnUserCC.Name = "btnUserCC";
            this.btnUserCC.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.btnUserCC.Size = new System.Drawing.SizeF(75F, 16F);
            this.btnUserCC.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btnUserCC.TabIndex = 6;
            this.btnUserCC.Text = "我关注的成本中心";
            // 
            // imgUser
            // 
            this.imgUser.BackColorAlpha = 0;
            this.imgUser.BorderColor = System.Drawing.Color.DarkGray;
            this.imgUser.FontSize = 4F;
            this.imgUser.Location = new Smobiler.Core.PointS(0F, 2F);
            this.imgUser.Name = "imgUser";
            this.imgUser.Size = new System.Drawing.SizeF(14F, 14F);
            this.imgUser.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.imgUser.TabIndex = 7;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(101)))), ((int)(((byte)(113)))));
            this.Label1.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label1.BorderColor = System.Drawing.Color.DarkGray;
            this.Label1.Location = new Smobiler.Core.PointS(0F, 17F);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.SizeF(90F, 5F);
            this.Label1.TabIndex = 8;
            // 
            // imgbtnUser
            // 
            this.imgbtnUser.BackColorAlpha = 0;
            this.imgbtnUser.BorderColor = System.Drawing.Color.DarkGray;
            this.imgbtnUser.FontSize = 4F;
            this.imgbtnUser.Location = new Smobiler.Core.PointS(2.5F, 57F);
            this.imgbtnUser.Name = "imgbtnUser";
            this.imgbtnUser.ResourceID = "shezhi";
            this.imgbtnUser.Size = new System.Drawing.SizeF(10F, 10F);
            this.imgbtnUser.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.imgbtnUser.TabIndex = 9;
            // 
            // btnUser
            // 
            this.btnUser.BackColorAlpha = 0;
            this.btnUser.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.btnUser.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUser.FontSize = 7F;
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Left;
            this.btnUser.Location = new Smobiler.Core.PointS(15F, 54F);
            this.btnUser.Name = "btnUser";
            this.btnUser.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.btnUser.Size = new System.Drawing.SizeF(75F, 16F);
            this.btnUser.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btnUser.TabIndex = 10;
            this.btnUser.Text = "用户设置";
            // 
            // btnHelp
            // 
            this.btnHelp.BackColorAlpha = 0;
            this.btnHelp.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.btnHelp.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHelp.FontSize = 7F;
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Left;
            this.btnHelp.Location = new Smobiler.Core.PointS(15F, 70F);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.btnHelp.Size = new System.Drawing.SizeF(75F, 16F);
            this.btnHelp.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btnHelp.TabIndex = 11;
            this.btnHelp.Text = "帮助";
            // 
            // imgbtnHelp
            // 
            this.imgbtnHelp.BackColorAlpha = 0;
            this.imgbtnHelp.BorderColor = System.Drawing.Color.DarkGray;
            this.imgbtnHelp.FontSize = 4F;
            this.imgbtnHelp.Location = new Smobiler.Core.PointS(2.5F, 73F);
            this.imgbtnHelp.Name = "imgbtnHelp";
            this.imgbtnHelp.ResourceID = "help";
            this.imgbtnHelp.Size = new System.Drawing.SizeF(10F, 10F);
            this.imgbtnHelp.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.imgbtnHelp.TabIndex = 12;
            // 
            // btnzb
            // 
            this.btnzb.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.btnzb.BorderColor = System.Drawing.Color.DarkGray;
            this.btnzb.FontSize = 7F;
            this.btnzb.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Left;
            this.btnzb.Location = new Smobiler.Core.PointS(15F, 103F);
            this.btnzb.Name = "btnzb";
            this.btnzb.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.btnzb.Size = new System.Drawing.SizeF(75F, 16F);
            this.btnzb.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btnzb.TabIndex = 14;
            this.btnzb.Text = "周报";
            // 
            // frmMainLeftLayout
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(37)))));
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblUser,
            this.btnMain,
            this.imgbtnMain,
            this.imgbtnUserCC,
            this.btnUserCC,
            this.imgUser,
            this.Label1,
            this.imgbtnUser,
            this.btnUser,
            this.btnHelp,
            this.imgbtnHelp});
            this.Size = new System.Drawing.Size(90, 200);

        }
        internal Smobiler.Core.Controls.Label lblUser;
        internal Smobiler.Core.Controls.Button btnMain;
        internal Smobiler.Core.Controls.ImageButton imgbtnMain;
        internal Smobiler.Core.Controls.ImageButton imgbtnUserCC;
        internal Smobiler.Core.Controls.Button btnUserCC;
        internal Smobiler.Core.Controls.ImageButton imgUser;
        internal Smobiler.Core.Controls.Label Label1;
        internal Smobiler.Core.Controls.ImageButton imgbtnUser;
        internal Smobiler.Core.Controls.Button btnUser;
        internal Smobiler.Core.Controls.Button btnHelp;
        internal Smobiler.Core.Controls.ImageButton imgbtnHelp;

        internal Smobiler.Core.Controls.Button btnzb;
        #endregion

    }


}