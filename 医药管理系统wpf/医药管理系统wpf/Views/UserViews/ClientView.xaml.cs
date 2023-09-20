using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using 医药管理系统wpf.Models;
using 医药管理系统wpf.ViewModels.UserViewsModelView;

namespace 医药管理系统wpf.Views
{
    /// <summary>
    /// ClientView.xaml 的交互逻辑
    /// </summary>
    public partial class ClientView : Window
    {
        //public ClientView()
        //{
        //    InitializeComponent();
        //}

        public ClientView(Client client, bool isEdit)
        {
            ClientViewModel clientViewModel = new ClientViewModel(client, isEdit);
            this.DataContext = clientViewModel;

            InitializeComponent();
        }
    }
}
