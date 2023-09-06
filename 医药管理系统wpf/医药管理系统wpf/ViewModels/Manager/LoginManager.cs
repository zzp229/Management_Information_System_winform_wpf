using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 医药管理系统wpf.Models;
using 医药管理系统wpf.Service;

namespace 医药管理系统wpf.ViewModels.Manager
{
    /// <summary>
    /// 用户登录的枚举类型
    /// </summary>
    public enum UserState
    {
        Ok,
        NoExist,
        PwdError
    }

    /// <summary>
    /// 登录管理类
    /// </summary>
    public class LoginManager
    {
        /// <summary>
        /// 验证是否有这个账号和密码是否正确
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public UserState CheckIdPwd(Admin user)
        {
            //改为params的试试
            string sql = "select * from users where LoginId = @tmp;";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@tmp", user.LoginId),
            };
            DataSet dataSet = SQLHelper.GetDataSet(sql, parameters);

            //先判断是否有这个账号
            if (dataSet.Tables[0].Rows.Count == 0)
            {
                return UserState.NoExist;
            }

            //判断密码是否正确
            string pwdFromSql = dataSet.Tables[0].Rows[0]["LoginPwd"].ToString();
            if (pwdFromSql != user.LoginPwd)
            {
                return UserState.PwdError;
            }

            //全部正确，可以登录
            return UserState.Ok;
        }



        /// <summary>
        /// 获取这个用户的完整信息，包括角色和名称
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public Admin GetAdmin(Admin user)
        {
            string sql = "select * from users where LoginId = @tmp;";

            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@tmp", user.LoginId),
            };
            DataSet dataSet = SQLHelper.GetDataSet(sql, sqlParameters);

            user.LoginName = dataSet.Tables[0].Rows[0]["LoginName"].ToString();
            user.Role = int.Parse(dataSet.Tables[0].Rows[0]["Role"].ToString());
            return user;
        }


        /// <summary>
        /// 新账户
        /// </summary>
        /// <param name="user"></param>
        /// <returns>返回影响的条数</returns>
        public int NewRole(Admin user)
        {
            string sql = "insert into users values(@tmp1, @tmp2, @tmp3, @tmp4);";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@tmp1", user.LoginId),
                new SqlParameter("@tmp2", user.LoginName),
                new SqlParameter("@tmp3", user.LoginPwd),
                new SqlParameter("@tmp4", user.Role)
            };
            return SQLHelper.Update(sql, sqlParameters);
        }



        /// <summary>
        /// 在数据库中删除这个账号
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public int DeleteAcount(Admin user)
        {
            string sql = "delete from users where LoginId = @id";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@id", user.LoginId),
            };
            return SQLHelper.Update(sql, sqlParameters);
        }
    }
}
