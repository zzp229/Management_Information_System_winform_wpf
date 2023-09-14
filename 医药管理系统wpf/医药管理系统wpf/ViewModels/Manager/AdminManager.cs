using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 医药管理系统wpf.Models;
using 医药管理系统wpf.Service;

namespace 医药管理系统wpf.ViewModels.Manager
{
    internal class AdminManager
    {
        
        public static Admin currentAdmin { get; set; } = new Admin();

        /// <summary>
        /// 通过LoginId获取整个Admin
        /// </summary>
        /// <param name="id"></param>
        public static Admin GetAdminById(string id)
        {
            string sql = "select * from users where LoginId = @LoginId;";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@LoginId", id)
            };

            DataSet ds = SQLHelper.GetDataSet(sql, parameters);

            DataRow dr = ds.Tables[0].Rows[0];

            Admin admin = new Admin()
            {
                LoginId = dr["LoginId"].ToString(),
                LoginName = dr["LoginName"].ToString(),
                LoginPwd = dr["LoginPwd"].ToString(),
                Role = int.Parse(dr["Role"].ToString())
            };

            return admin;
        }


        public static int DelAdminByLoginId()
        {
            string sql = "delete from users where LoginId = @LoginId;";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@LoginId", currentAdmin.LoginId),
            };

            int res = SQLHelper.Update(sql, sqlParameters);
            return res;
        }
    }
}
