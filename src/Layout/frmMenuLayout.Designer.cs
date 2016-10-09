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
            this.btnExit.FontSize = 18F;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Left;
            this.btnExit.Location = new System.Drawing.Point(50, 438);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new Smobiler.Core.Padding(5F, 0F, 0F, 0F);
            this.btnExit.Size = new System.Drawing.Size(190, 50);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "退出";
            // 
            // labUserIDData
            // 
            this.labUserIDData.BackColorAlpha = 0;
            this.labUserIDData.FontSize = 25F;
            this.labUserIDData.ForeColor = System.Drawing.Color.White;
            this.labUserIDData.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.labUserIDData.Location = new System.Drawing.Point(50, 138);
            this.labUserIDData.Name = "labUserIDData";
            this.labUserIDData.Size = new System.Drawing.Size(150, 25);
            this.labUserIDData.TabIndex = 7;
            this.labUserIDData.Text = "Lincy";
            this.labUserIDData.ZIndex = 2;
            // 
            // imguser
            // 
            this.imguser.BackColorAlpha = 0;
            this.imguser.BorderColor = System.Drawing.Color.White;
            this.imguser.BorderRadius = 10;
            this.imguser.ID = "lincy";
            this.imguser.Location = new System.Drawing.Point(82, 38);
            this.imguser.Name = "imguser";
            this.imguser.ResourceID = "lincy";
            this.imguser.Size = new System.Drawing.Size(88, 88);
            this.imguser.SizeMode = Smobiler.Core.ImageSizeMode.StretchImage;
            this.imguser.TabIndex = 8;
            this.imguser.ZIndex = 1;
            // 
            // labUserNameData
            // 
            this.labUserNameData.BackColorAlpha = 0;
            this.labUserNameData.FontSize = 20F;
            this.labUserNameData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.labUserNameData.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.labUserNameData.Location = new System.Drawing.Point(50, 163);
            this.labUserNameData.Name = "labUserNameData";
            this.labUserNameData.Size = new System.Drawing.Size(150, 30);
            this.labUserNameData.TabIndex = 9;
            this.labUserNameData.Text = "皮卡丘";
            this.labUserNameData.ZIndex = 3;
            // 
            // btninfo
            // 
            this.btninfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.btninfo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.btninfo.FontSize = 18F;
            this.btninfo.ForeColor = System.Drawing.Color.White;
            this.btninfo.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Left;
            this.btninfo.Location = new System.Drawing.Point(50, 288);
            this.btninfo.Name = "btninfo";
            this.btninfo.Padding = new Smobiler.Core.Padding(5F, 0F, 0F, 0F);
            this.btninfo.Size = new System.Drawing.Size(190, 50);
            this.btninfo.TabIndex = 10;
            this.btninfo.Text = "基本信息";
            // 
            // imgadreass
            // 
            this.imgadreass.BackColorAlpha = 0;
            this.imgadreass.ID = "!\\ue55f255255255";
            this.imgadreass.Location = new System.Drawing.Point(0, 205);
            this.imgadreass.Name = "imgadreass";
            this.imgadreass.Padding = new Smobiler.Core.Padding(0F, 5F, 0F, 5F);
            this.imgadreass.ResourceID = "!\\ue55f255255255";
            this.imgadreass.Size = new System.Drawing.Size(50, 33);
            this.imgadreass.TabIndex = 11;
            // 
            // lblAddress
            // 
            this.lblAddress.BackColorAlpha = 0;
            this.lblAddress.BorderColor = System.Drawing.Color.White;
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(174)))), ((int)(((byte)(216)))));
            this.lblAddress.Location = new System.Drawing.Point(50, 205);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Padding = new Smobiler.Core.Padding(5F, 0F, 2F, 0F);
            this.lblAddress.Size = new System.Drawing.Size(190, 33);
            this.lblAddress.TabIndex = 12;
            this.lblAddress.Text = "正在定位...";
            // 
            // btnbz
            // 
            this.btnbz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.btnbz.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.btnbz.FontSize = 18F;
            this.btnbz.ForeColor = System.Drawing.Color.White;
            this.btnbz.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Left;
            this.btnbz.Location = new System.Drawing.Point(50, 388);
            this.btnbz.Name = "btnbz";
            this.btnbz.Padding = new Smobiler.Core.Padding(5F, 0F, 0F, 0F);
            this.btnbz.Size = new System.Drawing.Size(190, 50);
            this.btnbz.TabIndex = 13;
            this.btnbz.Text = "帮助";
            // 
            // imgindex
            // 
            this.imgindex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(128)))), ((int)(((byte)(172)))));
            this.imgindex.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.imgindex.FontSize = 20F;
            this.imgindex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.imgindex.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Left;
            this.imgindex.Location = new System.Drawing.Point(0, 238);
            this.imgindex.Name = "imgindex";
            this.imgindex.Padding = new Smobiler.Core.Padding(10F, 12F, 10F, 12F);
            this.imgindex.ResourceID = "!\\ue88a255255255";
            this.imgindex.Size = new System.Drawing.Size(50, 50);
            this.imgindex.TabIndex = 15;
            // 
            // imginfo
            // 
            this.imginfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.imginfo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.imginfo.FontSize = 10F;
            this.imginfo.Location = new System.Drawing.Point(0, 288);
            this.imginfo.Name = "imginfo";
            this.imginfo.Padding = new Smobiler.Core.Padding(10F, 12F, 10F, 12F);
            this.imginfo.ResourceID = "!\\ue001255255255";
            this.imginfo.Size = new System.Drawing.Size(50, 50);
            this.imginfo.TabIndex = 16;
            // 
            // imgbz
            // 
            this.imgbz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.imgbz.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.imgbz.FontSize = 10F;
            this.imgbz.Location = new System.Drawing.Point(0, 388);
            this.imgbz.Name = "imgbz";
            this.imgbz.Padding = new Smobiler.Core.Padding(10F, 12F, 10F, 12F);
            this.imgbz.ResourceID = "!\\ue8fd255255255";
            this.imgbz.Size = new System.Drawing.Size(50, 50);
            this.imgbz.TabIndex = 18;
            // 
            // imgtc
            // 
            this.imgtc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.imgtc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.imgtc.FontSize = 10F;
            this.imgtc.Location = new System.Drawing.Point(0, 438);
            this.imgtc.Name = "imgtc";
            this.imgtc.Padding = new Smobiler.Core.Padding(10F, 12F, 10F, 12F);
            this.imgtc.ResourceID = "!\\ue8ac255255255";
            this.imgtc.Size = new System.Drawing.Size(50, 50);
            this.imgtc.TabIndex = 19;
            // 
            // btnindex
            // 
            this.btnindex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(128)))), ((int)(((byte)(172)))));
            this.btnindex.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.btnindex.FontSize = 18F;
            this.btnindex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.btnindex.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Left;
            this.btnindex.Location = new System.Drawing.Point(50, 238);
            this.btnindex.Name = "btnindex";
            this.btnindex.Padding = new Smobiler.Core.Padding(5F, 0F, 0F, 0F);
            this.btnindex.Size = new System.Drawing.Size(190, 50);
            this.btnindex.TabIndex = 21;
            this.btnindex.Text = "首页";
            // 
            // imgtz
            // 
            this.imgtz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.imgtz.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.imgtz.FontSize = 10F;
            this.imgtz.Location = new System.Drawing.Point(0, 338);
            this.imgtz.Name = "imgtz";
            this.imgtz.Padding = new Smobiler.Core.Padding(10F, 12F, 10F, 12F);
            this.imgtz.ResourceID = "!\\ue0e1255255255";
            this.imgtz.Size = new System.Drawing.Size(50, 50);
            this.imgtz.TabIndex = 22;
            // 
            // btntz
            // 
            this.btntz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.btntz.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.btntz.FontSize = 18F;
            this.btntz.ForeColor = System.Drawing.Color.White;
            this.btntz.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Left;
            this.btntz.Location = new System.Drawing.Point(50, 338);
            this.btntz.Name = "btntz";
            this.btntz.Padding = new Smobiler.Core.Padding(5F, 0F, 0F, 0F);
            this.btntz.Size = new System.Drawing.Size(190, 50);
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
            this.Size = new System.Drawing.Size(300, 488);
            this.Name = "frmMenuLayout";

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
