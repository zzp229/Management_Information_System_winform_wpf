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

            InquireCommand = new RelayCommand(ForInquireCommand);
        }

        #region 属性
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
        #endregion


        #region Command
        public RelayCommand InquireCommand { get; set; }
        #endregion


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
    }
}
