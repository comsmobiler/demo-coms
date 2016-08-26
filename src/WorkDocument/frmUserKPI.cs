using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;

namespace COMSSmobilerDemo.WorkDocument
{
    partial class frmUserKPI : Smobiler.Core.MobileForm
    {
        private List<TableViewColumn> items = new List<TableViewColumn>();
        private void TextTabBar1_ItemClick(object sender, TabBarItemClickEventArgs e)
        {
            try
            {
                Bind();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmUserKPI_Load(object sender, EventArgs e)
        {
            try
            {
                Bind();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Bind()
        {
            try
            {
              
    
                decimal userkpi = default(decimal);
                switch (TextTabBar1.SelectItemIndex)
                {
                    case 0:
                        
                        userkpi = 2;
                        Label1.Text = "完成4人天值/目标178人天值";
                        break;
                    case 1:
                        userkpi = 0;
                        Label1.Text = "完成4人天值/目标178人天值";
                        break;
                }

                GaugeView1.Value = (float)userkpi;
                GaugeView1.Text = userkpi.ToString() + "%";
                System.Drawing.Color lblinfocolor = new System.Drawing.Color();
                if (userkpi <= 0 && userkpi < 45)
                {
                    lblinfocolor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(255)), Convert.ToInt32(Convert.ToByte(128)), Convert.ToInt32(Convert.ToByte(128)));
                }
                else if (userkpi <= 45 && userkpi < 105)
                {
                    lblinfocolor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(255)), Convert.ToInt32(Convert.ToByte(192)), Convert.ToInt32(Convert.ToByte(128)));
                }
                else if (userkpi <= 105 && userkpi < 150)
                {
                    lblinfocolor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(128)), Convert.ToInt32(Convert.ToByte(255)), Convert.ToInt32(Convert.ToByte(128)));
                }
                GaugeView1.TextForeColor = lblinfocolor;
                Label1.ForeColor = lblinfocolor;

                COMSSmobilerDemo.common.WorkDInfo WorkDInfo = new COMSSmobilerDemo.common.WorkDInfo();
                DataTable KPItable = WorkDInfo.GetKPI();
                if (items.Count > 0)
                {
                    foreach (TableViewColumn c in items)
                    {
                        TableView1.Columns.Remove(c);
                    }
                    items.Clear();
                }
                switch (TextTabBar1.SelectItemIndex)
                {
                    case 0:
                        Smobiler.Core.Controls.TableViewLabelColumn TableViewLabelColumn2 = new Smobiler.Core.Controls.TableViewLabelColumn();
                        TableViewLabelColumn2.HeaderText = "工单业务人天";
                        TableViewLabelColumn2.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
                        TableViewLabelColumn2.Text = "工单业务人天";
                        TableViewLabelColumn2.VerticalAlignment = Smobiler.Core.VerticalAlignment.Center;
                        TableViewLabelColumn2.Width = 30f;
                        TableViewLabelColumn2.DataMember = "WDOC_MENDAY";
                        TableViewLabelColumn2.DisplayMember = "WDOC_MENDAY";
                        TableViewLabelColumn2.ForeColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(102)), Convert.ToInt32(Convert.ToByte(99)), Convert.ToInt32(Convert.ToByte(99)));
                        TableView1.Columns.Add(TableViewLabelColumn2);
                        items.Add(TableViewLabelColumn2);
                        Smobiler.Core.Controls.TableViewLabelColumn TableViewLabelColumn3 = new Smobiler.Core.Controls.TableViewLabelColumn();
                        TableViewLabelColumn3.HeaderText = "目标业务人天";
                        TableViewLabelColumn3.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
                        TableViewLabelColumn3.Text = "目标业务人天";
                        TableViewLabelColumn3.VerticalAlignment = Smobiler.Core.VerticalAlignment.Center;
                        TableViewLabelColumn3.Width = 30f;
                        TableViewLabelColumn3.DataMember = "USER_OBJMENDAY";
                        TableViewLabelColumn3.DisplayMember = "USER_OBJMENDAY";
                        TableViewLabelColumn3.ForeColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(102)), Convert.ToInt32(Convert.ToByte(99)), Convert.ToInt32(Convert.ToByte(99)));
                        TableView1.Columns.Add(TableViewLabelColumn3);
                        items.Add(TableViewLabelColumn3);
                        break;
                    case 1:
                        Smobiler.Core.Controls.TableViewLabelColumn TableViewLabelColumn4 = new Smobiler.Core.Controls.TableViewLabelColumn();
                        TableViewLabelColumn4.DefaultBindPropertyValue = "其他业务人天";
                        TableViewLabelColumn4.HeaderText = "其他业务人天";
                        TableViewLabelColumn4.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
                        TableViewLabelColumn4.Text = "其他业务人天";
                        TableViewLabelColumn4.VerticalAlignment = Smobiler.Core.VerticalAlignment.Center;
                        TableViewLabelColumn4.Width = 30f;
                        TableViewLabelColumn4.DataMember = "WDOC_MENDAY1";
                        TableViewLabelColumn4.DisplayMember = "WDOC_MENDAY1";
                        TableViewLabelColumn4.ForeColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(102)), Convert.ToInt32(Convert.ToByte(99)), Convert.ToInt32(Convert.ToByte(99)));
                        TableView1.Columns.Add(TableViewLabelColumn4);
                        items.Add(TableViewLabelColumn4);
                        Smobiler.Core.Controls.TableViewLabelColumn TableViewLabelColumn5 = new Smobiler.Core.Controls.TableViewLabelColumn();
                        TableViewLabelColumn5.DefaultBindPropertyValue = "目标其他人天";
                        TableViewLabelColumn5.HeaderText = "目标其他人天";
                        TableViewLabelColumn5.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
                        TableViewLabelColumn5.Text = "目标其他人天";
                        TableViewLabelColumn5.VerticalAlignment = Smobiler.Core.VerticalAlignment.Center;
                        TableViewLabelColumn5.Width = 30f;
                        TableViewLabelColumn5.DataMember = "USER_OBJMENDAY1";
                        TableViewLabelColumn5.DisplayMember = "USER_OBJMENDAY1";
                        TableViewLabelColumn5.ForeColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(102)), Convert.ToInt32(Convert.ToByte(99)), Convert.ToInt32(Convert.ToByte(99)));
                        TableView1.Columns.Add(TableViewLabelColumn5);
                        items.Add(TableViewLabelColumn5);
                        break;
                }
               
                TableView1.Rows.Clear();
                TableView1.DataSource = KPItable;
                TableView1.DataBind();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void frmUserKPI_KeyDown(object sender, KeyDownEventArgs e)
        {
            Close();
        }

        private void frmUserKPI_TitleImageClick(object sender, EventArgs e)
        {
            Close();
        }

        private void frmUserKPI_LeftSlipping(object sender, EventArgs e)
        {
            try
            {
                if (TextTabBar1.SelectItemIndex > 0 & TextTabBar1.SelectItemIndex <= 1)
                {
                    TextTabBar1.SelectItemIndex = 0;
                    Bind();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmUserKPI_RightSlipping(object sender, EventArgs e)
        {
            try
            {
                if (TextTabBar1.SelectItemIndex >= 0 & TextTabBar1.SelectItemIndex < 1)
                {
                    TextTabBar1.SelectItemIndex = 1;
                    Bind();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}