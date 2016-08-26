using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace COMSSmobilerDemo.RecipientsItems
{
    partial class frmRIDetail : Smobiler.Core.MobileForm
    {
        public string NO = "";//运维编号
        private void frmRIDetail_KeyDown(object sender, KeyDownEventArgs e)
        {
            Close();
        }

        private void frmRIDetail_TitleImageClick(object sender, EventArgs e)
        {
            Close();
        }

        private void frmRIDetail_Load(object sender, EventArgs e)
        {
            lblITEM_NAME.Text = "沐浴露";
            lblITEM_QTY.Text = "1";
            lblITEM_DATE.Text =DateTime .Now .ToShortDateString() ;
            lblITEM_USER.Text ="Demo";
            lblITEM_NOTE.Text ="八月份劳保";
            imgITEM_SIGNATURE.ResourceID = "";
        }
    }
}