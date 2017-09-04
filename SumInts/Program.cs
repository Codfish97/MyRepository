using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumInts
{
    class Program
    {
        static void Main(string[] args)
        {
            const int end = 999;
            int input = 0;
            int sum = 0;

            while (input != end)
            {
                Console.WriteLine("Enter a number, enter 999 to end");
                input = Convert.ToInt32(Console.ReadLine());
                sum += input;
            }
            Console.WriteLine("The total of all the numbers entered is " + (sum - 999));
            Console.ReadLine();
        }
    }
}
