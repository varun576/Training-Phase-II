using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class StudentMark : StaticDemo
    {
        private int m1, m2, m3;
        public StudentMark(int rno, string name, string address1,int m1, int m2, int m3) : base(rno,name,address1)
        {
            this.m1 = m1;
            this.m2 = m2;
                this.m3 = m3;
        }

        public int M1 { get => m1; set => m1 = value; }
        public int M2 { get => m2; set => m2 = value; }
        public int M3 { get => m3; set => m3 = value; }

        public int calculateTotal()
        {
            return m1+m2+m3;
        }

        public int calculateAvg()
        {
            return (m1 + m2 + m3)/3;
        }
    }
}
