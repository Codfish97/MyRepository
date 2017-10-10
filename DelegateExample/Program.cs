using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    public delegate string Hello(int a, int b);

    class Program
    {
        static string MethodDel(int num1, int num2)
        {
            if (num1 >= num2)
                return "Greater Than";
            else
                return "Less Than";
        }

        static void Main(string[] args)
        {
            Hello del_Obj = new Hello(MethodDel);
            Console.Write("Please enter 1st number ");
            int x1 = Int32.Parse(Console.ReadLine());
            Console.Write("Please enter 2nd number ");
            int x2 = Int32.Parse(Console.ReadLine());

            string res = del_Obj(x1, x2);
            Console.WriteLine("The 1st number is {0} the 2nd number", res);
            Console.ReadLine();
        }
    }
}
