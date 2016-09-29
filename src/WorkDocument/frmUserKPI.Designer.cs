using System;
using Smobiler.Core;
namespace COMSSmobilerDemo.WorkDocument
{
    partial class frmUserKPI : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmUserKPI()
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
            Smobiler.Core.Controls.TextTabBarItem textTabBarItem1 = new Smobiler.Core.Controls.TextTabBarItem();
            Smobiler.Core.Controls.TextTabBarItem textTabBarItem2 = new Smobiler.Core.Controls.TextTabBarItem();
            Smobiler.Core.Controls.GaugeViewAxisLine gaugeViewAxisLine1 = new Smobiler.Core.Controls.GaugeViewAxisLine();
            Smobiler.Core.Controls.GaugeViewAxisLine gaugeViewAxisLine2 = new Smobiler.Core.Controls.GaugeViewAxisLine();
            Smobiler.Core.Controls.GaugeViewAxisLine gaugeViewAxisLine3 = new Smobiler.Core.Controls.GaugeViewAxisLine();
            Smobiler.Core.Controls.TableViewLabelColumn tableViewLabelColumn1 = new Smobiler.Core.Controls.TableViewLabelColumn();
            Smobiler.Core.Controls.TableViewImageColumn tableViewImageColumn1 = new Smobiler.Core.Controls.TableViewImageColumn();
            this.TextTabBar1 = new Smobiler.Core.Controls.TextTabBar();
            this.GaugeView1 = new Smobiler.Core.Controls.GaugeView();
            this.Label1 = new Smobiler.Core.Controls.Label();
            this.TableView1 = new Smobiler.Core.Controls.TableView();
            // 
            // TextTabBar1
            // 
            this.TextTabBar1.BackColor = System.Drawing.Color.White;
            this.TextTabBar1.Border = new Smobiler.Core.Border(1);
            this.TextTabBar1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.TextTabBar1.BorderRadius = 2;
            this.TextTabBar1.BorderSize = 0.2F;
            this.TextTabBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            textTabBarItem1.Text = "业务人天";
            textTabBarItem1.Value = "kpiyw";
            textTabBarItem2.Text = "其他人天";
            textTabBarItem2.Value = "kpiother";
            this.TextTabBar1.Items.AddRange(new Smobiler.Core.Controls.TextTabBarItem[] {
            textTabBarItem1,
            textTabBarItem2});
            this.TextTabBar1.Location = new System.Drawing.Point(20,10);
            this.TextTabBar1.Name = "TextTabBar1";
            this.TextTabBar1.SelectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.TextTabBar1.SelectForeColor = System.Drawing.Color.White;
            this.TextTabBar1.Size = new System.Drawing.Size(200,28);
            this.TextTabBar1.TabIndex = 2;
            this.TextTabBar1.ItemClick += new Smobiler.Core.Controls.TabBarItemClickEventHandler(this.TextTabBar1_ItemClick);
            // 
            // GaugeView1
            // 
            gaugeViewAxisLine1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            gaugeViewAxisLine1.SplitNumRate = 0.3F;
            gaugeViewAxisLine2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            gaugeViewAxisLine2.SplitNumRate = 0.7F;
            gaugeViewAxisLine3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            gaugeViewAxisLine3.SplitNumRate = 1F;
            this.GaugeView1.AxisLines.AddRange(new Smobiler.Core.Controls.GaugeViewAxisLine[] {
            gaugeViewAxisLine1,
            gaugeViewAxisLine2,
            gaugeViewAxisLine3});
            this.GaugeView1.AxisLineWidth = 4F;
            this.GaugeView1.AxisTickLength = 2F;
            this.GaugeView1.Location = new System.Drawing.Point(0,48);
            this.GaugeView1.MaxValue = 150F;
            this.GaugeView1.Name = "GaugeView1";
            this.GaugeView1.PointerColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.GaugeView1.PointerLength = 40F;
            this.GaugeView1.PointerWidth = 10F;
            this.GaugeView1.Size = new System.Drawing.Size(240,180);
            this.GaugeView1.SplitLineLength = 4F;
            this.GaugeView1.TabIndex = 3;
            this.GaugeView1.Title = "绩效完成率";
            // 
            // Label1
            // 
            this.Label1.ForeColor = System.Drawing.Color.Red;
            this.Label1.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.Label1.Location = new System.Drawing.Point(0,228);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(240,20);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Label1";
            // 
            // TableView1
            // 
            this.TableView1.AutoHeight = false;
            this.TableView1.BackColorAlpha = 0;
            this.TableView1.ColumnHeaderStyle = new Smobiler.Core.Controls.TableViewColumnHeaderStyle(12F, 6F, System.Drawing.Color.LightBlue, System.Drawing.Color.White);
            tableViewLabelColumn1.DataMember = "PERIOD_ID";
            tableViewLabelColumn1.DefaultBindPropertyValue = "日期";
            tableViewLabelColumn1.DisplayMember = "PERIOD_ID";
            tableViewLabelColumn1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            tableViewLabelColumn1.HeaderText = "日期";
            tableViewLabelColumn1.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            tableViewLabelColumn1.Text = "日期";
            tableViewLabelColumn1.VerticalAlignment = Smobiler.Core.VerticalAlignment.Center;
            tableViewLabelColumn1.Width = 60;
            tableViewImageColumn1.DataMember = "ISWARNING1";
            tableViewImageColumn1.DefaultBindPropertyValue = "";
            tableViewImageColumn1.DefaultImageVisible = true;
            tableViewImageColumn1.DisplayMember = "ISWARNING1";
            tableViewImageColumn1.Enlarged = false;
            tableViewImageColumn1.HeaderText = "是否完成";
            tableViewImageColumn1.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            tableViewImageColumn1.Mode = Smobiler.Core.Controls.ResourceMode.File;
            tableViewImageColumn1.ResourceID = "";
            tableViewImageColumn1.ResourcePath = "";
            tableViewImageColumn1.SizeMode = Smobiler.Core.ImageSizeMode.Zoom;
            tableViewImageColumn1.VerticalAlignment = Smobiler.Core.VerticalAlignment.Center;
            tableViewImageColumn1.Width = 60;
            this.TableView1.Columns.AddRange(new Smobiler.Core.Controls.TableViewColumn[] {
            tableViewLabelColumn1,
            tableViewImageColumn1});
            this.TableView1.GridLinesColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.TableView1.Location = new System.Drawing.Point(0,248);
            this.TableView1.Name = "TableView1";
            this.TableView1.Size = new System.Drawing.Size(240,160);
            this.TableView1.TabIndex = 5;
            // 
            // frmUserKPI
            // 
            this.AllowSlip = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.TextTabBar1,
            this.GaugeView1,
            this.Label1,
            this.TableView1});
            this.StatusBarStyle = Smobiler.Core.StatusBarStyle.Default;
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("Exit", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(50))))));
            this.TitleText = "个人KPI";
            this.Load += new System.EventHandler(this.frmUserKPI_Load);
            this.TitleImageClick += new System.EventHandler(this.frmUserKPI_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.frmUserKPI_KeyDown);
            this.Name = "frmUserKPI";

        }
        internal Smobiler.Core.Controls.TextTabBar TextTabBar1;
        internal Smobiler.Core.Controls.GaugeView GaugeView1;
        internal Smobiler.Core.Controls.Label Label1;
        internal Smobiler.Core.Controls.TableView TableView1;
        #endregion
    }
}
