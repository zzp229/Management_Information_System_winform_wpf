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
using 医药管理系统wpf.ViewModels;

namespace 医药管理系统wpf
{
    /// <summary>
    /// FrmView_Medicine.xaml 的交互逻辑
    /// </summary>
    public partial class FrmView_Medicine : Window
    {
        public FrmView_Medicine()
        {
            InitializeComponent();

            FrmView_MedicineViewModel frmView_MedicineViewModel = new FrmView_MedicineViewModel();
            this.DataContext = frmView_MedicineViewModel;
            (DataContext as FrmView_MedicineViewModel)?.SetDataGrid(dataGrid);
        }
    }
}
