using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;

namespace COMSSmobilerDemo.FixedAssets.NootBooks
{
    partial class frmNBRecordCreate : Smobiler.Core.MobileForm
    {

        private object  btnName;
        private int State;
        private int Type;
        private string User = "";
        internal string NB_EQNO = "";
        private void btnpop_Click(object sender, EventArgs e)
        {
            try
            {
                btnName = sender;
                COMSSmobilerDemo.common.NBRecordInfo NBRecordInfo = new COMSSmobilerDemo.common.NBRecordInfo();
                COMSSmobilerDemo.common.NBInfo NBInfo = new COMSSmobilerDemo.common.NBInfo();
                
                DataTable table = new DataTable();
                PopList1.Groups.Clear();
                PopListGroup poli = new PopListGroup();
                PopList1.Groups.Add(poli);
                switch (((Button)btnName).Name)
                {
                    case "btnCODE2":

                        table = NBInfo.GetNootBooksData(0,3);
                        poli.Text = "笔记本序列号选择";
                        foreach (DataRow rowli in table.Rows)
                        {
                            poli.Items.Add(rowli["NB_EQNO"].ToString(), rowli["NB_EQNO"].ToString());
                            if (string.IsNullOrWhiteSpace(NB_EQNO) == false)
                            {
                                if (NB_EQNO.Equals(rowli["NB_EQNO"].ToString()))
                                {
                                    PopList1.SetSelections(poli.Items[(poli.Items.Count - 1)]);
                                }
                            }
                        }

                        break;
                    case "btnUser":
                    case "btnUser2":
                        table = NBRecordInfo.GetUserData();
                        poli.Text = "用户选择";
                        foreach (DataRow rowli in table.Rows)
                        {
                            poli.Items.Add(rowli["USER_NAME"].ToString(), rowli["USER_ID"].ToString());
                            if (string.IsNullOrWhiteSpace(User) == false)
                            {
                                if (User.Trim().ToUpper() == rowli["USER_ID"].ToString().Trim().ToUpper())
                                {
                                    PopList1.SetSelections(poli.Items[(poli.Items.Count - 1)]);
                                }
                            }
                        }

                        break;
                    case "btnType":
                    case "btnType2":
                        table = NBRecordInfo.StateData();
                        poli.Text = "操作类型选择";
                        foreach (DataRow rowli in table.Rows)
                        {
                            poli.Items.Add(rowli["StateName"].ToString (), rowli["State"].ToString ());
                            if (Type.ToString ().Length >0)
                            {
                                if (Type.Equals(rowli["State"]))
                                {
                                    PopList1.SetSelections(poli.Items[(poli.Items.Count - 1)]);
                                }
                            }
                        }

                        break;
                    case "btnNBR_LOCATION":
                    case "btnNBR_LOCATION2":
                        table = NBInfo.AddressData();
                        poli.Text = "所在位置";
                        foreach (DataRow rowli in table.Rows)
                        {
                            poli.Items.Add(rowli["Address"].ToString(), rowli["ID"].ToString());
                            if (btnNBR_LOCATION.Text.Trim().Length > 0)
                            {
                                if (btnNBR_LOCATION.Text.Equals(rowli["Address"]))
                                {
                                    PopList1.SetSelections(poli.Items[(poli.Items.Count - 1)]);
                                }
                            }
                        }

                        break;
                }
                PopList1.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 赋值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void PopList1_Selected(object sender, EventArgs e)
        {
            try
            {
                if (PopList1.Selection != null)
                {
                    switch (((Button)btnName).Name)
                    {
                        case "btnCODE2":
                            NB_EQNO = PopList1.Selection.Value;
                            this.txtNB_EQNO.Text = PopList1.Selection.Text.Trim();
                            break;
                        case "btnUser":
                        case "btnUser2":
                            User = PopList1.Selection.Value;
                            this.btnUser.Text = PopList1.Selection.Text.Trim();
                            break;
                        case "btnType":
                        case "btnType2":
                            Type = Convert.ToInt32 (PopList1.Selection.Value);
                            this.btnType.Text = PopList1.Selection.Text.Trim();
                            break;
                        case "btnNBR_LOCATION":
                        case "btnNBR_LOCATION2":
                            btnNBR_LOCATION.Text = PopList1.Selection.Text.Trim();
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 初始化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void frmNoteBooksRecordCreate_Load(object sender, EventArgs e)
        {
            Type = Convert .ToInt32 (NBROTYPE.开始使用);
            btnType.Text = ((NBROTYPE)Type).ToString();
            btnNBR_LOCATION.Text = ((NBAddress)NBAddress.上海).ToString();
            if (NB_EQNO.Length > 0)
            {
                txtNB_EQNO.Text = NB_EQNO;
            }
        }

        private void frmNBRecordCreate_TitleImageClick(object sender, EventArgs e)
        {
            HandleToast();
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
                this.Toast("再按一次退出界面", ToastLength.SHORT);
            }
        }
        /// <summary>
        /// 扫码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void btnNB_CODE_BarcodeScanned(object sender, BarcodeData e)
        {
            if (string.IsNullOrEmpty(e.ErrorInfo))
            {
                if (e.Barcode.Length > 0)
                {
                    txtNB_EQNO.Text = e.Barcode;
                }
            }
        }

        private void frmNBRecordCreate_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
        {
            try
            {
                switch (e.Name)
                {
                    case "save":
                        if (string.IsNullOrWhiteSpace(User) == true )
                        {
                            throw new Exception("请输入用户！");
                        }
                        if (btnNBR_LOCATION.Text.Trim().Length<= 0)
                        {
                            throw new Exception("请输入所在位置！");
                        }

                        MessageBox.Show("笔记本记录已创建成功！", (Object s, MessageBoxHandlerArgs args) =>
                        {
                            ShowResult = Smobiler.Core.ShowResult.Yes;
                            this.Close();
                        });
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