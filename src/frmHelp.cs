using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
namespace COMSSmobilerDemo
{
    public partial class frmHelp : Smobiler.Core.MobileForm
    {
        internal string LeftLayoutAction = "";
        private void frmHelp_LeftLayoutItemClick(object sender, MobileFormLayoutItemEventArgs e)
        {
            switch (e.CellItem.Name)
            {
                case "imgbz":
                case "btnbz":
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
                this.Client.Exit(false);
            }
            else
            {
                handleExit = true;
                taosttime = DateTime.Now;
                this.Toast("再按一次退出系统", ToastLength.SHORT);
            }
        }

        private void frmHelp_Load(object sender, EventArgs e)
        {
            Bind();
        }

        private  void Bind()
        {
            LeftLayoutExtension.upleftLayoutbtncolorExt(this);
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

        private void frmHelp_TitleImageClick(object sender, EventArgs e)
        {
            this.ShowSlider(Slider.Left);
        }
    }
}