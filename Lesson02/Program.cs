using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02
{
    class Rectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public double getArea()
        {
            return Length * Width;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle { Length = 10.0, Width = 20.0};
            double area = rect.getArea();
            Console.WriteLine("The area of Rectangle: {0}",  area);

            Console.ReadLine();
        }
    }
}
