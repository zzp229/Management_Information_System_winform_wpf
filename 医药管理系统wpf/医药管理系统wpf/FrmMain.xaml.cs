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
    /// FrmMain.xaml 的交互逻辑
    /// </summary>
    public partial class FrmMain : Window
    {
        public FrmMain()
        {
            InitializeComponent();
            this.Loaded += FrmMain_Loaded;
        }

        private void FrmMain_Loaded(object sender, RoutedEventArgs e)
        {
            this.cmb_Inquire.Items.Add("顾客信息");
            this.cmb_Inquire.Items.Add("经办人信息");
            this.cmb_Inquire.Items.Add("药品信息");
        }


        //查询按钮
        private void btn_Query_Click(object sender, RoutedEventArgs e)
        {
            if (cmb_Inquire.SelectedIndex == 0)
            {
                FrmView_Client frmView = new FrmView_Client();
                frmView.ShowDialog();
            }
            else if (cmb_Inquire.SelectedIndex == 1)
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
