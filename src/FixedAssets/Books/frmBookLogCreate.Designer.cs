using System;
using Smobiler.Core;
namespace COMSSmobilerDemo.FixedAssets.Books
{
    partial class frmBookLogCreate : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmBookLogCreate()
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
            this.Label1 = new Smobiler.Core.Controls.Label();
            this.Label2 = new Smobiler.Core.Controls.Label();
            this.txtBOOKSNID = new Smobiler.Core.Controls.TextBox();
            this.txtBORROWER = new Smobiler.Core.Controls.TextBox();
            this.btnBORROWER2 = new Smobiler.Core.Controls.Button();
            this.save = new Smobiler.Core.Controls.ToolbarItem();
            this.PopList1 = new Smobiler.Core.Controls.PopList();
            this.btnBOOKSN2 = new Smobiler.Core.Controls.Button();
            this.btnBOOKSN = new Smobiler.Core.Controls.BarcodeButton();
            this.Label4 = new Smobiler.Core.Controls.Label();
            this.btnState2 = new Smobiler.Core.Controls.Button();
            this.btnState = new Smobiler.Core.Controls.Button();
            // 
            // Label1
            // 
            this.Label1.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label1.Name = "Label1";
            this.Label1.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label1.Size = new System.Drawing.Size(88, 35);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Í¼ÊéÐòºÅ";
            this.Label1.ZIndex = 1;
            // 
            // Label2
            // 
            this.Label2.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label2.Location = new System.Drawing.Point(0, 43);
            this.Label2.Name = "Label2";
            this.Label2.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label2.Size = new System.Drawing.Size(88, 35);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "½èÔÄÕß";
            this.Label2.ZIndex = 1;
            // 
            // txtBOOKSNID
            // 
            this.txtBOOKSNID.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.txtBOOKSNID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtBOOKSNID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txtBOOKSNID.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.txtBOOKSNID.Location = new System.Drawing.Point(88, 0);
            this.txtBOOKSNID.Name = "txtBOOKSNID";
            this.txtBOOKSNID.Padding = new Smobiler.Core.Padding(0F, 0F, 2F, 0F);
            this.txtBOOKSNID.Size = new System.Drawing.Size(163, 35);
            this.txtBOOKSNID.TabIndex = 5;
            this.txtBOOKSNID.WaterMarkText = "£¨±ØÌî£©";
            this.txtBOOKSNID.ZIndex = 2;
            // 
            // txtBORROWER
            // 
            this.txtBORROWER.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.txtBORROWER.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtBORROWER.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txtBORROWER.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.txtBORROWER.Location = new System.Drawing.Point(88, 43);
            this.txtBORROWER.Name = "txtBORROWER";
            this.txtBORROWER.Padding = new Smobiler.Core.Padding(0F, 0F, 5F, 0F);
            this.txtBORROWER.Size = new System.Drawing.Size(188, 35);
            this.txtBORROWER.TabIndex = 6;
            this.txtBORROWER.WaterMarkText = "£¨±ØÊä£©";
            this.txtBORROWER.ZIndex = 18;
            // 
            // btnBORROWER2
            // 
            this.btnBORROWER2.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.btnBORROWER2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnBORROWER2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnBORROWER2.Location = new System.Drawing.Point(275, 43);
            this.btnBORROWER2.Name = "btnBORROWER2";
            this.btnBORROWER2.Size = new System.Drawing.Size(25, 35);
            this.btnBORROWER2.TabIndex = 7;
            this.btnBORROWER2.Text = ">";
            this.btnBORROWER2.ZIndex = 19;
            this.btnBORROWER2.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnpop_Click);
            // 
            // save
            // 
            this.save.IconID = "!\\ue161043146223";
            this.save.Name = "save";
            this.save.Text = "±£´æ";
            // 
            // PopList1
            // 
            this.PopList1.Name = "PopList1";
            this.PopList1.Selected += new System.EventHandler(this.PopList1_Selected);
            // 
            // btnBOOKSN2
            // 
            this.btnBOOKSN2.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.btnBOOKSN2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnBOOKSN2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnBOOKSN2.Location = new System.Drawing.Point(250, 0);
            this.btnBOOKSN2.Name = "btnBOOKSN2";
            this.btnBOOKSN2.Size = new System.Drawing.Size(25, 35);
            this.btnBOOKSN2.TabIndex = 9;
            this.btnBOOKSN2.Text = ">";
            this.btnBOOKSN2.ZIndex = 29;
            this.btnBOOKSN2.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnpop_Click);
            // 
            // btnBOOKSN
            // 
            this.btnBOOKSN.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.btnBOOKSN.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnBOOKSN.FontSize = 10F;
            this.btnBOOKSN.Location = new System.Drawing.Point(275, 0);
            this.btnBOOKSN.Name = "btnBOOKSN";
            this.btnBOOKSN.ResourceID = "!\\uf029000000000";
            this.btnBOOKSN.Size = new System.Drawing.Size(25, 35);
            this.btnBOOKSN.TabIndex = 10;
            // 
            // Label4
            // 
            this.Label4.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label4.Location = new System.Drawing.Point(0, 78);
            this.Label4.Name = "Label4";
            this.Label4.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label4.Size = new System.Drawing.Size(88, 35);
            this.Label4.TabIndex = 11;
            this.Label4.Text = "×´Ì¬";
            this.Label4.ZIndex = 1;
            // 
            // btnState2
            // 
            this.btnState2.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.btnState2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnState2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnState2.Location = new System.Drawing.Point(275, 78);
            this.btnState2.Name = "btnState2";
            this.btnState2.Size = new System.Drawing.Size(25, 35);
            this.btnState2.TabIndex = 12;
            this.btnState2.Text = ">";
            this.btnState2.ZIndex = 29;
            this.btnState2.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnpop_Click);
            // 
            // btnState
            // 
            this.btnState.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.btnState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnState.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnState.Location = new System.Drawing.Point(88, 78);
            this.btnState.Name = "btnState";
            this.btnState.Padding = new Smobiler.Core.Padding(0F, 0F, 5F, 0F);
            this.btnState.Size = new System.Drawing.Size(188, 35);
            this.btnState.TabIndex = 13;
            this.btnState.Text = "½è³ö";
            this.btnState.ZIndex = 28;
            // 
            // frmBookLogCreate
            // 
            this.ComponentControls.AddRange(new Smobiler.Core.ComponentBase[] {
            this.PopList1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnBOOKSN,
            this.Label1,
            this.Label2,
            this.Label4,
            this.txtBOOKSNID,
            this.txtBORROWER,
            this.btnBORROWER2,
            this.btnBOOKSN2,
            this.btnState2,
            this.btnState});
            this.StatusBarStyle = Smobiler.Core.StatusBarStyle.Default;
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("Exit", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(50))))));
            this.TitleText = "Í¼Êé½èÔÄ¼ÇÂ¼Â¼Èë";
            this.Toolbar.AddRange(new Smobiler.Core.Controls.ToolbarItem[] {
            this.save});
            this.ToolbarStyle = new Smobiler.Core.ToolBarSytle(Smobiler.Core.ToolbarSelectStyle.None, System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))), System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))));
            this.Load += new System.EventHandler(this.frmBookLogCreate_Load);
            this.ToolbarItemClick += new Smobiler.Core.ToolbarItemClickEventHandler(this.frmBookLogCreate_ToolbarItemClick);
            this.TitleImageClick += new System.EventHandler(this.frmBookLogCreate_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.MobileForm_KeyDown);
            this.Name = "frmBookLogCreate";

        }
        internal Smobiler.Core.Controls.Label Label1;
        internal Smobiler.Core.Controls.Label Label2;
        internal Smobiler.Core.Controls.TextBox txtBOOKSNID;
        internal Smobiler.Core.Controls.TextBox txtBORROWER;
        internal Smobiler.Core.Controls.Button btnBORROWER2;
        internal Smobiler.Core.Controls.ToolbarItem save;
        internal Smobiler.Core.Controls.PopList PopList1;
        internal Smobiler.Core.Controls.Button btnBOOKSN2;
        internal Smobiler.Core.Controls.BarcodeButton btnBOOKSN;
        internal Smobiler.Core.Controls.Label Label4;
        internal Smobiler.Core.Controls.Button btnState2;
        internal Smobiler.Core.Controls.Button btnState;
        #endregion
    }
}
