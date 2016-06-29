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
namespace COMSSmobilerDemo
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
        internal string LeftLayoutAction = "";

        /// <summary>
        /// 初始化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMessage_Load(object sender, EventArgs e)
        {
            LeftLayoutExtension.upleftLayoutbtncolorExt(this);
            Bind();
           
        }

        /// <summary>
        /// 初始化方法
        /// </summary>
        private void Bind()
        {
            try
            {
                //调用GPS
                Gps1.GetGps();
               
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
        /// 左侧栏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void frmMessage_LeftLayoutItemClick(object sender, MobileFormLayoutItemEventArgs e)
        {
            switch (e.CellItem.Name)
            {
                case "imgtz":
                case "btntz":
                    this.CloseSlider();
                    break;
                case "imgtc":
                case "btnExit":
                    MessageBox.Show("是否确定退出系统？", MessageBoxButtons.YesNo, (Object s, MessageBoxHandlerArgs args) =>
                    {
                        if (args.Result == Smobiler.Core.ShowResult.Yes)
                        {
                            this.Close();
                        }
                    }
                     );
                    break;
                default:
                    LeftLayoutAction = e.CellItem.Name;
                    this.Close();
                    break;
            }
        }


        private DateTime taosttime;
        private bool handleExit = false;
        /// <summary>
        /// 手机自带回退按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MobileForm_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
            {
                HandleToast();
            }
        }

        private void HandleToast()
        {
            if (handleExit == true && taosttime.AddSeconds(3) >= DateTime.Now)
            {
                handleExit = false;
                this.Close();
            }
            else
            {
                handleExit = true;
                taosttime = DateTime.Now;
                this.Toast("再按一次退出系统", ToastLength.SHORT);
            }
        }
        private void frmMessage_TitleImageClick(object sender, EventArgs e)
        {
            ShowSlider(Slider.Left);
        }
        private void Gps1_GotLocation(object sender, GPSData e)
        {
            try
            {
                if (e.Longitude.Equals(0) & e.Latitude.Equals(0))
                {
                    this.LeftLayoutData.Items["lblAddress"].Text = "";
                }
                else
                {
                    this.LeftLayoutData.Items["lblAddress"].Text = e.Location;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
        /// gridview下拉事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridView1_DownSlippling(object sender, EventArgs e)
        {
            Toast("数据已加载完成！",ToastLength.SHORT);
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
                    Toast("数据已加载完成！", ToastLength.SHORT);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}