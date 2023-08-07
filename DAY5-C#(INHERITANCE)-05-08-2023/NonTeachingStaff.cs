using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class NonTeachingStaff:StaffDetails
    {
        private double basicsalary;

        private readonly int _da, _hra, _cca, _pf;

        public double Basicsalary { get => basicsalary; set => basicsalary = value; }

        public int Da => _da;

        public int Hra => _hra;

        public int Cca => _cca;

        public int Pf => _pf;

        public NonTeachingStaff(int rno, string? name, string? address,double basicsalary,int da,int hra,int cca,int pf) : base(rno, name, address)
        {
            this.basicsalary = basicsalary;
            _da = rno;
            _hra = hra;
            _cca = cca;
            _pf = pf;

        }
        public float CalcualateSalary()
        {
            float netsal = (float)((Basicsalary * (Da / 100)) + (Basicsalary * (Hra / 100)) + (Basicsalary * (Cca / 100)) -(Basicsalary * (Pf / 100)));
            return netsal;

        }
    }
}
