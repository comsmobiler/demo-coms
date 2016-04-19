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

                frmMessage frm = new frmMessage();
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


    }
}
