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
    internal class AgencyManager
    {
        /// <summary>
        /// 获取
        /// </summary>
        /// <param name="Ano"></param>
        /// <returns></returns>
        public static Agency GetAgencyByAno(string Ano)
        {
            string sql = "select * from agency where ano=@Ano";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Ano", Ano)
            };
            DataSet ds = SQLHelper.GetDataSet(sql, parameters);

            DataRow dr = ds.Tables[0].Rows[0];
            Agency agency = new Agency()
            {
                Aname = Convert.ToString(dr["aname"]).Trim(),    //之前没有Trim删掉空白
                Ano = Convert.ToString(dr["ano"]).Trim(),
                Aphone = Convert.ToString(dr["aphone"]).Trim(),
                Aremark = Convert.ToString(dr["aremark"]).Trim(),
                Asex = Char.Parse(dr["asex"].ToString()),
            };

            return agency;
        }


        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="Ano"></param>
        /// <returns></returns>
        public static int DelAgencyByAno(string Ano)
        {
            string sql = "delete from agency where ano = @Ano;";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Ano", Ano)
            };
            return SQLHelper.Update(sql, parameters);
        }


        /// <summary>
        /// 编辑更新
        /// </summary>
        /// <param name="agency"></param>
        /// <returns></returns>
        public static int UpdateAgencyByAno(Agency agency)
        {
            string sql = "update agency set aname=@aname, asex=@asex, aphone=@aphone, aremark=@aremark where ano = @ano;";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@ano", agency.Ano),
                new SqlParameter("@aname", agency.Aname),
                new SqlParameter("@asex", agency.Asex),
                new SqlParameter("@aphone", agency.Aphone),
                new SqlParameter("@aremark", agency.Aremark),
            };

            return SQLHelper.Update(sql, sqlParameters );
        }
    }
}
