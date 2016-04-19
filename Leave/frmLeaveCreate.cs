using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;
using COMSSmobilerDemo.common;

namespace COMSSmobilerDemo.Leave
{
    partial class frmLeaveCreate : Smobiler.Core.MobileForm
    {
        #region "Properties"
        private string Type;
        //审阅人
        private string CUser = "";
        //抄送人
        private string CCUser = "";
        private object  btn;
        #endregion
       

        /// <summary>
        /// 调用相机
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LIMG_Click(object sender, EventArgs e)
        {
            Camera1.GetPhoto();
        }

        /// <summary>
        /// 图片上传信息赋值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Camera1_ImageCaptured(object sender, BinaryData e)
        {
            try
            {
                if (string.IsNullOrEmpty(e.ErrorInfo))
                {

                    if (LIMG.ResourceID.Length > 0)
                    {
                        e.SaveFile(LIMG.ResourceID);
                        LIMG.Refresh();//当图片上传文件名相同时，刷新界面图片内容
                    }
                    else
                    {
                        e.SaveFile();
                        LIMG.ResourceID = e.ResourceID;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        //选择请假类型
        private void btntype_Click(object sender, EventArgs e)
        {
            frmLeaveType frm = new frmLeaveType();
            this.Redirect(frm, (MobileForm sender1, object args) =>
            {
                try
                {
                    if (frm.ShowResult == Smobiler.Core.ShowResult.Yes)
                    {
                        string TYPEIDs = frm.TYPEID;
                        if (string.IsNullOrWhiteSpace(TYPEIDs) == false)
                        {
                            string[] Ltype = TYPEIDs.Split(new char[] { '/' });
                            Type = Ltype[0];
                            this.btntype.Text = Ltype[1];
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            });
        }
        //获取审批人
        private void BtnCUser_Click(object sender, EventArgs e)
        {
            //获取审批人
            btn = sender;
            LeaveInfo Leave = new LeaveInfo();
            DataTable table = Leave.GetConfirmUser();
            PopList1.Groups.Clear();
            PopListGroup poli = new PopListGroup();
            PopList1.Groups.Add(poli);

            switch (((Button)sender).Name)
            {
                case "BtnCUser":
                case "BtnCUser2":
                    PopList1.MultiSelect = false;
                    poli.Text = "审批人";
                    break;
                case "Btnccuser2":
                case "Btnccuser1":
                    PopList1.MultiSelect = true;
                    poli.Text = "抄送人";
                    break;
            }
            //显示选择列表中key和values
            foreach (DataRow rowli in table.Rows)
            {
                poli.Items.Add(rowli["USER_ID"].ToString(), rowli["USER_ID"].ToString());
                switch (((Button)sender).Name)
                {
                    case "BtnCUser":
                    case "BtnCUser2":
                        if (CUser.Trim().Length > 0)
                        {
                            if (CUser.Trim().ToUpper() == rowli["USER_ID"].ToString().Trim().ToUpper())
                            {
                                PopList1.SetSelections(poli.Items[(poli.Items.Count - 1)]);
                            }
                        }
                        break;
                    case "Btnccuser2":
                    case "Btnccuser1":
                        if (CCUser.Trim().Length > 0)
                        {
                            if (CCUser.Trim().ToUpper() == rowli["USER_ID"].ToString().Trim().ToUpper())
                            {
                                PopList1.SetSelections(poli.Items[(poli.Items.Count - 1)]);
                            }
                        }
                        break;
                }
            }
            PopList1.Show();
        }

        /// <summary>
        /// 审批人，抄送人赋值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PopList1_Selected(object sender, EventArgs e)
        {

            try
            {
                switch (((Button)btn).Name)
                {
                    case "BtnCUser":
                    case "BtnCUser2":
                        if (PopList1.Selection != null)
                        {
                            CUser = PopList1.Selection.Value;
                            this.BtnCUser.Text = PopList1.Selection.Text.Trim();
                        }
                        break;
                    case "Btnccuser2":
                    case "Btnccuser1":
                        if (PopList1.Selections != null)
                        {
                            CCUser = "";
                            foreach (PopListItem poitem in PopList1.Selections)
                            {
                                if (CCUser.Length > 0)
                                {
                                    CCUser += "," + poitem.Value;
                                }
                                else
                                {
                                    CCUser = poitem.Value;
                                }
                            }
                            if (CCUser.Length > 0)
                            {
                                this.Btnccuser1.Text = CCUser;
                            }
                        }
                        break;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// toolbar事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmLeaveCreate_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
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
                else if (e.Name.Equals(save.Name))
                {
                    if (LDAY.Text.Length < 0)
                    {
                        throw new Exception("请输入请假天数！");
                    }
                    if (int.Parse(LDAY.Text) <= 0)
                    {
                        throw new Exception("请假天数必须大于0！");
                    }
                    if (LREASON.Text.Length < 0)
                    {
                        throw new Exception("请输入请假事由！");
                    }
                    MessageBox.Show("请假条创建成功！", (Object s, MessageBoxHandlerArgs args) =>
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