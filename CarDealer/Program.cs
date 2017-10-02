using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer
{
    class Program
    {
        class Car
        {
            public int year { get; set; }
            public string make { get; set; }
            public string model { get; set; }
            public string color { get; set; }
        }

        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.year = 2006;
            myCar.make = "Scion";
            myCar.model = "xB";
            myCar.color = "White";

            Console.WriteLine("My car is a {0} {1} {2} in {3}", myCar.year, myCar.make, myCar.model, myCar.color);
            Console.ReadLine();
        }
    }
}
