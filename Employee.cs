using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task_6
{
    internal struct Employee
    {
        private int EmpId;
        private string Name;
        private Decimal Salary;
        public Employee(int empid, string name, decimal salary)
        {
            EmpId = empid;
            Name = name;
            Salary = salary;
        }
        public string GetName()
        {
            return Name;
        }
        public void SetName(string name)
        {
            Name = name;
        }
        public int empId
        {
            get         { return EmpId; }
            private set { EmpId = value; } 
        }
        public decimal salary
        {
            get { return Salary; }
            private set { Salary = value; }
        }

    }
}
