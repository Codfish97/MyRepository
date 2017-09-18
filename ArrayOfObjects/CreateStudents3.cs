using System;

namespace ArrayOfObjects
{
    class Student : IComparable
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

        public Student(int id, string name, double gpa)
        {
            IdNumber = id;
            LastName = name;
            GradePointAverage = gpa;
        }

        public Student()
            : this(0, "XXX", 0.0)
        { }

        public static void GetData(out int id, out string name, out double gpa)
        {
            string inString;

            Console.Write("Please enter student ID number >> ");
            inString = Console.ReadLine();
            int.TryParse(inString, out id);

            Console.Write("Please enter last name for student {0} >> ", id);
            name = Console.ReadLine();

            Console.Write("Please enter a grade point average >> ");
            inString = Console.ReadLine();
            double.TryParse(inString, out gpa);
        }

        int IComparable.CompareTo(Object o)
        {
            int returnVal;
            Student temp = (Student)o;
            if (this.IdNumber > temp.IdNumber)
                returnVal = 1;
            else
                if (this.IdNumber < temp.IdNumber)
                    returnVal = -1;
                else
                    returnVal = 0;
            return returnVal;
        }
    }
}