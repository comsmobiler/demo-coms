using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;

namespace COMSSmobilerDemo.Operational
{
    partial class frmOperationalREdit : Smobiler.Core.MobileForm
    {
        #region "Properties"
        private bool isSaving = false;
        //客户
        private string CUST_ID = "";
        //处理结果
        private string OR_PROCESSRESULT = "";
        //维护人员
        private string OR_MAINTAINER = "";
        //button标识
        private object btnmode;
        internal string OR_NO;
        public string GetOR_NO
        {
            get { return OR_NO; }
            set { OR_NO = value; }
        }
        #endregion

        /// <summary>
        /// 客户，处理结果，审批人选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnpop_Click(object sender, EventArgs e)
        {
            try
            {
                PopList1.Groups.Clear();
                //获取审批人
                btnmode = sender;
                OperationalInfo OperationalR = new OperationalInfo();
                DataTable table = new DataTable();
                PopListGroup poli = new PopListGroup();
                PopList1.Groups.Add(poli);

                switch (((Button)sender).Name)
                {
                    case "btnCU":
                    case "btnCU2":
                        poli.Text = "客户选择";
                        table = OperationalR.GetCUData();
                        break;
                    case "btnOR_PROCESSRESULT":
                    case "btnOR_PROCESSRESULT2":
                        poli.Text = "处理方式选择";
                        table = OperationalR.GetProcessResultData();
                        break;
                    case "btnOR_MAINTAINER":
                    case "btnOR_MAINTAINER2":
                        poli.Text = "维护人员选择";
                        table = OperationalR.GetUserData();
                        break;
                }

                foreach (DataRow rowli in table.Rows)
                {
                    switch (((Button)sender).Name)
                    {
                        case "btnCU":
                        case "btnCU2":
                            poli.Items.Add(rowli["CUST_NAME"].ToString(), rowli["CUST_ID"].ToString());
                            if (CUST_ID.Trim().Length > 0)
                            {
                                if (CUST_ID.Trim().Equals(rowli["CUST_ID"].ToString().Trim()))
                                {
                                    PopList1.SetSelections(poli.Items[(poli.Items.Count - 1)]);
                                }
                            }
                            break;
                        case "btnOR_PROCESSRESULT":
                        case "btnOR_PROCESSRESULT2":
                            poli.Items.Add(rowli["ProcessResultStateName"].ToString(), rowli["ProcessResultState"].ToString());
                            if (OR_PROCESSRESULT.Trim().Length > 0)
                            {
                                if (OR_PROCESSRESULT.Trim().Equals(rowli["ProcessResultState"].ToString().Trim()))
                                {
                                    PopList1.SetSelections(poli.Items[(poli.Items.Count - 1)]);
                                }
                            }
                            break;
                        case "btnOR_MAINTAINER":
                        case "btnOR_MAINTAINER2":
                            poli.Items.Add(rowli["USER_ID"].ToString(), rowli["USER_ID"].ToString());
                            if (OR_MAINTAINER.Trim().Length > 0)
                            {
                                if (OR_MAINTAINER.Trim().ToUpper().Equals(rowli["USER_ID"].ToString().Trim().ToUpper()))
                                {
                                    PopList1.SetSelections(poli.Items[(poli.Items.Count - 1)]);
                                }
                            }
                            break;
                    }
                }
                switch (((Button)sender).Name)
                {
                    case "btnCU":
                    case "btnCU2":
                    case "btnOR_MAINTAINER":
                    case "btnOR_MAINTAINER2":
                        PopList1.Show();
                        poli.Text = "客户选择";
                        table = OperationalR.GetCUData();
                        break;
                    case "btnOR_PROCESSRESULT":
                    case "btnOR_PROCESSRESULT2":
                        PopList1.ShowDialog();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// 客户，处理结果，审批人赋值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PopList1_Selected(object sender, EventArgs e)
        {
            try
            {
                if (PopList1.Selection != null)
                {
                    switch (((Button)btnmode).Name)
                    {
                        case "btnCU":
                        case "btnCU2":
                            CUST_ID = PopList1.Selection.Value;
                            this.btnCU.Text = PopList1.Selection.Text.Trim();
                            break;
                        case "btnOR_PROCESSRESULT":
                        case "btnOR_PROCESSRESULT2":
                            OR_PROCESSRESULT = PopList1.Selection.Value;
                            this.btnOR_PROCESSRESULT.Text = PopList1.Selection.Text.Trim();
                            break;
                        case "btnOR_MAINTAINER":
                        case "btnOR_MAINTAINER2":
                            OR_MAINTAINER = PopList1.Selection.Value;
                            this.btnOR_MAINTAINER.Text = PopList1.Selection.Text.Trim();
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
        private void frmOperationalREdit_Load(object sender, EventArgs e)
        {
            Bind();
        }
        /// <summary>
        /// 初始化方法
        /// </summary>
        private void Bind()
        {
            try
            {
                OR_PROCESSRESULT = Convert.ToInt32(ProcessResultState.待跟踪).ToString();
                btnOR_PROCESSRESULT.Text = "待跟踪";
                lblOR_NO.Text = OR_NO;
                CUST_ID = "CU001";
                btnCU.Text ="客户一";
                txtOR_DECLARANT.Text = "";
                txtOR_CONTACTTEL.Text ="";
                OR_DECLAREDATE.CurrentDate =DateTime .Now ;
                OR_STARTDATE.CurrentDate =DateTime .Now ;
                OR_ENDDATE.CurrentDate =DateTime .Now ;
                txtOR_FAULTINFO.Text = "";
                txtOR_REASONANALYSIS.Text = "";
                txtOR_PROCESSMODE.Text = "";
                OR_PROCESSRESULT = "";
                btnOR_PROCESSRESULT.Text = "已完成";
                OR_MAINTAINER = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 图片上传
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnupPhoto_Click(object sender, EventArgs e)
        {
            Camera1.GetPhoto();
        }
        /// <summary>
        /// 图片删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btndelPhoto_Click(object sender, EventArgs e)
        {
            if (OR_IMG .ResourceID .Length >0)
            {
            MessageBox.Show("是否确定删除图片？", "删除", MessageBoxButtons.YesNo, (Object s, MessageBoxHandlerArgs args) =>
            {
                if (args.Result == Smobiler.Core.ShowResult.Yes)
                {
                    OR_IMG.ResourceID = "";
                }
            }
                   );
            }
            else
            {
                MessageBox.Show("您没有上传图片，不能删除！");
            }
        }
        /// <summary>
        /// 图片上传赋值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Camera1_ImageCaptured(object sender, BinaryData e)
        {
            try
            {
                if (string.IsNullOrEmpty(e.ErrorInfo))
                {
                    if (OR_IMG.ResourceID.Length > 0)
                    {
                        e.SaveFile(OR_IMG.ResourceID);
                        OR_IMG.Refresh();
                    }
                    else
                    {
                        e.SaveFile();
                        OR_IMG.ResourceID = e.ResourceID;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmOperationalREdit_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
        {
            try
            {
                if (e.Name.Equals(save.Name))
                {
                    if (txtOR_DECLARANT.Text.Length < 0)
                    {
                        throw new Exception("请输入申报人！");
                    }
                
                    if (txtOR_FAULTINFO.Text.Length < 0)
                    {
                        throw new Exception("请输入故障描述！");
                    }
                    MessageBox.Show("运维记录已修改成功！", (Object s, MessageBoxHandlerArgs args) =>
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
        /// TitleImage点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MobileForm_TitleImageClick(object sender, EventArgs e)
        {
            HandleToast();
        }
    }
}