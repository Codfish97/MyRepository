using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateTwoBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            Book myBook = new Book();
            Book yourBook = new Book();
            myBook.Title = "Silas Marner";
            yourBook.Title = "The Time Traveler's Wife";
            myBook.AdvertisingMessage();
            yourBook.AdvertisingMessage();
            Console.ReadLine();
        }
    }
}
