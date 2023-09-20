using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using 医药管理系统wpf.Models;
using 医药管理系统wpf.ViewModels.Manager;

namespace 医药管理系统wpf.ViewModels
{
    internal class FrmView_ClientViewModel:ViewModelBase
    {
        public FrmView_ClientViewModel()
        {
            CsexSource = new ObservableCollection<char>()
            {
                '男', '女'
            };

            QueryCommand = new RelayCommand(FillDataGrid);
        }


        #region 属性
        private string cno;
        /// <summary>
        /// 编号
        /// </summary>
        public string Cno
        {
            get { return cno; }
            set { cno = value; RaisePropertyChanged(); }
        }

        private string cname;
        /// <summary>
        /// 姓名
        /// </summary>
        public string Cname
        {
            get { return cname; }
            set { cname = value; RaisePropertyChanged(); }
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

        private ObservableCollection<char> csexSource;
        /// <summary>
        /// 性别的集合
        /// </summary>
        public ObservableCollection<char> CsexSource
        {
            get { return csexSource; }
            set { csexSource = value; RaisePropertyChanged(); }
        }

        private int cage;
        /// <summary>
        /// 年龄
        /// </summary>
        public int Cage
        {
            get { return cage; }
            set { cage = value; RaisePropertyChanged(); }
        }

        private string cphone;
        /// <summary>
        /// 电话
        /// </summary>
        public string Cphone
        {
            get { return cphone; }
            set { cphone = value; RaisePropertyChanged(); }
        }

        private string caddress;
        /// <summary>
        /// 地址
        /// </summary>
        public string Caddress
        {
            get { return caddress; }
            set { caddress = value; RaisePropertyChanged(); }
        }

        private string csymptom;
        /// <summary>
        /// 症状
        /// </summary>
        public string Csymptom
        {
            get { return csymptom; }
            set { csymptom = value; RaisePropertyChanged(); }
        }

        private string mno;
        /// <summary>
        /// 已购药品
        /// </summary>
        public string Mno
        {
            get { return mno; }
            set { mno = value; RaisePropertyChanged(); }
        }

        private string ano;
        /// <summary>
        /// 经办人
        /// </summary>
        public string Ano
        {
            get { return ano; }
            set { ano = value; RaisePropertyChanged(); }
        }

        private string cremark;
        /// <summary>
        /// 备注
        /// </summary>
        public string Cremark
        {
            get { return cremark; }
            set { cremark = value; RaisePropertyChanged(); }
        }

        private DateTime cdate;
        /// <summary>
        /// 录入日期
        /// </summary>
        public DateTime Cdate
        {
            get { return cdate; }
            set { cdate = value; RaisePropertyChanged(); }
        }

        private ObservableCollection<Client> clients;
        /// <summary>
        /// 顾客
        /// </summary>
        public ObservableCollection<Client> Clients
        {
            get { return clients; }
            set { clients = value; RaisePropertyChanged(); }
        }

        #endregion



        #region Command
        public RelayCommand QueryCommand { get; set; }
        public RelayCommand<string> DelCommand { get; set; }
        public RelayCommand<string> EditCommand { get; set; }
        #endregion



        #region Method
        /// <summary>
        /// 生成sql命令中的条件
        /// </summary>
        /// <returns></returns>
        private string GetSqlCondition()
        {
            bool isNull = false;    //判断是否有条件
            bool isAnd = false; //判断是否有添加and，第一个条件不用
            string sqlCondition = " where ";

            if (!string.IsNullOrEmpty(Cno))
            {
                if (isAnd)
                    sqlCondition += " and ";
                isAnd = true;
                isNull = true;
                sqlCondition += "ano=" + "'" + this.Cno + "'";
            }

            if (!string.IsNullOrEmpty(this.Cname))
            {
                if (isAnd)
                    sqlCondition += " and ";
                isAnd = true;
                isNull = true;
                sqlCondition += "Cname=" + "'" + this.Cname + "'";
            }

            if (CsexSeleted != default)
            {
                if (isAnd)
                    sqlCondition += " and ";
                isAnd = true;
                isNull = true;
                sqlCondition += "Csex=" + "'" + this.CsexSeleted + "'";
            }

            if (!string.IsNullOrEmpty(Caddress))
            {
                if (isAnd)
                    sqlCondition += " and ";
                isAnd = true;
                isNull = true;
                sqlCondition += "Caddress=" + "'" + this.Caddress + "'";
            }

            if (!string.IsNullOrEmpty(Cphone))
            {
                if (isAnd)
                    sqlCondition += " and ";
                isAnd = true;
                isNull = true;
                sqlCondition += "Cphone=" + "'" + this.Cphone + "'";
            }

            if (!string.IsNullOrEmpty(Csymptom))
            {
                if (isAnd)
                    sqlCondition += " and ";
                isAnd = true;
                isNull = true;
                sqlCondition += "Csymptom=" + "'" + this.Csymptom + "'";
            }

            if (!string.IsNullOrEmpty(Mno))
            {
                if (isAnd)
                    sqlCondition += " and ";
                isAnd = true;
                isNull = true;
                sqlCondition += "Mno=" + "'" + this.Mno + "'";
            }

            if (!string.IsNullOrEmpty(Ano))
            {
                if (isAnd)
                    sqlCondition += " and ";
                isAnd = true;
                isNull = true;
                sqlCondition += "Ano=" + "'" + this.Ano + "'";
            }

            if (!string.IsNullOrEmpty(Cremark))
            {
                if (isAnd)
                    sqlCondition += " and ";
                isAnd = true;
                isNull = true;
                sqlCondition += "Cremark=" + "'" + this.Cremark + "'";
            }

            //日期和年龄
            if (Cage != default)
            {
                if (isAnd)
                    sqlCondition += " and ";
                isAnd = true;
                isNull = true;
                sqlCondition += "Cage=" + this.Cage;
            }

            if (Cdate != default)
            {
                if (isAnd)
                    sqlCondition += " and ";
                isAnd = true;
                isNull = true;
                sqlCondition += "Cdate=" + this.Cdate;
            }

            if (isNull)
                return sqlCondition;
            else
                return null;

            //test

            
        }


        private void FillDataGrid()
        {
            string sqlCondition = GetSqlCondition();
            //DataTable ds = new InfoManager().GetAgencyInfo(sqlCondition);
            DataTable ds = new InfoManager().GetClientInfo(sqlCondition);
            if (ds.Rows.Count == 0)  //没有查询到数据
            {
                MessageBox.Show("没有内容");
                return;
            }

            Clients = new ObservableCollection<Client>();   //初始化顾客集合
            foreach (DataRow row in ds.Rows)
            {
                Client client = new Client()
                {
                    //Cno = Convert.ToString(row["cno"]),
                    Cno = row["cno"].ToString(),
                    Cname = Convert.ToString(row["cname"]),
                    Csex = Char.Parse(row["csex"].ToString()),
                    Cage = int.Parse(row["cage"].ToString()),
                    Caddress = Convert.ToString(row["caddress"]),
                    Cphone = Convert.ToString(row["cphone"]),
                    Csymptom = Convert.ToString(row["csymptom"]),
                    Mno = Convert.ToString(row["mno"]),
                    Ano = Convert.ToString(row["ano"]),
                    Cdate = DateTime.Parse(row["cdate"].ToString()),
                    Cremark = Convert.ToString(row["cremark"])
                };
                clients.Add(client);
            }
        }
        #endregion
        }
}
