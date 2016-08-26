using System;
using Smobiler.Core;
namespace COMSSmobilerDemo.FixedAssets.Books.Layout
{
    partial class frmBooksLayout : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmBooksLayout()
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
            this.lblBOOKID = new Smobiler.Core.Controls.Label();
            this.lblMoney = new Smobiler.Core.Controls.Label();
            this.lblNB_BUYDATE = new Smobiler.Core.Controls.Label();
            this.Line1 = new Smobiler.Core.Controls.Line();
            this.Image1 = new Smobiler.Core.Controls.Image();
            this.lblQTY = new Smobiler.Core.Controls.Label();
            this.Image2 = new Smobiler.Core.Controls.Image();
            this.Label1 = new Smobiler.Core.Controls.Label();
            // 
            // lblBOOKID
            // 
            this.lblBOOKID.Bold = true;
            this.lblBOOKID.DataMember = "BOOKNO";
            this.lblBOOKID.DisplayMember = "BOOKNAME";
            this.lblBOOKID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblBOOKID.Location = new Smobiler.Core.PointS(30F, 0F);
            this.lblBOOKID.Name = "lblBOOKID";
            this.lblBOOKID.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.lblBOOKID.Size = new System.Drawing.SizeF(90F, 10F);
            this.lblBOOKID.TabIndex = 2;
            this.lblBOOKID.ZIndex = 2;
            // 
            // lblMoney
            // 
            this.lblMoney.DataMember = "MONEY";
            this.lblMoney.DisplayMember = "MONEY";
            this.lblMoney.FontSize = 5F;
            this.lblMoney.ForeColor = System.Drawing.Color.Red;
            this.lblMoney.Format = "{0:C}";
            this.lblMoney.Location = new Smobiler.Core.PointS(30F, 10F);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.lblMoney.Size = new System.Drawing.SizeF(60F, 6F);
            this.lblMoney.TabIndex = 3;
            this.lblMoney.Text = "гд0.00";
            this.lblMoney.ZIndex = 3;
            // 
            // lblNB_BUYDATE
            // 
            this.lblNB_BUYDATE.DataMember = "BOOKPUBLIDATE";
            this.lblNB_BUYDATE.DisplayMember = "BOOKPUBLIDATE";
            this.lblNB_BUYDATE.FontSize = 5F;
            this.lblNB_BUYDATE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.lblNB_BUYDATE.Format = "{0:yyyy/MM/dd}";
            this.lblNB_BUYDATE.Location = new Smobiler.Core.PointS(30F, 16F);
            this.lblNB_BUYDATE.Name = "lblNB_BUYDATE";
            this.lblNB_BUYDATE.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.lblNB_BUYDATE.Size = new System.Drawing.SizeF(60F, 6F);
            this.lblNB_BUYDATE.TabIndex = 4;
            this.lblNB_BUYDATE.ZIndex = 4;
            // 
            // Line1
            // 
            this.Line1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Line1.Location = new Smobiler.Core.PointS(30F, 28F);
            this.Line1.Name = "Line1";
            this.Line1.Size = new System.Drawing.SizeF(90F, 1F);
            this.Line1.TabIndex = 5;
            this.Line1.ZIndex = 6;
            // 
            // Image1
            // 
            this.Image1.DataMember = "BOOKIMG";
            this.Image1.DisplayMember = "BOOKIMG";
            this.Image1.ID = "";
            this.Image1.Location = new Smobiler.Core.PointS(2.5F, 2.5F);
            this.Image1.Name = "Image1";
            this.Image1.Size = new System.Drawing.SizeF(25F, 21F);
            this.Image1.SizeMode = Smobiler.Core.ImageSizeMode.StretchImage;
            this.Image1.TabIndex = 6;
            this.Image1.ZIndex = 1;
            // 
            // lblQTY
            // 
            this.lblQTY.DataMember = "QTY";
            this.lblQTY.DisplayMember = "QTY";
            this.lblQTY.FontSize = 4F;
            this.lblQTY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.lblQTY.Location = new Smobiler.Core.PointS(30F, 22F);
            this.lblQTY.Name = "lblQTY";
            this.lblQTY.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.lblQTY.Size = new System.Drawing.SizeF(90F, 6F);
            this.lblQTY.TabIndex = 7;
            this.lblQTY.ZIndex = 5;
            // 
            // Image2
            // 
            this.Image2.DataMember = "GRADEIMG";
            this.Image2.DisplayMember = "GRADEIMG";
            this.Image2.ID = "";
            this.Image2.Location = new Smobiler.Core.PointS(93F, 10F);
            this.Image2.Name = "Image2";
            this.Image2.Padding = new Smobiler.Core.Padding(1F);
            this.Image2.Size = new System.Drawing.SizeF(10F, 10F);
            this.Image2.TabIndex = 8;
            this.Image2.ZIndex = 1;
            // 
            // Label1
            // 
            this.Label1.DataMember = "GRADE";
            this.Label1.DisplayMember = "GRADE";
            this.Label1.FontSize = 5F;
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.Label1.Location = new Smobiler.Core.PointS(103F, 10F);
            this.Label1.Name = "Label1";
            this.Label1.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label1.Size = new System.Drawing.SizeF(16F, 10F);
            this.Label1.TabIndex = 9;
            this.Label1.Text = "Label1";
            // 
            // frmBooksLayout
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Image1,
            this.lblBOOKID,
            this.lblMoney,
            this.lblNB_BUYDATE,
            this.lblQTY,
            this.Line1,
            this.Image2,
            this.Label1});
            this.Size = new System.Drawing.Size(120, 28);
            this.Name = "frmBooksLayout";

        }
        internal Smobiler.Core.Controls.Label lblBOOKID;
        internal Smobiler.Core.Controls.Label lblMoney;
        internal Smobiler.Core.Controls.Label lblNB_BUYDATE;
        internal Smobiler.Core.Controls.Line Line1;
        internal Smobiler.Core.Controls.Image Image1;
        internal Smobiler.Core.Controls.Label lblQTY;
        internal Smobiler.Core.Controls.Image Image2;
        internal Smobiler.Core.Controls.Label Label1;
        #endregion
    }
}