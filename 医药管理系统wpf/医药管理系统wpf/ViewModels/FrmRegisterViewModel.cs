using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using 医药管理系统wpf.Service;

namespace 医药管理系统wpf.ViewModels
{
    internal class FrmRegisterViewModel:ViewModelBase
    {
        public FrmRegisterViewModel()
        {
            //初始化下拉框列表
            RoleList = new List<string>
            {
                "医生",
                "患者",
                "访客"
            };
            RoleSeleted = "患者";

            //测试
            //实例化Command
            CloseWindowCommand = new RelayCommand<object>(t => CloseWindow(t));
        }


        #region 属性
        private string loginName;
        public string LoginName
        {
            get { return loginName; }
            set { loginName = value; }
        }

        private string loginId;

        public string LoginId
        {
            get { return loginId; }
            set { loginId = value; }
        }

        private string loginPwd;

        public string LoginPwd
        {
            get { return loginPwd; }
            set { loginPwd = value; }
        }

        private List<string> roleList;

        public List<string> RoleList
        {
            get { return roleList; }
            set { roleList = value; }
        }

        private string roleSeleted;

        public string RoleSeleted
        {
            get { return roleSeleted; }
            set { roleSeleted = value; }
        }
        #endregion


        #region Command
        public RelayCommand RegisterCommand { get; set; }
        public RelayCommand<object> CloseWindowCommand { get; set; }
        #endregion


        #region Method
        
        /// <summary>
        /// 点击按钮后关闭窗口
        /// </summary>
        /// <param name="parameter"></param>
        private void CloseWindow(object parameter)
        {
            //关闭前将数据写入数据库
            InsertToSql();
            
            //关闭窗口
            var window = parameter as Window;
            if (window != null)
            {
                window.Close();
            }
        }


        /// <summary>
        /// 数据写入数据库
        /// </summary>
        private void InsertToSql()
        {
            string sql = "insert into users values(@LoginId, @LoginPwd, @LoginName, @Role);";
            int role = 0;
            if (RoleSeleted == RoleList[0])
            {
                role = 0;
            }
            else if (RoleSeleted == RoleList[1])
            {
                role = 1;
            }
            else
            {
                role = 3;
            }
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@LoginId", LoginId),
                new SqlParameter("@LoginPwd", LoginPwd),
                new SqlParameter("@LoginName", LoginName),
                new SqlParameter("@Role", role)
            };


            int tmp = SQLHelper.Update(sql, sqlParameters);
            if (tmp > 0)
            {
                MessageBox.Show("添加成功！");
            }
        }
        #endregion
    }
}
