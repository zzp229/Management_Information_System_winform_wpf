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
        /// 通过Mno获取全部
        /// </summary>
        /// <param name="Mno"></param>
        /// <returns></returns>
        public static Medicine GetMedicineByMno(string Mno)
        {
            string sql = "select * from medicine where mno=@Mno;";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@Mno", Mno)
            };
            DataSet ds = SQLHelper.GetDataSet(sql, sqlParameters);
            DataRow dr = ds.Tables[0].Rows[0];
            Medicine medicine = new Medicine()
            {
                Mno = Convert.ToString(dr["mno"]),
                Mname = Convert.ToString(dr["mname"]),
                Mmode = Convert.ToString(dr["mmode"]),
                Mefficacy = Convert.ToString(dr["mefficacy"])
            };
            return medicine;
        }


        /// <summary>
        /// 更新表中的数据
        /// </summary>
        /// <param name="medicine"></param>
        /// <returns></returns>
        public static int UpdateMedicineByMno(Medicine medicine)
        {
            string sql = "update medicine set mname=@mname, mmode=@mmode, mefficacy=@mefficacy where mno=@mno";

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
