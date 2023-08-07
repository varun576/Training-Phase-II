using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class StudentGrade : StudentMark
    {
        public StudentGrade(int rno, string name, string address1, int m1, int m2, int m3) : base(rno, name, address1, m1, m2, m3)
        {
            this.Rno = rno;
            this.Name = name;
            this.Addressl = address1;
            this.M1 = m1;
            this.M2 = m2;
            this.M3 = m3;

        }

        public char avg()
        {
            double total =calculateAvg();
            if (total > 90)
                return 'O';
            else if (total > 80 && total < 90)
                return 'A';
            else return 'B';
        }

    }
}
