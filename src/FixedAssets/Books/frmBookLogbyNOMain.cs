using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;

namespace COMSSmobilerDemo.FixedAssets.Books
{
    partial class frmBookLogbyNOMain : Smobiler.Core.MobileForm
    {

        internal string BOOKNO;
        /// <summary>
        /// 初始化方法绑定数据
        /// </summary>
        /// <remarks></remarks>
        private void Bind()
        {
            try
            {
                DataTable table = GetBookLogData();
                if (table.Rows.Count > 0)
                {
                    this.GridView1.DataSource = table;
                    this.GridView1.DataBind();
                }
                else
                {
                    this.GridView1.Rows.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private DataTable GetBookLogData()
        {
            try
            {
                COMSSmobilerDemo.common.BookSNInfo BookSNInfo = new COMSSmobilerDemo.common.BookSNInfo();
                DataTable table = BookSNInfo.GetBookSNbyBookID1();
                return table;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void GridView1_CellClick(object sender, GridViewCellEventArgs e)
        {
            try
            {
                string ID = e.Cell.Items["lblID"].Value.ToString ();
                frmBookLogDetail frm = new frmBookLogDetail();
                frm.bLogID = ID;
                Redirect(frm);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmBookLogbyNOMain_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
        {
            try
            {
                switch (e.Name)
                {
                    case "add":
                        frmBookLogCreate frm = new frmBookLogCreate();
                        this.Redirect(frm, (MobileForm form, object args) =>
                        {
                            try
                            {
                                if (frm.ShowResult == Smobiler.Core.ShowResult.Yes)
                                {
                                    ShowResult = Smobiler.Core.ShowResult.Yes;
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

        private void frmBookLog_TitleImageClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBookLog_KeyDown(object sender, KeyDownEventArgs e)
        {
            this.Close();
        }

        private void TextTabBar1_ItemClick(object sender, TabBarItemClickEventArgs e)
        {
            Bind();
        }

        private void frmBookLog_Load(object sender, EventArgs e)
        {
            Bind();
        }
    }
}