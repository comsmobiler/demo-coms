using System;
using Smobiler.Core;
namespace COMSSmobilerDemo.FixedAssets.NootBooks.Layout
{
    partial class frmNBLayout : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmNBLayout()
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
            this.lblNB_SN = new Smobiler.Core.Controls.Label();
            this.lblState = new Smobiler.Core.Controls.Image();
            this.lblNB_BUYDATE = new Smobiler.Core.Controls.Label();
            this.lblMoney = new Smobiler.Core.Controls.Label();
            this.lblUSER = new Smobiler.Core.Controls.Label();
            this.Label2 = new Smobiler.Core.Controls.Label();
            this.Label1 = new Smobiler.Core.Controls.Label();
            this.Label3 = new Smobiler.Core.Controls.Label();
            this.Label4 = new Smobiler.Core.Controls.Label();
            this.Label5 = new Smobiler.Core.Controls.Label();
            // 
            // lblNB_SN
            // 
            this.lblNB_SN.DataMember = "NB_EQNO";
            this.lblNB_SN.DisplayMember = "NBSN";
            this.lblNB_SN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblNB_SN.Location = new System.Drawing.Point(8,10);
            this.lblNB_SN.Name = "lblNB_SN";
            this.lblNB_SN.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.lblNB_SN.Size = new System.Drawing.Size(285,23);
            this.lblNB_SN.TabIndex = 2;
            this.lblNB_SN.ZIndex = 1;
            // 
            // lblState
            // 
            this.lblState.BackColorAlpha = 0;
            this.lblState.DataMember = "NB_STATE_FORMAT";
            this.lblState.DisplayMember = "NB_STATE_FORMAT";
            this.lblState.ID = "";
            this.lblState.Location = new System.Drawing.Point(238,23);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(45,35);
            this.lblState.TabIndex = 3;
            this.lblState.ZIndex = 5;
            // 
            // lblNB_BUYDATE
            // 
            this.lblNB_BUYDATE.DataMember = "NB_BUYDATE";
            this.lblNB_BUYDATE.DisplayMember = "NB_BUYDATE";
            this.lblNB_BUYDATE.FontSize = 13;
            this.lblNB_BUYDATE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.lblNB_BUYDATE.Format = "{0:yyyy/MM/dd}";
            this.lblNB_BUYDATE.Location = new System.Drawing.Point(8,48);
            this.lblNB_BUYDATE.Name = "lblNB_BUYDATE";
            this.lblNB_BUYDATE.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.lblNB_BUYDATE.Size = new System.Drawing.Size(285,15);
            this.lblNB_BUYDATE.TabIndex = 4;
            this.lblNB_BUYDATE.ZIndex = 3;
            // 
            // lblMoney
            // 
            this.lblMoney.DataMember = "NB_PRICE";
            this.lblMoney.DisplayMember = "NB_PRICE";
            this.lblMoney.FontSize = 13;
            this.lblMoney.ForeColor = System.Drawing.Color.Red;
            this.lblMoney.Format = "{0:C}";
            this.lblMoney.Location = new System.Drawing.Point(8,33);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.lblMoney.Size = new System.Drawing.Size(285,15);
            this.lblMoney.TabIndex = 5;
            this.lblMoney.Text = "£§0.00";
            this.lblMoney.ZIndex = 2;
            // 
            // lblUSER
            // 
            this.lblUSER.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.lblUSER.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblUSER.DataMember = "USER";
            this.lblUSER.DisplayMember = "USER";
            this.lblUSER.FontSize = 13;
            this.lblUSER.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.lblUSER.Location = new System.Drawing.Point(8,63);
            this.lblUSER.Name = "lblUSER";
            this.lblUSER.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.lblUSER.Size = new System.Drawing.Size(285,15);
            this.lblUSER.TabIndex = 7;
            this.lblUSER.ZIndex = 4;
            // 
            // Label2
            // 
            this.Label2.Border = new Smobiler.Core.Border(1);
            this.Label2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label2.BorderRadius = 1;
            this.Label2.Location = new System.Drawing.Point(4,8);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(293,113);
            this.Label2.TabIndex = 8;
            this.Label2.ZIndex = -1;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.Label1.FontSize = 13;
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.Label1.Location = new System.Drawing.Point(8,78);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(143,20);
            this.Label1.TabIndex = 9;
            this.Label1.Text = " π”√";
            this.Label1.ZIndex = 5;
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.Label3.FontSize = 13;
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.Label3.Location = new System.Drawing.Point(150,78);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(143,20);
            this.Label3.TabIndex = 10;
            this.Label3.Text = "Œ¨–ﬁ";
            this.Label3.ZIndex = 6;
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.Label4.DisplayMember = "NBWXQTY";
            this.Label4.FontSize = 13;
            this.Label4.ForeColor = System.Drawing.Color.White;
            this.Label4.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.Label4.Location = new System.Drawing.Point(150,98);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(143,18);
            this.Label4.TabIndex = 11;
            this.Label4.Text = "5";
            this.Label4.ZIndex = 8;
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.Label5.DisplayMember = "NBSYQTY";
            this.Label5.FontSize = 13;
            this.Label5.ForeColor = System.Drawing.Color.White;
            this.Label5.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.Label5.Location = new System.Drawing.Point(8,98);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(143,18);
            this.Label5.TabIndex = 12;
            this.Label5.Text = "2";
            this.Label5.ZIndex = 7;
            // 
            // frmNBLayout
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label2,
            this.lblNB_SN,
            this.lblMoney,
            this.lblNB_BUYDATE,
            this.lblUSER,
            this.Label1,
            this.lblState,
            this.Label3,
            this.Label5,
            this.Label4});
            this.Size = new System.Drawing.Size(300,125);
            this.Name = "frmNBLayout";

        }
        internal Smobiler.Core.Controls.Label lblNB_SN;
        internal Smobiler.Core.Controls.Image lblState;
        internal Smobiler.Core.Controls.Label lblNB_BUYDATE;
        internal Smobiler.Core.Controls.Label lblMoney;
        internal Smobiler.Core.Controls.Label lblUSER;
        internal Smobiler.Core.Controls.Label Label2;
        internal Smobiler.Core.Controls.Label Label1;
        internal Smobiler.Core.Controls.Label Label3;
        internal Smobiler.Core.Controls.Label Label4;
        internal Smobiler.Core.Controls.Label Label5;
        #endregion
    }
}
