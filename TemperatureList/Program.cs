using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureList
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] temps;
            temps = new int[7];
            int avg = 0;
            int total = 0;
            int diff = 0;
            string updown = "";

            for (int x = 0; x < 7; x++)
            {
                Console.WriteLine("Enter a temperature for day " + (x + 1));
                temps[x] = Convert.ToInt32(Console.ReadLine());
                total += temps[x];
            }

            Console.Clear();
            avg = total / 7;
            Console.WriteLine("The average temperature for the week is " + avg + " degrees.");
            Console.WriteLine();

            for (int y = 0; y < 7; y++)
            { 
                diff = avg - temps[y];
                if (diff < 0)
                {
                    updown = "above";
                    diff *= -1;
                }
                else if (diff > 0)
                    updown = "below";

                if (diff != 0)
                    Console.WriteLine("The temperature for day " + (y + 1) + " is " + temps[y] + " degrees.\n   This day's temperature is " + diff + " degrees " + updown + " average.\n");
                else
                    Console.WriteLine("The temperature for day " + (y + 1) + " is " + temps[y] + " degrees.\n   This day's temperature is average.\n");

            }
            Console.ReadLine();
        }
    }
}
