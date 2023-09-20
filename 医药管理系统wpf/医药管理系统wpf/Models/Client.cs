using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 医药管理系统wpf.Models
{
    public class Client
    {
        public Client()
        {
            Cdate = DateTime.Now;
        }

        private string cno;
        private string cname;
        private char csex;
        private int cage;
        private string caddress;
        private string cphone;
        private string csymptom;
        private string mno;
        private string ano;
        private DateTime cdate;
        private string cremark;



        public string Cno { get => cno; set => cno = value; }
        public string Cname { get => cname; set => cname = value; }
        public char Csex { get => csex; set => csex = value; }
        public int Cage { get => cage; set => cage = value; }
        public string Caddress { get => caddress; set => caddress = value; }
        public string Cphone { get => cphone; set => cphone = value; }
        public string Csymptom { get => csymptom; set => csymptom = value; }
        public string Mno { get => mno; set => mno = value; }
        public string Ano { get => ano; set => ano = value; }
        public DateTime Cdate { get => cdate; set => cdate = value; }
        public string Cremark { get => cremark; set => cremark = value; }
    }
}
