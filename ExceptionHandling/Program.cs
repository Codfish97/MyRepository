using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            int milesDriven;
            int gallonsOfGas;
            int mpg;

            try
            {
                Console.WriteLine("Enter miles driven ");
                milesDriven = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter gallons of gas purchased ");
                gallonsOfGas = Convert.ToInt32(Console.ReadLine());
                mpg = milesDriven / gallonsOfGas;
            }

            catch(Exception e)
            {
                mpg = 0;
                Console.WriteLine("You attempted to divide by zero!");
            }

            Console.WriteLine("You got {0} miles per gallon", mpg);
            Console.ReadLine();
        }
    }
}
