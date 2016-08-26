using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;

namespace COMSSmobilerDemo.FixedAssets.NootBooks
{
    partial class frmNBDetail : Smobiler.Core.MobileForm
    {
        public string NO = "";

        private void frmNBDetail_KeyDown(object sender, KeyDownEventArgs e)
        {
            Close();
        }

        private void frmNBDetail_TitleImageClick(object sender, EventArgs e)
        {
            Close();
        }

        private void frmNBDetail_Load(object sender, EventArgs e)
        {
            Bind();
        }
        private void Bind()
        {

            lblNB_EQNO.Text = "NB001";
            lblNB_SN.Text = "L_x0035";
            //型号
            lblNB_MODEL.Text = "E530";
            lblNB_OWNER.Text = "";
            lblNB_CHECK.Text = "";
            lblState.Text = "正常";
            //所在位置
            lblNB_LOCATION.Text = "上海";
            //购买时间
            lblNB_BUYDATE.Text = DateTime.Now.ToString();
            //保修期
            lblNB_WARRANTYPERIOD.Text = "2年";
            //配置清单
            lblNB_CONFIG.Text = "硬盘";
            //价格
            lblNB_PRICE.Text = "5500";
            //确认价格
            lblNB_CONFIRMPRICE.Text = "5200";
            //折旧年限
            lblNB_YEAR.Text = "1年";

        }

        /// <summary>
        /// toolbar事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void frmNBDetail_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
        {
            try
            {
                switch (e.Name)
                {
                    case "Edit":
                        frmNBEdit frm = new frmNBEdit();
                        this.Redirect(frm, (MobileForm form, object args) =>
                        {
                            if (frm.ShowResult == Smobiler.Core.ShowResult.Yes)
                            {
                                ShowResult = Smobiler.Core.ShowResult.Yes;
                                Bind();
                            }
                        });
                        break;
                    case "Scrap":
                        MessageBox.Show("是否确定报废笔记本？", "报废", MessageBoxButtons.YesNo, (object s, MessageBoxHandlerArgs args) =>
                        {
                            if (args.Result == Smobiler.Core.ShowResult.Yes)
                            {
                                MessageBox.Show("笔记本已报废！");
                            }
                        });
                        break;
                    case "Transfer":
                        PopList1.Groups.Clear();
                        PopListGroup poli = new PopListGroup();
                        PopList1.Groups.Add(poli);
                        COMSSmobilerDemo.common.NBInfo NBInfo = new COMSSmobilerDemo.common.NBInfo();
                        DataTable table = NBInfo.AddressData();
                        poli.Text = "转移位置";
                        foreach (DataRow rowli in table.Rows)
                        {
                            poli.Items.Add(rowli["Address"].ToString(), rowli["ID"].ToString());
                        }

                        PopList1.ShowDialog();
                        break;
                    case "Record":
                        frmNBRecordMain frm1 = new frmNBRecordMain();
                        this.Redirect(frm1, (MobileForm form, object args) =>
                        {
                            try
                            {
                                if (frm1.ShowResult == Smobiler.Core.ShowResult.Yes)
                                {
                                    Bind();
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        });
                        break;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}