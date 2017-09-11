using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckZips
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] zips = { 67133, 67002, 67101, 67201, 67276, 67208, 67106, 67207, 67277, 67210 };
            int zip = 0;
            bool inArea = false;

            Console.Write("Enter a your zip code: ");
            zip = Convert.ToInt32(Console.ReadLine());

            for (int x = 0; x < 10; x++)
            {
                if (zip == zips[x])
                {
                    inArea = true;
                    break;
                }
            }

            if (inArea == true)
                Console.WriteLine("Your zip code is within our delivery range.");
            else
                Console.WriteLine("We're sorry, we cannot deliver to your zip code.");
            Console.ReadLine();
        }
    }
}
