
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
using Smobiler.Core.Controls;
namespace COMSSmobilerDemo.Reimbursement.CostCenter.Layout
{
    public partial class frmCCleft : Smobiler.Core.MobileForm
    {

        #region "VTForm Designer generated code "

        public frmCCleft()
            : base()
        {

            //This call is required by the VTForm Designer.
            InitializeComponent();

            //Add any initialization after the InitializeComponent() call

        }

        //VTForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the VTForm Designer
        //It can be modified using the VTForm Designer.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.Label1 = new Smobiler.Core.Controls.Label();
            this.txtCCUser = new Smobiler.Core.Controls.TextBox();
            this.btnchoice = new Smobiler.Core.Controls.Button();
            this.btncurrentUser = new Smobiler.Core.Controls.ImageButton();
            this.Label2 = new Smobiler.Core.Controls.Label();
            this.txtCCName = new Smobiler.Core.Controls.TextBox();
            this.btnsearch = new Smobiler.Core.Controls.ImageButton();
            this.Line2 = new Smobiler.Core.Controls.Line();
            this.search = new Smobiler.Core.Controls.ToolbarItem();
            this.Line1 = new Smobiler.Core.Controls.Line();
            // 
            // Label1
            // 
            this.Label1.FontSize = 7F;
            this.Label1.Name = "Label1";
            this.Label1.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label1.Size = new System.Drawing.SizeF(30F, 15F);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "责任人：";
            // 
            // txtCCUser
            // 
            this.txtCCUser.BorderColor = System.Drawing.Color.LightGray;
            this.txtCCUser.ForeColor = System.Drawing.Color.Gray;
            this.txtCCUser.Location = new Smobiler.Core.PointS(29F, 0F);
            this.txtCCUser.Name = "txtCCUser";
            this.txtCCUser.Size = new System.Drawing.SizeF(28F, 15F);
            this.txtCCUser.TabIndex = 3;
            // 
            // btnchoice
            // 
            this.btnchoice.Border = new Smobiler.Core.Border(1, 0, 0, 0);
            this.btnchoice.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnchoice.FontSize = 8F;
            this.btnchoice.ForeColor = System.Drawing.Color.Gray;
            this.btnchoice.Location = new Smobiler.Core.PointS(57F, 0F);
            this.btnchoice.Name = "btnchoice";
            this.btnchoice.Size = new System.Drawing.SizeF(12F, 15F);
            this.btnchoice.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btnchoice.TabIndex = 4;
            this.btnchoice.Text = ">";
            // 
            // btncurrentUser
            // 
            this.btncurrentUser.Border = new Smobiler.Core.Border(1, 0, 0, 0);
            this.btncurrentUser.BorderColor = System.Drawing.Color.Gainsboro;
            this.btncurrentUser.FontSize = 1F;
            this.btncurrentUser.Location = new Smobiler.Core.PointS(69F, 0F);
            this.btncurrentUser.Name = "btncurrentUser";
            this.btncurrentUser.ResourceID = "log1";
            this.btncurrentUser.Size = new System.Drawing.SizeF(11F, 15F);
            this.btncurrentUser.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btncurrentUser.TabIndex = 5;
            // 
            // Label2
            // 
            this.Label2.FontSize = 7F;
            this.Label2.Location = new Smobiler.Core.PointS(0F, 15F);
            this.Label2.Name = "Label2";
            this.Label2.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label2.Size = new System.Drawing.SizeF(29F, 15F);
            this.Label2.TabIndex = 6;
            this.Label2.Text = "成本中心:";
            // 
            // txtCCName
            // 
            this.txtCCName.BorderColor = System.Drawing.Color.LightBlue;
            this.txtCCName.ForeColor = System.Drawing.Color.Gray;
            this.txtCCName.Location = new Smobiler.Core.PointS(29F, 15F);
            this.txtCCName.Name = "txtCCName";
            this.txtCCName.Size = new System.Drawing.SizeF(51F, 15F);
            this.txtCCName.TabIndex = 7;
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(201)))), ((int)(((byte)(232)))));
            this.btnsearch.BorderColor = System.Drawing.Color.White;
            this.btnsearch.BorderRadius = 4;
            this.btnsearch.FontSize = 4F;
            this.btnsearch.ForeColor = System.Drawing.Color.White;
            this.btnsearch.Location = new Smobiler.Core.PointS(16F, 53F);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.ResourceID = "Search1";
            this.btnsearch.Size = new System.Drawing.SizeF(50F, 14F);
            this.btnsearch.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btnsearch.TabIndex = 8;
            this.btnsearch.Text = "查询";
            // 
            // Line2
            // 
            this.Line2.BackColor = System.Drawing.Color.Gainsboro;
            this.Line2.Location = new Smobiler.Core.PointS(2F, 15F);
            this.Line2.Name = "Line2";
            this.Line2.Size = new System.Drawing.SizeF(78F, 1F);
            this.Line2.TabIndex = 11;
            // 
            // search
            // 
            this.search.IconID = "search";
            this.search.Name = "search";
            this.search.Text = "查询";
            // 
            // Line1
            // 
            this.Line1.BackColor = System.Drawing.Color.Gainsboro;
            this.Line1.Location = new Smobiler.Core.PointS(0F, 30F);
            this.Line1.Name = "Line1";
            this.Line1.Size = new System.Drawing.SizeF(80F, 1F);
            this.Line1.TabIndex = 12;
            // 
            // frmCCleft
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label1,
            this.txtCCUser,
            this.btnchoice,
            this.btncurrentUser,
            this.Label2,
            this.txtCCName,
            this.btnsearch,
            this.Line2,
            this.Line1});
            this.Size = new System.Drawing.Size(80, 204);
            this.TitleImage = "formimg";
            this.TitleText = "成本中心查询";
            this.Toolbar.AddRange(new Smobiler.Core.Controls.ToolbarItem[] {
            this.search});

        }
        internal Smobiler.Core.Controls.Label Label1;
        internal Smobiler.Core.Controls.TextBox txtCCUser;
        internal Smobiler.Core.Controls.Button btnchoice;
        internal Smobiler.Core.Controls.ImageButton btncurrentUser;
        internal Smobiler.Core.Controls.Label Label2;
        internal Smobiler.Core.Controls.TextBox txtCCName;
        internal Smobiler.Core.Controls.ImageButton btnsearch;
        internal Smobiler.Core.Controls.Line Line2;
        internal Smobiler.Core.Controls.ToolbarItem search;

        internal Smobiler.Core.Controls.Line Line1;
        #endregion

    }
}
