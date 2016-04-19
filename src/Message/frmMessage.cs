using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using COMSSmobilerDemo.common;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using System.Net;
using System.IO;
using COMSSmobilerDemo.WorkDocument;
using COMSSmobilerDemo.Leave;
using COMSSmobilerDemo.Reimbursement.CostCenter;
namespace COMSSmobilerDemo.Message
{
    partial class frmMessage : Smobiler.Core.MobileForm
    {
        //总页数
        private int pagesCount = 0;
        //当前页
        private int pageIndex = 0;
        //当前页显示条数
        private int pagesize = 5;
        //消息收索信息变量
        private string searchinfo = "";
       

        /// <summary>
        /// 初始化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMessage_Load(object sender, EventArgs e)
        {
            Bind();
            getleftLayoutDate();
        }

        /// <summary>
        /// 初始化方法
        /// </summary>
        private void Bind()
        {
            try
            {
                pageIndex = 0;
                //当前页
                MessageInfo Message = new MessageInfo();
                //获取消息总页数
                pagesCount = 3;
                DataTable table = GetMessage();
                if (table.Rows.Count > 0)
                {
                    GridView1.DataSource = table;
                    GridView1.DataBind();
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

        private void getleftLayoutDate()
        {
            try
            {
                LeftLayoutData.Items["lblUser"].Text = "MobilerUser";
                 LeftLayoutData.Items["imgUser"].DefaultValue  = "MobilerUser";
            }
                  catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 获取消息数据
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        private DataTable  GetMessage()
        {
            DataTable table=new DataTable ();
            try
            {
                //根据当前页获取信息
                MessageInfo Message = new MessageInfo();
               table= Message.GetMessageData(searchinfo, pageIndex, pagesize);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return table;
        }

        /// <summary>
        /// 调用GPS
        /// </summary>
        /// <remarks></remarks>
        private void getGps()
        {
            try
            {
                //获取当前日期
                lbldatetime.Text = System.DateTime.Today.ToString("MM月dd日 dddd", new System.Globalization.CultureInfo("zh-CN"));
                //调用GPS
                Gps1.GetGps();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 天气插件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="certificate"></param>
        /// <param name="chain"></param>
        /// <param name="sslPolicyErrors"></param>
        /// <returns></returns>
        public static bool ValidateServerCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }

        /// <summary>
        /// 获取gps定位信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Gps1_GotLocation(object sender, GPSData e)
        {
          
                if (string.IsNullOrEmpty(e.ErrorInfo))
                {
                    if (e.Longitude.Equals(0) & e.Latitude.Equals(0))
                    {
                        this.LblGps.Text = "定位中...";
                    }
                    else
                    {
                        this.LblGps.Text = e.Location.ToString();
                    }
                }
                else
                {
                    this.LblGps.Text = "定位中...";
                }     
        }

        /// <summary>
        /// 消息信息查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchinfo = txtSearchinfo.Text.Trim();
            Bind();
        }

        /// <summary>
        /// 行项点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridView1_CellClick(object sender, GridViewCellEventArgs e)
        {
            try
            {
                string NO = e.Cell.Items["lblNOTE"].Value.ToString ();
                int state=Convert.ToInt32(e.Cell.Items["lblNOTE1"].Value.ToString());
                switch (state)
                {
                    case (int)MessageStates.工作单:
                        frmWorkDocumentDetail1 frm = new frmWorkDocumentDetail1();

                        this.Redirect(frm, (MobileForm from ,object args) =>
                        {
                            if (frm.ShowResult == Smobiler.Core.ShowResult.Yes)
                            {
                                Bind();
                            }
                        });
                        break;
                    case (int)MessageStates.请假:
                        frmLeaveDef1 frm1 = new frmLeaveDef1();
                      
                        this.Redirect(frm1, (MobileForm from, object args) =>
                        {
                            if (frm1.ShowResult == Smobiler.Core.ShowResult.Yes)
                            {
                                Bind();
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

        /// <summary>
        /// toolbar点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMessage_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
        {
            try
            {

                switch (e.Name)
                {
                    case "RB":
                        frmRBMune frmRBMune = new frmRBMune();
                        this.Redirect(frmRBMune, (MobileForm form, object args) => { this.Close(); });
                        break;
                    case "Other":
                        frmOtherMune frmMune = new frmOtherMune();
                        this.Redirect(frmMune, (MobileForm form, object args) => { this.Close(); });
                        break;
                    case "tExit":
                        MessageBox.Show("是否确定退出系统？", MessageBoxButtons.YesNo, (Object s, MessageBoxHandlerArgs args) =>
                        {
                            if (args.Result == Smobiler.Core.ShowResult.Yes)
                            {
                                this.Close();
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

        /// <summary>
        /// 左侧栏点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMessage_LeftLayoutItemClick(object sender, MobileFormLayoutItemEventArgs e)
        {
            try
            {
                switch (e.CellItem  .Name  )
                {
                    case "imgbtnMain":
                    case "btnMain":
                        this.CloseSlider();
                        break;
                    case "imgbtnUserCC":
                    case "btnUserCC":
                        frmAttentionCC frm = new frmAttentionCC();
                        frm.muneMode = 0;
                        this.Redirect(frm, (MobileForm form, object args) => this.Close());
                        break;
                    case "btnUser":
                        frmUserDetail frmUserDetail = new frmUserDetail();
                        frmUserDetail.muneMode = 0;
                        this.Redirect(frmUserDetail, (MobileForm form, object args) =>
                           {
                               if (frmUserDetail.ShowResult == Smobiler.Core.ShowResult.Yes)
                               {
                                   ((ImageButton)LeftLayoutData.Items["imgUser"].DefaultValue).Refresh();
                               }
                               this.Close();
                        });
                        break;
                    case "btnHelp":
                        this.RedirectUrl("帮助", "http://www.searching-info.com/coms/ComsSmobiler.html");
                        break;
                }
            }
                catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        /// <summary>
        /// gridview下拉事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridView1_DownSlippling(object sender, EventArgs e)
        {
            MessageBox.Show("数据已加载完成！");
        }

        /// <summary>
        /// gridview上拉事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridView1_UpSlippling(object sender, EventArgs e)
        {
            try
            {
                pageIndex += 1;
                if (pageIndex < pagesCount)
                {
                    DataTable table = GetMessage();
                    if (table.Rows.Count > 0)
                    {
                        this.GridView1.AddData(table);
                    }
                }
                else
                {
                    MessageBox.Show("数据已加载完成!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}