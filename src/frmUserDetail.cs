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
    public partial class frmUserDetail : Smobiler.Core.MobileForm
    {
      
        internal int muneMode;
        private void btnUpUserImg_Click(object sender, EventArgs e)
        {
            try
            {
                this.Camera1.GetPhoto();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ImageButton1_Click(object sender, EventArgs e)
        {
            this.ShowSlider(Slider.Left);
        }

        private void Camera1_ImageCaptured(object sender, BinaryData e)
        {
             try
            {
                if (string.IsNullOrEmpty(e.ErrorInfo))
                {
                    e.SaveFile("MobilerUser.png");
                    btnUpUserImg.Refresh();
                   // ((MobileViewCellItemImageButton )LeftLayoutData.Items["imgUser"].DefaultValue).Refresh();
                    ShowResult = Smobiler.Core.ShowResult.Yes;
                }
             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmUserDetail_LeftLayoutItemClick(object sender, MobileFormLayoutItemEventArgs e)
        {
            try
            {
                switch (e.CellItem .Name)
                {
                    case "imgbtnMain":
                    case "btnMain":
                        switch (muneMode)
                        {
                            case 0:
                                frmMessage frm = new frmMessage();
                                this.Redirect(frm, (MobileForm form, object args) => this.Close());
                                break;
                            case 1:
                                frmRBMune frmRBMune = new frmRBMune();
                                this.Redirect(frmRBMune, (MobileForm form, object args) => this.Close());
                                break;
                            case 2:
                                frmOtherMune frmOtherMune = new frmOtherMune();
                                this.Redirect(frmOtherMune, (MobileForm form, object args) => this.Close());
                                break;
                        }
                        break;
                    case "imgbtnUserCC":
                    case "btnUserCC":
                        frmAttentionCC frmAttentionCC = new frmAttentionCC();
                        frmAttentionCC.muneMode = muneMode;
                        this.Redirect(frmAttentionCC, (MobileForm form, object args) => this.Close());
                        break;
                    case "imgbtnUser":
                    case "btnUser":
                        this.CloseSlider();
                        break;
                    case "imgbtnHelp":
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
       
    }
}

