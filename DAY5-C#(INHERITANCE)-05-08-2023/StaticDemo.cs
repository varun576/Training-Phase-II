using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ConsoleApp1
{
    internal class StaticDemo : College
    {
        private int rno;
        private string? name, addressl;

        public int Rno { get => rno; set => rno = value; }
        public string? Name { get => name; set => name = value; }
        public string? Addressl { get => addressl; set => addressl = value; }
        public StaticDemo(int rno, string? name, string? addressl):base()
        {
            this.rno = rno;
            this.name = name;
            this.addressl = addressl;
        }

    }
}
