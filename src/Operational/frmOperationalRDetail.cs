using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;

namespace COMSSmobilerDemo.Operational
{
    partial class frmOperationalRDetail : Smobiler.Core.MobileForm
    {

        internal string CUNO;
        private void NodeView1_ItemClicked(object sender, EventArgs e)
        {
            try
            {
                string ORNO = NodeView1.ClickedItem.Text;
                frmOperationalREdit frm = new frmOperationalREdit();
                frm.OR_NO = ORNO;
                this.Redirect(frm, (MobileForm form, object args) =>
                {
                    if (frm.ShowResult == Smobiler.Core.ShowResult.Yes)
                    {
                        Bind();
                    }
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmOperationalRDetail_Load(object sender, EventArgs e)
        {
            Bind();
        }

        private void Bind()
        {
            try
            {
                TitleText = "客户一";
                NodeView1.Items.Clear();
                OperationalInfo OperationalInfo = new OperationalInfo();
                DataTable table = OperationalInfo.GetORDataByCU();
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        
                        NodeViewItem nodeItem = new NodeViewItem();
                        nodeItem.Text = row["OR_NO"].ToString();
                        nodeItem.TextColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(45)), Convert.ToInt32(Convert.ToByte(45)), Convert.ToInt32(Convert.ToByte(45)));
                        nodeItem.SubText = row["OR_FAULTINFO"].ToString();
                        nodeItem.SubTextColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(145)), Convert.ToInt32(Convert.ToByte(145)), Convert.ToInt32(Convert.ToByte(145)));
                        nodeItem.Icon = row["OR_PROCESSRESULT"].ToString ();
                        nodeItem.Date =Convert .ToDateTime ( row["OR_DECLAREDATE"]);
                        nodeItem.DateColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(145)), Convert.ToInt32(Convert.ToByte(145)), Convert.ToInt32(Convert.ToByte(145)));
                        NodeView1.Items.Add(nodeItem);
                    }
                }
                lblQty.Text = "运维记录：3" ;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void frmOperationalRDetail_TitleImageClick(object sender, EventArgs e)
        {
            Close();
        }

        private void frmOperationalRDetail_KeyDown(object sender, KeyDownEventArgs e)
        {
            Close();
        }
    }
}