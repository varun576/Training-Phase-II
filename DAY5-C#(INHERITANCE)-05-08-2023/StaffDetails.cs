using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class StaffDetails:College
    {
        private int rno;
        private string? name,address;

        public StaffDetails(int rno, string name, string address)
        {
            this.rno = rno;
            this.name = name;
            this.address = address;
        }

        public StaffDetails(string clgName,string clgAddress,int rno, string? name, string? address):base(clgName,clgAddress)
        {

            this.Rno = rno;
            this.Name = name;
            this.Address = address;
        }

        public int Rno { get => rno; set => rno = value; }
        public string? Name { get => name; set => name = value; }
        public string? Address { get => address; set => address = value; }
    }
}
