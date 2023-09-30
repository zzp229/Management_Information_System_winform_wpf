using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using 医药管理系统wpf.Models;
using 医药管理系统wpf.ViewModels.Manager;
using 医药管理系统wpf.Views.Helper;
using 医药管理系统wpf.Views.UserViews;

namespace 医药管理系统wpf.ViewModels
{
    internal class FrmView_MedicineViewModel:ViewModelBase
    {
        public FrmView_MedicineViewModel()
        {
            MmodeSource = new ObservableCollection<string>
            {
                "内服",
                "外用"
            };
            MmodeSeleted = MmodeSource[0];

            //实例化Command
            QueryCommand = new RelayCommand(() => ForQueryCommand());
            EditCommand = new RelayCommand<string>(t=>Edit(t));

            //关闭MedicineView时更新datagrid用
            Messenger.Default.Register<CloseWindowMessage>(this, HandleCloseWindowMessage);

        }

        #region 属性
        private string mno;
        /// <summary>
        /// 编号
        /// </summary>
        public string Mno
        {
            get { return mno; }
            set { mno = value; RaisePropertyChanged(); }
        }

        private ObservableCollection<string> mmodeSource;
        /// <summary>
        /// 服用方法
        /// </summary>
        public ObservableCollection<string> MmodeSource
        {
            get { return mmodeSource; }
            set { mmodeSource = value; RaisePropertyChanged(); }
        }

        private string mmodeSeleted;
        /// <summary>
        /// 选择的服用方法
        /// </summary>
        public string MmodeSeleted
        {
            get { return mmodeSeleted; }
            set { mmodeSeleted = value; RaisePropertyChanged(); }
        }

        private string mname;
        /// <summary>
        /// 名称
        /// </summary>
        public string Mname
        {
            get { return mname; }
            set { mname = value; RaisePropertyChanged(); }
        }

        private string mefficacy;
        /// <summary>
        /// 功效
        /// </summary>
        public string Mefficacy
        {
            get { return mefficacy; }
            set { mefficacy = value; RaisePropertyChanged(); }
        }


        private ObservableCollection<Medicine> medicines;
        /// <summary>
        /// 药品的集合，给DataGrid显示用
        /// </summary>
        public ObservableCollection<Medicine> Medicines
        {
            get { return medicines; }
            set { medicines = value; RaisePropertyChanged(); }
        }




        #endregion


        #region Command
        public RelayCommand QueryCommand { get; set; }
        public RelayCommand<string> EditCommand { get; set; }
        #endregion


        #region 方法
        private DataGrid dataGrid;
        /// <summary>
        /// 给View绑定时调用
        /// </summary>
        /// <param name="grid"></param>
        public void SetDataGrid(DataGrid grid)
        {
            dataGrid = grid;
        }


        /// <summary>
        /// 查询按钮使用的方法
        /// </summary>
        private void Edit(string Mno)
        {
            if(Mno != null)
            {
                Medicine medicine = MedicineManager.GetMedicineByMno(Mno);
                MedicineView medicineView = new MedicineView(medicine, false);
                medicineView.ShowDialog();
            }
        }


        private void ForQueryCommand()
        {
            FillDataGrid();
        }

        private void FillDataGrid()
        {
            string sqlCondition = GetSqlCondition();
            DataTable ds = new InfoManager().GetMedicineInfo(sqlCondition);
            if (ds.Rows.Count == 0)
            {
                MessageBox.Show("没有数据");
            } 
            //有数据再更新
            else
            {
                Medicines = new ObservableCollection<Medicine>();   //实例化集合
                foreach (DataRow row in ds.Rows)
                {
                    Medicine medicine = new Medicine()
                    {
                        Mno = row["mno"].ToString(),
                        Mname = row["mname"].ToString(),
                        Mmode = row["mmode"].ToString(),
                        Mefficacy = row["mefficacy"].ToString(),
                    };
                    Medicines.Add(medicine);    //添加
                }
            }


        }

        /// <summary>
        /// 生成sql命令中的条件
        /// </summary>
        /// <returns></returns>
        private string GetSqlCondition()
        {
            bool isNull = false;    //判断是否有条件
            bool isAnd = false; //判断是否有添加and，第一个条件不用
            string sqlCondition = " where ";

            if (!string.IsNullOrEmpty(Mno))
            {
                if (isAnd)
                    sqlCondition += " and ";
                isAnd = true;
                isNull = true;
                sqlCondition += "mno=" + "'" + this.Mno + "' ";
            }

            if (!string.IsNullOrEmpty(Mname))
            {
                if (isAnd)
                    sqlCondition += " and ";
                isAnd = true;
                isNull = true;
                sqlCondition += "mname=" + "'" + this.Mname + "' ";
            }

            if (!string.IsNullOrEmpty(MmodeSeleted))
            {
                if (isAnd)
                    sqlCondition += " and ";
                isAnd = true;
                isNull = true;
                sqlCondition += "mmode=" + "'" + this.MmodeSeleted + "' ";
            }

            if (!string.IsNullOrEmpty(Mefficacy))
            {
                if (isAnd)
                    sqlCondition += " and ";
                isAnd = true;
                isNull = true;
                sqlCondition += "mefficacy=" + "'" + this.Mefficacy + "' ";
            }

            if (isNull)
                return sqlCondition;
            else
                return null;
        }


        private void HandleCloseWindowMessage(CloseWindowMessage message)
        {
            //处理窗口返回值
            bool dialogResult = message.MedicineView_DialogResult;
            //根据返回值做出响应
            if(dialogResult)
            {
                FillDataGrid(); //更新一下列表
            }
        }
        public override void Cleanup()
        {
            Messenger.Default.Unregister(this);
            base.Cleanup();
        }

        #endregion
    }
    }
