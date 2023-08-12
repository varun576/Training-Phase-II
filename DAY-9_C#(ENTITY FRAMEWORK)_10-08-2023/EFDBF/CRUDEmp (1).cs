using EFDBF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDBF
{
    internal class CRUDEmp
    {
        public void InsertRecords()
        {
            using (var context = new EmployeeMgmtContext())
            {
               

                var emp = new Emp()
                {
                    Empno = 123,
                    Empname = "Suriya",
                    Deptno = 1
                };
                context.Emps.Add(emp);
                context.SaveChanges();


            }
        }
        public void UpdateRecords()
        {
            var context = new EmployeeMgmtContext();
            var selectedEmp = context.Emps.FirstOrDefault(d => d.Deptno == 1);
            selectedEmp.Empname = "Suriyalakshmi";
            context.SaveChanges();
        }
        public void DeleteRecord()
        {
            var context = new EmployeeMgmtContext();

            var selectedEmp = context.Depts.FirstOrDefault(d => d.Deptno == 1);
            context.Depts.Remove(selectedEmp);
            context.SaveChanges();
        }
        
    }
}
