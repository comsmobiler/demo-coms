using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using COMSSmobilerDemo.Reimbursement.RB;
using COMSSmobilerDemo.Reimbursement.CostCenter;
using COMSSmobilerDemo.Message;
using Smobiler.Core.Plugin.RongIM;
namespace COMSSmobilerDemo
{
    partial class frmMune : Smobiler.Core.MobileForm
    {
        internal string ToolBarName = "";
        IM im;
        /// <summary>
        /// appKey和appSecret请去融云注册应用：http://www.rongcloud.cn/
        /// IM是仅限于打包版，开发版不支持
        /// </summary>
        string  appKey  = "z3v5yqkbvzdn0";
        string appSecret = "YixaaKHE83zPj";
        
        /// <summary>
        /// 显示左侧栏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMune_TitleImageClick(object sender, EventArgs e)
        {
            ShowSlider(Slider.Left);
        }

        private void frmMune_LeftLayoutItemClick(object sender, MobileFormLayoutItemEventArgs e)
        {
            ProcessLeftMenuFormName(e.CellItem.Name);
        }
        private void ProcessLeftMenuFormName(string leftLayoutActionName)
        {
            try
            {
                switch (leftLayoutActionName)
                {
                    case "":
                        this.Close();
                        break;
                    //case "imgindex":
                    //case "btnindex":
                    //    this.CloseSlider();
                    //    break;
                    case "imginfo":
                    case "btninfo":
                        frmInfo frm = new frmInfo();
                        this.Redirect(frm, (MobileForm sender1, object args) => ProcessLeftMenuFormName(frm.LeftLayoutAction));
                        break;
                    case "imgtz":
                    case "btntz":
                        frmMessage frmMessage = new frmMessage();
                        this.Redirect(frmMessage, (MobileForm sender1, object args) => ProcessLeftMenuFormName(frmMessage.LeftLayoutAction));
                        break;
                    case "imgbz":
                    case "btnbz":
                        frmHelp frmHelp = new frmHelp();
                        this.Redirect(frmHelp, (MobileForm sender1, object args) => ProcessLeftMenuFormName(frmHelp.LeftLayoutAction));
                        break;
                    case "imgtc":
                    case "btnExit":
                        MessageBox.Show("是否确定退出系统？", MessageBoxButtons.YesNo, (Object s, MessageBoxHandlerArgs args) =>
                        {
                            if (args.Result == Smobiler.Core.ShowResult.Yes)
                            {
                               this .Close ();
                            }
                        }
                     );
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private DateTime taosttime;
        private bool handleExit = false;
        /// <summary>
        /// 手机自带回退按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                this.Toast("再按一次退出系统", ToastLength.SHORT);
            }
        }
        /// <summary>
        /// 地理位置赋值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
     
        /// <summary>
        /// 菜单点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuView1_MenuItemClick(object sender, IconMenuItemEventArgs e)
        {

            switch (e.Item.ID)
            {
                case "MenuRB":
                        IconMenuViewGroup grp = new IconMenuViewGroup();
                        grp.Items.Add(new IconMenuViewItem("RBMain", "报销", "RBMain"));
                        grp.Items.Add(new IconMenuViewItem("RBPostMain", "报销送审", "RBPostMain"));
                        grp.Items.Add(new IconMenuViewItem("RBCheckCofirmed", "责任人审批", "RBCheckCofirmed"));
                        grp.Items.Add(new IconMenuViewItem("RBChecking", "行政审批", "RBChecking"));
                        grp.Items.Add(new IconMenuViewItem("RBCheckAccounted", "财务审批", "RBCheckAccounted"));
                        IconMenuView1.ShowDialogMenu(grp);
                    break;
                case "MenuWorkD":
                    COMSSmobilerDemo.WorkDocument.frmWorkDMain frmWorkDMain = new COMSSmobilerDemo.WorkDocument.frmWorkDMain();
                    this.Redirect(frmWorkDMain);
                    break;
                case "MenuLeave":
                    COMSSmobilerDemo.Leave.frmLeaveGrid frmLeaveGrid = new COMSSmobilerDemo.Leave.frmLeaveGrid();
                    this.Redirect(frmLeaveGrid);
                    break;
                case "MenuUnCCUser":
                    COMSSmobilerDemo.Reimbursement.CostCenter.frmAttentionCC frmAttentionCC =new COMSSmobilerDemo.Reimbursement.CostCenter.frmAttentionCC();
                    this.Redirect(frmAttentionCC);
                    break;
                case "MenuSign":
                    COMSSmobilerDemo.SignIn.frmSignInMain frmSignInMain = new COMSSmobilerDemo.SignIn.frmSignInMain();
                     this.Redirect(frmSignInMain);
                    break;
                case "MenuOperational":
                    COMSSmobilerDemo.Operational.frmOperationalRMain frmOperationalRMain =new  COMSSmobilerDemo.Operational.frmOperationalRMain();
                    this.Redirect(frmOperationalRMain);
                    break;
                case "RBMain":
                    COMSSmobilerDemo.Reimbursement.RB.frmRBMain frmRBMain = new COMSSmobilerDemo.Reimbursement.RB.frmRBMain();
                    this.Redirect(frmRBMain);
                    break;
                case "RBPostMain":
                     COMSSmobilerDemo.Reimbursement.RB.frmRBPostMain frmRBPostMain = new COMSSmobilerDemo.Reimbursement.RB.frmRBPostMain();
                    this.Redirect(frmRBPostMain);
                   
                    break;
                case "RBCheckCofirmed":
                    COMSSmobilerDemo.Reimbursement.RB.frmRBCheck2 frmRBCheck2 = new COMSSmobilerDemo.Reimbursement.RB.frmRBCheck2();
                    this.Redirect(frmRBCheck2);
                    break;
                case "RBChecking":
                   COMSSmobilerDemo.Reimbursement.RB.frmRBCheck3 frmRBCheck3 = new COMSSmobilerDemo.Reimbursement.RB.frmRBCheck3();
                   this.Redirect(frmRBCheck3);
                    break;
                case "RBCheckAccounted":
                   COMSSmobilerDemo.Reimbursement.RB.frmRBCheck4 frmRBCheck4 = new COMSSmobilerDemo.Reimbursement.RB.frmRBCheck4();
                   this.Redirect(frmRBCheck4);
                    break;
                case "MenuRItems":
                    COMSSmobilerDemo.RecipientsItems.frmRIMain frmRIMain = new COMSSmobilerDemo.RecipientsItems.frmRIMain();
                    this.Redirect(frmRIMain);
                    break;
                case "MenuFixedAssets":
                    IconMenuViewGroup grp1 = new IconMenuViewGroup();
                    grp1.Items.Add(new IconMenuViewItem("NBMain", "笔记本", "NBMain"));
                    grp1.Items.Add(new IconMenuViewItem("BooksMain", "书", "BooksMain"));
                    grp1.Items.Add(new IconMenuViewItem("BooksLogCheckMain", "图书借阅", "BooksLogCheckMain"));
                    IconMenuView1.ShowDialogMenu(grp1);
                    break;
                case "NBMain":
                    COMSSmobilerDemo.FixedAssets.NootBooks.frmNBMain frmNBMain = new COMSSmobilerDemo.FixedAssets.NootBooks.frmNBMain();
                    this.Redirect(frmNBMain);
                    break;
                case "BooksMain":
                    COMSSmobilerDemo.FixedAssets.Books.frmBooksMain frmBooksMain = new COMSSmobilerDemo.FixedAssets.Books.frmBooksMain();
                    this.Redirect(frmBooksMain);
                    break;
                case "BooksLogCheckMain":
                    COMSSmobilerDemo.FixedAssets.Books.frmBookLogCheckMain frmBookLogCheckMain = new COMSSmobilerDemo.FixedAssets.Books.frmBookLogCheckMain();
                    this.Redirect(frmBookLogCheckMain);
                    break;
            }
        }

        /// <summary>
        /// 初始化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMune_Load(object sender, EventArgs e)
        {
            InitialIM(appKey, appSecret);
            ScreenGestures();
            Bind();
            
        }

        private void Bind()
        {
            LeftLayoutExtension.upleftLayoutbtncolorExt(this);
            Gps1.GetGps();
        }

        //手势创建
        private void ScreenGestures()
        {
            if (string.IsNullOrWhiteSpace(this.Client.Pattern.Password )== true)
            {
                //当设备手势密码为空时，进行手势创建
                this.Client.Pattern.Create((object s1, Smobiler.Core.API.PatternCreatedEventArgs args) =>
                {
                    if (args.IsError == true)
                    {
                        MessageBox.Show(args.ErrorInfo);
                    }
                    else
                    {
                        if (string.IsNullOrWhiteSpace(this.Client.Pattern.Password) == false)
                        {
                            //赋值手势密码
                            this.Client.Pattern.Password = args.Password;
                        }
                    }
                });
            }
        }


        private void ProcessToolBarName(string toolBarName)
        {
            try
            {
                switch (toolBarName)
                {
                    case "Content":
                        frmContacts frm = new frmContacts();
                        frm.im = im;
                        this.Redirect(frm, (MobileForm sender1, object args) => ProcessLeftMenuFormName(frm.toolBarName));
                        break;
                    case "Mes":
                        im.StartConversationList();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 初始化数据
        /// </summary>
        /// <param name="key"></param>
        /// <param name="secret"></param>
        /// <remarks></remarks>
        private void InitialIM(string key, string secret)
        {
            im = new IM(this.Client.SessionID, key, secret);
            if (System.String.IsNullOrEmpty(im.Token) == true)
            {
                string tokenuser = Client.Session["UserID"].ToString();
                if (System.String.IsNullOrEmpty(tokenuser) == false)
                {
                    //在融云用户初始化，如若报“toke失效”请去融云中查看token是否失效
                    im.InitialToken(tokenuser, tokenuser, "");
                }
                else
                {
                    MessageBox.Show("TokenUser Not Be NullOrEmpty!");
                }
            }
            else
            {
                im.InitialToken();
            }
        }
        /// <summary>
        /// toolbar事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMune_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
        {
            ProcessToolBarName(e.Name);
        }



    }
}