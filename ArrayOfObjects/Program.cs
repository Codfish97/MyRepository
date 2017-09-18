using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[8];
            int x;
            int id;
            string name;
            double gpa;

            for (x = 0; x < students.Length; ++x)
            {
                Student.GetData(out id, out name, out gpa);
                students[x] = new Student(id, name, gpa);
            }

            Array.Sort(students);
            Console.WriteLine("Sorted List: ");
            for (x = 0; x < students.Length; ++x)
                Student.Display(students[x]);

            Console.ReadLine();
        }

    }
}
