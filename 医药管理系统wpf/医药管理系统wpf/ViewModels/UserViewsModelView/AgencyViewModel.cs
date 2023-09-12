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
        public AgencyViewModel(Agency agency, bool isEdit)
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

            //是否可以修改学号
            IsTextBoxVisible = isEdit;
            IsLableVisible = !isEdit;

            this.IsEdit = isEdit;
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

        /// <summary>
        /// 用来设置是否显示这个TextBox
        /// </summary>
        private bool isTextBoxVisible;
        public bool IsTextBoxVisible
        {
            get { return isTextBoxVisible; }
            set { isTextBoxVisible = value; RaisePropertyChanged(); }
        }

        /// <summary>
        /// 设置是是否显示Lable
        /// </summary>
        private bool isLableVisible;
        public bool IsLableVisible
        {
            get { return isLableVisible; }
            set { isLableVisible = value; RaisePropertyChanged(); }
        }

        /// <summary>
        ///判断是修改还是增加
        /// </summary>
        private bool isEdit;
        public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; }
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
                //根据IsEdit判断时候是添加还是修改
                if (!IsEdit)
                {
                    int a = AgencyManager.UpdateAgencyByAno(agency);    //这个绑定一个类，不知道能不能修改成功
                    if(a > 0)
                    {
                        MessageBox.Show("修改成功！");
                    }
                }
                else
                {
                    //性别的添加进去
                    agency.Asex = AsexSeleted;
                    //往数据库增加
                    int a = AgencyManager.InSertAgency(agency);
                    if (a > 0)
                        MessageBox.Show("添加成功！");
                }

                

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
