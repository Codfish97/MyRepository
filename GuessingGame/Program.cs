using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 1;
            int max = 11;
            int guess = 0;

            Random ranNumberGenerator = new Random();
            int randomNumber;
            randomNumber = ranNumberGenerator.Next(min, max);

            Console.WriteLine("Guess a number between 1 and 10");
            guess = Convert.ToInt32(Console.ReadLine());

            while (guess != randomNumber)
            {
                if (guess < min)
                {
                    Console.WriteLine("Your guess must be higher than 0, guess again");
                    guess = Convert.ToInt32(Console.ReadLine());
                }
                else if (guess > max)
                {
                    Console.WriteLine("Your guess must be lower than 10, guess again");
                    guess = Convert.ToInt32(Console.ReadLine());
                }

                if (guess < randomNumber)
                {
                    Console.WriteLine("Your guess was too low, guess again");
                    guess = Convert.ToInt32(Console.ReadLine());
                }

                else if (guess > randomNumber)
                {
                    Console.WriteLine("Your guess is too high, guess again");
                    guess = Convert.ToInt32(Console.ReadLine());
                }

                if (guess == randomNumber)
                    Console.WriteLine("CORRECT! Congratulations");
            }
            Console.ReadLine();
        }
    }
}
