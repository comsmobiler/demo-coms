using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Xml;
using COMSSmobilerDemo.Message;
namespace COMSSmobilerDemo
{
    public partial class frmLogon : Smobiler.Core.MobileForm
    {
         DateTime taosttime  ;
        ///登录事件
        private void btn_Logo_Click(object sender, System.EventArgs e)
        {
            try
            {
                string UserID = txtName.Text;
                string Password = txtPwd.Text;
                if (UserID.Length <= 0)
                    throw new Exception("用户名必须输入!");
                if (Password.Length <= 0)
                    throw new Exception("密码必须输入!");
                //验证密码

                if (CheckBox1.Checked == true)
                {
                    //添加客户端数据
                    LoadClientData("user", UserID);

                    LoadClientData("pwd", Password);
                }
                else
                {

                    //删除客户端数据
                    RemoveClientData("pwd", (object s, ClientDataCallBackHandlerArgs args) =>
                    {
                        txtPwd.Text = "";
                    });
                }

                frmMune  frm = new frmMune ();
                this.Redirect(frm, (MobileForm sender1, object args) =>
                {
                    LblMsg.Text = "";
                }
                    );
            }
            catch (Exception ex)
            {
                LblMsg.Text = ex.Message;
                LblMsg.Visible = true;
                LblMsg.ForeColor = System.Drawing.Color.Red;
            }
        }


        private void frmLogon_Load(object sender, System.EventArgs e)
        {
            isNewDeviceVersion();
            //读取客户端数据
            ReadClientData("user", (object s, ClientDataCallBackHandlerArgs args) =>
            {

                if (string.IsNullOrEmpty(args.ErrorInfo))
                {
                    txtName.Text = args.Value;
                }
            });

            ReadClientData("pwd", (object s, ClientDataCallBackHandlerArgs args) =>
            {
                if (string.IsNullOrEmpty(args.ErrorInfo))
                {
                    txtPwd.Text = args.Value;
                    if (txtPwd.Text.Length > 0)
                    {
                        CheckBox1.Checked = true;
                    }
                }
            });

        }

        /// <summary>
        /// 手势验证
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGestures_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Client.Pattern.Password)==false )
            {
                //调用自动手势验证
                Client.Pattern.VerifyLocal((object s,Smobiler.Core.API.PatternLocalVerifiedEventArgs args)=>
                    {
                        if (args.IsError == false)
                        {
                            //手势验证成功，跳转到菜单界面
                            frmMune  frm = new frmMune ();
                            this.Redirect(frm, (MobileForm sender1, object arg) =>
                            {
                                LblMsg.Text = "";
                            }
                                );
                        }
                    }
                 );
            }
              
        }
        /// <summary>
        /// 客户端版本更新
        /// </summary>
        /// <returns></returns>
        private bool isNewDeviceVersion()
        {
            try
            {
                //版本号更新
                //dynamic servicer = this.Client.Version;//获取当前打包版版本号
                dynamic servicer = this.Client.DeviceVersion;//获取当前版本号
                //获取最新版本号
                System.Xml.XmlTextReader reader = new System.Xml.XmlTextReader("ServicerNO.xml");
                System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
                doc.Load(reader);
                XmlNode xnode = doc.DocumentElement.FirstChild;
                string servicerNew = xnode.Value.ToString();
                //判断当前客户端是否是最新版本，否则更新客户端
                if (string.IsNullOrWhiteSpace(servicerNew) == false)
                {
                    System.Version servicerVer = Version.Parse(servicerNew);
                    if (this.Client.DeviceVersion < servicerVer)
                    {
                        this.Client.ClientUpdate("http://smobiler.com/");
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        /// <summary>
        /// 手机自带回退按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmLogon_KeyDown(object sender, KeyDownEventArgs e)
        {
           if (e.KeyCode == KeyCode.Back) 
           {
                if ( taosttime.AddSeconds(3) >= DateTime.Now )
                {
                    Client.Exit(false);
                }
               else 
                {
                    taosttime = DateTime.Now;
                    Toast("再按一次退出应用", ToastLength.SHORT);
                }
           }
        }

    }
}
