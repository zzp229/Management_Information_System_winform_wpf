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
using System.Windows.Navigation;
using System.Windows.Shapes;
using 医药管理系统wpf.ViewModels;

namespace 医药管理系统wpf.Views
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class FrmLogin : Window
    {
        public FrmLogin()
        {
            InitializeComponent();
            FrmLoginViewModel model = new FrmLoginViewModel();
            this.DataContext = model;

            
            
            this.Loaded += FrmLogin_Loaded;
        }


        private void FrmLogin_Loaded(object sender, RoutedEventArgs e)
        {
            this.btn_Login.Focus();
        }

    }
}
