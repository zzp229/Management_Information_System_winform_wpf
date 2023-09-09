using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using 医药管理系统wpf.Models;
using 医药管理系统wpf.ViewModels.Manager;
using 医药管理系统wpf.Views;
using 医药管理系统wpf.ViewModels.UserViewsModelView;

namespace 医药管理系统wpf.ViewModels
{
    internal class FrmView_AgencyViewModel:ViewModelBase
    {
        public FrmView_AgencyViewModel()
        {
            Asex = new ObservableCollection<string>();
            Asex.Add("男");
            Asex.Add("女");

            QueryCommand = new RelayCommand(FillDataGrid);
            DelCommand = new RelayCommand<string>(t =>Del(t));
            EditCommand = new RelayCommand<string>(t=>Edit(t));
        }


        #region 属性
        private string ano;
        public string Ano
        {
            get { return ano; }
            set { ano = value; RaisePropertyChanged(); }
        }

        private string aphone;
        public string Aphone
        {
            get { return aphone; }
            set { aphone = value; RaisePropertyChanged(); }
        }


        private string aname;
        public string Aname
        {
            get { return aname; }
            set { aname = value; RaisePropertyChanged(); }
        }

        private string aremark;
        public string Aremark
        {
            get { return aremark; }
            set { aremark = value; RaisePropertyChanged(); }
        }

        private ObservableCollection<string> asex;
        public ObservableCollection<string> Asex
        {
            get { return asex; }
            set { asex = value; RaisePropertyChanged(); }
        }


        private ObservableCollection<Agency> agencies;
        public ObservableCollection<Agency> Agencies
        {
            get { return agencies; }
            set { agencies = value; RaisePropertyChanged(); }
        }

        private string asexSeleted; //这个是选择了的性别
        public string AsexSeleted
        {
            get { return asexSeleted; }
            set { asexSeleted = value; }
        }
        #endregion



        #region Command
        public RelayCommand QueryCommand{ get; set; }
        public RelayCommand<string> DelCommand { get; set; }
        public RelayCommand<string> EditCommand { get; set; }
        #endregion



        /// <summary>
        /// 将数据写入DataGrid
        /// </summary>
        private void FillDataGrid()
        {
            string sqlCondition = GetSqlCondition();
            DataTable ds = new InfoManager().GetAgencyInfo(sqlCondition);
            if (ds.Rows.Count == 0)  //没有查询到数据
            {
                MessageBox.Show("没有内容");
                return;
            }

            Agencies = new ObservableCollection<Agency>();  //实例化集合，这个不能直接添加集合
            foreach (DataRow row in ds.Rows)
            {
                Agency agency1 = new Agency()
                {
                    Aname = row["aname"].ToString(),
                    Ano = row["ano"].ToString(),
                    Aphone = row["aphone"].ToString(),
                    Aremark = row["aremark"].ToString(),
                    Asex = char.Parse(row["asex"].ToString())
                };
                Agencies.Add(agency1);
                
            }
        }


        /// <summary>
        /// 生成sql命令中的条件
        /// </summary>
        /// <returns></returns>
        private string GetSqlCondition()
        {
            bool isNull = false;    //判断是否有条件
            bool isAnd = false; //判断是否有添加
            string sqlCondition = " where ";

            if(!string.IsNullOrEmpty(Ano))
            {
                if (isAnd)
                    sqlCondition += " and ";
                isAnd = true;
                isNull = true;
                sqlCondition += "ano=" + "'" + this.Ano + "' ";
            }

            if (!string.IsNullOrEmpty(Aname))
            {
                if (isAnd)
                    sqlCondition += " and ";
                isAnd = true;
                isNull = true;
                sqlCondition += "aname=" + "'" + this.Aname + "' ";
            }

            if (!string.IsNullOrEmpty(AsexSeleted))
            {
                if (isAnd)
                    sqlCondition += " and ";
                isAnd = true;
                isNull = true;
                sqlCondition += "asex=" + $"'{this.AsexSeleted}' ";
            }

            if (!string.IsNullOrEmpty(Aphone))
            {
                if (isAnd)
                    sqlCondition += " and ";
                isAnd = true;
                isNull = true;
                sqlCondition += "aphone=" + "'" + this.Aphone + "' ";
            }

            if (!string.IsNullOrEmpty(Aremark))
            {
                if (isAnd)
                    sqlCondition += " and ";
                isAnd = true;
                isNull = true;
                sqlCondition += "aremark=" + "'" + this.Aremark + "' ";
            }

            if (isNull)
                return sqlCondition;
            else
                return null;
        }

        /// <summary>
        /// 删除那一行
        /// </summary>
        /// <param name="Ano"></param>
        private void Del(string Ano)
        {
            AgencyManager.DelAgencyByAno(Ano);
            FillDataGrid(); //更新一下列表
        }


        /// <summary>
        /// 调出窗口编辑
        /// </summary>
        /// <param name="Ano"></param>
        private void Edit(string Ano)
        {
            Agency agency = AgencyManager.GetAgencyByAno(Ano);
            AgencyView agencyView = new AgencyView(agency);
            //绑定ViewModel
            agencyView.ShowDialog();

        }
    }
}
