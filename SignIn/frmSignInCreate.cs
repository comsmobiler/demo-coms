using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using COMSSmobilerDemo.common;
using System.Data;

namespace COMSSmobilerDemo.SignIn
{
    partial class frmSignInCreate : Smobiler.Core.MobileForm
    {
        private string Type = "";
        private string PunchCardType = "";
        private object  btn;
       

        /// <summary>
        /// 初始化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSignInCreate_Load(object sender, EventArgs e)
        {
            lblDate.Text =DateTime .Now.ToString();
            Gps1.GetGps();
        }

        /// <summary>
        /// 打卡地方赋值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Gps1_GotLocation(object sender, GPSData e)
        {
            if ((e.IsError).Equals (false))
            {
                if (e.Longitude != 0 & e.Latitude != 0)
                {
                    txtAddress.Text = e.Location;
                   
                }
            }
        }
        /// <summary>
        /// 类型和打卡类型选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btntype2_Click(object sender, EventArgs e)
        {
            try
            {
                btn = sender;
                PopList1.Groups.Clear();
                PopListGroup popg = new PopListGroup();
                PopList1.Groups.Add(popg);
                SignIninfo SignIninfo = new SignIninfo();
                DataTable table = new DataTable();
                switch (((Button)sender).Name)
                {
                    case "btntype":
                    case "btntype2":
                        popg.Text = "类型";
                        table = SignIninfo.StateData1();
                        break;
                    case "btnPunchCardType":
                    case "btnPunchCardType2":
                        popg.Text = "打卡类型";
                        table = SignIninfo.StateData();
                        break;
                }
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        popg.Items.Add(row["StateName"].ToString (),row["State"].ToString ());
                        switch (((Button)sender).Name)
                        {
                            case "btntype":
                            case "btntype2":
                                if (Type.Trim().Length > 0)
                                {
                                    if (Type.Trim().Equals ( row["State"].ToString().Trim ()))
                                    {
                                        PopList1.SetSelections(popg.Items[(popg.Items.Count - 1)]);
                                    }
                                }
                                break;
                            case "btnPunchCardType":
                            case "btnPunchCardType2":
                                if (PunchCardType.Trim().Length > 0)
                                {
                                    if (PunchCardType.Trim().Equals ( row["State"].ToString().Trim()))
                                    {
                                        PopList1.SetSelections(popg.Items[(popg.Items.Count - 1)]);
                                    }
                                }
                                break;
                        }
                    }
                }
                PopList1.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 类型和打卡类型赋值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PopList1_Selected(object sender, EventArgs e)
        {
            if (PopList1.Selection != null)
            {
                switch (((Button)btn).Name)
                {
                    case "btntype":
                    case "btntype2":
                        Type = PopList1.Selection.Value;
                        btntype.Text = PopList1.Selection.Text;
                        break;
                    case "btnPunchCardType":
                    case "btnPunchCardType2":
                        PunchCardType = PopList1.Selection.Value;
                        btnPunchCardType.Text = PopList1.Selection.Text;
                        break;
                }
            }
        }

        private void frmSignInCreate_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
        {
            try 
   {
                if (e.Name.Equals(tExit.Name))
                {
                    MessageBox.Show("是否确定返回？", MessageBoxButtons.YesNo, (Object s, MessageBoxHandlerArgs args) =>
                    {
                        if (args.Result == Smobiler.Core.ShowResult.Yes)
                        {
                            this.Close();
                        }
                    }
                    );

                }
                else if (e.Name.Equals(SignIn.Name))
                {
                    MessageBox.Show("签到成功！", (Object s, MessageBoxHandlerArgs args) =>
                    {
                        ShowResult = Smobiler.Core.ShowResult.Yes;
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}