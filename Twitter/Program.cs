using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "";
            const int max = 140;

            Console.WriteLine("TWITTER");
            Console.WriteLine();
            Console.Write("Enter your message: ");
            message = Console.ReadLine();

            if (message.Length > max)
                Console.WriteLine("Your message exceeds more than 140 characters!");
            else
                Console.WriteLine("Your message is within the 140 character limit.");
            Console.ReadLine();
        }
    }
}
