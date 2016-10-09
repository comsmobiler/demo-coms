using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;

namespace COMSSmobilerDemo.FixedAssets.Books
{
    partial class frmBookDetail : Smobiler.Core.MobileForm
    {

        internal string BOOKID;
        private List<string> imglist = new List<string>();
        private List<MobileControl> imglistC = new List<MobileControl>();
        private bool MustPrint = false;
        private int BookQty = 0;
        private void Bind()
        {
            try
            {

                    lblBOOKNAME.Text = "ASP.NET基础";
                    lblBOOKQUANTITY.Text = "2本";
                    lblBOOKUNITPRICE.Text =  "50元";
                    lblBOOKLOADSTOCK.Text =  "0本";
                    lblBOOKLOSEQTY.Text = "0本";
                    lblBOOKPUBLIDATE.Text = DateTime .Now.ToString () ;
                    lblBOOKBORROWQTY.Text ="0次";
                    lblAmount.Text = "100.00元";
                //图书图片
                    imglist.Add("Book1");
                    imglist.Add("Book2");
                if (imglist.Count > 0)
                {
                    CreateImg();
                    switch (imglist.Count)
                    {
                        case 1:
                        case 2:
                        case 3:
                        case 4:
                            GridView1.Top = 335 + 75 +13;
                            Height =Convert .ToInt32 ( GridView1.Top) + Height;
                            break;
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                            GridView1.Top = 335 + (75 * 2) + 13;
                            Height = Convert .ToInt32 (GridView1.Top) + Height;
                            break;
                        case 9:
                            GridView1.Top = 335 + (75 * 3) + 13;
                            Height = Convert.ToInt32(GridView1.Top) + Height;
                            break;
                    }
                }
                else
                {
                    GridView1.Top = 335;
                }
                COMSSmobilerDemo.common.BookSNInfo BookSNInfo = new COMSSmobilerDemo.common.BookSNInfo();
                DataTable table = BookSNInfo.GetBookSNbyBookID();
                GridView1.DataSource = table;
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private int  upleft = 0;
        private int uptop = 335;
        private void CreateImg()
        {
            for (int i = 1; i <= imglist.Count; i++)
            {
                if ((upleft + 75) > 300)
                {
                    upleft = 0;
                    if (uptop > Height)
                    {
                        Height = Height + 75;
                    }
                    uptop = uptop + 75;
                }
                Image Image1 = new Image();
                Image1.Left = upleft;
                Image1.Top = uptop;
                Image1.Width = 75;
                Image1.Height = 75;
                upleft = upleft + Image1.Width;
                Image1.ResourceID = imglist[i - 1];
                Image1.Name = "imgBook" + i.ToString();
                Image1.Enlarged = true;
                Image1.Border = new Smobiler.Core.Border(1, 0, 0, 1);
                Image1.BorderColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(230)), Convert.ToInt32(Convert.ToByte(230)), Convert.ToInt32(Convert.ToByte(230)));
                Controls.Add(Image1);
                imglistC.Add(Image1);
            }
        }
        private void frmBookDetail_TitleImageClick(object sender, EventArgs e)
        {
            Close();
        }

        private void frmBookDetail_KeyDown(object sender, KeyDownEventArgs e)
        {
            Close();
        }


        private void frmBookDetail_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
        {
            try
            {
                switch (e.Name)
                {
                    case "Edit":
                        frmBookEdit frm = new frmBookEdit();
                        frm.BookID = BOOKID;
                        this.Redirect(frm, (MobileForm form, object args) =>
                        {
                            try
                            {
                                if (frm.ShowResult == Smobiler.Core.ShowResult.Yes)
                                {
                                    ShowResult = Smobiler.Core.ShowResult.Yes;
                                    imglist.Clear();
                                    Bind();
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        });
                        break;
               
                    case "Record":
                        frmBookLogbyNOMain frm1 = new frmBookLogbyNOMain();
                        frm1.BOOKNO = BOOKID;
                        this.Redirect(frm1, (MobileForm form, object args) =>
                        {
                            try
                            {
                                if (frm1.ShowResult == Smobiler.Core.ShowResult.Yes)
                                {
                                    ShowResult = Smobiler.Core.ShowResult.Yes;
                                    if (imglistC.Count > 0)
                                    {
                                        foreach (MobileControl m in imglistC)
                                        {
                                            this.Controls.Remove(m);
                                        }
                                    }
                                    imglist.Clear();
                                    imglistC.Clear();
                                    upleft = 0;
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

        private void frmBookDetail_Load(object sender, EventArgs e)
        {
            Bind();
        }

       

      
    }
}