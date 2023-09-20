using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using GalaSoft.MvvmLight.Command;
using 医药管理系统wpf.Models;
using 医药管理系统wpf.Views;
using 医药管理系统wpf.Views.Helper;
using GalaSoft.MvvmLight.Messaging;
using 医药管理系统wpf.ViewModels.Manager;
using 医药管理系统wpf.Views.UserViews;


namespace 医药管理系统wpf.ViewModels
{
    internal class FrmMainViewModel:ViewModelBase
    {
        public FrmMainViewModel()
        {
            Title = "欢迎" + AdminManager.currentAdmin.LoginName + "登录医药管理系统";

            //给两个下拉框使用
            List<string> listSelete = new List<string>()
            {
                "顾客信息",
                "经办人信息",
                "药品信息"
            };

            //初始化下拉框
            //查询
            InquireList = listSelete;
            Inquired = InquireList[1];

            //录入
            CheckInList = listSelete;
            CheckIn = CheckInList[2];

            //传递消息，判断编辑窗口是否点击确定
            Messenger.Default.Register<CloseWindowMessage>(this, HandleCloseWindowMessage);

            InquireCommand = new RelayCommand(ForInquireCommand);
            CheckInCommand = new RelayCommand(ForCheckInCommand);
            LogoutCommand = new RelayCommand(ForLogoutCommand);
        }

        

        #region 属性

        //左边下拉
        private List<string> inquireList;
        public List<string> InquireList
        {
            get { return inquireList; }
            set { inquireList = value; RaisePropertyChanged(); }
        }

        private string inquired;
        public string Inquired
        {
            get { return inquired; }
            set { inquired = value; RaisePropertyChanged(); }
        }

        //右边下拉
        private List<string> checkInList;
        public List<string> CheckInList
        {
            get { return checkInList; }
            set { checkInList = value; }
        }

        private string checkIn;
        public string CheckIn
        {
            get { return checkIn; }
            set { checkIn = value; }
        }

        private string title;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        #endregion




        #region Command
        public RelayCommand InquireCommand { get; set; }
        public RelayCommand CheckInCommand { get; set; }
        public RelayCommand LogoutCommand { get; set; }
        #endregion

        //查询
        private void ForInquireCommand()
        {
            if(inquired == inquireList[0])
            {
                FrmView_Client frmView = new FrmView_Client();
                frmView.ShowDialog();
            }
            else if (inquired == inquireList[1])
            {
                FrmView_Agency frmView_Agency = new FrmView_Agency();
                frmView_Agency.ShowDialog();
            }
            else
            {
                FrmView_Medicine frmView_Medicine = new FrmView_Medicine();
                frmView_Medicine.ShowDialog();
            }
        }

        //录入
        private void ForCheckInCommand()
        {
            if(checkIn == checkInList[0])
            {
                Medicine medicine = new Medicine();
                MedicineView medicineView = new MedicineView(medicine, true);
                medicineView.ShowDialog();
            }
            else if(checkIn == checkInList[1])
            {
                Agency agency = new Agency();
                AgencyView agencyView = new AgencyView(agency, true);
                agencyView.ShowDialog();
            } 
            else
            {
                Client client = new Client();
                ClientView clientView = new ClientView(client, true);
                clientView.ShowDialog();
            }
        }


        //注销账号
        private void ForLogoutCommand()
        {
            //MessageBox.Show("aa", "aa", MessageBoxButton.OK, MessageBoxImage.Error);
            if(MessageBox.Show("确认注销该账号吗？", "注销", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                //数据库中删除该账号
                AdminManager.DelAdminByLoginId();
                AdminManager.currentAdmin = null;

                MessageBox.Show("注销成功!");

                //然后关闭主页，跳回登录窗口

            }
        }


        #region 判断AgencyView是否点击了确认按钮

        private void HandleCloseWindowMessage(CloseWindowMessage message)
        {
            // 处理窗口的返回值
            bool dialogResult = message.AgencyView_DialogResult;
            if (dialogResult)
            {
                MessageBox.Show("保存成功！");
            }
        }

        // 不要忘记在视图模型销毁时取消注册消息   ///?这个忘记怎么用了
        public override void Cleanup()
        {
            Messenger.Default.Unregister(this);
            base.Cleanup();
        }
        #endregion
    }
}
