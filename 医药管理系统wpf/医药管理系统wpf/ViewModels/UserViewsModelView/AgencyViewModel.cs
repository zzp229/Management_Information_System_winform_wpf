using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using 医药管理系统wpf.Models;

namespace 医药管理系统wpf.ViewModels.UserViewsModelView
{
    internal class AgencyViewModel:ViewModelBase
    {

        #region 属性
        private List<Char> asexSource;
        public List<Char> AsexSource
        {
            get { return asexSource; }
            set { asexSource = value; RaisePropertyChanged(); }
        }


        private char asexSeleted;
        public char AsexSeleted
        {
            get { return asexSeleted; }
            set { asexSeleted = value; RaisePropertyChanged(); }
        }

        private Agency agency1;
        public Agency agency
        {
            get { return agency1; }
            set { agency1 = value; RaisePropertyChanged(); }
        }

        #endregion



        public AgencyViewModel(Agency agency)
        {
            //初始化ComboBox的数据
            asexSource = new List<char>()
            {
                '男',
                '女'
            };
            AsexSeleted = agency.Asex;
            this.agency = agency;
            CloseWindowCommand = new RelayCommand<object>(t=>CloseWindow(t));
        }

        

        public RelayCommand<object> CloseWindowCommand { get; set; }
        private void CloseWindow(object parameter)
        {
            // 在这里执行关闭窗体的操作
            var window = parameter as Window;
            if (window != null)
            {
                MessageBox.Show("可以关闭");
                window.Close();
            }
        }

    }
}
