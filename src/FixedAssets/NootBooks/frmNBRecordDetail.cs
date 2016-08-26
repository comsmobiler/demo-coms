using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace COMSSmobilerDemo.FixedAssets.NootBooks
{
    partial class frmNBRecordDetail : Smobiler.Core.MobileForm
    {
        public string ID;
        private void frmNBRecordDetail_Load(object sender, EventArgs e)
        {

                lblNB_EQNO.Text = "E530 L_x0035";
                lblUSER_ID.Text = "Demo";
                lblNBR_OTYPE.Text = "½è³ö";
                lblNBR_ODATE.Text =DateTime .Now .ToString ();
                lblNBR_LOCATION.Text = "ÉÏº£";
        }

        private void frmNBRecordDetail_KeyDown(object sender, KeyDownEventArgs e)
        {
            Close();
        }

        private void frmNBRecordDetail_TitleImageClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}