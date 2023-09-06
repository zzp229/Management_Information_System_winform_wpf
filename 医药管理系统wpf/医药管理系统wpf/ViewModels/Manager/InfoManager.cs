using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 医药管理系统wpf.Service;

namespace 医药管理系统wpf.ViewModels.Manager
{
    public class InfoManager
    {
        public DataTable GetClientInfo()
        {
            //这里只是测试
            string sql = "select * from client;";
            DataTable dt = SQLHelper.GetDataSet(sql).Tables[0];

            return dt;
        }

        public DataTable GetAgencyInfo(string sqlCondition)
        {
            //
            string sql = "select * from agency" + sqlCondition;
            return SQLHelper.GetDataSet(sql).Tables[0];
        }

        public DataTable GetMedicineInfo(string sqlCondition)
        {
            string sql = "select * from medicine" + sqlCondition;
            return SQLHelper.GetDataSet(sql).Tables[0];
        }
    }
}
