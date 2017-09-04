using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarshallsMurals
{
    class Program
    {
        static void Main(string[] args)
        {
            const int interiorMural = 500;
            const int exteriorMural = 750;
            int interior = 0;
            int exterior = 0;
            int total = 0;

            Console.WriteLine("Welcome to Marshall's!");
            Console.WriteLine("How many interior murals would you like to be painted?");
            interior = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many exterior murals would you like to be painted?");
            exterior = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            total = (interior * interiorMural) + (exterior + exteriorMural);

            Console.WriteLine("The total revenue from all the murals painted this month is $" + total + ".00.");

            if (interior > exterior)
                Console.WriteLine("There were more interior murals painted than exterior murals.");
            else if (exterior > interior)
                Console.WriteLine("There were more exterior murals painted than interior murals.");
            else
                Console.WriteLine("There were exactly the same amount of interior and exterior murals painted, " + exterior + " of each were painted.");
            Console.ReadLine();
        }
    }
}
