using System;
using System.Collections.Generic;
using System.Text;

namespace _1042022
{
    class Departament
    {
        public string Name;
        public int EmployeeLimit;
        public double SalaryLimit;
        public Departament(string name,int employeeLimit,double salarylimit)
        {
            Name = name;
            EmployeeLimit = employeeLimit;
            SalaryLimit = salarylimit;
        }
    }
}
