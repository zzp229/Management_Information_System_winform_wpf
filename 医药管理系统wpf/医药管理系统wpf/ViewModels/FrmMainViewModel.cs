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

namespace 医药管理系统wpf.ViewModels
{
    internal class FrmMainViewModel:ViewModelBase
    {
        public FrmMainViewModel()
        {
            //初始化下拉框
            InquireList = new List<string>()
            {
                "顾客信息",
                "经办人信息",
                "药品信息"
            };
            Inquired = InquireList[1];

            CheckInList = new List<string>()
            {
                "顾客信息",
                "经办人信息",
                "药品信息"
            };
            CheckIn = CheckInList[1];

            //传递消息，判断编辑窗口是否点击确定
            Messenger.Default.Register<CloseWindowMessage>(this, HandleCloseWindowMessage);

            InquireCommand = new RelayCommand(ForInquireCommand);
            CheckInCommand = new RelayCommand(ForCheckInCommand);
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


        #endregion




        #region Command
        public RelayCommand InquireCommand { get; set; }
        public RelayCommand CheckInCommand { get; set; }
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

            }
            else if(checkIn == checkInList[1])
            {
                Agency agency = new Agency();
                AgencyView agencyView = new AgencyView(agency, true);
                agencyView.ShowDialog();
            } 
            else
            {

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
