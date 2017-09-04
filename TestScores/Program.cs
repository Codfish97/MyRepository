using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestScores
{
    class Program
    {
        static void Main(string[] args)
        {
            const int END = -1;
            const int MIN = 0;
            const int MAX = 100;
            int inputScore = 0;
            int numScores = 0;
            int totalScores = 0;
            int avgScores = 0;

            while (inputScore != END)
            {
                Console.WriteLine("Enter a test score from 0 to 100");
                inputScore = Convert.ToInt32(Console.ReadLine());

                if (inputScore < MIN && inputScore != -1)
                {
                    Console.WriteLine("The score you entered was lower than 0, enter your score again");
                    inputScore = Convert.ToInt32(Console.ReadLine());
                }

                else if (inputScore > MAX)
                {
                    Console.WriteLine("The score you entered was higher than 100, enter your score again");
                    inputScore = Convert.ToInt32(Console.ReadLine());
                }

                numScores++;
                totalScores += inputScore;
            }
            totalScores += 1;
            numScores -= 1;
            avgScores = totalScores / numScores;

            Console.WriteLine("The total number of scores entered was " + numScores + ", the average of the scores is " + avgScores);
            Console.ReadLine();
        }
    }
}
