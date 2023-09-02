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

namespace 医药管理系统wpf
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class FrmLogin : Window
    {
        public FrmLogin()
        {
            InitializeComponent();
            this.Loaded += FrmLogin_Loaded;
        }

        private void FrmLogin_Loaded(object sender, RoutedEventArgs e)
        {
            this.btn_Login.Focus();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }


        //登录按钮
        private void btn_Login_Click(object sender, RoutedEventArgs e)
        {
            FrmMain frmMain = new FrmMain();
            frmMain.Show();
        }

        //退出按钮
        private void btn_Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btn_Register_Click(object sender, RoutedEventArgs e)
        {
            FrmRegister frmMain = new FrmRegister();
            frmMain.Show();
        }
    }
}
