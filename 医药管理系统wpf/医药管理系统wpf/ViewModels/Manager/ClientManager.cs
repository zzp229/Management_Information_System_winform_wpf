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
    internal class ClientManager
    {

        /// <summary>
        /// 通过编号获取顾客名称
        /// </summary>
        /// <param name="cno"></param>
        /// <returns></returns>
        internal static Client GetClientByCno(string cno)
        {
            string sql = "select * from client where cno=@cno;";

            //传过来的就是参数
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@cno", cno)
            };

            DataSet ds = SQLHelper.GetDataSet(sql, parameters);
            DataRow dr = ds.Tables[0].Rows[0];
            Client client = new Client()
            {
                Cno = Convert.ToString(dr["cno"]).Trim(),
                Cname = Convert.ToString(dr["cname"]).Trim(),
                Csex = Char.Parse(dr["csex"].ToString()),
                Cage = int.Parse(dr["cage"].ToString()),
                Caddress = Convert.ToString(dr["caddress"]).Trim(),
                Cphone = Convert.ToString(dr["cphone"]).Trim(),
                Csymptom = Convert.ToString(dr["csymptom"]).Trim(),
                Ano = Convert.ToString(dr["ano"]).Trim(),
                Cdate = DateTime.Parse(dr["cdate"].ToString()),
                Cremark = Convert.ToString(dr["cremark"]).Trim(),
            };

            return client;
        }


       


        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="cno"></param>
        /// <returns></returns>
        public static int DelClientByCno(string cno)
        {
            string sql = "delete from client where cno = @cno;";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@cno", cno)
            };

            return SQLHelper.Update(sql, parameters);
        }


        /// <summary>
        /// 编辑更新
        /// </summary>
        /// <param name="agency"></param>
        /// <returns></returns>
        public static int UpdateClientByAno(Client client)
        {
            string sql = "update agency set cname=@cname, csex=@csex, cage=@cage, caddress=@caddress, cphone=@cphone, " +
                "csymptom=@csymptom, mno=@mno, ano=@ano, cdate=@cdate cremark=@cremark where cno = @cno;";

            return SQLHelper.Update(sql, GetParameters(client));
        }

        /// <summary>
        /// 插入
        /// </summary>
        /// <param name="agency"></param>
        /// <returns></returns>
        public static int InSertClient(Client client)
        {
            string sql = "insert into client values(@cno, @cname, @csex, @cage, @caddress, @cphone, @csymptom, @mno, @ano, @cdate, @cno);";

            return SQLHelper.Update(sql, GetParameters(client));
        }


        //获取参数用
        private static SqlParameter[] GetParameters(Client client)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@cno", client.Cno),
                new SqlParameter("@cname", client.Cname),
                new SqlParameter("@csex", client.Csex),
                new SqlParameter("@cage", client.Cage),
                new SqlParameter("@caddress", client.Caddress),
                new SqlParameter("@cphone", client.Cphone),
                new SqlParameter("@csymptom", client.Csymptom),
                new SqlParameter("@mno", client.Mno),
                new SqlParameter("@ano", client.Ano),
                new SqlParameter("@cdate", client.Cdate),
                new SqlParameter("@cremark", client.Cremark),
            };

            return sqlParameters;
        }
    }
}
