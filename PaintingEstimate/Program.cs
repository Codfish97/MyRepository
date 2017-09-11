using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintingEstimate
{
    class Program
    {
        static void Main(string[] args)
        {
            //hey there
            double width = 0;
            double length = 0;
            double price = 0;

            Console.Write("What is the width of the room? ");
            width = Convert.ToInt32(Console.ReadLine());

            Console.Write("What is the length of the room? ");
            length = Convert.ToInt32(Console.ReadLine());

            price = getPrice(width, length);

            Console.WriteLine("The price to paint the whole room is $" + price);

            Console.ReadLine();
        }

        public static double getPrice(double x, double y)
        {
            double PRICE = (((x * 9) * 2) + ((y * 9) * 2)) * 6;
            return PRICE;
        }
    }
}
