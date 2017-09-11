using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            string fortune = getFortune();

            Console.Write("Press enter to recieve your fortune");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(fortune);
            Console.ReadLine();
        }

        public static string getFortune()
        {
            string[] fortune = { "You will have great luck in the near future", 
                                   "Great wealth will come upon you within the week", 
                                   "You will encounter an old friend and spark a new relationship", 
                                   "Those you least expect will soon come to betray you", 
                                   "Those you least expect will soon come to enter a deeper relationship with you", 
                                   "Your current relationships are in grave danger if no action is taken soon"};

            Random ranNumberGenerator = new Random();
            int randomNumber;
            randomNumber = ranNumberGenerator.Next(0, 6);

            string FORTUNE = fortune[randomNumber];
            return FORTUNE;
        }
    }
}
