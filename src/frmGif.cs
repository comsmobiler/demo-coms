using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace COMSSmobilerDemo
{
    partial class frmGif : Smobiler.Core.MobileForm
    {
        private void frmGif_FooterBarLayoutItemClick(object sender, MobileFormLayoutItemEventArgs e)
        {
            frmLogon frm = new frmLogon(); this.Redirect(frm);
        }
    }
}