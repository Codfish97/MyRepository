using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingOverloadedConstructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Student first = new Student();
            Student second = new Student();
            Student third = new Student(456, "Marco", 2.4);
            Student fourth = new Student();
            first.IdNumber = 123;
            first.LastName = "Anderson";
            first.GradePointAverage = 3.5;
            second.IdNumber = 789;
            second.LastName = "Daniels";
            second.GradePointAverage = 4.1;

            Student.Display(first);
            Student.Display(second);
            Student.Display(third);
            Student.Display(fourth);

            Console.ReadLine();
        }
    }
}
