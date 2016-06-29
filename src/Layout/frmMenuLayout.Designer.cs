using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
namespace COMSSmobilerDemo
{  
    public partial class frmMenuLayout : Smobiler.Core.MobileForm
    {

        #region "SmobilerForm Designer generated code "

        public frmMenuLayout()
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
            this.btnExit = new Smobiler.Core.Controls.Button();
            this.labUserIDData = new Smobiler.Core.Controls.Label();
            this.imguser = new Smobiler.Core.Controls.Image();
            this.labUserNameData = new Smobiler.Core.Controls.Label();
            this.btninfo = new Smobiler.Core.Controls.Button();
            this.imgadreass = new Smobiler.Core.Controls.Image();
            this.lblAddress = new Smobiler.Core.Controls.Label();
            this.btnbz = new Smobiler.Core.Controls.Button();
            this.imgindex = new Smobiler.Core.Controls.ImageButton();
            this.imginfo = new Smobiler.Core.Controls.ImageButton();
            this.imgbz = new Smobiler.Core.Controls.ImageButton();
            this.imgtc = new Smobiler.Core.Controls.ImageButton();
            this.btnindex = new Smobiler.Core.Controls.Button();
            this.imgtz = new Smobiler.Core.Controls.ImageButton();
            this.btntz = new Smobiler.Core.Controls.Button();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.btnExit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.btnExit.FontSize = 7F;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Left;
            this.btnExit.Location = new Smobiler.Core.PointS(20F, 175F);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.btnExit.Size = new System.Drawing.SizeF(76F, 20F);
            this.btnExit.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "退出";
            // 
            // labUserIDData
            // 
            this.labUserIDData.BackColorAlpha = 0;
            this.labUserIDData.FontSize = 10F;
            this.labUserIDData.ForeColor = System.Drawing.Color.White;
            this.labUserIDData.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.labUserIDData.Location = new Smobiler.Core.PointS(20F, 55F);
            this.labUserIDData.Name = "labUserIDData";
            this.labUserIDData.Size = new System.Drawing.SizeF(60F, 10F);
            this.labUserIDData.TabIndex = 7;
            this.labUserIDData.Text = "Lincy";
            this.labUserIDData.ZIndex = 2;
            // 
            // imguser
            // 
            this.imguser.BackColorAlpha = 0;
            this.imguser.BorderColor = System.Drawing.Color.White;
            this.imguser.BorderRadius = 10;
            this.imguser.Location = new Smobiler.Core.PointS(32.5F, 15F);
            this.imguser.Name = "imguser";
            this.imguser.ResourceID = "lincy";
            this.imguser.Size = new System.Drawing.SizeF(35F, 35F);
            this.imguser.SizeMode = Smobiler.Core.ImageSizeMode.StretchImage;
            this.imguser.TabIndex = 8;
            this.imguser.ZIndex = 1;
            // 
            // labUserNameData
            // 
            this.labUserNameData.BackColorAlpha = 0;
            this.labUserNameData.FontSize = 8F;
            this.labUserNameData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.labUserNameData.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.labUserNameData.Location = new Smobiler.Core.PointS(20F, 65F);
            this.labUserNameData.Name = "labUserNameData";
            this.labUserNameData.Size = new System.Drawing.SizeF(60F, 12F);
            this.labUserNameData.TabIndex = 9;
            this.labUserNameData.Text = "皮卡丘";
            this.labUserNameData.ZIndex = 3;
            // 
            // btninfo
            // 
            this.btninfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.btninfo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.btninfo.FontSize = 7F;
            this.btninfo.ForeColor = System.Drawing.Color.White;
            this.btninfo.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Left;
            this.btninfo.Location = new Smobiler.Core.PointS(20F, 115F);
            this.btninfo.Name = "btninfo";
            this.btninfo.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.btninfo.Size = new System.Drawing.SizeF(76F, 20F);
            this.btninfo.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btninfo.TabIndex = 10;
            this.btninfo.Text = "基本信息";
            // 
            // imgadreass
            // 
            this.imgadreass.BackColorAlpha = 0;
            this.imgadreass.Location = new Smobiler.Core.PointS(0F, 82F);
            this.imgadreass.Name = "imgadreass";
            this.imgadreass.Padding = new Smobiler.Core.Padding(0F, 2F, 0F, 2F);
            this.imgadreass.ResourceID = "!\\ue55f255255255";
            this.imgadreass.Size = new System.Drawing.SizeF(20F, 13F);
            this.imgadreass.TabIndex = 11;
            // 
            // lblAddress
            // 
            this.lblAddress.BackColorAlpha = 0;
            this.lblAddress.BorderColor = System.Drawing.Color.White;
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(174)))), ((int)(((byte)(216)))));
            this.lblAddress.Location = new Smobiler.Core.PointS(20F, 82F);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Padding = new Smobiler.Core.Padding(2F, 0F, 2F, 0F);
            this.lblAddress.Size = new System.Drawing.SizeF(76F, 13F);
            this.lblAddress.TabIndex = 12;
            this.lblAddress.Text = "正在定位...";
            // 
            // btnbz
            // 
            this.btnbz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.btnbz.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.btnbz.FontSize = 7F;
            this.btnbz.ForeColor = System.Drawing.Color.White;
            this.btnbz.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Left;
            this.btnbz.Location = new Smobiler.Core.PointS(20F, 155F);
            this.btnbz.Name = "btnbz";
            this.btnbz.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.btnbz.Size = new System.Drawing.SizeF(76F, 20F);
            this.btnbz.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btnbz.TabIndex = 13;
            this.btnbz.Text = "帮助";
            // 
            // imgindex
            // 
            this.imgindex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(128)))), ((int)(((byte)(172)))));
            this.imgindex.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.imgindex.FontSize = 8F;
            this.imgindex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.imgindex.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Left;
            this.imgindex.Location = new Smobiler.Core.PointS(0F, 95F);
            this.imgindex.Name = "imgindex";
            this.imgindex.Padding = new Smobiler.Core.Padding(4F, 5F, 4F, 3F);
            this.imgindex.ResourceID = "!\\ue88a255255255";
            this.imgindex.Size = new System.Drawing.SizeF(20F, 20F);
            this.imgindex.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.imgindex.TabIndex = 15;
            // 
            // imginfo
            // 
            this.imginfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.imginfo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.imginfo.FontSize = 4F;
            this.imginfo.Location = new Smobiler.Core.PointS(0F, 115F);
            this.imginfo.Name = "imginfo";
            this.imginfo.Padding = new Smobiler.Core.Padding(4F, 5F, 4F, 3F);
            this.imginfo.ResourceID = "!\\ue001255255255";
            this.imginfo.Size = new System.Drawing.SizeF(20F, 20F);
            this.imginfo.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.imginfo.TabIndex = 16;
            // 
            // imgbz
            // 
            this.imgbz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.imgbz.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.imgbz.FontSize = 4F;
            this.imgbz.Location = new Smobiler.Core.PointS(0F, 155F);
            this.imgbz.Name = "imgbz";
            this.imgbz.Padding = new Smobiler.Core.Padding(4F, 5F, 4F, 3F);
            this.imgbz.ResourceID = "!\\ue8fd255255255";
            this.imgbz.Size = new System.Drawing.SizeF(20F, 20F);
            this.imgbz.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.imgbz.TabIndex = 18;
            // 
            // imgtc
            // 
            this.imgtc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.imgtc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.imgtc.FontSize = 4F;
            this.imgtc.Location = new Smobiler.Core.PointS(0F, 175F);
            this.imgtc.Name = "imgtc";
            this.imgtc.Padding = new Smobiler.Core.Padding(4F, 5F, 4F, 3F);
            this.imgtc.ResourceID = "!\\ue8ac255255255";
            this.imgtc.Size = new System.Drawing.SizeF(20F, 20F);
            this.imgtc.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.imgtc.TabIndex = 19;
            // 
            // btnindex
            // 
            this.btnindex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(128)))), ((int)(((byte)(172)))));
            this.btnindex.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.btnindex.FontSize = 7F;
            this.btnindex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.btnindex.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Left;
            this.btnindex.Location = new Smobiler.Core.PointS(20F, 95F);
            this.btnindex.Name = "btnindex";
            this.btnindex.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.btnindex.Size = new System.Drawing.SizeF(76F, 20F);
            this.btnindex.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btnindex.TabIndex = 21;
            this.btnindex.Text = "首页";
            // 
            // imgtz
            // 
            this.imgtz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.imgtz.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.imgtz.FontSize = 4F;
            this.imgtz.Location = new Smobiler.Core.PointS(0F, 135F);
            this.imgtz.Name = "imgtz";
            this.imgtz.Padding = new Smobiler.Core.Padding(4F, 5F, 4F, 3F);
            this.imgtz.ResourceID = "!\\ue0e1255255255";
            this.imgtz.Size = new System.Drawing.SizeF(20F, 20F);
            this.imgtz.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.imgtz.TabIndex = 22;
            // 
            // btntz
            // 
            this.btntz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.btntz.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.btntz.FontSize = 7F;
            this.btntz.ForeColor = System.Drawing.Color.White;
            this.btntz.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Left;
            this.btntz.Location = new Smobiler.Core.PointS(20F, 135F);
            this.btntz.Name = "btntz";
            this.btntz.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.btntz.Size = new System.Drawing.SizeF(76F, 20F);
            this.btntz.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btntz.TabIndex = 23;
            this.btntz.Text = "消息";
            // 
            // frmMenuLayout
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.BackGroundImage = "leftFrom";
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnExit,
            this.btninfo,
            this.imgadreass,
            this.lblAddress,
            this.btnbz,
            this.imgindex,
            this.imginfo,
            this.imgbz,
            this.imgtc,
            this.btnindex,
            this.imgtz,
            this.btntz,
            this.imguser,
            this.labUserIDData,
            this.labUserNameData});
            this.Size = new System.Drawing.Size(120, 195);

        }
        internal Smobiler.Core.Controls.Button btnExit;
        internal Smobiler.Core.Controls.Label labUserIDData;
        internal Smobiler.Core.Controls.Image imguser;
        internal Smobiler.Core.Controls.Label labUserNameData;
        internal Smobiler.Core.Controls.Button btninfo;
        internal Smobiler.Core.Controls.Image imgadreass;
        internal Smobiler.Core.Controls.Label lblAddress;
        internal Smobiler.Core.Controls.Button btnbz;
        internal Smobiler.Core.Controls.ImageButton imgindex;
        internal Smobiler.Core.Controls.ImageButton imginfo;
        internal Smobiler.Core.Controls.ImageButton imgbz;
        internal Smobiler.Core.Controls.ImageButton imgtc;
        internal Smobiler.Core.Controls.Button btnindex;
        internal Smobiler.Core.Controls.ImageButton imgtz;
        internal Smobiler.Core.Controls.Button btntz;
        #endregion


    }


}