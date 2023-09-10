using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using 医药管理系统wpf.Models;
using 医药管理系统wpf.ViewModels.Manager;
using 医药管理系统wpf.Views.Helper;

namespace 医药管理系统wpf.ViewModels.UserViewsModelView
{
    internal class AgencyViewModel:ViewModelBase
    {
        public AgencyViewModel(Agency agency)
        {
            //初始化ComboBox的数据
            asexSource = new List<char>()
            {
                '男',
                '女'
            };
            this.agency = agency;
            AsexSeleted = agency.Asex;
            CloseWindowCommand = new RelayCommand<object>(t => CloseWindow(t));
        }

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



        


        #region Command
        public RelayCommand<object> CloseWindowCommand { get; set; }
        #endregion


        /// <summary>
        /// 保存按钮点击后才是保存编辑的内容
        /// </summary>
        /// <param name="parameter"></param>
        private void CloseWindow(object parameter)
        {
            // 在这里执行关闭窗体的操作
            var window = parameter as Window;
            if (window != null)
            {
                
                int a = AgencyManager.UpdateAgencyByAno(agency);    //这个绑定一个类，不知道能不能修改成功

                //更新状态
                // 在 ViewModel B 中
                var message = new CloseWindowMessage
                {
                    AgencyView_DialogResult = true // 或者 false，根据需要设置结果
                };
                Messenger.Default.Send(message);    //这里将窗口的状态发送出去

                //还要更新一遍DataGrid，到FrmView_Agency中更新

                window.Close();
            }
        }

    }
}
