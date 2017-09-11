﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OverloadedTriples
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 20;
            string message = "Go Team!";
            Triple(num);
            Triple(message);
            Console.ReadLine();
        }

        public static void Triple(int num)
        {
            const int MULT_FACTOR = 3;
            Console.WriteLine("{0} times {1} is {2}\n", num, MULT_FACTOR, num * MULT_FACTOR);
        }

        private static void Triple(string message)
        {
            Console.WriteLine("{0}\t{0}\t{0}", message);
        }
    }
}
