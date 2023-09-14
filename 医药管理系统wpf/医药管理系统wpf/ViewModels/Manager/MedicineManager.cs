using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 医药管理系统wpf.Models;
using 医药管理系统wpf.Service;

namespace 医药管理系统wpf.ViewModels.Manager
{
    internal class MedicineManager
    {
        /// <summary>
        /// 增添药品
        /// </summary>
        /// <param name="medicine"></param>
        /// <returns></returns>
        public static int InsertMedicine(Medicine medicine)
        {
            string sql = "insert into medicine values(@mno, @mname, @mmode, @mefficacy);";

            return SQLHelper.Update(sql, GetParameters(medicine));
        }


        /// <summary>
        /// 获取medicine参数
        /// </summary>
        /// <param name="medicine"></param>
        /// <returns></returns>
        private static SqlParameter[] GetParameters(Medicine medicine)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@mno", medicine.Mno),
                new SqlParameter("@mname", medicine.Mname),
                new SqlParameter("@mmode", medicine.Mmode),
                new SqlParameter("@mefficacy", medicine.Mefficacy)
            };

            return parameters;
        }
    }
}
