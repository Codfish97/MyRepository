using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateEmployees
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee aWorker = new Employee();
            Employee anotherWorker = new Employee(234);
            Employee theBoss = new Employee('A');

            Console.WriteLine("{0, 4}{1, 14}", aWorker.IdNumber,aWorker.Salary.ToString("C")); 
            Console.WriteLine("{0, 4}{1, 14}", anotherWorker.IdNumber, anotherWorker.Salary.ToString("C")); 
            Console.WriteLine("{0, 4}{1, 14}", theBoss.IdNumber, theBoss.Salary.ToString("C"));

            Console.ReadLine();

        }
    }
}
