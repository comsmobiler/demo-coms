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
        //经度
        private decimal Longitude = 0;
        //纬度
        private decimal Latitude = 0;
        private string addressInfo = "";

        /// <summary>
        /// 初始化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSignInCreate_Load(object sender, EventArgs e)
        {
            lblDate.Text =DateTime .Now.ToString();
	Gps1.GetGps();
	setbtnColor();
	setbtnColorP();
}
/// <summary>
/// 动态更改控件字体颜色
/// </summary>
/// <remarks></remarks>
private void setbtnColor()
{
	if (string.IsNullOrWhiteSpace(Type) == false) {
		btntype.ForeColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(102)), Convert.ToInt32(Convert.ToByte(99)), Convert.ToInt32(Convert.ToByte(99)));
	} else {
		btntype.ForeColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(193)), Convert.ToInt32(Convert.ToByte(193)), Convert.ToInt32(Convert.ToByte(193)));
	}
}
/// <summary>
/// 动态更改控件字体颜色
/// </summary>
/// <remarks></remarks>
private void setbtnColorP()
{
	if (string.IsNullOrWhiteSpace(PunchCardType) == false) {
		btnPunchCardType.ForeColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(102)), Convert.ToInt32(Convert.ToByte(99)), Convert.ToInt32(Convert.ToByte(99)));
	} else {
		btnPunchCardType.ForeColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(193)), Convert.ToInt32(Convert.ToByte(193)), Convert.ToInt32(Convert.ToByte(193)));
	}
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
                    Longitude = e.Longitude;
                    Latitude = e.Latitude;
                    addressInfo = e.Location;
                    lblAddress.Text = e.Location;
                    MapView1.GeoTag = new GeoTag(Longitude, Latitude, addressInfo);
                }
                else
                {
                    lblAddress.Text = "定位失败";
                }

            }
            else
            {
                lblAddress.Text = "定位失败";
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
                        setbtnColor();
                        break;
                    case "btnPunchCardType":
                    case "btnPunchCardType2":
                        PunchCardType = PopList1.Selection.Value;
                        btnPunchCardType.Text = PopList1.Selection.Text;
                        setbtnColorP();
                        break;
                }
            }
        }

        private void frmSignInCreate_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
        {
            try 
   {
                 if (e.Name.Equals(SignIn.Name))
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

        /// <summary>
        /// 地点微调
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddress_Click(object sender, EventArgs e)
        {
            if (Longitude != 0 & Latitude != 0 & addressInfo.Trim().Length > 0)
            {
                this.Gps1.GetEditGps(new GPSData(Longitude, Latitude, addressInfo));
            }
            else
            {
                Toast("定位失败");
            }

        }

        /// <summary>
        /// 返回
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSignInCreate_TitleImageClick(object sender, EventArgs e)
        {
            HandleToast();
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
                this.Toast("再按一次退出界面", ToastLength.SHORT);
            }
        }

    }
}