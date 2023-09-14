using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using 医药管理系统wpf.Models;
using 医药管理系统wpf.ViewModels.Manager;
using 医药管理系统wpf.Views.Helper;


namespace 医药管理系统wpf.ViewModels
{
    internal class FrmLoginViewModel:ViewModelBase
    {
        public FrmLoginViewModel()
        {
            //测试用
            LoginId = "uu";
            LoginPwd = "uu";

            //退出按钮
            ExitCommand = new RelayCommand(() =>
            {
                Application.Current.MainWindow.Close();
            });

            //登录按钮
            LoginCommand = new RelayCommand(LoginVerify);

            //注册按钮
            RegisterCommand = new RelayCommand(ForRegisterCommand);
        }

        #region 属性

        private string loginId;
        public string LoginId
        {
            get { return loginId; }
            set
            {
                loginId = value;
                RaisePropertyChanged(nameof(LoginId));
            }
        }

        private string loginPwd;

        public string LoginPwd
        {
            get { return loginPwd; }
            set 
            {
                loginPwd = value; 
                RaisePropertyChanged(nameof(LoginPwd));
            }
        }

        private bool shouldFocusOnLoginId;

        //给登录提示使用
        public bool ShouldFocusOnLoginId
        {
            get { return shouldFocusOnLoginId; }
            set
            {
                if (shouldFocusOnLoginId != value)
                {
                    shouldFocusOnLoginId = value;
                    RaisePropertyChanged(nameof(ShouldFocusOnLoginId));
                }
            }
        }

        private bool shouldFocusOnLoginPwd;

        public bool ShouldFocusOnLoginPwd
        {
            get { return shouldFocusOnLoginPwd; }
            set
            { 
                shouldFocusOnLoginPwd = value;
                RaisePropertyChanged(nameof(ShouldFocusOnLoginPwd));
            }
        }



        #endregion


        


        #region Command
        public RelayCommand ExitCommand { get; set; }
        public RelayCommand LoginCommand { get; set; }
        public RelayCommand RegisterCommand { get; set; }
        #endregion


        //点击登录按钮的验证
        public void LoginVerify()
        {
            if(string.IsNullOrEmpty(LoginId))
            {
                MessageBox.Show("账号不能为空！");
                ShouldFocusOnLoginId = true;
                return;
            }

            if (string.IsNullOrEmpty(LoginPwd))
            {
                MessageBox.Show("密码不能为空！");
                ShouldFocusOnLoginPwd = true;
                return;
            }

            Admin admin = new Admin()
            {
                LoginId = this.LoginId,
                LoginPwd = this.LoginPwd,
            };

            //验证密码对不对
            LoginManager loginManager = new LoginManager();
            if (loginManager.CheckIdPwd(admin) == UserState.NoExist)
            {
                MessageBox.Show("该账号未注册");
            }
            else if (loginManager.CheckIdPwd(admin) == UserState.PwdError)
            {
                MessageBox.Show("密码错误！");
            }
            else
            {
                //补充好这个静态用户
                AdminManager.currentAdmin = AdminManager.GetAdminById(LoginId);
                
                //可以登录
                FrmMain frmMain = new FrmMain();
                frmMain.ShowDialog();
            }

        }


        //注册按钮打开新窗口
        public void ForRegisterCommand()
        {
            FrmRegister frmRegister = new FrmRegister();
            frmRegister.ShowDialog();
        }
    }
}
