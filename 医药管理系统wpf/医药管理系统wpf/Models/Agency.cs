using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 医药管理系统wpf.Models
{
    public class Agency
    {
        private string ano;
        private string aname;
        private char asex;
        private string aphone;
        private string aremark;



        public string Ano { get => ano; set => ano = value; }
        public string Aname { get => aname; set => aname = value; }
        public char Asex { get => asex; set => asex = value; }
        public string Aphone { get => aphone; set => aphone = value; }
        public string Aremark { get => aremark; set => aremark = value; }
    }
}
