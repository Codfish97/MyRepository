using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            string message = "";
            Console.WriteLine("Enter a number 1-5");
            input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1:
                    message = "You entered 1";
                    break;
                case 2:
                    message = "You entered 2";
                    break;
                case 3:
                    message = "You entered 3";
                    break;
                case 4:
                    message = "You entered 4";
                    break;
                case 5:
                    message = "You entered 5";
                    break;
                default:
                    message = "You did not enter a number from 1 to 5!";
                    break;
            }

            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
