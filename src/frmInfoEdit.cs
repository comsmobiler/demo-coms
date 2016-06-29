using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Text.RegularExpressions;
using System.Data;

namespace COMSSmobilerDemo
{
    partial class frmInfoEdit : Smobiler.Core.MobileForm
    {
        Int32 sex;
        /// <summary>
        /// 头像上传
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imguser_Click(object sender, EventArgs e)
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
        /// <summary>
        /// 保存头像
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Camera1_ImageCaptured(object sender, BinaryData e)
        {
            try
            {
                if (System.String.IsNullOrEmpty(e.ResourceID) == false)
                {
                    string filename ="Demo.png";
                    e.SaveFile(filename);
                    imguser.ResourceID = filename;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        /// <summary>
        /// 验证手机号码和电话号码是否正确
        /// </summary>
        /// <remarks></remarks>
        private void valiPhoneorTel()
        {
            try
            {
                if (txtTel.Text.Trim().Length > 0)
                {
                    string tels = txtTel.Text.Trim();
                    foreach (string t1 in tels.Split(new char[] { ',' }))
                    {
                        if (t1.Trim().Length > 0)
                        {
                            //检查手机号码是否是正确的
                            Regex r = new Regex("((\\d{11})|^((\\d{7,8})|(\\d{4}|\\d{3})-(\\d{7,8})|(\\d{4}|\\d{3})-(\\d{7,8})-(\\d{4}|\\d{3}|\\d{2}|\\d{1})|(\\d{7,8})-(\\d{4}|\\d{3}|\\d{2}|\\d{1}))$)");
                            if (r.IsMatch(t1) == false)
                                throw new Exception("手机号码" + t1.ToString() + "填写有误，请检查。");
                        }
                    }

                }
                //检查电话号码是否是正确的
                if (txtPhone.Text.Trim().Length > 0)
                {
                    string phones = txtPhone.Text.Trim();
                    foreach (string p1 in phones.Split(new char[] {','}))
                    {
                        if (p1.Trim().Length > 0)
                        {
                            Regex r = new Regex("((\\d{11})|^((\\d{7,8})|(\\d{4}|\\d{3})-(\\d{7,8})|(\\d{4}|\\d{3})-(\\d{7,8})-(\\d{4}|\\d{3}|\\d{2}|\\d{1})|(\\d{7,8})-(\\d{4}|\\d{3}|\\d{2}|\\d{1}))$)");
                            if (r.IsMatch(p1) == false)
                                throw new Exception("电话号码" + p1.Trim().Length.ToString() + "填写有误，请检查。");
                        }
                    }
                }
                if (txtEmail.Text.Trim().Length > 0)
                {
                    string Emails = txtEmail.Text.Trim();
                    if (System.Text.RegularExpressions.Regex.IsMatch(Emails, "^(?(\")(\".+?\"@)|(([0-9a-zA-Z]((\\.(?!\\.))|[-!#\\$%&'\\*\\+/=\\?\\^`\\{\\}\\|~\\w])*)(?<=[0-9a-zA-Z])@))" + "(?(\\[)(\\[(\\d{1,3}\\.){3}\\d{1,3}\\])|(([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,6}))$") == false)
                    {
                        throw new Exception("电子邮件" + Emails + "填写有误，请检查。");
                    }
                }
            }
            catch (Exception ex)
            {
                throw  ex ;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmInfoEdit_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
        {
            try
            {
                valiPhoneorTel();
                MessageBox.Show("基本信息已修改保存！");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmInfoEdit_Load(object sender, EventArgs e)
        {
            lblUser.Text = "Demo";
            txtUserName.Text = "测试用户";
            imguser.ResourceID = "Demo";
            sex = 0;
            btnSex.Text = "男";
        }

        private void btnSex_Click(object sender, EventArgs e)
        {
            PopList1.Groups.Clear();
            DataTable table = new DataTable();
            PopListGroup poli = new PopListGroup();
            PopList1.Groups.Add(poli);
            poli.Text = "性别";
            table.Columns.Add("sex", typeof(System.Int32 ));
            table.Columns.Add("sexDesc", typeof(System.String));
            table.Rows.Add(0, "男");
            table.Rows.Add(1, "女");
            foreach (DataRow rowli in table.Rows)
            {
                poli.Items.Add(rowli["sexDesc"].ToString(), rowli["sex"].ToString());

                if (sex.ToString().Length > 0)
                {
                    if (sex.Equals(rowli["sex"]))
                    {
                        PopList1.SetSelections(poli.Items[(poli.Items.Count - 1)]);
                    }
                }
            }
            PopList1.Show();

        }

        private void PopList1_Selected(object sender, EventArgs e)
        {
            if (PopList1.Selection != null)
            {
                sex = int.Parse(PopList1.Selection.Value);
                this.btnSex .Text = PopList1.Selection.Text.Trim();
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

        private void frmInfoEdit_TitleImageClick(object sender, EventArgs e)
        {
            HandleToast();
        }
    }
}