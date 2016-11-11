using System;
using Smobiler.Core;
namespace COMSSmobilerDemo.Layout
{
    partial class frmAddUserLayout : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmAddUserLayout()
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
            this.imgPortraitUri = new Smobiler.Core.Controls.Image();
            this.lblUSER_ID = new Smobiler.Core.Controls.Label();
            this.btnAddUser = new Smobiler.Core.Controls.Button();
            this.Line1 = new Smobiler.Core.Controls.Line();
            // 
            // imgPortraitUri
            // 
            this.imgPortraitUri.Border = new Smobiler.Core.Border(1);
            this.imgPortraitUri.BorderColor = System.Drawing.Color.Gainsboro;
            this.imgPortraitUri.BorderRadius = 10;
            this.imgPortraitUri.DataMember = "PortraitUri";
            this.imgPortraitUri.DisplayMember = "PortraitUri";
            this.imgPortraitUri.ID = "";
            this.imgPortraitUri.Location = new System.Drawing.Point(5, 3);
            this.imgPortraitUri.Name = "imgPortraitUri";
            this.imgPortraitUri.Size = new System.Drawing.Size(44, 45);
            this.imgPortraitUri.TabIndex = 2;
            this.imgPortraitUri.ZIndex = 1;
            // 
            // lblUSER_ID
            // 
            this.lblUSER_ID.DataMember = "UserID";
            this.lblUSER_ID.DisplayMember = "UserID";
            this.lblUSER_ID.FontSize = 17F;
            this.lblUSER_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblUSER_ID.Location = new System.Drawing.Point(55, 0);
            this.lblUSER_ID.Name = "lblUSER_ID";
            this.lblUSER_ID.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.lblUSER_ID.Size = new System.Drawing.Size(177, 50);
            this.lblUSER_ID.TabIndex = 3;
            this.lblUSER_ID.ZIndex = 2;
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnAddUser.BorderColor = System.Drawing.Color.White;
            this.btnAddUser.BorderRadius = 2;
            this.btnAddUser.DataMember = "isAddC";
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnAddUser.HoverForeColor = System.Drawing.Color.White;
            this.btnAddUser.Location = new System.Drawing.Point(232, 13);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(55, 25);
            this.btnAddUser.TabIndex = 4;
            this.btnAddUser.Text = "Ìí¼Ó";
            // 
            // Line1
            // 
            this.Line1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Line1.Location = new System.Drawing.Point(0, 50);
            this.Line1.Name = "Line1";
            this.Line1.Size = new System.Drawing.Size(300, 3);
            this.Line1.TabIndex = 5;
            this.Line1.ZIndex = 5;
            // 
            // frmAddUserLayout
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnAddUser,
            this.imgPortraitUri,
            this.lblUSER_ID,
            this.Line1});
            this.Size = new System.Drawing.Size(300, 50);
            this.Name = "frmAddUserLayout";

        }
        #endregion

        internal Smobiler.Core.Controls.Image imgPortraitUri;
        internal Smobiler.Core.Controls.Label lblUSER_ID;
        internal Smobiler.Core.Controls.Button btnAddUser;
        internal Smobiler.Core.Controls.Line Line1;
    }
}