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

namespace 医药管理系统wpf
{
    /// <summary>
    /// FrmView_Agency.xaml 的交互逻辑
    /// </summary>
    public partial class FrmView_Agency : Window
    {
        public FrmView_Agency()
        {
            InitializeComponent();
            this.Loaded += FrmView_Agency_Loaded;
        }

        private void FrmView_Agency_Loaded(object sender, RoutedEventArgs e)
        {
            this.cmb_asex.Items.Add("男");
            this.cmb_asex.Items.Add("女");
        }
    }
}
