using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrays: an array is a collection of items in which each item can be accessed by uing a unique index
            int[] numbers = { 1, 2, 3, 4, 5 };
            Console.WriteLine("The value at numbers index 2 is " + numbers[2]);

            //Switch: a switch statement allows multi-way branching. In many cases, using a switch statement can simplifiy a complex combination of if-else statements.
            int op1 = 10;
            int op2 = 20;
            int result = 0;
            char opr = '+';

            switch (opr)
             {
                 case '+':
                     result = op1 + op2;
                     break;
                 case '-':
                     result = op1 - op2;
                     break;
                 case '*':
                     result = op1 * op2;
                     break;
                 case '/':
                     result = op1 / op2;
                     break;
                 default:
                     Console.WriteLine("Unknown Operator");
                     break;
             }

            Console.WriteLine("{0} {1} {2} is {3}", op1, opr, op2, result);

            //Methods: Methods are code blocks containing a series of statements. Methods can recieve input via arguments and can return a value to the caller.
            //Recursion: Recursion is a programming technique that causes a method to call itself in order to computer a result
            Console.WriteLine("Calling Factorial(5) results in " + Factorial(5));

            //Try/Catch: Try Catch will try blocks of code and will catch exceptions and process a seperate code block to inform the user of the problem
            ExceptionTest();

            Console.ReadLine();

        }

        public static int Factorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * Factorial(n - 1);
        }

        public static void ExceptionTest()
        {
            System.IO.StreamReader sr = null;

            try
            {
                sr = System.IO.File.OpenText(@"c:\data.txt");
                Console.WriteLine(sr.ReadToEnd());
            }
            catch (System.IO.FileNotFoundException fnfe)
            {
                Console.WriteLine(fnfe.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
