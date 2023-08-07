using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class TeachingStaff : StaffDetails
    {
        private string? dept;
        private double basicsalary;
        private readonly int _da, _hra, _cca, _pf;

        public TeachingStaff(int rno,string name,string address,string? dept, double basicsalary, int da, int hra, int cca, int pf) : base(rno, name, address)
        {
            this.dept = dept;
            this.basicsalary = basicsalary;
            _da = da;
            _hra = hra;
            _cca = cca;
            _pf = pf;
        }

        public string? Dept { get => dept; set => dept = value; }
        public double Basicsalary { get => basicsalary; set => basicsalary = value; }

        public int Da => _da;

        public int Hra => _hra;

        public int Cca => _cca;

        public int Pf => _pf;

         public float CalcualateSalary()
        {
            float netsal;
            float app = (float)(basicsalary * (Da / 100)) + (float)(basicsalary * (Hra / 100)) + (float)(basicsalary * (Cca / 100));
            float red = (float)(basicsalary * (Pf / 100));
            return netsal = app-red;

        }
    }
}
