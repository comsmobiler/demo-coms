using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;

namespace COMSSmobilerDemo.FixedAssets.NootBooks
{
    partial class frmNBCreate : Smobiler.Core.MobileForm
    {

        private int State;
        private object  btnName;
        private string Address = "";
        private string Owner = "";
        /// <summary>
        /// 初始化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void frmNBCreate_Load(object sender, EventArgs e)
        {
            State = Convert .ToInt32 (NBStates.正常);
            btnState.Text = ((NBStates)State).ToString();
            Address = ((NBAddress)NBAddress.上海 ).ToString();
            btnNB_LOCATION.Text = Address;
            Owner = NBOWNER.Smobiler.ToString ();
            btnNB_OWNER.Text = ((NBOWNER)NBOWNER.Smobiler ).ToString();
            txtNB_CHECK.Text = "Demo";
            txtNB_CHECK.ReadOnly = true;
             
        }

        /// <summary>
        /// toolbar事件
        /// </summary> 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void frmNBCreate_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
        {
            try
            {
                switch (e.Name)
                {
                    case "save":
                      
                        //序号
                        if (txtNB_SN.Text.Trim().Length <= 0)
                        {
                            throw new Exception("请输入序号！");
                        }

                        //型号
                        if (txtNB_MODEL.Text.Trim().Length <= 0)
                        {
                            throw new Exception("请输入型号！");
                        }
                        //所有者
                        if (btnNB_OWNER.Text.Trim().Length <= 0)
                        {
                            throw new Exception("请输入所有者！");
                        }
                        //责任人
                        if (txtNB_CHECK.Text.Trim().Length <= 0)
                        {
                            throw new Exception("请输入责任人！");
                        }
                        //状态
                        if (btnState.Text.Trim().Length <= 0)
                        {
                            throw new Exception("请输入状态！");
                        }
                        //所在位置
                        if (btnNB_LOCATION.Text .Trim().Length <= 0)
                        {
                            throw new Exception("请输入所在位置！");
                        }
                       
                        //保修期
                        if (txtNB_WARRANTYPERIOD.Text.Trim().Length <= 0)
                        {
                            throw new Exception("请输入保修期！");
                        }
                        //配置清单
                        if (txtNB_CONFIG.Text.Trim().Length <= 0)
                        {
                            throw new Exception("请输入配置清单！");
                        }
                        //价格
                        if (txtNB_PRICE.Text.Trim().Length <= 0)
                        {
                            throw new Exception("请输入价格！");
                        }
                        //确认价格
                        if (txtNB_CONFIRMPRICE.Text.Trim().Length <= 0)
                        {
                            throw new Exception("请输入确认价格！");
                        }
                        //折旧年限
                        if (txtNB_YEAR.Text.Trim().Length <= 0)
                        {
                            throw new Exception("请输入折旧年限！");
                        }

                        MessageBox.Show("笔记本已创建成功！", (Object s, MessageBoxHandlerArgs args) =>
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

        /// <summary>
        /// 删除发票照片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void btndelPhoto_Click(object sender, EventArgs e)
        {
            if (imgNB_INVOCIEIMGID.ResourceID.Length > 0)
            {
                MessageBox.Show("是否确定删除发票照片？", "发票删除", MessageBoxButtons.YesNo, (object s, MessageBoxHandlerArgs args) =>
                {
                    if (args.Result == Smobiler.Core.ShowResult.Yes)
                    {
                        if (imgNB_INVOCIEIMGID.ResourceID.Trim().Length > 0)
                        {
                            imgNB_INVOCIEIMGID.ResourceID = "";
                            imgNB_INVOCIEIMGID.Enlarged = false;
                        }
                    }
                });
            }
            else
            {
                MessageBox.Show("您没有上传发票照片，不能删除！");
            }
        }

        /// <summary>
        /// 发票上传
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void btnupPhoto_Click(object sender, EventArgs e)
        {
            Camera1.GetPhoto();
        }

        /// <summary>
        /// 赋值发票
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void Camera1_ImageCaptured(object sender, BinaryData e)
        {
            try
            {
                if (string.IsNullOrEmpty(e.ErrorInfo))
                {
                    if (imgNB_INVOCIEIMGID.ResourceID.Length > 0)
                    {
                        e.SaveFile(imgNB_INVOCIEIMGID.ResourceID);
                        imgNB_INVOCIEIMGID.Refresh();
                    }
                    else
                    {
                        e.SaveFile();
                        imgNB_INVOCIEIMGID.ResourceID = e.ResourceID;
                    }
                    imgNB_INVOCIEIMGID.Enlarged = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnState_Click(object sender, EventArgs e)
        {
            try
            {
                btnName =sender;
                PopList1.Groups.Clear();
                PopListGroup poli = new PopListGroup();
                PopList1.Groups.Add(poli);
                COMSSmobilerDemo.common.NBInfo NBInfo = new COMSSmobilerDemo.common.NBInfo();
                switch (((Button)sender).Name)
                {
                    case "btnNB_OWNER":
                    case "btnNB_OWNER2":
                        DataTable table = NBInfo.OwnerData();
                        poli.Text = "所有者选择";
                        foreach (DataRow rowli in table.Rows)
                        {
                            poli.Items.Add(rowli["NB_OWNER1"].ToString (), rowli["NB_OWNER"].ToString ());
                            if (string .IsNullOrWhiteSpace (Owner) == false)
                            {
                                if (Owner.Equals(rowli["NB_OWNER"]))
                                {
                                    PopList1.SetSelections(poli.Items[(poli.Items.Count - 1)]);
                                }
                            }
                        }

                        break;
                    case "btnState":
                    case "btnState2":
                        DataTable table1 = NBInfo.StateData();
                        poli.Text = "状态选择";
                        foreach (DataRow rowli in table1.Rows)
                        {
                            poli.Items.Add(rowli["StateName"].ToString(), rowli["State"].ToString());
                            if (string .IsNullOrWhiteSpace (State.ToString ()) == false)
                            {
                                if (State.Equals(rowli["State"]))
                                {
                                    PopList1.SetSelections(poli.Items[(poli.Items.Count - 1)]);
                                }
                            }
                        }

                        break;
                    case "btnNB_LOCATION":
                    case "btnNB_LOCATION2":
                        DataTable table2 = NBInfo.AddressData();
                        poli.Text = "所在位置";
                        foreach (DataRow rowli in table2.Rows)
                        {
                            poli.Items.Add(rowli["Address"].ToString(), rowli["ID"].ToString());
                            if (Address.Trim().Length > 0)
                            {
                                if (Address.Equals(rowli["Address"]))
                                {
                                    PopList1.SetSelections(poli.Items[(poli.Items.Count - 1)]);
                                }
                            }
                        }

                        break;
                }
                PopList1.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// 状态或位置赋值
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
                    switch (((Button)btnName ).Name)
                    {
                        case "btnNB_OWNER":
                        case "btnNB_OWNER2":
                            Owner = PopList1.Selection.Value;
                            btnNB_OWNER.Text = PopList1.Selection.Text.Trim();
                            if (btnNB_OWNER.Text.Equals(((NBOWNER)NBOWNER.Smobiler ).ToString()))
                            {
                                txtNB_CHECK.Text = "Demo";
                                txtNB_CHECK.ReadOnly = true;
                            }
                            else
                            {
                                txtNB_CHECK.ReadOnly = false;
                                txtNB_CHECK.Text = "";
                            }
                            break;
                        case "btnState":
                        case "btnState2":
                            State =int .Parse ( PopList1.Selection.Value);
                            btnState.Text = PopList1.Selection.Text.Trim();
                            break;
                        case "btnNB_LOCATION":
                        case "btnNB_LOCATION2":
                            Address = PopList1.Selection.Text.Trim();
                            btnNB_LOCATION.Text = PopList1.Selection.Text.Trim();
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private DateTime taosttime;
        private void MobileForm_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
            {
                HandleToast();
            }
        }

        private void HandleToast()
        {
            if ( taosttime.AddSeconds(3) >= DateTime.Now)
            {
                this.Close();
            }
            else
            {
                taosttime = DateTime.Now;
                this.Toast("再按一次退出界面", ToastLength.SHORT);
            }
        }

        private void frmNBCreate_TitleImageClick(object sender, EventArgs e)
        {
            HandleToast();
        }
    }
}