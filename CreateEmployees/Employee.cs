using System;

namespace CreateEmployees
{
    class Employee
    {
        public int IdNumber { get; set; }

        public double Salary { get; set; }
        public Employee()
        {
            IdNumber = 999;
            Salary = 0;
        }
        public Employee(int empId)
        {
            IdNumber = empId;
            Salary = 0;
        }
        public Employee(int empId, double sal)
        {
            IdNumber = empId;
            Salary = sal;
        }
        public Employee(char code)
        {
            IdNumber = 111;
            Salary = 100000;
        }

    }
}
