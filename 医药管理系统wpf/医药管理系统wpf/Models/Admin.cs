using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 医药管理系统wpf.Models
{
    public class Admin
    {
        //登录ID
        public string LoginId { get; set; }
        //登录名称
        public string LoginName { get; set; }
        //登录密码
        public string LoginPwd { get; set; }
        //角色
        public int Role { get; set; }
    }
}
