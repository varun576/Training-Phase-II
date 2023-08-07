using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class College
    {
        private string? clgName, clgAddress;

        public College(string? clgName, string? clgAddress)
        {
            this.clgName = clgName;
            this.clgAddress = clgAddress;
        }

        public string? ClgName { get => clgName; set => clgName = value; }
        public string? ClgAddress { get => clgAddress; set => clgAddress = value; }

        public void DisplayclgDetails()
        {
            Console.WriteLine(clgName);
            Console.WriteLine(clgAddress);
        }
    }
}
