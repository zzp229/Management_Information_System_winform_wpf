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

namespace 医药管理系统wpf.ViewModels.UserViewsModelView
{
    internal class ClientViewModel:ViewModelBase
    {
        public ClientViewModel(Client client, bool isEdit)
        {
            Cdate = DateTime.Now;

            //初始化下拉列表
            CsexSource = new List<char>
            {
                '男',
                '女'
            };
            CsexSeleted = CsexSource[0];

            this.client = client;

            //是否可以修改学号
            IsTextBoxVisible = isEdit;
            IsLableVisible = !isEdit;
            this.IsEdit = isEdit;

            //Command实例化
            CloseWindowCommand = new RelayCommand<object>(t=>CloseWindow(t));
        }


        #region 属性
        private Client _client;
        /// <summary>
        /// 顾客实体类
        /// </summary>
        public Client client
        {
            get { return _client; }
            set { _client = value; RaisePropertyChanged(); }
        }

        private char csexSeleted;
        /// <summary>
        /// 性别
        /// </summary>
        public char CsexSeleted
        {
            get { return csexSeleted; }
            set { csexSeleted = value; RaisePropertyChanged(); }
        }

        private DateTime cdate;
        /// <summary>
        /// 登录日期
        /// </summary>
        public DateTime Cdate
        {
            get { return cdate; }
            set { cdate = value; RaisePropertyChanged(); }
        }

        private string cdateFormatted;
        /// <summary>
        /// 格式化后的日期
        /// </summary>
        public string CdateFormatted
        {
            get { return Cdate.ToString("yyyy-MM-dd HH:mm:ss"); }
            set { cdateFormatted = value; }
        }


        private List<char> csexSource;
        /// <summary>
        /// 性别列表
        /// </summary>
        public List<char> CsexSource
        {
            get { return csexSource; }
            set { csexSource = value; RaisePropertyChanged(); }
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


        #region Method
        private void CloseWindow(object parameter)
        {
            var window = parameter as Window;
            if(window != null)
            {
                //判断是保存还是编辑，true就是添加（一位编辑看的是TextBox是否显示）
                if(!IsEdit)
                {
                    //不编辑，修改

                }
                else
                {
                    //TextBox编辑，录入
                    client.Csex = CsexSeleted;
                    client.Cdate = Cdate;

                    int a = ClientManager.InSertClient(client);
                    if (a > 0)
                        MessageBox.Show("插入成功！");
                }

                window.Close();
            }
        }
        #endregion
    }
}
