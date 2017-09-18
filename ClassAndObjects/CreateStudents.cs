using System;

namespace ClassAndObjects
{
    class Student
    {
        private double gradePointAverage;

        public const double HIGHEST_GPA = 4.0;
        public const double LOWEST_GPA = 0.0;

        public int IdNumber { get; set; }
        public string LastName { get; set; }
        public double GradePointAverage
        {
            get { return gradePointAverage; }
            set
            {
                if (value >= LOWEST_GPA && value <= HIGHEST_GPA)
                    gradePointAverage = value;
                else
                    gradePointAverage = LOWEST_GPA;
            }
        }

        public static void Display(Student stu)
        {
            Console.WriteLine("{0, 5} {1, -10}{2, 6}", stu.IdNumber, stu.LastName, stu.GradePointAverage.ToString("F1"));
        }
    }
}