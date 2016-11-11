using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
using Smobiler.Core.Controls;
using COMSSmobilerDemo.Reimbursement.CostCenter;
using COMSSmobilerDemo.Reimbursement.RB;
using COMSSmobilerDemo.Message;
namespace COMSSmobilerDemo
{
    public partial class frmInfo : Smobiler.Core.MobileForm
    {

        internal string LeftLayoutAction = "";

        /// <summary>
        /// 初始化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void frminfo_Load(object sender, EventArgs e)
        {
            Bind();
        }
        private void Bind()
        {
            LeftLayoutExtension.upleftLayoutbtncolorExt(this);
            this.Gps1.GetGps();
            imguser.ResourceID = "Demo";
            lblUserName.Text = "测试用户";
            lblSex.Text = "男";
        }


        private void frminfo_LeftLayoutItemClick(object sender, MobileFormLayoutItemEventArgs e)
        {
            switch (e.CellItem.Name)
            {
                case "imginfo":
                case "btninfo":
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
                    this.LeftLayoutAction = e.CellItem.Name;
                    this.Close();
                    break;
            }
        }

        private DateTime taosttime;
        private bool handleExit = false;
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
        private void frminfo_TitleImageClick(object sender, EventArgs e)
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

        private void frmInfo_FooterBarLayoutItemClick(object sender, MobileFormLayoutItemEventArgs e)
        {
            frmInfoEdit frm = new frmInfoEdit();
             this.Redirect(frm);
        }
        /// <summary>
        /// 打电话
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imgbtnPhone_Click(object sender, EventArgs e)
        {
            Client.TelCall("10086");
        }
        /// <summary>
        /// 添加到通讯录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imgbtnAddTel_Click(object sender, EventArgs e)
        {
            Client.Contacts.Add("demo", "10086", "");
        }
        /// <summary>
        /// 发送短信
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imgbtnSedM_Click(object sender, EventArgs e)
        {
            Client.SendSMS("", "10086");
        }
        /// <summary>
        /// 发送邮件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imgbtnSedEmail_Click(object sender, EventArgs e)
        {
            Client.SendEmail("测试", "testEmail", "lincy@smobiler.com");
        }
       

       
    }
}

